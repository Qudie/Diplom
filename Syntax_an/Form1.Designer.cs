namespace Syntax_an
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
            this.OriginalTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveTextBtn = new System.Windows.Forms.Button();
            this.CorrectedTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CorrectTextBtn = new System.Windows.Forms.Button();
            this.UploadTextBtn = new System.Windows.Forms.Button();
            this.LabelOriginalTxt = new System.Windows.Forms.Label();
            this.LabelChangedTxt = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DigitErrorUpDown = new System.Windows.Forms.NumericUpDown();
            this.KBLayoutErrorUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TypoErrorUpDown = new System.Windows.Forms.NumericUpDown();
            this.DigitErrorCheckBox = new System.Windows.Forms.CheckBox();
            this.KBLayoutErrorCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TypoErrorCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DigitErrorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KBLayoutErrorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypoErrorUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalTextBox
            // 
            this.OriginalTextBox.Location = new System.Drawing.Point(3, 23);
            this.OriginalTextBox.Name = "OriginalTextBox";
            this.OriginalTextBox.Size = new System.Drawing.Size(357, 485);
            this.OriginalTextBox.TabIndex = 1;
            this.OriginalTextBox.Text = "";
            this.OriginalTextBox.TextChanged += new System.EventHandler(this.OriginalTextBox_TextChanged);
            // 
            // SaveTextBtn
            // 
            this.SaveTextBtn.Location = new System.Drawing.Point(584, 514);
            this.SaveTextBtn.Name = "SaveTextBtn";
            this.SaveTextBtn.Size = new System.Drawing.Size(145, 33);
            this.SaveTextBtn.TabIndex = 2;
            this.SaveTextBtn.Text = "Сохранить текст";
            this.SaveTextBtn.UseVisualStyleBackColor = true;
            this.SaveTextBtn.Click += new System.EventHandler(this.SaveText_Click);
            // 
            // CorrectedTextBox
            // 
            this.CorrectedTextBox.Location = new System.Drawing.Point(369, 23);
            this.CorrectedTextBox.Name = "CorrectedTextBox";
            this.CorrectedTextBox.Size = new System.Drawing.Size(360, 485);
            this.CorrectedTextBox.TabIndex = 3;
            this.CorrectedTextBox.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 582);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CorrectTextBtn);
            this.tabPage1.Controls.Add(this.UploadTextBtn);
            this.tabPage1.Controls.Add(this.LabelOriginalTxt);
            this.tabPage1.Controls.Add(this.LabelChangedTxt);
            this.tabPage1.Controls.Add(this.CorrectedTextBox);
            this.tabPage1.Controls.Add(this.SaveTextBtn);
            this.tabPage1.Controls.Add(this.OriginalTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Анализ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CorrectTextBtn
            // 
            this.CorrectTextBtn.Location = new System.Drawing.Point(215, 514);
            this.CorrectTextBtn.Name = "CorrectTextBtn";
            this.CorrectTextBtn.Size = new System.Drawing.Size(145, 33);
            this.CorrectTextBtn.TabIndex = 7;
            this.CorrectTextBtn.Text = "Исправить текст";
            this.CorrectTextBtn.UseVisualStyleBackColor = true;
            this.CorrectTextBtn.Click += new System.EventHandler(this.CorrectTextBtn_Click);
            // 
            // UploadTextBtn
            // 
            this.UploadTextBtn.Location = new System.Drawing.Point(3, 514);
            this.UploadTextBtn.Name = "UploadTextBtn";
            this.UploadTextBtn.Size = new System.Drawing.Size(145, 33);
            this.UploadTextBtn.TabIndex = 6;
            this.UploadTextBtn.Text = "Загрузить текст";
            this.UploadTextBtn.UseVisualStyleBackColor = true;
            this.UploadTextBtn.Click += new System.EventHandler(this.UploadTextBtn_Click);
            // 
            // LabelOriginalTxt
            // 
            this.LabelOriginalTxt.AutoSize = true;
            this.LabelOriginalTxt.Location = new System.Drawing.Point(6, 3);
            this.LabelOriginalTxt.Name = "LabelOriginalTxt";
            this.LabelOriginalTxt.Size = new System.Drawing.Size(113, 17);
            this.LabelOriginalTxt.TabIndex = 5;
            this.LabelOriginalTxt.Text = "Исходный текст";
            // 
            // LabelChangedTxt
            // 
            this.LabelChangedTxt.AutoSize = true;
            this.LabelChangedTxt.Location = new System.Drawing.Point(366, 3);
            this.LabelChangedTxt.Name = "LabelChangedTxt";
            this.LabelChangedTxt.Size = new System.Drawing.Size(146, 17);
            this.LabelChangedTxt.TabIndex = 4;
            this.LabelChangedTxt.Text = "Исправленный текст";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DigitErrorUpDown);
            this.tabPage2.Controls.Add(this.KBLayoutErrorUpDown);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TypoErrorUpDown);
            this.tabPage2.Controls.Add(this.DigitErrorCheckBox);
            this.tabPage2.Controls.Add(this.KBLayoutErrorCheckBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.TypoErrorCheckBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DigitErrorUpDown
            // 
            this.DigitErrorUpDown.Location = new System.Drawing.Point(282, 110);
            this.DigitErrorUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DigitErrorUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DigitErrorUpDown.Name = "DigitErrorUpDown";
            this.DigitErrorUpDown.Size = new System.Drawing.Size(120, 22);
            this.DigitErrorUpDown.TabIndex = 7;
            this.DigitErrorUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DigitErrorUpDown.ValueChanged += new System.EventHandler(this.DigitErrorUpDown_ValueChanged);
            // 
            // KBLayoutErrorUpDown
            // 
            this.KBLayoutErrorUpDown.Location = new System.Drawing.Point(282, 82);
            this.KBLayoutErrorUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.KBLayoutErrorUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KBLayoutErrorUpDown.Name = "KBLayoutErrorUpDown";
            this.KBLayoutErrorUpDown.Size = new System.Drawing.Size(120, 22);
            this.KBLayoutErrorUpDown.TabIndex = 6;
            this.KBLayoutErrorUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KBLayoutErrorUpDown.ValueChanged += new System.EventHandler(this.KBLayoutErrorUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Приоритет типа ошибок";
            // 
            // TypoErrorUpDown
            // 
            this.TypoErrorUpDown.Location = new System.Drawing.Point(282, 53);
            this.TypoErrorUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.TypoErrorUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TypoErrorUpDown.Name = "TypoErrorUpDown";
            this.TypoErrorUpDown.Size = new System.Drawing.Size(120, 22);
            this.TypoErrorUpDown.TabIndex = 4;
            this.TypoErrorUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TypoErrorUpDown.ValueChanged += new System.EventHandler(this.TypoErrorUpDown_ValueChanged);
            // 
            // DigitErrorCheckBox
            // 
            this.DigitErrorCheckBox.AutoSize = true;
            this.DigitErrorCheckBox.Location = new System.Drawing.Point(9, 109);
            this.DigitErrorCheckBox.Name = "DigitErrorCheckBox";
            this.DigitErrorCheckBox.Size = new System.Drawing.Size(175, 21);
            this.DigitErrorCheckBox.TabIndex = 3;
            this.DigitErrorCheckBox.Text = "Замена буквы цифрой";
            this.DigitErrorCheckBox.UseVisualStyleBackColor = true;
            this.DigitErrorCheckBox.CheckedChanged += new System.EventHandler(this.DigitErrorCheckBox_CheckedChanged);
            // 
            // KBLayoutErrorCheckBox
            // 
            this.KBLayoutErrorCheckBox.AutoSize = true;
            this.KBLayoutErrorCheckBox.Location = new System.Drawing.Point(9, 82);
            this.KBLayoutErrorCheckBox.Name = "KBLayoutErrorCheckBox";
            this.KBLayoutErrorCheckBox.Size = new System.Drawing.Size(179, 21);
            this.KBLayoutErrorCheckBox.TabIndex = 2;
            this.KBLayoutErrorCheckBox.Text = "Раскладка клавиатуры";
            this.KBLayoutErrorCheckBox.UseVisualStyleBackColor = true;
            this.KBLayoutErrorCheckBox.CheckedChanged += new System.EventHandler(this.KBLayoutErrorCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип исправляемой ошибки";
            // 
            // TypoErrorCheckBox
            // 
            this.TypoErrorCheckBox.AutoSize = true;
            this.TypoErrorCheckBox.Location = new System.Drawing.Point(9, 55);
            this.TypoErrorCheckBox.Name = "TypoErrorCheckBox";
            this.TypoErrorCheckBox.Size = new System.Drawing.Size(113, 21);
            this.TypoErrorCheckBox.TabIndex = 0;
            this.TypoErrorCheckBox.Text = "Орфография";
            this.TypoErrorCheckBox.UseVisualStyleBackColor = true;
            this.TypoErrorCheckBox.CheckedChanged += new System.EventHandler(this.TypoErrorCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 606);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ПМ АГЭД";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DigitErrorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KBLayoutErrorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypoErrorUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox OriginalTextBox;
        private System.Windows.Forms.Button SaveTextBtn;
        private System.Windows.Forms.RichTextBox CorrectedTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button UploadTextBtn;
        private System.Windows.Forms.Label LabelOriginalTxt;
        private System.Windows.Forms.Label LabelChangedTxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox DigitErrorCheckBox;
        private System.Windows.Forms.CheckBox KBLayoutErrorCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TypoErrorCheckBox;
        private System.Windows.Forms.NumericUpDown DigitErrorUpDown;
        private System.Windows.Forms.NumericUpDown KBLayoutErrorUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TypoErrorUpDown;
        private System.Windows.Forms.Button CorrectTextBtn;
    }
}

