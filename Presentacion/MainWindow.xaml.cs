using Presentacion.Interfaces;
using Presentacion.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Presentacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindowsService
    {
        private readonly UserControls.Empleados empleado;
        private readonly UserControls.Clientes clientes ;
        private readonly UserControls.Cuentas cuentas ;
        private readonly UserControls.Transacciones transacciones;

        public MainWindow()
        {
            InitializeComponent();
            cuentas = new UserControls.Cuentas(this);
            empleado = new UserControls.Empleados(this);
            clientes = new UserControls.Clientes(this);
            transacciones = new UserControls.Transacciones(this);
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (Action)delegate ()
            {
                lblTime.Content = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            });
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginLayer.Visibility = Visibility.Collapsed;
            StatusBar.Visibility = Visibility.Visible;
            WelcomeLayer.Visibility = Visibility.Visible;
            Menu.Visibility = Visibility.Visible;
            RemoveControls();
            ContentLayer.Visibility = Visibility.Visible;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginLayer.Visibility = Visibility.Visible;
            StatusBar.Visibility = Visibility.Collapsed;
            Menu.Visibility = Visibility.Collapsed;
            ContentLayer.Visibility = Visibility.Collapsed;
        }

        private void Empleados_Click(object sender, RoutedEventArgs e)
        {
            WelcomeLayer.Visibility = Visibility.Collapsed;
            RemoveControls();
            ContentLayer.Children.Add(empleado);
            lbStatus.Text = "EMPLEADOS";
        }

        private void RemoveControls()
        {
            List<UserControl> controls = ContentLayer.Children.OfType<UserControl>().ToList();
            controls.ForEach(x => ContentLayer.Children.Remove(x));
        }

        private void Clientes_Click(object sender, RoutedEventArgs e)
        {
            WelcomeLayer.Visibility = Visibility.Collapsed;
            RemoveControls();
            ContentLayer.Children.Add(clientes);
            lbStatus.Text = "CLIENTES";
        }

        private void Cuentas_Click(object sender, RoutedEventArgs e)
        {
            WelcomeLayer.Visibility = Visibility.Collapsed;
            RemoveControls();
            ContentLayer.Children.Add(cuentas);
            lbStatus.Text = "CUENTAS";
        }

        private void Transacciones_Click(object sender, RoutedEventArgs e)
        {
            WelcomeLayer.Visibility = Visibility.Collapsed;
            RemoveControls();
            ContentLayer.Children.Add(transacciones);
            lbStatus.Text = "TRANSACCIONES";
        }

        private void Inicio_Click(object sender, RoutedEventArgs e)
        {
            WelcomeLayer.Visibility = Visibility.Visible;          
            RemoveControls();
        }

        public void ActualizarBarraDeEstado(string action)
        {
            lbAction.Text = action;
        }

        public void ChangeStatusColor(Brush color)
        {
            StatusBar.Background = color;
        }

        private void Container_Click(object sender, RoutedEventArgs e)
        {
            WelcomeLayer.Visibility = Visibility.Collapsed;
            RemoveControls();
            ContentLayer.Children.Add(new ContainerUserControl());
            
        }
    }
}
