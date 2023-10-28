namespace PracticeUni
{
    partial class OneArr
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
            this.sur1 = new System.Windows.Forms.TextBox();
            this.sur2 = new System.Windows.Forms.TextBox();
            this.sur3 = new System.Windows.Forms.TextBox();
            this.sur4 = new System.Windows.Forms.TextBox();
            this.sur5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.revers_surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sur1
            // 
            this.sur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sur1.Location = new System.Drawing.Point(342, 67);
            this.sur1.Name = "sur1";
            this.sur1.Size = new System.Drawing.Size(160, 35);
            this.sur1.TabIndex = 0;
            // 
            // sur2
            // 
            this.sur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sur2.Location = new System.Drawing.Point(342, 108);
            this.sur2.Name = "sur2";
            this.sur2.Size = new System.Drawing.Size(160, 35);
            this.sur2.TabIndex = 0;
            // 
            // sur3
            // 
            this.sur3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sur3.Location = new System.Drawing.Point(342, 149);
            this.sur3.Name = "sur3";
            this.sur3.Size = new System.Drawing.Size(160, 35);
            this.sur3.TabIndex = 0;
            // 
            // sur4
            // 
            this.sur4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sur4.Location = new System.Drawing.Point(342, 190);
            this.sur4.Name = "sur4";
            this.sur4.Size = new System.Drawing.Size(160, 35);
            this.sur4.TabIndex = 0;
            // 
            // sur5
            // 
            this.sur5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sur5.Location = new System.Drawing.Point(342, 231);
            this.sur5.Name = "sur5";
            this.sur5.Size = new System.Drawing.Size(160, 35);
            this.sur5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(325, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Surname";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.revers_surname});
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 180);
            this.dataGridView1.TabIndex = 2;
            // 
            // revers_surname
            // 
            this.revers_surname.HeaderText = "Revers surname";
            this.revers_surname.Name = "revers_surname";
            this.revers_surname.Width = 250;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(342, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reverse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OneArr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sur5);
            this.Controls.Add(this.sur4);
            this.Controls.Add(this.sur3);
            this.Controls.Add(this.sur2);
            this.Controls.Add(this.sur1);
            this.Name = "OneArr";
            this.Text = "OneArr";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sur1;
        private System.Windows.Forms.TextBox sur2;
        private System.Windows.Forms.TextBox sur3;
        private System.Windows.Forms.TextBox sur4;
        private System.Windows.Forms.TextBox sur5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn revers_surname;
        private System.Windows.Forms.Button button1;
    }
}