using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class ClsTransacciones
    {
        public void Depositar(string numero, string cedula,int cantidad)
        {
            using (BancoEntities contex = new BancoEntities())
            {
                Cuenta depositar = (from q in contex.Cuentas
                                     where q.Numero_Cuenta == numero && q.Cedula_Titular==cedula
                                     select q).First();

                if(depositar.Saldo==null)
                {
                    depositar.Saldo = cantidad;
                }
                else
                {
                    depositar.Saldo = depositar.Saldo.Value + cantidad;
                }

                contex.SaveChanges();
            }
        }

        public void Retirar(string numero, string cedula, int cantidad)
        {
            using (BancoEntities contex = new BancoEntities())
            {
                Cuenta retirar = (from q in contex.Cuentas
                                     where q.Numero_Cuenta == numero && q.Cedula_Titular == cedula
                                     select q).First();

                retirar.Saldo = retirar.Saldo.Value - cantidad;

                contex.SaveChanges();
            }
        }

        public int VerSaldo(string numero, string cedula)
        {
            using (BancoEntities contex = new BancoEntities())
            {
                Cuenta buscar = (from q in contex.Cuentas
                                     where q.Numero_Cuenta == numero && q.Cedula_Titular == cedula
                                     select q).First();


                int saldo = buscar.Saldo.Value;

                return saldo;
            }
        }

    }
}
