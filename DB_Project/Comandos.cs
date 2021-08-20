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
    public partial class Comandos : Form
    {
        public Comandos()
        {
            InitializeComponent();
        }
        //************************************************************************
        //------------------------------------------
        Menu mn = new Menu();                       //Comunicacion entre ventanas
        // Delegado
        public delegate void Delegado_MetodoCMD(string mensaje);    
        //Evento
        public event Delegado_MetodoCMD MiEvento;
        //------------------------------------------
        //************************************************************************
        private void Comandos_Load(object sender, EventArgs e)
        {
        }
        //************************************************************************
        private void textBox_SQL_CMD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                this.MiEvento(textBox_SQL_CMD.Text.ToLower().Trim());
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                e.Handled = true;
                //this.MiEvento("SELECT * FROM ventas"); //Actualiza el DataGridView
                this.textBox_SQL_CMD.Text = "";
            }
            else
            {
               // Lo que hará en cualquier otro caso
            }
        }
        //************************************************************************
    }
}
