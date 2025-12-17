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
            this.comboBoxNoun = new System.Windows.Forms.ComboBox();
            this.listBoxVerb = new System.Windows.Forms.ListBox();
            this.groupBoxSecondNoun = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.textBoxVerbEdit = new System.Windows.Forms.TextBox();
            this.buttonAddVerb = new System.Windows.Forms.Button();
            this.buttonUpdateVerb = new System.Windows.Forms.Button();
            this.buttonDeleteVerb = new System.Windows.Forms.Button();
            this.checkBoxOption = new System.Windows.Forms.CheckBox();
            this.textBoxNewNoun = new System.Windows.Forms.TextBox();
            this.buttonAddRadio = new System.Windows.Forms.Button();
            this.buttonAddToCombo = new System.Windows.Forms.Button();
            this.buttonUpdateCombo = new System.Windows.Forms.Button();
            this.buttonDeleteFromCombo = new System.Windows.Forms.Button();
            this.groupBoxSecondNoun.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNoun
            // 
            this.comboBoxNoun.FormattingEnabled = true;
            this.comboBoxNoun.Location = new System.Drawing.Point(101, 96);
            this.comboBoxNoun.Name = "comboBoxNoun";
            this.comboBoxNoun.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNoun.TabIndex = 0;
            this.comboBoxNoun.Text = "Существительное";
            this.comboBoxNoun.DropDown += new System.EventHandler(this.comboBoxNoun_DropDown);
            this.comboBoxNoun.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBoxNoun.TextUpdate += new System.EventHandler(this.comboBoxNoun_TextUpdate);
            // 
            // listBoxVerb
            // 
            this.listBoxVerb.FormattingEnabled = true;
            this.listBoxVerb.Location = new System.Drawing.Point(101, 123);
            this.listBoxVerb.Name = "listBoxVerb";
            this.listBoxVerb.Size = new System.Drawing.Size(120, 95);
            this.listBoxVerb.TabIndex = 1;
            this.listBoxVerb.SelectedIndexChanged += new System.EventHandler(this.listBoxVerb_SelectedIndexChanged);
            // 
            // groupBoxSecondNoun
            // 
            this.groupBoxSecondNoun.Controls.Add(this.radioButton4);
            this.groupBoxSecondNoun.Controls.Add(this.radioButton3);
            this.groupBoxSecondNoun.Controls.Add(this.radioButton2);
            this.groupBoxSecondNoun.Controls.Add(this.radioButton1);
            this.groupBoxSecondNoun.Location = new System.Drawing.Point(243, 96);
            this.groupBoxSecondNoun.Name = "groupBoxSecondNoun";
            this.groupBoxSecondNoun.Size = new System.Drawing.Size(199, 177);
            this.groupBoxSecondNoun.TabIndex = 2;
            this.groupBoxSecondNoun.TabStop = false;
            this.groupBoxSecondNoun.Text = "Второе существительное:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Глагол";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Теорема";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Задача";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 77);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Уравнение";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(20, 100);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(79, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Гипербола";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(250, 320);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(105, 16);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Вывод строчки";
            this.labelResult.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(243, 279);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(113, 23);
            this.buttonBuild.TabIndex = 5;
            this.buttonBuild.Text = "Построить фразу";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // textBoxVerbEdit
            // 
            this.textBoxVerbEdit.Location = new System.Drawing.Point(101, 239);
            this.textBoxVerbEdit.Name = "textBoxVerbEdit";
            this.textBoxVerbEdit.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerbEdit.TabIndex = 6;
            // 
            // buttonAddVerb
            // 
            this.buttonAddVerb.Location = new System.Drawing.Point(113, 275);
            this.buttonAddVerb.Name = "buttonAddVerb";
            this.buttonAddVerb.Size = new System.Drawing.Size(109, 27);
            this.buttonAddVerb.TabIndex = 7;
            this.buttonAddVerb.Text = "Добавить глагол";
            this.buttonAddVerb.UseVisualStyleBackColor = true;
            this.buttonAddVerb.Click += new System.EventHandler(this.buttonAddVerb_Click);
            // 
            // buttonUpdateVerb
            // 
            this.buttonUpdateVerb.Location = new System.Drawing.Point(113, 309);
            this.buttonUpdateVerb.Name = "buttonUpdateVerb";
            this.buttonUpdateVerb.Size = new System.Drawing.Size(109, 24);
            this.buttonUpdateVerb.TabIndex = 8;
            this.buttonUpdateVerb.Text = "Изменить глагол";
            this.buttonUpdateVerb.UseVisualStyleBackColor = true;
            this.buttonUpdateVerb.Click += new System.EventHandler(this.buttonUpdateVerb_Click);
            // 
            // buttonDeleteVerb
            // 
            this.buttonDeleteVerb.Location = new System.Drawing.Point(113, 339);
            this.buttonDeleteVerb.Name = "buttonDeleteVerb";
            this.buttonDeleteVerb.Size = new System.Drawing.Size(109, 23);
            this.buttonDeleteVerb.TabIndex = 9;
            this.buttonDeleteVerb.Text = "Удалить глагол";
            this.buttonDeleteVerb.UseVisualStyleBackColor = true;
            this.buttonDeleteVerb.Click += new System.EventHandler(this.buttonDeleteVerb_Click);
            // 
            // checkBoxOption
            // 
            this.checkBoxOption.AutoSize = true;
            this.checkBoxOption.Location = new System.Drawing.Point(113, 380);
            this.checkBoxOption.Name = "checkBoxOption";
            this.checkBoxOption.Size = new System.Drawing.Size(204, 17);
            this.checkBoxOption.TabIndex = 10;
            this.checkBoxOption.Text = "Добавить \'активно\' в предложение";
            this.checkBoxOption.UseVisualStyleBackColor = true;
            this.checkBoxOption.CheckedChanged += new System.EventHandler(this.checkBoxOption_CheckedChanged);
            // 
            // textBoxNewNoun
            // 
            this.textBoxNewNoun.Location = new System.Drawing.Point(124, 446);
            this.textBoxNewNoun.Name = "textBoxNewNoun";
            this.textBoxNewNoun.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewNoun.TabIndex = 11;
            // 
            // buttonAddRadio
            // 
            this.buttonAddRadio.Location = new System.Drawing.Point(124, 481);
            this.buttonAddRadio.Name = "buttonAddRadio";
            this.buttonAddRadio.Size = new System.Drawing.Size(100, 38);
            this.buttonAddRadio.TabIndex = 12;
            this.buttonAddRadio.Text = "Добавить переключатель";
            this.buttonAddRadio.UseVisualStyleBackColor = true;
            this.buttonAddRadio.Click += new System.EventHandler(this.buttonAddRadio_Click);
            // 
            // buttonAddToCombo
            // 
            this.buttonAddToCombo.Location = new System.Drawing.Point(12, 27);
            this.buttonAddToCombo.Name = "buttonAddToCombo";
            this.buttonAddToCombo.Size = new System.Drawing.Size(67, 50);
            this.buttonAddToCombo.TabIndex = 13;
            this.buttonAddToCombo.Text = "&Добавить в ComboBox (Alt+E)";
            this.buttonAddToCombo.UseVisualStyleBackColor = true;
            this.buttonAddToCombo.Click += new System.EventHandler(this.buttonAddToCombo_Click);
            // 
            // buttonUpdateCombo
            // 
            this.buttonUpdateCombo.Location = new System.Drawing.Point(85, 27);
            this.buttonUpdateCombo.Name = "buttonUpdateCombo";
            this.buttonUpdateCombo.Size = new System.Drawing.Size(67, 50);
            this.buttonUpdateCombo.TabIndex = 14;
            this.buttonUpdateCombo.Text = "Изменить (F2)";
            this.buttonUpdateCombo.UseVisualStyleBackColor = true;
            this.buttonUpdateCombo.Click += new System.EventHandler(this.buttonUpdateCombo_Click);
            // 
            // buttonDeleteFromCombo
            // 
            this.buttonDeleteFromCombo.Location = new System.Drawing.Point(158, 27);
            this.buttonDeleteFromCombo.Name = "buttonDeleteFromCombo";
            this.buttonDeleteFromCombo.Size = new System.Drawing.Size(66, 50);
            this.buttonDeleteFromCombo.TabIndex = 15;
            this.buttonDeleteFromCombo.Text = "Удалить";
            this.buttonDeleteFromCombo.UseVisualStyleBackColor = true;
            this.buttonDeleteFromCombo.Click += new System.EventHandler(this.buttonDeleteFromCombo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 618);
            this.Controls.Add(this.buttonDeleteFromCombo);
            this.Controls.Add(this.buttonUpdateCombo);
            this.Controls.Add(this.buttonAddToCombo);
            this.Controls.Add(this.buttonAddRadio);
            this.Controls.Add(this.textBoxNewNoun);
            this.Controls.Add(this.checkBoxOption);
            this.Controls.Add(this.buttonDeleteVerb);
            this.Controls.Add(this.buttonUpdateVerb);
            this.Controls.Add(this.buttonAddVerb);
            this.Controls.Add(this.textBoxVerbEdit);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxSecondNoun);
            this.Controls.Add(this.listBoxVerb);
            this.Controls.Add(this.comboBoxNoun);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBoxSecondNoun.ResumeLayout(false);
            this.groupBoxSecondNoun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNoun;
        private System.Windows.Forms.ListBox listBoxVerb;
        private System.Windows.Forms.GroupBox groupBoxSecondNoun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.TextBox textBoxVerbEdit;
        private System.Windows.Forms.Button buttonAddVerb;
        private System.Windows.Forms.Button buttonUpdateVerb;
        private System.Windows.Forms.Button buttonDeleteVerb;
        private System.Windows.Forms.CheckBox checkBoxOption;
        private System.Windows.Forms.TextBox textBoxNewNoun;
        private System.Windows.Forms.Button buttonAddRadio;
        private System.Windows.Forms.Button buttonAddToCombo;
        private System.Windows.Forms.Button buttonUpdateCombo;
        private System.Windows.Forms.Button buttonDeleteFromCombo;
    }
}

