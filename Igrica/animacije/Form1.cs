using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animacije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listTacaka = new List<Point>();
            listaBoja = new List<Color>();
            listaDebiljina = new List<int>();
            toolStripComboBox1.SelectedIndex = 0;
            pomocT=new List<Point>();
            pomocD=new List<int>();
            pomocC=new List<Color>();
            strBoja = Color.Black;
            strX = 0;
            strY = 0;
            deb = 1;
            stara=new Pen(this.BackColor,1);
            Mod = false;
        }

        Thread mojaNit;
        bool Mod;
        Color boja = Color.Black;
        List<Color> listaBoja;
        bool ludost = true;
        Pen stara;
        Color strBoja;
        int strX;
        int strY;
        int deb;

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);        
 	        if(k==1)
            {
                var controlGraphics = CreateGraphics();
                var paintEventArgs = new PaintEventArgs(controlGraphics, ClientRectangle);
                Pen nova = new Pen(boja, Convert.ToInt32(toolStripComboBox1.Text));
                if (!Mod)
                    paintEventArgs.Graphics.DrawLine(stara, prva, new Point(strX, strY));
                ludost = false;
                Form1_Paint(controlGraphics, paintEventArgs);
                paintEventArgs.Graphics.DrawLine(nova, prva, new Point(e.X, e.Y));
                stara.Width = Convert.ToInt32(toolStripComboBox1.Text);
                strX = e.X;
                strY = e.Y;
                if (e.Button == MouseButtons.Right)
                {
                    Mod = true;
                    /*Pen nova = new Pen(boja, Convert.ToInt32(toolStripComboBox1.Text));
                    paintEventArgs.Graphics.DrawLine(nova, prva, new Point(e.X, e.Y));
                    stara.Color = boja;
                    stara.Width = Convert.ToInt32(toolStripComboBox1.Text);*/
                }
                if (e.Button==MouseButtons.None)
                {
                    Mod = false;
                    /*Pen nova = new Pen(boja, Convert.ToInt32(toolStripComboBox1.Text));
                    if(!Mod)
                    paintEventArgs.Graphics.DrawLine(stara, prva, new Point(strX, strY));
                    ludost = false;
                    Form1_Paint(controlGraphics, paintEventArgs);
                    paintEventArgs.Graphics.DrawLine(nova, prva, new Point(e.X, e.Y));
                    stara.Width = Convert.ToInt32(toolStripComboBox1.Text);
                    strX = e.X;
                    strY = e.Y;*/
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // MEGAMAN
            if (ludost == false)
            {
                for (int l = 0; l < (listTacaka.Count / 2); l++)
                {
                    e.Graphics.DrawLine(new Pen(listaBoja[l], listaDebiljina[l]), listTacaka[l * 2], listTacaka[l * 2 + 1]);
                    ludost=true;
                }
            }
        }

        int k = 0;
        Point prva = new Point();
        Point druga = new Point();
        List<Point> listTacaka;
        List<int> listaDebiljina;

        List<Point> pomocT;
        List<int> pomocD;
        List<Color> pomocC;

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                k++;
                if (k == 2)
                {

                    druga.X = e.X;
                    druga.Y = e.Y;
                    listTacaka.Add(druga);
                    mojaFja();
                    listaBoja.Add(boja);
                    listaDebiljina.Add(Convert.ToInt32(toolStripComboBox1.Text));
                    ludost = false;
                    var controlGraphics = CreateGraphics();
                    var paintEventArgs = new PaintEventArgs(controlGraphics, ClientRectangle);
                    Form1_Paint(sender, paintEventArgs);
                    k = 0;
                }
                if (k == 1)
                {
                    prva.X = e.X;
                    prva.Y = e.Y;
                    strX = e.X;
                    strY = e.Y;
                    mojaFja();
                    listTacaka.Add(prva);
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ToolStripButton p in toolStrip1.Items)
                    p.Checked = false;
            }
            catch(InvalidCastException)
            {

            }
        }

        void mojaFja()
        {
            try
            {
                foreach (ToolStripButton p in toolStrip1.Items)
                    if (p.Checked == true)
                    {
                        boja = (Color)p.BackColor;
                        p.Checked = false;
                        break;
                    }
            }
            catch (InvalidCastException)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           /* if(k==1)
            {
            var controlGraphics = CreateGraphics();
            var paintEventArgs = new PaintEventArgs(controlGraphics, ClientRectangle);
            pomocT.Add(new Point())
                MouseButtons.ge
            lista
            paintEventArgs.Graphics.DrawLine();
            }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
