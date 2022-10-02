
namespace ergasia2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.straightLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freestyleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extraSmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraExtraLargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCanvasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawAFaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawChristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapesToolStripMenuItem,
            this.chooseColorToolStripMenuItem,
            this.toolStripComboBox1,
            this.clearCanvasToolStripMenuItem,
            this.canvasColorToolStripMenuItem,
            this.eraserToolStripMenuItem,
            this.drawHouseToolStripMenuItem,
            this.drawAFaceToolStripMenuItem,
            this.drawChristasToolStripMenuItem,
            this.drawToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1356, 105);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.straightLinesToolStripMenuItem,
            this.freestyleToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.elipseToolStripMenuItem});
            this.shapesToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(132, 54);
            this.shapesToolStripMenuItem.Text = "Shapes";
            this.shapesToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // straightLinesToolStripMenuItem
            // 
            this.straightLinesToolStripMenuItem.Name = "straightLinesToolStripMenuItem";
            this.straightLinesToolStripMenuItem.Size = new System.Drawing.Size(306, 54);
            this.straightLinesToolStripMenuItem.Text = "Straight lines";
            this.straightLinesToolStripMenuItem.Click += new System.EventHandler(this.straightLinesToolStripMenuItem_Click);
            // 
            // freestyleToolStripMenuItem
            // 
            this.freestyleToolStripMenuItem.Name = "freestyleToolStripMenuItem";
            this.freestyleToolStripMenuItem.Size = new System.Drawing.Size(306, 54);
            this.freestyleToolStripMenuItem.Text = "Freestyle";
            this.freestyleToolStripMenuItem.Click += new System.EventHandler(this.freestyleToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(306, 54);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(306, 54);
            this.elipseToolStripMenuItem.Text = "Ellipse";
            this.elipseToolStripMenuItem.Click += new System.EventHandler(this.elipseToolStripMenuItem_Click);
            // 
            // chooseColorToolStripMenuItem
            // 
            this.chooseColorToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseColorToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseColorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.chooseColorToolStripMenuItem.Name = "chooseColorToolStripMenuItem";
            this.chooseColorToolStripMenuItem.Size = new System.Drawing.Size(175, 54);
            this.chooseColorToolStripMenuItem.Text = "Pen Color";
            this.chooseColorToolStripMenuItem.Click += new System.EventHandler(this.chooseColorToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extraSmallToolStripMenuItem,
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.largeToolStripMenuItem,
            this.extraLargeToolStripMenuItem,
            this.extraExtraLargeToolStripMenuItem});
            this.toolStripComboBox1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toolStripComboBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(156, 54);
            this.toolStripComboBox1.Text = "Pen Size";
            // 
            // extraSmallToolStripMenuItem
            // 
            this.extraSmallToolStripMenuItem.Name = "extraSmallToolStripMenuItem";
            this.extraSmallToolStripMenuItem.Size = new System.Drawing.Size(373, 54);
            this.extraSmallToolStripMenuItem.Text = "Extra Small";
            this.extraSmallToolStripMenuItem.Click += new System.EventHandler(this.extraSmallToolStripMenuItem_Click);
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(373, 54);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(373, 54);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(373, 54);
            this.largeToolStripMenuItem.Text = "Large";
            this.largeToolStripMenuItem.Click += new System.EventHandler(this.largeToolStripMenuItem_Click);
            // 
            // extraLargeToolStripMenuItem
            // 
            this.extraLargeToolStripMenuItem.Name = "extraLargeToolStripMenuItem";
            this.extraLargeToolStripMenuItem.Size = new System.Drawing.Size(373, 54);
            this.extraLargeToolStripMenuItem.Text = "Extra Large";
            this.extraLargeToolStripMenuItem.Click += new System.EventHandler(this.extraLargeToolStripMenuItem_Click);
            // 
            // extraExtraLargeToolStripMenuItem
            // 
            this.extraExtraLargeToolStripMenuItem.Name = "extraExtraLargeToolStripMenuItem";
            this.extraExtraLargeToolStripMenuItem.Size = new System.Drawing.Size(373, 54);
            this.extraExtraLargeToolStripMenuItem.Text = "Extra Extra Large";
            this.extraExtraLargeToolStripMenuItem.Click += new System.EventHandler(this.extraExtraLargeToolStripMenuItem_Click);
            // 
            // clearCanvasToolStripMenuItem
            // 
            this.clearCanvasToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearCanvasToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.clearCanvasToolStripMenuItem.Name = "clearCanvasToolStripMenuItem";
            this.clearCanvasToolStripMenuItem.Size = new System.Drawing.Size(211, 51);
            this.clearCanvasToolStripMenuItem.Text = "Clear Canvas";
            this.clearCanvasToolStripMenuItem.Click += new System.EventHandler(this.clearCanvasToolStripMenuItem_Click);
            // 
            // canvasColorToolStripMenuItem
            // 
            this.canvasColorToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.canvasColorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.canvasColorToolStripMenuItem.Name = "canvasColorToolStripMenuItem";
            this.canvasColorToolStripMenuItem.Size = new System.Drawing.Size(211, 51);
            this.canvasColorToolStripMenuItem.Text = "Canvas Color";
            this.canvasColorToolStripMenuItem.Click += new System.EventHandler(this.canvasColorToolStripMenuItem_Click);
            // 
            // eraserToolStripMenuItem
            // 
            this.eraserToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.eraserToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            this.eraserToolStripMenuItem.Size = new System.Drawing.Size(121, 51);
            this.eraserToolStripMenuItem.Text = "Eraser";
            this.eraserToolStripMenuItem.Click += new System.EventHandler(this.eraserToolStripMenuItem_Click);
            // 
            // drawHouseToolStripMenuItem
            // 
            this.drawHouseToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.drawHouseToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.drawHouseToolStripMenuItem.Name = "drawHouseToolStripMenuItem";
            this.drawHouseToolStripMenuItem.Size = new System.Drawing.Size(198, 51);
            this.drawHouseToolStripMenuItem.Text = "Draw House";
            this.drawHouseToolStripMenuItem.Click += new System.EventHandler(this.drawHouseToolStripMenuItem_Click);
            // 
            // drawAFaceToolStripMenuItem
            // 
            this.drawAFaceToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.drawAFaceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.drawAFaceToolStripMenuItem.Name = "drawAFaceToolStripMenuItem";
            this.drawAFaceToolStripMenuItem.Size = new System.Drawing.Size(219, 51);
            this.drawAFaceToolStripMenuItem.Text = "Draw Human";
            this.drawAFaceToolStripMenuItem.Click += new System.EventHandler(this.drawAFaceToolStripMenuItem_Click);
            // 
            // drawChristasToolStripMenuItem
            // 
            this.drawChristasToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.drawChristasToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.drawChristasToolStripMenuItem.Name = "drawChristasToolStripMenuItem";
            this.drawChristasToolStripMenuItem.Size = new System.Drawing.Size(327, 51);
            this.drawChristasToolStripMenuItem.Text = "Draw Christmas Tree";
            this.drawChristasToolStripMenuItem.Click += new System.EventHandler(this.drawChristasToolStripMenuItem_Click);
            // 
            // drawToolStripMenuItem
            // 
            this.drawToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.drawToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            this.drawToolStripMenuItem.Size = new System.Drawing.Size(169, 51);
            this.drawToolStripMenuItem.Text = "Draw Box";
            this.drawToolStripMenuItem.Click += new System.EventHandler(this.drawToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(15, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 629);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1356, 766);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem straightLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freestyleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem extraSmallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraLargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraExtraLargeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem clearCanvasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canvasColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eraserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawHouseToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem drawAFaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drawChristasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

