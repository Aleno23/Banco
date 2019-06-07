using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.DTOs
{
    public partial class CuentaDTO : BindingBase
    {
        private string _numero;

        public string Numero
        {
            get { return _numero; }
            set { SetProperty(ref _numero, value); }
        }


        private string _cedula;

        public string Cedula
        {
            get { return _cedula; }
            set { SetProperty(ref _cedula, value); }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { SetProperty(ref _nombre, value); }
        }

        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { SetProperty(ref _tipo, value); }
        }

        private int _saldo;

        public int Saldo
        {
            get { return _saldo; }
            set { SetProperty(ref _saldo, value); }
        }

        
    }
}
