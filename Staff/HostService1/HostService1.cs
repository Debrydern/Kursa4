using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HostService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HostService1" in both code and config file together.
    public class HostService1 : IHostService1
    {
        public void AddNewPerson(GetShortInfo info)
        {            
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|DBase\DBase.mdf';Integrated Security=True");
                
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = $"INSERT INTO  Staff(LastName, FirstName, PatronicName, Age, BirthDay, Post_Id, Departament_Id) " +
                $"VALUES(N'{info.Last_name}',N'{info.First_name}',N'{info.Patronic_name}',{info.Age}, Convert(datetime, '{info.Birthday.ToShortDateString()}', 104), {info.Post}, {info.Departament})";
                sqlCom.Connection = sqlConn;

                sqlConn.Open();
                sqlCom.ExecuteNonQuery();
                sqlConn.Close();
        }

        public GetShortInfo[] FindByLastName(string name)
        {
            //коннектимся
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|DBase\DBase.mdf';Integrated Security=True");
            sqlConn.Open();
            //выполняем запрос
            SqlCommand sqlCom = new SqlCommand($"SELECT * FROM Staff WHERE LastName Like N'%{name}%' ", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            //результат запроса суем в таблицу
            DataTable dt = new DataTable();
            dt.Load(dr);
            dt.AcceptChanges();
            sqlConn.Close();

            int a = dt.Rows.Count;
            if (a != 0)
            {
                GetShortInfo[] shortInfo = new GetShortInfo[a];
                for (int i = 0; i < a; i++)
                {
                    shortInfo[i].Last_name = dt.Rows[i].ItemArray[1].ToString();
                    shortInfo[i].First_name = dt.Rows[i].ItemArray[2].ToString();
                    shortInfo[i].Patronic_name = dt.Rows[i].ItemArray[3].ToString();
                    shortInfo[i].Age = (int)dt.Rows[i].ItemArray[4];
                    shortInfo[i].Birthday = (DateTime)dt.Rows[i].ItemArray[5];
                    shortInfo[i].Post = Convert.ToInt32(dt.Rows[i].ItemArray[6]);
                    shortInfo[i].Departament = Convert.ToInt32(dt.Rows[i].ItemArray[7]);
                }


                return shortInfo;
            }
            else return null;
        }

        public GetPosts[] GetPostsList()
        {

            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|DBase\DBase.mdf';Integrated Security=True");
            sqlConn.Open();

            SqlCommand sqlCom = new SqlCommand($"SELECT * FROM Post ", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            GetPosts[] temp = new GetPosts[dt.Rows.Count];
            for(int i=0;i<dt.Rows.Count;i++)
            {
                temp[i].Id = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                temp[i].Name = dt.Rows[i].ItemArray[1].ToString();
            }
            return temp;
        }

        public GetDepartament[] GetDepartamentsList()
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|DBase\DBase.mdf';Integrated Security=True");
            sqlConn.Open();

            SqlCommand sqlCom = new SqlCommand($"SELECT * FROM Departament ", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            GetDepartament[] temp = new GetDepartament[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                temp[i].Id = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                temp[i].Name = dt.Rows[i].ItemArray[1].ToString();
            }
            return temp;
        }

        public GetShortInfo GetRowById(int id)
        {
            GetShortInfo shortInfo = new GetShortInfo();

            //коннектимся
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|DBase\DBase.mdf';Integrated Security=True");
            sqlConn.Open();
            //выполняем запрос
            SqlCommand sqlCom = new SqlCommand($"SELECT * FROM Staff WHERE Staff_Id = {id}", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            //результат запроса суем в таблицу
            DataTable dt = new DataTable();
            dt.Load(dr);
            dt.AcceptChanges();

            shortInfo.Last_name = dt.Rows[0].ItemArray[1].ToString();
            shortInfo.First_name = dt.Rows[0].ItemArray[2].ToString();
            shortInfo.Patronic_name = dt.Rows[0].ItemArray[3].ToString();
            shortInfo.Age = (int)dt.Rows[0].ItemArray[4];
            shortInfo.Birthday = (DateTime)dt.Rows[0].ItemArray[5];
            shortInfo.Post = Convert.ToInt32 (dt.Rows[0].ItemArray[6]);
            shortInfo.Departament = Convert.ToInt32(dt.Rows[0].ItemArray[7]);
            sqlConn.Close();

            return shortInfo;
        }

        public void AddNewPost(string name)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|DBase\DBase.mdf';Integrated Security=True;");
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandText = $"INSERT INTO  Post(Name) values(N'{name}')";
            sqlCom.Connection = sqlConn;

            sqlConn.Open();
            sqlCom.ExecuteNonQuery();
            sqlConn.Close();
        }

        public void AddNewDepartament(string name)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|DBase\DBase.mdf';Integrated Security=True");
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandText = $"INSERT INTO  Departament(Name) values(N'{name}')";
            sqlCom.Connection = sqlConn;

            sqlConn.Open();
            sqlCom.ExecuteNonQuery();
            sqlConn.Close();
        }
    }
}
