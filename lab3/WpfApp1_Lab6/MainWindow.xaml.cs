using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1_Lab6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // ComboBox заполняется программно
            comboSubject.Items.Add("Студент");
            comboSubject.Items.Add("Преподаватель");
            comboSubject.Items.Add("Ученик");
        }

        // Построение предложения
        private void BuildSentence_Click(object sender, RoutedEventArgs e)
        {
            if (comboSubject.SelectedItem == null || listVerb.SelectedItem == null)
                return;

            string subject = comboSubject.SelectedItem.ToString();
            string verb = listVerb.SelectedItem.ToString();

            string obj = "";

            // Обход RadioButton через for (по варианту)
            for (int i = 0; i < radioPanel.Children.Count; i++)
            {
                if (radioPanel.Children[i] is RadioButton rb && rb.IsChecked == true)
                {
                    obj = rb.Content.ToString();
                    break;
                }
            }

            labelResult.Content = $"{subject} {verb} {obj}";
        }

        // Добавить слово
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textInput.Text))
                listVerb.Items.Add(textInput.Text);
        }

        // Изменить слово
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (listVerb.SelectedIndex >= 0)
                listVerb.Items[listVerb.SelectedIndex] = textInput.Text;
        }

        // Удалить слово
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (listVerb.SelectedIndex >= 0)
                listVerb.Items.RemoveAt(listVerb.SelectedIndex);
        }

        // Проверка ввода (только буквы)
        private void TextInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsLetter(e.Text, 0))
                e.Handled = true;
        }
    }
}
