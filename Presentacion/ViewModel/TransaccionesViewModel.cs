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
using Presentacion.Vistas.Transacciones;

namespace Presentacion.ViewModel
{
    public class TransaccionesViewModel : BindingBase
    {
        public TransaccionesViewModel()
        {

        }


        private CuentaDTO _cuenta = new CuentaDTO();

        public CuentaDTO Cuenta
        {
            get { return _cuenta; }
            set { SetProperty(ref _cuenta, value); }
        }

        private ICommand _depositarCommand;


        public ICommand DepositarCommand
        {

            get
            {

                if (_depositarCommand == null)
                {

                    _depositarCommand = new RelayCommand(param => Depositar(), CanExecuteDepositar);
                }
                return _depositarCommand;
            }
        }

        private bool CanExecuteDepositar()
        {
            return !string.IsNullOrEmpty(Cuenta.Numero);
        }



        internal void Depositar()
        {
            Service1Client client = new Service1Client();


            try
            {
                client.Depositar(Cuenta.Numero, Cuenta.Cedula, Cuenta.Saldo);

                MessageBox.Show("Deposito realizado");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Saldo = 0;
            }
            catch
            {
                MessageBox.Show("Error al intentar depositar");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Saldo = 0;
            }

        }

        private ICommand _retirarCommand;

        public ICommand RetirarCommand
        {

            get
            {
                if (_retirarCommand == null)
                {

                    _retirarCommand = new RelayCommand(param => Retirar(), CanExecuteRetirar);
                }
                return _retirarCommand;
            }
        }

        private bool CanExecuteRetirar()
        {
            return !string.IsNullOrEmpty(Cuenta.Numero);
        }

        internal void Retirar()
        {
            Service1Client client = new Service1Client();

            try
            {
                client.Retirar(Cuenta.Numero, Cuenta.Cedula, Cuenta.Saldo);

                MessageBox.Show("Retiro realizado");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Saldo = 0;
            }
            catch
            {
                MessageBox.Show("Error al intentar retirar");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Saldo = 0;
            }

        }

        private ICommand _verSaldoCommand;

        public ICommand VerSaldoCommand
        {

            get
            {
                if (_verSaldoCommand == null)
                {

                    _verSaldoCommand = new RelayCommand(param => Saldo(), CanExecuteSaldo);
                }
                return _verSaldoCommand;
            }
        }

        private bool CanExecuteSaldo()
        {
            return !string.IsNullOrEmpty(Cuenta.Numero);
        }

        internal void Saldo()
        {
            Service1Client client = new Service1Client();

            try
            {
              
                Cuenta.Saldo = client.VerSaldo(Cuenta.Numero, Cuenta.Cedula);
            }
            catch
            {
                MessageBox.Show("Error al intentar ver el saldo");

                Cuenta.Numero = "";
                Cuenta.Cedula = "";
                Cuenta.Saldo = 0;
            }

        }


        private ICommand _abrirDepositarCommand;

        public ICommand AbrirDepositarCommand
        {

            get
            {
                if (_abrirDepositarCommand == null)
                {

                    _abrirDepositarCommand = new RelayCommand(param => AbrirDepositar());
                }
                return _abrirDepositarCommand;
            }
        }

        internal void AbrirDepositar()
        {
            Depositar depositar = new Depositar();
            depositar.Show();

            Transacciones transacciones = new Transacciones();
            transacciones.Close();
        }


        private ICommand _abrirRetirarCommand;

        public ICommand AbrirRetirarCommand
        {

            get
            {
                if (_abrirRetirarCommand == null)
                {

                    _abrirRetirarCommand = new RelayCommand(param => AbrirRetirar());
                }
                return _abrirRetirarCommand;
            }
        }

        internal void AbrirRetirar()
        {
            Retirar retirar = new Retirar();
            retirar.Show();

            Transacciones transacciones = new Transacciones();
            transacciones.Close();
        }


        private ICommand _abrirSaldoCommand;

        public ICommand AbrirSaldoCommand
        {

            get
            {
                if (_abrirSaldoCommand == null)
                {

                    _abrirSaldoCommand = new RelayCommand(param => AbrirSaldo());
                }
                return _abrirSaldoCommand;
            }
        }

        internal void AbrirSaldo()
        {
            Saldo saldo = new Saldo();
            saldo.Show();

            Transacciones transacciones = new Transacciones();
            transacciones.Close();
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
            Cuenta.Numero = "";
            Cuenta.Cedula = "";
            Cuenta.Saldo = 0;
        }

    }
}
