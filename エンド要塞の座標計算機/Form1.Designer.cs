namespace エンド要塞の座標計算機
{
    partial class エンド要塞特定
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
            this.x10 = new System.Windows.Forms.TextBox();
            this.z10 = new System.Windows.Forms.TextBox();
            this.x11 = new System.Windows.Forms.TextBox();
            this.z11 = new System.Windows.Forms.TextBox();
            this.x20 = new System.Windows.Forms.TextBox();
            this.z20 = new System.Windows.Forms.TextBox();
            this.x21 = new System.Windows.Forms.TextBox();
            this.z21 = new System.Windows.Forms.TextBox();
            this.要塞の座標 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x10
            // 
            this.x10.Location = new System.Drawing.Point(69, 13);
            this.x10.Name = "x10";
            this.x10.Size = new System.Drawing.Size(125, 27);
            this.x10.TabIndex = 0;
            this.x10.TextChanged += new System.EventHandler(this.再計算);
            // 
            // z10
            // 
            this.z10.Location = new System.Drawing.Point(265, 13);
            this.z10.Name = "z10";
            this.z10.Size = new System.Drawing.Size(125, 27);
            this.z10.TabIndex = 1;
            this.z10.TextChanged += new System.EventHandler(this.再計算);
            // 
            // x11
            // 
            this.x11.Location = new System.Drawing.Point(69, 46);
            this.x11.Name = "x11";
            this.x11.Size = new System.Drawing.Size(125, 27);
            this.x11.TabIndex = 2;
            this.x11.TextChanged += new System.EventHandler(this.再計算);
            // 
            // z11
            // 
            this.z11.Location = new System.Drawing.Point(265, 46);
            this.z11.Name = "z11";
            this.z11.Size = new System.Drawing.Size(125, 27);
            this.z11.TabIndex = 3;
            this.z11.TextChanged += new System.EventHandler(this.再計算);
            // 
            // x20
            // 
            this.x20.Location = new System.Drawing.Point(69, 103);
            this.x20.Name = "x20";
            this.x20.Size = new System.Drawing.Size(125, 27);
            this.x20.TabIndex = 4;
            this.x20.TextChanged += new System.EventHandler(this.再計算);
            // 
            // z20
            // 
            this.z20.Location = new System.Drawing.Point(265, 103);
            this.z20.Name = "z20";
            this.z20.Size = new System.Drawing.Size(125, 27);
            this.z20.TabIndex = 5;
            this.z20.TextChanged += new System.EventHandler(this.再計算);
            // 
            // x21
            // 
            this.x21.Location = new System.Drawing.Point(69, 136);
            this.x21.Name = "x21";
            this.x21.Size = new System.Drawing.Size(125, 27);
            this.x21.TabIndex = 6;
            this.x21.TextChanged += new System.EventHandler(this.再計算);
            // 
            // z21
            // 
            this.z21.Location = new System.Drawing.Point(265, 136);
            this.z21.Name = "z21";
            this.z21.Size = new System.Drawing.Size(125, 27);
            this.z21.TabIndex = 7;
            this.z21.TextChanged += new System.EventHandler(this.再計算);
            // 
            // 要塞の座標
            // 
            this.要塞の座標.AutoSize = true;
            this.要塞の座標.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.要塞の座標.Location = new System.Drawing.Point(13, 193);
            this.要塞の座標.Name = "要塞の座標";
            this.要塞の座標.Size = new System.Drawing.Size(0, 31);
            this.要塞の座標.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "x座標1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "z座標1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "x座標2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "z座標2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "x座標1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(209, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "z座標1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "x座標2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "z座標2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(396, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 28);
            this.label9.TabIndex = 17;
            this.label9.Text = "愛一回目";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(396, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "愛二回目";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "コピー";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // エンド要塞特定
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.要塞の座標);
            this.Controls.Add(this.z21);
            this.Controls.Add(this.x21);
            this.Controls.Add(this.z20);
            this.Controls.Add(this.x20);
            this.Controls.Add(this.z11);
            this.Controls.Add(this.x11);
            this.Controls.Add(this.z10);
            this.Controls.Add(this.x10);
            this.Name = "エンド要塞特定";
            this.Text = "エンド要塞の座標計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x10;
        private System.Windows.Forms.TextBox z10;
        private System.Windows.Forms.TextBox x11;
        private System.Windows.Forms.TextBox z11;
        private System.Windows.Forms.TextBox x20;
        private System.Windows.Forms.TextBox z20;
        private System.Windows.Forms.TextBox x21;
        private System.Windows.Forms.TextBox z21;
        private System.Windows.Forms.Label 要塞の座標;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}