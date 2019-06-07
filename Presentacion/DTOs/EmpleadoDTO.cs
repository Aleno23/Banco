using Helpers;

namespace Presentacion
{
    public partial class EmpleadoDTO : BindingBase
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

        private string _cargo;

        public string Cargo
        {
            get { return _cargo; }
            set { SetProperty(ref _cargo, value); }
        }

        private string _usuario;

        public string Usuario
        {
            get { return _usuario; }
            set { SetProperty(ref _usuario, value); }
        }

        private string _contraseña;

        public string Contraseña
        {
            get { return _contraseña; }
            set { SetProperty(ref _contraseña, value); }
        }
    }
}
