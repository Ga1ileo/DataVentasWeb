using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataVentasWeb.DAL;
using DataVentasWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DataVentasWeb.BLL
{
    public class VentasBLL
    {
        private readonly Contexto _contexto;

        public VentasBLL(Contexto contexto){
            _contexto = contexto;
        }

        public async Task<bool> Guardar(Ventas venta)
        {
            if (!await Existe(venta.VentaId))
                return await Insertar(venta);
            else
                return await Modificar(venta);
        }

        public async Task<bool> Insertar(Ventas venta)
        {
            bool paso = false;

            try
            {
                _contexto.Ventas.Add(venta);
                paso = await _contexto.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
           
            return paso;
        }

        public async Task<bool> Modificar(Ventas venta)
        {
            bool paso = false;


            try
            {
                _contexto.Entry(venta).State = EntityState.Modified;

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
                var venta = _contexto.Ventas.Find(id);

                if (venta != null)
                {
                    _contexto.Ventas.Remove(venta);
                    paso = await _contexto.SaveChangesAsync() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            

            return paso;
        }

        public async Task<Ventas> Buscar(int id)
        {
            Ventas venta;

            try
            {
                venta = await _contexto.Ventas
                    .Where(v => v.VentaId == id)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return venta;
        }


        public async Task<bool> Existe(int id)
        {
            bool encontrado = false;

            try
            {
                encontrado = await _contexto.Ventas.AnyAsync(v => v.VentaId == id);
            }
            catch (Exception)
            {
                throw;
            }

            return encontrado;
        }

        public async Task<List<Ventas>> GetVentas(int clienteId = 0)
        {

            List<Ventas> ventas = new List<Ventas>();
            await Task.Delay(01); //Para dar tiempo a renderizar el mensaje de carga

            try
            {
                if (clienteId > 0)
                {
                    ventas = (await _contexto.Ventas.ToListAsync()).Where(v => v.ClienteId == clienteId && v.Balance > 0).ToList();
                }
                else
                {
                    ventas = await _contexto.Ventas.ToListAsync();
                }

            }
            catch (Exception)
            {

                throw;
            }

            return ventas;

        }

    }
}
