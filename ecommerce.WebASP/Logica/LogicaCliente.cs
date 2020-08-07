using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ecommerce.WebASP.Logica
{
    public class LogicaCliente
    {
        //mi contexto de datos
        private static BDDCORDICARRITOEntities3 db = new BDDCORDICARRITOEntities3();


        //listado de clientes
        public static async Task<List<TBL_CLIENTE>> getAllClients()
        {
            try
            {
                return await db.TBL_CLIENTE.Where(data => data.cli_status.Equals("A")).ToListAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar cliente");
            }
        }


        //listado por dni
        public static async Task<TBL_CLIENTE> getClientsDni(string dni)
        {
            try
            {
                return await db.TBL_CLIENTE.Where(data => data.cli_status.Equals("A")
                && data.cli_identificacion.Equals(dni)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar cliente");
            }
        }





        //secuencia de id cliente
        public static Int64 getNextSequence()
        {
            var query = db.Database.SqlQuery<Int64>("SELECT NEXT VALUE FOR sq_ClienteId");
            var task = query.SingleAsync();
            Int64 valorSequence = task.Result;
            return valorSequence;
        }



        //guardar cliente
        public static async Task<bool> saveClients(TBL_CLIENTE _infoCliente)
        {
            try
            {
                bool resultado = false;
                _infoCliente.cli_id = getNextSequence();
                _infoCliente.cli_status = "A";
                _infoCliente.cli_fechacreacion = DateTime.Now;
                db.TBL_CLIENTE.Add(_infoCliente);

                //actualiza el contexto de datos
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al guardar cliente");
            }
        }




    }
}