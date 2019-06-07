using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using Presentacion.ServiceReferenceBanco;
using System.Windows;
using System.Windows.Input;
using Presentacion.DTOs;

namespace Presentacion.ViewModel
{
    public class ClienteViewModel : BindingBase
    {
        public ClienteViewModel()
        {

        }

        private ClienteDTO _cliente = new ClienteDTO();

        public ClienteDTO Cliente
        {
            get { return _cliente; }
            set { SetProperty(ref _cliente, value); }
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
            return !string.IsNullOrEmpty(Cliente.Cedula);
        }



        internal void Registrar()
        {
            Service1Client client = new Service1Client();

            try
            {
                client.RegistrarCliente(Cliente.Cedula, Cliente.Nombre, Cliente.Apellido, Cliente.Telefono,
                Cliente.Direccion, Cliente.Celular);

                MessageBox.Show("Cliente registrado corectamente");

                Cliente.Cedula = "";
                Cliente.Nombre = "";
                Cliente.Apellido = "";
                Cliente.Telefono = "";
                Cliente.Direccion = "";
                Cliente.Celular = "";
            }
            catch
            {
                MessageBox.Show("Error al registrar el cliente");
                Cliente.Cedula = "";
                Cliente.Nombre = "";
                Cliente.Apellido = "";
                Cliente.Telefono = "";
                Cliente.Direccion = "";
                Cliente.Celular = "";
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
            return !string.IsNullOrEmpty(Cliente.Cedula);
        }

        internal void Buscar()
        {
            Service1Client client = new Service1Client();

            try
            {
                string[] vs = client.BuscarCliente(Cliente.Cedula);

                Cliente.Nombre = vs[1];
                Cliente.Apellido = vs[2];
                Cliente.Telefono = vs[3];
                Cliente.Direccion = vs[3];
                Cliente.Celular = vs[5];
            }
            catch
            {
                MessageBox.Show("Error al buscar el cliente");

                Cliente.Cedula = "";
                Cliente.Nombre = "";
                Cliente.Apellido = "";
                Cliente.Telefono = "";
                Cliente.Direccion = "";
                Cliente.Celular = "";
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
            return !string.IsNullOrEmpty(Cliente.Cedula);
        }

        internal void Actualizar()
        {
            Service1Client client = new Service1Client();

            try
            {
                client.ActualizarCliente(Cliente.Cedula, Cliente.Nombre, Cliente.Apellido, Cliente.Telefono,
               Cliente.Direccion, Cliente.Celular);

                MessageBox.Show("El cliente ha sido actualizado correctamente");

                Cliente.Cedula = "";
                Cliente.Nombre = "";
                Cliente.Apellido = "";
                Cliente.Telefono = "";
                Cliente.Direccion = "";
                Cliente.Celular = "";
            }
            catch
            {
                MessageBox.Show("Error al actualizar el cliente");

                Cliente.Cedula = "";
                Cliente.Nombre = "";
                Cliente.Apellido = "";
                Cliente.Telefono = "";
                Cliente.Direccion = "";
                Cliente.Celular = "";
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
            return !string.IsNullOrEmpty(Cliente.Cedula);
        }

        internal void Borrar()
        {
            Service1Client client = new Service1Client();

            try
            {
                client.BorrarCliente(Cliente.Cedula);

                MessageBox.Show("El cliente ha sido borrado correctamente");

                Cliente.Cedula = "";
                Cliente.Nombre = "";
                Cliente.Apellido = "";
                Cliente.Telefono = "";
                Cliente.Direccion = "";
                Cliente.Celular = "";
            }
            catch
            {
                MessageBox.Show("Error al intentar borrar el cliente");

                Cliente.Cedula = "";
                Cliente.Nombre = "";
                Cliente.Apellido = "";
                Cliente.Telefono = "";
                Cliente.Direccion = "";
                Cliente.Celular = "";
            }

        }

    }
}
