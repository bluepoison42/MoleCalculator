namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Numin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Numin2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Numin3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Numin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numin3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(433, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mole Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.listBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 39;
            this.listBox1.Items.AddRange(new object[] {
            "Moles",
            "Particle numbers",
            "Volume of Gas",
            "Mass"});
            this.listBox1.Location = new System.Drawing.Point(184, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 160);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 77);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(598, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 77);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Numin
            // 
            this.Numin.BackColor = System.Drawing.Color.White;
            this.Numin.DecimalPlaces = 3;
            this.Numin.Font = new System.Drawing.Font("Agency FB", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Numin.Location = new System.Drawing.Point(529, 221);
            this.Numin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Numin.Name = "Numin";
            this.Numin.Size = new System.Drawing.Size(368, 74);
            this.Numin.TabIndex = 6;
            this.Numin.ValueChanged += new System.EventHandler(this.Numin_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(2, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 77);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.White;
            this.listBox2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold);
            this.listBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 39;
            this.listBox2.Items.AddRange(new object[] {
            "Moles",
            "Particle numbers",
            "Volume of Gas",
            "Mass"});
            this.listBox2.Location = new System.Drawing.Point(184, 398);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(289, 160);
            this.listBox2.TabIndex = 8;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(574, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 77);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Agency FB", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(184, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 84);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.BackColor = System.Drawing.Color.Transparent;
            this.Output.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Output.Location = new System.Drawing.Point(583, 582);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(155, 77);
            this.Output.TabIndex = 11;
            this.Output.Text = "Result";
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(946, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 116);
            this.label7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(782, 603);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 40);
            this.label8.TabIndex = 13;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Numin2
            // 
            this.Numin2.BackColor = System.Drawing.Color.White;
            this.Numin2.DecimalPlaces = 2;
            this.Numin2.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numin2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Numin2.Location = new System.Drawing.Point(611, 307);
            this.Numin2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Numin2.Name = "Numin2";
            this.Numin2.Size = new System.Drawing.Size(109, 64);
            this.Numin2.TabIndex = 14;
            this.Numin2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(519, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 58);
            this.label9.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 151);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(426, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(388, 59);
            this.label10.TabIndex = 17;
            this.label10.Text = "Coded by Vincent#1337";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 40;
            this.listBox3.Items.AddRange(new object[] {
            "Light",
            "Dark",
            "Green"});
            this.listBox3.Location = new System.Drawing.Point(287, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 124);
            this.listBox3.TabIndex = 19;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label11.Location = new System.Drawing.Point(157, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 58);
            this.label11.TabIndex = 20;
            this.label11.Text = "Theme";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(759, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 58);
            this.label6.TabIndex = 21;
            this.label6.Text = "MM";
            this.label6.Visible = false;
            // 
            // Numin3
            // 
            this.Numin3.BackColor = System.Drawing.Color.White;
            this.Numin3.DecimalPlaces = 2;
            this.Numin3.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numin3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Numin3.Location = new System.Drawing.Point(850, 309);
            this.Numin3.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Numin3.Name = "Numin3";
            this.Numin3.Size = new System.Drawing.Size(109, 64);
            this.Numin3.TabIndex = 22;
            this.Numin3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(972, 738);
            this.Controls.Add(this.Numin3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Numin2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Numin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numin3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Numin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Numin2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Numin3;
    }
}

