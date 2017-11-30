﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDojo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatchBox.Text = "";
            string text = TextBox.Text;
            string pattern = @"" + RegexBox.Text;
            foreach (var word in text.Split(' '))
            {
                if (Regex.IsMatch(word, pattern))
                {
                    MatchBox.AppendText(word);
                    MatchBox.AppendText(Environment.NewLine);
                }
            }

            //MatchBox.Text 
        }

        private void RegexBox_TextChanged(object sender, EventArgs e)
        {
            MatchBox.Text = "";
            string text = TextBox.Text;
            string pattern = @"" + RegexBox.Text;
            foreach (var word in text.Split(' '))
            {
                if (Regex.IsMatch(word, pattern))
                {
                    MatchBox.AppendText(word);
                    MatchBox.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
