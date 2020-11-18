using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using DataVentasWeb.Models;


namespace DataVentasWeb.BLL
{
    public class UsuariosBLL
    {
        /*public static bool Guardar(Usuarios usuarios)
        {
            if (!Existe(usuarios.UsuarioId))

                return Insertar(usuarios);
            else
                return Modificar(usuarios);

        }
        private static bool Insertar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Usuarios.Add(usuarios);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                contexto.Entry(usuarios).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var aux = contexto.Usuarios.Find(id);
                if (aux != null)
                {
                    contexto.Usuarios.Remove(aux);
                    paso = contexto.SaveChanges() > 0;

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Usuarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Usuarios usuarios;

            try
            {
                usuarios = contexto.Usuarios.Find(id);
                if(usuarios != null)
                {
                    usuarios.Clave= Encriptar(usuarios.Clave);
                    
                }          
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return usuarios;

        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Usuarios.Any(p=>p.UsuarioId == id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;

        }

        public static bool ComprobarDatosUsuario(string nombreUsuario, string clave)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
       
            try
            {
               paso = contexto.Usuarios.Any(x => x.NombreUsuario == nombreUsuario && x.Clave == clave);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }

        public static List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Usuarios.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static string Encriptar(string cadenaEncriptada)
        {
            if (!string.IsNullOrEmpty(cadenaEncriptada))
            {
                string resultado = string.Empty;
                byte[] encryted = Encoding.Unicode.GetBytes(cadenaEncriptada);
                resultado = Convert.ToBase64String(encryted);

                return resultado;
            }

            return string.Empty;
        }

        public static string Desencriptar(string cadenaDesencriptada)
        {
            if (!string.IsNullOrEmpty(cadenaDesencriptada))
            {
                string resultado = string.Empty;
                byte[] decryted = Convert.FromBase64String(cadenaDesencriptada);
                resultado = System.Text.Encoding.Unicode.GetString(decryted);

                return resultado;
            }

            return string.Empty;
        }
    */
    }
}