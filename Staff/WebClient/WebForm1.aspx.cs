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

        protected void Button1_Click(object sender, EventArgs e)
        {
            var xValue = int.Parse(TextBox1.Text);
            var yValue = int.Parse(TextBox2.Text);

            var client = new ServiceReference1.HostService1Client("BasicHttpBinding_IHostService1");
            Label1.Text = client.Summator(xValue, yValue).ToString();
            client.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var _id = int.Parse(TextBox3.Text);
            var client = new ServiceReference1.HostService1Client("BasicHttpBinding_IHostService1");
            TextBox4.Text = client.GetRowById(_id);             
            client.Close();
        }
    }
}