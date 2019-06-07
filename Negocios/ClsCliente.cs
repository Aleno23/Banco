using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ClsCliente
    {
        public void Registrar(string cedula, string nombre, string apellido, string telefono, string direccion, string celular)
        {
            using (BancoEntities contex = new BancoEntities())
            {
                Cliente cliente = new Cliente
                {
                    Cedula = cedula,
                    Nombre = nombre,
                    Apellido = apellido,
                    Telefono = telefono,
                    Direccion = direccion,
                    Celular = celular,
                };

                contex.Clientes.Add(cliente);
                contex.SaveChanges();
            }
        }

        public string[] Buscar(string cedula)
        {
            using (BancoEntities contex = new BancoEntities())
            {
                Cliente buscar = (from q in contex.Clientes
                                where q.Cedula == cedula
                                select q).First();

                string[] vs = {buscar.Cedula,buscar.Nombre,buscar.Apellido,
                buscar.Telefono,buscar.Direccion,buscar.Celular};

                return vs;
            }
        }


        public void Actualizar(string cedula, string nombre, string apellido, string telefono, string direccion, string celular)
        {
            using (BancoEntities contex = new BancoEntities())
            {

                Cliente Actualizar = (from q in contex.Clientes
                                       where q.Cedula == cedula
                                       select q).First();



                Actualizar.Nombre = nombre;
                Actualizar.Apellido = apellido;
                Actualizar.Telefono = telefono;
                Actualizar.Direccion = direccion;
                Actualizar.Celular = celular;
               
                contex.SaveChanges();
            }
        }


        public void Borrar(string cedula)
        {
            using (BancoEntities contex = new BancoEntities())
            {

                var borrar = contex.Clientes.Find(cedula);

                contex.Clientes.Remove(borrar);

                contex.SaveChanges();


            }

        }
    }
}
