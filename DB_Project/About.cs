using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        //************************************************************************************
        private void About_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;

        }
        //************************************************************************************
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.Fixed3D;
        }
        //***********************************************************************************
        private void About_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }
        //************************************************************************************
    }
}
