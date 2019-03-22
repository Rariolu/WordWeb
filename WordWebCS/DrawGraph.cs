using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordWebCS
{
    public partial class DrawGraph : Form
    {
        Graph thisGraph;
        public DrawGraph(Graph graph)
        {
            InitializeComponent();
            thisGraph = graph;
        }
        private void DrawGraph_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(DefaultBackColor);
            thisGraph.Paint(e,Width,Height);
        }
        private void DrawGraph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
