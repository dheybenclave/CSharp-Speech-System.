namespace SAD_Project
{
    partial class Confirmation_Dialog
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
            this.pnlfill = new System.Windows.Forms.Panel();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.txtconfirmpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlmessage = new System.Windows.Forms.Panel();
            this.lblmanagenotif = new System.Windows.Forms.Label();
            this.lblmessage = new System.Windows.Forms.Label();
            this.lblcancelconfirm = new System.Windows.Forms.Label();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlfill.SuspendLayout();
            this.pnlmessage.SuspendLayout();
            this.pnlbottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlfill
            // 
            this.pnlfill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlfill.Controls.Add(this.btnconfirm);
            this.pnlfill.Controls.Add(this.txtconfirmpassword);
            this.pnlfill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlfill.Location = new System.Drawing.Point(0, 69);
            this.pnlfill.Name = "pnlfill";
            this.pnlfill.Size = new System.Drawing.Size(455, 47);
            this.pnlfill.TabIndex = 22;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnconfirm.FlatAppearance.BorderSize = 0;
            this.btnconfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnconfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirm.Location = new System.Drawing.Point(346, 0);
            this.btnconfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(91, 45);
            this.btnconfirm.TabIndex = 21;
            this.btnconfirm.Text = "CONFIRM";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconfirmpassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtconfirmpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtconfirmpassword.ForeColor = System.Drawing.Color.White;
            this.txtconfirmpassword.HintForeColor = System.Drawing.Color.Gray;
            this.txtconfirmpassword.HintText = "Input password here..";
            this.txtconfirmpassword.isPassword = false;
            this.txtconfirmpassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.txtconfirmpassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtconfirmpassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.txtconfirmpassword.LineThickness = 10;
            this.txtconfirmpassword.Location = new System.Drawing.Point(0, 0);
            this.txtconfirmpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Padding = new System.Windows.Forms.Padding(15, 0, 0, 5);
            this.txtconfirmpassword.Size = new System.Drawing.Size(346, 45);
            this.txtconfirmpassword.TabIndex = 20;
            this.txtconfirmpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlmessage
            // 
            this.pnlmessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmessage.Controls.Add(this.lblmanagenotif);
            this.pnlmessage.Controls.Add(this.lblmessage);
            this.pnlmessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmessage.Location = new System.Drawing.Point(0, 0);
            this.pnlmessage.Name = "pnlmessage";
            this.pnlmessage.Size = new System.Drawing.Size(455, 69);
            this.pnlmessage.TabIndex = 19;
            // 
            // lblmanagenotif
            // 
            this.lblmanagenotif.AutoSize = true;
            this.lblmanagenotif.BackColor = System.Drawing.Color.Transparent;
            this.lblmanagenotif.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanagenotif.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblmanagenotif.Location = new System.Drawing.Point(13, 50);
            this.lblmanagenotif.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblmanagenotif.Name = "lblmanagenotif";
            this.lblmanagenotif.Size = new System.Drawing.Size(174, 15);
            this.lblmanagenotif.TabIndex = 1008;
            this.lblmanagenotif.Text = "PLEASE COMPLETE THE SET-UP! .";
            this.lblmanagenotif.Visible = false;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.BackColor = System.Drawing.Color.Transparent;
            this.lblmessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.White;
            this.lblmessage.Location = new System.Drawing.Point(11, 8);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(365, 17);
            this.lblmessage.TabIndex = 0;
            this.lblmessage.Text = "We need a permission to Admin or with higher Position.\r\n";
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblcancelconfirm
            // 
            this.lblcancelconfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcancelconfirm.AutoSize = true;
            this.lblcancelconfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblcancelconfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcancelconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcancelconfirm.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Underline);
            this.lblcancelconfirm.ForeColor = System.Drawing.Color.White;
            this.lblcancelconfirm.Location = new System.Drawing.Point(11, 2);
            this.lblcancelconfirm.Name = "lblcancelconfirm";
            this.lblcancelconfirm.Size = new System.Drawing.Size(141, 16);
            this.lblcancelconfirm.TabIndex = 22;
            this.lblcancelconfirm.Text = "CANCEL CONFIRMATION";
            this.lblcancelconfirm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblcancelconfirm.Click += new System.EventHandler(this.lblcancelconfirm_Click);
            // 
            // pnlbottom
            // 
            this.pnlbottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbottom.Controls.Add(this.lblcancelconfirm);
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(0, 116);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(455, 26);
            this.pnlbottom.TabIndex = 22;
            // 
            // Confirmation_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(455, 142);
            this.Controls.Add(this.pnlfill);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnlmessage);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Confirmation_Dialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Confirmation_Dialog";
            this.Load += new System.EventHandler(this.Confirmation_Dialog_Load);
            this.pnlfill.ResumeLayout(false);
            this.pnlmessage.ResumeLayout(false);
            this.pnlmessage.PerformLayout();
            this.pnlbottom.ResumeLayout(false);
            this.pnlbottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlfill;
        private System.Windows.Forms.Panel pnlmessage;
        private System.Windows.Forms.Label lblmessage;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtconfirmpassword;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label lblcancelconfirm;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Label lblmanagenotif;
        private System.Windows.Forms.Timer timer1;
    }
}