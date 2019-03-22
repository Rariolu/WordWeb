using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebHacks;

namespace WordWebCS
{
    public class Graph
    {
        Dictionary<string, Node> strNodes = new Dictionary<string, Node>();
        Dictionary<int, Node> nodes = new Dictionary<int, Node>();
        List<string> processedText = new List<string>();
        public void Process(string text)
        {
            if (!processedText.Contains(text))
            {
                processedText.Add(text);
            }
            text = text.ReplaceRedundants(" ", "\n", "\t");
            string wtext = text.ReplaceRedundants("", ".", ",", "!", ",", "?",":",";");
            string[] words = wtext.Split(' ');
            foreach(string word in words)
            {
                if (!strNodes.ContainsKey(word))
                {
                    Node n = new Node(word);
                    strNodes.Add(word, n);
                    nodes.Add(n.ID, n);
                }
            }
            string stext = text.ReplaceRedundants(".", "!", "?");
            string[] sentences = stext.Split('.');
            foreach (string sentence in sentences)
            {
                string wsentence = sentence.ReplaceRedundants("", ".", ",", "!", ",", "?", ":", ";");
                string[] swords = wsentence.Split(' ');
                for(int i = 0; i < swords.Length-1; i++)
                {
                    string iword = swords[i];
                    for (int j = i+1; j < swords.Length; j++)
                    {
                        string jword = swords[j];
                        if (!string.Equals(iword,jword))
                        {
                            if (strNodes.ContainsKey(iword) && strNodes.ContainsKey(jword))
                            {
                                Node inode = strNodes[iword];
                                Node jnode = strNodes[jword];
                                inode.Converge(jnode);
                            }
                        }
                    }
                }
            }
        }
        public void ReProcess(int iters=1)
        {
            iters = Math.Abs(iters);
            for (int i = 0; i < iters; i++)
            {
                foreach(string t in processedText)
                {
                    Process(t);
                }
            }
        }
        public void Paint(PaintEventArgs e, int width, int height)
        {
            Pen pen = new Pen(Color.Black);
            Pen tpen = new Pen(Color.Red);
            Font font = new Font("Calibri", 10);
            List<KeyValuePair<string, string>> drawnLinks = new List<KeyValuePair<string, string>>();
            foreach(Node n in strNodes.Values)
            {
                PointF p = new PointF((float)n.Position.X * width, (float)n.Position.Y * height);
                e.Graphics.DrawString(n.Word, font, tpen.Brush, p);
                foreach(Link l in n.Links)
                {
                    KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(l.A.Word, l.B.Word);
                    if (!drawnLinks.Contains(kvp))
                    {
                        Point aPoint = new Point((int)(l.A.Position.X * width), (int)(l.A.Position.Y * height));
                        Point bPoint = new Point((int)(l.B.Position.X * width), (int)(l.B.Position.Y * height));
                        e.Graphics.DrawLine(pen, aPoint, bPoint);
                        drawnLinks.Add(kvp);
                    }
                }
            }
        }
        public Node this[int index]
        {
            get
            {
                return nodes.ContainsKey(index) ? nodes[index] : new Node("NodeNotFound");
            }
        }
    }
}