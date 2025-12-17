using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphicsLab5
{
    public partial class Form1 : Form
    {
        private Color цветПера = Color.Black;
        private Color цветКисти = Color.Blue;
        private Font шрифтТекста = new Font("Arial", 12);
        private DashStyle стильШтриха = DashStyle.Solid;
        private bool рисоватьПоЩелчку = false;
        private Point местоЗвезды = Point.Empty;
        private Bitmap модифицированноеИзображение = null;
        private Image загруженноеИзображение = null;

        public Form1()
        {
            InitializeComponent();
            НастроитьЭлементы();
            this.DoubleBuffered = true;
        }

        private void НастроитьЭлементы()
        {
            комбоСтильШтриха.Items.AddRange(new string[] {
                "Solid", "Dash", "Dot", "DashDot", "DashDotDot"
            });
            комбоСтильШтриха.SelectedIndex = 0;

            списокРежимОтображения.Items.AddRange(new string[] {
                "Normal", "StretchImage", "AutoSize", "CenterImage", "Zoom"
            });
            списокРежимОтображения.SelectedIndex = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle прямоугольник = new Rectangle(50, 50, 200, 100);
            using (Pen перо = new Pen(цветПера, 3))
            {
                перо.DashStyle = стильШтриха;
                g.DrawRectangle(перо, прямоугольник);
            }

            using (LinearGradientBrush градиент = new LinearGradientBrush(
                прямоугольник, цветКисти, Color.Yellow, 45f))
            {
                g.FillRectangle(градиент, прямоугольник);
            }

            Point[] точкиКривой = new Point[]
            {
                new Point(300, 50),
                new Point(350, 100),
                new Point(400, 50),
                new Point(450, 100),
                new Point(500, 50)
            };

            using (Pen перо = new Pen(Color.DarkBlue, 2))
            {
                перо.DashStyle = стильШтриха;
                g.DrawClosedCurve(перо, точкиКривой);
            }

            using (TextureBrush текстура = new TextureBrush(СоздатьТекстурноеИзображение()))
            {
                g.FillClosedCurve(текстура, точкиКривой);
            }

            using (Pen перо = new Pen(Color.Green, 3))
            {
                перо.DashStyle = стильШтриха;
                g.DrawBezier(перо,
                    new Point(50, 200),
                    new Point(150, 250),
                    new Point(250, 150),
                    new Point(350, 200));
            }

            string многострочныйТекст = "Это пример многострочного текста.\nВторая строка текста.\nТретья строка с разными словами.";
            RectangleF областьТекста = new RectangleF(50, 250, 200, 100);
            using (SolidBrush кисть = new SolidBrush(Color.DarkRed))
            {
                g.DrawString(многострочныйТекст, шрифтТекста, кисть, областьТекста);
            }

            if (модифицированноеИзображение != null)
            {
                g.DrawImage(модифицированноеИзображение, new Point(400, 400));
                g.DrawString("Модифицированное изображение",
                    new Font("Arial", 10),
                    Brushes.Black, 400, 570);
            }

            if (рисоватьПоЩелчку && местоЗвезды != Point.Empty)
            {
                НарисоватьЗвезду(g, местоЗвезды);
            }
        }

        private Bitmap СоздатьТекстурноеИзображение()
        {
            Bitmap текстура = new Bitmap(20, 20);
            using (Graphics g = Graphics.FromImage(текстура))
            {
                g.FillRectangle(Brushes.LightBlue, 0, 0, 10, 10);
                g.FillRectangle(Brushes.LightYellow, 10, 0, 10, 10);
                g.FillRectangle(Brushes.LightYellow, 0, 10, 10, 10);
                g.FillRectangle(Brushes.LightBlue, 10, 10, 10, 10);
            }
            return текстура;
        }

        private void НарисоватьЗвезду(Graphics g, Point место)
        {
            GraphicsPath путьЗвезды = new GraphicsPath();
            PointF[] точкиЗвезды = new PointF[10];
            double внешнийРадиус = 30;
            double внутреннийРадиус = 15;
            double угол = Math.PI / 2.0;
            double приращениеУгла = Math.PI / 10.0;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    точкиЗвезды[i] = new PointF(
                        (float)(внешнийРадиус * Math.Cos(угол)) + место.X,
                        (float)(внешнийРадиус * Math.Sin(угол)) + место.Y);
                }
                else
                {
                    точкиЗвезды[i] = new PointF(
                        (float)(внутреннийРадиус * Math.Cos(угол)) + место.X,
                        (float)(внутреннийРадиус * Math.Sin(угол)) + место.Y);
                }
                угол += приращениеУгла;
            }
            путьЗвезды.AddPolygon(точкиЗвезды);

            using (Pen перо = new Pen(Color.Red, 2))
            using (SolidBrush кисть = new SolidBrush(Color.Yellow))
            {
                g.FillPath(кисть, путьЗвезды);
                g.DrawPath(перо, путьЗвезды);
            }
        }

        private void кнопкаЦветПера_Click(object sender, EventArgs e)
        {
            ColorDialog диалогЦвета = new ColorDialog();
            if (диалогЦвета.ShowDialog() == DialogResult.OK)
            {
                цветПера = диалогЦвета.Color;
                this.Invalidate();
            }
        }

        private void кнопкаЦветКисти_Click(object sender, EventArgs e)
        {
            ColorDialog диалогЦвета = new ColorDialog();
            if (диалогЦвета.ShowDialog() == DialogResult.OK)
            {
                цветКисти = диалогЦвета.Color;
                this.Invalidate();
            }
        }

        private void кнопкаШрифт_Click(object sender, EventArgs e)
        {
            FontDialog диалогШрифта = new FontDialog();
            if (диалогШрифта.ShowDialog() == DialogResult.OK)
            {
                шрифтТекста = диалогШрифта.Font;
                this.Invalidate();
            }
        }

        private void комбоСтильШтриха_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (комбоСтильШтриха.SelectedItem.ToString())
            {
                case "Solid": стильШтриха = DashStyle.Solid; break;
                case "Dash": стильШтриха = DashStyle.Dash; break;
                case "Dot": стильШтриха = DashStyle.Dot; break;
                case "DashDot": стильШтриха = DashStyle.DashDot; break;
                case "DashDotDot": стильШтриха = DashStyle.DashDotDot; break;
            }
            this.Invalidate();
        }

        private void кнопкаЗагрузитьИзображение_Click(object sender, EventArgs e)
        {
            диалогОткрытьФайл.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            диалогОткрытьФайл.Title = "Выберите изображение";

            if (диалогОткрытьФайл.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    загруженноеИзображение = Image.FromFile(диалогОткрытьФайл.FileName);
                    картинка1.Image = загруженноеИзображение;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
                }
            }
        }

        private void списокРежимОтображения_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (списокРежимОтображения.SelectedItem.ToString())
            {
                case "Normal": картинка1.SizeMode = PictureBoxSizeMode.Normal; break;
                case "StretchImage": картинка1.SizeMode = PictureBoxSizeMode.StretchImage; break;
                case "AutoSize": картинка1.SizeMode = PictureBoxSizeMode.AutoSize; break;
                case "CenterImage": картинка1.SizeMode = PictureBoxSizeMode.CenterImage; break;
                case "Zoom": картинка1.SizeMode = PictureBoxSizeMode.Zoom; break;
            }
        }

        private void кнопкаРисоватьПоЩелчку_Click(object sender, EventArgs e)
        {
            рисоватьПоЩелчку = !рисоватьПоЩелчку;
            кнопкаРисоватьПоЩелчку.Text = рисоватьПоЩелчку ?
                "Отключить рисование по щелчку" :
                "Рисовать фигуру по щелчку";

            if (!рисоватьПоЩелчку)
            {
                местоЗвезды = Point.Empty;
                this.Invalidate();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (рисоватьПоЩелчку)
            {
                местоЗвезды = e.Location;
                this.Invalidate();
            }
        }

        private void кнопкаМодифицироватьИзображение_Click(object sender, EventArgs e)
        {
            if (загруженноеИзображение != null)
            {
                Bitmap оригинал = new Bitmap(загруженноеИзображение);
                модифицированноеИзображение = ИнвертироватьИзображение(оригинал);
                ПоказатьДвойнуюБуферизацию();
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Сначала загрузите изображение!");
            }
        }

        private Bitmap ИнвертироватьИзображение(Bitmap оригинал)
        {
            Bitmap инвертированное = new Bitmap(оригинал.Width, оригинал.Height);

            for (int x = 0; x < оригинал.Width; x++)
            {
                for (int y = 0; y < оригинал.Height; y++)
                {
                    Color исходныйЦвет = оригинал.GetPixel(x, y);
                    Color инвертированныйЦвет = Color.FromArgb(
                        255 - исходныйЦвет.R,
                        255 - исходныйЦвет.G,
                        255 - исходныйЦвет.B);
                    инвертированное.SetPixel(x, y, инвертированныйЦвет);
                }
            }
            return инвертированное;
        }

        private void ПоказатьДвойнуюБуферизацию()
        {
            Bitmap буфер = new Bitmap(300, 200);
            using (Graphics gBuffer = Graphics.FromImage(буфер))
            {
                Random случайный = new Random();
                gBuffer.Clear(Color.White);

                for (int i = 0; i < 1000; i++)
                {
                    Color цветЛинии = Color.FromArgb(
                        случайный.Next(255),
                        случайный.Next(255),
                        случайный.Next(255));

                    using (Pen перо = new Pen(цветЛинии, 1))
                    {
                        gBuffer.DrawLine(перо,
                            случайный.Next(буфер.Width),
                            случайный.Next(буфер.Height),
                            случайный.Next(буфер.Width),
                            случайный.Next(буфер.Height));
                    }
                }

                картинка1.Image = буфер;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}