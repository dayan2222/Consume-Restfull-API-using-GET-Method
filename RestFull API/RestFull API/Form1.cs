using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestFull_API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            // if you want to show data in string
            // HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://example_domani.com/?user=USERNAME&pwd=PASSWORD&sender=USERNAME&reciever=YOURNUMBER&msg-data=MESSAGAE&response=string");
            
            // if you want to show data in json 
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://example_domani.com/?user=USERNAME&pwd=PASSWORD&sender=USERNAME&reciever=YOURNUMBER&msg-data=MESSAGAE&response=json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            // Display the Content
            textBox1.Text = textBox1.Text + response.StatusDescription;
            textBox1.Text = textBox1.Text + responseFromServer;

            reader.Close();
            dataStream.Close();
            response.Close();

        }


    }
}
