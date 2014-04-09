using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using mshtml;
using System.Net;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using ASAPAutomation.DataTypes;
using ASAPAutomation.Controls;


namespace ASAPAutomation
{
    public partial class WebBrowserForm : Form
    {
        #region Constants
        #region URI
        private const string BLANK_PAGE = "https://p40sap.ss.sw.ericsson.se:8380/sap(bD1lbiZjPTQ1MCZkPW1pbg==)/bc/bsp/sap/crm_ui_start/startIE7.htm";
        private const string ROLE_SELECT = "https://p40sap.ss.sw.ericsson.se:8380/sap(bD1lbiZjPTQ1MCZkPW1pbg==)/bc/bsp/sap/crm_ui_start/default.htm?sap-client=450&sap-language=EN";
        private const string DOWNLOAD_WORKLIST = "https://p40sap.ss.sw.ericsson.se/sap({0})/webcuif/uif_export_tab?method=csv&iId={1}";
        private const string RVI_URL = "https://rvi.ericsson.net/index.php?erica";
        #endregion
        #region PAGE TITLES
        private const string HOME = "SAP - [Home]";
        private const string LOGIN = "Ericsson CRM - Logon";
        private const string LOGIN_CHECK = "Logon Status Check";
        private const string ROLE = "SAP - [Select a business role: ]";
        private const string WORKLIST = "SAP - [Worklist]";
        private const string OVERVIEW = "CSR Overview]";
        private const string NAV_CANCELED = "Navigation Canceled";
        #endregion
        #region Error Messages
        private const string CONNECTION_ERROR = "Hey! Check your internet connection!";
        private const string RVI_ERROR = "You aren't connected to internal, let me get that for you.";
        private const string CALL_HELP = "Hmm, I'm not sure what happened, go call for help, hurry.";
        private const string MANUAL_LOGIN = "Try Logging In Manually";
        private const string CLICK_LOGIN = "Would you mind logging in by clicking the button?";
        private const string CLICK_LOGIN_TITLE = "Give me a hand please";
        private const string SOMETHING_WRONG = "Oops, somethings wrong";
        private const string SILLY = "Silly You";
        #endregion

        /* Editable Fields
         * Slogan
         * Ext. Ref
         * Comments
        */

        /* Dropdown (Choice fields)
         * Severity
         * Status
         * Csr Type
         * Issue Category
         * Cost Allocation
         * Cause Code
         * Csr Origin
         * 
         */

        /* Special Lookups
         * Contact Person
         * Region SPOC
         */

        #endregion

        #region Initialize
        public WebBrowserForm()
        {
            InitializeComponent();
            Text = "SMS Browser";
            Enabled = false;
            Visible = true;
        }
        #endregion

        #region SMS Startup
        private void Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.Equals(BLANK_PAGE))
            {
                e.Cancel = true;
                smsBrowser.Stop();
                smsBrowser.Navigate(ROLE_SELECT);
                smsBrowser.Navigating -= Navigating;
            }
        }
        private void Document_Complete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (smsBrowser.DocumentTitle == HOME)
                smsBrowser.DocumentCompleted -= Document_Complete;
            else
            {
                if (smsBrowser.DocumentTitle == LOGIN)
                {
                    if (Properties.Settings.Default.Username != string.Empty)
                    {
                        // Maybe the password was changed...
                        if (smsBrowser.Document.GetElementById("m1-txt") == null)
                        {
                            smsBrowser.Document.GetElementById("sap-user").SetAttribute("value", Properties.Settings.Default.Username);
                            smsBrowser.Document.GetElementById("sap-password")
                                .SetAttribute("value", Properties.Settings.Default.Password);
                            smsBrowser.Document.GetElementById("SL__FORM").InvokeMember("submit");
                        }
                        else
                        {
                            Visible = true;
                            Enabled = true;
                            HtmlElement loginButton = smsBrowser.Document.GetElementById("LOGON_BUTTON");
                            loginButton.AttachEventHandler("onclick", (s, a) => OnClick(loginButton, EventArgs.Empty));
                            MessageBox.Show(SOMETHING_WRONG, MANUAL_LOGIN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        Visible = true;
                        Enabled = true;
                        HtmlElement loginButton = smsBrowser.Document.GetElementById("LOGON_BUTTON");
                        loginButton.AttachEventHandler("onclick", (s, a) => OnClick(loginButton, EventArgs.Empty));
                        MessageBox.Show(CLICK_LOGIN, CLICK_LOGIN_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (smsBrowser.DocumentTitle == LOGIN_CHECK)
                    smsBrowser.GoBack();
                else if (smsBrowser.DocumentTitle == ROLE)
                {
                    if (Properties.Settings.Default.RoleId != string.Empty)
                        smsBrowser.Document
                            .GetElementById(Properties.Settings.Default.RoleId)
                            .InvokeMember("Click");
                    else
                    {
                        Visible = true;
                        Enabled = true;

                        foreach (HtmlElement node in smsBrowser.Document.Links)
                        {
                            node.AttachEventHandler("onclick", (s, a) => OnClick(node, EventArgs.Empty));
                        }
                    }
                    smsBrowser.DocumentCompleted -= Document_Complete;
                }
                else if (smsBrowser.DocumentTitle == NAV_CANCELED)
                {
                    try
                    {
                        using (var client = new WebClient())
                        using (var stream = client.OpenRead("http://www.google.com"))
                        {
                            if (MessageBox.Show(RVI_ERROR, SILLY, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                System.Diagnostics.Process.Start("iexplore.exe", RVI_URL);
                        }
                    }
                    catch (System.Net.WebException)
                    { MessageBox.Show(CONNECTION_ERROR); }
                    catch { MessageBox.Show(CALL_HELP); }
                }
            }
        }
        private void OnHomeLoad(object sender, EventArgs e)
        {
            if (smsBrowser.Document.Title == HOME)
            {
                smsBrowser.DocumentTitleChanged -= OnHomeLoad;
                GoToWorklist();
            }
        }
        private void OnClick(object s, EventArgs args)
        {
            if ((s as HtmlElement).Id == "LOGON_BUTTON")
            {
                Properties.Settings.Default.Username = smsBrowser.Document.GetElementById("sap-user").GetAttribute("value");
                Properties.Settings.Default.Password = smsBrowser.Document.GetElementById("sap-password").GetAttribute("value");
            }
            else if ((s as HtmlElement).Id.StartsWith("ZSMSCSRAGENT"))
            {
                Properties.Settings.Default.Role = (s as HtmlElement).InnerText;
                Properties.Settings.Default.RoleId = (s as HtmlElement).Id;
            }
            Visible = false;
            Enabled = false;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Get Worklist
        public void GoToWorklist()
        {
            smsBrowser.DocumentTitleChanged += WaitForWorklist;
            smsBrowser.ClickWorklist();
        }
        Worklist worklist;
        private void WaitForWorklist(object s, EventArgs e)
        {
            if (smsBrowser.DocumentTitle == WORKLIST)
            {
                smsBrowser.DocumentTitleChanged -= WaitForWorklist;
                var wait = new EventWaitHandle(false, EventResetMode.AutoReset);
                HtmlElementEventHandler handler = null;
                handler = new HtmlElementEventHandler((sender, ev) =>
                {
                    ev.BubbleEvent = false;
                    smsBrowser.Doc.Focusing -= handler;

                    worklist = new Worklist();
                    worklist.Load(smsBrowser.GetWorklistCsv());

                    SQLiteDatabase.InsertWorklist(worklist);
                    SQLiteDatabase.Commit();
                    Task<DataTable> t2 = Task<DataTable>.Factory.StartNew(() => SQLiteDatabase.FillWorklistGrid());
                    MainForm.DataGrid.DataSource = t2.Result;
                    //SQLiteDatabase.FillWorklistGrid();

                    //wait.Set();
                });

                smsBrowser.Doc.Focusing += handler;

                smsBrowser.ClickSearch();

                //wait.WaitOne();
            }
        }
        
        #endregion

/*        #region Get All Notes

        public void StartSync(List<string> csrs)
        {
            if (smsBrowser.DocumentTitle == WORKLIST)
            {
                csrNums = csrs;
                SearchForIndividualCsr();
            }
            else
                GoToWorklist();
        }
        private void SearchForIndividualCsr()
        {
            if (csrNums.Count == 0)
            {// Done Parsing
                SQLiteDatabase.Commit();
                SQLiteDatabase.FillWorklistGrid();

                if (MainForm.DataGrid.SelectedRows.Count > 0)
                    SQLiteDatabase.FillTransactionGrid(MainForm
                        .DataGrid.SelectedRows[0].Cells[4].Value.ToString());

                smsBrowser.ClickReset();
                return;
            }
            string csr = csrNums.First();
            csrNums.Remove(csr);

            smsBrowser.DocumentTitleChanged += FrameTitleChanged;
            smsBrowser.DocumentTitleChanged += DetailsLoaded;

            freezeShield = smsBrowser.Document.GetElementById("th_freezeShield");
            onLoadFinish = new EventHandler((a, b) => OnLoadFinish(freezeShield, EventArgs.Empty));
            freezeShield.AttachEventHandler("onpropertychange", onLoadFinish);

            smsBrowser.SetCsrNumberAndClick(csr);
        }
        private void OnLoadFinish(object s, EventArgs e)
        {
            if ((s as HtmlElement).Style.Contains("DISPLAY: none") && smsBrowser.DocumentTitle == WORKLIST)
            {
                smsBrowser.DocumentTitleChanged -= FrameTitleChanged;
                smsBrowser.Doc.Focusing -= OnWorklistSingleLoad;

                smsBrowser.ClickCsr();
            }
            else if (smsBrowser.DocumentTitle != WORKLIST)
                freezeShield.DetachEventHandler("onpropertychange", onLoadFinish);
        }
        private void OnWorklistSingleLoad(object s, HtmlElementEventArgs e) { e.BubbleEvent = false; }

        private void FrameTitleChanged(object sender, EventArgs e)
        {
            if (smsBrowser.DocumentTitle == WORKLIST)
            {
                smsBrowser.Doc.Focusing += OnWorklistSingleLoad;

                if (csrNums != null && csrNums.Count != 0)
                {
                    string csr = csrNums.First();
                    csrNums.Remove(csr);
                    SearchForIndividualCsr();
                }
            }
        }
        Csr details;
        private void DetailsLoaded(object sender, EventArgs e)
        {
            if (!smsBrowser.DocumentTitle.EndsWith(OVERVIEW))
            {
                details = new Csr();
                details.ParseDetails(smsBrowser.Doc);



                smsBrowser.DocumentTitleChanged -= DetailsLoaded;
                smsBrowser.DocumentTitleChanged += OverviewLoaded;

                smsBrowser.CancelAndForward();
            }
        }

        #endregion*/

        #region Synchronize
        private List<string> csrNums;
        HtmlElement freezeShield;
        EventHandler onLoadFinish;

        public void StartSync()
        {
            if (smsBrowser.DocumentTitle == WORKLIST)
            {
                csrNums = worklist.Ids;
                //csrNums = new List<string>() { "2478283" };
                SearchForIndividualCsr();
            }
            else
                GoToWorklist();
        }
        public void StartSync(List<string> csrs)
        {
            if (smsBrowser.DocumentTitle == WORKLIST)
            {
                csrNums = csrs;
                SearchForIndividualCsr();
            }
            else
                GoToWorklist();
        }
        private void SearchForIndividualCsr()
        {
            if (csrNums.Count == 0)
            {// Done Parsing
                SQLiteDatabase.Commit();

                Task<DataTable> t3 = Task<DataTable>.Factory.StartNew(() => SQLiteDatabase.FillWorklistGrid());
                MainForm.DataGrid.DataSource = t3.Result; 
                //SQLiteDatabase.FillWorklistGrid();

                if (MainForm.DataGrid.SelectedRows.Count > 0 && MainForm.DataGrid.SelectedRows.Count < 2)
                    SQLiteDatabase.FillTransactionGrid(MainForm
                        .DataGrid.SelectedRows[0].Cells[4].Value.ToString());

                smsBrowser.ClickReset();
                return;
            }
            string csr = csrNums.First();
            csrNums.Remove(csr);

            smsBrowser.DocumentTitleChanged += FrameTitleChanged;
            smsBrowser.DocumentTitleChanged += DetailsLoaded;

            freezeShield = smsBrowser.Document.GetElementById("th_freezeShield");
            onLoadFinish = new EventHandler((a, b) => OnLoadFinish(freezeShield, EventArgs.Empty));
            freezeShield.AttachEventHandler("onpropertychange", onLoadFinish);

            smsBrowser.SetCsrNumberAndClick(csr);
        }
        private void OnLoadFinish(object s, EventArgs e)
        {
            if ((s as HtmlElement).Style.Contains("DISPLAY: none") && smsBrowser.DocumentTitle == WORKLIST)
            {
                smsBrowser.DocumentTitleChanged -= FrameTitleChanged;
                smsBrowser.Doc.Focusing -= OnWorklistSingleLoad;

                smsBrowser.ClickCsr();
            }
            else if (smsBrowser.DocumentTitle != WORKLIST)
                freezeShield.DetachEventHandler("onpropertychange", onLoadFinish);
        }
        private void OnWorklistSingleLoad(object s, HtmlElementEventArgs e) { e.BubbleEvent = false; }

        #region Page Events
        private void FrameTitleChanged(object sender, EventArgs e)
        {
            if (smsBrowser.DocumentTitle == WORKLIST)
            {
                smsBrowser.Doc.Focusing += OnWorklistSingleLoad;

                if (csrNums != null && csrNums.Count != 0)
                {
                    string csr = csrNums.First();
                    csrNums.Remove(csr);
                    SearchForIndividualCsr();
                }
            }
        }
        Csr details;
        private void DetailsLoaded(object sender, EventArgs e)
        {
            if (!smsBrowser.DocumentTitle.EndsWith(OVERVIEW))
            {
                details = new Csr();
                details.ParseDetails(smsBrowser.Doc);



                smsBrowser.DocumentTitleChanged -= DetailsLoaded;
                smsBrowser.DocumentTitleChanged += OverviewLoaded;

                smsBrowser.CancelAndForward();
            }
        }

        public void ReportTime(string hours, string minutes, string startDate, string startTime)
        {
            var timeRep = smsBrowser.Doc.All.Cast<HtmlElement>().First(x => x.Id != null && x.Id.EndsWith("_srvttimerep.do"));
            var inputs = timeRep.GetElementsByTagName("input");

            var hourBox = inputs.Cast<HtmlElement>().First(x => x.Id != null && x.Id.Contains("_timerecvalue_hours"));
            hourBox.SetAttribute("value", hours);
            hourBox.RaiseEvent("onchange");
            hourBox.RaiseEvent("onkeydown");

            var minBox = inputs.Cast<HtmlElement>().First(x => x.Id != null && x.Id.Contains("_timerecvalue_minutes"));
            minBox.SetAttribute("value", minutes);
            minBox.RaiseEvent("onchange");
            minBox.RaiseEvent("onkeydown");

            var dateBox = inputs.Cast<HtmlElement>().First(x => x.Id != null && x.Id.Contains("_timerecvalue_startdate"));
            dateBox.SetAttribute("value", startDate);
            dateBox.RaiseEvent("onchange");
            dateBox.RaiseEvent("onkeydown");

            var timeBox = inputs.Cast<HtmlElement>().First(x => x.Id != null && x.Id.Contains("_timerecvalue_starttime"));
            timeBox.SetAttribute("value", startTime);
            timeBox.RaiseEvent("onchange");
            timeBox.RaiseEvent("onkeydown");
            
            var addButton = timeRep.GetElementsByTagName("a").Cast<HtmlElement>().First(x => x.Id != null && x.Id.EndsWith("_bAdd"));
            addButton.InvokeMember("Click");
        }

        private EventHandler onTimeEntered;
        private void OnTimeEntered(object s, EventArgs a)
        {
            freezeShield.DetachEventHandler("onpropertychange", onTimeEntered);
        }

        private void OverviewLoaded(object sender, EventArgs e)
        {
            if (smsBrowser.DocumentTitle.EndsWith(OVERVIEW))
            {
                smsBrowser.DocumentTitleChanged -= OverviewLoaded;
                smsBrowser.DocumentTitleChanged += NavigateBackEvent;

                details.ParseOverview(smsBrowser.Doc);

                smsBrowser.ClickBack();
            }
        }
        private void NavigateBackEvent(object sender, EventArgs e)
        {
            if (smsBrowser.DocumentTitle == WORKLIST)
            {
                smsBrowser.DocumentTitleChanged -= NavigateBackEvent;
                SearchForIndividualCsr();
            }
            else
                smsBrowser.CancelAndBack();

        }
        #endregion
        #endregion
    }
}