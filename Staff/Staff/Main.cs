﻿using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            var myForm = new Create();
            myForm.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var myForm = new Find();
            myForm.Show();
        }

        private void PostsBtn_Click(object sender, EventArgs e)
        {
            var myForm = new Post();
            myForm.Show();
        }

        private void DepartamentBtn_Click(object sender, EventArgs e)
        {
            var myForm = new Departament();
            myForm.Show();
        }
    }
}
