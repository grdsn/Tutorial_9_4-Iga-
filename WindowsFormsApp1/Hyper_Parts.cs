﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Hyper_Parts : Form
    {
        private string[] argumentValues;
        public static string text_return;

        public Hyper_Parts()
        {
            InitializeComponent();
        }

        private void Hyper_Parts_Load(object sender, EventArgs e)
        {

        }

        public string ShowMiniForm()
        {
            Hyper_Parts f = new Hyper_Parts();
            string receiveText;
            f.ShowDialog();
            if (f.TextAdd.Text != "")
            {
                receiveText = "<a href=\"" + f.TextAdd.Text + "\">" + f.Title_Add.Text + "</a>";
            }
            else
            {
                receiveText = "-1";
            }
            f.Dispose();
            return receiveText;
        }

        private void AddConfirm_Click_1(object sender, EventArgs e)
        {
            Close();　//画面を閉じ反映させる
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            TextAdd.Text = "";
            Close();
        }
    }
}
