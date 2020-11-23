using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DataVentasWeb.Models;
using Microsoft.AspNetCore.Identity;

namespace DataVentasWeb.DAL
{
    public class Contexto : IdentityDbContext<Usuarios, IdentityRole<int>,int>
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<PagosVentas> PagosVentas { get; set; }
        public DbSet<PagosCompras> PagosCompras { get; set; }
        
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

       /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
    
            optionsBuilder.UseSqlServer(@"Server=.\\SQLEXPRESS; Initial Catalog=DataVentasWeb.db;Persist Security Info=True;Integrated Security = True");
            base.OnConfiguring(optionsBuilder);
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios { UsuarioId = 1, Nombres = "Admin", NombreUsuario = "admin" });

            modelBuilder.Entity<Vendedores>().HasData(new Vendedores { VendedorId = 1, Nombres = "Maria", Email = "Maria2020@gmail.com", Telefono = "829-587-5468", Celular = "829-749-7827", Cedula="064-1459022-2", Direccion="Tenares, El cruce", UsuarioId = 1 });

            modelBuilder.Entity<Clientes>().HasData(new Clientes { ClienteId = 1, Nombres = "Jose Perez", Email = "JosePerez2020@mgail.com", Telefono = "829-587-7521", Celular = "809-549-7827", Cedula = "064-5639022-1", Direccion = "Ciudad modelo tenares", UsuarioId = 1 });

            modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 1, Descripcion = "Bebidas", Cantidad = 10, Precio = 150, Costo = 100, UsuarioId = 1 });
        }


    }
}
