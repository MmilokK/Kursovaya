namespace WindowsFormsApp1
{
    partial class ForYP
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Dp1Field = new System.Windows.Forms.TextBox();
            this.vField = new System.Windows.Forms.TextBox();
            this.F0Field = new System.Windows.Forms.TextBox();
            this.uField = new System.Windows.Forms.TextBox();
            this.PFiField = new System.Windows.Forms.TextBox();
            this.PF0Field = new System.Windows.Forms.TextBox();
            this.LField = new System.Windows.Forms.TextBox();
            this.L0Field = new System.Windows.Forms.TextBox();
            this.CLField = new System.Windows.Forms.TextBox();
            this.nnFField = new System.Windows.Forms.TextBox();
            this.S1Field = new System.Windows.Forms.TextBox();
            this.S10Field = new System.Windows.Forms.TextBox();
            this.Z1Field = new System.Windows.Forms.TextBox();
            this.Z10Field = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диаметр меньшего шкива, Dp1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость ремня, v";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Приведенное полезное напряжение, [σF]0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Передаточное число, u";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Поправка Δ[σF]и";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Поправка Δ[σF]0 = 100Δ[σF]и/Dp1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Длина ремня L";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Исходная длина ремня L0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Коэффициент CL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "Допускаемое полезное напряжение \r\n[σF] = ([σF]0+Δ[σF]0)*С1*С3*CL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "S1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "S10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(263, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Число ремней";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 496);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 26);
            this.label14.TabIndex = 13;
            this.label14.Text = "Для клиновых передач\r\nZ = F/(S1*[σF])";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 496);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 26);
            this.label15.TabIndex = 14;
            this.label15.Text = "Для поликлинового ремня\r\nZ = 10*F/(S10*[σF])";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(127, 549);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(123, 34);
            this.CalculateButton.TabIndex = 15;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Сохранить рассчет";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Dp1Field
            // 
            this.Dp1Field.Location = new System.Drawing.Point(218, 24);
            this.Dp1Field.Name = "Dp1Field";
            this.Dp1Field.Size = new System.Drawing.Size(91, 20);
            this.Dp1Field.TabIndex = 17;
            // 
            // vField
            // 
            this.vField.Location = new System.Drawing.Point(218, 83);
            this.vField.Name = "vField";
            this.vField.Size = new System.Drawing.Size(91, 20);
            this.vField.TabIndex = 18;
            // 
            // F0Field
            // 
            this.F0Field.Location = new System.Drawing.Point(555, 59);
            this.F0Field.Name = "F0Field";
            this.F0Field.Size = new System.Drawing.Size(91, 20);
            this.F0Field.TabIndex = 19;
            // 
            // uField
            // 
            this.uField.Location = new System.Drawing.Point(218, 148);
            this.uField.Name = "uField";
            this.uField.Size = new System.Drawing.Size(91, 20);
            this.uField.TabIndex = 20;
            // 
            // PFiField
            // 
            this.PFiField.Location = new System.Drawing.Point(520, 148);
            this.PFiField.Name = "PFiField";
            this.PFiField.Size = new System.Drawing.Size(91, 20);
            this.PFiField.TabIndex = 21;
            // 
            // PF0Field
            // 
            this.PF0Field.Location = new System.Drawing.Point(520, 195);
            this.PF0Field.Name = "PF0Field";
            this.PF0Field.Size = new System.Drawing.Size(91, 20);
            this.PF0Field.TabIndex = 22;
            // 
            // LField
            // 
            this.LField.Location = new System.Drawing.Point(218, 244);
            this.LField.Name = "LField";
            this.LField.Size = new System.Drawing.Size(91, 20);
            this.LField.TabIndex = 23;
            // 
            // L0Field
            // 
            this.L0Field.Location = new System.Drawing.Point(218, 288);
            this.L0Field.Name = "L0Field";
            this.L0Field.Size = new System.Drawing.Size(91, 20);
            this.L0Field.TabIndex = 24;
            // 
            // CLField
            // 
            this.CLField.Location = new System.Drawing.Point(448, 267);
            this.CLField.Name = "CLField";
            this.CLField.Size = new System.Drawing.Size(91, 20);
            this.CLField.TabIndex = 25;
            // 
            // nnFField
            // 
            this.nnFField.Location = new System.Drawing.Point(235, 359);
            this.nnFField.Name = "nnFField";
            this.nnFField.Size = new System.Drawing.Size(91, 20);
            this.nnFField.TabIndex = 26;
            // 
            // S1Field
            // 
            this.S1Field.Location = new System.Drawing.Point(405, 357);
            this.S1Field.Name = "S1Field";
            this.S1Field.Size = new System.Drawing.Size(91, 20);
            this.S1Field.TabIndex = 27;
            // 
            // S10Field
            // 
            this.S10Field.Location = new System.Drawing.Point(405, 392);
            this.S10Field.Name = "S10Field";
            this.S10Field.Size = new System.Drawing.Size(91, 20);
            this.S10Field.TabIndex = 28;
            // 
            // Z1Field
            // 
            this.Z1Field.Location = new System.Drawing.Point(178, 496);
            this.Z1Field.Name = "Z1Field";
            this.Z1Field.Size = new System.Drawing.Size(91, 20);
            this.Z1Field.TabIndex = 29;
            // 
            // Z10Field
            // 
            this.Z10Field.Location = new System.Drawing.Point(495, 496);
            this.Z10Field.Name = "Z10Field";
            this.Z10Field.Size = new System.Drawing.Size(91, 20);
            this.Z10Field.TabIndex = 30;
            // 
            // ForYP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 610);
            this.Controls.Add(this.Z10Field);
            this.Controls.Add(this.Z1Field);
            this.Controls.Add(this.S10Field);
            this.Controls.Add(this.S1Field);
            this.Controls.Add(this.nnFField);
            this.Controls.Add(this.CLField);
            this.Controls.Add(this.L0Field);
            this.Controls.Add(this.LField);
            this.Controls.Add(this.PF0Field);
            this.Controls.Add(this.PFiField);
            this.Controls.Add(this.uField);
            this.Controls.Add(this.F0Field);
            this.Controls.Add(this.vField);
            this.Controls.Add(this.Dp1Field);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
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
            this.Name = "ForYP";
            this.Text = "ForYP";
            this.Load += new System.EventHandler(this.ForYP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Dp1Field;
        private System.Windows.Forms.TextBox vField;
        private System.Windows.Forms.TextBox F0Field;
        private System.Windows.Forms.TextBox uField;
        private System.Windows.Forms.TextBox PFiField;
        private System.Windows.Forms.TextBox PF0Field;
        private System.Windows.Forms.TextBox LField;
        private System.Windows.Forms.TextBox L0Field;
        private System.Windows.Forms.TextBox CLField;
        private System.Windows.Forms.TextBox nnFField;
        private System.Windows.Forms.TextBox S1Field;
        private System.Windows.Forms.TextBox S10Field;
        private System.Windows.Forms.TextBox Z1Field;
        private System.Windows.Forms.TextBox Z10Field;
    }
}