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

namespace TextCryptor_WPF
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

        private void btnEnc_Click(object sender, RoutedEventArgs e)
        {
            string input = new TextRange(txtInput.Document.ContentStart, txtInput.Document.ContentEnd).Text;
            txtOutput.Document.Blocks.Clear();
            txtOutput.Document.Blocks.Add(new Paragraph(new Run(MainClass.Encrypt(input, 6))));
        }

        private void btnCopy_Click(object sender, RoutedEventArgs e)
        {
            string text = new TextRange(txtOutput.Document.ContentStart, txtOutput.Document.ContentEnd).Text;
            Clipboard.SetText(text);
        }

        private void btnDc_Click(object sender, RoutedEventArgs e)
        {
            string input = new TextRange(txtInput.Document.ContentStart, txtInput.Document.ContentEnd).Text;
            txtOutput.Document.Blocks.Clear();
            txtOutput.Document.Blocks.Add(new Paragraph(new Run(MainClass.Decrypt(input, 6))));
        }
    }
}
