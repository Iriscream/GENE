using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRDrawing;

namespace MyPainter2
{
    public partial class Form1 : Form
    {
        bool isMouseDown = false;
        Painting p;
        public Form1()
        {
            InitializeComponent();
           p = new Painting(PaintBoard.Size.Width,
                PaintBoard.Size.Height, ref PaintBoard);
        }
        //清空画布
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            p.SaveBefore();
            Point mousePoint = new Point(e.X, e.Y);
            p.AddPoint(mousePoint);
            isMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePoint = new Point(e.X, e.Y);
                p.AddPoint(mousePoint);
                p.Draw();
                p.Update();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            p.Clear();
        }

        private void pickStyle(object sender, EventArgs e)
        {
            Button b = sender as Button;
            //Panel panel = sender as Panel;
            if (b != null)
            {
                switch (b.Name)
                {
                    case "solid":
                        //MessageBox.Show("in", "in");
                        p.SetPenStyle(System.Drawing.Drawing2D.DashStyle.Solid);
                        break;
                    case "dash":
                        p.SetPenStyle(System.Drawing.Drawing2D.DashStyle.Dash);
                        break;
                    case "dot":
                        p.SetPenStyle(System.Drawing.Drawing2D.DashStyle.Dot);
                        break;
                    case "dashDot":
                        p.SetPenStyle(System.Drawing.Drawing2D.DashStyle.DashDot);
                        break;
                }
            }
        }

        private void pickPen(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b!= null)
            {
                switch (b.Name)
                {
                    case "straightLine":
                       //MessageBox.Show("in", "in");
                        p.ChangeStatus(Painting.Status.STRAINGHTLINE);
                        break;
                    case "curve":
                        p.ChangeStatus(Painting.Status.CURVE);
                        break;
                    case "eraser":
                        p.ChangeStatus(Painting.Status.ERASER);
                        break;
                }
            }
        }
        private void pickPicture()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                p.SetImage(openFileDialog1.FileName);
                p.ChangeStatus(Painting.Status.IMAGE);
            }
        }

        private void setShape(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                switch (b.Name)
                {
                    case "poly":
                        p.ChangeStatus(Painting.Status.POLY);
                        break;
                    case "rectangle":
                        p.ChangeStatus(Painting.Status.REC);
                        break;
                    case "circle":
                        p.ChangeStatus(Painting.Status.CIR);
                        break;
                    case "triangle":
                        p.ChangeStatus(Painting.Status.TRI);
                        break;
                    case "star":
                        p.ChangeStatus(Painting.Status.STAR);
                        break;
                    case "cross":
                        p.ChangeStatus(Painting.Status.CROSS);
                        break;
                    case "write":
                        Fore();
                        p.ChangeStatus(Painting.Status.WRITE);
                        break;
                    case "image":
                        this.pickPicture();
                        break;

                }
            }
        }

        private void saveClick(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "图像文件(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
            saveFileDialog1.DefaultExt = ".jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                PaintBoard.Image.Save(fileName);
            }
        }

        private void setPenWidth(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if(b!= null)
            {
                switch (b.Name)
                {
                    case "Line1":
                        p.SetPenWidth(3);
                        break;
                    case "Line2":
                        p.SetPenWidth(5);
                        break;
                    case "Line3":
                        p.SetPenWidth(8);
                        break;
                    case "Line4":
                        p.SetPenWidth(11);
                        break;
                    case "Line5":
                        p.SetPenWidth(14);
                        break;
                }
            }
        }

        private void reverse_Click(object sender, EventArgs e)
        {
            p.Revoke();
        }

        private void Fore()
        {
            StringWrite stringWrite = new StringWrite();
            stringWrite.Owner = this;
            stringWrite.ShowDialog();
            string GetString = stringWrite.strwrite;
            if (stringWrite.Check && stringWrite.strwrite != null)
            {
                fontDialog1.ShowColor = true;
                fontDialog1.ShowDialog();
                p.Strinform(GetString, fontDialog1.Font, fontDialog1.Color);
            }
            else if (stringWrite.strwrite != null)
            {
                p.Strinform(GetString, new Font("Arial", 16), Color.Black);
            }
        }
        private void clear(object sender, EventArgs e)
        {
            p.SetBackground();
        }

        private void foreColorChangeClick(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                forecolorButton.BackColor = ColorDialog.Color;

                p.SetPenColor(ColorDialog.Color);
            }
        }

        private void backColorChangeClick(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                backcolorButton.BackColor = ColorDialog.Color;

                p.SetBackground(ColorDialog.Color);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LabelTool_Click(object sender, EventArgs e)
        {

        }
    }
}
