using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Negocios;

namespace ServicioBanco
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string[] Ingresar(string usuario, string contraseña)
        {
            ClsEmpleado empleado = new ClsEmpleado();

            string[] resultado = empleado.Entrar(usuario,contraseña);

            
            return resultado;


        }

        public void RegistrarEmpleado(string cedula, string nombre, string apellido, string telefono, string direccion, string celular, string cargo, string usuario, string contraseña)
        {
            ClsEmpleado empleado = new ClsEmpleado();

            empleado.Registrar(cedula,nombre,apellido,telefono,direccion,celular,cargo,usuario,contraseña);

        }

        public string[] BuscarEmpleado(string cedula)
        {
            ClsEmpleado empleado = new ClsEmpleado();

            string[] vs= empleado.BuscarEmpleado(cedula);

            return vs;


        }

        public void ActualizarEmpleado(string cedula, string nombre, string apellido, string telefono, string direccion, string celular, string cargo, string usuario, string contraseña)
        {
            ClsEmpleado empleado = new ClsEmpleado();

            empleado.Actualizar( cedula,  nombre,  apellido,  telefono,  direccion,  celular,  cargo,  usuario,  contraseña);
        }

        public void BorrarEmpleado(string cedula)
        {
            ClsEmpleado empleado = new ClsEmpleado();

            empleado.Borrar(cedula);
        }

        public void RegistrarCliente(string cedula, string nombre, string apellido, string telefono, string direccion, string celular)
        {
            ClsCliente cliente = new ClsCliente();

            cliente.Registrar(cedula, nombre, apellido, telefono, direccion, celular);
        }

        public string[] BuscarCliente(string cedula)
        {
            ClsCliente cliente = new ClsCliente();

            string[] vs = cliente.Buscar(cedula);

            return vs;
        }

        public void ActualizarCliente(string cedula, string nombre, string apellido, string telefono, string direccion, string celular)
        {
            ClsCliente cliente = new ClsCliente();

            cliente.Actualizar(cedula, nombre, apellido, telefono, direccion, celular);
        }

        public void BorrarCliente(string cedula)
        {
            ClsCliente cliente = new ClsCliente();

            cliente.Borrar(cedula);
        }

        public void RegistrarCuenta(string numero, string cedula, string nombre, string tipo)
        {
            ClsCuenta cuenta = new ClsCuenta();

            cuenta.Registrar(numero, cedula, nombre, tipo);
        }

        public string[] BuscarCuenta(string numero)
        {
            ClsCuenta cuenta = new ClsCuenta();

            string[] vs = cuenta.Buscar(numero);

            return vs;
        }

        public void ActualizarCuenta(string numero, string cedula, string nombre, string tipo)
        {
            ClsCuenta cuenta = new ClsCuenta();

            cuenta.Actualizar(numero, cedula, nombre, tipo);
        }

        public void BorrarCuenta(string numero)
        {
            ClsCuenta cuenta = new ClsCuenta();

            cuenta.Borrar(numero);
        }

        public void Depositar(string numero, string cedula, int cantidad)
        {
            ClsTransacciones transacciones = new ClsTransacciones();

            transacciones.Depositar(numero, cedula, cantidad);
        }

        public void Retirar(string numero, string cedula, int cantidad)
        {
            ClsTransacciones transacciones = new ClsTransacciones();

            transacciones.Retirar(numero, cedula, cantidad);
        }

        public int VerSaldo(string numero, string cedula)
        {
            ClsTransacciones transacciones = new ClsTransacciones();

           return transacciones.VerSaldo(numero, cedula);

        }
    }
}
