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
    public partial class Form3 : Form
    {
       public string q="";
        Form1 parent;
        public Form3(Form1 mainform)
        {
            InitializeComponent();
            parent = mainform;
        }

     
     

     

        private void Form3_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader streamReader = new System.IO.StreamReader("namef.txt");

            while (!streamReader.EndOfStream)
            {
                listBox1.Items.Add(streamReader.ReadLine());
            }
        }

        private void listBox1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            q = listBox1.Items[listBox1.SelectedIndex].ToString();
            parent.goback(q);
            this.Close();
           
        }
    }
}
