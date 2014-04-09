using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using ASAPAutomation.DataTypes;
using gfoidl.Windows.Forms;

namespace ASAPAutomation
{
    public partial class MainForm : Form
    {
        #region Properties
        public static gfDataGridView DataGrid { get; set; }
        public static gfDataGridView TransactionGrid { get; set; }
        private WebBrowserForm browser;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();

            ClickListeners();
            FocusListeners();
            
            // Double Buffer DataGridView
            typeof(gfDataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
            BindingFlags.Instance | BindingFlags.SetProperty, null,
            dataGrid, new object[] { true });

            DataGrid = dataGrid;
            TransactionGrid = transactionGridView;

            // Get Connection to DB
            SQLiteDatabase.Initialize();

            // Start Browser
            browser = new WebBrowserForm();

            Task<DataTable> t1 = Task<DataTable>.Factory.StartNew(() => SQLiteDatabase.FillWorklistGrid());
            MainForm.DataGrid.DataSource = t1.Result;
            // Populate Grid
            //SQLiteDatabase.FillWorklistGrid();
        }
        #endregion

        #region Mouse Click Events
        private void DataGridViewContextMenu(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            CheckedListBox mCheckedListBox = new CheckedListBox();
            mCheckedListBox.CheckOnClick = true;
            mCheckedListBox.ItemCheck += (s, ev) =>
                dataGrid.Columns[ev.Index].Visible = (ev.NewValue == CheckState.Checked);

            foreach (DataGridViewColumn col in dataGrid.Columns)
                mCheckedListBox.Items.Add(col.HeaderText, col.Visible);

            ToolStripControlHost mControlHost = new ToolStripControlHost(mCheckedListBox);

            // Handle Popup
            ToolStripDropDown mPopup = new ToolStripDropDown();
            mPopup.Items.Add(mControlHost);
            mPopup.Show(Cursor.Position);
        }
        private void ClickListeners()
        {
            dataGrid.SelectionChanged += (s, e) =>
            {
                if (DataGrid.SelectedRows.Count > 0)
                {
                    descriptionRichTextBox.Text = SQLiteDatabase
                    .GetLongText(dataGrid.SelectedRows[0].Cells[4].Value.ToString(), "Description");
                    summaryNotesRichTextBox.Text = SQLiteDatabase
                    .GetLongText(dataGrid.SelectedRows[0].Cells[4].Value.ToString(), "Summary Text");
                    progressReportRichTextBox.Text = SQLiteDatabase
                    .GetLongText(dataGrid.SelectedRows[0].Cells[4].Value.ToString(), "Progress Report Text");
                    formalAnswerRichTextBox.Text = SQLiteDatabase
                    .GetLongText(dataGrid.SelectedRows[0].Cells[4].Value.ToString(), "Formal Answer");
                    overviewRichTextBox.Text = SQLiteDatabase
                    .GetLongText(dataGrid.SelectedRows[0].Cells[4].Value.ToString(), "Overview");
                    
                    transactionsDetailsRichTextBox.ResetText();
                    SQLiteDatabase.FillTransactionGrid(DataGrid.SelectedRows[0].Cells[4].Value.ToString());
                }
            };
            
            transactionGridView.SelectionChanged += (s,e) =>
            {
                if (transactionGridView.SelectedRows.Count > 0)
                    transactionsDetailsRichTextBox.Text = 
                        transactionGridView.SelectedCells[7].Value.ToString();
            };
        }

        private void FocusListeners()
        {try{
                descriptionRichTextBox.LostFocus += (s, a) =>
                    SQLiteDatabase.SetLongText(dataGrid.SelectedRows[0].Cells[4].Value.ToString(),
                    CsrPropertyTabs.SelectedTab.Text, (s as RichTextBox).Text);
                summaryNotesRichTextBox.LostFocus += (s, a) =>
                    SQLiteDatabase.SetLongText(dataGrid.SelectedRows[0].Cells[4].Value.ToString(),
                    CsrPropertyTabs.SelectedTab.Text, (s as RichTextBox).Text);
                progressReportRichTextBox.LostFocus += (s, a) =>
                    SQLiteDatabase.SetLongText(dataGrid.SelectedRows[0].Cells[4].Value.ToString(),
                    CsrPropertyTabs.SelectedTab.Text, (s as RichTextBox).Text);
            }catch (ArgumentOutOfRangeException){}
        }
        #endregion

        private void filter_Click(object sender, EventArgs e)
        {
            
        }
    }
}
