using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class Menu : Form
    {        
        Conexion Connec = new Conexion();        

        public Menu()
        {
            InitializeComponent();
        }        
        //*********************************************************************************
        private void Menu_Load(object sender, EventArgs e)
        {
            this.bt_Esquema.DialogResult = DialogResult.Yes;  //boton para el Diagrama

            Ventas al = new Ventas();
            Comandos cm = new Comandos();
            //------------------------------------------
            //Invocamos al Evento
            //listar es un método                               //Comunicacion entre ventanas
            al.MiEvento += new Ventas.Delegado_Metodo(listar);
            cm.MiEvento += new Comandos.Delegado_MetodoCMD(listar);
            //------------------------------------------
            listar();
        }
        //*********************************************************************************
        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ventas
            Ventas n = new Ventas();
            n.Visible = true;
            //------------------------------------------            
            n.MiEvento += new Ventas.Delegado_Metodo(listar); //llama al Metodo listar con String VER Ventas.cs LINEA 175
            //Mostrar Ventas(objeto de ventas)                //Comunicacion entre ventanas
            n.Show();
            //------------------------------------------
        }
        //*********************************************************************************
        private void sQLComandoscmdToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Comandos cmd = new Comandos();
            cmd.Visible = true;
            //------------------------------------------            
            cmd.MiEvento += new Comandos.Delegado_MetodoCMD(listar); //llama al Metodo listar con String VER Comandos.cs LINEA 23            
            cmd.Show();                                              //Comunicacion entre ventanas
            //------------------------------------------
        }
        //*********************************************************************************
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if(MessageBox.Show("¿ Exit ?", "Exit", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {               
                Application.ExitThread();                                                                
            }                    
        }
        //*********************************************************************************
        //Metodo listar pasando String, Necesario para ventana SQL Comandos (CMD)
        public void listar(String stringRecibido)
        {
            if (stringRecibido != "")
            {                
                try
                {                    
                    string mitabla = "Tabla_DataTable";
                    Connec.sqlConn.Open();
                    SqlDataAdapter daList = new SqlDataAdapter(stringRecibido.ToString(), Connec.sqlConn);
                    DataTable dt = new System.Data.DataTable(mitabla);
                    daList.Fill(dt);
                    DGV.DataSource = dt;                              
                }
                catch (Exception e)
                {
                    MessageBox.Show("The SQL command is not Correct, check !");
                    MessageBox.Show(e.Message);
                }
                Connec.sqlConn.Close();               
            }
            else
            {
                listar();
            }                                        
        }   
        //*********************************************************************************
        public void listar()
        {
            Connec.sqlConn.Open();
            SqlDataAdapter daList = new SqlDataAdapter("Select * from ventas", Connec.sqlConn);
            DataSet dsList = new DataSet();
            daList.Fill(dsList, "ventas"); //Fill the list with the table

            //SHOW DATA
            DGV.DataSource = dsList;
            DGV.DataMember = "ventas";

            Connec.sqlConn.Close();
        }
        //************************************************************************************        
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            if (e.ColumnIndex == 0)  //if click column 0
            {
              
            }
        }
        //************************************************************************************
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }
        //************************************************************************************
        public void listarComboBox(string listaCombo)
        {
            try
            {
                string strin2 = listaCombo;
                string strin1 = "Select * from ";
                string CadenaConex = strin1 + strin2;

                Connec.sqlConn.Open();            
                SqlCommand cmd = Connec.sqlConn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = CadenaConex;

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter daList = new SqlDataAdapter(cmd);

                daList.Fill(dt); //Fill the list with the table

                //SHOW DATA
                DGV.DataSource = dt;                
            }
            catch (Exception e){
                MessageBox.Show(e.Message);
            }
            Connec.sqlConn.Close();
        }
        //********************************************************************************
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {                       
            listarComboBox(comboBox_Menu.Text.ToLower().ToString());            
        }
        //********************************************************************************
        private void bt_Esquema_Click(object sender, EventArgs e)
        {
            Diagram dg = new Diagram();
            dg.Show();
        }
        //*********************************************************************************
    }        
}
