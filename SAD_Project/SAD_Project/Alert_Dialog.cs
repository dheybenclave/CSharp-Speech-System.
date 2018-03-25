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

namespace SAD_Project
{
    public partial class Alert_Dialog : Form
    {

        // DEFAULI WINDOWS SIZE 1000,666
        // CUSTOMIZE USER INTERFACE
        // DHEO BENSURTO CLAVERIA (BSCS 2014- 2018) - NAVOTAS POLYTECHNIC COLLEGE
        // CONTACT: dheybenclave@gmail.com || dheo_claveria@yahoo.com || dheybenclave

        MySqlDataAdapter adapt;
        DataTable table = new DataTable();
        MySqlCommand cmd;
        Point p;
        string max = "on";

        Db_Utilities db = new Db_Utilities();
        Responsive res = new Responsive();

        public Alert_Dialog()
        {
            InitializeComponent();
            res.generateresponsive(this);
            btnyes.Size = new Size(this.Size.Width / 2 + 2, btnyes.Bounds.Height);
            lblmessage.Location = res.autocenterobjects_XY(lblmessage.Width, pnlmessage.Width, lblmessage.Height, pnlmessage.Height);
       
        }



        private void Alert_Dialog_Load(object sender, EventArgs e)
        {
            
        }

        private void btnyes_Click(object sender, EventArgs e)
        { Application.ExitThread(); }

        private void btnno_Click(object sender, EventArgs e)
        {this.Close();}

    

    }

}
