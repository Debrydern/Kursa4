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
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }

        private void AddPostsBtn_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference1.HostService1Client("BasicHttpBinding_IHostService1");
            client.AddNewPost(AddPostBox.Text);
            client.Close();
            AddPostBox.Text = "";
            AddPostBox.Focus();
        }
    }
}
