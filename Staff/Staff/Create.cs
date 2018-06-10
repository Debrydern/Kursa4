using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Staff
{
    public partial class Create : Form
    {
        ServiceReference1.GetPosts[] posts;
        ServiceReference1.GetDepartament[] departaments;

        public Create()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (LastNameBox.TextLength > 0 && FirstNameBox.TextLength > 0 && PatronicBox.TextLength > 0 && AgeBox.TextLength > 0 && BirthdayBox.TextLength > 9)
            {
                var temp = new ServiceReference1.GetShortInfo
                {
                    Last_name = LastNameBox.Text,
                    First_name = FirstNameBox.Text,
                    Patronic_name = PatronicBox.Text,
                    Age = Convert.ToInt32(AgeBox.Text),
                    Birthday = Convert.ToDateTime(BirthdayBox.Text)
                };

                foreach (var item in posts)
                {
                    if (item.Name == PostComboBox.Text)
                        temp.Post = item.Id;
                }
                foreach (var item in departaments)
                {
                    if (item.Name == DepartamentComboBox.Text)
                        temp.Departament = item.Id;
                }
                var client = new ServiceReference1.HostService1Client("BasicHttpBinding_IHostService1");
                client.AddNewPerson(temp);

                LastNameBox.Text = "";
                FirstNameBox.Text = "";
                PatronicBox.Text = "";
                AgeBox.Text = "";
                BirthdayBox.Text = "";
            }
            else
                MessageBox.Show("Не все поля заполнены верно!","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Create_Load(object sender, EventArgs e)
        {
            var client = new ServiceReference1.HostService1Client("BasicHttpBinding_IHostService1");
            posts = client.GetPostsList();
            departaments = client.GetDepartamentsList();
            client.Close();

            foreach (var item in posts)
            {
                PostComboBox.Items.Add(item.Name);
            }
            foreach (var item in departaments)
            {
                DepartamentComboBox.Items.Add(item.Name);
            }
        }
    }
}
