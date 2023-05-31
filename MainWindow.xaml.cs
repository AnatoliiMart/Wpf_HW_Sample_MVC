using System;
using System.Windows;
using Wpf_HW_Sample_MVC.Models;

namespace Wpf_HW_Sample_MVC
{
    public partial class MainWindow : Window
    {
        private readonly Controller _controller = new Controller();


        public MainWindow() => InitializeComponent();


        private void Button_Save_Click(object sender, EventArgs e)
        {
            _controller.AddPersonToDB(textBox_Name.Text, int.Parse(textBox_Age.Text));
            textBox_Age.Text = string.Empty;
            textBox_Name.Text = string.Empty;
        }

        private void Button_Show_Click(object sender, EventArgs e) => Print();

        private void Button_Search_Click(object sender, EventArgs e)
        {

            listBox_SavedItems.Items.Clear();

            foreach (var item in _controller.SearchPersons(textBox_SearchName.Text))
                listBox_SavedItems.Items.Add(item);
        }


        private void DeleteAllToolStripMenuItem_Click(object sender, EventArgs e) => listBox_SavedItems.Items.Clear();

        private void DeleteSelectedItemMenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _controller.Delete((Person)listBox_SavedItems.SelectedItem);
                Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Print()
        {
            listBox_SavedItems.Items.Clear();

            foreach (var item in _controller.GetAll())
                listBox_SavedItems.Items.Add(item);
        }
    }
}
