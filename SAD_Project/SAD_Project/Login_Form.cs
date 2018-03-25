using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using SAD_Project;

namespace SAD_Projectogin
{
    public partial class Login_Form : Form
    {
        // DEFAULI WINDOWS SIZE 1000,666
        // CUSTOMIZE USER INTERFACEe
        // DHEO BENSURTO CLAVERIA (BSCS 2014- 2018) - NAVOTAS POLYTECHNIC COLLEGE
        // CONTACT: dheybenclave@gmail.com || dheo_claveria@yahoo.com || dheybenclave
        //475, 598
        MySqlDataAdapter adapt;
        DataTable table = new DataTable();
        MySqlCommand cmd;
        Db_Utilities db = new Db_Utilities();
        Responsive res=  new Responsive ();
        Point p;
        TextBox subtextbox = new TextBox();
        int TMove, MX, MY, countfade, done,count_id  = 0;
        string max, showpassword = "on";
        string idshow,position, user_id = "";
        bool fadenow, editconnection, editdone = false;
        public  static bool onshow,ifeditconnection, ifcreateaccount = false;
        Splash_Form sf = new Splash_Form();
             


        public Login_Form()
        {
            InitializeComponent();

            res.generateresponsive(this);
            btnmaxmin.Enabled = false;
            subtextbox = txtpasswordlogin;
            pnlbody_events.Size = new System.Drawing.Size(0, 598);
            timer1.Start(); this.Visible = false;
            sf.ShowDialog();

            if (db.OpenConnection() == null)
            {
                subtextbox = txtpassword;
                pnlbody_events.Size = new System.Drawing.Size(475, 598);
                pnlconnect.BringToFront();
                pnlconnect.BringToFront();
                pnlconnect.Location = new Point(res.autocenterobjects_X(pnlconnect.Width, pnlbody_events.Width), 25);
                lblnoitfconnect.Location = new Point(res.autocenterobjects_X(lblnoitfconnect.Width, pnlbody_events.Width), this.lblnoitfconnect.Bounds.Y);
         
                pnlconnect.Visible = true;
                pnlnavbutton.Visible = false;
                lblcanceledit.Enabled = false;
            }
            else
            {
                lblcanceledit.Enabled = true;
                pnllogin.BringToFront();
                pnllogin.BringToFront();
                pnllogin.Location = new Point(res.autocenterobjects_X(pnllogin.Width, pnlbody_events.Width), 25);
                lblnoitfconnect.Location = new Point(res.autocenterobjects_X(lblnoitfconnect.Width, pnlbody_events.Width), this.lblnoitfconnect.Bounds.Y);
                pnllogin.Visible = true;
                onloadlogo();
            }
        }
     

        private void pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (TMove == 1) this.SetDesktopLocation(MousePosition.X - MX, MousePosition.Y - MY);

            //if (MousePosition.Y - MY <= 1)
            //{ max = "off"; this.WindowState = FormWindowState.Maximized; }
        }

        private void pnlheader_MouseUp(object sender, MouseEventArgs e)
        { TMove = 0; }

        private void pnlheader_MouseDown(object sender, MouseEventArgs e)
        { TMove = 1; MX = e.X; MY = e.Y; }

        private void btnclose_Click(object sender, EventArgs e)
        { 
            Alert_Dialog ad = new Alert_Dialog(); ad.ShowDialog();
      
        }

        private void btnmaxmin_Click(object sender, EventArgs e)
        { res.adjustpanel(this); }

        private void btnminimize_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }


        private void pnlheader_DoubleClick(object sender, EventArgs e)
        { //adjustpanel();
        }

        public void onloadlogo()
        {
            pblogo.Location = new Point(res.autocenterobjects_X(pblogo.Width, pnlstart.Width), pblogo.Bounds.Y);
            lblcompanyname.Location = new Point(res.autocenterobjects_X(lblcompanyname.Width, pnlstart.Width), lblcompanyname.Bounds.Y);
            lblcompanynamesub.Location = new Point(res.autocenterobjects_X(lblcompanynamesub.Width, pnlstart.Width), lblcompanynamesub.Bounds.Y);
            pnlnavbutton.Location = new Point(res.autocenterobjects_X(pnlnavbutton.Width, pnlstart.Width), pnlnavbutton.Bounds.Y);
        }


        private void Login_Form_Load(object sender, EventArgs e)
        {
            notiflogin.BalloonTipText = "TimeSchedule";
            notiflogin.BalloonTipTitle = "Nursing Scheduler";
        }

        private void pnlbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (showpassword == "on")
            {
                showpassword = "off";
                subtextbox.UseSystemPasswordChar = false;
            }
            else
            {
                showpassword = "on";
                subtextbox.UseSystemPasswordChar = true;
            }
        }



        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (txtserver.Text == "" || txtport.Text == "" || txtdatabase.Text == "" || txtusername.Text == "" || txtpassword.Text == "")
            {
                lblnoitfconnect.Text = "PLEASE COMPLETE THE SET-UP!.";
            }
            else
            {
                lbleditconnection.Enabled = lbladdaccount.Enabled = lblforgetpassword.Enabled = false;
                db.server = txtserver.Text;
                db.port = txtport.Text;
                db.database = txtdatabase.Text;
                db.username = txtusername.Text;
                db.password = txtpassword.Text;

                try
                {
                    db.SaveSettings();
                    db.OpenConnection();

                    if (db.OpenConnection() != null)
                    {
                        lblnoitfconnect.Text = lblnotifllogin.Text = "YOUR DATABASE CONNECTION IS SUCCESS.";
                        txtpassword.Text = txtport.Text = txtserver.Text = txtusername.Text = "";

                        pnllogin.Enabled = lbladdaccount.Enabled = lbleditconnection.Enabled = lblforgetpassword.Enabled = true;
                        pnllogin.Location = new Point(res.autocenterobjects_X(pnlconnect.Width, pnlbody_events.Width), 25);
                        lblnoitfconnect.Location = new Point(res.autocenterobjects_X(lblnoitfconnect.Width, pnlbody_events.Width), this.lblnoitfconnect.Bounds.Y);
                        pnllogin.BringToFront();
                    }
                    else { lblnoitfconnect.Text = "YOUR DATABASE CONNECTION IS NOT VALID"; lblcanceledit.Enabled = false; }
                }
                catch
                {
                    lblnoitfconnect.Text = "YOUR DATABASE CONNECTION IS NOT VALID";
                    lblcanceledit.Enabled = false;
                }
            }
            lblnoitfconnect.Location = new Point(res.autocenterobjects_X(lblnoitfconnect.Width, pnlconnect.Width), this.lblnoitfconnect.Bounds.Y);
            lblnoitfconnect.Visible = true;
        }

        public void forbuttons(Panel p, TextBox t)
        {
            subtextbox = t;
            p.Visible = true;
            p.BringToFront();
            pnlbody_events.Size = new System.Drawing.Size(475, 598);
            p.Location = new Point(res.autocenterobjects_X(pnllogin.Width, pnlbody_events.Width), 25);
            lblnoitfconnect.Location = new Point(res.autocenterobjects_X(lblnoitfconnect.Width, pnlconnect.Width), this.lblnoitfconnect.Bounds.Y);
            lblcanceladd.Location = lblcanceledit.Location = new Point(res.autocenterobjects_X(lblcanceladd.Width, pnlconnect.Width), this.lblcanceledit.Bounds.Y);
            lblcanceledit.Enabled = lblcanceladd.Enabled =  true;
            onloadlogo();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            txtusernamelogin.Focus();
            pnlconnect.Visible = pnladdaccount.Visible = pnlnavbutton.Visible = pnlmanage.Visible =  false;
            pnlrecover.Enabled = true;
            forbuttons(pnllogin,txtpasswordlogin);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtserver.Focus();
            pnllogin.Visible = pnladdaccount.Visible = pnlnavbutton.Visible = false;
            forbuttons(pnlconnect,txtpassword);
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            txtaddusername.Focus();
            pnllogin.Visible = pnlconnect.Visible = pnlnavbutton.Visible = false;
            forbuttons(pnladdaccount,txtaddpassword);
        }
        public void Login()
        {

            try
            {
                if (txtusernamelogin.Text != "" && txtpasswordlogin.Text != "")
                {
                    string query = "SELECT * FROM db_nursing_scheduler_system.tbl_user WHERE  user_username ='" + txtusernamelogin.Text +
                                                "' AND user_password = '" + txtpasswordlogin.Text + "';";
                    adapt = new MySqlDataAdapter(query, db.OpenConnection());
                    table.Clear();
                    adapt.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow dr in table.Rows)
                        {
                            position = dr[4].ToString();
                            this.Visible = false;
                        }
                    }
                    else { lblnotifllogin.Text = "NO ACCOUNT FOUND!."; }
                    switch (position)
                    {
                        case "user": Main_Form mf = new Main_Form(); mf.Show(); break;
                        case "admin": MessageBox.Show("admin"); break;
                    }

                }
                else if (txtusernamelogin.Text == "" || txtpasswordlogin.Text == "")
                { lblnotifllogin.Text = "PLEASE FILL ALL REQUIREMENTS!."; }
                else { lblnotifllogin.Text = "NO ACCOUNT FOUND!."; }


                lblnotifllogin.Location = new Point(res.autocenterobjects_X(lblnotifllogin.Width, pnllogin.Width), this.lblnotifllogin.Bounds.Y);
                lblnotifllogin.Visible = true;

            }
            catch { MessageBox.Show("this"); }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txtusernamelogin_TextChanged(object sender, EventArgs e)
        {    lblnotifllogin.Visible = false;}

        private void txtpasswordlogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            { Login(); }
        }


        public void AddAccount()
        {
            try
            {
                adapt = new MySqlDataAdapter("SELECT user_id  FROM db_nursing_scheduler_system.tbl_user order by last_insert_id(user_last_insert) DESC LIMIT 1;", db.OpenConnection());
                table = new DataTable(); adapt.Fill(table);
                if (table.Rows.Count > 0)
                { foreach (DataRow dr in table.Rows) { count_id = Convert.ToInt32(dr[0]) + 1; } }
                else { }
               

                cmd = new MySqlCommand("AddAccount", db.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    cmd.Parameters.Add(new MySqlParameter("?user_id", count_id));
                    cmd.Parameters.Add(new MySqlParameter("?user_username1", txtaddusername.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_password", txtaddpassword.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_recovery_password", txtaddrecovery.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_position", txtaddposition.Text.ToLower()));
                    cmd.Parameters.Add(new MySqlParameter("?user_last_insert", DateTime.Now.ToString("yyyy-MM-dd HHH:MM:ss")));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }   

        private void btnaddapply_Click(object sender, EventArgs e)
        {
            if (txtaddusername.Text != "" && txtaddpassword.Text != "" && txtaddrecovery.Text != "" && txtaddposition.Text != "")
            {

                string query = "SELECT * FROM db_nursing_scheduler_system.tbl_user WHERE user_username ='" + txtaddusername.Text + "';";

                adapt = new MySqlDataAdapter(query, db.OpenConnection());
                table = new DataTable();
                adapt.Fill(table);

                if (table.Rows.Count > 0)
                {

                    lblnotificationaddaccount.Text = txtaddusername.Text.ToUpper() + " HAS ALREADY EXIST!.";
                    lblnotificationaddaccount.ForeColor = Color.OrangeRed;
                }
                else
                {
                    AddAccount();
                    lblnotificationaddaccount.Text = "ADD ACCOUNT SUCCESS!.";
                    lblnotificationaddaccount.ForeColor = Color.SeaGreen;
                }
            }
            else
            { lblnotificationaddaccount.Text = "PLEASE FILL ALL THE REQUIREMENTS!."; lblnotificationaddaccount.ForeColor = Color.OrangeRed; }
     
            lblnotificationaddaccount.Location = new Point(res.autocenterobjects_X(lblnotificationaddaccount.Width, pnladdaccount.Width), this.lblnotificationaddaccount.Bounds.Y);
            lblnotificationaddaccount.Visible = true;
        
        }

        private void lblhomeadd_Click(object sender, EventArgs e)
        {
            pnlbody_events.Size = new Size(0, pnlbody_events.Height);
            pnlnavbutton.Visible = true;
            onloadlogo();
        }

        private void lblcreateaccountcheck_Click(object sender, EventArgs e)
        {
            if (txtaddusername.Text != "")
            {
                adapt = new MySqlDataAdapter("SELECT user_username FROM db_nursing_scheduler_system.tbl_user WHERE user_username ='" + txtaddusername.Text + "';", db.OpenConnection());
                table = new DataTable();
                adapt.Fill(table);
                if (table.Rows.Count > 0)
                {
                    lblnotificationaddaccount.Text = txtaddusername.Text.ToUpper() + " HAS ALREADY EXIST!.";
                    lblnotificationaddaccount.ForeColor = Color.OrangeRed;
                }
                else
                {
                    lblnotificationaddaccount.Text = "USERNAME ARE AVAILABLE";
                    lblnotificationaddaccount.ForeColor = Color.SeaGreen;
                }
                lblnotificationaddaccount.Location = new Point(res.autocenterobjects_X(lblnotificationaddaccount.Width, pnladdaccount.Width), this.lblnotificationaddaccount.Bounds.Y);
                lblnotificationaddaccount.Visible = true;
            }
            else { }
        }

        private void pnlrecover_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblchangeaccount_Click(object sender, EventArgs e)
        {
            subtextbox = txtmanagepassword;
            txtmanageusername.Focus();
            lblheaderstatus.Text = " MANAGE ACCOUNT";
            txtmanageusername.Text = txtusernamerecovery.Text;
            txtmanagerecoverypassword.Text = txtrecoverypassword.Text;
            txtmanagepassword.Text = lblshowpassword.Text;
            pnlmanage.Visible = true;
            pnlrecover.Enabled = lblnotifrecovery.Visible = lblchangeaccount.Visible = false;
            txtrecoverypassword.Text = txtusernamerecovery.Text = lblshowpassword.Text = "";
            iconotif.BackColor = Color.Transparent;
        }

        private void lblforgetpassword_Click(object sender, EventArgs e)
        {
            forbuttons(pnlforgetpassword, txtrecoverypassword);
        }

        private void UpdateAccount()
        {
            {
                try
                {
                    cmd = new MySqlCommand("UpdateAccount", db.OpenConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        cmd.Parameters.Add(new MySqlParameter("?user_username", txtmanageusername.Text));
                        cmd.Parameters.Add(new MySqlParameter("?user_password", txtmanagepassword.Text));
                        cmd.Parameters.Add(new MySqlParameter("?user_recovery_password", txtmanagerecoverypassword.Text));
                        cmd.Parameters.Add(new MySqlParameter("?user_id1", user_id));
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }

                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }

            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtmanageusername.Text != "" && txtmanagepassword.Text != "" && txtmanagerecoverypassword.Text != "")
            {
                UpdateAccount();

                adapt = new MySqlDataAdapter("SELECT * FROM tbl_user WHERE user_id ='" + user_id + " ';", db.OpenConnection());
                table = new DataTable();
                adapt.Fill(table);

                foreach (DataRow dr2 in table.Rows)
                {
                    user_id = dr2[0].ToString();
                    txtmanageusername.Text = dr2[1].ToString();
                    txtmanagepassword.Text = dr2[2].ToString();
                    txtmanagerecoverypassword.Text = dr2[3].ToString();
                }

                lblmanagenotif.Text = "UPDATE ACCOUNT SUCCESS!.";
                pnlrecover.Enabled = true;
                lblmanagenotif.ForeColor = Color.SeaGreen;
            }
            else
            {
                lblmanagenotif.Text = "PLEASE FILL ALL THE REQUIREMENTS!.";
                lblmanagenotif.ForeColor = Color.OrangeRed;
            }
            lblmanagenotif.Visible = true;
        }

 

        private void btnrecover_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusernamerecovery.Text != "" && txtrecoverypassword.Text != "")
                {
                    string query = "SELECT * FROM tbl_user WHERE user_username = '" + txtusernamerecovery.Text + "' AND user_recovery_password ='" + txtrecoverypassword.Text + "';";
                    adapt = new MySqlDataAdapter(query, db.OpenConnection());
                    table = new DataTable();
                    adapt.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        lblnotifrecovery.Text = " YOUR OLD PASSWORD IS :";
                        lblnotifrecovery.Visible = lblchangeaccount.Visible = lblshowpassword.Visible = true;
                        iconotif.BackColor = lblnotifrecovery.ForeColor = Color.SeaGreen;
                        foreach (DataRow dr in table.Rows)
                        {
                            lblshowpassword.Text = dr[2].ToString();
                            user_id = dr[0].ToString();

                        }
                    }
                    else
                    { lblnotifrecovery.Text = " NO ACCOUNT FOUND!."; iconotif.BackColor = lblnotifrecovery.ForeColor = Color.OrangeRed; }
                }
                else { lblnotifrecovery.Text = "PLEASE FILL ALL THE REQUIREMENTS!."; lblnotifrecovery.ForeColor = Color.OrangeRed; }
                lblnotifrecovery.Visible = iconotif.Visible = true;
            }
            catch { }
        }

        private void lblrecoverycheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusernamerecovery.Text != "")
                {
                    adapt = new MySqlDataAdapter("SELECT * FROM tbl_user WHERE user_username = '" + txtusernamerecovery.Text + "';", db.OpenConnection());
                    table = new DataTable();
                    adapt.Fill(table);
                    if (table.Rows.Count > 0)
                    { lblnotifrecovery.Text = " YOUR USERNAME ARE FOUND!."; lblnotifrecovery.Visible = iconotif.Visible = true; iconotif.BackColor = lblnotifrecovery.ForeColor = Color.SeaGreen; }
                    else
                    { lblnotifrecovery.Text = " NO USERNAME FOUND!."; lblnotifrecovery.Visible = iconotif.Visible = true; iconotif.BackColor = lblnotifrecovery.ForeColor = Color.OrangeRed; }
                }
                else { }
            }
            catch { }
        }

        private void txtusernamelogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void txtusernamerecovery_Click(object sender, EventArgs e)
        {lblmanagenotif.Visible = pnlmanage.Visible = false;}

        private void txtmanageusername_TextChanged(object sender, EventArgs e)
        { lblmanagenotif.Visible  = false; }

        private void txtusernamerecovery_TextChanged(object sender, EventArgs e)
        {lblnotifrecovery.Visible = iconotif.Visible = lblshowpassword.Visible = false;}

        private void timer1_Tick(object sender, EventArgs e)
        {
            countfade++;
            if (countfade == 3){  sf.Opacity -=10; sf.Visible = false;sf.Close();this.Visible = true; this.Focus(); timer1.Stop();}
        }

        private void notiflogin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           notiflogin.Visible = false;
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;

        }

        private void Login_Form_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notiflogin.Visible = true;
                ShowInTaskbar = false;

                notiflogin.BalloonTipIcon = ToolTipIcon.Warning;
                notiflogin.ShowBalloonTip(5000);
                notiflogin.InitializeLifetimeService();
            }
            else { }
        }

        private void notiflogin_Click(object sender, EventArgs e)
        {
            notiflogin.Visible = false;
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

    }
}
