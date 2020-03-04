namespace ColorPicker
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bSlider = new System.Windows.Forms.TrackBar();
            this.gSlider = new System.Windows.Forms.TrackBar();
            this.rSlider = new System.Windows.Forms.TrackBar();
            this.bLabel = new System.Windows.Forms.Label();
            this.gLable = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.bValue = new System.Windows.Forms.TextBox();
            this.gValue = new System.Windows.Forms.TextBox();
            this.rValue = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kSlider = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.kValue = new System.Windows.Forms.TextBox();
            this.ySlider = new System.Windows.Forms.TrackBar();
            this.mSlider = new System.Windows.Forms.TrackBar();
            this.cSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yValue = new System.Windows.Forms.TextBox();
            this.mValue = new System.Windows.Forms.TextBox();
            this.cValue = new System.Windows.Forms.TextBox();
            this.colorPickerClass1 = new ColorPicker.ColorPickerClass();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bSlider2 = new System.Windows.Forms.TrackBar();
            this.aSlider = new System.Windows.Forms.TrackBar();
            this.LSlider = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bValue2 = new System.Windows.Forms.TextBox();
            this.aValue = new System.Windows.Forms.TextBox();
            this.lValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSlider)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSlider)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(802, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 189);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bSlider);
            this.panel2.Controls.Add(this.gSlider);
            this.panel2.Controls.Add(this.rSlider);
            this.panel2.Controls.Add(this.bLabel);
            this.panel2.Controls.Add(this.gLable);
            this.panel2.Controls.Add(this.rLabel);
            this.panel2.Controls.Add(this.bValue);
            this.panel2.Controls.Add(this.gValue);
            this.panel2.Controls.Add(this.rValue);
            this.panel2.Location = new System.Drawing.Point(12, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 162);
            this.panel2.TabIndex = 2;
            // 
            // bSlider
            // 
            this.bSlider.Location = new System.Drawing.Point(125, 103);
            this.bSlider.Maximum = 255;
            this.bSlider.Name = "bSlider";
            this.bSlider.Size = new System.Drawing.Size(288, 45);
            this.bSlider.TabIndex = 7;
            this.bSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bSlider.Value = 255;
            this.bSlider.Scroll += new System.EventHandler(this.BSlider_Scroll);
            // 
            // gSlider
            // 
            this.gSlider.Location = new System.Drawing.Point(125, 54);
            this.gSlider.Maximum = 255;
            this.gSlider.Name = "gSlider";
            this.gSlider.Size = new System.Drawing.Size(288, 45);
            this.gSlider.TabIndex = 6;
            this.gSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gSlider.Value = 255;
            this.gSlider.Scroll += new System.EventHandler(this.GSlider_Scroll);
            // 
            // rSlider
            // 
            this.rSlider.Location = new System.Drawing.Point(125, 3);
            this.rSlider.Maximum = 255;
            this.rSlider.Name = "rSlider";
            this.rSlider.Size = new System.Drawing.Size(288, 45);
            this.rSlider.TabIndex = 3;
            this.rSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rSlider.Value = 255;
            this.rSlider.Scroll += new System.EventHandler(this.RSlider_Scroll);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(42, 106);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(17, 13);
            this.bLabel.TabIndex = 5;
            this.bLabel.Text = "B:";
            this.bLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gLable
            // 
            this.gLable.AutoSize = true;
            this.gLable.Location = new System.Drawing.Point(41, 57);
            this.gLable.Name = "gLable";
            this.gLable.Size = new System.Drawing.Size(18, 13);
            this.gLable.TabIndex = 4;
            this.gLable.Text = "G:";
            this.gLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(40, 6);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(18, 13);
            this.rLabel.TabIndex = 3;
            this.rLabel.Text = "R:";
            this.rLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bValue
            // 
            this.bValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bValue.Location = new System.Drawing.Point(64, 103);
            this.bValue.MaxLength = 3;
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(55, 20);
            this.bValue.TabIndex = 2;
            this.bValue.Text = "255";
            this.bValue.WordWrap = false;
            this.bValue.TextChanged += new System.EventHandler(this.RValue_TextChanged);
            this.bValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RValue_KeyPress);
            this.bValue.Leave += new System.EventHandler(this.RValue_Leave);
            // 
            // gValue
            // 
            this.gValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gValue.Location = new System.Drawing.Point(64, 54);
            this.gValue.MaxLength = 3;
            this.gValue.Name = "gValue";
            this.gValue.Size = new System.Drawing.Size(55, 20);
            this.gValue.TabIndex = 1;
            this.gValue.Text = "255";
            this.gValue.WordWrap = false;
            this.gValue.TextChanged += new System.EventHandler(this.RValue_TextChanged);
            this.gValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RValue_KeyPress);
            this.gValue.Leave += new System.EventHandler(this.RValue_Leave);
            // 
            // rValue
            // 
            this.rValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rValue.Location = new System.Drawing.Point(64, 3);
            this.rValue.MaxLength = 3;
            this.rValue.Name = "rValue";
            this.rValue.Size = new System.Drawing.Size(55, 20);
            this.rValue.TabIndex = 0;
            this.rValue.Text = "255";
            this.rValue.WordWrap = false;
            this.rValue.TextChanged += new System.EventHandler(this.RValue_TextChanged);
            this.rValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RValue_KeyPress);
            this.rValue.Leave += new System.EventHandler(this.RValue_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.kSlider);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.kValue);
            this.panel3.Controls.Add(this.ySlider);
            this.panel3.Controls.Add(this.mSlider);
            this.panel3.Controls.Add(this.cSlider);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.yValue);
            this.panel3.Controls.Add(this.mValue);
            this.panel3.Controls.Add(this.cValue);
            this.panel3.Location = new System.Drawing.Point(541, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 212);
            this.panel3.TabIndex = 8;
            // 
            // kSlider
            // 
            this.kSlider.Location = new System.Drawing.Point(125, 150);
            this.kSlider.Maximum = 100;
            this.kSlider.Name = "kSlider";
            this.kSlider.Size = new System.Drawing.Size(288, 45);
            this.kSlider.TabIndex = 10;
            this.kSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.kSlider.Scroll += new System.EventHandler(this.KSlide_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "K:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // kValue
            // 
            this.kValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kValue.Location = new System.Drawing.Point(64, 150);
            this.kValue.MaxLength = 3;
            this.kValue.Name = "kValue";
            this.kValue.Size = new System.Drawing.Size(55, 20);
            this.kValue.TabIndex = 8;
            this.kValue.Text = "0";
            this.kValue.WordWrap = false;
            this.kValue.TextChanged += new System.EventHandler(this.CValue_TextChanged);
            this.kValue.Enter += new System.EventHandler(this.CValue_Enter);
            this.kValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KValue_KeyPress);
            this.kValue.Leave += new System.EventHandler(this.KValue_Leave);
            // 
            // ySlider
            // 
            this.ySlider.Location = new System.Drawing.Point(125, 103);
            this.ySlider.Maximum = 100;
            this.ySlider.Name = "ySlider";
            this.ySlider.Size = new System.Drawing.Size(288, 45);
            this.ySlider.TabIndex = 7;
            this.ySlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ySlider.Scroll += new System.EventHandler(this.YSlide_Scroll);
            // 
            // mSlider
            // 
            this.mSlider.Location = new System.Drawing.Point(125, 54);
            this.mSlider.Maximum = 100;
            this.mSlider.Name = "mSlider";
            this.mSlider.Size = new System.Drawing.Size(288, 45);
            this.mSlider.TabIndex = 6;
            this.mSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mSlider.Scroll += new System.EventHandler(this.MSlide_Scroll);
            // 
            // cSlider
            // 
            this.cSlider.Location = new System.Drawing.Point(125, 3);
            this.cSlider.Maximum = 100;
            this.cSlider.Name = "cSlider";
            this.cSlider.Size = new System.Drawing.Size(288, 45);
            this.cSlider.TabIndex = 3;
            this.cSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cSlider.Scroll += new System.EventHandler(this.CSlide_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Y:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "M:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "C:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // yValue
            // 
            this.yValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.yValue.Location = new System.Drawing.Point(64, 103);
            this.yValue.MaxLength = 3;
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(55, 20);
            this.yValue.TabIndex = 2;
            this.yValue.Text = "0";
            this.yValue.WordWrap = false;
            this.yValue.TextChanged += new System.EventHandler(this.CValue_TextChanged);
            this.yValue.Enter += new System.EventHandler(this.CValue_Enter);
            this.yValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KValue_KeyPress);
            this.yValue.Leave += new System.EventHandler(this.KValue_Leave);
            // 
            // mValue
            // 
            this.mValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mValue.Location = new System.Drawing.Point(64, 54);
            this.mValue.MaxLength = 3;
            this.mValue.Name = "mValue";
            this.mValue.Size = new System.Drawing.Size(55, 20);
            this.mValue.TabIndex = 1;
            this.mValue.Text = "0";
            this.mValue.WordWrap = false;
            this.mValue.TextChanged += new System.EventHandler(this.CValue_TextChanged);
            this.mValue.Enter += new System.EventHandler(this.CValue_Enter);
            this.mValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KValue_KeyPress);
            this.mValue.Leave += new System.EventHandler(this.KValue_Leave);
            // 
            // cValue
            // 
            this.cValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cValue.Location = new System.Drawing.Point(64, 3);
            this.cValue.MaxLength = 3;
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(55, 20);
            this.cValue.TabIndex = 0;
            this.cValue.Text = "0";
            this.cValue.WordWrap = false;
            this.cValue.TextChanged += new System.EventHandler(this.CValue_TextChanged);
            this.cValue.Enter += new System.EventHandler(this.CValue_Enter);
            this.cValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KValue_KeyPress);
            this.cValue.Leave += new System.EventHandler(this.KValue_Leave);
            // 
            // colorPickerClass1
            // 
            this.colorPickerClass1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPickerClass1.Location = new System.Drawing.Point(115, 12);
            this.colorPickerClass1.Name = "colorPickerClass1";
            this.colorPickerClass1.Size = new System.Drawing.Size(545, 236);
            this.colorPickerClass1.TabIndex = 0;
            this.colorPickerClass1.ColorPicked += new System.EventHandler(this.ColorPickerClass1_ColorPicked);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bSlider2);
            this.panel4.Controls.Add(this.aSlider);
            this.panel4.Controls.Add(this.LSlider);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.bValue2);
            this.panel4.Controls.Add(this.aValue);
            this.panel4.Controls.Add(this.lValue);
            this.panel4.Location = new System.Drawing.Point(12, 457);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 162);
            this.panel4.TabIndex = 8;
            // 
            // bSlider2
            // 
            this.bSlider2.Location = new System.Drawing.Point(125, 103);
            this.bSlider2.Maximum = 128;
            this.bSlider2.Minimum = -128;
            this.bSlider2.Name = "bSlider2";
            this.bSlider2.Size = new System.Drawing.Size(288, 45);
            this.bSlider2.TabIndex = 7;
            this.bSlider2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bSlider2.Scroll += new System.EventHandler(this.BSlider2_Scroll);
            // 
            // aSlider
            // 
            this.aSlider.Location = new System.Drawing.Point(125, 54);
            this.aSlider.Maximum = 128;
            this.aSlider.Minimum = -128;
            this.aSlider.Name = "aSlider";
            this.aSlider.Size = new System.Drawing.Size(288, 45);
            this.aSlider.TabIndex = 6;
            this.aSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.aSlider.Scroll += new System.EventHandler(this.ASlider_Scroll);
            // 
            // LSlider
            // 
            this.LSlider.Location = new System.Drawing.Point(125, 3);
            this.LSlider.Maximum = 100;
            this.LSlider.Name = "LSlider";
            this.LSlider.Size = new System.Drawing.Size(288, 45);
            this.LSlider.TabIndex = 3;
            this.LSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LSlider.Value = 100;
            this.LSlider.Scroll += new System.EventHandler(this.LSlieder_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "b:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "a:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "L:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bValue2
            // 
            this.bValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bValue2.Location = new System.Drawing.Point(64, 103);
            this.bValue2.MaxLength = 4;
            this.bValue2.Name = "bValue2";
            this.bValue2.Size = new System.Drawing.Size(55, 20);
            this.bValue2.TabIndex = 2;
            this.bValue2.Text = "0";
            this.bValue2.WordWrap = false;
            this.bValue2.TextChanged += new System.EventHandler(this.AValue_TextChanged);
            this.bValue2.Enter += new System.EventHandler(this.LValue_Enter);
            this.bValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AValue_KeyPress);
            this.bValue2.Leave += new System.EventHandler(this.LValue_Leave);
            // 
            // aValue
            // 
            this.aValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.aValue.Location = new System.Drawing.Point(64, 54);
            this.aValue.MaxLength = 4;
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(55, 20);
            this.aValue.TabIndex = 1;
            this.aValue.Text = "0";
            this.aValue.WordWrap = false;
            this.aValue.TextChanged += new System.EventHandler(this.AValue_TextChanged);
            this.aValue.Enter += new System.EventHandler(this.LValue_Enter);
            this.aValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AValue_KeyPress);
            this.aValue.Leave += new System.EventHandler(this.LValue_Leave);
            // 
            // lValue
            // 
            this.lValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lValue.Location = new System.Drawing.Point(64, 3);
            this.lValue.MaxLength = 3;
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(55, 20);
            this.lValue.TabIndex = 0;
            this.lValue.Text = "100";
            this.lValue.WordWrap = false;
            this.lValue.TextChanged += new System.EventHandler(this.LValue_TextChanged);
            this.lValue.Enter += new System.EventHandler(this.LValue_Enter);
            this.lValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LValue_KeyPress);
            this.lValue.Leave += new System.EventHandler(this.LValue_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(538, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(421, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Используйте слайдеры или укажите требуемое значение и затем нажмите Enter.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(321, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Также можно использовать палитру, кликнув по ней мышью.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 621);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.colorPickerClass1);
            this.Name = "Form1";
            this.Text = "Seledtsov Denis 13 Gr";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rSlider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSlider)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorPickerClass colorPickerClass1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label gLable;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.TextBox bValue;
        private System.Windows.Forms.TextBox gValue;
        private System.Windows.Forms.TextBox rValue;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TrackBar bSlider;
        private System.Windows.Forms.TrackBar gSlider;
        private System.Windows.Forms.TrackBar rSlider;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar kSlider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kValue;
        private System.Windows.Forms.TrackBar ySlider;
        private System.Windows.Forms.TrackBar mSlider;
        private System.Windows.Forms.TrackBar cSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.TextBox mValue;
        private System.Windows.Forms.TextBox cValue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar bSlider2;
        private System.Windows.Forms.TrackBar aSlider;
        private System.Windows.Forms.TrackBar LSlider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bValue2;
        private System.Windows.Forms.TextBox aValue;
        private System.Windows.Forms.TextBox lValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

