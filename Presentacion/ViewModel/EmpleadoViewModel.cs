using Helpers;
using Presentacion.ServiceReferenceBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Presentacion.Vistas.Empleado
{
    public class EmpleadoViewModel : BindingBase
    {
        public EmpleadoViewModel()
        {

        }


        private EmpleadoDTO _empleado = new EmpleadoDTO();

        public EmpleadoDTO Empleado
        {
            get { return _empleado; }
            set { SetProperty(ref _empleado, value); }
        }

        private ICommand _loginCommand;


        public ICommand LoginCommand
        {

            get
            {

                if (_loginCommand == null)
                {

                    _loginCommand = new RelayCommand(param => Login(), CanExecuteLogin);
                }
                return _loginCommand;
            }
        }

        private bool CanExecuteLogin()
        {
            return !string.IsNullOrEmpty(Empleado.Usuario);
        }

        internal void Login()
        {
            Service1Client client = new Service1Client();
            

            try
            {


                string[] resultado = client.Ingresar(Empleado.Usuario, Empleado.Contraseña);

                Funciones f = new Funciones();
                f.Show();

                Empleado.Usuario = "";
                Empleado.Contraseña = "";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario o contreseña son invalidos");

                Empleado.Usuario = "";
                Empleado.Contraseña = "";
            }

        }



        private ICommand _registrarCommand;


        public ICommand RegistrarCommand
        {

            get
            {
                
                if (_registrarCommand == null)
                {
                   
                    _registrarCommand = new RelayCommand(param => Registrar(), CanExecuteRegistrar);
                }
                return _registrarCommand;
            }
        }

        private bool CanExecuteRegistrar()
        {
            return !string.IsNullOrEmpty(Empleado.Cedula );
        }


       
        internal void Registrar()
        {
            Service1Client client = new Service1Client();

       
            try
            {
                client.RegistrarEmpleado(Empleado.Cedula, Empleado.Nombre, Empleado.Apellido, Empleado.Telefono,
                Empleado.Direccion, Empleado.Celular, Empleado.Cargo, Empleado.Usuario, Empleado.Contraseña);

                MessageBox.Show("Empleado registrado corectamente");

                Empleado.Cedula = "";
                Empleado.Nombre = "";
                Empleado.Apellido = "";
                Empleado.Telefono = "";
                Empleado.Direccion = "";
                Empleado.Celular = "";
                Empleado.Cargo = "";
                Empleado.Usuario = "";
                Empleado.Contraseña = "";
            }
            catch
            {
                MessageBox.Show("Error al registrar el empleado");
                Empleado.Cedula = "";
                Empleado.Nombre = "";
                Empleado.Apellido = "";
                Empleado.Telefono = "";
                Empleado.Direccion = "";
                Empleado.Celular = "";
                Empleado.Cargo = "";
                Empleado.Usuario = "";
                Empleado.Contraseña = "";
            }

        }

        private ICommand _buscarCommand;

        public ICommand BuscarCommand
        {

            get
            {
                if (_buscarCommand == null)
                {

                    _buscarCommand = new RelayCommand(param => Buscar(), CanExecuteBuscar);
                }
                return _buscarCommand;
            }
        }

        private bool CanExecuteBuscar()
        {
            return !string.IsNullOrEmpty(Empleado.Cedula);
        }

        internal void   Buscar()
        {
            Service1Client client = new Service1Client();

            try
            {
                string[] vs = client.BuscarEmpleado(Empleado.Cedula);

                Empleado.Nombre = vs[1];
                Empleado.Apellido = vs[2];
                Empleado.Telefono = vs[3];
                Empleado.Direccion = vs[4];
                Empleado.Celular = vs[5];
                Empleado.Cargo = vs[6];
                Empleado.Usuario = vs[7];
                Empleado.Contraseña = vs[8];
            }
            catch
            {
                MessageBox.Show("Error al buscar el empleado");

                Empleado.Cedula = "";
                Empleado.Nombre = "";
                Empleado.Apellido = "";
                Empleado.Telefono = "";
                Empleado.Direccion = "";
                Empleado.Celular = "";
                Empleado.Cargo = "";
                Empleado.Usuario = "";
                Empleado.Contraseña = "";
            }
            
        }

        private ICommand _actualizarCommand;

        public ICommand ActualizarCommand
        {

            get
            {
                if (_actualizarCommand == null)
                {

                    _actualizarCommand = new RelayCommand(param => Actualizar(), CanExecuteActualizar);
                }
                return _actualizarCommand;
            }
        }

        private bool CanExecuteActualizar()
        {
            return !string.IsNullOrEmpty(Empleado.Cedula);
        }

        internal void Actualizar()
        {
            Service1Client client = new Service1Client();

            try
            {
                client.ActualizarEmpleado(Empleado.Cedula, Empleado.Nombre, Empleado.Apellido, Empleado.Telefono,
               Empleado.Direccion, Empleado.Celular, Empleado.Cargo, Empleado.Usuario, Empleado.Contraseña);

                MessageBox.Show("El empleado ha sido actualizado correctamente");

                Empleado.Cedula = "";
                Empleado.Nombre = "";
                Empleado.Apellido = "";
                Empleado.Telefono = "";
                Empleado.Direccion = "";
                Empleado.Celular = "";
                Empleado.Cargo = "";
                Empleado.Usuario = "";
                Empleado.Contraseña = "";
            }
            catch
            {
                MessageBox.Show("Error al actualizar el empleado");

                Empleado.Cedula = "";
                Empleado.Nombre = "";
                Empleado.Apellido = "";
                Empleado.Telefono = "";
                Empleado.Direccion = "";
                Empleado.Celular = "";
                Empleado.Cargo = "";
                Empleado.Usuario = "";
                Empleado.Contraseña = "";
            }

        }

        private ICommand _borrarCommand;

        public ICommand BorrarCommand
        {

            get
            {
                if (_borrarCommand == null)
                {

                    _borrarCommand = new RelayCommand(param => Borrar(), CanExecuteBorrar);
                }
                return _borrarCommand;
            }
        }

        private bool CanExecuteBorrar()
        {
            return !string.IsNullOrEmpty(Empleado.Cedula);
        }

        internal void Borrar()
        {
            Service1Client client = new Service1Client();

            try
            {
                client.BorrarEmpleado(Empleado.Cedula);

                MessageBox.Show("El empleado ha sido borrado correctamente");

                Empleado.Cedula = "";
                Empleado.Nombre = "";
                Empleado.Apellido = "";
                Empleado.Telefono = "";
                Empleado.Direccion = "";
                Empleado.Celular = "";
                Empleado.Cargo = "";
                Empleado.Usuario = "";
                Empleado.Contraseña = "";
            }
            catch
            {
                MessageBox.Show("Error al intentar borrar el empleado");

                Empleado.Cedula = "";
                Empleado.Nombre = "";
                Empleado.Apellido = "";
                Empleado.Telefono = "";
                Empleado.Direccion = "";
                Empleado.Celular = "";
                Empleado.Cargo = "";
                Empleado.Usuario = "";
                Empleado.Contraseña = "";
            }

        }


        private ICommand _cancelarCommand;

        public ICommand CancelarCommand
        {

            get
            {
                if (_cancelarCommand == null)
                {

                    _cancelarCommand = new RelayCommand(param => Cancelar());
                }
                return _cancelarCommand;
            }
        }

       
        internal void Cancelar()
        {
           
                Empleado.Usuario = "";
                Empleado.Contraseña = "";
            

        }


    }
}
