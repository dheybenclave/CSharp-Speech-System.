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

namespace SAD_Project
{
    public partial class AddingSchedule_Form : Form
    {
        MySqlDataAdapter adapt;
        DataTable table = new DataTable();
        MySqlCommand cmd;
        Db_Utilities db = new Db_Utilities();
        Responsive res = new Responsive();
        int countfade;
        public AddingSchedule_Form()
        {
            InitializeComponent();
            res.generateresponsive(this);
        }

        private void AddingSchedule_Form_Load(object sender, EventArgs e)
        {

        }

        private void btninvetory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
