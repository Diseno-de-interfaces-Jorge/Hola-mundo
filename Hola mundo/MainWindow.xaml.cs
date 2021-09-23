using System.Windows;
using System.Windows.Media;

namespace Hola_mundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MensajeTxtBlock.Text = "Hola " + MensajeTextBox.Text;
            MensajeTxtBlock.Foreground = Brushes.BlueViolet;
        }
    }
}
