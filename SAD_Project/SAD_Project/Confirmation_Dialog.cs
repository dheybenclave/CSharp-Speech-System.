using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SAD_Project
{
    public partial class Confirmation_Dialog : Form
    {
        MySqlDataAdapter adapt;
        Db_Utilities db = new Db_Utilities();
        DataTable table = new DataTable();
        MySqlCommand cmd;
        Point p;
        string max = "on";

        public Confirmation_Dialog()
        {
            InitializeComponent();
            generateresponsive();
        }

        public void generateresponsive()
        {
            p.X = (Screen.PrimaryScreen.Bounds.Width / 2) - (this.Size.Width / 2);
            p.Y = (Screen.PrimaryScreen.Bounds.Height / 2) - (this.Size.Height / 2);
            this.Location = p;

            btnconfirm.Size = new Size(this.Width-txtconfirmpassword.Width-3,btnconfirm.Height);
            lblcancelconfirm.Location = autocenterobjects_XY(lblcancelconfirm.Width, pnlbottom.Width, lblcancelconfirm.Height, pnlbottom.Height+20);
            lblmessage.Location = autocenterobjects_XY(lblmessage.Width, pnlmessage.Width, lblmessage.Height, pnlmessage.Height);
        }

        public int autocenterobjects_X(int width, int basewidth)
        {
            int retval = 0;
            int cur = width;
            try
            {
                int ccur = basewidth / 2 - cur / 2;
                retval = ccur;
            }
            catch { }
            return retval;
        }

        public int autocenterobjects_Y(int height, int baseheight)
        {
            int retval = 0;
            int cur = height;
            try
            {
                int ccur = baseheight / 2 - cur / 2;
                retval = ccur;
            }
            catch { }
            return retval;
        }

        public Point autocenterobjects_XY(int width, int basewidth, int height, int baseheight)
        {
            // width and height = width/ height of your object that you want to center ex : buttons, groupbox, listview etc
            // basewidth and baseheight = the basement of your object that you want center ex: form, panel, groupbox 

            Point retval = new Point(width, height);
            int curx = width; int cury = height;
            try
            {
                Point newpoint = new Point(basewidth / 2 - curx / 2, baseheight / 2 - cury - 2);
                retval = newpoint;
            }
            catch { }
            return retval;
        }


        public void hoverborder(Button b)
        {
            if (b.Focus() == true)
            {
                b.FlatAppearance.BorderColor = b.BackColor;
            }
            else { b.FlatAppearance.BorderSize = 0; }
            b.FlatAppearance.BorderSize = 2;
        }

        private void Confirmation_Dialog_Load(object sender, EventArgs e)
        {

        }

        private void lblcancelconfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Position()
        { 
            //take for admin 
            
                string query = "SELECT user_position FROM db_nursing_scheduler_system.tbl_user WHERE user_password ='" + txtconfirmpassword.Text + "';";

                adapt = new MySqlDataAdapter(query, db.OpenConnection());
                table = new DataTable();
                adapt.Fill(table);

                if (table.Rows.Count == 1)
                {
                    foreach (DataRow dr in table.Rows)
                    { MessageBox.Show(dr[0].ToString()); }
                }
                else { MessageBox.Show("noe"); }
        }

        private void btnyes_Click(object sender, EventArgs e)
        {
            Position();
        }
    }
}
