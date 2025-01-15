using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kwa
{
    internal class attendClass
    {
        dbconnect connect = new dbconnect();
        public bool insertattend(DateTime A_date, string cid, string sid)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `attendence`( `Date`, `Class_ID`, `studentid`) VALUES (@date,@cid,@sid)", connect.getconnection);
            //@sub,@t,@grade,@grp,@day,@time
            command.Parameters.Add("@date", MySqlDbType.Date).Value = A_date;
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = cid;
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = sid;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)

            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;

            }

        }
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchdate(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `attendence`WHERE CONCAT( `Class_ID`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchsid(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `attendence`WHERE CONCAT( `studentid`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
