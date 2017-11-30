using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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

        private void Fart_Click(object sender, EventArgs e)
        {
            MatchBox.Text = "";
            for (int i = 0; i < 1000; i++){
                MatchBox.AppendText(" FaRt");
            }
            MessageBox.Show(MatchBox.Text);
            this.Close();
        }

        private void RegexBox_TextChanged(object sender, EventArgs e)
        {
            MatchBox.Text = "";
            string text = TextBox.Text;
            string pattern = @"" + RegexBox.Text;
            foreach (var word in text.Split(' '))
            {
                try
                {
                    if (Regex.IsMatch(word, pattern))
                    {
                        MatchBox.AppendText(word);
                        MatchBox.AppendText(Environment.NewLine);
                    }
                }
                catch (Exception m)
                {
                    Console.WriteLine(m.Message);
                }
            }
        }
    }
}
