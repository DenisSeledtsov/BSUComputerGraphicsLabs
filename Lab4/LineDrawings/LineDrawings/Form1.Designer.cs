namespace LineDrawings
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.x1Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.y1Box = new System.Windows.Forms.TextBox();
            this.StepByStep = new System.Windows.Forms.Button();
            this.DDA = new System.Windows.Forms.Button();
            this.Bresenhams = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.y2Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.x2Box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.y0Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.x0Box = new System.Windows.Forms.TextBox();
            this.rBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(22, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "15";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "15";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // x1Box
            // 
            this.x1Box.Location = new System.Drawing.Point(682, 37);
            this.x1Box.MaxLength = 2;
            this.x1Box.Name = "x1Box";
            this.x1Box.Size = new System.Drawing.Size(106, 20);
            this.x1Box.TabIndex = 6;
            this.x1Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "X1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Y1:";
            // 
            // y1Box
            // 
            this.y1Box.Location = new System.Drawing.Point(682, 63);
            this.y1Box.MaxLength = 2;
            this.y1Box.Name = "y1Box";
            this.y1Box.Size = new System.Drawing.Size(106, 20);
            this.y1Box.TabIndex = 8;
            this.y1Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitKeyPress);
            // 
            // StepByStep
            // 
            this.StepByStep.Location = new System.Drawing.Point(645, 159);
            this.StepByStep.Name = "StepByStep";
            this.StepByStep.Size = new System.Drawing.Size(143, 23);
            this.StepByStep.TabIndex = 10;
            this.StepByStep.Text = "Step-by-step algorithm";
            this.StepByStep.UseVisualStyleBackColor = true;
            this.StepByStep.Click += new System.EventHandler(this.StepByStep_Click);
            // 
            // DDA
            // 
            this.DDA.Location = new System.Drawing.Point(645, 188);
            this.DDA.Name = "DDA";
            this.DDA.Size = new System.Drawing.Size(143, 23);
            this.DDA.TabIndex = 11;
            this.DDA.Text = "DDA algorithm";
            this.DDA.UseVisualStyleBackColor = true;
            this.DDA.Click += new System.EventHandler(this.DDA_Click);
            // 
            // Bresenhams
            // 
            this.Bresenhams.Location = new System.Drawing.Point(645, 217);
            this.Bresenhams.Name = "Bresenhams";
            this.Bresenhams.Size = new System.Drawing.Size(143, 23);
            this.Bresenhams.TabIndex = 12;
            this.Bresenhams.Text = "Bresenham\'s algorithm";
            this.Bresenhams.UseVisualStyleBackColor = true;
            this.Bresenhams.Click += new System.EventHandler(this.Bresenhams_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(653, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Y2:";
            // 
            // y2Box
            // 
            this.y2Box.Location = new System.Drawing.Point(682, 127);
            this.y2Box.MaxLength = 2;
            this.y2Box.Name = "y2Box";
            this.y2Box.Size = new System.Drawing.Size(106, 20);
            this.y2Box.TabIndex = 15;
            this.y2Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitKeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "X2:";
            // 
            // x2Box
            // 
            this.x2Box.Location = new System.Drawing.Point(682, 101);
            this.x2Box.MaxLength = 2;
            this.x2Box.Name = "x2Box";
            this.x2Box.Size = new System.Drawing.Size(106, 20);
            this.x2Box.TabIndex = 13;
            this.x2Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitKeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Bresenham\'s circle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Bresenhams_Circle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(653, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Y0:";
            // 
            // y0Box
            // 
            this.y0Box.Location = new System.Drawing.Point(682, 284);
            this.y0Box.MaxLength = 2;
            this.y0Box.Name = "y0Box";
            this.y0Box.Size = new System.Drawing.Size(106, 20);
            this.y0Box.TabIndex = 20;
            this.y0Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitKeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(653, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "X0:";
            // 
            // x0Box
            // 
            this.x0Box.Location = new System.Drawing.Point(682, 258);
            this.x0Box.MaxLength = 2;
            this.x0Box.Name = "x0Box";
            this.x0Box.Size = new System.Drawing.Size(106, 20);
            this.x0Box.TabIndex = 18;
            this.x0Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitKeyPress);
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(682, 314);
            this.rBox.MaxLength = 2;
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(106, 20);
            this.rBox.TabIndex = 22;
            this.rBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitKeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(636, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Radius:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(669, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Algorithms:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(20, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(254, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "Basic raster algorithms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.y0Box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.x0Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.y2Box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.x2Box);
            this.Controls.Add(this.Bresenhams);
            this.Controls.Add(this.DDA);
            this.Controls.Add(this.StepByStep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.y1Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.x1Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Seledtsov Denis / 13 group";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox x1Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox y1Box;
        private System.Windows.Forms.Button StepByStep;
        private System.Windows.Forms.Button DDA;
        private System.Windows.Forms.Button Bresenhams;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox y2Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox x2Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox y0Box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox x0Box;
        private System.Windows.Forms.TextBox rBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

