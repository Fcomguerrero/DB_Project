using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Login: Form
    {    
        public Login()
        {
            InitializeComponent();         
        }
        //*****************************************************************************************
        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        //*****************************************************************************************
        private void bt_Login_Click(object sender, EventArgs e)
        {
            //Conexion
            Conexion cnnx = new Conexion();

            //check de textBox Vacios
            if (textBox_user.Text.Trim() == "")
            {
                MessageBox.Show("Enter User");
                textBox_user.Focus();
            }
            else if (textBox_pass.Text.Trim() == "")
            {
                MessageBox.Show("Enter Password");
                textBox_pass.Focus();
            }
            else
            {
                //validacion de usuario y clave
                string strinCONN = string.Format("SELECT * FROM Login WHERE usuario='{0}' AND password='{1}'", textBox_user.Text.ToLower().Trim(), textBox_pass.Text.ToLower().Trim());
                Boolean consulResul = cnnx.ConsultaResul(strinCONN);
                
                if (consulResul)
                {
                    textBox_pass.Enabled = false;
                    textBox_user.Enabled = false;
                    bt_Login.Enabled = false;
                    //llamar al Menu
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Visible = true;                    
                }
                else
                {
                    MessageBox.Show("Error... Check your credentials");
                    textBox_user.Clear();
                    textBox_pass.Clear();
                    textBox_user.Focus();
                }
            }
        }
        //*****************************************************************************************
        private void textBox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                bt_Login_Click((object)sender, (EventArgs)e);
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                e.Handled = true;
                textBox_pass.Text = "";
            }
            else
            {
                // Lo que hará en cualquier otro caso
            }
        }
        //*****************************************************************************************
    }
}
