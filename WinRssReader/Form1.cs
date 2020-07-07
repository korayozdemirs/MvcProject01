using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinRssReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(textBox1.Text);

            XmlNode root = xdoc.DocumentElement;
            string path = "channel/item";
            XmlNodeList list = root.SelectNodes(path);

            foreach (XmlNode item in list)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.SelectSingleNode("title").InnerText;
                li.SubItems.Add(item.SelectSingleNode("link").InnerText);
                li.Tag = item;
                listView1.Items.Add(li);
            }

        }
    }
}
