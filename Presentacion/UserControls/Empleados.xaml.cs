using Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentacion.UserControls
{
    /// <summary>
    /// Interaction logic for Empleados.xaml
    /// </summary>
    public partial class Empleados : UserControl
    {

        private readonly IMainWindowsService _mainWindowsService;

        public Empleados(IMainWindowsService mainWindowsService)
        {
            InitializeComponent();
            _mainWindowsService = mainWindowsService;
            Loaded += Empleados_Loaded;
        }

        private async void Empleados_Loaded(object sender, RoutedEventArgs e)
        {
            _mainWindowsService.ActualizarBarraDeEstado("CARGANDO EMPLEADOS...");
            dgEmpleados.ItemsSource = new List<EmpleadoDTO>();
            brBusy.Visibility = Visibility.Visible;
            var employees = await Task.Run(() => CreateEmployees());
            dgEmpleados.ItemsSource = employees;
            brBusy.Visibility = Visibility.Collapsed;
            _mainWindowsService.ActualizarBarraDeEstado("FORMULARIO CARGADO EXITOSAMENTE");

        }

        private Task<List<EmpleadoDTO>> CreateEmployees()
        {
            var listEmpleados = new List<EmpleadoDTO>();

            var employee = new EmpleadoDTO
            {
                Nombre = "Diana",
                Usuario = "Diana123",
                Telefono = "3214545",
                Direccion = "Calle 123",
                Contraseña = "123",
                Celular = "321454589989",
                Cedula = "4255455",
                Cargo = "Empleada",
                Apellido = "Apellido"
            };

            Thread.Sleep(500);
            var employee1 = new EmpleadoDTO
            {
                Nombre = "Angela",
                Usuario = "Angela123",
                Telefono = "3214545",
                Direccion = "Calle 444",
                Contraseña = "555",
                Celular = "321454589989",
                Cedula = "4255455",
                Cargo = "Empleada",
                Apellido = "Cortes"
            };
            Thread.Sleep(500);

            var employee2 = new EmpleadoDTO
            {
                Nombre = "Marisol",
                Usuario = "Marisol123",
                Telefono = "3214545",
                Direccion = "Calle 8888",
                Contraseña = "777",
                Celular = "321454589989",
                Cedula = "4255455",
                Cargo = "Empleada",
                Apellido = "Velez"
            };

            var employee4 = new EmpleadoDTO
            {
                Nombre = "Natalia",
                Usuario = "Natalia123",
                Telefono = "3214545",
                Direccion = "Calle 9998",
                Contraseña = "444",
                Celular = "321454589989",
                Cedula = "4255455",
                Cargo = "Empleada",
                Apellido = "Apellido"
            };
            Thread.Sleep(500);

            var employee3 = new EmpleadoDTO
            {
                Nombre = "Franco",
                Usuario = "Franco123",
                Telefono = "3214545",
                Direccion = "Calle 9998",
                Contraseña = "444",
                Celular = "321454589989",
                Cedula = "4255455",
                Cargo = "Empleada",
                Apellido = "Apellido"
            };
            Thread.Sleep(1000);
            listEmpleados.Add(employee);
            listEmpleados.Add(employee1);
            listEmpleados.Add(employee2);
            listEmpleados.Add(employee3);
            listEmpleados.Add(employee4);

            return Task.FromResult(listEmpleados);
        }



        private void RbActualizar_Click(object sender, RoutedEventArgs e)
        {
            _mainWindowsService.ActualizarBarraDeEstado("ACTUALIZANDO EMPLEADO");
            _mainWindowsService.ChangeStatusColor(Brushes.DarkOrange);
            rbActualizar.IsEnabled = false;
            rbGuardar.IsEnabled = true;
            rbBuscar.IsEnabled = false;
            rbBorrar.IsEnabled = false;
            rbCancelar.IsEnabled = true;
            txtCedula.Focus();
            OpenPanel(grControles);
        }


        public void ClosePanel(Grid grid)
        {
            var da = new DoubleAnimation();
            da.From = 150;
            da.To = 0;
            da.Duration = new Duration(TimeSpan.FromMilliseconds(400));
            grid.BeginAnimation(HeightProperty, da);
        }

        public void OpenPanel(Grid grid)
        {
            var da = new DoubleAnimation();
            da.From = 0;
            da.To = 150;
            da.Duration = new Duration(TimeSpan.FromMilliseconds(400));
            grid.BeginAnimation(HeightProperty, da);
        }

        private void RbGuardar_Click(object sender, RoutedEventArgs e)
        {
            rbActualizar.IsEnabled = true;
            rbBuscar.IsEnabled = true;
            rbBorrar.IsEnabled = true;
            ClosePanel(grControles);
        }

        private void RbBuscar_Click(object sender, RoutedEventArgs e)
        {
            rbActualizar.IsEnabled = false;
            rbGuardar.IsEnabled = false;
            rbBuscar.IsEnabled = false;
            rbBorrar.IsEnabled = false;
            rbCancelar.IsEnabled = true;
            OpenPanel(grControles);
        }

        private void RbBorrar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¿Esta seguro de borrar el empleado?", "Atención", MessageBoxButton.YesNo, MessageBoxImage.Information);
        }

        private void RbCancelar_Click(object sender, RoutedEventArgs e)
        {
            _mainWindowsService.ActualizarBarraDeEstado("");
            _mainWindowsService.ChangeStatusColor(Brushes.DarkOrchid);
            ClosePanel(grControles);

            foreach (var textBox in grControles.Children.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }

            foreach (var passwordBox in grControles.Children.OfType<PasswordBox>())
            {
                passwordBox.Password = string.Empty;
            }


            rbActualizar.IsEnabled = true;
            rbBuscar.IsEnabled = true;
            rbBorrar.IsEnabled = true;
            rbCancelar.IsEnabled = false;
            rbGuardar.IsEnabled = false;
        }

        private void RbNew_Click(object sender, RoutedEventArgs e)
        {
            _mainWindowsService.ActualizarBarraDeEstado("Creando nuevo empleado");
            _mainWindowsService.ChangeStatusColor(Brushes.Green);
            OpenPanel(grControles);
            rbNew.IsEnabled = false;
            rbActualizar.IsEnabled = false;
            rbBuscar.IsEnabled = false;
            rbBorrar.IsEnabled = false;
            rbCancelar.IsEnabled = true;
            rbGuardar.IsEnabled = true;
        }
    }
}
