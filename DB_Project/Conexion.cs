using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DB_Project
{
    class Conexion
    {
        //Declaracion de variables
        private string m_stringConexion;
        private SqlDataReader m_dr;
        private SqlDataAdapter m_da;
        private SqlConnection m_cnn;
        private SqlCommand cmd;
        
        //***************************************************************
        public Conexion()                   //Constructor
        {
            m_stringConexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DB_Proyecto;Data Source=DESKTOP-B7A7GH7";
            m_cnn = new SqlConnection(m_stringConexion);
        }
        //****************************************************************
        public Conexion(string cadenaConexion)
        {                                               //Constructor
            m_stringConexion = cadenaConexion;
            m_cnn = new SqlConnection(m_stringConexion);
        }
        //****************************************************************
        public Boolean ConsultaResul(string comando)        
        {
            //Devuelve un Boolean para indicar si la consulta obtuvo algun resultado
            Boolean resultado = false;

            if (m_cnn.State == ConnectionState.Closed)
            {
                m_cnn.Open();
            }

            cmd = new SqlCommand(comando, m_cnn);
            
            MessageBox.Show("A connection was successfully established with the server");

            Dr = cmd.ExecuteReader();
            
            if (Dr.Read()) {
                resultado = true;               
            }
            Dr.Close();
            m_cnn.Close();

            return resultado;
        }
        //****************************************************************
        public SqlDataAdapter Dadapter         //SqlDataAdapter
        {
            get { return m_da; }
            set { m_da = value; }
        }
        //****************************************************************
        public SqlDataReader Dr          //SqlDataReader
        {
            get { return m_dr; }
            set { m_dr = value; }
        }
        //****************************************************************
        public void abrir()             //Open Conexion
        {                                
            if (m_cnn.State == ConnectionState.Closed)
            {
                m_cnn.Open();
            }
        }
        //****************************************************************
        public void Cerrar()            //Close Conexion
        {                                                           
            if (m_cnn.State == ConnectionState.Open) {
                Dr.Close();
                m_cnn.Close();
            }
        }
        //****************************************************************
        public SqlConnection sqlConn
        {                               //Conseguir conexion de Tipo SqlConnection
            get { return m_cnn; }
            set { m_cnn = value; }
        }
        //****************************************************************
    }
}
