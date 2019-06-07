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
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para Funciones.xaml
    /// </summary>
    public partial class Funciones : Window
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void Clientes(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();

            this.Close();

         
        }

        private void Empleados(object sender, RoutedEventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Show();

            this.Close();
          
        }

        private void Cuentas(object sender, RoutedEventArgs e)
        {
            Cuentas cuentas = new Cuentas();
            cuentas.Show();

            this.Close();
        }

        private void Transacciones(object sender, RoutedEventArgs e)
        {
            Transacciones transacciones = new Transacciones();
            transacciones.Show();

            this.Close();
        }
    }
}
