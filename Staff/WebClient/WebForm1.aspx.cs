using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }       

        protected void Button2_Click(object sender, EventArgs e)
        {
            var _id = int.Parse(TextBox3.Text);
            var client = new ServiceReference1.HostService1Client("BasicHttpBinding_IHostService1");
            try
            {
                TextBox4.Text = client.GetRowById(_id).First_name + " " + client.GetRowById(_id).Last_name + " " +
                    client.GetRowById(_id).Patronic_name +" "+ client.GetRowById(_id).Birthday.ToShortDateString();
            }
            catch (Exception err)
            {
                TextBox4.Text = err.Message;
            }
            client.Close();
        }
    }
}