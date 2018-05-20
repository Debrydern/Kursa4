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
        public int Summator(int a, int b)
        {
            return a + b;
        }

        public string GetRowById(int id)
        {
            try
            {
                //коннектимся
                SqlConnection sqlConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Dropbox\personal\Ucheba\Kursa4\Staff\Server\DBase\Database.mdf;Integrated Security=True");
                sqlConn.Open();
                //выполняем запрос
                SqlCommand sqlCom = new SqlCommand($"SELECT * FROM Staff_Short WHERE Id = {id}", sqlConn);
                SqlDataReader dr = sqlCom.ExecuteReader();
                //результат запроса суем в таблицу
                DataTable dt = new DataTable();
                dt.Load(dr);

                return $"{dt.Rows[0].ItemArray[0].ToString()} {dt.Rows[0].ItemArray[1].ToString()} " +
                    $"{dt.Rows[0].ItemArray[2].ToString()} {dt.Rows[0].ItemArray[3].ToString()} {dt.Rows[0].ItemArray[4].ToString()}";
            }
            catch (Exception err)
            {

               
                return err.Message;
            }

        }
    }
}
