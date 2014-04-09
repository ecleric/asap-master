using ASAPAutomation.DataTypes;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace ASAPAutomation
{
    partial class MainForm
    {
        #region Inherited Code
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGrid = new gfoidl.Windows.Forms.gfDataGridView();
            this.flags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress_updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summary_updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severity_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slogan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resp_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posting_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ericsson_resp_org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.network = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.node = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csr_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ext_reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csr_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sold_to_party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_to_remedy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_to_callback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notific_rec_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_resp_org = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attach_cnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.global_cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remedy_overdue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solution_overdue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_to_party = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changed_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gs_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unnecessary_escalation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changed_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_to_sol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csr_type_txt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hot_csr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_allocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.follow_up_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cause_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region_spoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csr_origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contract_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.installed_base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CsrPropertyTabs = new FlatTabControl.FlatTabControl();
            this.description = new System.Windows.Forms.TabPage();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.overview = new System.Windows.Forms.TabPage();
            this.overviewRichTextBox = new System.Windows.Forms.RichTextBox();
            this.progress_report = new System.Windows.Forms.TabPage();
            this.progressReportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.progressReport = new System.Windows.Forms.RichTextBox();
            this.summary_text = new System.Windows.Forms.TabPage();
            this.summaryNotesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.transaction_history = new System.Windows.Forms.TabPage();
            this.transactionsDetailsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.transactionGridView = new gfoidl.Windows.Forms.gfDataGridView();
            this.transaction_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csr_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_subtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_created_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_created_on = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaction_long_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emails = new System.Windows.Forms.TabPage();
            this.formal_answer = new System.Windows.Forms.TabPage();
            this.formalAnswerRichTextBox = new System.Windows.Forms.RichTextBox();
            this.analysis = new System.Windows.Forms.TabPage();
            this.relatedCSR = new System.Windows.Forms.TabPage();
            this.addTime = new System.Windows.Forms.TabPage();
            this.addTimeGrid = new gfoidl.Windows.Forms.gfDataGridView();
            this.timeHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip = new System.Windows.Forms.ToolStrip();
            this.Sync = new System.Windows.Forms.ToolStripSplitButton();
            this.SyncList = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateAll = new System.Windows.Forms.ToolStripButton();
            this.Email = new System.Windows.Forms.ToolStripSplitButton();
            this.Reception = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.FormalAnswerEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.filter = new System.Windows.Forms.ToolStripTextBox();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.Maximize = new System.Windows.Forms.ToolStripButton();
            this.Minimize = new System.Windows.Forms.ToolStripButton();
            this.Help = new System.Windows.Forms.ToolStripButton();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.Report = new System.Windows.Forms.ToolStripSplitButton();
            this.CsrCauseCode = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowFlagged = new System.Windows.Forms.ToolStripButton();
            this.ShowSMS = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CsrPropertyTabs.SuspendLayout();
            this.description.SuspendLayout();
            this.overview.SuspendLayout();
            this.progress_report.SuspendLayout();
            this.summary_text.SuspendLayout();
            this.transaction_history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).BeginInit();
            this.formal_answer.SuspendLayout();
            this.addTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTimeGrid)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flags,
            this.progress_updated,
            this.summary_updated,
            this.overdue,
            this.id,
            this.status,
            this.severity_text,
            this.slogan,
            this.resp_employee,
            this.posting_date,
            this.ericsson_resp_org,
            this.network,
            this.node,
            this.site,
            this.csr_category,
            this.issue_category,
            this.ext_reference,
            this.csr_type,
            this.sold_to_party,
            this.created_on,
            this.time_to_remedy,
            this.time_to_callback,
            this.notific_rec_date,
            this.cust_resp_org,
            this.contact_person,
            this.attach_cnt,
            this.global_cust,
            this.comments,
            this.contract,
            this.remedy_overdue,
            this.solution_overdue,
            this.main_category,
            this.severity,
            this.service_to_party,
            this.created_by,
            this.changed_by,
            this.gs_flag,
            this.tr_id,
            this.unnecessary_escalation,
            this.changed_on,
            this.time_to_sol,
            this.csr_type_txt,
            this.hot_csr,
            this.total_time,
            this.cost_allocation,
            this.follow_up_date,
            this.cause_code,
            this.component,
            this.region_spoc,
            this.csr_origin,
            this.contract_type,
            this.installed_base});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(980, 284);
            this.dataGrid.StandardTab = true;
            this.dataGrid.TabIndex = 9;
            this.dataGrid.VirtualMode = true;
            this.dataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewContextMenu);
            // 
            // flags
            // 
            this.flags.DataPropertyName = "flags";
            this.flags.HeaderText = "Flags";
            this.flags.Name = "flags";
            this.flags.ReadOnly = true;
            // 
            // progress_updated
            // 
            this.progress_updated.DataPropertyName = "progress_updated";
            this.progress_updated.HeaderText = "Progress Updated";
            this.progress_updated.Name = "progress_updated";
            this.progress_updated.ReadOnly = true;
            // 
            // summary_updated
            // 
            this.summary_updated.DataPropertyName = "summary_updated";
            this.summary_updated.HeaderText = "Summary Updated";
            this.summary_updated.Name = "summary_updated";
            this.summary_updated.ReadOnly = true;
            // 
            // overdue
            // 
            this.overdue.DataPropertyName = "overdue";
            this.overdue.HeaderText = "Overdue";
            this.overdue.Name = "overdue";
            this.overdue.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "CSR#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 72;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // severity_text
            // 
            this.severity_text.DataPropertyName = "severity_text";
            this.severity_text.HeaderText = "Severity";
            this.severity_text.Name = "severity_text";
            // 
            // slogan
            // 
            this.slogan.DataPropertyName = "slogan";
            this.slogan.HeaderText = "Slogan";
            this.slogan.Name = "slogan";
            // 
            // resp_employee
            // 
            this.resp_employee.DataPropertyName = "resp_employee";
            this.resp_employee.HeaderText = "Resp. Employee";
            this.resp_employee.Name = "resp_employee";
            // 
            // posting_date
            // 
            this.posting_date.DataPropertyName = "posting_date";
            this.posting_date.HeaderText = "Posting Date";
            this.posting_date.Name = "posting_date";
            // 
            // ericsson_resp_org
            // 
            this.ericsson_resp_org.DataPropertyName = "ericsson_resp_org";
            this.ericsson_resp_org.HeaderText = "Ericsson Resp Org";
            this.ericsson_resp_org.Name = "ericsson_resp_org";
            // 
            // network
            // 
            this.network.DataPropertyName = "network";
            this.network.HeaderText = "Network";
            this.network.Name = "network";
            // 
            // node
            // 
            this.node.DataPropertyName = "node";
            this.node.HeaderText = "Node";
            this.node.Name = "node";
            // 
            // site
            // 
            this.site.DataPropertyName = "site";
            this.site.HeaderText = "Site";
            this.site.Name = "site";
            // 
            // csr_category
            // 
            this.csr_category.DataPropertyName = "csr_category";
            this.csr_category.HeaderText = "CSR Category";
            this.csr_category.Name = "csr_category";
            // 
            // issue_category
            // 
            this.issue_category.DataPropertyName = "issue_category";
            this.issue_category.HeaderText = "Issue Category";
            this.issue_category.Name = "issue_category";
            // 
            // ext_reference
            // 
            this.ext_reference.DataPropertyName = "ext_reference";
            this.ext_reference.HeaderText = "Ext Reference";
            this.ext_reference.Name = "ext_reference";
            // 
            // csr_type
            // 
            this.csr_type.DataPropertyName = "csr_type";
            this.csr_type.HeaderText = "CSR Type";
            this.csr_type.Name = "csr_type";
            // 
            // sold_to_party
            // 
            this.sold_to_party.DataPropertyName = "sold_to_party";
            this.sold_to_party.HeaderText = "Sold To Party";
            this.sold_to_party.Name = "sold_to_party";
            // 
            // created_on
            // 
            this.created_on.DataPropertyName = "created_on";
            this.created_on.HeaderText = "Created On";
            this.created_on.Name = "created_on";
            // 
            // time_to_remedy
            // 
            this.time_to_remedy.DataPropertyName = "time_to_remedy";
            this.time_to_remedy.HeaderText = "Time To Remedy";
            this.time_to_remedy.Name = "time_to_remedy";
            // 
            // time_to_callback
            // 
            this.time_to_callback.DataPropertyName = "time_to_callback";
            this.time_to_callback.HeaderText = "Time To Callback";
            this.time_to_callback.Name = "time_to_callback";
            // 
            // notific_rec_date
            // 
            this.notific_rec_date.DataPropertyName = "notific_rec_date";
            this.notific_rec_date.HeaderText = "Notific Rec Date";
            this.notific_rec_date.Name = "notific_rec_date";
            // 
            // cust_resp_org
            // 
            this.cust_resp_org.DataPropertyName = "cust_resp_org";
            this.cust_resp_org.HeaderText = "Cust. Resp. Org.";
            this.cust_resp_org.Name = "cust_resp_org";
            // 
            // contact_person
            // 
            this.contact_person.DataPropertyName = "contact_person";
            this.contact_person.HeaderText = "Contact Person";
            this.contact_person.Name = "contact_person";
            // 
            // attach_cnt
            // 
            this.attach_cnt.DataPropertyName = "attach_cnt";
            this.attach_cnt.HeaderText = "Attach Cnt";
            this.attach_cnt.Name = "attach_cnt";
            // 
            // global_cust
            // 
            this.global_cust.DataPropertyName = "global_cust";
            this.global_cust.HeaderText = "Global Cust";
            this.global_cust.Name = "global_cust";
            // 
            // comments
            // 
            this.comments.DataPropertyName = "comments";
            this.comments.HeaderText = "Comments";
            this.comments.Name = "comments";
            // 
            // contract
            // 
            this.contract.DataPropertyName = "contract";
            this.contract.HeaderText = "Contract";
            this.contract.Name = "contract";
            // 
            // remedy_overdue
            // 
            this.remedy_overdue.DataPropertyName = "remedy_overdue";
            this.remedy_overdue.HeaderText = "Remedy Overdue";
            this.remedy_overdue.Name = "remedy_overdue";
            // 
            // solution_overdue
            // 
            this.solution_overdue.DataPropertyName = "solution_overdue";
            this.solution_overdue.HeaderText = "Solution Overdue";
            this.solution_overdue.Name = "solution_overdue";
            // 
            // main_category
            // 
            this.main_category.DataPropertyName = "main_category";
            this.main_category.HeaderText = "Main Category";
            this.main_category.Name = "main_category";
            // 
            // severity
            // 
            this.severity.DataPropertyName = "severity";
            this.severity.HeaderText = "Severity";
            this.severity.Name = "severity";
            // 
            // service_to_party
            // 
            this.service_to_party.DataPropertyName = "service_to_party";
            this.service_to_party.HeaderText = "Service To Party";
            this.service_to_party.Name = "service_to_party";
            // 
            // created_by
            // 
            this.created_by.DataPropertyName = "created_by";
            this.created_by.HeaderText = "Created By";
            this.created_by.Name = "created_by";
            // 
            // changed_by
            // 
            this.changed_by.DataPropertyName = "changed_by";
            this.changed_by.HeaderText = "Changed By";
            this.changed_by.Name = "changed_by";
            // 
            // gs_flag
            // 
            this.gs_flag.DataPropertyName = "gs_flag";
            this.gs_flag.HeaderText = "GS Flag";
            this.gs_flag.Name = "gs_flag";
            this.gs_flag.ReadOnly = true;
            // 
            // tr_id
            // 
            this.tr_id.DataPropertyName = "tr_id";
            this.tr_id.HeaderText = "TR#";
            this.tr_id.Name = "tr_id";
            this.tr_id.ReadOnly = true;
            // 
            // unnecessary_escalation
            // 
            this.unnecessary_escalation.DataPropertyName = "unnecessary_escalation";
            this.unnecessary_escalation.HeaderText = "Unnecessary Esc.";
            this.unnecessary_escalation.Name = "unnecessary_escalation";
            this.unnecessary_escalation.ReadOnly = true;
            // 
            // changed_on
            // 
            this.changed_on.DataPropertyName = "changed_on";
            this.changed_on.HeaderText = "Changed On";
            this.changed_on.Name = "changed_on";
            // 
            // time_to_sol
            // 
            this.time_to_sol.DataPropertyName = "time_to_sol";
            this.time_to_sol.HeaderText = "Time To Sol";
            this.time_to_sol.Name = "time_to_sol";
            // 
            // csr_type_txt
            // 
            this.csr_type_txt.DataPropertyName = "csr_type_txt";
            this.csr_type_txt.HeaderText = "Csr Type Txt";
            this.csr_type_txt.Name = "csr_type_txt";
            // 
            // hot_csr
            // 
            this.hot_csr.DataPropertyName = "hot_csr";
            this.hot_csr.HeaderText = "Hot CSR";
            this.hot_csr.Name = "hot_csr";
            // 
            // total_time
            // 
            this.total_time.DataPropertyName = "total_time";
            this.total_time.HeaderText = "Total Time";
            this.total_time.Name = "total_time";
            // 
            // cost_allocation
            // 
            this.cost_allocation.DataPropertyName = "cost_allocation";
            this.cost_allocation.HeaderText = "Cost Allocation";
            this.cost_allocation.Name = "cost_allocation";
            // 
            // follow_up_date
            // 
            this.follow_up_date.DataPropertyName = "follow_up_date";
            this.follow_up_date.HeaderText = "Follow-Up Date";
            this.follow_up_date.Name = "follow_up_date";
            // 
            // cause_code
            // 
            this.cause_code.DataPropertyName = "cause_code";
            this.cause_code.HeaderText = "Cause Code";
            this.cause_code.Name = "cause_code";
            // 
            // component
            // 
            this.component.DataPropertyName = "component";
            this.component.HeaderText = "Component";
            this.component.Name = "component";
            // 
            // region_spoc
            // 
            this.region_spoc.DataPropertyName = "region_spoc";
            this.region_spoc.HeaderText = "Region SPOC";
            this.region_spoc.Name = "region_spoc";
            // 
            // csr_origin
            // 
            this.csr_origin.DataPropertyName = "csr_origin";
            this.csr_origin.HeaderText = "CSR Origin";
            this.csr_origin.Name = "csr_origin";
            // 
            // contract_type
            // 
            this.contract_type.DataPropertyName = "contract_type";
            this.contract_type.HeaderText = "Contract Type";
            this.contract_type.Name = "contract_type";
            // 
            // installed_base
            // 
            this.installed_base.DataPropertyName = "installed_base";
            this.installed_base.HeaderText = "Installed Base";
            this.installed_base.Name = "installed_base";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 43);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGrid);
            this.splitContainer1.Panel1MinSize = 95;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CsrPropertyTabs);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(980, 573);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 44;
            // 
            // CsrPropertyTabs
            // 
            this.CsrPropertyTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CsrPropertyTabs.Controls.Add(this.description);
            this.CsrPropertyTabs.Controls.Add(this.overview);
            this.CsrPropertyTabs.Controls.Add(this.progress_report);
            this.CsrPropertyTabs.Controls.Add(this.summary_text);
            this.CsrPropertyTabs.Controls.Add(this.transaction_history);
            this.CsrPropertyTabs.Controls.Add(this.emails);
            this.CsrPropertyTabs.Controls.Add(this.formal_answer);
            this.CsrPropertyTabs.Controls.Add(this.analysis);
            this.CsrPropertyTabs.Controls.Add(this.relatedCSR);
            this.CsrPropertyTabs.Controls.Add(this.addTime);
            this.CsrPropertyTabs.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsrPropertyTabs.Location = new System.Drawing.Point(0, 1);
            this.CsrPropertyTabs.Margin = new System.Windows.Forms.Padding(0);
            this.CsrPropertyTabs.Name = "CsrPropertyTabs";
            this.CsrPropertyTabs.Padding = new System.Drawing.Point(0, 0);
            this.CsrPropertyTabs.SelectedIndex = 0;
            this.CsrPropertyTabs.Size = new System.Drawing.Size(980, 289);
            this.CsrPropertyTabs.TabIndex = 16;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.description.Controls.Add(this.descriptionRichTextBox);
            this.description.Location = new System.Drawing.Point(4, 25);
            this.description.Margin = new System.Windows.Forms.Padding(2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(972, 260);
            this.description.TabIndex = 6;
            this.description.Text = "Description";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(972, 260);
            this.descriptionRichTextBox.TabIndex = 0;
            this.descriptionRichTextBox.Text = "";
            // 
            // overview
            // 
            this.overview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.overview.Controls.Add(this.overviewRichTextBox);
            this.overview.Location = new System.Drawing.Point(4, 25);
            this.overview.Margin = new System.Windows.Forms.Padding(2);
            this.overview.Name = "overview";
            this.overview.Padding = new System.Windows.Forms.Padding(2);
            this.overview.Size = new System.Drawing.Size(972, 260);
            this.overview.TabIndex = 7;
            this.overview.Text = "Overview";
            // 
            // overviewRichTextBox
            // 
            this.overviewRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.overviewRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.overviewRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewRichTextBox.Location = new System.Drawing.Point(2, 2);
            this.overviewRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.overviewRichTextBox.MinimumSize = new System.Drawing.Size(970, 250);
            this.overviewRichTextBox.Name = "overviewRichTextBox";
            this.overviewRichTextBox.Size = new System.Drawing.Size(970, 256);
            this.overviewRichTextBox.TabIndex = 0;
            this.overviewRichTextBox.Text = "";
            // 
            // progress_report
            // 
            this.progress_report.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progress_report.Controls.Add(this.progressReportRichTextBox);
            this.progress_report.Controls.Add(this.progressReport);
            this.progress_report.Location = new System.Drawing.Point(4, 25);
            this.progress_report.Margin = new System.Windows.Forms.Padding(0);
            this.progress_report.Name = "progress_report";
            this.progress_report.Size = new System.Drawing.Size(972, 260);
            this.progress_report.TabIndex = 1;
            this.progress_report.Text = "Progress Report";
            // 
            // progressReportRichTextBox
            // 
            this.progressReportRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressReportRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressReportRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressReportRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.progressReportRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.progressReportRichTextBox.MinimumSize = new System.Drawing.Size(970, 250);
            this.progressReportRichTextBox.Name = "progressReportRichTextBox";
            this.progressReportRichTextBox.Size = new System.Drawing.Size(972, 260);
            this.progressReportRichTextBox.TabIndex = 1;
            this.progressReportRichTextBox.Text = "";
            // 
            // progressReport
            // 
            this.progressReport.AcceptsTab = true;
            this.progressReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressReport.Location = new System.Drawing.Point(2, 2);
            this.progressReport.Margin = new System.Windows.Forms.Padding(2);
            this.progressReport.Name = "progressReport";
            this.progressReport.Size = new System.Drawing.Size(0, 287);
            this.progressReport.TabIndex = 0;
            this.progressReport.Text = "";
            // 
            // summary_text
            // 
            this.summary_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.summary_text.Controls.Add(this.summaryNotesRichTextBox);
            this.summary_text.Location = new System.Drawing.Point(4, 25);
            this.summary_text.Margin = new System.Windows.Forms.Padding(0);
            this.summary_text.Name = "summary_text";
            this.summary_text.Size = new System.Drawing.Size(972, 260);
            this.summary_text.TabIndex = 2;
            this.summary_text.Text = "Summary Text";
            // 
            // summaryNotesRichTextBox
            // 
            this.summaryNotesRichTextBox.AcceptsTab = true;
            this.summaryNotesRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.summaryNotesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.summaryNotesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryNotesRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.summaryNotesRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.summaryNotesRichTextBox.MinimumSize = new System.Drawing.Size(970, 250);
            this.summaryNotesRichTextBox.Name = "summaryNotesRichTextBox";
            this.summaryNotesRichTextBox.Size = new System.Drawing.Size(972, 260);
            this.summaryNotesRichTextBox.TabIndex = 0;
            this.summaryNotesRichTextBox.Text = "";
            // 
            // transaction_history
            // 
            this.transaction_history.BackColor = System.Drawing.Color.WhiteSmoke;
            this.transaction_history.Controls.Add(this.transactionsDetailsRichTextBox);
            this.transaction_history.Controls.Add(this.transactionGridView);
            this.transaction_history.Location = new System.Drawing.Point(4, 25);
            this.transaction_history.Margin = new System.Windows.Forms.Padding(0);
            this.transaction_history.Name = "transaction_history";
            this.transaction_history.Size = new System.Drawing.Size(972, 260);
            this.transaction_history.TabIndex = 3;
            this.transaction_history.Text = "Transaction History";
            // 
            // transactionsDetailsRichTextBox
            // 
            this.transactionsDetailsRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.transactionsDetailsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionsDetailsRichTextBox.Location = new System.Drawing.Point(313, 2);
            this.transactionsDetailsRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.transactionsDetailsRichTextBox.Name = "transactionsDetailsRichTextBox";
            this.transactionsDetailsRichTextBox.ReadOnly = true;
            this.transactionsDetailsRichTextBox.Size = new System.Drawing.Size(662, 255);
            this.transactionsDetailsRichTextBox.TabIndex = 1;
            this.transactionsDetailsRichTextBox.Text = "";
            // 
            // transactionGridView
            // 
            this.transactionGridView.AllowUserToAddRows = false;
            this.transactionGridView.AllowUserToDeleteRows = false;
            this.transactionGridView.AllowUserToOrderColumns = true;
            this.transactionGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.transactionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.transactionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transaction_id,
            this.csr_id,
            this.entry_type,
            this.transaction_subtype,
            this.transaction_created_by,
            this.transaction_created_on,
            this.transaction_created_at,
            this.transaction_long_text});
            this.transactionGridView.EnableHeadersVisualStyles = false;
            this.transactionGridView.Location = new System.Drawing.Point(2, 2);
            this.transactionGridView.Margin = new System.Windows.Forms.Padding(2);
            this.transactionGridView.Name = "transactionGridView";
            this.transactionGridView.RowHeadersVisible = false;
            this.transactionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.transactionGridView.RowTemplate.Height = 24;
            this.transactionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionGridView.Size = new System.Drawing.Size(306, 255);
            this.transactionGridView.TabIndex = 0;
            // 
            // transaction_id
            // 
            this.transaction_id.DataPropertyName = "transaction_id";
            this.transaction_id.Frozen = true;
            this.transaction_id.HeaderText = "Transaction Id";
            this.transaction_id.Name = "transaction_id";
            this.transaction_id.ReadOnly = true;
            this.transaction_id.Visible = false;
            // 
            // csr_id
            // 
            this.csr_id.DataPropertyName = "csr_id";
            this.csr_id.HeaderText = "CSR ID";
            this.csr_id.Name = "csr_id";
            this.csr_id.ReadOnly = true;
            this.csr_id.Visible = false;
            // 
            // entry_type
            // 
            this.entry_type.DataPropertyName = "type";
            this.entry_type.HeaderText = "Type";
            this.entry_type.Name = "entry_type";
            this.entry_type.ReadOnly = true;
            this.entry_type.Width = 66;
            // 
            // transaction_subtype
            // 
            this.transaction_subtype.DataPropertyName = "subtype";
            this.transaction_subtype.HeaderText = "Subtype";
            this.transaction_subtype.Name = "transaction_subtype";
            this.transaction_subtype.ReadOnly = true;
            this.transaction_subtype.Visible = false;
            // 
            // transaction_created_by
            // 
            this.transaction_created_by.DataPropertyName = "created_by";
            this.transaction_created_by.HeaderText = "Created By";
            this.transaction_created_by.Name = "transaction_created_by";
            this.transaction_created_by.ReadOnly = true;
            this.transaction_created_by.Width = 106;
            // 
            // transaction_created_on
            // 
            this.transaction_created_on.DataPropertyName = "created_on";
            this.transaction_created_on.HeaderText = "Created On";
            this.transaction_created_on.Name = "transaction_created_on";
            this.transaction_created_on.ReadOnly = true;
            this.transaction_created_on.Width = 109;
            // 
            // transaction_created_at
            // 
            this.transaction_created_at.DataPropertyName = "created_at";
            this.transaction_created_at.HeaderText = "Created At";
            this.transaction_created_at.Name = "transaction_created_at";
            this.transaction_created_at.ReadOnly = true;
            this.transaction_created_at.Width = 105;
            // 
            // transaction_long_text
            // 
            this.transaction_long_text.DataPropertyName = "content";
            this.transaction_long_text.HeaderText = "Contents";
            this.transaction_long_text.Name = "transaction_long_text";
            this.transaction_long_text.ReadOnly = true;
            this.transaction_long_text.Visible = false;
            // 
            // emails
            // 
            this.emails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emails.Location = new System.Drawing.Point(4, 25);
            this.emails.Margin = new System.Windows.Forms.Padding(2);
            this.emails.Name = "emails";
            this.emails.Size = new System.Drawing.Size(972, 260);
            this.emails.TabIndex = 9;
            this.emails.Text = "Emails";
            // 
            // formal_answer
            // 
            this.formal_answer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formal_answer.Controls.Add(this.formalAnswerRichTextBox);
            this.formal_answer.Location = new System.Drawing.Point(4, 25);
            this.formal_answer.Margin = new System.Windows.Forms.Padding(0);
            this.formal_answer.Name = "formal_answer";
            this.formal_answer.Size = new System.Drawing.Size(972, 260);
            this.formal_answer.TabIndex = 5;
            this.formal_answer.Text = "Formal Answer";
            // 
            // formalAnswerRichTextBox
            // 
            this.formalAnswerRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formalAnswerRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formalAnswerRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formalAnswerRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.formalAnswerRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.formalAnswerRichTextBox.MinimumSize = new System.Drawing.Size(970, 250);
            this.formalAnswerRichTextBox.Name = "formalAnswerRichTextBox";
            this.formalAnswerRichTextBox.Size = new System.Drawing.Size(972, 260);
            this.formalAnswerRichTextBox.TabIndex = 0;
            this.formalAnswerRichTextBox.Text = "";
            // 
            // analysis
            // 
            this.analysis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.analysis.Location = new System.Drawing.Point(4, 25);
            this.analysis.Margin = new System.Windows.Forms.Padding(0);
            this.analysis.Name = "analysis";
            this.analysis.Size = new System.Drawing.Size(972, 260);
            this.analysis.TabIndex = 4;
            this.analysis.Text = "Analysis";
            // 
            // relatedCSR
            // 
            this.relatedCSR.Location = new System.Drawing.Point(4, 25);
            this.relatedCSR.Margin = new System.Windows.Forms.Padding(2);
            this.relatedCSR.Name = "relatedCSR";
            this.relatedCSR.Padding = new System.Windows.Forms.Padding(2);
            this.relatedCSR.Size = new System.Drawing.Size(972, 260);
            this.relatedCSR.TabIndex = 10;
            this.relatedCSR.Text = "Related CSRs";
            this.relatedCSR.UseVisualStyleBackColor = true;
            // 
            // addTime
            // 
            this.addTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addTime.Controls.Add(this.addTimeGrid);
            this.addTime.Location = new System.Drawing.Point(4, 25);
            this.addTime.Margin = new System.Windows.Forms.Padding(2);
            this.addTime.Name = "addTime";
            this.addTime.Padding = new System.Windows.Forms.Padding(2);
            this.addTime.Size = new System.Drawing.Size(972, 260);
            this.addTime.TabIndex = 11;
            this.addTime.Text = "Add Time";
            // 
            // addTimeGrid
            // 
            this.addTimeGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.addTimeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTimeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.addTimeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.addTimeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.addTimeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addTimeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeHours,
            this.timeMinutes,
            this.dateStarted,
            this.timeStarted});
            this.addTimeGrid.EnableHeadersVisualStyles = false;
            this.addTimeGrid.Location = new System.Drawing.Point(2, 0);
            this.addTimeGrid.Margin = new System.Windows.Forms.Padding(2);
            this.addTimeGrid.Name = "addTimeGrid";
            this.addTimeGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addTimeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.addTimeGrid.RowHeadersVisible = false;
            this.addTimeGrid.RowTemplate.Height = 24;
            this.addTimeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addTimeGrid.Size = new System.Drawing.Size(396, 255);
            this.addTimeGrid.TabIndex = 0;
            // 
            // timeHours
            // 
            this.timeHours.HeaderText = "Hours";
            this.timeHours.Name = "timeHours";
            // 
            // timeMinutes
            // 
            this.timeMinutes.HeaderText = "Minutes";
            this.timeMinutes.Name = "timeMinutes";
            // 
            // dateStarted
            // 
            this.dateStarted.HeaderText = "Started On";
            this.dateStarted.Name = "dateStarted";
            // 
            // timeStarted
            // 
            this.timeStarted.HeaderText = "Time Started";
            this.timeStarted.Name = "timeStarted";
            // 
            // MenuStrip
            // 
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuStrip.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.MenuStrip.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sync,
            this.UpdateAll,
            this.Email,
            this.filter,
            this.CloseButton,
            this.Maximize,
            this.Minimize,
            this.Help,
            this.Settings,
            this.Report,
            this.ShowFlagged,
            this.ShowSMS});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(980, 41);
            this.MenuStrip.TabIndex = 47;
            this.MenuStrip.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ChangeSize);
            this.MenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
            // 
            // Sync
            // 
            this.Sync.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SyncList});
            this.Sync.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.Sync.Image = ((System.Drawing.Image)(resources.GetObject("Sync.Image")));
            this.Sync.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sync.Name = "Sync";
            this.Sync.Size = new System.Drawing.Size(119, 38);
            this.Sync.Text = "Synchronize";
            this.Sync.ButtonClick += new System.EventHandler(this.syncClick);
            // 
            // SyncList
            // 
            this.SyncList.Name = "SyncList";
            this.SyncList.Size = new System.Drawing.Size(163, 22);
            this.SyncList.Text = "Sync List of CSRs";
            this.SyncList.Click += new System.EventHandler(this.syncListClick);
            // 
            // UpdateAll
            // 
            this.UpdateAll.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.UpdateAll.Image = ((System.Drawing.Image)(resources.GetObject("UpdateAll.Image")));
            this.UpdateAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UpdateAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateAll.Name = "UpdateAll";
            this.UpdateAll.Size = new System.Drawing.Size(98, 38);
            this.UpdateAll.Text = "Update All";
            this.UpdateAll.Visible = false;
            // 
            // Email
            // 
            this.Email.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Email.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reception,
            this.UpdateEmail,
            this.FormalAnswerEmail});
            this.Email.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.Email.Image = ((System.Drawing.Image)(resources.GetObject("Email.Image")));
            this.Email.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Email.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 38);
            this.Email.Text = "Email";
            this.Email.ButtonClick += new System.EventHandler(this.ButtonClick);
            // 
            // Reception
            // 
            this.Reception.Name = "Reception";
            this.Reception.Size = new System.Drawing.Size(153, 22);
            this.Reception.Text = "CSR Reception";
            this.Reception.Click += new System.EventHandler(this.ButtonClick);
            // 
            // UpdateEmail
            // 
            this.UpdateEmail.Name = "UpdateEmail";
            this.UpdateEmail.Size = new System.Drawing.Size(153, 22);
            this.UpdateEmail.Text = "Update";
            this.UpdateEmail.Click += new System.EventHandler(this.ButtonClick);
            // 
            // FormalAnswerEmail
            // 
            this.FormalAnswerEmail.Name = "FormalAnswerEmail";
            this.FormalAnswerEmail.Size = new System.Drawing.Size(153, 22);
            this.FormalAnswerEmail.Text = "Formal Answer";
            this.FormalAnswerEmail.Click += new System.EventHandler(this.ButtonClick);
            // 
            // filter
            // 
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(76, 41);
            this.filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterKeyPress);
            this.filter.Click += new System.EventHandler(this.filter_Click);
            this.filter.TextChanged += new System.EventHandler(this.FilterTextChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseButton.AutoSize = false;
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Maximize
            // 
            this.Maximize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Maximize.AutoSize = false;
            this.Maximize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Maximize.Image")));
            this.Maximize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Maximize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Maximize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(32, 32);
            this.Maximize.Text = "Maximize";
            this.Maximize.Click += new System.EventHandler(this.maximizeClick);
            // 
            // Minimize
            // 
            this.Minimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Minimize.AutoSize = false;
            this.Minimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Minimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.Text = "Minimize";
            this.Minimize.Click += new System.EventHandler(this.minimizeClick);
            // 
            // Help
            // 
            this.Help.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Help.AutoSize = false;
            this.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(45, 45);
            this.Help.Text = "Help";
            // 
            // Settings
            // 
            this.Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Settings.AutoSize = false;
            this.Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(45, 45);
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.settingsClick);
            // 
            // Report
            // 
            this.Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CsrCauseCode});
            this.Report.Image = ((System.Drawing.Image)(resources.GetObject("Report.Image")));
            this.Report.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Report.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(140, 38);
            this.Report.Text = "Generate Report";
            this.Report.ButtonClick += new System.EventHandler(this.reportClick);
            // 
            // CsrCauseCode
            // 
            this.CsrCauseCode.Name = "CsrCauseCode";
            this.CsrCauseCode.Size = new System.Drawing.Size(161, 22);
            this.CsrCauseCode.Text = "CSR Cause Code";
            this.CsrCauseCode.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ShowFlagged
            // 
            this.ShowFlagged.CheckOnClick = true;
            this.ShowFlagged.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.ShowFlagged.Image = ((System.Drawing.Image)(resources.GetObject("ShowFlagged.Image")));
            this.ShowFlagged.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowFlagged.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowFlagged.Name = "ShowFlagged";
            this.ShowFlagged.Size = new System.Drawing.Size(117, 38);
            this.ShowFlagged.Text = "Show Flagged";
            this.ShowFlagged.Click += new System.EventHandler(this.flaggedClick);
            // 
            // ShowSMS
            // 
            this.ShowSMS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ShowSMS.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.ShowSMS.Image = ((System.Drawing.Image)(resources.GetObject("ShowSMS.Image")));
            this.ShowSMS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowSMS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowSMS.Name = "ShowSMS";
            this.ShowSMS.Size = new System.Drawing.Size(98, 38);
            this.ShowSMS.Text = "Show SMS";
            this.ShowSMS.Click += new System.EventHandler(this.showSMSClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(980, 626);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CsrPropertyTabs.ResumeLayout(false);
            this.description.ResumeLayout(false);
            this.overview.ResumeLayout(false);
            this.progress_report.ResumeLayout(false);
            this.summary_text.ResumeLayout(false);
            this.transaction_history.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionGridView)).EndInit();
            this.formal_answer.ResumeLayout(false);
            this.addTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addTimeGrid)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        #region Properties

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip MenuStrip;
        private System.Windows.Forms.ToolStripButton UpdateAll;
        private System.Windows.Forms.ToolStripSplitButton Email;
        private System.Windows.Forms.ToolStripMenuItem Reception;
        private System.Windows.Forms.ToolStripMenuItem UpdateEmail;
        private System.Windows.Forms.ToolStripMenuItem FormalAnswerEmail;
        private System.Windows.Forms.ToolStripButton ShowFlagged;
        private System.Windows.Forms.ToolStripTextBox filter;
        private System.Windows.Forms.ToolStripButton Help;
        private System.Windows.Forms.ToolStripButton Settings;
        private ToolStripButton CloseButton;
        private ToolStripButton Maximize;
        private ToolStripButton Minimize;
        private ToolStripButton ShowSMS;
        private ToolStripSplitButton Report;
        private ToolStripMenuItem CsrCauseCode;
        private gfoidl.Windows.Forms.gfDataGridView dataGrid;
        private FlatTabControl.FlatTabControl CsrPropertyTabs;
        private TabPage progress_report;
        private TabPage summary_text;
        private TabPage transaction_history;
        private TabPage analysis;
        private TabPage formal_answer;
        private RichTextBox progressReport;
        private TabPage description;
        private TabPage emails;
        private TabPage overview;
        private RichTextBox descriptionRichTextBox;
        private RichTextBox summaryNotesRichTextBox;
        private gfoidl.Windows.Forms.gfDataGridView transactionGridView;
        private DataGridViewTextBoxColumn flags;
        private DataGridViewTextBoxColumn progress_updated;
        private DataGridViewTextBoxColumn summary_updated;
        private DataGridViewTextBoxColumn overdue;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn severity_text;
        private DataGridViewTextBoxColumn slogan;
        private DataGridViewTextBoxColumn resp_employee;
        private DataGridViewTextBoxColumn posting_date;
        private DataGridViewTextBoxColumn ericsson_resp_org;
        private DataGridViewTextBoxColumn network;
        private DataGridViewTextBoxColumn node;
        private DataGridViewTextBoxColumn site;
        private DataGridViewTextBoxColumn csr_category;
        private DataGridViewTextBoxColumn issue_category;
        private DataGridViewTextBoxColumn ext_reference;
        private DataGridViewTextBoxColumn csr_type;
        private DataGridViewTextBoxColumn sold_to_party;
        private DataGridViewTextBoxColumn created_on;
        private DataGridViewTextBoxColumn time_to_remedy;
        private DataGridViewTextBoxColumn time_to_callback;
        private DataGridViewTextBoxColumn notific_rec_date;
        private DataGridViewTextBoxColumn cust_resp_org;
        private DataGridViewTextBoxColumn contact_person;
        private DataGridViewTextBoxColumn attach_cnt;
        private DataGridViewTextBoxColumn global_cust;
        private DataGridViewTextBoxColumn comments;
        private DataGridViewTextBoxColumn contract;
        private DataGridViewTextBoxColumn remedy_overdue;
        private DataGridViewTextBoxColumn solution_overdue;
        private DataGridViewTextBoxColumn main_category;
        private DataGridViewTextBoxColumn severity;
        private DataGridViewTextBoxColumn service_to_party;
        private DataGridViewTextBoxColumn created_by;
        private DataGridViewTextBoxColumn changed_by;
        private DataGridViewTextBoxColumn gs_flag;
        private DataGridViewTextBoxColumn tr_id;
        private DataGridViewTextBoxColumn unnecessary_escalation;
        private DataGridViewTextBoxColumn changed_on;
        private DataGridViewTextBoxColumn time_to_sol;
        private DataGridViewTextBoxColumn csr_type_txt;
        private DataGridViewTextBoxColumn hot_csr;
        private DataGridViewTextBoxColumn total_time;
        private DataGridViewTextBoxColumn cost_allocation;
        private DataGridViewTextBoxColumn follow_up_date;
        private DataGridViewTextBoxColumn cause_code;
        private DataGridViewTextBoxColumn component;
        private DataGridViewTextBoxColumn region_spoc;
        private DataGridViewTextBoxColumn csr_origin;
        private DataGridViewTextBoxColumn contract_type;
        private DataGridViewTextBoxColumn installed_base;
        #endregion

        #region Window Actions

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragWindow(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                MenuStrip.Capture = false;
            }
        }

        private void ChangeSize(object s, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Normal)
                    WindowState = FormWindowState.Maximized;
                else
                    WindowState = FormWindowState.Normal;
                MenuStrip.Capture = false;
            }
        }
        #endregion

        #region Button Click Events
        private void syncClick(object sender, EventArgs e)
        {
            browser.StartSync(); 
        }
        private void syncListClick(object sender, EventArgs e)
        {
            // Show Dialog List
        }

        private void reportClick(object sender, EventArgs e)
        {
            Worklist.GenerateReport(dataGrid);
        }

        private void flaggedClick(object sender, EventArgs e)
        {

        }

        private void showSMSClick(object sender, EventArgs e)
        {
            (sender as ToolStripButton).Text = 
                ((sender as ToolStripButton).Text == "Show SMS") 
                ? "Hide SMS" : "Show SMS";
            browser.ToggleShow();
        }

        private void settingsClick(object sender, EventArgs e)
        {
            SettingsDialog sDiag = new SettingsDialog();
            sDiag.StartPosition = FormStartPosition.CenterParent;
            sDiag.ShowDialog();
        }

        private void minimizeClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeClick(object sender, EventArgs e)
        {
            WindowState = (WindowState == FormWindowState.Maximized)
                        ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if (sender == Reception)
                Csr.SendEmail(dataGrid.SelectedRows[0], "Reception");
            else if (sender == UpdateEmail)
                Csr.SendEmail(dataGrid.SelectedRows[0], "Update");
            else if (sender == FormalAnswerEmail)
                Csr.SendEmail(dataGrid.SelectedRows[0], "FormalAnswer");
            else if (sender == CsrCauseCode)
                Worklist.GenerateReport(dataGrid);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            SQLiteDatabase.SaveChanges();

            browser.Close();
            this.Close();

            Application.Exit();
        }

        #endregion

        #region Other Event Listeners
        public void FilterTextChanged(object s, EventArgs e)
        {
            string text = filter.Text;
            StringBuilder builder = new StringBuilder(text);
            string max = builder.Append('9', 7-text.Length).ToString();
            builder = new StringBuilder(text);
            string min = builder.Append('0', 7-text.Length).ToString();

            (DataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format("id >= {0} AND id <= {1}", min, max);
        }
        private void FilterKeyPress(object s, KeyPressEventArgs e)
        {
            if (e.KeyChar.CompareTo((Char) Keys.Return) == 0)
            {
                if (char.IsDigit(e.KeyChar) && filter.Text.Length >= 7)
                {
                    e.Handled = true;
                    System.Collections.Generic.List<String> synList = new System.Collections.Generic.List<String>();
                    synList.Add(filter.TextBox.Text.ToString());
                    browser.StartSync(synList);
                }
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (char.IsDigit(e.KeyChar) && filter.Text.Length >= 7)
                e.Handled = true;
        }
        #endregion

        private RichTextBox overviewRichTextBox;
        private TabPage relatedCSR;
        private RichTextBox progressReportRichTextBox;
        private RichTextBox transactionsDetailsRichTextBox;
        private DataGridViewTextBoxColumn transaction_id;
        private DataGridViewTextBoxColumn csr_id;
        private DataGridViewTextBoxColumn entry_type;
        private DataGridViewTextBoxColumn transaction_subtype;
        private DataGridViewTextBoxColumn transaction_created_by;
        private DataGridViewTextBoxColumn transaction_created_on;
        private DataGridViewTextBoxColumn transaction_created_at;
        private DataGridViewTextBoxColumn transaction_long_text;
        private RichTextBox formalAnswerRichTextBox;
        private TabPage addTime;
        private gfoidl.Windows.Forms.gfDataGridView addTimeGrid;
        private DataGridViewTextBoxColumn timeHours;
        private DataGridViewTextBoxColumn timeMinutes;
        private DataGridViewTextBoxColumn dateStarted;
        private DataGridViewTextBoxColumn timeStarted;
        private ToolStripSplitButton Sync;
        private ToolStripMenuItem SyncList;
        
    }
}

