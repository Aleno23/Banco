using Presentacion.ServiceReferenceBanco;
using Presentacion.Vistas.Empleado;
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
    /// Lógica de interacción para Empleado.xaml
    /// </summary>
    public partial class Empleado : Window
    {
        private EmpleadoViewModel model;

        public Empleado()
        {
            InitializeComponent();
            model = new EmpleadoViewModel();
            DataContext = model;
        }
    }
}
