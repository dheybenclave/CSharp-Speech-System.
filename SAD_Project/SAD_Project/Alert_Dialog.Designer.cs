namespace SAD_Project
{
    partial class Alert_Dialog
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
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.pnlmessage = new System.Windows.Forms.Panel();
            this.btnyes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlmessage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.BackColor = System.Drawing.Color.Transparent;
            this.lblmessage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.Transparent;
            this.lblmessage.Location = new System.Drawing.Point(2, 57);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(259, 17);
            this.lblmessage.TabIndex = 0;
            this.lblmessage.Text = "Do you want to close this application?";
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnno
            // 
            this.btnno.BackColor = System.Drawing.Color.Transparent;
            this.btnno.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnno.FlatAppearance.BorderSize = 0;
            this.btnno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnno.ForeColor = System.Drawing.Color.Transparent;
            this.btnno.Location = new System.Drawing.Point(148, 0);
            this.btnno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(224, 46);
            this.btnno.TabIndex = 18;
            this.btnno.Text = "NO";
            this.btnno.UseVisualStyleBackColor = false;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // pnlmessage
            // 
            this.pnlmessage.BackColor = System.Drawing.Color.Transparent;
            this.pnlmessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmessage.Controls.Add(this.lblmessage);
            this.pnlmessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmessage.ForeColor = System.Drawing.Color.Transparent;
            this.pnlmessage.Location = new System.Drawing.Point(0, 0);
            this.pnlmessage.Name = "pnlmessage";
            this.pnlmessage.Size = new System.Drawing.Size(455, 94);
            this.pnlmessage.TabIndex = 19;
            // 
            // btnyes
            // 
            this.btnyes.BackColor = System.Drawing.Color.Transparent;
            this.btnyes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnyes.FlatAppearance.BorderSize = 0;
            this.btnyes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnyes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyes.ForeColor = System.Drawing.Color.Transparent;
            this.btnyes.Location = new System.Drawing.Point(0, 0);
            this.btnyes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(148, 46);
            this.btnyes.TabIndex = 20;
            this.btnyes.Text = "YES";
            this.btnyes.UseVisualStyleBackColor = false;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnno);
            this.panel2.Controls.Add(this.btnyes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 48);
            this.panel2.TabIndex = 21;
            // 
            // Alert_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(455, 142);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlmessage);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Alert_Dialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alert_Dialog";
            this.Load += new System.EventHandler(this.Alert_Dialog_Load);
            this.pnlmessage.ResumeLayout(false);
            this.pnlmessage.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Panel pnlmessage;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Panel panel2;
    }
}