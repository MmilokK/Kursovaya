namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.typeField = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NFeild = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.vFeild = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FFeild = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.angleFeild = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.C1Field = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hField = new System.Windows.Forms.ComboBox();
            this.TmField = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.C3Field = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TeIField = new System.Windows.Forms.RadioButton();
            this.TeIIField = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид ремня";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // typeField
            // 
            this.typeField.FormattingEnabled = true;
            this.typeField.Items.AddRange(new object[] {
            "Нормальный",
            "Узкоклименной",
            "Поликлименной"});
            this.typeField.Location = new System.Drawing.Point(138, 21);
            this.typeField.Name = "typeField";
            this.typeField.Size = new System.Drawing.Size(182, 21);
            this.typeField.TabIndex = 1;
            this.typeField.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Профиль ремня";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PrField
            // 
            this.PrField.FormattingEnabled = true;
            this.PrField.Items.AddRange(new object[] {
            "О",
            "А",
            "Б",
            "В",
            "УО",
            "УА",
            "УБ",
            "УВ",
            "К",
            "Л"});
            this.PrField.Location = new System.Drawing.Point(138, 65);
            this.PrField.Name = "PrField";
            this.PrField.Size = new System.Drawing.Size(181, 21);
            this.PrField.TabIndex = 3;
            this.PrField.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Мощность на ведущей звездочке, N";
            // 
            // NFeild
            // 
            this.NFeild.Location = new System.Drawing.Point(249, 108);
            this.NFeild.Name = "NFeild";
            this.NFeild.Size = new System.Drawing.Size(70, 20);
            this.NFeild.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Скорость ремня, v";
            // 
            // vFeild
            // 
            this.vFeild.Location = new System.Drawing.Point(249, 154);
            this.vFeild.Name = "vFeild";
            this.vFeild.Size = new System.Drawing.Size(70, 20);
            this.vFeild.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Окружная сила\r\nF = 1000N/v";
            // 
            // FFeild
            // 
            this.FFeild.Location = new System.Drawing.Point(483, 133);
            this.FFeild.Name = "FFeild";
            this.FFeild.Size = new System.Drawing.Size(70, 20);
            this.FFeild.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Угол обхвата, α1";
            // 
            // angleFeild
            // 
            this.angleFeild.Location = new System.Drawing.Point(199, 208);
            this.angleFeild.Name = "angleFeild";
            this.angleFeild.Size = new System.Drawing.Size(70, 20);
            this.angleFeild.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Коэффициент С1";
            // 
            // C1Field
            // 
            this.C1Field.Location = new System.Drawing.Point(436, 205);
            this.C1Field.Name = "C1Field";
            this.C1Field.Size = new System.Drawing.Size(70, 20);
            this.C1Field.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Характер нагрузки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Тип машины";
            // 
            // hField
            // 
            this.hField.FormattingEnabled = true;
            this.hField.Items.AddRange(new object[] {
            "Спокойная нагрузка",
            "Умеренные колебания нагрузки",
            "Значительные колебания нагрузки",
            "Весьма неравномерная нагрузка"});
            this.hField.Location = new System.Drawing.Point(171, 265);
            this.hField.Name = "hField";
            this.hField.Size = new System.Drawing.Size(182, 21);
            this.hField.TabIndex = 16;
            // 
            // TmField
            // 
            this.TmField.FormattingEnabled = true;
            this.TmField.Items.AddRange(new object[] {
            "Ленточные транспортеры",
            "Пластинчатые транспортёры",
            "Реверсивные приводы",
            "Подъемники"});
            this.TmField.Location = new System.Drawing.Point(171, 307);
            this.TmField.Name = "TmField";
            this.TmField.Size = new System.Drawing.Size(182, 21);
            this.TmField.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(375, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Коэффициент С3";
            // 
            // C3Field
            // 
            this.C3Field.Location = new System.Drawing.Point(483, 283);
            this.C3Field.Name = "C3Field";
            this.C3Field.Size = new System.Drawing.Size(70, 20);
            this.C3Field.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Тип двигателя";
            // 
            // TeIField
            // 
            this.TeIField.AutoSize = true;
            this.TeIField.Location = new System.Drawing.Point(155, 352);
            this.TeIField.Name = "TeIField";
            this.TeIField.Size = new System.Drawing.Size(28, 17);
            this.TeIField.TabIndex = 21;
            this.TeIField.TabStop = true;
            this.TeIField.Text = "I";
            this.TeIField.UseVisualStyleBackColor = true;
            // 
            // TeIIField
            // 
            this.TeIIField.AutoSize = true;
            this.TeIIField.Location = new System.Drawing.Point(155, 375);
            this.TeIIField.Name = "TeIIField";
            this.TeIIField.Size = new System.Drawing.Size(31, 17);
            this.TeIIField.TabIndex = 22;
            this.TeIIField.TabStop = true;
            this.TeIIField.Text = "II";
            this.TeIIField.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(222, 406);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(116, 30);
            this.buttonCalculate.TabIndex = 23;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(378, 406);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(116, 30);
            this.buttonNext.TabIndex = 24;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 487);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.TeIIField);
            this.Controls.Add(this.TeIField);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.C3Field);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TmField);
            this.Controls.Add(this.hField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.C1Field);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.angleFeild);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FFeild);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vFeild);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NFeild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeField);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PrField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NFeild;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vFeild;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FFeild;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox angleFeild;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox C1Field;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox hField;
        private System.Windows.Forms.ComboBox TmField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox C3Field;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton TeIField;
        private System.Windows.Forms.RadioButton TeIIField;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonNext;
    }
}

