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
namespace WordWebCS
{
    public partial class MainForm : Form
    {
        Graph graph = new Graph();
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnProcessText_Click(object sender, EventArgs e)
        {
            graph.Process(rtbMain.Text);
            MessageBox.Show("Processed.");
        }
        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            new DrawGraph(graph).Show();
        }

        private void rtbMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProcessText_Click(null, null);
            }
        }
        private void btnReprocess_Click(object sender, EventArgs e)
        {
            graph.ReProcess();
            MessageBox.Show("Processed.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cons = graph[0].ConnotationWords;
            string t = "";
            foreach(string con in cons)
            {
                t += con + ",";
            }
            MessageBox.Show("Word: " + graph[0].Word + "; Connotations: " + t);
        }
        private void btnWikiText_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://en.wikipedia.org/wiki/Japan");
            rtbMain.Text = doc.InnerText;
            //Fncs.Url = "https://en.wikipedia.org/wiki/Japan";
            //rtbMain.Text = Fncs.GetText();
        }
    }
}