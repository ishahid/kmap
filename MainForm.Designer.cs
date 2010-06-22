
namespace KarnaughMap
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	this.label3 = new System.Windows.Forms.Label();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.cbt_000 = new System.Windows.Forms.CheckBox();
        	this.gbt = new System.Windows.Forms.GroupBox();
        	this.cbt_111 = new System.Windows.Forms.CheckBox();
        	this.cbt_110 = new System.Windows.Forms.CheckBox();
        	this.cbt_101 = new System.Windows.Forms.CheckBox();
        	this.cbt_100 = new System.Windows.Forms.CheckBox();
        	this.cbt_011 = new System.Windows.Forms.CheckBox();
        	this.cbt_010 = new System.Windows.Forms.CheckBox();
        	this.cbt_001 = new System.Windows.Forms.CheckBox();
        	this.gbk = new System.Windows.Forms.GroupBox();
        	this.panel3 = new System.Windows.Forms.Panel();
        	this.cbk_111 = new System.Windows.Forms.CheckBox();
        	this.cbk_110 = new System.Windows.Forms.CheckBox();
        	this.cbk_101 = new System.Windows.Forms.CheckBox();
        	this.cbk_100 = new System.Windows.Forms.CheckBox();
        	this.cbk_011 = new System.Windows.Forms.CheckBox();
        	this.cbk_010 = new System.Windows.Forms.CheckBox();
        	this.cbk_001 = new System.Windows.Forms.CheckBox();
        	this.cbk_000 = new System.Windows.Forms.CheckBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.gbe = new System.Windows.Forms.GroupBox();
        	this.tb_equation = new System.Windows.Forms.TextBox();
        	this.gbt.SuspendLayout();
        	this.gbk.SuspendLayout();
        	this.gbe.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(6, 18);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(34, 13);
        	this.label3.TabIndex = 0;
        	this.label3.Text = "A B C";
        	// 
        	// panel1
        	// 
        	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel1.Location = new System.Drawing.Point(6, 34);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(50, 2);
        	this.panel1.TabIndex = 1;
        	// 
        	// cbt_000
        	// 
        	this.cbt_000.AutoSize = true;
        	this.cbt_000.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbt_000.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbt_000.Location = new System.Drawing.Point(6, 38);
        	this.cbt_000.Name = "cbt_000";
        	this.cbt_000.Size = new System.Drawing.Size(50, 17);
        	this.cbt_000.TabIndex = 2;
        	this.cbt_000.Text = "0 0 0";
        	this.cbt_000.UseVisualStyleBackColor = true;
        	this.cbt_000.CheckedChanged += new System.EventHandler(this.Cbt_000CheckedChanged);
        	// 
        	// gbt
        	// 
        	this.gbt.Controls.Add(this.cbt_111);
        	this.gbt.Controls.Add(this.cbt_110);
        	this.gbt.Controls.Add(this.cbt_101);
        	this.gbt.Controls.Add(this.cbt_100);
        	this.gbt.Controls.Add(this.cbt_011);
        	this.gbt.Controls.Add(this.cbt_010);
        	this.gbt.Controls.Add(this.cbt_001);
        	this.gbt.Controls.Add(this.cbt_000);
        	this.gbt.Controls.Add(this.label3);
        	this.gbt.Controls.Add(this.panel1);
        	this.gbt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gbt.Location = new System.Drawing.Point(12, 12);
        	this.gbt.Name = "gbt";
        	this.gbt.Size = new System.Drawing.Size(85, 162);
        	this.gbt.TabIndex = 3;
        	this.gbt.TabStop = false;
        	this.gbt.Text = "Truth Table";
        	// 
        	// cbt_111
        	// 
        	this.cbt_111.AutoSize = true;
        	this.cbt_111.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbt_111.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbt_111.Location = new System.Drawing.Point(6, 136);
        	this.cbt_111.Name = "cbt_111";
        	this.cbt_111.Size = new System.Drawing.Size(50, 17);
        	this.cbt_111.TabIndex = 2;
        	this.cbt_111.Text = "1 1 1";
        	this.cbt_111.UseVisualStyleBackColor = true;
        	this.cbt_111.CheckedChanged += new System.EventHandler(this.Cbt_111CheckedChanged);
        	// 
        	// cbt_110
        	// 
        	this.cbt_110.AutoSize = true;
        	this.cbt_110.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbt_110.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbt_110.Location = new System.Drawing.Point(6, 122);
        	this.cbt_110.Name = "cbt_110";
        	this.cbt_110.Size = new System.Drawing.Size(50, 17);
        	this.cbt_110.TabIndex = 2;
        	this.cbt_110.Text = "1 1 0";
        	this.cbt_110.UseVisualStyleBackColor = true;
        	this.cbt_110.CheckedChanged += new System.EventHandler(this.Cbt_110CheckedChanged);
        	// 
        	// cbt_101
        	// 
        	this.cbt_101.AutoSize = true;
        	this.cbt_101.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbt_101.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbt_101.Location = new System.Drawing.Point(6, 108);
        	this.cbt_101.Name = "cbt_101";
        	this.cbt_101.Size = new System.Drawing.Size(50, 17);
        	this.cbt_101.TabIndex = 2;
        	this.cbt_101.Text = "1 0 1";
        	this.cbt_101.UseVisualStyleBackColor = true;
        	this.cbt_101.CheckedChanged += new System.EventHandler(this.Cbt_101CheckedChanged);
        	// 
        	// cbt_100
        	// 
        	this.cbt_100.AutoSize = true;
        	this.cbt_100.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbt_100.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbt_100.Location = new System.Drawing.Point(6, 94);
        	this.cbt_100.Name = "cbt_100";
        	this.cbt_100.Size = new System.Drawing.Size(50, 17);
        	this.cbt_100.TabIndex = 2;
        	this.cbt_100.Text = "1 0 0";
        	this.cbt_100.UseVisualStyleBackColor = true;
        	this.cbt_100.CheckedChanged += new System.EventHandler(this.Cbt_100CheckedChanged);
        	// 
        	// cbt_011
        	// 
        	this.cbt_011.AutoSize = true;
        	this.cbt_011.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbt_011.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbt_011.Location = new System.Drawing.Point(6, 80);
        	this.cbt_011.Name = "cbt_011";
        	this.cbt_011.Size = new System.Drawing.Size(50, 17);
        	this.cbt_011.TabIndex = 2;
        	this.cbt_011.Text = "0 1 1";
        	this.cbt_011.UseVisualStyleBackColor = true;
        	this.cbt_011.CheckedChanged += new System.EventHandler(this.Cbt_011CheckedChanged);
        	// 
        	// cbt_010
        	// 
        	this.cbt_010.AutoSize = true;
        	this.cbt_010.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbt_010.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbt_010.Location = new System.Drawing.Point(6, 66);
        	this.cbt_010.Name = "cbt_010";
        	this.cbt_010.Size = new System.Drawing.Size(50, 17);
        	this.cbt_010.TabIndex = 2;
        	this.cbt_010.Text = "0 1 0";
        	this.cbt_010.UseVisualStyleBackColor = true;
        	this.cbt_010.CheckedChanged += new System.EventHandler(this.Cbt_010CheckedChanged);
        	// 
        	// cbt_001
        	// 
        	this.cbt_001.AutoSize = true;
        	this.cbt_001.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbt_001.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbt_001.Location = new System.Drawing.Point(6, 52);
        	this.cbt_001.Name = "cbt_001";
        	this.cbt_001.Size = new System.Drawing.Size(50, 17);
        	this.cbt_001.TabIndex = 2;
        	this.cbt_001.Text = "0 0 1";
        	this.cbt_001.UseVisualStyleBackColor = true;
        	this.cbt_001.CheckedChanged += new System.EventHandler(this.Cbt_001CheckedChanged);
        	// 
        	// gbk
        	// 
        	this.gbk.Controls.Add(this.panel3);
        	this.gbk.Controls.Add(this.cbk_111);
        	this.gbk.Controls.Add(this.cbk_110);
        	this.gbk.Controls.Add(this.cbk_101);
        	this.gbk.Controls.Add(this.cbk_100);
        	this.gbk.Controls.Add(this.cbk_011);
        	this.gbk.Controls.Add(this.cbk_010);
        	this.gbk.Controls.Add(this.cbk_001);
        	this.gbk.Controls.Add(this.cbk_000);
        	this.gbk.Controls.Add(this.label6);
        	this.gbk.Controls.Add(this.label5);
        	this.gbk.Controls.Add(this.label4);
        	this.gbk.Controls.Add(this.label2);
        	this.gbk.Controls.Add(this.label1);
        	this.gbk.Controls.Add(this.panel2);
        	this.gbk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gbk.Location = new System.Drawing.Point(103, 12);
        	this.gbk.Name = "gbk";
        	this.gbk.Size = new System.Drawing.Size(177, 162);
        	this.gbk.TabIndex = 4;
        	this.gbk.TabStop = false;
        	this.gbk.Text = "Karnaugh Map";
        	// 
        	// panel3
        	// 
        	this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel3.Location = new System.Drawing.Point(26, 38);
        	this.panel3.Name = "panel3";
        	this.panel3.Size = new System.Drawing.Size(1, 66);
        	this.panel3.TabIndex = 1;
        	// 
        	// cbk_111
        	// 
        	this.cbk_111.AutoSize = true;
        	this.cbk_111.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbk_111.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbk_111.Location = new System.Drawing.Point(93, 79);
        	this.cbk_111.Name = "cbk_111";
        	this.cbk_111.Size = new System.Drawing.Size(15, 14);
        	this.cbk_111.TabIndex = 18;
        	this.cbk_111.UseVisualStyleBackColor = true;
        	this.cbk_111.CheckedChanged += new System.EventHandler(this.Cbk_111CheckedChanged);
        	// 
        	// cbk_110
        	// 
        	this.cbk_110.AutoSize = true;
        	this.cbk_110.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbk_110.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbk_110.Location = new System.Drawing.Point(118, 79);
        	this.cbk_110.Name = "cbk_110";
        	this.cbk_110.Size = new System.Drawing.Size(15, 14);
        	this.cbk_110.TabIndex = 17;
        	this.cbk_110.UseVisualStyleBackColor = true;
        	this.cbk_110.CheckedChanged += new System.EventHandler(this.Cbk_110CheckedChanged);
        	// 
        	// cbk_101
        	// 
        	this.cbk_101.AutoSize = true;
        	this.cbk_101.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbk_101.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbk_101.Location = new System.Drawing.Point(68, 79);
        	this.cbk_101.Name = "cbk_101";
        	this.cbk_101.Size = new System.Drawing.Size(15, 14);
        	this.cbk_101.TabIndex = 16;
        	this.cbk_101.UseVisualStyleBackColor = true;
        	this.cbk_101.CheckedChanged += new System.EventHandler(this.Cbk_101CheckedChanged);
        	// 
        	// cbk_100
        	// 
        	this.cbk_100.AutoSize = true;
        	this.cbk_100.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbk_100.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbk_100.Location = new System.Drawing.Point(43, 79);
        	this.cbk_100.Name = "cbk_100";
        	this.cbk_100.Size = new System.Drawing.Size(15, 14);
        	this.cbk_100.TabIndex = 15;
        	this.cbk_100.UseVisualStyleBackColor = true;
        	this.cbk_100.CheckedChanged += new System.EventHandler(this.Cbk_100CheckedChanged);
        	// 
        	// cbk_011
        	// 
        	this.cbk_011.AutoSize = true;
        	this.cbk_011.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbk_011.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbk_011.Location = new System.Drawing.Point(93, 52);
        	this.cbk_011.Name = "cbk_011";
        	this.cbk_011.Size = new System.Drawing.Size(15, 14);
        	this.cbk_011.TabIndex = 14;
        	this.cbk_011.UseVisualStyleBackColor = true;
        	this.cbk_011.CheckedChanged += new System.EventHandler(this.Cbk_011CheckedChanged);
        	// 
        	// cbk_010
        	// 
        	this.cbk_010.AutoSize = true;
        	this.cbk_010.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbk_010.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbk_010.Location = new System.Drawing.Point(118, 52);
        	this.cbk_010.Name = "cbk_010";
        	this.cbk_010.Size = new System.Drawing.Size(15, 14);
        	this.cbk_010.TabIndex = 13;
        	this.cbk_010.UseVisualStyleBackColor = true;
        	this.cbk_010.CheckedChanged += new System.EventHandler(this.Cbk_010CheckedChanged);
        	// 
        	// cbk_001
        	// 
        	this.cbk_001.AutoSize = true;
        	this.cbk_001.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbk_001.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbk_001.Location = new System.Drawing.Point(68, 52);
        	this.cbk_001.Name = "cbk_001";
        	this.cbk_001.Size = new System.Drawing.Size(15, 14);
        	this.cbk_001.TabIndex = 12;
        	this.cbk_001.UseVisualStyleBackColor = true;
        	this.cbk_001.CheckedChanged += new System.EventHandler(this.Cbk_001CheckedChanged);
        	// 
        	// cbk_000
        	// 
        	this.cbk_000.AutoSize = true;
        	this.cbk_000.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
        	this.cbk_000.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.cbk_000.Location = new System.Drawing.Point(43, 52);
        	this.cbk_000.Name = "cbk_000";
        	this.cbk_000.Size = new System.Drawing.Size(15, 14);
        	this.cbk_000.TabIndex = 11;
        	this.cbk_000.UseVisualStyleBackColor = true;
        	this.cbk_000.CheckedChanged += new System.EventHandler(this.Cbk_000CheckedChanged);
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.Location = new System.Drawing.Point(7, 80);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(13, 13);
        	this.label6.TabIndex = 7;
        	this.label6.Text = "1";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.Location = new System.Drawing.Point(7, 53);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(13, 13);
        	this.label5.TabIndex = 6;
        	this.label5.Text = "0";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(43, 18);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(91, 13);
        	this.label4.TabIndex = 4;
        	this.label4.Text = "00    01    11    10";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(16, 18);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(21, 13);
        	this.label2.TabIndex = 3;
        	this.label2.Text = "AB";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(6, 31);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(14, 13);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "C";
        	// 
        	// panel2
        	// 
        	this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.panel2.Location = new System.Drawing.Point(26, 38);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(117, 1);
        	this.panel2.TabIndex = 0;
        	// 
        	// gbe
        	// 
        	this.gbe.Controls.Add(this.tb_equation);
        	this.gbe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.gbe.Location = new System.Drawing.Point(12, 180);
        	this.gbe.Name = "gbe";
        	this.gbe.Size = new System.Drawing.Size(268, 47);
        	this.gbe.TabIndex = 5;
        	this.gbe.TabStop = false;
        	this.gbe.Text = "Equation Output";
        	// 
        	// tb_equation
        	// 
        	this.tb_equation.BorderStyle = System.Windows.Forms.BorderStyle.None;
        	this.tb_equation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.tb_equation.Location = new System.Drawing.Point(6, 19);
        	this.tb_equation.Name = "tb_equation";
        	this.tb_equation.ReadOnly = true;
        	this.tb_equation.Size = new System.Drawing.Size(256, 15);
        	this.tb_equation.TabIndex = 0;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(292, 240);
        	this.Controls.Add(this.gbe);
        	this.Controls.Add(this.gbk);
        	this.Controls.Add(this.gbt);
        	this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        	this.MaximizeBox = false;
        	this.Name = "MainForm";
        	this.Text = "KarnaughMap";
        	this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
        	this.gbt.ResumeLayout(false);
        	this.gbt.PerformLayout();
        	this.gbk.ResumeLayout(false);
        	this.gbk.PerformLayout();
        	this.gbe.ResumeLayout(false);
        	this.gbe.PerformLayout();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.GroupBox gbt;
        private System.Windows.Forms.GroupBox gbk;
        private System.Windows.Forms.GroupBox gbe;
        private System.Windows.Forms.TextBox tb_equation;
        private System.Windows.Forms.CheckBox cbk_000;
        private System.Windows.Forms.CheckBox cbk_001;
        private System.Windows.Forms.CheckBox cbk_010;
        private System.Windows.Forms.CheckBox cbk_011;
        private System.Windows.Forms.CheckBox cbk_100;
        private System.Windows.Forms.CheckBox cbk_101;
        private System.Windows.Forms.CheckBox cbk_110;
        private System.Windows.Forms.CheckBox cbk_111;
        private System.Windows.Forms.CheckBox cbt_110;
        private System.Windows.Forms.CheckBox cbt_111;
        private System.Windows.Forms.CheckBox cbt_011;
        private System.Windows.Forms.CheckBox cbt_100;
        private System.Windows.Forms.CheckBox cbt_101;
        private System.Windows.Forms.CheckBox cbt_001;
        private System.Windows.Forms.CheckBox cbt_010;
        private System.Windows.Forms.CheckBox cbt_000;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}
