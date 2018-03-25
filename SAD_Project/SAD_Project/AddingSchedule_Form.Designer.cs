namespace SAD_Project
{
    partial class AddingSchedule_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingSchedule_Form));
            this.pnlheader = new System.Windows.Forms.Panel();
            this.btninvetory = new System.Windows.Forms.Button();
            this.clndr = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.weekDaysCheckEdit1 = new DevExpress.XtraScheduler.UI.WeekDaysCheckEdit();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clndr.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlheader.Controls.Add(this.btninvetory);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(900, 55);
            this.pnlheader.TabIndex = 10;
            // 
            // btninvetory
            // 
            this.btninvetory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btninvetory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btninvetory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btninvetory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btninvetory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninvetory.Image = ((System.Drawing.Image)(resources.GetObject("btninvetory.Image")));
            this.btninvetory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninvetory.Location = new System.Drawing.Point(753, 0);
            this.btninvetory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninvetory.Name = "btninvetory";
            this.btninvetory.Padding = new System.Windows.Forms.Padding(0, 0, 20, 3);
            this.btninvetory.Size = new System.Drawing.Size(147, 55);
            this.btninvetory.TabIndex = 4;
            this.btninvetory.Text = "BACK";
            this.btninvetory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninvetory.UseVisualStyleBackColor = true;
            this.btninvetory.Click += new System.EventHandler(this.btninvetory_Click);
            // 
            // clndr
            // 
            this.clndr.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clndr.DateTime = new System.DateTime(2017, 7, 29, 0, 0, 0, 0);
            this.clndr.EditValue = new System.DateTime(2017, 7, 29, 0, 0, 0, 0);
            this.clndr.Location = new System.Drawing.Point(643, 74);
            this.clndr.Name = "clndr";
            this.clndr.Size = new System.Drawing.Size(232, 222);
            this.clndr.TabIndex = 11;
            // 
            // weekDaysCheckEdit1
            // 
            this.weekDaysCheckEdit1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.weekDaysCheckEdit1.Appearance.Options.UseBackColor = true;
            this.weekDaysCheckEdit1.Location = new System.Drawing.Point(513, 317);
            this.weekDaysCheckEdit1.Name = "weekDaysCheckEdit1";
            this.weekDaysCheckEdit1.Size = new System.Drawing.Size(350, 101);
            this.weekDaysCheckEdit1.TabIndex = 13;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(192)))), ((int)(((byte)(206)))));
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(24, 331);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Padding = new System.Windows.Forms.Padding(0, 0, 20, 3);
            this.btnsave.Size = new System.Drawing.Size(147, 55);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "SAVE";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(119)))), ((int)(((byte)(112)))));
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(187, 331);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncancel.Name = "btncancel";
            this.btncancel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 3);
            this.btncancel.Size = new System.Drawing.Size(147, 55);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "CANCEL";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2017, 7, 29, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(513, 109);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Size = new System.Drawing.Size(99, 20);
            this.timeEdit1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Title";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Honeydew;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(21, 88);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(324, 41);
            this.bunifuMaterialTextbox1.TabIndex = 17;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Honeydew;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(21, 143);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(324, 41);
            this.bunifuMaterialTextbox2.TabIndex = 19;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Status";
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Honeydew;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(21, 257);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(324, 41);
            this.bunifuMaterialTextbox3.TabIndex = 23;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Location";
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Honeydew;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(21, 202);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(324, 41);
            this.bunifuMaterialTextbox4.TabIndex = 21;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddingSchedule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(900, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuMaterialTextbox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuMaterialTextbox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeEdit1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.weekDaysCheckEdit1);
            this.Controls.Add(this.clndr);
            this.Controls.Add(this.pnlheader);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddingSchedule_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddingSchedule_Form";
            this.Load += new System.EventHandler(this.AddingSchedule_Form_Load);
            this.pnlheader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clndr.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekDaysCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private DevExpress.XtraEditors.Controls.CalendarControl clndr;
        private DevExpress.XtraScheduler.UI.WeekDaysCheckEdit weekDaysCheckEdit1;
        private System.Windows.Forms.Button btninvetory;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
    }
}