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
    public partial class Table_Parts : Form
    {

        int tr_num; //列の指定
        int td_num = 0; //行の指定
        
        public Table_Parts()
        {
            InitializeComponent();
        }

        public string ShowMiniForm()
        {
            Table_Parts f = new Table_Parts();
            f.ShowDialog();
            string work = ""; //文字格納用
            int cnt = 1; //テキストボックス用カウント
            int row = int.Parse(f.row_Box.Text);
            int col = int.Parse(f.col_Box.Text);
            try
            {
                string receiveText = "<table border=\"1\">" + "\r\n";
                if (row <= 4 && col <= 9) //列が４行以下行が９行以下
                {
                    for (int i = 0; i < col; i++)
                    {
                        receiveText += "  <tr>" + "\r\n";
                        for (int j = 0; j < row; j++)
                        {
                            work = ((TextBox)f.Controls[string.Format("tb{0}", cnt)]).Text;
                            receiveText += "    <td>" + work + "</td>" + "\r\n";
                            cnt++;
                        }
                        
                        work = "";
                        receiveText += "  </tr>" + "\r\n";
                    }
                    receiveText += "</table>";
                }
                f.Dispose();
                return receiveText;
            }
            catch(Exception e)
            {
                return e.ToString();
            }
            
        }

        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Table_Parts_Load(object sender, EventArgs e)
        {

        }
    
    }
}
