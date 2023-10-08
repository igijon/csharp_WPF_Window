using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace ActivateWindow
{
    /// <summary>
    /// Lógica de interacción para CustomMediaPlayerWindow.xaml
    /// </summary>
    public partial class CustomMediaPlayerWindow : Window
    {
        public CustomMediaPlayerWindow()
        {
            InitializeComponent();
            MessageBox.Show(Directory.GetCurrentDirectory());
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            mediaElement.Play();
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            mediaElement.Pause();
        }
    }
}
