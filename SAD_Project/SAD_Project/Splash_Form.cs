using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAD_Project
{
    public partial class Splash_Form : Form
    {
        public Splash_Form()
        {
            InitializeComponent();
            BackColor = Color.Gray;
                TransparencyKey = BackColor;
        }

        private void Splash_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
