using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ecommerce.WebASP.Logica
{
    public class LogicaCategoria
    {
        private static BDDCORDICARRITOEntities2 db = new BDDCORDICARRITOEntities2();
        //listado de categoria
        public static async Task<List<TBL_CATEGORIA>> getAllCategory()
        {
            try
            {
                return await db.TBL_CATEGORIA.Where(data => data.cat_status.Equals("A")).ToListAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar categoria");
            }
        }

        //listado por codigo
        public static async Task<TBL_CATEGORIA> getCategoryId(int codigo)
        {
            try
            {
                return await db.TBL_CATEGORIA.Where(data => data.cat_status.Equals("A")
                && data.cat_id.Equals(codigo)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar categoria");
            }
        }

   

        //guardar categoria
        public static async Task<bool> saveCategory(TBL_CATEGORIA _infocategoria)
        {
            try
            {
                bool resultado = false;
                _infocategoria.cat_status = "A";
                _infocategoria.cat_fechacreacion = DateTime.Now;
                db.TBL_CATEGORIA.Add(_infocategoria);

                //actualiza el contexto de datos
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar categoria");
            }
        }

        //modificar categoria
        public static async Task<bool> updateCategory(TBL_CATEGORIA _infocategoria)
        {
            try
            {
                bool resultado = false;
                _infocategoria.cat_fechacreacion = DateTime.Now;
                db.TBL_CATEGORIA.Add(_infocategoria);

                //actualiza el contexto de datos
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar categoria");
            }
        }

        //eliminar o cambiara estado categoria
        public static async Task<bool> deleteCategory(TBL_CATEGORIA _infocategoria)
        {
            try
            {
                bool resultado = false;
                //elimina de forma fisica delete from
                //db.TBL_CATEGORIA.Remove(_infocategoria);


                _infocategoria.cat_status = "I";
                _infocategoria.cat_fechacreacion = DateTime.Now;

                //actualiza el contexto de datos
                await db.SaveChangesAsync();
                resultado = true;
                return resultado;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar categoria");
            }
        }

    }
}