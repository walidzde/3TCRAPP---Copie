using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;


namespace _3TCRAPP
{
    public class SqlDbConnect
    {
        private MySqlConnection _con;
        public MySqlCommand Cmd;
        private MySqlDataAdapter _da;
        private DataTable _dt;
        /***************************************************************************/
        public SqlDbConnect()
        {
            _con = new MySqlConnection(@"Data Source=localhost ; DataBase=acte; User ID=root; Password='' ; CHARSET=utf8");
            _con.Open();
            if (_con.State == ConnectionState.Open)
            {
                
                
            }
            

        }
        public bool connectionstateftw()
        {
            _con = new MySqlConnection(@"Data Source=localhost ; DataBase=acte; User ID=root; Password='' ");
            try
            {
                _con.Open();
                if (_con.State == ConnectionState.Open)
                {

                    return true;

                }
            }
            catch(Exception)
            {
                    return false;
            }
            return false;
        }
        /***************************************************************************/
        public void SqlQuery(string queryText)
        {
            Cmd = new MySqlCommand(queryText, _con);
        }
        /***************************************************************************/
        public DataTable QueryEx()
        {
            _da = new MySqlDataAdapter(Cmd);
            _dt = new DataTable();
            _da.Fill(_dt);
            return _dt;

        }
        /****************************************************************************/
        public void NonQueryEx()
        {
            Cmd.ExecuteNonQuery();
        }

    }
}
        
