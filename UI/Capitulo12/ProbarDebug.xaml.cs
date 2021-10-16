using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Capitulo10y12.UI.Capitulo12
{
    /// <summary>
    /// Interaction logic for ProbarDebug.xaml
    /// </summary>
    public partial class ProbarDebug : Window
    {
        public ProbarDebug()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, RoutedEventArgs e)
        {
            Mostrar();
        }

        
        public int Calcular()
        {
            Debug.WriteLine("Entrando a la funcion Calcular()");
            int factorial = 1;

            for (int i = 1; i < 5; i++)
            {
                factorial *= i + 1;
            }


            Debug.WriteLine("Saliendo de la funcion Calcular()");
            return factorial;
        }

        public void Mostrar()
        {
            Debug.WriteLine("Entrando a la funcion Mostrar()");
            FactorialTextBox.Text = "5";

            for (int i = 4; i > 0; i--)
            {
                FactorialTextBox.Text += $" x {i}";
            }

            FactorialTextBox.Text += $" = {Calcular()}i";
            Debug.WriteLine("Saliendo de la funcion Mostrar()");
        }
    }
}
