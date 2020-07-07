using System;
using System.Windows.Forms;
using System.Xml;

namespace WinRssReader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetXmlData();
        }
        XmlDocument document = new XmlDocument();
        private void GetXmlData()
        {
            document.Load(Application.StartupPath + "\\Sites.xml");
            lstXML.Items.Clear();
            XmlNodeList xmlNodelist = document.GetElementsByTagName("site");

            foreach (XmlNode xmlNode in xmlNodelist)
            {
                ListViewItem listviewItem = new ListViewItem(xmlNode.Attributes["name"].InnerText);
                foreach (XmlNode xmlnode in xmlNode.ChildNodes)
                {
                    listviewItem.SubItems.Add(xmlnode.InnerText);
                }
                listviewItem.Tag = xmlNode;
                lstXML.Items.Add(listviewItem);
            }
            lstXML.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        XmlNode selectedNode;
        private void lstXML_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstXML.SelectedItems.Count == 0) return;
            ListViewItem listviewItem = lstXML.SelectedItems[0];
            selectedNode = listviewItem.Tag as XmlNode;
            txtSite.Text = listviewItem.SubItems[0].Text;
            txtDate.Text = listviewItem.SubItems[2].Text;
            txtURL.Text = listviewItem.SubItems[1].Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            XmlElement element = document.CreateElement("site");
            element.SetAttribute("name", txtSite.Text);

            XmlElement URLElemenet = document.CreateElement("URL");
            URLElemenet.InnerText = txtURL.Text;

            XmlElement DateElement = document.CreateElement("Date");
            DateElement.InnerText = txtDate.Text;

            element.AppendChild(URLElemenet);
            element.AppendChild(DateElement);

            document.DocumentElement.AppendChild(element);
            document.Save(Application.StartupPath + "\\Sites.xml");
            ControlClear();
            GetXmlData();
        }

        private void ControlClear()
        {
            selectedNode = null;
            txtDate.Text = "";
            txtSite.Text = "";
            txtURL.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedNode == null) return;
            selectedNode.Attributes["name"].InnerText = txtSite.Text;
            selectedNode.ChildNodes[0].InnerText = txtURL.Text;
            selectedNode.ChildNodes[1].InnerText = txtDate.Text;
            document.Save(Application.StartupPath + "\\Sites.xml");
            ControlClear();
            GetXmlData();
        }
    }
}
