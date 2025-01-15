using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace kwa
{
    internal class studentClass
    {
        dbconnect connect = new dbconnect();
        public bool insertstudent(string name, string address, string age, string grade, string school, string number,byte[] img,string sub1, string sub2,string sub3, string sub4 ,string sub5, string sub6, string sub7, string sub8, string sub9,string sub10, string sub101)
        {
            MySqlCommand command= new MySqlCommand("INSERT INTO `student`(`name`, `address`, `age`, `grade`, `school`, `number`, `pic`, `sub1`, `sub2`, `sub3`, `sub4`, `sub5`, `sub6`, `sub7`, `sub8`, `sub9`, `sub10`)VALUES(@n,@a,@ag,@gr,@sch,@nu,@pic,@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8,@s9,@s10)",connect.getconnection);
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value=name;
            command.Parameters.Add("@a", MySqlDbType.Text).Value=address;
            command.Parameters.Add("@ag", MySqlDbType.Int16).Value=age;
            command.Parameters.Add("@gr", MySqlDbType.Int16).Value = grade;
            command.Parameters.Add("@sch", MySqlDbType.VarChar).Value=school;
            command.Parameters.Add("@nu", MySqlDbType.Int64).Value=number;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value=img;
            command.Parameters.Add("@s1", MySqlDbType.VarChar).Value = sub1;
            command.Parameters.Add("@s2", MySqlDbType.VarChar).Value=sub2;
            command.Parameters.Add("@s3", MySqlDbType.VarChar).Value=sub3 ;
            command.Parameters.Add("@s4", MySqlDbType.VarChar).Value=sub4 ;
            command.Parameters.Add("@s5", MySqlDbType.VarChar).Value=sub5 ;
            command.Parameters.Add("@s6", MySqlDbType.VarChar).Value=sub6 ;
            command.Parameters.Add("@s7", MySqlDbType.VarChar).Value=sub7 ;
            command.Parameters.Add("@s8", MySqlDbType.VarChar).Value=sub8 ;
            command.Parameters.Add("@s9", MySqlDbType.VarChar).Value=sub9 ;
            command.Parameters.Add("@s10", MySqlDbType.VarChar).Value=sub10 ;

            connect.openConnect();
            if (command.ExecuteNonQuery()==1)
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
        public DataTable getstudentlist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public string exeCount(string query)
        {
            MySqlCommand command=new MySqlCommand(query, connect.getconnection);
            connect.openConnect();
            string count=command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }
        public DataTable searchStudent(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`WHERE CONCAT(`studentid`, `name`, `grade`, `school`, `number`) LIKE '%"+searchdata+"%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updatestudent(int id,string name, string address, string age, string grade, string school, string number, byte[] img, string sub1, string sub2, string sub3, string sub4, string sub5, string sub6, string sub7, string sub8, string sub9, string sub10, string sub101)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `pic`=@pic ,`name`=@n ,`address`=@a ,`age`=@ag ,`grade`=@gr ,`school`=@sch ,`number`=@nu ,`sub1`=@s1 ,`sub2`=@s2 ,`sub3`=@s3 ,`sub4`=@s4 ,`sub5`=@s5 ,`sub6`=@s6 ,`sub7`=@s7 ,`sub8`=@s8 ,`sub9`=@s9 ,`sub10`=@s10 WHERE `studentid`=@id ", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int64).Value = id;
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@a", MySqlDbType.Text).Value = address;
            command.Parameters.Add("@ag", MySqlDbType.Int16).Value = age;
            command.Parameters.Add("@gr", MySqlDbType.Int16).Value = grade;
            command.Parameters.Add("@sch", MySqlDbType.VarChar).Value = school;
            command.Parameters.Add("@nu", MySqlDbType.Int64).Value = number;
            command.Parameters.Add("@pic", MySqlDbType.LongBlob).Value = img;
            command.Parameters.Add("@s1", MySqlDbType.VarChar).Value = sub1;
            command.Parameters.Add("@s2", MySqlDbType.VarChar).Value = sub2;
            command.Parameters.Add("@s3", MySqlDbType.VarChar).Value = sub3;
            command.Parameters.Add("@s4", MySqlDbType.VarChar).Value = sub4;
            command.Parameters.Add("@s5", MySqlDbType.VarChar).Value = sub5;
            command.Parameters.Add("@s6", MySqlDbType.VarChar).Value = sub6;
            command.Parameters.Add("@s7", MySqlDbType.VarChar).Value = sub7;
            command.Parameters.Add("@s8", MySqlDbType.VarChar).Value = sub8;
            command.Parameters.Add("@s9", MySqlDbType.VarChar).Value = sub9;
            command.Parameters.Add("@s10", MySqlDbType.VarChar).Value = sub10;

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
        public DataTable searchStudent1(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`WHERE CONCAT(`grade`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchStudent2(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`WHERE CONCAT(`school`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchStudent3(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student`WHERE CONCAT(`sub1`, `sub2`, `sub3`, `sub4`, `sub5`, `sub6`, `sub7`, `sub8`, `sub9`, `sub10`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deletestudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `studentid`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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
    }


}
