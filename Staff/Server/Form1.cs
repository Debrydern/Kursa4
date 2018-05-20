using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void staff_FullBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staff_FullBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Staff_Short' table. You can move, or remove it, as needed.
            this.staff_ShortTableAdapter.Fill(this.databaseDataSet.Staff_Short);
            // TODO: This line of code loads data into the 'databaseDataSet.Staff_Full' table. You can move, or remove it, as needed.
            this.staff_FullTableAdapter.Fill(this.databaseDataSet.Staff_Full);
            
        }
    }
}
