using System;
using System.Windows;

namespace TestBindingCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Temp foo;
        Random rng;

        public MainWindow()
        {
            InitializeComponent();
            rng = new Random();
            foo = new Temp();
            foo.Num = rng.Next(0, 100);
            foo.FloatWithConverter = rng.NextDouble() * 100d;
            foo.FloatWithFormatting = rng.NextDouble() * 100d;
            this.DataContext = foo;
        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {
            foo.Num = rng.Next(0, 100);
            MessageBox.Show("Num is " + foo.Num);
            foo.FloatWithConverter = rng.NextDouble() * 100d;
            foo.FloatWithFormatting = rng.NextDouble() * 100d;
        }
    }
}
