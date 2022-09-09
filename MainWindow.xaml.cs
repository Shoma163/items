using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //добавление в combobox
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length == 0) return;

            string newItem = textBox.Text.Trim();
            if (comboBox.Items.Contains(newItem))
            {
                MessageBox.Show("Данный элемент уже существует");
                return;
            }

            comboBox.Items.Add(textBox.Text.Trim());
            textBox.Text = "";
        }

        //удаление в combobox
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var rem = comboBox.SelectedItem;
            if (textBox.Text.Length == 0)
            {
                comboBox.Items.Remove(rem);
            };
            comboBox.Items.Remove(textBox.Text.Trim());
            textBox.Text = "";
        }
        
        //очистка combobox
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (comboBox.Items.Count == 0)
            {
                MessageBox.Show("ComboBox пуст");
                return;
            }

            comboBox.Items.Clear();
        }

        //удаление listbox
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            var rem = listBox.SelectedItem;
            listBox.Items.Remove(rem);

        }

        //очистка listbox
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("ComboBox пуст");
                return;
            }

            listBox.Items.Clear();
        }

        //перенести в listbox 
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedItem == null) 
                return;
            if (listBox.Items.Contains(comboBox.SelectedItem))
            {
                MessageBox.Show("Данный элемент уже существует");
                return;
            }
            else
            {
                listBox.Items.Add(comboBox.SelectedItem);
                comboBox.Items.Remove(comboBox.SelectedItem);
            }
            }

        //копировать
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedItem == null) return;
            if (comboBox.Items.Contains(listBox.SelectedIndex)) 
            {
                MessageBox.Show("Данный элемент уже существует");
                return;
            }
                var scan = comboBox.SelectedItem;
            listBox.Items.Add(scan);
            
           
        }

        //перенести в combobox
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem == null) return;
            if (comboBox.Items.Contains(listBox.SelectedItem))
            {
                MessageBox.Show("Данный элемент уже существует");
                return;
            }
            else
            {
                comboBox.Items.Add(listBox.SelectedItem);
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }
    }
}
