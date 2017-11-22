using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;
using System.Linq.Expressions;

namespace BLL
{
    public class PresupuestosBll
    {
        public static bool Guardar(Presupuestos presupu)
        {
            using (var reposi = new Repositorio<Presupuestos>())
            {
                try
                {
                    if (Buscar(u => u.PresupuestosId == presupu.PresupuestosId) == null)
                    {
                        return reposi.Guardar(presupu);
                    }
                    else
                    {
                        return reposi.Modificar(presupu);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static bool Modificar(Presupuestos presupu)
        {
            bool modifica = false;
            using (var reposi = new Repositorio<Presupuestos>())
            {
                modifica = reposi.Modificar(presupu);
            }

            return modifica;
        }

        public static bool Eliminar(Presupuestos presupu)
        {
            bool eliminado = false;
            using (var reposi = new Repositorio<Presupuestos>())
            {
                eliminado = reposi.Eliminar(presupu);
            }
            return eliminado;
        }

        public static Presupuestos Buscar(Expression<Func<Entidades.Presupuestos, bool>> Busqueda)
        {
            Presupuestos Result = null;
            using (var repoitorio = new Repositorio<Presupuestos>())
            {
                Result = repoitorio.Buscar(Busqueda);
            }
            return Result;
        }

        public static List<Presupuestos> Listar(Expression<Func<Presupuestos, bool>> busqueda)
        {
            List<Presupuestos> retorno = null;
            using (var conn = new Repositorio<Presupuestos>())
            {
                try
                {
                    retorno = conn.Lista(busqueda).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
        }

        public static List<Presupuestos> ListarTodo()
        {
            List<Presupuestos> retorno = null;
            using (var conn = new Repositorio<Presupuestos>())
            {
                try
                {
                    retorno = conn.ListaGet().ToList();

                }
                catch (Exception)
                {

                    throw;
                }
                return retorno;
            }
        }
    }
}
