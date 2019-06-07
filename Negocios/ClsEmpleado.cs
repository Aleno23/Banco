using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Runtime.Serialization;
namespace Negocios
{

    public class ClsEmpleado
    {
        public string[] Entrar(string usuario, string contraseña)
        {
            using (BancoEntities contex = new BancoEntities())
            {

                Empleado Ver = (from q in contex.Empleadoes
                                where q.Usuario == usuario && q.Contraseña == contraseña
                                select q).First();

                string[] vs = { Ver.Usuario, Ver.Contraseña };

                return vs;


            }
        }


        public void Registrar(string cedula, string nombre, string apellido, string telefono, string direccion, string celular, string cargo, string usuario, string contraseña)
        {
            using (BancoEntities contex = new BancoEntities())
            {
                Empleado empleado = new Empleado
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Direccion = direccion,
                    Celular = celular,
                    Cargo = cargo,
                    Usuario = usuario,
                    Contraseña = contraseña
                };

                contex.Empleadoes.Add(empleado);
                contex.SaveChanges();
            }
        }

        public string[] BuscarEmpleado(string cedula)
        {
            using (BancoEntities contex = new BancoEntities())
            {
                Empleado Ver = (from q in contex.Empleadoes
                                where q.Cedula == cedula
                                select q).First();

                string[] vs = {Ver.Cedula,Ver.Nombre,Ver.Apellido,
                Ver.Telefono,Ver.Direccion,Ver.Celular,Ver.Cargo,
                Ver.Usuario,Ver.Contraseña};

                return vs;
            }
        }


        public void Actualizar(string cedula, string nombre, string apellido, string telefono, string direccion, string celular, string cargo, string usuario, string contraseña)
        {
            using (BancoEntities contex = new BancoEntities())
            {

                Empleado Actualizar = (from q in contex.Empleadoes
                                       where q.Cedula == cedula
                                       select q).First();



                Actualizar.Nombre = nombre;
                Actualizar.Apellido = apellido;
                Actualizar.Telefono = telefono;
                Actualizar.Direccion = direccion;
                Actualizar.Celular = celular;
                Actualizar.Cargo = cargo;
                Actualizar.Usuario = usuario;
                Actualizar.Contraseña = contraseña;


                //contex.Empleadoes.Add(empleado);
                contex.SaveChanges();
            }
        }


        public void Borrar(string cedula)
        {
            using (BancoEntities contex = new BancoEntities())
            {

                var borrar = contex.Empleadoes.Find(cedula);

                contex.Empleadoes.Remove(borrar);

                contex.SaveChanges();


            }

        }


        public int Sumar(int x, int y)
        {
            if (x< 0)
            {
                return 0;
            }

            if (y < 0)
            {
                return -1;
            }


            return x + y;
        }
    }
}
