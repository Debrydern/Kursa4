using System;
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

            int a = dt.Rows.Count;
            GetShortInfo[] shortInfo = new GetShortInfo[a];
            for (int i = 0; i < a; i++)
            {
                shortInfo[i].Last_name =    dt.Rows[i].ItemArray[1].ToString();
                shortInfo[i].First_name =   dt.Rows[i].ItemArray[2].ToString();
                shortInfo[i].Patronic_name = dt.Rows[i].ItemArray[3].ToString();
                shortInfo[i].Age =           (int)dt.Rows[i].ItemArray[4];
                shortInfo[i].Birthday =     (DateTime)dt.Rows[i].ItemArray[5];
                shortInfo[i].Post =         dt.Rows[i].ItemArray[6].ToString();
                shortInfo[i].Department =   dt.Rows[i].ItemArray[7].ToString();
            }

            return shortInfo;
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

            shortInfo.Last_name =       dt.Rows[0].ItemArray[1].ToString();
            shortInfo.First_name =      dt.Rows[0].ItemArray[2].ToString();
            shortInfo.Patronic_name =   dt.Rows[0].ItemArray[3].ToString();           
            shortInfo.Age =             (int)dt.Rows[0].ItemArray[4];
            shortInfo.Birthday =        (DateTime)dt.Rows[0].ItemArray[5];
            shortInfo.Post =            dt.Rows[0].ItemArray[6].ToString();
            shortInfo.Department =      dt.Rows[0].ItemArray[7].ToString();

            return shortInfo;
        }       
    }
}
