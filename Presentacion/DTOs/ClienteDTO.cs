using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace Presentacion.DTOs
{
    public partial class ClienteDTO : BindingBase
    {
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

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { SetProperty(ref _apellido, value); }
        }

        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { SetProperty(ref _telefono, value); }
        }

        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { SetProperty(ref _direccion, value); }
        }

        private string _celular;

        public string Celular
        {
            get { return _celular; }
            set { SetProperty(ref _celular, value); }
        }

    }
}
