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


namespace ModuloConexion
{
    public partial class Conexion : Form
    {

        DBLog credencial = new DBLog();

        

        public Conexion()
        {
            InitializeComponent();

            autenticacion.Items.Add(credencial.Authentication[0]);
            autenticacion.Items.Add(credencial.Authentication[1]);
            

        }


        

        private void Conexion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Conectarse();
                MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            }
            catch
            {
                MessageBox.Show("No se puedo conectar a la base de datos, corrobore haber ingresado correctamente los datos para la conexion");
            }
            
            
        }




        /*
          Este metodo nos conecta con la base de datos ingresada ya sea que tenga autenticacion SQL o Windows
           Instacia un objeto de tipo DBLog, el cual toma como atributos los datos ingresados por el usuario en el formulario.    
        */    
    private void Conectarse()
        {           
            credencial.Server = textServer.Text;
            credencial.DB = textDB.Text;
            credencial.User = textUser.Text;
            credencial.Password = textPass.Text;
            
            SqlConnection Conexion = new SqlConnection();
                if(autenticacion.Text == credencial.Authentication[0])
            {
                Conexion.ConnectionString = credencial.AuthenticationWindows();
            }   else {
                Conexion.ConnectionString = credencial.AuthenticationSQL();
            }
                     


        }



        //Este evento muestra los campos usuario y contraseña solo si el usuario tiene autenticacion de sql server
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (autenticacion.Text == credencial.Authentication[1])
            {
                MessageBox.Show("Debe ingresar su usuario y contraseña SQL");
                label2.Visible = true;
                textUser.Visible = true;
                label3.Visible = true;
                textPass.Visible = true;

            }
            
            
        }
    }
}
