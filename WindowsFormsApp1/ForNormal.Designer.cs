namespace WindowsFormsApp1
{
    partial class ForNormal
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
            this.Dp1Field = new System.Windows.Forms.TextBox();
            this.nnField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vField = new System.Windows.Forms.TextBox();
            this.C2Field = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.F0Field = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nnFField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.S1Field = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ZField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расчетный диаметр меньшего шкива, Dp1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Начальное напряжение, σ0";
            // 
            // Dp1Field
            // 
            this.Dp1Field.Location = new System.Drawing.Point(300, 39);
            this.Dp1Field.Name = "Dp1Field";
            this.Dp1Field.Size = new System.Drawing.Size(104, 20);
            this.Dp1Field.TabIndex = 2;
            // 
            // nnField
            // 
            this.nnField.Location = new System.Drawing.Point(300, 81);
            this.nnField.Name = "nnField";
            this.nnField.Size = new System.Drawing.Size(104, 20);
            this.nnField.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Скорость, v";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Коэффициент С2";
            // 
            // vField
            // 
            this.vField.Location = new System.Drawing.Point(177, 139);
            this.vField.Name = "vField";
            this.vField.Size = new System.Drawing.Size(104, 20);
            this.vField.TabIndex = 6;
            // 
            // C2Field
            // 
            this.C2Field.Location = new System.Drawing.Point(441, 139);
            this.C2Field.Name = "C2Field";
            this.C2Field.Size = new System.Drawing.Size(104, 20);
            this.C2Field.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Приведенное полезное напряжение [σF]0";
            // 
            // F0Field
            // 
            this.F0Field.Location = new System.Drawing.Point(675, 49);
            this.F0Field.Name = "F0Field";
            this.F0Field.Size = new System.Drawing.Size(104, 20);
            this.F0Field.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Допускаемое полезное напряжение, [σF] = [σF]0*С1*С2*С3";
            // 
            // nnFField
            // 
            this.nnFField.Location = new System.Drawing.Point(441, 207);
            this.nnFField.Name = "nnFField";
            this.nnFField.Size = new System.Drawing.Size(104, 20);
            this.nnFField.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "S1";
            // 
            // S1Field
            // 
            this.S1Field.Location = new System.Drawing.Point(441, 270);
            this.S1Field.Name = "S1Field";
            this.S1Field.Size = new System.Drawing.Size(104, 20);
            this.S1Field.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Число ремней Z = F/(S1[σF])";
            // 
            // ZField
            // 
            this.ZField.Location = new System.Drawing.Point(300, 347);
            this.ZField.Name = "ZField";
            this.ZField.Size = new System.Drawing.Size(104, 20);
            this.ZField.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Сохранить рассчет";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ForNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 513);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ZField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.S1Field);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nnFField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.F0Field);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.C2Field);
            this.Controls.Add(this.vField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nnField);
            this.Controls.Add(this.Dp1Field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForNormal";
            this.Text = "ForNormal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dp1Field;
        private System.Windows.Forms.TextBox nnField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vField;
        private System.Windows.Forms.TextBox C2Field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox F0Field;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nnFField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox S1Field;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ZField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}