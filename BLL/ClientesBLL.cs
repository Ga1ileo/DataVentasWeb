using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DataVentasWeb.DAL;
using DataVentasWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DataVentasWeb.BLL
{
    public class ClientesBLL
    {
        private readonly Contexto _contexto;

        public ClientesBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Guardar(Clientes cliente)
        {
            if (!await Existe(cliente.ClienteId))
                return await Insertar(cliente);
            else
                return await Modificar(cliente);
        }

        public async Task<bool> Insertar(Clientes cliente)
        {
            bool paso = false;

            try
            {
                _contexto.Clientes.Add(cliente);
                paso = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public async Task<bool> Modificar(Clientes cliente)
        {
            bool paso = false;


            try
            {
                _contexto.Entry(cliente).State = EntityState.Modified;

                paso = await _contexto.SaveChangesAsync() > 0;

            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool paso = false;

            try
            {
                var cliente = _contexto.Clientes.Find(id);

                if (cliente != null)
                {
                    _contexto.Clientes.Remove(cliente);
                    paso = await _contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }

        public async Task<Clientes> Buscar(int id)
        {
            Clientes cliente;

            try
            {
                cliente = await _contexto.Clientes
                    .Where(v => v.ClienteId == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return cliente;
        }


        public async Task<bool> Existe(int id)
        {
            bool encontrado = false;

            try
            {
                encontrado = await _contexto.Clientes.AnyAsync(v => v.ClienteId == id);
            }
            catch (Exception)
            {
                throw;
            }

            return encontrado;
        }

        public async Task<List<Clientes>> GetClientes()
        {

            List<Clientes> clientes = new List<Clientes>();
            await Task.Delay(01); //Para dar tiempo a renderizar el mensaje de carga

            try
            {

                clientes = await _contexto.Clientes.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }

            return clientes;

        }
    }
}
