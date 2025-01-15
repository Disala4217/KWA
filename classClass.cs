using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kwa
{
    internal class classClass
    {
        dbconnect connect=new dbconnect();
        public bool insertCourse(string id,string sub, string teacher, string grade, string grp, string day, string time,string hall)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `class`(`Class_ID`,`Subject`, `Teacher`, `Grade`, `Group`, `Day`, `Time`, `Hall`) VALUES (@id,@sub,@t,@grade,@grp,@day,@time,@hall)", connect.getconnection);
            //@sub,@t,@grade,@grp,@day,@time
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@sub",MySqlDbType.VarChar).Value = sub;
            command.Parameters.Add("@t",MySqlDbType.VarChar).Value= teacher;
            command.Parameters.Add("grade",MySqlDbType.VarChar).Value= grade;
            command.Parameters.Add("grp", MySqlDbType.VarChar).Value = grp;
            command.Parameters.Add("day", MySqlDbType.VarChar).Value = day;
            command.Parameters.Add("time", MySqlDbType.VarChar).Value = time;
            command.Parameters.Add("Hall",MySqlDbType.VarChar).Value= hall;
            connect.openConnect();
            if(command.ExecuteNonQuery()==1)

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
        public DataTable getclass(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateclass(string id,string sub, string teacher, string grade, string grp, string day, string time, string hall)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `class` SET `Subject`=@sub,`Teacher`=@t,`Grade`=@grade,`Group`=@grp,`Day`=@day,`Time`=@time,`Hall`=@hall WHERE  `Class_ID`=@id", connect.getconnection);
            //@id,@sub,@t,@grade,@grp,@day,@time
            command.Parameters.Add("@id",MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@sub", MySqlDbType.VarChar).Value = sub;
            command.Parameters.Add("@t", MySqlDbType.VarChar).Value = teacher;
            command.Parameters.Add("grade", MySqlDbType.VarChar).Value = grade;
            command.Parameters.Add("grp", MySqlDbType.VarChar).Value = grp;
            command.Parameters.Add("day", MySqlDbType.VarChar).Value = day;
            command.Parameters.Add("time", MySqlDbType.VarChar).Value = time;
            command.Parameters.Add("Hall", MySqlDbType.VarChar).Value = hall;
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
        public bool deletclass(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `class` WHERE `Class_ID`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
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
        public DataTable searchgrade(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `class`WHERE CONCAT( `Grade`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchteacher(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `class`WHERE CONCAT( `Teacher`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchday(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `class`WHERE CONCAT( `Day`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchsubject(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `class`WHERE CONCAT( `Subject`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
