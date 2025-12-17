using System.Windows;
using System.Windows.Media;

namespace WpfApp1_Lab7
{
    public partial class MainWindow : Window
    {
        RotateTransform rotate = new RotateTransform(0);
        TranslateTransform move = new TranslateTransform(0, 0);

        public MainWindow()
        {
            InitializeComponent();

            TransformGroup group = new TransformGroup();
            group.Children.Add(rotate);
            group.Children.Add(move);

            rect.RenderTransform = group;
            rect.RenderTransformOrigin = new Point(0.5, 0.5);
        }

        private void Rotate_Click(object sender, RoutedEventArgs e)
        {
            rotate.Angle += 15;
        }

        private void Move_Click(object sender, RoutedEventArgs e)
        {
            move.X += 20;
        }
    }
}
