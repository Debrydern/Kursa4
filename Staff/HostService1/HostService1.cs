﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public int Summator(int a, int b)
        {
            return a + b;
        }

        public GetShortInfo GetRowById(int id)
        {
            GetShortInfo shortInfo = new GetShortInfo();
            
                //коннектимся
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Dropbox\personal\Ucheba\Kursa4\Staff\Server\DBase\Database.mdf;Integrated Security=True");
                sqlConn.Open();
                //выполняем запрос
                SqlCommand sqlCom = new SqlCommand($"SELECT * FROM Staff_Short WHERE Id = {id}", sqlConn);
                SqlDataReader dr = sqlCom.ExecuteReader();
                //результат запроса суем в таблицу
                DataTable dt = new DataTable();
                dt.Load(dr);
               
               
                shortInfo.First_name = dt.Rows[0].ItemArray[1].ToString();
                shortInfo.Last_name = dt.Rows[0].ItemArray[2].ToString();
                shortInfo.Patronic_name = dt.Rows[0].ItemArray[3].ToString();
                shortInfo.Birthday = (DateTime)dt.Rows[0].ItemArray[4];
                shortInfo.Age = (int)dt.Rows[0].ItemArray[5];
                shortInfo.Department = dt.Rows[0].ItemArray[6].ToString();
                shortInfo.Post = dt.Rows[0].ItemArray[7].ToString();

                return shortInfo;           
        }
    }
}
