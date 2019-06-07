using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class ClsCuenta
    {
        public void Registrar(string numero, string cedula, string nombre, string tipo)
        {
            using (BancoEntities contex = new BancoEntities())
            {
                Cuenta cuenta = new Cuenta
                {
                    Numero_Cuenta = numero,
                    Cedula_Titular = cedula,
                    Nombre_Titular = nombre,
                    Tipo_cuenta=tipo
                  
                };

                contex.Cuentas.Add(cuenta);
                contex.SaveChanges();
            }
        }

        public string[] Buscar(string numero)
        {
            using (BancoEntities contex = new BancoEntities())
            {
                Cuenta buscar = (from q in contex.Cuentas
                                  where q.Numero_Cuenta == numero
                                  select q).First();

                string[] vs = {buscar.Cedula_Titular,buscar.Nombre_Titular,buscar.Tipo_cuenta};

                return vs;
            }
        }


        public void Actualizar(string numero, string cedula, string nombre, string tipo)
        {
            using (BancoEntities contex = new BancoEntities())
            {

                Cuenta Actualizar = (from q in contex.Cuentas
                                      where q.Numero_Cuenta == numero
                                      select q).First();



                Actualizar.Cedula_Titular = cedula;
                Actualizar.Nombre_Titular = nombre;
                Actualizar.Tipo_cuenta = tipo;
             

                contex.SaveChanges();
            }
        }


        public void Borrar(string numero)
        {
            using (BancoEntities contex = new BancoEntities())
            {

                var borrar = contex.Cuentas.Find(numero);

                contex.Cuentas.Remove(borrar);

                contex.SaveChanges();


            }

        }
    }
}
