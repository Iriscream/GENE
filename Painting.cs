using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GRDrawing
{
    class Painting
    {
        // 画笔
        Pen pen;
        // 鼠标路径
        GraphicsPath mousePath;
        // 位图
        Bitmap bitmap, prevBitmap;
        // 保存之前的状态，以实现撤销功能
        Bitmap[] revBitmap = new Bitmap[6];
        // 画布
        PictureBox Canvas;
        // 背景颜色
        Color penColor, backgroundColor;
        // 笔的粗细
        float penSize;
        //文字字体
        Font strFont;
        //文字颜色
        Color strColor;
        //文字内容
        string str;
        // 图片
        Image image;

        // 表示正在绘制的图形的枚举
        public enum Status { STRAINGHTLINE, CURVE, ERASER, REC, POLY, CIR, TRI, STAR, CROSS, WRITE, IMAGE};
        Status nowStatus = new Status();

        // 构造函数
        public Painting(int width, int height, ref PictureBox pictureBox)
        {
            bitmap = new Bitmap(width, height);
            // 初始背景颜色设为白色
            backgroundColor = Color.White;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(backgroundColor);
            prevBitmap = (Bitmap)bitmap.Clone();

            Canvas = pictureBox;

            // 初始设置笔的颜色为黑色，粗细为5个像素，样式为实现
            penColor = Color.Black;
            penSize = 5;
            pen = new Pen(penColor, penSize);


            mousePath = new GraphicsPath();
            

            for (int i = 0; i < 6; i++)
            {
                revBitmap[i] = (Bitmap)bitmap.Clone();
            }
        }

        // 设置笔的颜色
        public void SetPenColor(Color color)
        {
            penColor = color;
            pen.Color = penColor;
        }

        // 设置笔的粗细
        public void SetPenWidth(float width)
        {
            penSize = width;
            pen.Width = penSize;
        }

        // 设置笔的样式
        public void SetPenStyle(DashStyle dashStyle)
        {
            pen.DashStyle = dashStyle;
        }

        // 设置背景颜色
        public void SetBackground(Color color)
        {
            backgroundColor = color;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(backgroundColor);
            Update();
        }

        public void SetBackground()
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(backgroundColor);
            Update();
        }

        public void SetImage(string fileName)
        {
            image = Image.FromFile(fileName);
        }

        // 搜集鼠标轨迹
        public void AddPoint(Point point)
        {
            if (mousePath.PointCount == 0)
                prevBitmap = (Bitmap)bitmap.Clone();

            mousePath.AddLine(point, point);
        }

        //获取书写文字信息
        public void Strinform(string temp, Font font, Color color)
        {
            strColor = color;
            strFont = font;
            str = temp;
        }

        // 清空mousePath
        public void Clear()
        {
            mousePath.Dispose();
            mousePath = new GraphicsPath();
        }

        // 画直线
        public void DrawLine()
        {
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            // 使用鼠标轨迹的第一个和最后一个点绘制直线
            graphics.DrawLine(pen, mousePath.PathPoints[0], 
                    mousePath.PathPoints[mousePath.PointCount - 1]);
        }


        // 画曲线
        public void DrawCurve()
        {
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawPath(pen, mousePath);
        }
        //画矩形
        public void DrawRec()
        {
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            PointF p1 = new PointF(mousePath.PathPoints[0].X, mousePath.PathPoints[0].Y);
            PointF p2 = new PointF(mousePath.PathPoints[0].X, mousePath.PathPoints[mousePath.PointCount - 1].Y);
            PointF p4 = new PointF(mousePath.PathPoints[mousePath.PointCount - 1].X, mousePath.PathPoints[0].Y);
            PointF p3 = new PointF(mousePath.PathPoints[mousePath.PointCount - 1].X, mousePath.PathPoints[mousePath.PointCount - 1].Y);
            PointF[] SerPointF =
                            {
                p1,
                p2,
                p3,
                p4,
            };

            graphics.DrawPolygon(pen, SerPointF);
        }

        //画菱形
        public void DrawPoly()
        {
            bitmap = (Bitmap)prevBitmap.Clone();
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            PointF p1 = new PointF((mousePath.PathPoints[0].X + mousePath.PathPoints[mousePath.PointCount - 1].X) / 2, mousePath.PathPoints[0].Y);
            PointF p2 = new PointF(mousePath.PathPoints[0].X, (mousePath.PathPoints[mousePath.PointCount - 1].Y + mousePath.PathPoints[0].Y) / 2);
            PointF p3 = new PointF((mousePath.PathPoints[0].X + mousePath.PathPoints[mousePath.PointCount - 1].X) / 2, mousePath.PathPoints[mousePath.PointCount - 1].Y);
            PointF p4 = new PointF(mousePath.PathPoints[mousePath.PointCount - 1].X, (mousePath.PathPoints[mousePath.PointCount - 1].Y + mousePath.PathPoints[0].Y) / 2);
            PointF[] SerPointF =
                {
                p1,
                p2,
                p3,
                p4,
            };

            graphics.DrawPolygon(pen, SerPointF);
        }
        //画圆形
        public void DrawCir()
        {
            
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            float r_len = (float)Math.Sqrt(Math.Pow((mousePath.PathPoints[0].X - mousePath.PathPoints[mousePath.PointCount - 1].X), 2.0) + Math.Pow((mousePath.PathPoints[0].Y - mousePath.PathPoints[mousePath.PointCount - 1].Y), 2.0));
            graphics.DrawEllipse(pen, mousePath.PathPoints[0].X, mousePath.PathPoints[0].Y, r_len, r_len);
        }

        //画三角形
        public void DrawTri()
        {
            
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            PointF point1 = new PointF((mousePath.PathPoints[0].X + mousePath.PathPoints[mousePath.PointCount - 1].X) / 2, mousePath.PathPoints[0].Y);
            PointF point2 = new PointF(mousePath.PathPoints[0].X, mousePath.PathPoints[mousePath.PointCount - 1].Y);
            PointF point3 = mousePath.PathPoints[mousePath.PointCount - 1];
            PointF[] SerPointF =
               {
                point1,
                point2,
                point3,
            };
            graphics.DrawPolygon(pen, SerPointF);
        }
        //画十字
        public void DrawCross()
        {
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            float x1, x2, x3, x4;
            float y1, y2, y3, y4;
            x1 = (float)mousePath.PathPoints[0].X;
            x2 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].X - mousePath.PathPoints[0].X) * 0.4 + mousePath.PathPoints[0].X);
            x3 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].X - mousePath.PathPoints[0].X) * 0.6 + mousePath.PathPoints[0].X);
            x4 = (float)(mousePath.PathPoints[mousePath.PointCount - 1].X);
            y1 = (float)mousePath.PathPoints[0].Y;
            y2 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].Y - mousePath.PathPoints[0].Y) * 0.4 + mousePath.PathPoints[0].Y);
            y3 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].Y - mousePath.PathPoints[0].Y) * 0.6 + mousePath.PathPoints[0].Y);
            y4 = (float)mousePath.PathPoints[mousePath.PointCount - 1].Y;
            PointF p1 = new PointF(x2, y1);
            PointF p2 = new PointF(x2, y2);
            PointF p3 = new PointF(x1, y2);
            PointF p4 = new PointF(x1, y3);
            PointF p5 = new PointF(x2, y3);
            PointF p6 = new PointF(x2, y4);
            PointF p7 = new PointF(x3, y4);
            PointF p8 = new PointF(x3, y3);
            PointF p9 = new PointF(x4, y3);
            PointF p10 = new PointF(x4, y2);
            PointF p11 = new PointF(x3, y2);
            PointF p12 = new PointF(x3, y1);
            PointF[] SerPointF =
                {
                    p1,
                    p2,
                    p3,
                    p4,
                    p5,
                    p6,
                    p7,
                    p8,
                    p9,
                    p10,
                    p11,
                    p12
                 };
            graphics.DrawPolygon(pen, SerPointF);
        }
        //画五角星
        public void DrawStar()
        {
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            float x1, x2, x3, x4, x5, x6, x7, x8, x9;
            float y1, y2, y3, y4, y5;
            x1 = (float)mousePath.PathPoints[0].X;
            x2 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].X - mousePath.PathPoints[0].X) * 0.2 + mousePath.PathPoints[0].X);
            x3 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].X - mousePath.PathPoints[0].X) * 0.3 + mousePath.PathPoints[0].X);
            x4 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].X - mousePath.PathPoints[0].X) * 0.4 + mousePath.PathPoints[0].X);
            x5 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].X - mousePath.PathPoints[0].X) * 0.5 + mousePath.PathPoints[0].X);
            x6 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].X - mousePath.PathPoints[0].X) * 0.6 + mousePath.PathPoints[0].X);
            x7 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].X - mousePath.PathPoints[0].X) * 0.7 + mousePath.PathPoints[0].X);
            x8 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].X - mousePath.PathPoints[0].X) * 0.8 + mousePath.PathPoints[0].X);
            x9 = (float)(mousePath.PathPoints[mousePath.PointCount - 1].X);
            y1 = (float)mousePath.PathPoints[0].Y;
            y2 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].Y - mousePath.PathPoints[0].Y) * 0.3 + mousePath.PathPoints[0].Y);
            y3 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].Y - mousePath.PathPoints[0].Y) * 0.5 + mousePath.PathPoints[0].Y);
            y4 = (float)((mousePath.PathPoints[mousePath.PointCount - 1].Y - mousePath.PathPoints[0].Y) * 0.67 + mousePath.PathPoints[0].Y);
            y5 = (float)mousePath.PathPoints[mousePath.PointCount - 1].Y;

            PointF p1 = new PointF(x5, y1);
            PointF p2 = new PointF(x4, y2);
            PointF p3 = new PointF(x1, y2);
            PointF p4 = new PointF(x3, y3);
            PointF p5 = new PointF(x2, y5);
            PointF p6 = new PointF(x5, y4);
            PointF p7 = new PointF(x8, y5);
            PointF p8 = new PointF(x7, y3);
            PointF p9 = new PointF(x9, y2);
            PointF p10 = new PointF(x6, y2);
            PointF[] SerPointF =
                {
                    p1,
                    p2,
                    p3,
                    p4,
                    p5,
                    p6,
                    p7,
                    p8,
                    p9,
                    p10,
                 };
            graphics.DrawPolygon(pen, SerPointF);
        }


        //绘制文本
        public void DrawStr()
        {
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            SolidBrush brush = new SolidBrush(strColor);
            float x, y;
            x = mousePath.PathPoints[0].X;
            y = mousePath.PathPoints[0].Y;
            float wid, hig;
            wid = mousePath.PathPoints[mousePath.PointCount - 1].X - x;
            hig = mousePath.PathPoints[mousePath.PointCount - 1].Y - y;
            RectangleF strRec = new RectangleF(x, y, wid, hig);
            graphics.DrawString(str, strFont, brush, strRec);

        }
        //引用照片
        public void DrawImage()
        {
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            PointF p = new PointF(mousePath.PathPoints[0].X, mousePath.PathPoints[0].Y);
            PointF p2 = new PointF(mousePath.PathPoints[mousePath.PointCount - 1].X, mousePath.PathPoints[mousePath.PointCount - 1].Y);
            RectangleF rectangle = new RectangleF(p.X, p.Y, p2.X - p.X, p2.Y - p.Y);
            graphics.DrawImage(image, rectangle);
        }

        //橡皮擦升级版
        public void DrawFillElli()
        {
            bitmap = (Bitmap)prevBitmap.Clone();
            Graphics graphics = Graphics.FromImage(bitmap);
            float x1,y1;
            x1 = mousePath.PathPoints[mousePath.PointCount - 1].X -10;
            y1 = mousePath.PathPoints[mousePath.PointCount - 1].Y - 10;
            SolidBrush brush = new SolidBrush(backgroundColor);
            graphics.FillEllipse(brush,x1,y1,20,20);
        }

        // 使当前绘制图像在画布上显现
        public void Update()
        {
            Canvas.Image = bitmap;
        }

        public void ChangeStatus(Status status)
        {
            nowStatus = status;
        }

        // 根据状态绘制图形
        public void Draw()
        {
            switch (nowStatus)
            {
                case Status.STRAINGHTLINE:
                    DrawLine();
                    break;
                case Status.CURVE:
                    DrawCurve();
                    break;
                case Status.ERASER:
                    pen.Width = 20;
                    pen.Color = backgroundColor;
                    DrawCurve();
                    pen.Width = penSize;
                    pen.Color = penColor;
                    break;
                case Status.REC:
                    DrawRec();
                    break;
                case Status.POLY:
                    DrawPoly();
                    break;
                case Status.CIR:
                    DrawCir();
                    break;
                case Status.TRI:
                    DrawTri();
                    break;
                case Status.CROSS:
                    DrawCross();
                    break;
                case Status.STAR:
                    DrawStar();
                    break;
                case Status.WRITE:
                    DrawStr();
                    break;
                case Status.IMAGE:
                    DrawImage();
                    break;
            }
        }

        // 保存之前的位图
        public void SaveBefore()
        {
            for (int i = 5; i > 0; i--)
            {
                revBitmap[i] = (Bitmap)revBitmap[i - 1].Clone();
            }
            revBitmap[0] = (Bitmap)bitmap.Clone();
        }

        // 将画布上的的位图设置为前一张位图，实现撤销
        public void Revoke()
        {
            bitmap = (Bitmap)revBitmap[0].Clone();
            prevBitmap = (Bitmap)revBitmap[0].Clone();
            Update();
            for (int i = 0; i < 5; i++)
            {
                revBitmap[i] = (Bitmap)revBitmap[i + 1].Clone();
            }
        }
    }
}
