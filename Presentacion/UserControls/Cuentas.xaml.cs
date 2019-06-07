using Presentacion.Interfaces;
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

namespace Presentacion.UserControls
{
    /// <summary>
    /// Interaction logic for Cuentas.xaml
    /// </summary>
    public partial class Cuentas : UserControl
    {
        private readonly IMainWindowsService _mainWindowsService;
        public Cuentas(IMainWindowsService mainWindowsService)
        {
            InitializeComponent();
            _mainWindowsService = mainWindowsService;
        }
    }
}
