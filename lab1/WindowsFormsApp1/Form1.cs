using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            {
                // 1. Заполнение ComboBox (существительные по теме Математика) с помощью Add()
                // Используем BeginUpdate() и EndUpdate() для оптимизации (требование варианта I-A)
                comboBoxNoun.BeginUpdate(); // Начинаем пакетное обновление (предотвращает мигание)
                comboBoxNoun.Items.Clear(); // Очищаем на случай, если что-то было
                comboBoxNoun.Items.Add("Математик");
                comboBoxNoun.Items.Add("Студент");
                comboBoxNoun.Items.Add("Ученый");
                comboBoxNoun.Items.Add("Учитель");
                comboBoxNoun.Items.Add("Алгоритм");
                comboBoxNoun.EndUpdate(); // Заканчиваем пакетное обновление, отрисовываем все сразу
                comboBoxNoun.SelectedIndex = 0; // Выбираем первый элемент по умолчанию

                comboBoxNoun.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBoxNoun.AutoCompleteSource = AutoCompleteSource.ListItems;

                // 2. Заполнение ListBox (глаголы)
                // Для ListBox также используем BeginUpdate/EndUpdate для единообразия
                listBoxVerb.BeginUpdate();
                listBoxVerb.Items.Clear();
                listBoxVerb.Items.Add("доказывает");
                listBoxVerb.Items.Add("решает");
                listBoxVerb.Items.Add("изучает");
                listBoxVerb.Items.Add("формулирует");
                listBoxVerb.Items.Add("анализирует");
                listBoxVerb.EndUpdate();
                listBoxVerb.SelectedIndex = 0; // Выбираем первый элемент по умолчанию

                // 3. Для GroupBox с RadioButton ничего заполнять не нужно,
                // мы уже задали Text через дизайнер. Выберем первый переключатель.
                if (groupBoxSecondNoun.Controls.Count > 0)
                {
                    // Найдем первый RadioButton и выберем его
                    foreach (Control ctrl in groupBoxSecondNoun.Controls)
                    {
                        if (ctrl is RadioButton)
                        {
                            ((RadioButton)ctrl).Checked = true;
                            break;
                        }
                    }
                }
            }
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            string additionalWord = "";
            if (checkBoxOption.Checked)
            {
                additionalWord = "активно "; // Пример
            }
            {
                // 1. Получаем данные из ComboBox и ListBox
                string noun1 = comboBoxNoun.SelectedItem?.ToString(); // Существительное 1
                string verb = listBoxVerb.SelectedItem?.ToString(); // Глагол

                // 2. Получаем данные из GroupBox с RadioButton с помощью цикла FOREACH
                string noun2 = ""; // Существительное 2 (из RadioButton)

                // Цикл foreach по всем элементам управления внутри GroupBox
                foreach (Control ctrl in groupBoxSecondNoun.Controls)
                {
                    // Проверяем, является ли этот элемент RadioButton
                    if (ctrl is RadioButton)
                    {
                        RadioButton rb = (RadioButton)ctrl; // Приводим тип Control к RadioButton
                        if (rb.Checked) // Если этот переключатель выбран
                        {
                            noun2 = rb.Text; // Берем его текст
                            break; // Выходим из цикла, т.к. выбран только один
                        }
                    }
                }

                // 3. Собираем предложение (можно добавить точки, пробелы для красоты)
                if (!string.IsNullOrEmpty(noun1) && !string.IsNullOrEmpty(verb) && !string.IsNullOrEmpty(noun2))
                {
                    // Пример: "Математик доказывает теорему."
                    // (В реальности нужно согласовать падежи, но для лабораторной сойдет)
                    labelResult.Text = $"{noun1} {additionalWord}{verb} {noun2}.";
                }
                else
                {
                    labelResult.Text = "Выберите все элементы!";
                }
            }
        }

        private void buttonAddVerb_Click(object sender, EventArgs e)
        {
         
            {
                string newVerb = textBoxVerbEdit.Text.Trim();
                if (!string.IsNullOrEmpty(newVerb))
                {
                    // Добавляем новый глагол в ListBox
                    listBoxVerb.Items.Add(newVerb);
                    textBoxVerbEdit.Clear(); // Очищаем поле ввода
                }
                else
                {
                    MessageBox.Show("Введите глагол в текстовое поле.");
                }
            }
        }

        private void buttonUpdateVerb_Click(object sender, EventArgs e)
        {
            {
                if (listBoxVerb.SelectedIndex != -1) // Если что-то выбрано
                {
                    string updatedVerb = textBoxVerbEdit.Text.Trim();
                    if (!string.IsNullOrEmpty(updatedVerb))
                    {
                        // Меняем текст выбранного элемента
                        listBoxVerb.Items[listBoxVerb.SelectedIndex] = updatedVerb;
                        textBoxVerbEdit.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Введите новый текст для глагола.");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите глагол в списке для изменения.");
                }
            }
        }

        private void buttonDeleteVerb_Click(object sender, EventArgs e)
        {
            {
                if (listBoxVerb.SelectedIndex != -1)
                {
                    // Удаляем выбранный элемент
                    listBoxVerb.Items.RemoveAt(listBoxVerb.SelectedIndex);
                    textBoxVerbEdit.Clear();
                }
                else
                {
                    MessageBox.Show("Выберите глагол в списке для удаления.");
                }
            }
        }

        private void listBoxVerb_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (listBoxVerb.SelectedIndex != -1)
                {
                    // Копируем текст выбранного глагола в TextBox для редактирования
                    textBoxVerbEdit.Text = listBoxVerb.SelectedItem.ToString();
                }
            }
        }

        private void checkBoxOption_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddRadio_Click(object sender, EventArgs e)
        {
            {
                string newNoun = textBoxNewNoun.Text.Trim();

                if (!string.IsNullOrEmpty(newNoun))
                {
                    // Создаем новый RadioButton динамически
                    RadioButton newRadioButton = new RadioButton();

                    // Устанавливаем свойства
                    newRadioButton.Text = newNoun;
                    newRadioButton.AutoSize = true; // Чтобы размер подстраивался под текст

                    // Рассчитываем положение (в конец)
                    int topPosition = 20; // Начальное отступ сверху

                    // Если в GroupBox уже есть другие RadioButton, размещаем ниже последнего
                    if (groupBoxSecondNoun.Controls.Count > 0)
                    {
                        // Находим максимальную координату Y среди существующих RadioButton
                        int maxY = 0;
                        foreach (Control ctrl in groupBoxSecondNoun.Controls)
                        {
                            if (ctrl is RadioButton && ctrl.Top > maxY)
                            {
                                maxY = ctrl.Top;
                            }
                        }
                        // Размещаем на 25 пикселей ниже самого нижнего
                        topPosition = maxY + 25;
                    }

                    newRadioButton.Location = new System.Drawing.Point(10, topPosition);

                    // Добавляем в GroupBox
                    groupBoxSecondNoun.Controls.Add(newRadioButton);

                    // Очищаем поле ввода
                    textBoxNewNoun.Clear();
                }
                else
                {
                    MessageBox.Show("Введите слово для нового переключателя.");
                }
            }
        }

        private void buttonAddToCombo_Click(object sender, EventArgs e)
        {
            {
                string newItem = comboBoxNoun.Text.Trim();

                if (!string.IsNullOrEmpty(newItem))
                {
                    // Проверяем, нет ли уже такого элемента
                    if (!comboBoxNoun.Items.Contains(newItem))
                    {
                        comboBoxNoun.Items.Add(newItem);
                        comboBoxNoun.Text = ""; // Очищаем текстовое поле
                    }
                    else
                    {
                        MessageBox.Show("Такой элемент уже существует.");
                    }
                }
                else
                {
                    MessageBox.Show("Введите значение в поле ComboBox.");
                }
            }
        }

        private void buttonUpdateCombo_Click(object sender, EventArgs e)
        {
            {
                if (comboBoxNoun.SelectedIndex != -1)
                {
                    string updatedItem = comboBoxNoun.Text.Trim();

                    if (!string.IsNullOrEmpty(updatedItem))
                    {
                        // Заменяем выбранный элемент
                        comboBoxNoun.Items[comboBoxNoun.SelectedIndex] = updatedItem;
                        comboBoxNoun.Text = ""; // Очищаем поле
                    }
                    else
                    {
                        MessageBox.Show("Введите новое значение.");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите элемент для изменения.");
                }
            }
        }

        private void buttonDeleteFromCombo_Click(object sender, EventArgs e)
        {
            {
                if (comboBoxNoun.SelectedIndex != -1)
                {
                    // Удаляем выбранный элемент
                    comboBoxNoun.Items.RemoveAt(comboBoxNoun.SelectedIndex);
                    comboBoxNoun.Text = ""; // Очищаем поле
                }
                else
                {
                    MessageBox.Show("Выберите элемент для удаления.");
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Alt+E - Добавление в ComboBox
            if (e.Alt && e.KeyCode == Keys.E)
            {
                buttonAddToCombo_Click(sender, e);
                e.Handled = true; // Говорим, что обработали событие
            }

            // Можно добавить другие клавиши для других кнопок
            // Например, F2 для изменения
            if (e.KeyCode == Keys.F2)
            {
                buttonUpdateCombo_Click(sender, e);
                e.Handled = true;
            }

            // Delete для удаления
            if (e.KeyCode == Keys.Delete)
            {
                buttonDeleteFromCombo_Click(sender, e);
                e.Handled = true;
            }
        }

        private void comboBoxNoun_TextUpdate(object sender, EventArgs e)
        {

        }

        private void comboBoxNoun_DropDown(object sender, EventArgs e)
        {
            {
                // Просто показываем сообщение - этого достаточно для проверки
                MessageBox.Show("Событие DropDown сработало! Список раскрывается.",
                               "Проверка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }

        }
    }
}
