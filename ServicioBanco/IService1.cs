using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioBanco
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string[] Ingresar(string usuario, string contraseña);

        [OperationContract]
        void RegistrarEmpleado(string cedula, string nombre, string apellido, string telefono, string direccion, string celular, string cargo, string usuario, string contraseña);

        [OperationContract]
        string[] BuscarEmpleado(string cedula);

        [OperationContract]
        void ActualizarEmpleado(string cedula, string nombre, string apellido, string telefono, string direccion, string celular, string cargo, string usuario, string contraseña);

        [OperationContract]
        void BorrarEmpleado(string cedula);

        [OperationContract]
        void RegistrarCliente(string cedula, string nombre, string apellido, string telefono, string direccion, string celular);

        [OperationContract]
        string[] BuscarCliente(string cedula);

        [OperationContract]
        void ActualizarCliente(string cedula, string nombre, string apellido, string telefono, string direccion, string celular);

        [OperationContract]
        void BorrarCliente(string cedula);


        [OperationContract]
        void RegistrarCuenta(string numero, string cedula, string nombre, string tipo);

        [OperationContract]
        string[] BuscarCuenta(string numero);

        [OperationContract]
        void ActualizarCuenta(string numero, string cedula, string nombre, string tipo);

        [OperationContract]
        void BorrarCuenta(string numero);

        [OperationContract]
        void Depositar(string numero, string cedula, int cantidad);

        [OperationContract]
        void Retirar(string numero, string cedula, int cantidad);

        [OperationContract]
        int VerSaldo(string numero, string cedula);
    }

}
