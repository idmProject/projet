//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.OleDb;

//namespace IDM2
//{
//    class Database
//    {
//        private string m_name;

//        public Database(string name)
//        {
//            m_name = name;
//        }

//        public OleDbConnection MakeConnexion()
//        {
//            string connstr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + m_name;
//            OleDbConnection connection = new OleDbConnection(connstr);

//            return connection;
//        }

//        /// <summary>
//        /// Method to test the connection with the database
//        /// </summary>
//        public string TestConnexion()
//        {
//            OleDbConnection connection = MakeConnexion();

//            try 
//            {
//                connection.Open();
//                connection.Close();
//                return "";
//            }
//            catch (Exception ex)
//            {
//                return "Une erreur c'est produite \n" + ex.Message;
//            }
//        }

        
//    }
//}
