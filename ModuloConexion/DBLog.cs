using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloConexion
{
    class DBLog
    {


        private string server;
        private string dB;
        public string[] Authentication = { "Windows Authentication", "Sql Server Authentication" };
        private string user;
        private string password;

        public string Server { get => "server = " + server; set => server = value; }
        public string DB { get => "DataBase = " + dB; set => dB = value; }
        public string User { get => "User = " + user; set => user = value; }
        public string Password { get => "Password = " + password; set => password = value; }


        //Este metodo nos permite conectarnos a una base de datos sql server con autenticacion sql server
        public string AuthenticationSQL()
        {
            return Server + ";" + DB + ";" + User + ";" + Password;
        }

        //Este metodo nos permite conectarnos a una base de datos sql server con autenticacion windows
        public string AuthenticationWindows()
        {
            return Server + ";" + DB + ";" + "Integrated Security = true";
        }

        
       
    }





        
    
}
