
namespace MyPainter2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PaintBoard = new System.Windows.Forms.PictureBox();
            this.circle = new System.Windows.Forms.Button();
            this.curve = new System.Windows.Forms.Button();
            this.straightLine = new System.Windows.Forms.Button();
            this.poly = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTool = new System.Windows.Forms.Label();
            this.LabelShape = new System.Windows.Forms.Label();
            this.LabelColor = new System.Windows.Forms.Label();
            this.reverse = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.write = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Line1 = new System.Windows.Forms.Button();
            this.Line2 = new System.Windows.Forms.Button();
            this.Line3 = new System.Windows.Forms.Button();
            this.Line4 = new System.Windows.Forms.Button();
            this.Line5 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.solid = new System.Windows.Forms.Button();
            this.dashDot = new System.Windows.Forms.Button();
            this.dash = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.forecolorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backcolorButton = new System.Windows.Forms.Button();
            this.star = new System.Windows.Forms.Button();
            this.cross = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.image = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaintBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // PaintBoard
            // 
            this.PaintBoard.BackColor = System.Drawing.Color.White;
            this.PaintBoard.Location = new System.Drawing.Point(218, 17);
            this.PaintBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PaintBoard.Name = "PaintBoard";
            this.PaintBoard.Size = new System.Drawing.Size(671, 544);
            this.PaintBoard.TabIndex = 1;
            this.PaintBoard.TabStop = false;
            this.PaintBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.PaintBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.PaintBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle.BackgroundImage")));
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circle.Location = new System.Drawing.Point(62, 528);
            this.circle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(32, 32);
            this.circle.TabIndex = 2;
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.setShape);
            // 
            // curve
            // 
            this.curve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.curve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("curve.BackgroundImage")));
            this.curve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.curve.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.curve.Location = new System.Drawing.Point(20, 482);
            this.curve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.curve.Name = "curve";
            this.curve.Size = new System.Drawing.Size(32, 32);
            this.curve.TabIndex = 3;
            this.curve.UseVisualStyleBackColor = false;
            this.curve.Click += new System.EventHandler(this.pickPen);
            // 
            // straightLine
            // 
            this.straightLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.straightLine.BackgroundImage = global::MyPainter2.Properties.Resources.line;
            this.straightLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.straightLine.Location = new System.Drawing.Point(62, 482);
            this.straightLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.straightLine.Name = "straightLine";
            this.straightLine.Size = new System.Drawing.Size(32, 32);
            this.straightLine.TabIndex = 4;
            this.straightLine.UseVisualStyleBackColor = false;
            this.straightLine.Click += new System.EventHandler(this.pickPen);
            // 
            // poly
            // 
            this.poly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.poly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("poly.BackgroundImage")));
            this.poly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.poly.Location = new System.Drawing.Point(107, 482);
            this.poly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.poly.Name = "poly";
            this.poly.Size = new System.Drawing.Size(32, 32);
            this.poly.TabIndex = 5;
            this.poly.UseVisualStyleBackColor = false;
            this.poly.Click += new System.EventHandler(this.setShape);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle.BackgroundImage")));
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangle.Location = new System.Drawing.Point(107, 528);
            this.rectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(32, 32);
            this.rectangle.TabIndex = 6;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.setShape);
            // 
            // triangle
            // 
            this.triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("triangle.BackgroundImage")));
            this.triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangle.Location = new System.Drawing.Point(20, 528);
            this.triangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(32, 32);
            this.triangle.TabIndex = 7;
            this.triangle.UseVisualStyleBackColor = false;
            this.triangle.Click += new System.EventHandler(this.setShape);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eraser.BackgroundImage = global::MyPainter2.Properties.Resources.xiangpi;
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraser.Location = new System.Drawing.Point(152, 273);
            this.eraser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(32, 32);
            this.eraser.TabIndex = 8;
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.pickPen);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-520, -108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // LabelTool
            // 
            this.LabelTool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTool.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTool.Location = new System.Drawing.Point(20, 195);
            this.LabelTool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTool.Name = "LabelTool";
            this.LabelTool.Size = new System.Drawing.Size(58, 19);
            this.LabelTool.TabIndex = 12;
            this.LabelTool.Text = "TOOL";
            this.LabelTool.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelTool.Click += new System.EventHandler(this.LabelTool_Click);
            // 
            // LabelShape
            // 
            this.LabelShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LabelShape.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelShape.Location = new System.Drawing.Point(20, 450);
            this.LabelShape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelShape.Name = "LabelShape";
            this.LabelShape.Size = new System.Drawing.Size(62, 19);
            this.LabelShape.TabIndex = 13;
            this.LabelShape.Text = "SHAPE";
            // 
            // LabelColor
            // 
            this.LabelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelColor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelColor.Location = new System.Drawing.Point(18, 50);
            this.LabelColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(64, 19);
            this.LabelColor.TabIndex = 14;
            this.LabelColor.Text = "COLOR";
            // 
            // reverse
            // 
            this.reverse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reverse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reverse.BackgroundImage")));
            this.reverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reverse.Location = new System.Drawing.Point(107, 273);
            this.reverse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(32, 32);
            this.reverse.TabIndex = 15;
            this.reverse.UseVisualStyleBackColor = false;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.Location = new System.Drawing.Point(2, -2);
            this.save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(32, 32);
            this.save.TabIndex = 16;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.saveClick);
            // 
            // write
            // 
            this.write.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.write.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("write.BackgroundImage")));
            this.write.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.write.Location = new System.Drawing.Point(20, 273);
            this.write.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(32, 32);
            this.write.TabIndex = 17;
            this.write.UseVisualStyleBackColor = false;
            this.write.Click += new System.EventHandler(this.setShape);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(20, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 100);
            this.label5.TabIndex = 18;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Line1.Location = new System.Drawing.Point(39, 334);
            this.Line1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(125, 9);
            this.Line1.TabIndex = 19;
            this.Line1.Text = "button13";
            this.Line1.UseVisualStyleBackColor = false;
            this.Line1.Click += new System.EventHandler(this.setPenWidth);
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.SystemColors.ControlText;
            this.Line2.Location = new System.Drawing.Point(39, 349);
            this.Line2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(125, 12);
            this.Line2.TabIndex = 20;
            this.Line2.Text = "button14";
            this.Line2.UseVisualStyleBackColor = false;
            this.Line2.Click += new System.EventHandler(this.setPenWidth);
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.SystemColors.ControlText;
            this.Line3.Location = new System.Drawing.Point(39, 365);
            this.Line3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(125, 13);
            this.Line3.TabIndex = 21;
            this.Line3.Text = "button15";
            this.Line3.UseVisualStyleBackColor = false;
            this.Line3.Click += new System.EventHandler(this.setPenWidth);
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.SystemColors.ControlText;
            this.Line4.Location = new System.Drawing.Point(39, 381);
            this.Line4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(125, 15);
            this.Line4.TabIndex = 22;
            this.Line4.Text = "button16";
            this.Line4.UseVisualStyleBackColor = false;
            this.Line4.Click += new System.EventHandler(this.setPenWidth);
            // 
            // Line5
            // 
            this.Line5.BackColor = System.Drawing.SystemColors.ControlText;
            this.Line5.Location = new System.Drawing.Point(39, 400);
            this.Line5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Line5.Name = "Line5";
            this.Line5.Size = new System.Drawing.Size(125, 15);
            this.Line5.TabIndex = 23;
            this.Line5.Text = "button17";
            this.Line5.UseVisualStyleBackColor = false;
            this.Line5.Click += new System.EventHandler(this.setPenWidth);
            // 
            // dot
            // 
            this.dot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dot.BackgroundImage")));
            this.dot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dot.Location = new System.Drawing.Point(152, 228);
            this.dot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(32, 32);
            this.dot.TabIndex = 31;
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.pickStyle);
            // 
            // solid
            // 
            this.solid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("solid.BackgroundImage")));
            this.solid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.solid.Location = new System.Drawing.Point(20, 228);
            this.solid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.solid.Name = "solid";
            this.solid.Size = new System.Drawing.Size(32, 32);
            this.solid.TabIndex = 32;
            this.solid.UseVisualStyleBackColor = true;
            this.solid.Click += new System.EventHandler(this.pickStyle);
            // 
            // dashDot
            // 
            this.dashDot.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dashDot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashDot.BackgroundImage")));
            this.dashDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashDot.Location = new System.Drawing.Point(62, 228);
            this.dashDot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashDot.Name = "dashDot";
            this.dashDot.Size = new System.Drawing.Size(32, 32);
            this.dashDot.TabIndex = 33;
            this.dashDot.UseVisualStyleBackColor = false;
            this.dashDot.Click += new System.EventHandler(this.pickStyle);
            // 
            // dash
            // 
            this.dash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dash.BackgroundImage")));
            this.dash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dash.Location = new System.Drawing.Point(107, 228);
            this.dash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(32, 32);
            this.dash.TabIndex = 34;
            this.dash.UseVisualStyleBackColor = true;
            this.dash.Click += new System.EventHandler(this.pickStyle);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "ForeColor";
            // 
            // forecolorButton
            // 
            this.forecolorButton.BackColor = System.Drawing.Color.Black;
            this.forecolorButton.Location = new System.Drawing.Point(114, 92);
            this.forecolorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forecolorButton.Name = "forecolorButton";
            this.forecolorButton.Size = new System.Drawing.Size(32, 32);
            this.forecolorButton.TabIndex = 36;
            this.forecolorButton.UseVisualStyleBackColor = false;
            this.forecolorButton.Click += new System.EventHandler(this.foreColorChangeClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(18, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 37;
            this.label3.Text = "BackColor";
            // 
            // backcolorButton
            // 
            this.backcolorButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backcolorButton.Location = new System.Drawing.Point(114, 141);
            this.backcolorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backcolorButton.Name = "backcolorButton";
            this.backcolorButton.Size = new System.Drawing.Size(32, 32);
            this.backcolorButton.TabIndex = 38;
            this.backcolorButton.UseVisualStyleBackColor = false;
            this.backcolorButton.Click += new System.EventHandler(this.backColorChangeClick);
            // 
            // star
            // 
            this.star.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.star.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("star.BackgroundImage")));
            this.star.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.star.Location = new System.Drawing.Point(152, 482);
            this.star.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(32, 32);
            this.star.TabIndex = 41;
            this.star.UseVisualStyleBackColor = false;
            this.star.Click += new System.EventHandler(this.setShape);
            // 
            // cross
            // 
            this.cross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cross.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cross.BackgroundImage")));
            this.cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cross.Location = new System.Drawing.Point(152, 528);
            this.cross.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(32, 32);
            this.cross.TabIndex = 42;
            this.cross.UseVisualStyleBackColor = false;
            this.cross.Click += new System.EventHandler(this.setShape);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("image.BackgroundImage")));
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.Location = new System.Drawing.Point(62, 273);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(32, 32);
            this.image.TabIndex = 43;
            this.image.UseVisualStyleBackColor = false;
            this.image.Click += new System.EventHandler(this.setShape);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(218, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 37);
            this.button2.TabIndex = 45;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.clear);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 578);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.image);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.star);
            this.Controls.Add(this.backcolorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forecolorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dash);
            this.Controls.Add(this.dashDot);
            this.Controls.Add(this.solid);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.Line5);
            this.Controls.Add(this.Line4);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.write);
            this.Controls.Add(this.save);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.LabelColor);
            this.Controls.Add(this.LabelShape);
            this.Controls.Add(this.LabelTool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.straightLine);
            this.Controls.Add(this.curve);
            this.Controls.Add(this.triangle);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.eraser);
            this.Controls.Add(this.poly);
            this.Controls.Add(this.PaintBoard);
            this.Controls.Add(this.rectangle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "MyPainter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaintBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PaintBoard;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button curve;
        private System.Windows.Forms.Button straightLine;
        private System.Windows.Forms.Button poly;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelTool;
        private System.Windows.Forms.Label LabelShape;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Line1;
        private System.Windows.Forms.Button Line2;
        private System.Windows.Forms.Button Line3;
        private System.Windows.Forms.Button Line4;
        private System.Windows.Forms.Button Line5;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button solid;
        private System.Windows.Forms.Button dashDot;
        private System.Windows.Forms.Button dash;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button forecolorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backcolorButton;
        private System.Windows.Forms.Button star;
        private System.Windows.Forms.Button cross;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button button2;
    }
}

