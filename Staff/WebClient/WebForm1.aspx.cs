using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using HostService;

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public HostService.GetShortInfo[] getShort;


        protected void Page_Load(object sender, EventArgs e)
        {
            ErrorLbl.Text = "";
            ErrorLbl.ForeColor = System.Drawing.Color.Red;
        }       

        protected void FindBtn_Click(object sender, EventArgs e)
        {
            //var _id = int.Parse(TextBox3.Text);
            //var client = new ServiceReference1.HostService1Client("BasicHttpBinding_IHostService1");
            //try
            //{
            //    TextBox4.Text = client.GetRowById(_id).First_name + " " + client.GetRowById(_id).Last_name + " " +
            //        client.GetRowById(_id).Patronic_name +" "+ client.GetRowById(_id).Birthday;
            //}
            //catch (Exception err)
            //{
            //    TextBox4.Text = err.Message + "                   "+err.StackTrace;
            //}
            //client.Close();

             

            var client = new ServiceReference1.HostService1Client("BasicHttpBinding_IHostService1");
            try
            {
                getShort = client.FindByLastName(LastNameBox.Text);
                if(getShort.Length==0)
                    ErrorLbl.Text = "В базе нету такого человека!";
            }
            catch (Exception err)
            {
                ErrorLbl.Text = err.Message;
            }


        }
    }
}