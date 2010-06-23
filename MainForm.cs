
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace KarnaughMap
{
    public partial class MainForm : Form
    {
        private Graphics graphics;
        
        public MainForm()
        {
            InitializeComponent();
        }
        
        void MainFormLoad(object sender, EventArgs e)
        {
        	graphics = gbk.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
        
        void MainFormPaint(object sender, PaintEventArgs e)
        {
            tb_equation.Text = DrawGroups();
        }
        
        void Cbt_000CheckedChanged(object sender, EventArgs e)
        {
        	cbk_000.Checked = cbt_000.Checked;
        	this.Refresh();
        }
        
        void Cbk_000CheckedChanged(object sender, EventArgs e)
        {
        	cbt_000.Checked = cbk_000.Checked;
            this.Refresh();
        }
        
        void Cbt_001CheckedChanged(object sender, EventArgs e)
        {
        	cbk_100.Checked = cbt_001.Checked;
        	this.Refresh();
        }
        
        void Cbk_100CheckedChanged(object sender, EventArgs e)
        {
        	cbt_001.Checked = cbk_100.Checked;
        	this.Refresh();
        }
        
        void Cbt_010CheckedChanged(object sender, EventArgs e)
        {
        	cbk_001.Checked = cbt_010.Checked;
        	this.Refresh();
        }
        
        void Cbk_001CheckedChanged(object sender, EventArgs e)
        {
        	cbt_010.Checked = cbk_001.Checked;
        	this.Refresh();
        }
        
        void Cbt_011CheckedChanged(object sender, EventArgs e)
        {
        	cbk_101.Checked = cbt_011.Checked;
        	this.Refresh();
        }
        
        void Cbk_101CheckedChanged(object sender, EventArgs e)
        {
        	cbt_011.Checked = cbk_101.Checked;
        	this.Refresh();
        }
        
        void Cbt_100CheckedChanged(object sender, EventArgs e)
        {
        	cbk_010.Checked = cbt_100.Checked;
        	this.Refresh();
        }
        
        void Cbk_010CheckedChanged(object sender, EventArgs e)
        {
        	cbt_100.Checked = cbk_010.Checked;
        	this.Refresh();
        }
        
        void Cbt_101CheckedChanged(object sender, EventArgs e)
        {
        	cbk_110.Checked = cbt_101.Checked;
        	this.Refresh();
        }
        
        void Cbk_110CheckedChanged(object sender, EventArgs e)
        {
        	cbt_101.Checked = cbk_110.Checked;
        	this.Refresh();
        }
        
        void Cbt_110CheckedChanged(object sender, EventArgs e)
        {
        	cbk_011.Checked = cbt_110.Checked;
        	this.Refresh();
        }
        
        void Cbk_011CheckedChanged(object sender, EventArgs e)
        {
        	cbt_110.Checked = cbk_011.Checked;
        	this.Refresh();
        }
        
        void Cbt_111CheckedChanged(object sender, EventArgs e)
        {
        	cbk_111.Checked = cbt_111.Checked;
        	this.Refresh();
        }
        
        void Cbk_111CheckedChanged(object sender, EventArgs e)
        {
        	cbt_111.Checked = cbk_111.Checked;
        	this.Refresh();
        }
        
        string DrawGroups()
        {
            gbk.Refresh();
            string equation = string.Empty;
            List<string> groups = new List<string>();
            
            int xdiff=10, ydiff=19;
            if (Checked8()) 
            {
                int left = cbk_000.Left-xdiff;
                int top = cbk_000.Top-xdiff;
                int width = cbk_110.Left-cbk_000.Left+cbk_110.Width+ydiff;
                int height = cbk_110.Top-cbk_000.Top+cbk_110.Height+ydiff;
                DrawEllipse(left, top, width, height, Color.DarkViolet);
                equation = "1";
            } else {
                xdiff=8; ydiff=15;
                /* Left box */
                if (Checked4(cbk_000, cbk_001, cbk_100, cbk_101)) 
                {
                    int left = cbk_000.Left-xdiff;
                    int top = cbk_000.Top-xdiff;
                    int width = cbk_101.Left-cbk_000.Left+cbk_101.Width+ydiff;
                    int height = cbk_101.Top-cbk_000.Top+cbk_101.Height+ydiff;
                    DrawEllipse(left, top, width, height, Color.Blue);
                    groups.Add("A'");
                } else {
                    xdiff=6; ydiff=11;
                    /* Left two top */
                    if (Checked2(cbk_000, cbk_001) && !Checked4(cbk_000, cbk_001, cbk_011, cbk_010))
                    {
                        int left = cbk_000.Left-xdiff;
                        int top = cbk_000.Top-xdiff;
                        int width = cbk_001.Left-cbk_000.Left+cbk_001.Width+ydiff;
                        int height = cbk_001.Top-cbk_000.Top+cbk_001.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("A'C'");
                    } else {
                        xdiff=4; ydiff=7;
                        /* 000 */
                        if(cbk_000.Checked && !Checked2(cbk_000, cbk_100) && !Checked4(cbk_000, cbk_001, cbk_011, cbk_010))
                        {
                            int left = cbk_000.Left-xdiff;
                            int top = cbk_000.Top-xdiff;
                            int width = cbk_000.Width+ydiff;
                            int height = cbk_000.Height+ydiff;
                            DrawEllipse(left, top, width, height, Color.Firebrick);
                            groups.Add("A'B'C'");
                        }
                        
                        /* 001 */
                        if(cbk_001.Checked && !Checked2(cbk_001, cbk_101) && !Checked2(cbk_001, cbk_011) && !Checked4(cbk_000, cbk_001, cbk_011, cbk_010))
                        {
                            int left = cbk_001.Left-xdiff;
                            int top = cbk_001.Top-xdiff;
                            int width = cbk_001.Width+ydiff;
                            int height = cbk_001.Height+ydiff;
                            DrawEllipse(left, top, width, height, Color.Firebrick);
                            groups.Add("A'BC'");
                        }
                    }
                    
                    /* Left two bottom */
                    if (Checked2(cbk_100, cbk_101) && !Checked4(cbk_100, cbk_101, cbk_111, cbk_110))
                    {
                        int left = cbk_100.Left-xdiff;
                        int top = cbk_100.Top-xdiff;
                        int width = cbk_101.Left-cbk_100.Left+cbk_101.Width+ydiff;
                        int height = cbk_101.Top-cbk_100.Top+cbk_101.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("A'C");
                    } else {
                        xdiff=4; ydiff=7;
                        /* 100 */
                        if(cbk_100.Checked && !Checked2(cbk_000, cbk_100) && !Checked4(cbk_100, cbk_101, cbk_111, cbk_110))
                        {
                            int left = cbk_100.Left-xdiff;
                            int top = cbk_100.Top-xdiff;
                            int width = cbk_100.Width+ydiff;
                            int height = cbk_100.Height+ydiff;
                            DrawEllipse(left, top, width, height, Color.Firebrick);
                            groups.Add("A'B'C");
                        }
                        
                        /* 101 */
                        if(cbk_101.Checked && !Checked2(cbk_001, cbk_101) && !Checked2(cbk_101, cbk_111) && !Checked4(cbk_100, cbk_101, cbk_111, cbk_110))
                        {
                            int left = cbk_101.Left-xdiff;
                            int top = cbk_101.Top-xdiff;
                            int width = cbk_101.Width+ydiff;
                            int height = cbk_101.Height+ydiff;
                            DrawEllipse(left, top, width, height, Color.Firebrick);
                            groups.Add("A'BC");
                        }
                    }
                    
                    /* First column */
                    if (Checked2(cbk_000, cbk_100) && !Checked4(cbk_000, cbk_100, cbk_010, cbk_110))
                    {
                        int left = cbk_000.Left-xdiff;
                        int top = cbk_000.Top-xdiff;
                        int width = cbk_000.Width+ydiff;
                        int height = cbk_100.Top-cbk_000.Top+cbk_100.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("A'B'");
                    }
                    
                    /* Second column */
                    if (Checked2(cbk_001, cbk_101) && !Checked4(cbk_001, cbk_011, cbk_101, cbk_111))
                    {
                        int left = cbk_001.Left-xdiff;
                        int top = cbk_001.Top-xdiff;
                        int width = cbk_001.Width+ydiff;
                        int height = cbk_101.Top-cbk_001.Top+cbk_101.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("A'B");
                    }
                }
                
                /* Middle box */
                if (Checked4(cbk_001, cbk_011, cbk_101, cbk_111)) 
                {
                    int left = cbk_001.Left-xdiff;
                    int top = cbk_001.Top-xdiff;
                    int width = cbk_111.Left-cbk_001.Left+cbk_111.Width+ydiff;
                    int height = cbk_111.Top-cbk_001.Top+cbk_111.Height+ydiff;
                    DrawEllipse(left, top, width, height, Color.Blue);
                    groups.Add("B");
                } else {
                    xdiff=6; ydiff=11;
                    /* Middle two top */
                    if (Checked2(cbk_001, cbk_011) && !Checked4(cbk_000, cbk_001, cbk_011, cbk_010))
                    {
                        int left = cbk_001.Left-xdiff;
                        int top = cbk_001.Top-xdiff;
                        int width = cbk_011.Left-cbk_001.Left+cbk_011.Width+ydiff;
                        int height = cbk_011.Top-cbk_001.Top+cbk_011.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("BC'");
                    }
                    
                    /* Middle two bottom */
                    if (Checked2(cbk_101, cbk_111) && !Checked4(cbk_100, cbk_101, cbk_111, cbk_110))
                    {
                        int left = cbk_101.Left-xdiff;
                        int top = cbk_101.Top-xdiff;
                        int width = cbk_111.Left-cbk_101.Left+cbk_111.Width+ydiff;
                        int height = cbk_111.Top-cbk_101.Top+cbk_111.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("BC");
                    }
                }
                
                /* Right box */
                if (Checked4(cbk_011, cbk_010, cbk_111, cbk_110)) 
                {
                    int left = cbk_011.Left-xdiff;
                    int top = cbk_011.Top-xdiff;
                    int width = cbk_110.Left-cbk_011.Left+cbk_110.Width+ydiff;
                    int height = cbk_110.Top-cbk_011.Top+cbk_110.Height+ydiff;
                    DrawEllipse(left, top, width, height, Color.Blue);
                    groups.Add("A");
                } else {
                    xdiff=6; ydiff=11;
                    /* Right two top */
                    if (Checked2(cbk_011, cbk_010) && !Checked4(cbk_000, cbk_001, cbk_011, cbk_010))
                    {
                        int left = cbk_011.Left-xdiff;
                        int top = cbk_011.Top-xdiff;
                        int width = cbk_010.Left-cbk_011.Left+cbk_010.Width+ydiff;
                        int height = cbk_010.Top-cbk_011.Top+cbk_010.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("AC'");
                    } else {
                        xdiff=4; ydiff=7;
                        /* 011 */
                        if(cbk_011.Checked && !Checked2(cbk_001, cbk_011) && !Checked2(cbk_011, cbk_111) && !Checked4(cbk_000, cbk_001, cbk_011, cbk_010))
                        {
                            int left = cbk_011.Left-xdiff;
                            int top = cbk_011.Top-xdiff;
                            int width = cbk_011.Width+ydiff;
                            int height = cbk_011.Height+ydiff;
                            DrawEllipse(left, top, width, height, Color.Firebrick);
                            groups.Add("ABC'");
                        }
                        
                        /* 010 */
                        if(cbk_010.Checked && !Checked2(cbk_010, cbk_110) && !Checked4(cbk_000, cbk_001, cbk_011, cbk_010))
                        {
                            int left = cbk_010.Left-xdiff;
                            int top = cbk_010.Top-xdiff;
                            int width = cbk_010.Width+ydiff;
                            int height = cbk_010.Height+ydiff;
                            DrawEllipse(left, top, width, height, Color.Firebrick);
                            groups.Add("AB'C'");
                        }
                    }
                    
                    /* Right two bottom */
                    if (Checked2(cbk_111, cbk_110) && !Checked4(cbk_100, cbk_101, cbk_111, cbk_110))
                    {
                        int left = cbk_111.Left-xdiff;
                        int top = cbk_111.Top-xdiff;
                        int width = cbk_110.Left-cbk_111.Left+cbk_110.Width+ydiff;
                        int height = cbk_110.Top-cbk_111.Top+cbk_110.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("AC");
                    } else {
                        xdiff=4; ydiff=7;
                        /* 111 */
                        if(cbk_111.Checked && !Checked2(cbk_101, cbk_111) && !Checked2(cbk_011, cbk_111) && !Checked4(cbk_100, cbk_101, cbk_111, cbk_110))
                        {
                            int left = cbk_111.Left-xdiff;
                            int top = cbk_111.Top-xdiff;
                            int width = cbk_111.Width+ydiff;
                            int height = cbk_111.Height+ydiff;
                            DrawEllipse(left, top, width, height, Color.Firebrick);
                            groups.Add("ABC");
                        }
                        
                        /* 110 */
                        if(cbk_110.Checked && !Checked2(cbk_010, cbk_110) && !Checked4(cbk_100, cbk_101, cbk_111, cbk_110))
                        {
                            int left = cbk_110.Left-xdiff;
                            int top = cbk_110.Top-xdiff;
                            int width = cbk_110.Width+ydiff;
                            int height = cbk_110.Height+ydiff;
                            DrawEllipse(left, top, width, height, Color.Firebrick);
                            groups.Add("AB'C");
                        }
                    }
                    
                    /* Third column */
                    if (Checked2(cbk_011, cbk_111) && !Checked4(cbk_001, cbk_011, cbk_101, cbk_111))
                    {
                        int left = cbk_011.Left-xdiff;
                        int top = cbk_011.Top-xdiff;
                        int width = cbk_011.Width+ydiff;
                        int height = cbk_111.Top-cbk_011.Top+cbk_111.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("AB");
                    }
                    
                    /* Last column */
                    if (Checked2(cbk_010, cbk_110) && !Checked4(cbk_000, cbk_100, cbk_010, cbk_110))
                    {
                        int left = cbk_010.Left-xdiff;
                        int top = cbk_010.Top-xdiff;
                        int width = cbk_010.Width+ydiff;
                        int height = cbk_110.Top-cbk_010.Top+cbk_110.Height+ydiff;
                        DrawEllipse(left, top, width, height, Color.Green);
                        groups.Add("AB'");
                    }
                }
                
                /* Full first row */
                if (Checked4(cbk_000, cbk_001, cbk_011, cbk_010)) 
                {
                    int left = cbk_000.Left-xdiff;
                    int top = cbk_000.Top-xdiff;
                    int width = cbk_010.Left-cbk_000.Left+cbk_000.Width+ydiff;
                    int height = cbk_010.Top-cbk_000.Top+cbk_000.Height+ydiff;
                    DrawEllipse(left, top, width, height, Color.Blue);
                    groups.Add("C'");
                }
                
                /* Full second row */
                if (Checked4(cbk_100, cbk_101, cbk_111, cbk_110)) 
                {
                    int left = cbk_100.Left-xdiff;
                    int top = cbk_100.Top-xdiff;
                    int width = cbk_110.Left-cbk_100.Left+cbk_100.Width+ydiff;
                    int height = cbk_110.Top-cbk_100.Top+cbk_100.Height+ydiff;
                    DrawEllipse(left, top, width, height, Color.Blue);
                    groups.Add("C");
                }
                
                /* First and fourth column */
                if (Checked4(cbk_000, cbk_100, cbk_010, cbk_110)) 
                {
                    int left = cbk_000.Left-xdiff;
                    int top = cbk_000.Top-xdiff;
                    int width = cbk_000.Width+ydiff;
                    int height = cbk_100.Top-cbk_000.Top+cbk_100.Height+ydiff;
                    DrawSplitArc(left, top, width, height, -90, 180, Color.Blue);
                    
                    left = cbk_010.Left-xdiff;
                    top = cbk_010.Top-xdiff;
                    width = cbk_010.Width+ydiff;
                    height = cbk_110.Top-cbk_010.Top+cbk_110.Height+ydiff;
                    DrawSplitArc(left, top, width, height, 90, 180, Color.Blue);
                    groups.Add("B'");
                }
            }
            
            if (equation != "1")
            {
                groups.Sort();
                
                foreach (string group in groups)
                    equation = equation + " " + group;
                
                equation = equation.Trim();
                equation = equation.Replace(" ", " + ");
            }
            
            return equation;
        }
        
        void DrawEllipse(int left, int top, int width, int height, Color color)
        {
            Pen pen = new Pen(new SolidBrush(color));
            graphics.DrawEllipse(pen, new Rectangle(left, top, width, height));
            pen.Dispose();
        }
        
        void DrawSplitArc(int left, int top, int width, int height, float start_angle, float sweep_angle, Color color)
        {
            Pen pen = new Pen(new SolidBrush(color));
            graphics.DrawArc(pen, new Rectangle(left, top, width, height), start_angle, sweep_angle);
            pen.Dispose();
        }
        
        bool Checked8()
        {
            if (cbk_000.Checked && cbk_001.Checked && cbk_010.Checked && cbk_011.Checked && cbk_100.Checked && cbk_101.Checked && cbk_110.Checked && cbk_111.Checked) 
                return true;
            else
                return false;
        }
        
        bool Checked4(CheckBox cb1, CheckBox cb2, CheckBox cb3, CheckBox cb4)
        {
            if (cb1.Checked && cb2.Checked && cb3.Checked && cb4.Checked) 
                return true;
            else
                return false;
        }
        
        bool Checked2(CheckBox cb1, CheckBox cb2)
        {
            if (cb1.Checked && cb2.Checked) 
                return true;
            else
                return false;
        }
    }
}
