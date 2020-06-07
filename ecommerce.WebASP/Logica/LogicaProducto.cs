using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;

namespace ecommerce.WebASP.Logica
{
    public class LogicaProducto
    {
        //mi contexto de datos
        private static BDDCORDICARRITOEntities db = new BDDCORDICARRITOEntities();


        //listado de productos
        public static async Task<List<TBL_PRODUCTO>> getAllProduct()
        {
            try
            {
                return await db.TBL_PRODUCTO.Where(data => data.PRO_STATUS.Equals("A")).ToListAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }

        //listado por codigo
        public static async Task<TBL_PRODUCTO> getProductxId(int codigo)
        {
            try
            {
                return await db.TBL_PRODUCTO.Where(data => data.PRO_STATUS.Equals("A")
                && data.PRO_ID.Equals(codigo)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }

        //listado por id
        public static async Task<TBL_PRODUCTO> getProductxCode(string codigo)
        {
            try
            {
                return await db.TBL_PRODUCTO.Where(data => data.PRO_STATUS.Equals('A')
                && data.PRO_CODIGO.Equals(codigo)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }

        //guardar producto
        public static async Task<bool> saveProduct(TBL_PRODUCTO _infoProducto)
        {
            try
            {
                bool resultado = false;
                _infoProducto.PRO_STATUS = "A";
                _infoProducto.PRO_FECHACREACION = DateTime.Now;
                db.TBL_PRODUCTO.Add(_infoProducto);

                //actualiza el contexto de datos
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al guardar producto");
            }
        }

        //modificar producto
        public static async Task<bool> updateProduct(TBL_PRODUCTO _infoProducto)
        {
            try
            {
                bool resultado = false;
                _infoProducto.PRO_FECHACREACION = DateTime.Now;
                db.TBL_PRODUCTO.Add(_infoProducto);

                //actualiza el contexto de datos
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }

        //eliminar o cambiara estado producto
        public static async Task<bool> deleteproduct(TBL_PRODUCTO _infoProducto)
        {
            try
            {
                bool resultado = false;
                //elimina de forma fisica delete from
                //db.TBL_PRODUCTO.Remove(_infoProducto);


                _infoProducto.PRO_STATUS = "I";
                _infoProducto.PRO_FECHACREACION = DateTime.Now;

                //actualiza el contexto de datos
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar producto");
            }
        }
    }
}