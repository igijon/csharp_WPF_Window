using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
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
    /// Lógica de interacción para OtherWindow.xaml
    /// </summary>
    public partial class OtherWindow : Window
    {
        public OtherWindow()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            //Estos métodos sirven para activar o desactivar contenidos si la ventana no está activa
            Debug.WriteLine("Entré a ACTIVATED");
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            Debug.WriteLine("Entré a DEACTIVATED");
        }
    }
}
