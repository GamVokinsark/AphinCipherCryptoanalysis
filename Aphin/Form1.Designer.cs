namespace Aphin
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB3 = new System.Windows.Forms.RadioButton();
            this.inpA = new System.Windows.Forms.TextBox();
            this.inpB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inpSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbX1 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.cB2 = new System.Windows.Forms.ComboBox();
            this.copy = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inpAlp = new System.Windows.Forms.TextBox();
            this.inpN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(267, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Погнали!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 131);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(770, 200);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(9, 374);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(773, 200);
            this.textBox2.TabIndex = 100;
            this.textBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Получаемый текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Исходный текст";
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Checked = true;
            this.rB1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB1.Location = new System.Drawing.Point(23, 19);
            this.rB1.Name = "rB1";
            this.rB1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.rB1.Size = new System.Drawing.Size(146, 22);
            this.rB1.TabIndex = 101;
            this.rB1.TabStop = true;
            this.rB1.Text = "Шифрование";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.CheckedChanged += new System.EventHandler(this.rB1_CheckedChanged);
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB2.Location = new System.Drawing.Point(177, 19);
            this.rB2.Name = "rB2";
            this.rB2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.rB2.Size = new System.Drawing.Size(173, 22);
            this.rB2.TabIndex = 102;
            this.rB2.Text = "Полный перебор";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.CheckedChanged += new System.EventHandler(this.rB2_CheckedChanged);
            // 
            // rB3
            // 
            this.rB3.AutoSize = true;
            this.rB3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB3.Location = new System.Drawing.Point(358, 19);
            this.rB3.Name = "rB3";
            this.rB3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.rB3.Size = new System.Drawing.Size(184, 22);
            this.rB3.TabIndex = 103;
            this.rB3.Text = "Частотный анализ";
            this.rB3.UseVisualStyleBackColor = true;
            this.rB3.CheckedChanged += new System.EventHandler(this.rB3_CheckedChanged);
            // 
            // inpA
            // 
            this.inpA.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpA.Location = new System.Drawing.Point(249, 102);
            this.inpA.MaxLength = 2;
            this.inpA.Name = "inpA";
            this.inpA.Size = new System.Drawing.Size(41, 26);
            this.inpA.TabIndex = 1;
            // 
            // inpB
            // 
            this.inpB.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpB.Location = new System.Drawing.Point(360, 102);
            this.inpB.MaxLength = 2;
            this.inpB.Name = "inpB";
            this.inpB.Size = new System.Drawing.Size(41, 26);
            this.inpB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(212, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "a: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(323, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "b: ";
            // 
            // inpSize
            // 
            this.inpSize.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpSize.Location = new System.Drawing.Point(454, 102);
            this.inpSize.MaxLength = 3;
            this.inpSize.Name = "inpSize";
            this.inpSize.Size = new System.Drawing.Size(73, 26);
            this.inpSize.TabIndex = 3;
            this.inpSize.Text = "60";
            this.inpSize.Visible = false;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSize.Location = new System.Drawing.Point(212, 102);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(221, 26);
            this.lbSize.TabIndex = 3;
            this.lbSize.Text = "Количество символов:";
            this.lbSize.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(360, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "Очистить все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbX1.Location = new System.Drawing.Point(519, 102);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(38, 26);
            this.lbX1.TabIndex = 3;
            this.lbX1.Text = "X1: ";
            this.lbX1.Visible = false;
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbX2.Location = new System.Drawing.Point(667, 102);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(41, 26);
            this.lbX2.TabIndex = 3;
            this.lbX2.Text = "X2: ";
            this.lbX2.Visible = false;
            // 
            // cB1
            // 
            this.cB1.DropDownHeight = 200;
            this.cB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB1.FormattingEnabled = true;
            this.cB1.IntegralHeight = false;
            this.cB1.Items.AddRange(new object[] {
            "а",
            "б",
            "в",
            "г",
            "ґ",
            "д",
            "е",
            "є",
            "ж",
            "з",
            "и",
            "і",
            "ї",
            "й",
            "к",
            "л",
            "м",
            "н",
            "о",
            "п",
            "р",
            "с",
            "т",
            "у",
            "ф",
            "х",
            "ц",
            "ч",
            "ш",
            "щ",
            "ь",
            "ю",
            "я"});
            this.cB1.Location = new System.Drawing.Point(563, 101);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(40, 27);
            this.cB1.TabIndex = 104;
            this.cB1.Visible = false;
            this.cB1.SelectedIndex = 18;
            // 
            // cB2
            // 
            this.cB2.DropDownHeight = 200;
            this.cB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB2.FormattingEnabled = true;
            this.cB2.IntegralHeight = false;
            this.cB2.Items.AddRange(new object[] {
            "а",
            "б",
            "в",
            "г",
            "ґ",
            "д",
            "е",
            "є",
            "ж",
            "з",
            "и",
            "і",
            "ї",
            "й",
            "к",
            "л",
            "м",
            "н",
            "о",
            "п",
            "р",
            "с",
            "т",
            "у",
            "ф",
            "х",
            "ц",
            "ч",
            "ш",
            "щ",
            "ь",
            "ю",
            "я"});
            this.cB2.Location = new System.Drawing.Point(714, 101);
            this.cB2.Name = "cB2";
            this.cB2.Size = new System.Drawing.Size(40, 27);
            this.cB2.TabIndex = 104;
            this.cB2.Visible = false;
            this.cB2.SelectedIndex = 0;
            // 
            // copy
            // 
            this.copy.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copy.Location = new System.Drawing.Point(657, 580);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(106, 31);
            this.copy.TabIndex = 0;
            this.copy.Text = "Скопировать";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.button3_Click);
            // 
            // reverse
            // 
            this.reverse.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reverse.Location = new System.Drawing.Point(618, 99);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(41, 29);
            this.reverse.TabIndex = 0;
            this.reverse.Text = "<->";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Visible = false;
            this.reverse.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(810, 49);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(172, 562);
            this.textBox3.TabIndex = 100;
            this.textBox3.TabStop = false;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(851, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Частоты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Алфавит";
            // 
            // inpAlp
            // 
            this.inpAlp.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpAlp.Location = new System.Drawing.Point(131, 57);
            this.inpAlp.MaxLength = 80;
            this.inpAlp.Name = "inpAlp";
            this.inpAlp.Size = new System.Drawing.Size(486, 31);
            this.inpAlp.TabIndex = 1;
            this.inpAlp.Text = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя0123";
            this.inpAlp.TextChanged += new System.EventHandler(this.inpAlp_TextChanged);
            // 
            // inpN
            // 
            this.inpN.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpN.Location = new System.Drawing.Point(684, 56);
            this.inpN.MaxLength = 2;
            this.inpN.Name = "inpN";
            this.inpN.ReadOnly = true;
            this.inpN.Size = new System.Drawing.Size(39, 31);
            this.inpN.TabIndex = 2;
            this.inpN.Text = "37";
            this.inpN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(647, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "N: ";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(794, 626);
            this.Controls.Add(this.cB2);
            this.Controls.Add(this.cB1);
            this.Controls.Add(this.inpN);
            this.Controls.Add(this.inpB);
            this.Controls.Add(this.inpAlp);
            this.Controls.Add(this.inpA);
            this.Controls.Add(this.rB3);
            this.Controls.Add(this.rB2);
            this.Controls.Add(this.rB1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbX2);
            this.Controls.Add(this.lbX1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.inpSize);
            this.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Афинская перестановка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.RadioButton rB3;
        private System.Windows.Forms.TextBox inpA;
        private System.Windows.Forms.TextBox inpB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inpSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.ComboBox cB2;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inpAlp;
        private System.Windows.Forms.TextBox inpN;
        private System.Windows.Forms.Label label7;
    }
}

