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

namespace ExoCalculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MemoryButton_Click(object sender, RoutedEventArgs e)
        {            
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Bouton Mémoire pressé...");
            stringBuilder.AppendLine($"OrignalSource Content : {(e.OriginalSource as Button)?.Content}");
            MessageBox.Show(stringBuilder.ToString());
            e.Handled = true;
        }

        private void NumericalButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Bouton numérique pressé...");
            stringBuilder.AppendLine($"OrignalSource Content : {(e.OriginalSource as Button)?.Content}");
            MessageBox.Show(stringBuilder.ToString());
            e.Handled = true;
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Bouton opération pressé...");
            stringBuilder.AppendLine($"OrignalSource Content : {(e.OriginalSource as Button)?.Content}");
            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
