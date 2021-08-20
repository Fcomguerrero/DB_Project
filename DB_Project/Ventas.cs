using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Project
{
    
    public partial class Ventas : Form
    {
        
        Conexion conex = new Conexion();       

        //interface
        void activa_textos()    //activa los textBox para escribir
        {
            this.tbox_V_CodPro.Enabled = true;
            this.tbox_V_CodPie.Enabled = true;
            this.tbox_V_CodPj.Enabled = true;
            this.tbox_V_Cantidad.Enabled = true;            
        }
        //********************************************************************************************
        public void buscar()
        {
            try
            {
                //busca si existe                
                string sql = string.Format("SELECT codpro FROM ventas WHERE codpro='{0}'", tbox_V_CodPro.Text);
                Boolean resul = conex.ConsultaResul(sql);

                if (resul)
                {
                    MessageBox.Show("PROVIDER EXIST IN THE DATABASE");                                     
                    this.bt_N_Eliminar.Enabled = true;
                    this.bt_N_modificar.Enabled = true;
                    activa_textos();
                                        
                    SqlDataAdapter adp = new SqlDataAdapter("SELECT codpro,codpie,codpj,cantidad FROM ventas WHERE codpro='" + this.tbox_V_CodPro.Text + "'", conex.sqlConn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "ventas");
                    this.tbox_V_CodPro.Text = ds.Tables[0].Rows[0]["codpro"].ToString();
                    this.tbox_V_CodPie.Text = ds.Tables[0].Rows[0]["codpie"].ToString();
                    this.tbox_V_CodPj.Text = ds.Tables[0].Rows[0]["codpj"].ToString();
                    this.tbox_V_Cantidad.Text = ds.Tables[0].Rows[0]["cantidad"].ToString();                                                         
                    this.tbox_V_CodPie.Focus();                    
                }
                else
                {
                    MessageBox.Show("PROVIDER DOES NOT EXIST IN THE DATABASE");                    
                    this.bt_N_insertar.Enabled = true;
                    this.bt_N_Eliminar.Enabled = false;
                    this.bt_N_modificar.Enabled = false;                                       
                    activa_textos();                   
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR..." + exc);                
            }
        }
        //*******************************************************************************************
        public void insertar()
        {
            try
            {
                if (tbox_V_CodPro.Text == "" || tbox_V_CodPie.Text == "" || tbox_V_CodPj.Text == "")
                {
                    MessageBox.Show("PRIMARY KEYS CAN NOT STAY BLANK");
                }
                else
                {                    
                    SqlCommand cmd = new SqlCommand("INSERT INTO ventas(codpro,codpie,codpj,cantidad)VALUES('"
                    + this.tbox_V_CodPro.Text + "','" + this.tbox_V_CodPie.Text
                    + "','" + this.tbox_V_CodPj.Text
                    + "','" + this.tbox_V_Cantidad.Text + "')", conex.sqlConn);

                    conex.sqlConn.Open();
                    cmd.ExecuteNonQuery();
                    conex.sqlConn.Close();

                    MessageBox.Show("ADDED SUCCESSFULLY");
                    this.tbox_V_CodPro.Focus();                    
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("ERROR... NOT ADDED" + ee);
                conex.sqlConn.Close();
            }            
        }
        //****************************************************************************************
        public void modificar()
        {
            try
            {
                if (tbox_V_CodPro.Text == "" || tbox_V_CodPie.Text == "" || tbox_V_CodPj.Text == "")
                {
                    MessageBox.Show("PRIMARY KEYS CAN NOT STAY BLANK");
                }
                else
                {
                    //busca si existe la combinacion de Primary key en la tabla ventas                
                    string sql = string.Format("SELECT * FROM ventas WHERE ventas.codpro = '" + tbox_V_CodPro.Text + "' and ventas.codpie = '" + tbox_V_CodPie.Text + "' and ventas.codpj = '" + tbox_V_CodPj.Text + "'");
                    Boolean resul = conex.ConsultaResul(sql);
                    if (resul) //si existe hago esto
                    {
                        MessageBox.Show("PRIMARY KEYs: OK  :-D ");

                        string str = "UPDATE ventas SET cantidad = '" + tbox_V_Cantidad.Text + "' where ventas.codpro = '" + tbox_V_CodPro.Text + "' and ventas.codpie = '" + tbox_V_CodPie.Text + "' and ventas.codpj = '" + tbox_V_CodPj.Text + "'";
                        SqlCommand cmd = new SqlCommand(str, conex.sqlConn);
                        conex.sqlConn.Open();
                        cmd.ExecuteNonQuery();
                        conex.sqlConn.Close();
                        MessageBox.Show("MODIFIED SUCCESSFULLY");
                       
                        this.tbox_V_CodPro.Focus();
                    }
                    else {
                        MessageBox.Show("ERROR... PRIMARY KEYs: NOT FOUND");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR... NOT MODIFIED" + e);
                conex.sqlConn.Close();
            }
        }
        //***************************************************************************************
        public void eliminar()
        {
            try
            {
                //busca si existe la combinacion de Primary key en la tabla ventas                
                string sql = string.Format("SELECT * FROM ventas WHERE ventas.codpro = '" + tbox_V_CodPro.Text + "' and ventas.codpie = '" + tbox_V_CodPie.Text + "' and ventas.codpj = '" + tbox_V_CodPj.Text + "'");
                Boolean resul = conex.ConsultaResul(sql);

                if (resul) //si existe hago esto
                {
                    string str = "DELETE FROM ventas where ventas.codpro = '" + tbox_V_CodPro.Text + "' and ventas.codpie = '" + tbox_V_CodPie.Text + "' and ventas.codpj = '" + tbox_V_CodPj.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, conex.sqlConn);

                    conex.sqlConn.Open();
                    cmd.ExecuteNonQuery();
                    conex.sqlConn.Close();
                    MessageBox.Show("DELETED SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("ERROR... PRIMARY KEYs: NOT FOUND");
                }                
                this.tbox_V_CodPro.Focus();                
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR... NOT DELETED" + e);
                conex.sqlConn.Close();
            }
        }
        //***************************************************************************************
        //------------------------------------------
        Menu mn = new Menu();
        // Delegado
        public delegate void Delegado_Metodo(string mensaje);    //175
        //Evento
        public event Delegado_Metodo MiEvento;        
        //****************************************************************************************
        public Ventas()
        {
            InitializeComponent();
        }
        //****************************************************************************************
        private void Ventas_Load(object sender, EventArgs e) { }
        //****************************************************************************************
        //Botones de Control
        private void bt_N_Buscar_Click(object sender, EventArgs e)
        {
            buscar();
            this.MiEvento("SELECT * FROM ventas WHERE codpro='" + this.tbox_V_CodPro.Text + "'");
        }
        //*********************************************************************************
        private void bt_N_insertar_Click(object sender, EventArgs e)
        {            
            insertar();
            this.MiEvento("");
        }
        //*********************************************************************************
        private void bt_N_Eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
            this.MiEvento("");
        }
        //*********************************************************************************
        private void bt_N_modificar_Click(object sender, EventArgs e)
        {
            modificar();
            this.MiEvento("");
        }        
        //*********************************************************************************
        private void tbox_V_CodPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;           //eliminar el sonido al presionar la tecla
                buscar();
                this.MiEvento("SELECT * FROM ventas WHERE codpro='" + this.tbox_V_CodPro.Text + "'");
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                e.Handled = true;
                //limpiar textBox
                this.tbox_V_CodPro.Text = "";
                this.tbox_V_CodPie.Text = "";
                this.tbox_V_CodPj.Text = "";
                this.tbox_V_Cantidad.Text = "";                
            }
            else
            {
                //lo que haria en otro caso
            }
        }     
        //***************************************************************************************       
    }
}
