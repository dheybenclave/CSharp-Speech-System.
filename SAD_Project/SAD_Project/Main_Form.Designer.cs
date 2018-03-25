namespace SAD_Project
{
    partial class Main_Form
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.pnltoptab = new System.Windows.Forms.Panel();
            this.btninvetory = new System.Windows.Forms.Button();
            this.btnduties = new System.Windows.Forms.Button();
            this.btnschedule = new System.Windows.Forms.Button();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.pnlfooter = new System.Windows.Forms.Panel();
            this.tab_main = new DevExpress.XtraTab.XtraTabControl();
            this.tab_schedule = new DevExpress.XtraTab.XtraTabPage();
            this.pnlschedfill = new DevExpress.XtraEditors.PanelControl();
            this.clndrsched = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.pnlschedright = new System.Windows.Forms.Panel();
            this.lstvdetails = new System.Windows.Forms.ListView();
            this.pnlschedrighttop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.pnlschedleft = new System.Windows.Forms.Panel();
            this.lbldateselected = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbackrecovery = new System.Windows.Forms.Label();
            this.btnpnlschedleftclose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab_duties = new DevExpress.XtraTab.XtraTabPage();
            this.tab_inventory = new DevExpress.XtraTab.XtraTabPage();
            this.pnlbody = new System.Windows.Forms.Panel();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnforsched = new Bunifu.Framework.UI.BunifuTileButton();
            this.tmsidenav = new System.Windows.Forms.Timer(this.components);
            this.tmforform = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnclose = new System.Windows.Forms.Button();
            this.btnmaxmin = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.pnlheader = new System.Windows.Forms.Panel();
            this.pnltoptab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_main)).BeginInit();
            this.tab_main.SuspendLayout();
            this.tab_schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlschedfill)).BeginInit();
            this.pnlschedfill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clndrsched.CalendarTimeProperties)).BeginInit();
            this.pnlschedright.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlschedleft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlbody.SuspendLayout();
            this.pnlleft.SuspendLayout();
            this.pnlheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltoptab
            // 
            this.pnltoptab.BackColor = System.Drawing.Color.Transparent;
            this.pnltoptab.Controls.Add(this.btninvetory);
            this.pnltoptab.Controls.Add(this.btnduties);
            this.pnltoptab.Controls.Add(this.btnschedule);
            this.pnltoptab.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltoptab.Location = new System.Drawing.Point(0, 0);
            this.pnltoptab.Name = "pnltoptab";
            this.pnltoptab.Size = new System.Drawing.Size(995, 58);
            this.pnltoptab.TabIndex = 11;
            // 
            // btninvetory
            // 
            this.btninvetory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btninvetory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btninvetory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btninvetory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btninvetory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninvetory.Image = ((System.Drawing.Image)(resources.GetObject("btninvetory.Image")));
            this.btninvetory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninvetory.Location = new System.Drawing.Point(319, 0);
            this.btninvetory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninvetory.Name = "btninvetory";
            this.btninvetory.Padding = new System.Windows.Forms.Padding(0, 0, 20, 3);
            this.btninvetory.Size = new System.Drawing.Size(161, 58);
            this.btninvetory.TabIndex = 3;
            this.btninvetory.Text = "INVENTORY";
            this.btninvetory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninvetory.UseVisualStyleBackColor = true;
            this.btninvetory.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnduties
            // 
            this.btnduties.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnduties.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnduties.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnduties.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnduties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnduties.Image = ((System.Drawing.Image)(resources.GetObject("btnduties.Image")));
            this.btnduties.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnduties.Location = new System.Drawing.Point(158, 0);
            this.btnduties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnduties.Name = "btnduties";
            this.btnduties.Padding = new System.Windows.Forms.Padding(0, 0, 20, 3);
            this.btnduties.Size = new System.Drawing.Size(161, 58);
            this.btnduties.TabIndex = 2;
            this.btnduties.Text = "DUTIES";
            this.btnduties.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnduties.UseVisualStyleBackColor = true;
            this.btnduties.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnschedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnschedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnschedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnschedule.Image = ((System.Drawing.Image)(resources.GetObject("btnschedule.Image")));
            this.btnschedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnschedule.Location = new System.Drawing.Point(0, 0);
            this.btnschedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Padding = new System.Windows.Forms.Padding(0, 0, 20, 3);
            this.btnschedule.Size = new System.Drawing.Size(158, 58);
            this.btnschedule.TabIndex = 1;
            this.btnschedule.Text = "SCHEDULE";
            this.btnschedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnschedule.UseVisualStyleBackColor = true;
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // dtdate
            // 
            this.dtdate.Location = new System.Drawing.Point(9, 81);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(200, 21);
            this.dtdate.TabIndex = 21;
            this.dtdate.ValueChanged += new System.EventHandler(this.dtdate_ValueChanged);
            // 
            // pnlfooter
            // 
            this.pnlfooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlfooter.Location = new System.Drawing.Point(0, 637);
            this.pnlfooter.Name = "pnlfooter";
            this.pnlfooter.Size = new System.Drawing.Size(1000, 29);
            this.pnlfooter.TabIndex = 12;
            // 
            // tab_main
            // 
            this.tab_main.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tab_main.Appearance.Options.UseBackColor = true;
            this.tab_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tab_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_main.HeaderButtons = DevExpress.XtraTab.TabButtons.None;
            this.tab_main.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Never;
            this.tab_main.Location = new System.Drawing.Point(0, 58);
            this.tab_main.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.tab_main.Margin = new System.Windows.Forms.Padding(0);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedTabPage = this.tab_schedule;
            this.tab_main.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.tab_main.Size = new System.Drawing.Size(995, 547);
            this.tab_main.TabIndex = 12;
            this.tab_main.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tab_schedule,
            this.tab_duties,
            this.tab_inventory});
            // 
            // tab_schedule
            // 
            this.tab_schedule.AllowTouchScroll = true;
            this.tab_schedule.Appearance.PageClient.BackColor = System.Drawing.SystemColors.GrayText;
            this.tab_schedule.Appearance.PageClient.Options.UseBackColor = true;
            this.tab_schedule.AutoScroll = true;
            this.tab_schedule.Controls.Add(this.pnlschedfill);
            this.tab_schedule.Controls.Add(this.pnlschedleft);
            this.tab_schedule.Name = "tab_schedule";
            this.tab_schedule.Size = new System.Drawing.Size(989, 541);
            this.tab_schedule.Text = "xtraTabPage1";
            // 
            // pnlschedfill
            // 
            this.pnlschedfill.AllowTouchScroll = true;
            this.pnlschedfill.AutoSize = true;
            this.pnlschedfill.Controls.Add(this.clndrsched);
            this.pnlschedfill.Controls.Add(this.pnlschedright);
            this.pnlschedfill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlschedfill.Location = new System.Drawing.Point(215, 0);
            this.pnlschedfill.Name = "pnlschedfill";
            this.pnlschedfill.Size = new System.Drawing.Size(774, 541);
            this.pnlschedfill.TabIndex = 3;
            // 
            // clndrsched
            // 
            this.clndrsched.Appearance.BackColor = System.Drawing.Color.Honeydew;
            this.clndrsched.Appearance.ForeColor = System.Drawing.Color.White;
            this.clndrsched.Appearance.Options.UseBackColor = true;
            this.clndrsched.Appearance.Options.UseForeColor = true;
            this.clndrsched.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.clndrsched.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.clndrsched.CalendarAppearance.CalendarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.CalendarHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.CalendarHeader.Options.UseBackColor = true;
            this.clndrsched.CalendarAppearance.CalendarHeader.Options.UseBorderColor = true;
            this.clndrsched.CalendarAppearance.DayCellHighlighted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.DayCellHighlighted.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.DayCellHighlighted.ForeColor = System.Drawing.Color.Honeydew;
            this.clndrsched.CalendarAppearance.DayCellHighlighted.Options.UseBackColor = true;
            this.clndrsched.CalendarAppearance.DayCellHighlighted.Options.UseForeColor = true;
            this.clndrsched.CalendarAppearance.DayCellToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.DayCellToday.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.DayCellToday.ForeColor = System.Drawing.Color.Honeydew;
            this.clndrsched.CalendarAppearance.DayCellToday.Options.UseBackColor = true;
            this.clndrsched.CalendarAppearance.DayCellToday.Options.UseForeColor = true;
            this.clndrsched.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clndrsched.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Flat;
            this.clndrsched.CalendarTimeProperties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.clndrsched.CaseMonthNames = DevExpress.XtraEditors.Controls.TextCaseMode.UpperCase;
            this.clndrsched.CaseWeekDayAbbreviations = DevExpress.XtraEditors.Controls.TextCaseMode.UpperCase;
            this.clndrsched.CellPadding = new System.Windows.Forms.Padding(20, 27, 20, 27);
            this.clndrsched.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clndrsched.DateTime = new System.DateTime(2017, 7, 22, 0, 0, 0, 0);
            this.clndrsched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clndrsched.DrawCellLines = true;
            this.clndrsched.EditValue = new System.DateTime(2017, 7, 22, 0, 0, 0, 0);
            this.clndrsched.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.True;
            this.clndrsched.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clndrsched.Location = new System.Drawing.Point(2, 2);
            this.clndrsched.MinValue = new System.DateTime(1988, 12, 25, 0, 0, 0, 0);
            this.clndrsched.Name = "clndrsched";
            this.clndrsched.SelectionBehavior = DevExpress.XtraEditors.Controls.CalendarSelectionBehavior.OutlookStyle;
            this.clndrsched.ShowClearButton = true;
            this.clndrsched.ShowFooter = false;
            this.clndrsched.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.clndrsched.ShowTodayButton = false;
            this.clndrsched.ShowWeekNumbers = true;
            this.clndrsched.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.clndrsched.Size = new System.Drawing.Size(505, 537);
            this.clndrsched.TabIndex = 5;
            this.clndrsched.TodayDate = new System.DateTime(2017, 7, 21, 0, 0, 0, 0);
            this.clndrsched.TodayDayCellFrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.UpdateSelectionWhenNavigating = true;
            this.clndrsched.VistaCalendarViewStyle = ((DevExpress.XtraEditors.VistaCalendarViewStyle)(((((DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView | DevExpress.XtraEditors.VistaCalendarViewStyle.YearView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.QuarterView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView)));
            this.clndrsched.WeekDayAbbreviationLength = 3;
            this.clndrsched.DateTimeChanged += new System.EventHandler(this.clndrsched_DateTimeChanged);
            this.clndrsched.MouseEnter += new System.EventHandler(this.clndrsched_MouseEnter);
            this.clndrsched.MouseHover += new System.EventHandler(this.clndrsched_MouseHover);
            this.clndrsched.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clndrsched_MouseMove);
            // 
            // pnlschedright
            // 
            this.pnlschedright.Controls.Add(this.lstvdetails);
            this.pnlschedright.Controls.Add(this.pnlschedrighttop);
            this.pnlschedright.Controls.Add(this.panel3);
            this.pnlschedright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlschedright.Location = new System.Drawing.Point(507, 2);
            this.pnlschedright.Name = "pnlschedright";
            this.pnlschedright.Size = new System.Drawing.Size(265, 537);
            this.pnlschedright.TabIndex = 2;
            // 
            // lstvdetails
            // 
            this.lstvdetails.BackColor = System.Drawing.Color.Honeydew;
            this.lstvdetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstvdetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvdetails.FullRowSelect = true;
            this.lstvdetails.GridLines = true;
            this.lstvdetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstvdetails.Location = new System.Drawing.Point(0, 128);
            this.lstvdetails.Name = "lstvdetails";
            this.lstvdetails.Size = new System.Drawing.Size(265, 409);
            this.lstvdetails.TabIndex = 6;
            this.lstvdetails.UseCompatibleStateImageBehavior = false;
            this.lstvdetails.View = System.Windows.Forms.View.Details;
            // 
            // pnlschedrighttop
            // 
            this.pnlschedrighttop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlschedrighttop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlschedrighttop.Location = new System.Drawing.Point(0, 100);
            this.pnlschedrighttop.Name = "pnlschedrighttop";
            this.pnlschedrighttop.Size = new System.Drawing.Size(265, 28);
            this.pnlschedrighttop.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 100);
            this.panel3.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(144, 58);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Padding = new System.Windows.Forms.Padding(0, 0, 10, 3);
            this.btnadd.Size = new System.Drawing.Size(116, 35);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "ADD";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pnlschedleft
            // 
            this.pnlschedleft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlschedleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlschedleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlschedleft.Controls.Add(this.dtdate);
            this.pnlschedleft.Controls.Add(this.lbldateselected);
            this.pnlschedleft.Controls.Add(this.panel1);
            this.pnlschedleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlschedleft.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pnlschedleft.ForeColor = System.Drawing.Color.Honeydew;
            this.pnlschedleft.Location = new System.Drawing.Point(0, 0);
            this.pnlschedleft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlschedleft.Name = "pnlschedleft";
            this.pnlschedleft.Size = new System.Drawing.Size(215, 541);
            this.pnlschedleft.TabIndex = 4;
            this.pnlschedleft.Resize += new System.EventHandler(this.Main_Form_Resize);
            // 
            // lbldateselected
            // 
            this.lbldateselected.AutoSize = true;
            this.lbldateselected.BackColor = System.Drawing.Color.Transparent;
            this.lbldateselected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbldateselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldateselected.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lbldateselected.ForeColor = System.Drawing.Color.Transparent;
            this.lbldateselected.Location = new System.Drawing.Point(9, 51);
            this.lbldateselected.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldateselected.Name = "lbldateselected";
            this.lbldateselected.Size = new System.Drawing.Size(87, 16);
            this.lbldateselected.TabIndex = 1010;
            this.lbldateselected.Text = "date selected;";
            this.lbldateselected.TextChanged += new System.EventHandler(this.lbldateselected_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblbackrecovery);
            this.panel1.Controls.Add(this.btnpnlschedleftclose);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 37);
            this.panel1.TabIndex = 0;
            // 
            // lblbackrecovery
            // 
            this.lblbackrecovery.AutoSize = true;
            this.lblbackrecovery.BackColor = System.Drawing.Color.Transparent;
            this.lblbackrecovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblbackrecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbackrecovery.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbackrecovery.ForeColor = System.Drawing.Color.Transparent;
            this.lblbackrecovery.Location = new System.Drawing.Point(8, 5);
            this.lblbackrecovery.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblbackrecovery.Name = "lblbackrecovery";
            this.lblbackrecovery.Size = new System.Drawing.Size(83, 20);
            this.lblbackrecovery.TabIndex = 1009;
            this.lblbackrecovery.Text = "SCHEDULE";
            // 
            // btnpnlschedleftclose
            // 
            this.btnpnlschedleftclose.BackColor = System.Drawing.Color.Transparent;
            this.btnpnlschedleftclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpnlschedleftclose.BackgroundImage")));
            this.btnpnlschedleftclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpnlschedleftclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpnlschedleftclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnpnlschedleftclose.FlatAppearance.BorderSize = 0;
            this.btnpnlschedleftclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnpnlschedleftclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnpnlschedleftclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpnlschedleftclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnpnlschedleftclose.Location = new System.Drawing.Point(183, 0);
            this.btnpnlschedleftclose.Margin = new System.Windows.Forms.Padding(0);
            this.btnpnlschedleftclose.Name = "btnpnlschedleftclose";
            this.btnpnlschedleftclose.Size = new System.Drawing.Size(32, 34);
            this.btnpnlschedleftclose.TabIndex = 13;
            this.btnpnlschedleftclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpnlschedleftclose.UseVisualStyleBackColor = false;
            this.btnpnlschedleftclose.Click += new System.EventHandler(this.btnpnlschedleftclose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 3);
            this.panel2.TabIndex = 1010;
            // 
            // tab_duties
            // 
            this.tab_duties.Name = "tab_duties";
            this.tab_duties.Size = new System.Drawing.Size(989, 541);
            this.tab_duties.Text = "xtraTabPage2";
            // 
            // tab_inventory
            // 
            this.tab_inventory.Name = "tab_inventory";
            this.tab_inventory.Size = new System.Drawing.Size(989, 541);
            this.tab_inventory.Text = "xtraTabPage3";
            // 
            // pnlbody
            // 
            this.pnlbody.BackColor = System.Drawing.Color.Transparent;
            this.pnlbody.Controls.Add(this.tab_main);
            this.pnlbody.Controls.Add(this.pnltoptab);
            this.pnlbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbody.Location = new System.Drawing.Point(5, 32);
            this.pnlbody.Name = "pnlbody";
            this.pnlbody.Size = new System.Drawing.Size(995, 605);
            this.pnlbody.TabIndex = 10;
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.Transparent;
            this.pnlleft.Controls.Add(this.bunifuTileButton3);
            this.pnlleft.Controls.Add(this.bunifuTileButton2);
            this.pnlleft.Controls.Add(this.btnforsched);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 32);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(5, 605);
            this.pnlleft.TabIndex = 13;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "USER FORM";
            this.bunifuTileButton3.Location = new System.Drawing.Point(641, 162);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Padding = new System.Windows.Forms.Padding(2);
            this.bunifuTileButton3.Size = new System.Drawing.Size(238, 218);
            this.bunifuTileButton3.TabIndex = 2;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "USER FORM";
            this.bunifuTileButton2.Location = new System.Drawing.Point(382, 162);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Padding = new System.Windows.Forms.Padding(2);
            this.bunifuTileButton2.Size = new System.Drawing.Size(238, 218);
            this.bunifuTileButton2.TabIndex = 1;
            // 
            // btnforsched
            // 
            this.btnforsched.BackColor = System.Drawing.Color.SeaGreen;
            this.btnforsched.color = System.Drawing.Color.SeaGreen;
            this.btnforsched.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnforsched.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnforsched.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnforsched.ForeColor = System.Drawing.Color.White;
            this.btnforsched.Image = ((System.Drawing.Image)(resources.GetObject("btnforsched.Image")));
            this.btnforsched.ImagePosition = 20;
            this.btnforsched.ImageZoom = 50;
            this.btnforsched.LabelPosition = 41;
            this.btnforsched.LabelText = "USER FORM";
            this.btnforsched.Location = new System.Drawing.Point(132, 162);
            this.btnforsched.Margin = new System.Windows.Forms.Padding(6);
            this.btnforsched.Name = "btnforsched";
            this.btnforsched.Padding = new System.Windows.Forms.Padding(2);
            this.btnforsched.Size = new System.Drawing.Size(238, 218);
            this.btnforsched.TabIndex = 0;
            this.btnforsched.Click += new System.EventHandler(this.btnforsched_Click);
            // 
            // tmsidenav
            // 
            this.tmsidenav.Interval = 1;
            this.tmsidenav.Tick += new System.EventHandler(this.tmsidenav_Tick);
            // 
            // tmforform
            // 
            this.tmforform.Interval = 1;
            this.tmforform.Tick += new System.EventHandler(this.tmforform_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 100;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipTitle = "hello";
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnclose.Location = new System.Drawing.Point(968, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 32);
            this.btnclose.TabIndex = 12;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnmaxmin
            // 
            this.btnmaxmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaxmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmaxmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmaxmin.BackgroundImage")));
            this.btnmaxmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmaxmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaxmin.FlatAppearance.BorderSize = 0;
            this.btnmaxmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnmaxmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnmaxmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaxmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnmaxmin.Location = new System.Drawing.Point(936, 0);
            this.btnmaxmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnmaxmin.Name = "btnmaxmin";
            this.btnmaxmin.Size = new System.Drawing.Size(32, 32);
            this.btnmaxmin.TabIndex = 13;
            this.btnmaxmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmaxmin.UseVisualStyleBackColor = false;
            this.btnmaxmin.Click += new System.EventHandler(this.btnmaxmin_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimize.BackgroundImage")));
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnminimize.Location = new System.Drawing.Point(904, 0);
            this.btnminimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(32, 32);
            this.btnminimize.TabIndex = 14;
            this.btnminimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlheader.Controls.Add(this.btnminimize);
            this.pnlheader.Controls.Add(this.btnmaxmin);
            this.pnlheader.Controls.Add(this.btnclose);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1000, 32);
            this.pnlheader.TabIndex = 9;
            this.pnlheader.DoubleClick += new System.EventHandler(this.pnlheader_DoubleClick);
            this.pnlheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseDown);
            this.pnlheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseMove);
            this.pnlheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseUp);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1000, 666);
            this.Controls.Add(this.pnlbody);
            this.Controls.Add(this.pnlleft);
            this.Controls.Add(this.pnlfooter);
            this.Controls.Add(this.pnlheader);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main_Form";
            this.Resize += new System.EventHandler(this.Main_Form_Resize);
            this.pnltoptab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab_main)).EndInit();
            this.tab_main.ResumeLayout(false);
            this.tab_schedule.ResumeLayout(false);
            this.tab_schedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlschedfill)).EndInit();
            this.pnlschedfill.ResumeLayout(false);
            this.pnlschedfill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clndrsched.CalendarTimeProperties)).EndInit();
            this.pnlschedright.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlschedleft.ResumeLayout(false);
            this.pnlschedleft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlbody.ResumeLayout(false);
            this.pnlleft.ResumeLayout(false);
            this.pnlheader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltoptab;
        private System.Windows.Forms.Panel pnlfooter;
        private System.Windows.Forms.Panel pnlbody;
        private System.Windows.Forms.Button btninvetory;
        private System.Windows.Forms.Button btnduties;
        private System.Windows.Forms.Button btnschedule;
        private System.Windows.Forms.Panel pnlleft;
        private DevExpress.XtraTab.XtraTabPage tab_schedule;
        private DevExpress.XtraTab.XtraTabPage tab_duties;
        public DevExpress.XtraTab.XtraTabControl tab_main;
        private DevExpress.XtraTab.XtraTabPage tab_inventory;
        public DevExpress.XtraEditors.Controls.CalendarControl clndrsched;
        private System.Windows.Forms.Panel pnlschedleft;
        private DevExpress.XtraEditors.PanelControl pnlschedfill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnpnlschedleftclose;
        private System.Windows.Forms.Label lblbackrecovery;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tmsidenav;
        private System.Windows.Forms.Label lbldateselected;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.Panel pnlschedright;
        private System.Windows.Forms.Panel pnlschedrighttop;
        private System.Windows.Forms.ListView lstvdetails;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton btnforsched;
        private System.Windows.Forms.Timer tmforform;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnmaxmin;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Panel pnlheader;
    }
}