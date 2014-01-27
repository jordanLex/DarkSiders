using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        int i = 2;
        public Form1()
        {
            InitializeComponent();
            Form2 f = new Form2(this);
            textBox1.Text = f.q;
            Form3 f1 = new Form3(this);
            textBox1.Text = f1.q;
            //WebBrowser browser;
          
        }
        public void goback(string a)
        {
            webBrowser1.Navigate(a);
            textBox1.Text = a;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "return");
            if (e.KeyCode==Keys.Enter)
            {
                System.IO.StreamWriter sw;
                System.IO.FileInfo fi = new System.IO.FileInfo("name.txt");
                sw = fi.AppendText();
                sw.WriteLine(textBox1.Text);
                sw.Close();
                tabs.SelectedTab.Text = textBox1.Text;
                ((WebBrowser)tabs.SelectedTab.Controls[0]).Navigate(@"http://www." + textBox1.Text);
                
            }
                
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader("nastr.txt");
            if (e.KeyCode==Keys.Enter)
            {
                string s = streamReader.ReadLine();
               
                    if (s== "yandex.ru")
                    {
                        webBrowser1.Navigate(@"https://yandex.ua/yandsearch?lr=143&text=" + textBox2.Text);
                    }
                
                
                    if (s == "google.ru")
                    {
                        webBrowser1.Navigate(@"https://www.google.com.ua/search?q=" + textBox2.Text);
                    }

                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader("nastr.txt");


            for (int i = 1; i < 3;i++ )
                webBrowser1.Navigate(streamReader.ReadLine());
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void історіяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
        }

        private void улюбленеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(this);
            f.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw;
            System.IO.FileInfo fi = new System.IO.FileInfo("namef.txt");
            sw = fi.AppendText();
            sw.WriteLine(textBox1.Text);
            sw.Close();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {

           
            
                WebBrowser browser = new WebBrowser();
                tabs.TabPages.Add("Новая вкладка ");
                tabs.SelectTab(i - 1);
                browser.Name = "browser";

                tabs.SelectedTab.Controls.Add(browser);
                browser.Dock = DockStyle.Fill;

                i++;
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i > 2)
            {
                tabs.SelectedTab.Dispose();
            }
        } 
    }
}
