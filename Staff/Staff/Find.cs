using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staff
{
    public partial class Find : Form
    {
        ServiceReference1.GetPosts[] posts;
        ServiceReference1.GetDepartament[] departaments;
        ServiceReference1.GetShortInfo[] buff;

        int counter = 0;


        public Find()
        {
            InitializeComponent();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            counter = 0;
            NextBtn.Enabled = true;
            PrevBtn.Enabled = true;

            var client = new ServiceReference1.HostService1Client("BasicHttpBinding_IHostService1");
            try
            {
                buff = client.FindByLastName(FindBox.Text);
                posts = client.GetPostsList();
                departaments = client.GetDepartamentsList();
                client.Close();

                CounterLable.Text = "Знайдено: " + buff.Count();

                if (buff != null)
                {
                    FillFild(counter);
                    if (buff.Count() == 1)
                    {
                        NextBtn.Enabled = false;
                        PrevBtn.Enabled = false;
                    }
                    else
                    {
                        NextBtn.Enabled = true;
                        PrevBtn.Enabled = false;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " \nНету записей в базе.");
            }

        }

        private void FillFild(int buffNum)
        {
            FirstNameBox.Text = buff[counter].First_name;
            LastNameBox.Text = buff[counter].Last_name;
            PatronicBox.Text = buff[counter].Patronic_name;
            BirthdayBox.Text = buff[counter].Birthday.ToShortDateString();
            AgeBox.Text = buff[counter].Age.ToString();
            foreach (var item in posts)
            {
                if (buff[0].Post == item.Id)
                    PostBox.Text = item.Name;
            }
            foreach (var item in departaments)
            {
                if (buff[0].Departament == item.Id)
                    DepartmentBox.Text = item.Name;
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (buff != null)
            {
                FillFild(counter += 1);
                if (counter < buff.Count() - 1)
                {
                    NextBtn.Enabled = true;
                    PrevBtn.Enabled = true;
                }
                else
                {
                    NextBtn.Enabled = false;
                    PrevBtn.Enabled = true;
                }
            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (buff != null)
            {
                FillFild(counter -= 1);
                if (counter > 0)
                {
                    PrevBtn.Enabled = true;
                    NextBtn.Enabled = true;
                }
                else
                {
                    PrevBtn.Enabled = false;
                    NextBtn.Enabled = true;
                }
            }
        }
    }
}
