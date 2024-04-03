using System;
using System.Collections.Generic;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace TestGenerator
{
    public partial class MainWindow : Window
    {
        private readonly Test currentTest;
        private readonly string authorizationCode;

        public int TestDataDeserializer { get; }

        public MainWindow()
        {
            currentTest = TestDataDeserializer.Deserialize();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void StartTestButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentTest == null)
            {
                ShowNoTestPage();
            }
            else
            {
                ShowTestPage();
            }
        }

        private void EditTestButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredCode = "введенный_пароль";

            if (enteredCode == authorizationCode)
            {
                ShowEditTestPage();
            }
            else
            {
                MessageBox.Show("Неправильный пароль!");
            }
        }

        private void ShowNoTestPage()
        {
        }

        private void ShowTestPage()
        {
        }

        private void ShowEditTestPage()
        {
        }
    }

    internal class Test
    {
    }
}
