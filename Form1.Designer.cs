namespace PracticeUni
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Calculate_Practice1 = new System.Windows.Forms.Button();
            this.XnText = new System.Windows.Forms.TextBox();
            this.XkText = new System.Windows.Forms.TextBox();
            this.hText = new System.Windows.Forms.TextBox();
            this.aText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.arrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onearrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoarrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unitTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOLIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate_Practice1
            // 
            this.Calculate_Practice1.Location = new System.Drawing.Point(333, 63);
            this.Calculate_Practice1.Name = "Calculate_Practice1";
            this.Calculate_Practice1.Size = new System.Drawing.Size(91, 31);
            this.Calculate_Practice1.TabIndex = 0;
            this.Calculate_Practice1.Text = "Calculate";
            this.Calculate_Practice1.UseVisualStyleBackColor = true;
            this.Calculate_Practice1.Click += new System.EventHandler(this.Calculate_Practice1_Click);
            // 
            // XnText
            // 
            this.XnText.Location = new System.Drawing.Point(12, 69);
            this.XnText.Name = "XnText";
            this.XnText.Size = new System.Drawing.Size(71, 20);
            this.XnText.TabIndex = 1;
            this.XnText.Text = "-1,7";
            // 
            // XkText
            // 
            this.XkText.Location = new System.Drawing.Point(89, 69);
            this.XkText.Name = "XkText";
            this.XkText.Size = new System.Drawing.Size(71, 20);
            this.XkText.TabIndex = 2;
            this.XkText.Text = "45,3";
            // 
            // hText
            // 
            this.hText.Location = new System.Drawing.Point(166, 69);
            this.hText.Name = "hText";
            this.hText.Size = new System.Drawing.Size(71, 20);
            this.hText.TabIndex = 3;
            this.hText.Text = "1";
            // 
            // aText
            // 
            this.aText.Location = new System.Drawing.Point(243, 69);
            this.aText.Name = "aText";
            this.aText.Size = new System.Drawing.Size(71, 20);
            this.aText.TabIndex = 4;
            this.aText.Text = "0,3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Xk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "a";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 338);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(379, 135);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(466, 338);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticeUni.Properties.Resources.pr;
            this.pictureBox1.Location = new System.Drawing.Point(440, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 56);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // arrayToolStripMenuItem
            // 
            this.arrayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onearrToolStripMenuItem,
            this.twoarrayToolStripMenuItem});
            this.arrayToolStripMenuItem.Name = "arrayToolStripMenuItem";
            this.arrayToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.arrayToolStripMenuItem.Text = "Array";
            // 
            // onearrToolStripMenuItem
            // 
            this.onearrToolStripMenuItem.Name = "onearrToolStripMenuItem";
            this.onearrToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.onearrToolStripMenuItem.Text = "One-array";
            this.onearrToolStripMenuItem.Click += new System.EventHandler(this.onearrToolStripMenuItem_Click);
            // 
            // twoarrayToolStripMenuItem
            // 
            this.twoarrayToolStripMenuItem.Name = "twoarrayToolStripMenuItem";
            this.twoarrayToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.twoarrayToolStripMenuItem.Text = "Two-array";
            this.twoarrayToolStripMenuItem.Click += new System.EventHandler(this.twoarrayToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayToolStripMenuItem,
            this.unitTestToolStripMenuItem,
            this.sOLIDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unitTestToolStripMenuItem
            // 
            this.unitTestToolStripMenuItem.Name = "unitTestToolStripMenuItem";
            this.unitTestToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.unitTestToolStripMenuItem.Text = "Unit Test";
            this.unitTestToolStripMenuItem.Click += new System.EventHandler(this.unitTestToolStripMenuItem_Click);
            // 
            // sOLIDToolStripMenuItem
            // 
            this.sOLIDToolStripMenuItem.Name = "sOLIDToolStripMenuItem";
            this.sOLIDToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.sOLIDToolStripMenuItem.Text = "SOLID";
            this.sOLIDToolStripMenuItem.Click += new System.EventHandler(this.sOLIDToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aText);
            this.Controls.Add(this.hText);
            this.Controls.Add(this.XkText);
            this.Controls.Add(this.XnText);
            this.Controls.Add(this.Calculate_Practice1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate_Practice1;
        private System.Windows.Forms.TextBox XnText;
        private System.Windows.Forms.TextBox XkText;
        private System.Windows.Forms.TextBox hText;
        private System.Windows.Forms.TextBox aText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem arrayToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem onearrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoarrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOLIDToolStripMenuItem;
    }
}

