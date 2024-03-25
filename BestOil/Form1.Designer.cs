namespace BestOil
{
    partial class BestOil
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
            label2 = new Label();
            GasolineComboBox = new ComboBox();
            label3 = new Label();
            priceGas = new TextBox();
            LitresRadioButton1 = new RadioButton();
            SumRadioButton1 = new RadioButton();
            GasBox = new TextBox();
            SumBox = new TextBox();
            label4 = new Label();
            CalculateGas = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            CalculateCafe = new TextBox();
            label10 = new Label();
            numericUpDownAmericano = new NumericUpDown();
            textBoxAmericano = new TextBox();
            checkBoxAmericano = new CheckBox();
            numericUpDownCocaCola = new NumericUpDown();
            textBoxCocaCola = new TextBox();
            checkBoxCocaCola = new CheckBox();
            numericUpDownHotDog = new NumericUpDown();
            textBoxHotDog = new TextBox();
            checkBoxHotDog = new CheckBox();
            numericUpDownBurger = new NumericUpDown();
            label1 = new Label();
            textBoxBurger = new TextBox();
            checkBoxBurger = new CheckBox();
            groupBox3 = new GroupBox();
            buttonCheck = new Button();
            label11 = new Label();
            CalculateGasCafe = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmericano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCocaCola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHotDog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBurger).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 23);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Бензин";
            // 
            // GasolineComboBox
            // 
            GasolineComboBox.FormattingEnabled = true;
            GasolineComboBox.Items.AddRange(new object[] { "AI-92", "AI-95" });
            GasolineComboBox.Location = new Point(56, 20);
            GasolineComboBox.Name = "GasolineComboBox";
            GasolineComboBox.Size = new Size(61, 23);
            GasolineComboBox.Sorted = true;
            GasolineComboBox.TabIndex = 0;
            GasolineComboBox.SelectedIndexChanged += GasolineComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Цена";
            // 
            // priceGas
            // 
            priceGas.Cursor = Cursors.IBeam;
            priceGas.Location = new Point(56, 53);
            priceGas.Name = "priceGas";
            priceGas.Size = new Size(61, 23);
            priceGas.TabIndex = 3;
            priceGas.TextChanged += GasolineComboBox_SelectedIndexChanged;
            // 
            // LitresRadioButton1
            // 
            LitresRadioButton1.AutoSize = true;
            LitresRadioButton1.Location = new Point(6, 96);
            LitresRadioButton1.Name = "LitresRadioButton1";
            LitresRadioButton1.Size = new Size(90, 19);
            LitresRadioButton1.TabIndex = 4;
            LitresRadioButton1.TabStop = true;
            LitresRadioButton1.Text = "Количество";
            LitresRadioButton1.UseVisualStyleBackColor = true;
            LitresRadioButton1.CheckedChanged += LitresRadioButton1_CheckedChanged;
            // 
            // SumRadioButton1
            // 
            SumRadioButton1.AutoSize = true;
            SumRadioButton1.Location = new Point(6, 125);
            SumRadioButton1.Name = "SumRadioButton1";
            SumRadioButton1.Size = new Size(63, 19);
            SumRadioButton1.TabIndex = 5;
            SumRadioButton1.TabStop = true;
            SumRadioButton1.Text = "Сумма";
            SumRadioButton1.UseVisualStyleBackColor = true;
            SumRadioButton1.CheckedChanged += SumRadioButton1_CheckedChanged;
            // 
            // GasBox
            // 
            GasBox.Location = new Point(102, 96);
            GasBox.Name = "GasBox";
            GasBox.Size = new Size(61, 23);
            GasBox.TabIndex = 6;
            GasBox.TextChanged += GasBox_TextChanged;
            // 
            // SumBox
            // 
            SumBox.Location = new Point(102, 125);
            SumBox.Name = "SumBox";
            SumBox.Size = new Size(61, 23);
            SumBox.TabIndex = 7;
            SumBox.TextChanged += SumBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 165);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Сумма";
            // 
            // CalculateGas
            // 
            CalculateGas.Cursor = Cursors.IBeam;
            CalculateGas.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateGas.Location = new Point(57, 166);
            CalculateGas.Multiline = true;
            CalculateGas.Name = "CalculateGas";
            CalculateGas.ReadOnly = true;
            CalculateGas.Size = new Size(95, 50);
            CalculateGas.TabIndex = 9;
            CalculateGas.Text = "0";
            CalculateGas.TextAlign = HorizontalAlignment.Center;
            CalculateGas.TextChanged += CalculateGas_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(158, 188);
            label5.Name = "label5";
            label5.Size = new Size(23, 28);
            label5.TabIndex = 10;
            label5.Text = "$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 132);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 12;
            label7.Text = "$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(166, 103);
            label8.Name = "label8";
            label8.Size = new Size(17, 15);
            label8.TabIndex = 13;
            label8.Text = "л.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(123, 61);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 14;
            label9.Text = "$";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(GasolineComboBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(priceGas);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(LitresRadioButton1);
            groupBox1.Controls.Add(CalculateGas);
            groupBox1.Controls.Add(SumRadioButton1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(GasBox);
            groupBox1.Controls.Add(SumBox);
            groupBox1.Location = new Point(17, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 235);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Автозаправка";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(CalculateCafe);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(numericUpDownAmericano);
            groupBox2.Controls.Add(textBoxAmericano);
            groupBox2.Controls.Add(checkBoxAmericano);
            groupBox2.Controls.Add(numericUpDownCocaCola);
            groupBox2.Controls.Add(textBoxCocaCola);
            groupBox2.Controls.Add(checkBoxCocaCola);
            groupBox2.Controls.Add(numericUpDownHotDog);
            groupBox2.Controls.Add(textBoxHotDog);
            groupBox2.Controls.Add(checkBoxHotDog);
            groupBox2.Controls.Add(numericUpDownBurger);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxBurger);
            groupBox2.Controls.Add(checkBoxBurger);
            groupBox2.Location = new Point(232, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 235);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Мини Кафе";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(161, 187);
            label6.Name = "label6";
            label6.Size = new Size(23, 28);
            label6.TabIndex = 15;
            label6.Text = "$";
            // 
            // CalculateCafe
            // 
            CalculateCafe.Cursor = Cursors.IBeam;
            CalculateCafe.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateCafe.Location = new Point(60, 165);
            CalculateCafe.Multiline = true;
            CalculateCafe.Name = "CalculateCafe";
            CalculateCafe.ReadOnly = true;
            CalculateCafe.Size = new Size(95, 50);
            CalculateCafe.TabIndex = 14;
            CalculateCafe.Text = "0";
            CalculateCafe.TextAlign = HorizontalAlignment.Center;
            CalculateCafe.TextChanged += CalculateCafe_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 164);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 13;
            label10.Text = "Сумма";
            // 
            // numericUpDownAmericano
            // 
            numericUpDownAmericano.Location = new Point(138, 112);
            numericUpDownAmericano.Name = "numericUpDownAmericano";
            numericUpDownAmericano.Size = new Size(33, 23);
            numericUpDownAmericano.TabIndex = 12;
            numericUpDownAmericano.ValueChanged += numericUpDownAmericano_ValueChanged;
            // 
            // textBoxAmericano
            // 
            textBoxAmericano.Location = new Point(95, 111);
            textBoxAmericano.Name = "textBoxAmericano";
            textBoxAmericano.Size = new Size(33, 23);
            textBoxAmericano.TabIndex = 11;
            textBoxAmericano.Text = "1.50";
            // 
            // checkBoxAmericano
            // 
            checkBoxAmericano.AutoSize = true;
            checkBoxAmericano.Location = new Point(6, 113);
            checkBoxAmericano.Name = "checkBoxAmericano";
            checkBoxAmericano.Size = new Size(89, 19);
            checkBoxAmericano.TabIndex = 10;
            checkBoxAmericano.Text = "Американо";
            checkBoxAmericano.UseVisualStyleBackColor = true;
            checkBoxAmericano.CheckedChanged += checkBoxBurger_CheckedChanged;
            // 
            // numericUpDownCocaCola
            // 
            numericUpDownCocaCola.Location = new Point(138, 85);
            numericUpDownCocaCola.Name = "numericUpDownCocaCola";
            numericUpDownCocaCola.Size = new Size(33, 23);
            numericUpDownCocaCola.TabIndex = 9;
            numericUpDownCocaCola.ValueChanged += numericUpDownCocaCola_ValueChanged;
            // 
            // textBoxCocaCola
            // 
            textBoxCocaCola.Location = new Point(95, 84);
            textBoxCocaCola.Name = "textBoxCocaCola";
            textBoxCocaCola.Size = new Size(33, 23);
            textBoxCocaCola.TabIndex = 8;
            textBoxCocaCola.Text = "1.20";
            // 
            // checkBoxCocaCola
            // 
            checkBoxCocaCola.AutoSize = true;
            checkBoxCocaCola.Location = new Point(6, 85);
            checkBoxCocaCola.Name = "checkBoxCocaCola";
            checkBoxCocaCola.Size = new Size(84, 19);
            checkBoxCocaCola.TabIndex = 7;
            checkBoxCocaCola.Text = "Кока-Кола";
            checkBoxCocaCola.UseVisualStyleBackColor = true;
            checkBoxCocaCola.CheckedChanged += checkBoxBurger_CheckedChanged;
            // 
            // numericUpDownHotDog
            // 
            numericUpDownHotDog.Location = new Point(138, 58);
            numericUpDownHotDog.Name = "numericUpDownHotDog";
            numericUpDownHotDog.Size = new Size(33, 23);
            numericUpDownHotDog.TabIndex = 6;
            numericUpDownHotDog.ValueChanged += numericUpDownHotDog_ValueChanged;
            // 
            // textBoxHotDog
            // 
            textBoxHotDog.Location = new Point(95, 57);
            textBoxHotDog.Name = "textBoxHotDog";
            textBoxHotDog.Size = new Size(33, 23);
            textBoxHotDog.TabIndex = 5;
            textBoxHotDog.Text = "1.80";
            // 
            // checkBoxHotDog
            // 
            checkBoxHotDog.AutoSize = true;
            checkBoxHotDog.Location = new Point(6, 59);
            checkBoxHotDog.Name = "checkBoxHotDog";
            checkBoxHotDog.Size = new Size(70, 19);
            checkBoxHotDog.TabIndex = 4;
            checkBoxHotDog.Text = "Хот-Дог";
            checkBoxHotDog.UseVisualStyleBackColor = true;
            checkBoxHotDog.CheckedChanged += checkBoxBurger_CheckedChanged;
            // 
            // numericUpDownBurger
            // 
            numericUpDownBurger.Location = new Point(138, 31);
            numericUpDownBurger.Name = "numericUpDownBurger";
            numericUpDownBurger.Size = new Size(33, 23);
            numericUpDownBurger.TabIndex = 3;
            numericUpDownBurger.ValueChanged += numericUpDownBurger_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 11);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Цена";
            // 
            // textBoxBurger
            // 
            textBoxBurger.Location = new Point(95, 30);
            textBoxBurger.Name = "textBoxBurger";
            textBoxBurger.ReadOnly = true;
            textBoxBurger.Size = new Size(33, 23);
            textBoxBurger.TabIndex = 1;
            textBoxBurger.Text = "3,20";
            // 
            // checkBoxBurger
            // 
            checkBoxBurger.AutoSize = true;
            checkBoxBurger.Location = new Point(6, 32);
            checkBoxBurger.Name = "checkBoxBurger";
            checkBoxBurger.Size = new Size(64, 19);
            checkBoxBurger.TabIndex = 0;
            checkBoxBurger.Text = "Бургер";
            checkBoxBurger.UseVisualStyleBackColor = true;
            checkBoxBurger.CheckedChanged += checkBoxBurger_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonCheck);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(CalculateGasCafe);
            groupBox3.Location = new Point(17, 268);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(401, 107);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Общая сумма";
            // 
            // buttonCheck
            // 
            buttonCheck.BackColor = Color.Transparent;
            buttonCheck.Cursor = Cursors.Hand;
            buttonCheck.Location = new Point(30, 38);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(106, 42);
            buttonCheck.TabIndex = 13;
            buttonCheck.Text = "Check";
            buttonCheck.UseVisualStyleBackColor = false;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(372, 57);
            label11.Name = "label11";
            label11.Size = new Size(23, 28);
            label11.TabIndex = 12;
            label11.Text = "$";
            // 
            // CalculateGasCafe
            // 
            CalculateGasCafe.Cursor = Cursors.IBeam;
            CalculateGasCafe.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateGasCafe.Location = new Point(158, 29);
            CalculateGasCafe.Multiline = true;
            CalculateGasCafe.Name = "CalculateGasCafe";
            CalculateGasCafe.ReadOnly = true;
            CalculateGasCafe.Size = new Size(208, 56);
            CalculateGasCafe.TabIndex = 11;
            CalculateGasCafe.Text = "0";
            CalculateGasCafe.TextAlign = HorizontalAlignment.Center;
            // 
            // BestOil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(434, 411);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "BestOil";
            Text = "BestOil";
            FormClosing += CloseProgram;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmericano).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCocaCola).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHotDog).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBurger).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private ComboBox GasolineComboBox;
        private Label label3;
        private TextBox priceGas;
        private RadioButton LitresRadioButton1;
        private RadioButton SumRadioButton1;
        private TextBox GasBox;
        private TextBox SumBox;
        private Label label4;
        private TextBox CalculateGas;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBoxBurger;
        private CheckBox checkBoxBurger;
        private NumericUpDown numericUpDownCocaCola;
        private TextBox textBoxCocaCola;
        private CheckBox checkBoxCocaCola;
        private NumericUpDown numericUpDownHotDog;
        private TextBox textBoxHotDog;
        private CheckBox checkBoxHotDog;
        private NumericUpDown numericUpDownBurger;
        private NumericUpDown numericUpDownAmericano;
        private TextBox textBoxAmericano;
        private CheckBox checkBoxAmericano;
        private Label label6;
        private TextBox CalculateCafe;
        private Label label10;
        private GroupBox groupBox3;
        private Button buttonCheck;
        private Label label11;
        private TextBox CalculateGasCafe;
    }
}
