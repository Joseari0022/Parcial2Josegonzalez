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
        public static bool Guardar(Usuarios usuarios)
        {
            using (var reposi = new Repositorio<Usuarios>())
            {
                try
                {
                    if (Buscar(u => u.IdUsuarios == usuarios.IdUsuarios) == null)
                    {
                        return reposi.Guardar(usuarios);
                    }
                    else
                    {
                        return reposi.Modificar(usuarios);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static bool Modificar(Usuarios usuario)
        {
            bool modifica = false;
            using (var reposi = new Repositorio<Usuarios>())
            {
                modifica = reposi.Modificar(usuario);
            }

            return modifica;
        }

        public static bool Eliminar(Usuarios usuario)
        {
            bool eliminado = false;
            using (var reposi = new Repositorio<Usuarios>())
            {
                eliminado = reposi.Eliminar(usuario);
            }
            return eliminado;
        }

        public static Usuarios Buscar(Expression<Func<Entidades.Usuarios, bool>> Busqueda)
        {
            Usuarios Result = null;
            using (var repoitorio = new Repositorio<Usuarios>())
            {
                Result = repoitorio.Buscar(Busqueda);
            }
            return Result;
        }

        public static List<Usuarios> Listar(Expression<Func<Usuarios, bool>> busqueda)
        {
            List<Usuarios> retorno = null;
            using (var conn = new Repositorio<Usuarios>())
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

        public static List<Usuarios> ListarTodo()
        {
            List<Usuarios> retorno = null;
            using (var conn = new Repositorio<Usuarios>())
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

        public static List<Usuarios> GetListaNombre(string tmp)
        {
            List<Usuarios> retorno = null;
            SistemaVentasDb db = new SistemaVentasDb();
            {
                try
                {
                    retorno = db.Usuarios.Where(p => p.NombresUsuarios == tmp).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
                return retorno;
            }

        }
        public static List<Usuarios> GetContrasena(string tmp)
        {
            List<Usuarios> retorno = null;
            SistemaVentasDb db = new SistemaVentasDb();
            {
                try
                {
                    retorno = db.Usuarios.Where(p => p.Contrasena == tmp).ToList();
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
