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
    partial class Diagram : Form
    {
        public Diagram()
        {
            InitializeComponent();
        }
        //*****************************************************************        
        private void Diagram_Load(object sender, EventArgs e)
        {

        }
        //*****************************************************************
        private void Diagram_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
        }
    }
}
