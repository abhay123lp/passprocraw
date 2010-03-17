using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using Parser;
using System.Collections;


namespace HTTPRequest
{
    public partial class Form1 : Form
    {
        //Creating an object for unvisited URLs
        Queue frontier = new Queue();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("HTTP Requesting the following URL: " + textBox1.Text);
            try
            {
                
                //creating web http request
                HttpWebRequest request = (HttpWebRequest)
                    WebRequest.Create("http://" + textBox1.Text);
                //Executing request and taking response as Stream 

                HttpWebResponse response = (HttpWebResponse)
                    request.GetResponse();
                Stream resStream = response.GetResponseStream();
                //Creating a StreamReader Object
                StreamReader a = new StreamReader(resStream);
                //Reading all stream and convert it to string
                string txt = a.ReadToEnd();
                richTextBox1.Text = txt;

                //URL Location 
                String URLLocation = textBox1.Text;
                //Creating inst object in terms of Parser Class
                //use MakeLinks method in order to parse the links
                Parser.Parser inst2 = new Parser.Parser();
                inst2.MakeLinks(txt, URLLocation);
                foreach (string str in inst2.PLinks)
                {
                    richTextBox3.Text += str + "\r\n";
                    frontier.Enqueue(str);
                }
                //Parsing the Content in the related URL
                Parser.Parser inst = new Parser.Parser();
                richTextBox2.Text = inst.GetText(txt);
            }
            catch
            {
                MessageBox.Show("Unexpectable error occurs. There may be a problem with URL you entered or check your Internet Connnections");
                
            }
            
            

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAuth yeni = new AboutAuth();//yardım formunu acar
            yeni.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();

        }

        public void button6_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = "Sayı :" + frontier.Count;
            string a = (string)frontier.Peek();
            
            
        }

        
    }
}
