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
    public class CuentaViewModel : BindingBase
    {
        public CuentaViewModel()
        {

        }

        private CuentaDTO _cuenta = new CuentaDTO();

        public CuentaDTO Cuenta
        {
            get { return _cuenta; }
            set { SetProperty(ref _cuenta, value); }
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
            return !string.IsNullOrEmpty(Cuenta.Numero);
        }



        internal void Registrar()
        {
            Service1Client client = new Service1Client();

            try
            {
                client.RegistrarCuenta(Cuenta.Numero, Cuenta.Cedula, Cuenta.Nombre,Cuenta.Tipo);

                MessageBox.Show("Cuenta registrada corectamente");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Nombre = "";
                Cuenta.Tipo = "";
            }
            catch
            {
                MessageBox.Show("Error al registrar la cuenta");
                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Nombre = "";
                Cuenta.Tipo = "";
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
            return !string.IsNullOrEmpty(Cuenta.Numero);
        }

        internal void Buscar()
        {
            Service1Client client = new Service1Client();

            try
            {
                string[] vs = client.BuscarCuenta(Cuenta.Numero);

                Cuenta.Cedula = vs[0];
                Cuenta.Nombre = vs[1];
                Cuenta.Tipo = vs[2];
                
            }
            catch
            {
                MessageBox.Show("Error al buscar la cuenta");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Nombre = "";
                Cuenta.Tipo = "";
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
            return !string.IsNullOrEmpty(Cuenta.Numero);
        }

        internal void Actualizar()
        {
            Service1Client client = new Service1Client();

            try
            {
                client.ActualizarCuenta(Cuenta.Numero, Cuenta.Cedula, Cuenta.Nombre, Cuenta.Tipo);


                MessageBox.Show("La cuenta ha sido actualizada correctamente");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Nombre = "";
                Cuenta.Tipo = "";
            }
            catch
            {
                MessageBox.Show("Error al actualizar la cuenta");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Nombre = "";
                Cuenta.Tipo = "";
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
            return !string.IsNullOrEmpty(Cuenta.Numero);
        }

        internal void Borrar()
        {
            Service1Client client = new Service1Client();

            try
            {
                client.BorrarCuenta(Cuenta.Numero);

                MessageBox.Show("La cuenta ha sido borrada correctamente");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Nombre = "";
                Cuenta.Tipo = "";
            }
            catch
            {
                MessageBox.Show("Error al intentar borrar la cuenta");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Nombre = "";
                Cuenta.Tipo = "";
            }

        }

    }
}
