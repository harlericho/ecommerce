using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ecommerce.WebASP.Logica
{
    public class LogicaPedido
    {
        //mi contexto de datos
        private static BDDCORDICARRITOEntities db = new BDDCORDICARRITOEntities();

        //listado de pedidos
        public static async Task<List<TBL_PEDIDO>> getAllPedidos()
        {
            try
            {
                return await db.TBL_PEDIDO.Where(data => data.ped_status.Equals("A")).ToListAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar pedido");
            }
        }

        //secuencia de id pedido
        public static int getNextSequence()
        {
            var query = db.Database.SqlQuery<int>("SELECT NEXT VALUE FOR sq_PedidoId");
            var task = query.SingleAsync();
            int valorSequence = task.Result;
            return valorSequence;
        }

        //guardar pedido
        public static async Task<bool> savePedido(TBL_PEDIDO _infoPedido)
        {
            try
            {
                bool resultado = false;
                _infoPedido.ped_id = getNextSequence();
                // _infoProducto.pro_id = getNextSequence();
                _infoPedido.ped_status = "A";
                _infoPedido.ped_fechacreacion = DateTime.Now;
                db.TBL_PEDIDO.Add(_infoPedido);

                //actualiza el contexto de datos
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al guardar pedido");
            }
        }

    }
}