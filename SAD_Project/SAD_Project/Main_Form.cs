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
using Bunifu.Framework.Lib;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraEditors.Controls;
using Microsoft.Win32;
using System.Diagnostics;
using System.Speech.Synthesis;



namespace SAD_Project
{
    public partial class Main_Form : Form
    {
        MySqlDataAdapter adapt;
        DataTable table = new DataTable();
        MySqlCommand cmd;
        Db_Utilities db = new Db_Utilities();
        Responsive res = new Responsive();
        Point p;
        TextBox subtextbox = new TextBox();
        int TMove, MX, MY, countfade, done, count_id = 0;
        string max, showpassword = "on";
        string idshow, position, user_id = "";
        bool fadenow, editconnection, editdone, collapse = false;
        public static bool onshow, ifeditconnection, ifcreateaccount = false;
       
        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "NursingScehduler";
        

        public Main_Form()
        {
            
            InitializeComponent();
            SetStartup();
            res.generateresponsive(this);
            forbuttonstop();
            clndrsched.Focus();
            clndrsched.TodayDate = DateTime.Now;
        }
   

        private static void SetStartup()
        {
            //Set the application to run at startup
            RegistryKey key = Registry.CurrentUser.OpenSubKey (StartupKey, true);
            key.SetValue(StartupValue, Application.ExecutablePath.ToString());
            MessageBox.Show("Created");
        }

        void Shutdown()
        {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        private void speech(string speak) // defining the function which will accept a string parameter
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult); // to change VoiceGender and VoiceAge check out those links below
            synthesizer.Volume = 100;  // (0 - 100)
            synthesizer.Rate = 0;     // (-10 - 10)       
            synthesizer.SpeakAsync(speak); // here args = pran
        }     
         


        public void forbuttonstop()
        {
            res.resizepanelbutton_W(btnschedule, pnltoptab, 4);
            res.resizepanelbutton_W(btnduties, pnltoptab, 4);
            res.resizepanelbutton_W(btninvetory, pnltoptab, 4);
        }


        private void pnlheader_MouseMove(object sender, MouseEventArgs e)
        {
            if (TMove == 1) this.SetDesktopLocation(MousePosition.X - MX, MousePosition.Y - MY);

            if (MousePosition.Y - MY <= 1)
            { max = "off"; this.WindowState = FormWindowState.Maximized; }
            forbuttonstop();
          
        }


        private void pnlheader_DoubleClick(object sender, EventArgs e)
        { res.adjustpanel(this); forbuttonstop(); }

        private void pnlheader_MouseUp(object sender, MouseEventArgs e)
        { TMove = 0; }

        private void pnlheader_MouseDown(object sender, MouseEventArgs e)
        { TMove = 1; MX = e.X; MY = e.Y;}

        private void btnclose_Click(object sender, EventArgs e)
        {
            Alert_Dialog ad = new Alert_Dialog(); ad.ShowDialog();
            // Confirmation_Dialog cd = new Confirmation_Dialog(); cd.ShowDialog();
        }

        private void btnmaxmin_Click(object sender, EventArgs e)
        { res.adjustpanel(this);
          forbuttonstop();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized;}

        private void btnschedule_Click(object sender, EventArgs e)
        {
            tab_main.SelectedTabPageIndex = 0;
           
        }

   

        private void button1_Click(object sender, EventArgs e)
        {

            tab_main.SelectedTabPageIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tab_main.SelectedTabPageIndex = 2;
        }

        private void tmsidenav_Tick(object sender, EventArgs e)
        {
           if (done == 1) { if (!(pnlschedleft.Width >= 215)) { pnlschedleft.Width +=55; } else { tmsidenav.Stop(); } }
           if (done == 0) { if (pnlschedleft.Width != 0) { pnlschedleft.Width -=55; } else { tmsidenav.Stop(); } }
        }

        private void btnpnlschedleftclose_Click(object sender, EventArgs e)
        {
            done = 0;
            tmsidenav.Start();
            
        }

        private void clndrsched_DateTimeChanged(object sender, EventArgs e)
        {
            if (clndrsched.DateTime.ToString() != "")
            {
                done = 1;
                tmsidenav.Start();
                dtdate.Value = clndrsched.DateTime;
                lbldateselected.Text = clndrsched.DateTime.ToLongDateString();
            }

 
        }
        
        private void Main_Form_Resize(object sender, EventArgs e)
        {
            if (pnlschedleft.Width != 0)
            {
                if (this.WindowState == FormWindowState.Maximized) { clndrsched.CellPadding = new Padding(60, 40, 60, 40);  }
                else { clndrsched.CellPadding = new Padding(20, 27, 20, 27); }
            }
            else {

                if (this.WindowState == FormWindowState.Maximized) { clndrsched.CellPadding = new Padding(75, 40, 75, 40); }
                else { clndrsched.CellPadding = new Padding(35, 27, 35, 27); }             
            }
        }

        private void tmforform_Tick(object sender, EventArgs e)
        {
            while (pnlleft.Width != 0) { pnlleft.Width-=25; }
            if (pnlleft.Width <= 0) { tmforform.Stop(); }
        }

        private void btnforsched_Click(object sender, EventArgs e)
        {
           // tmforform.Start();
            pnlleft.Width = 0;
        }

        private void dtdate_ValueChanged(object sender, EventArgs e)
        {
            clndrsched.DateTime = dtdate.Value;
        }


        private void clndrsched_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void clndrsched_MouseClick(object sender, EventArgs e)
        {
 
        }

        private void clndrsched_MouseHover(object sender, EventArgs e)
        {
        }

        private void clndrsched_MouseEnter(object sender, EventArgs e)
        {
        }

        private void clndrsched_MouseMove(object sender, MouseEventArgs e)
        {
            lbldateselected.Text = clndrsched.HotDate.GetValueOrDefault().ToLongDateString();

        }

        private void lbldateselected_TextChanged(object sender, EventArgs e)
        {
            if (lbldateselected.Text != "Monday, January 01, 0001" && lbldateselected.Text != "")
            {
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 5000;
                toolTip1.AutomaticDelay = 5000;

                speech("you select " + lbldateselected.Text.ToString());
                toolTip1.SetToolTip(clndrsched, lbldateselected.Text);
            }
            else { lbldateselected.Text = ""; }

           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddingSchedule_Form asf = new AddingSchedule_Form();
            asf.ShowDialog();
        }
    }
}
