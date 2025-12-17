namespace GraphicsLab5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button кнопкаЦветПера;
        private System.Windows.Forms.Button кнопкаЦветКисти;
        private System.Windows.Forms.Button кнопкаШрифт;
        private System.Windows.Forms.ComboBox комбоСтильШтриха;
        private System.Windows.Forms.PictureBox картинка1;
        private System.Windows.Forms.ListBox списокРежимОтображения;
        private System.Windows.Forms.Button кнопкаЗагрузитьИзображение;
        private System.Windows.Forms.OpenFileDialog диалогОткрытьФайл;
        private System.Windows.Forms.Button кнопкаРисоватьПоЩелчку;
        private System.Windows.Forms.Button кнопкаМодифицироватьИзображение;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.кнопкаЦветПера = new System.Windows.Forms.Button();
            this.кнопкаЦветКисти = new System.Windows.Forms.Button();
            this.кнопкаШрифт = new System.Windows.Forms.Button();
            this.комбоСтильШтриха = new System.Windows.Forms.ComboBox();
            this.картинка1 = new System.Windows.Forms.PictureBox();
            this.списокРежимОтображения = new System.Windows.Forms.ListBox();
            this.кнопкаЗагрузитьИзображение = new System.Windows.Forms.Button();
            this.диалогОткрытьФайл = new System.Windows.Forms.OpenFileDialog();
            this.кнопкаРисоватьПоЩелчку = new System.Windows.Forms.Button();
            this.кнопкаМодифицироватьИзображение = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.картинка1)).BeginInit();
            this.SuspendLayout();
            // 
            // кнопкаЦветПера
            // 
            this.кнопкаЦветПера.Location = new System.Drawing.Point(975, 46);
            this.кнопкаЦветПера.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.кнопкаЦветПера.Name = "кнопкаЦветПера";
            this.кнопкаЦветПера.Size = new System.Drawing.Size(150, 46);
            this.кнопкаЦветПера.TabIndex = 0;
            this.кнопкаЦветПера.Text = "Цвет пера";
            this.кнопкаЦветПера.UseVisualStyleBackColor = true;
            this.кнопкаЦветПера.Click += new System.EventHandler(this.кнопкаЦветПера_Click);
            // 
            // кнопкаЦветКисти
            // 
            this.кнопкаЦветКисти.Location = new System.Drawing.Point(975, 108);
            this.кнопкаЦветКисти.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.кнопкаЦветКисти.Name = "кнопкаЦветКисти";
            this.кнопкаЦветКисти.Size = new System.Drawing.Size(150, 46);
            this.кнопкаЦветКисти.TabIndex = 1;
            this.кнопкаЦветКисти.Text = "Цвет кисти";
            this.кнопкаЦветКисти.UseVisualStyleBackColor = true;
            this.кнопкаЦветКисти.Click += new System.EventHandler(this.кнопкаЦветКисти_Click);
            // 
            // кнопкаШрифт
            // 
            this.кнопкаШрифт.Location = new System.Drawing.Point(975, 169);
            this.кнопкаШрифт.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.кнопкаШрифт.Name = "кнопкаШрифт";
            this.кнопкаШрифт.Size = new System.Drawing.Size(150, 46);
            this.кнопкаШрифт.TabIndex = 2;
            this.кнопкаШрифт.Text = "Шрифт текста";
            this.кнопкаШрифт.UseVisualStyleBackColor = true;
            this.кнопкаШрифт.Click += new System.EventHandler(this.кнопкаШрифт_Click);
            // 
            // комбоСтильШтриха
            // 
            this.комбоСтильШтриха.Location = new System.Drawing.Point(975, 231);
            this.комбоСтильШтриха.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.комбоСтильШтриха.Name = "комбоСтильШтриха";
            this.комбоСтильШтриха.Size = new System.Drawing.Size(148, 28);
            this.комбоСтильШтриха.TabIndex = 3;
            this.комбоСтильШтриха.SelectedIndexChanged += new System.EventHandler(this.комбоСтильШтриха_SelectedIndexChanged);
            // 
            // картинка1
            // 
            this.картинка1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.картинка1.Location = new System.Drawing.Point(975, 308);
            this.картинка1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.картинка1.Name = "картинка1";
            this.картинка1.Size = new System.Drawing.Size(449, 307);
            this.картинка1.TabIndex = 4;
            this.картинка1.TabStop = false;
            // 
            // списокРежимОтображения
            // 
            this.списокРежимОтображения.ItemHeight = 20;
            this.списокРежимОтображения.Location = new System.Drawing.Point(975, 631);
            this.списокРежимОтображения.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.списокРежимОтображения.Name = "списокРежимОтображения";
            this.списокРежимОтображения.Size = new System.Drawing.Size(178, 144);
            this.списокРежимОтображения.TabIndex = 5;
            this.списокРежимОтображения.SelectedIndexChanged += new System.EventHandler(this.списокРежимОтображения_SelectedIndexChanged);
            // 
            // кнопкаЗагрузитьИзображение
            // 
            this.кнопкаЗагрузитьИзображение.Location = new System.Drawing.Point(975, 785);
            this.кнопкаЗагрузитьИзображение.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.кнопкаЗагрузитьИзображение.Name = "кнопкаЗагрузитьИзображение";
            this.кнопкаЗагрузитьИзображение.Size = new System.Drawing.Size(225, 46);
            this.кнопкаЗагрузитьИзображение.TabIndex = 6;
            this.кнопкаЗагрузитьИзображение.Text = "Загрузить изображение";
            this.кнопкаЗагрузитьИзображение.UseVisualStyleBackColor = true;
            this.кнопкаЗагрузитьИзображение.Click += new System.EventHandler(this.кнопкаЗагрузитьИзображение_Click);
            // 
            // кнопкаРисоватьПоЩелчку
            // 
            this.кнопкаРисоватьПоЩелчку.Location = new System.Drawing.Point(975, 846);
            this.кнопкаРисоватьПоЩелчку.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.кнопкаРисоватьПоЩелчку.Name = "кнопкаРисоватьПоЩелчку";
            this.кнопкаРисоватьПоЩелчку.Size = new System.Drawing.Size(257, 46);
            this.кнопкаРисоватьПоЩелчку.TabIndex = 7;
            this.кнопкаРисоватьПоЩелчку.Text = "Рисовать фигуру по щелчку";
            this.кнопкаРисоватьПоЩелчку.UseVisualStyleBackColor = true;
            this.кнопкаРисоватьПоЩелчку.Click += new System.EventHandler(this.кнопкаРисоватьПоЩелчку_Click);
            // 
            // кнопкаМодифицироватьИзображение
            // 
            this.кнопкаМодифицироватьИзображение.Location = new System.Drawing.Point(975, 908);
            this.кнопкаМодифицироватьИзображение.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.кнопкаМодифицироватьИзображение.Name = "кнопкаМодифицироватьИзображение";
            this.кнопкаМодифицироватьИзображение.Size = new System.Drawing.Size(270, 46);
            this.кнопкаМодифицироватьИзображение.TabIndex = 8;
            this.кнопкаМодифицироватьИзображение.Text = "Модифицировать изображение";
            this.кнопкаМодифицироватьИзображение.UseVisualStyleBackColor = true;
            this.кнопкаМодифицироватьИзображение.Click += new System.EventHandler(this.кнопкаМодифицироватьИзображение_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 1077);
            this.Controls.Add(this.кнопкаМодифицироватьИзображение);
            this.Controls.Add(this.кнопкаРисоватьПоЩелчку);
            this.Controls.Add(this.кнопкаЗагрузитьИзображение);
            this.Controls.Add(this.списокРежимОтображения);
            this.Controls.Add(this.картинка1);
            this.Controls.Add(this.комбоСтильШтриха);
            this.Controls.Add(this.кнопкаШрифт);
            this.Controls.Add(this.кнопкаЦветКисти);
            this.Controls.Add(this.кнопкаЦветПера);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Графическая лабораторная №5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.картинка1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}