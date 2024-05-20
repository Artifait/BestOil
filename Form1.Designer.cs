namespace BestOil
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            label6 = new Label();
            ViewTotalOilPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            InputSum = new TextBox();
            InputVolume = new TextBox();
            groupBox3 = new GroupBox();
            SumType = new RadioButton();
            VolumeType = new RadioButton();
            ViewPriceOil = new TextBox();
            InputTypeOil = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox5 = new GroupBox();
            label9 = new Label();
            ViewTotalCofePrice = new TextBox();
            ViewCocaColaPrice = new TextBox();
            ViewFrenchFryPrice = new TextBox();
            ViewBurgerPrice = new TextBox();
            ViewHotDogPrice = new TextBox();
            InputCocaColaCount = new NumericUpDown();
            InputFrenchFryCount = new NumericUpDown();
            InputBurgerCount = new NumericUpDown();
            InputHotDogCount = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            checkBoxCocaCola = new CheckBox();
            checkBoxFrenchFry = new CheckBox();
            checkBoxBurger = new CheckBox();
            checkBoxHotDog = new CheckBox();
            groupBox6 = new GroupBox();
            CheckButton = new Button();
            label10 = new Label();
            ViewTotalPrice = new TextBox();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputCocaColaCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputFrenchFryCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputBurgerCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputHotDogCount).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(InputSum);
            groupBox1.Controls.Add(InputVolume);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(ViewPriceOil);
            groupBox1.Controls.Add(InputTypeOil);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Snow;
            groupBox1.Location = new Point(21, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 336);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Заправка";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(ViewTotalOilPrice);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(18, 214);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(278, 99);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "До Оплаты";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(224, 51);
            label6.Name = "label6";
            label6.Size = new Size(41, 23);
            label6.TabIndex = 13;
            label6.Text = "RUB";
            // 
            // ViewTotalOilPrice
            // 
            ViewTotalOilPrice.BackColor = Color.Black;
            ViewTotalOilPrice.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewTotalOilPrice.ForeColor = Color.White;
            ViewTotalOilPrice.Location = new Point(17, 39);
            ViewTotalOilPrice.Name = "ViewTotalOilPrice";
            ViewTotalOilPrice.ReadOnly = true;
            ViewTotalOilPrice.Size = new Size(201, 40);
            ViewTotalOilPrice.TabIndex = 0;
            ViewTotalOilPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 70);
            label5.Name = "label5";
            label5.Size = new Size(41, 23);
            label5.TabIndex = 11;
            label5.Text = "RUB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 164);
            label4.Name = "label4";
            label4.Size = new Size(41, 23);
            label4.TabIndex = 10;
            label4.Text = "RUB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 129);
            label3.Name = "label3";
            label3.Size = new Size(17, 23);
            label3.TabIndex = 9;
            label3.Text = "L";
            // 
            // InputSum
            // 
            InputSum.BackColor = Color.Black;
            InputSum.ForeColor = Color.White;
            InputSum.Location = new Point(149, 161);
            InputSum.Name = "InputSum";
            InputSum.Size = new Size(107, 31);
            InputSum.TabIndex = 8;
            InputSum.TextChanged += InputSum_TextChanged;
            // 
            // InputVolume
            // 
            InputVolume.BackColor = Color.Black;
            InputVolume.ForeColor = Color.White;
            InputVolume.Location = new Point(150, 121);
            InputVolume.Name = "InputVolume";
            InputVolume.Size = new Size(107, 31);
            InputVolume.TabIndex = 7;
            InputVolume.TextChanged += InputVolume_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SumType);
            groupBox3.Controls.Add(VolumeType);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(18, 107);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(108, 91);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // SumType
            // 
            SumType.AutoSize = true;
            SumType.Font = new Font("Impact", 12F);
            SumType.Location = new Point(17, 54);
            SumType.Name = "SumType";
            SumType.Size = new Size(73, 24);
            SumType.TabIndex = 1;
            SumType.TabStop = true;
            SumType.Text = "Сумма";
            SumType.UseVisualStyleBackColor = true;
            SumType.CheckedChanged += SumType_CheckedChanged;
            // 
            // VolumeType
            // 
            VolumeType.AutoSize = true;
            VolumeType.Font = new Font("Impact", 12F);
            VolumeType.Location = new Point(17, 21);
            VolumeType.Name = "VolumeType";
            VolumeType.Size = new Size(74, 24);
            VolumeType.TabIndex = 0;
            VolumeType.TabStop = true;
            VolumeType.Text = "Кол-во";
            VolumeType.UseVisualStyleBackColor = true;
            VolumeType.CheckedChanged += VolumeType_CheckedChanged;
            // 
            // ViewPriceOil
            // 
            ViewPriceOil.BackColor = Color.Black;
            ViewPriceOil.ForeColor = Color.White;
            ViewPriceOil.Location = new Point(103, 67);
            ViewPriceOil.Name = "ViewPriceOil";
            ViewPriceOil.ReadOnly = true;
            ViewPriceOil.Size = new Size(154, 31);
            ViewPriceOil.TabIndex = 5;
            // 
            // InputTypeOil
            // 
            InputTypeOil.BackColor = Color.Black;
            InputTypeOil.DropDownStyle = ComboBoxStyle.DropDownList;
            InputTypeOil.ForeColor = Color.White;
            InputTypeOil.FormattingEnabled = true;
            InputTypeOil.Items.AddRange(new object[] { "Oil92", "Oil95" });
            InputTypeOil.Location = new Point(103, 30);
            InputTypeOil.Name = "InputTypeOil";
            InputTypeOil.Size = new Size(154, 31);
            InputTypeOil.TabIndex = 4;
            InputTypeOil.SelectedIndexChanged += InputTypeOil_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 3;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 2;
            label1.Text = "Топливо";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(ViewCocaColaPrice);
            groupBox2.Controls.Add(ViewFrenchFryPrice);
            groupBox2.Controls.Add(ViewBurgerPrice);
            groupBox2.Controls.Add(ViewHotDogPrice);
            groupBox2.Controls.Add(InputCocaColaCount);
            groupBox2.Controls.Add(InputFrenchFryCount);
            groupBox2.Controls.Add(InputBurgerCount);
            groupBox2.Controls.Add(InputHotDogCount);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(checkBoxCocaCola);
            groupBox2.Controls.Add(checkBoxFrenchFry);
            groupBox2.Controls.Add(checkBoxBurger);
            groupBox2.Controls.Add(checkBoxHotDog);
            groupBox2.ForeColor = Color.Snow;
            groupBox2.Location = new Point(360, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 336);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Мини-Кафе";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(ViewTotalCofePrice);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(17, 214);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(317, 99);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "До Оплаты";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(261, 51);
            label9.Name = "label9";
            label9.Size = new Size(41, 23);
            label9.TabIndex = 13;
            label9.Text = "RUB";
            // 
            // ViewTotalCofePrice
            // 
            ViewTotalCofePrice.BackColor = Color.Black;
            ViewTotalCofePrice.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewTotalCofePrice.ForeColor = Color.White;
            ViewTotalCofePrice.Location = new Point(17, 39);
            ViewTotalCofePrice.Name = "ViewTotalCofePrice";
            ViewTotalCofePrice.ReadOnly = true;
            ViewTotalCofePrice.Size = new Size(238, 40);
            ViewTotalCofePrice.TabIndex = 0;
            ViewTotalCofePrice.TextAlign = HorizontalAlignment.Right;
            // 
            // ViewCocaColaPrice
            // 
            ViewCocaColaPrice.BackColor = Color.Black;
            ViewCocaColaPrice.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewCocaColaPrice.ForeColor = Color.White;
            ViewCocaColaPrice.Location = new Point(194, 166);
            ViewCocaColaPrice.Name = "ViewCocaColaPrice";
            ViewCocaColaPrice.ReadOnly = true;
            ViewCocaColaPrice.Size = new Size(67, 26);
            ViewCocaColaPrice.TabIndex = 16;
            ViewCocaColaPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // ViewFrenchFryPrice
            // 
            ViewFrenchFryPrice.BackColor = Color.Black;
            ViewFrenchFryPrice.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewFrenchFryPrice.ForeColor = Color.White;
            ViewFrenchFryPrice.Location = new Point(194, 134);
            ViewFrenchFryPrice.Name = "ViewFrenchFryPrice";
            ViewFrenchFryPrice.ReadOnly = true;
            ViewFrenchFryPrice.Size = new Size(67, 26);
            ViewFrenchFryPrice.TabIndex = 15;
            ViewFrenchFryPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // ViewBurgerPrice
            // 
            ViewBurgerPrice.BackColor = Color.Black;
            ViewBurgerPrice.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewBurgerPrice.ForeColor = Color.White;
            ViewBurgerPrice.Location = new Point(194, 100);
            ViewBurgerPrice.Name = "ViewBurgerPrice";
            ViewBurgerPrice.ReadOnly = true;
            ViewBurgerPrice.Size = new Size(67, 26);
            ViewBurgerPrice.TabIndex = 14;
            ViewBurgerPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // ViewHotDogPrice
            // 
            ViewHotDogPrice.BackColor = Color.Black;
            ViewHotDogPrice.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewHotDogPrice.ForeColor = Color.White;
            ViewHotDogPrice.Location = new Point(194, 64);
            ViewHotDogPrice.Name = "ViewHotDogPrice";
            ViewHotDogPrice.ReadOnly = true;
            ViewHotDogPrice.Size = new Size(67, 26);
            ViewHotDogPrice.TabIndex = 13;
            ViewHotDogPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // InputCocaColaCount
            // 
            InputCocaColaCount.BackColor = Color.Black;
            InputCocaColaCount.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputCocaColaCount.ForeColor = Color.White;
            InputCocaColaCount.Location = new Point(267, 166);
            InputCocaColaCount.Name = "InputCocaColaCount";
            InputCocaColaCount.Size = new Size(67, 26);
            InputCocaColaCount.TabIndex = 9;
            InputCocaColaCount.TextAlign = HorizontalAlignment.Center;
            InputCocaColaCount.ValueChanged += InputCocaColaCount_ValueChanged;
            // 
            // InputFrenchFryCount
            // 
            InputFrenchFryCount.BackColor = Color.Black;
            InputFrenchFryCount.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputFrenchFryCount.ForeColor = Color.White;
            InputFrenchFryCount.Location = new Point(267, 133);
            InputFrenchFryCount.Name = "InputFrenchFryCount";
            InputFrenchFryCount.Size = new Size(67, 26);
            InputFrenchFryCount.TabIndex = 8;
            InputFrenchFryCount.TextAlign = HorizontalAlignment.Center;
            InputFrenchFryCount.ValueChanged += InputFrenchFryCount_ValueChanged;
            // 
            // InputBurgerCount
            // 
            InputBurgerCount.BackColor = Color.Black;
            InputBurgerCount.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputBurgerCount.ForeColor = Color.White;
            InputBurgerCount.Location = new Point(267, 100);
            InputBurgerCount.Name = "InputBurgerCount";
            InputBurgerCount.Size = new Size(67, 26);
            InputBurgerCount.TabIndex = 7;
            InputBurgerCount.TextAlign = HorizontalAlignment.Center;
            InputBurgerCount.ValueChanged += InputBurgerCount_ValueChanged;
            // 
            // InputHotDogCount
            // 
            InputHotDogCount.BackColor = Color.Black;
            InputHotDogCount.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputHotDogCount.ForeColor = Color.White;
            InputHotDogCount.Location = new Point(267, 65);
            InputHotDogCount.Name = "InputHotDogCount";
            InputHotDogCount.Size = new Size(67, 26);
            InputHotDogCount.TabIndex = 6;
            InputHotDogCount.TextAlign = HorizontalAlignment.Center;
            InputHotDogCount.ValueChanged += InputHotDogCount_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(267, 30);
            label8.Name = "label8";
            label8.Size = new Size(67, 23);
            label8.TabIndex = 5;
            label8.Text = "Кол-во";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 30);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 4;
            label7.Text = "Цена";
            // 
            // checkBoxCocaCola
            // 
            checkBoxCocaCola.AutoSize = true;
            checkBoxCocaCola.Location = new Point(17, 164);
            checkBoxCocaCola.Name = "checkBoxCocaCola";
            checkBoxCocaCola.Size = new Size(116, 27);
            checkBoxCocaCola.TabIndex = 3;
            checkBoxCocaCola.Text = "Кока-Кола";
            checkBoxCocaCola.UseVisualStyleBackColor = true;
            checkBoxCocaCola.CheckedChanged += checkBoxCocaCola_CheckedChanged;
            // 
            // checkBoxFrenchFry
            // 
            checkBoxFrenchFry.AutoSize = true;
            checkBoxFrenchFry.Location = new Point(17, 131);
            checkBoxFrenchFry.Name = "checkBoxFrenchFry";
            checkBoxFrenchFry.Size = new Size(165, 27);
            checkBoxFrenchFry.TabIndex = 2;
            checkBoxFrenchFry.Text = "Картофель-Фри";
            checkBoxFrenchFry.UseVisualStyleBackColor = true;
            checkBoxFrenchFry.CheckedChanged += checkBoxFrenchFry_CheckedChanged;
            // 
            // checkBoxBurger
            // 
            checkBoxBurger.AutoSize = true;
            checkBoxBurger.Location = new Point(17, 98);
            checkBoxBurger.Name = "checkBoxBurger";
            checkBoxBurger.Size = new Size(116, 27);
            checkBoxBurger.TabIndex = 1;
            checkBoxBurger.Text = "Гамбургер";
            checkBoxBurger.UseVisualStyleBackColor = true;
            checkBoxBurger.CheckedChanged += checkBoxBurger_CheckedChanged;
            // 
            // checkBoxHotDog
            // 
            checkBoxHotDog.AutoSize = true;
            checkBoxHotDog.Location = new Point(17, 65);
            checkBoxHotDog.Name = "checkBoxHotDog";
            checkBoxHotDog.Size = new Size(91, 27);
            checkBoxHotDog.TabIndex = 0;
            checkBoxHotDog.Text = "Хот-Дог";
            checkBoxHotDog.UseVisualStyleBackColor = true;
            checkBoxHotDog.CheckedChanged += checkBoxHotDog_CheckedChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(CheckButton);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(ViewTotalPrice);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(21, 374);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(691, 154);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "Всего-До-Оплаты";
            // 
            // CheckButton
            // 
            CheckButton.BackColor = Color.Black;
            CheckButton.Location = new Point(24, 47);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(102, 72);
            CheckButton.TabIndex = 14;
            CheckButton.Text = "Чек";
            CheckButton.UseVisualStyleBackColor = false;
            CheckButton.Click += CheckButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(632, 72);
            label10.Name = "label10";
            label10.Size = new Size(41, 23);
            label10.TabIndex = 13;
            label10.Text = "RUB";
            // 
            // ViewTotalPrice
            // 
            ViewTotalPrice.BackColor = Color.Black;
            ViewTotalPrice.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ViewTotalPrice.ForeColor = Color.White;
            ViewTotalPrice.Location = new Point(150, 60);
            ViewTotalPrice.Name = "ViewTotalPrice";
            ViewTotalPrice.ReadOnly = true;
            ViewTotalPrice.Size = new Size(476, 50);
            ViewTotalPrice.TabIndex = 0;
            ViewTotalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(734, 561);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "BestOil";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputCocaColaCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputFrenchFryCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputBurgerCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputHotDogCount).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private TextBox ViewPriceOil;
        private ComboBox InputTypeOil;
        private GroupBox groupBox3;
        private RadioButton VolumeType;
        private Label label4;
        private Label label3;
        private TextBox InputSum;
        private TextBox InputVolume;
        private RadioButton SumType;
        private GroupBox groupBox4;
        private Label label6;
        private TextBox ViewTotalOilPrice;
        private Label label5;
        private CheckBox checkBoxBurger;
        private CheckBox checkBoxHotDog;
        private Label label8;
        private Label label7;
        private CheckBox checkBoxCocaCola;
        private CheckBox checkBoxFrenchFry;
        private NumericUpDown InputHotDogCount;
        private TextBox ViewCocaColaPrice;
        private TextBox ViewFrenchFryPrice;
        private TextBox ViewBurgerPrice;
        private TextBox ViewHotDogPrice;
        private NumericUpDown InputCocaColaCount;
        private NumericUpDown InputFrenchFryCount;
        private NumericUpDown InputBurgerCount;
        private GroupBox groupBox5;
        private Label label9;
        private TextBox ViewTotalCofePrice;
        private GroupBox groupBox6;
        private Button CheckButton;
        private Label label10;
        private TextBox ViewTotalPrice;
    }
}
