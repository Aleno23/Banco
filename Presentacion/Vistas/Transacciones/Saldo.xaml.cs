using Presentacion.ViewModel;
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

namespace Presentacion.Vistas.Transacciones
{
    /// <summary>
    /// Lógica de interacción para Saldo.xaml
    /// </summary>
    public partial class Saldo : Window
    {
        private TransaccionesViewModel model;
        public Saldo()
        {
            InitializeComponent();
            model = new TransaccionesViewModel();
            DataContext = model;
        }
    }
}
