namespace ImagesReader
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(385, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageName,
            this.ImageSize,
            this.Resolution,
            this.ColorDepth,
            this.Compression});
            this.dataGridView1.Location = new System.Drawing.Point(145, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 359);
            this.dataGridView1.TabIndex = 3;
            // 
            // ImageName
            // 
            this.ImageName.HeaderText = "Name";
            this.ImageName.MaxInputLength = 64;
            this.ImageName.Name = "ImageName";
            this.ImageName.ReadOnly = true;
            this.ImageName.Width = 150;
            // 
            // ImageSize
            // 
            this.ImageSize.HeaderText = "Size";
            this.ImageSize.MaxInputLength = 16;
            this.ImageSize.Name = "ImageSize";
            this.ImageSize.ReadOnly = true;
            // 
            // Resolution
            // 
            this.Resolution.HeaderText = "Resolution";
            this.Resolution.MaxInputLength = 16;
            this.Resolution.Name = "Resolution";
            this.Resolution.ReadOnly = true;
            // 
            // ColorDepth
            // 
            this.ColorDepth.HeaderText = "Color depth";
            this.ColorDepth.MaxInputLength = 32;
            this.ColorDepth.Name = "ColorDepth";
            this.ColorDepth.ReadOnly = true;
            this.ColorDepth.Width = 120;
            // 
            // Compression
            // 
            this.Compression.HeaderText = "Compression";
            this.Compression.MaxInputLength = 16;
            this.Compression.Name = "Compression";
            this.Compression.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compression;
        private System.Windows.Forms.Label label1;
    }
}

