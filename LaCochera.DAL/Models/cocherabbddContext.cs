using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LaCochera.DAL.Models
{
    public partial class cocherabbddContext : DbContext
    {
        public cocherabbddContext()
        {
        }

        public cocherabbddContext(DbContextOptions<cocherabbddContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<CombustibleVehiculos> CombustibleVehiculos { get; set; }
        public virtual DbSet<Concesionarios> Concesionarios { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<Jefe> Jefe { get; set; }
        public virtual DbSet<Mecanicos> Mecanicos { get; set; }
        public virtual DbSet<PropuestaVenta> PropuestaVenta { get; set; }
        public virtual DbSet<Reparaciones> Reparaciones { get; set; }
        public virtual DbSet<TiposVehiculos> TiposVehiculos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<VehiculosReparar> VehiculosReparar { get; set; }
        public virtual DbSet<VehiculosVender> VehiculosVender { get; set; }
        public virtual DbSet<Vendedores> Vendedores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=1234;database=cocherabbdd", x => x.ServerVersion("8.0.19-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("cliente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DescripcionVehiculo)
                    .HasColumnName("descripcionVehiculo")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fechaRegistro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Presupuesto).HasColumnName("presupuesto");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<CombustibleVehiculos>(entity =>
            {
                entity.ToTable("combustible_vehiculos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Concesionarios>(entity =>
            {
                entity.ToTable("concesionarios");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("ciudad")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("cp")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasColumnName("provincia")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Especialidades>(entity =>
            {
                entity.HasKey(e => new { e.TipoId, e.MecanicoId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("especialidades");

                entity.HasIndex(e => e.MecanicoId)
                    .HasName("fk_Tipos_Vehiculos_has_Mecanicos_Mecanicos1_idx");

                entity.HasIndex(e => e.TipoId)
                    .HasName("fk_Tipos_Vehiculos_has_Mecanicos_Tipos_Vehiculos1_idx");

                entity.Property(e => e.TipoId).HasColumnName("tipoID");

                entity.Property(e => e.MecanicoId).HasColumnName("mecanicoID");

                entity.HasOne(d => d.Mecanico)
                    .WithMany(p => p.Especialidades)
                    .HasForeignKey(d => d.MecanicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_especialidades_mecanicos");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Especialidades)
                    .HasForeignKey(d => d.TipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_especialidades_tipos");
            });

            modelBuilder.Entity<Jefe>(entity =>
            {
                entity.ToTable("jefe");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("FK_jefe_usuarios");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Jefe)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_jefe_usuarios");
            });

            modelBuilder.Entity<Mecanicos>(entity =>
            {
                entity.ToTable("mecanicos");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("FK_mecanicos_usuarios");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EsJefe).HasColumnName("esJefe");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Mecanicos)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_mecanicos_usuarios");
            });

            modelBuilder.Entity<PropuestaVenta>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.VendedorId, e.VehiculoVenderId, e.ClienteId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("propuesta_venta");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("fk_propuesta_venta_cliente1_idx");

                entity.HasIndex(e => e.VehiculoVenderId)
                    .HasName("fk_propuesta_venta_vehiculos_Vender1_idx");

                entity.HasIndex(e => e.VendedorId)
                    .HasName("fk_propuesta_venta_vendedores1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.VendedorId).HasColumnName("vendedorID");

                entity.Property(e => e.VehiculoVenderId).HasColumnName("vehiculoVenderID");

                entity.Property(e => e.ClienteId).HasColumnName("clienteID");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("enum('aceptada','pendiente','rechazada')")
                    .HasDefaultValueSql("'pendiente'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fechaFin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FechaLimite)
                    .HasColumnName("fechaLimite")
                    .HasColumnType("date");

                entity.Property(e => e.Presupuesto).HasColumnName("presupuesto");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.PropuestaVenta)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_propuesta_venta_cliente1");

                entity.HasOne(d => d.VehiculoVender)
                    .WithMany(p => p.PropuestaVenta)
                    .HasForeignKey(d => d.VehiculoVenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_propuesta_venta_vehiculos_Vender1");

                entity.HasOne(d => d.Vendedor)
                    .WithMany(p => p.PropuestaVenta)
                    .HasForeignKey(d => d.VendedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_propuesta_venta_vendedores1");
            });

            modelBuilder.Entity<Reparaciones>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.MecanicoId, e.VehiculoRepararId, e.ClienteId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("reparaciones");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("fk_reparaciones_cliente1_idx");

                entity.HasIndex(e => e.MecanicoId)
                    .HasName("fk_reparaciones_mecanicos1_idx");

                entity.HasIndex(e => e.VehiculoRepararId)
                    .HasName("fk_reparaciones_vehiculos_reparar1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MecanicoId).HasColumnName("mecanicoID");

                entity.Property(e => e.VehiculoRepararId).HasColumnName("vehiculoRepararID");

                entity.Property(e => e.ClienteId).HasColumnName("clienteID");

                entity.Property(e => e.Componentes)
                    .HasColumnName("componentes")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("enum('finalizado','proceso','pendiente','avisado')")
                    .HasDefaultValueSql("'pendiente'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fechaFin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.PresupuestoEstimado).HasColumnName("presupuestoEstimado");

                entity.Property(e => e.PresupuestoReal).HasColumnName("presupuestoReal");

                entity.Property(e => e.TiempoEstimado)
                    .IsRequired()
                    .HasColumnName("tiempoEstimado")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TiempoReal)
                    .HasColumnName("tiempoReal")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Reparaciones)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reparaciones_cliente1");

                entity.HasOne(d => d.Mecanico)
                    .WithMany(p => p.Reparaciones)
                    .HasForeignKey(d => d.MecanicoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reparaciones_mecanicos1");

                entity.HasOne(d => d.VehiculoReparar)
                    .WithMany(p => p.Reparaciones)
                    .HasForeignKey(d => d.VehiculoRepararId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reparaciones_vehiculos_reparar1");
            });

            modelBuilder.Entity<TiposVehiculos>(entity =>
            {
                entity.ToTable("tipos_vehiculos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.ConcesionarioId)
                    .HasName("fk_usuarios_concesionarios1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasColumnName("apellidos")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ConcesionarioId).HasColumnName("concesionarioID");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasColumnName("dni")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Salario).HasColumnName("salario");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("enum('vendedor','mecanico','jefe')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Concesionario)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.ConcesionarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_concesionarios1");
            });

            modelBuilder.Entity<Vehiculos>(entity =>
            {
                entity.ToTable("vehiculos");

                entity.HasIndex(e => e.ConcesionarioId)
                    .HasName("fk_vehiculos_concesionarios1_idx");

                entity.HasIndex(e => e.TipoId)
                    .HasName("fk_vehiculos_Tipos_Vehiculos1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConcesionarioId).HasColumnName("concesionarioID");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fechaRegistro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Potencia)
                    .HasColumnName("potencia")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TipoId).HasColumnName("tipoID");

                entity.HasOne(d => d.Concesionario)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.ConcesionarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vehiculos_concesionarios1");

                entity.HasOne(d => d.Tipo)
                    .WithMany(p => p.Vehiculos)
                    .HasForeignKey(d => d.TipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vehiculos_Tipos_Vehiculos1");
            });

            modelBuilder.Entity<VehiculosReparar>(entity =>
            {
                entity.ToTable("vehiculos_reparar");

                entity.HasIndex(e => e.VehiculoId)
                    .HasName("fk_vehiculos_reparar_vehiculos1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Matricula)
                    .HasColumnName("matricula")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculoID");

                entity.HasOne(d => d.Vehiculo)
                    .WithMany(p => p.VehiculosReparar)
                    .HasForeignKey(d => d.VehiculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vehiculos_reparar_vehiculos1");
            });

            modelBuilder.Entity<VehiculosVender>(entity =>
            {
                entity.ToTable("vehiculos_vender");

                entity.HasIndex(e => e.CombustibleId)
                    .HasName("combustibleID");

                entity.HasIndex(e => e.VehiculoId)
                    .HasName("fk_vehiculos_Vender_vehiculos1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CombustibleId).HasColumnName("combustibleID");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .HasColumnType("mediumtext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KmRecorridos).HasColumnName("kmRecorridos");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("decimal(9,2)");

                entity.Property(e => e.SegundaMano).HasColumnName("segundaMano");

                entity.Property(e => e.TiempoUsado)
                    .HasColumnName("tiempoUsado")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VehiculoId).HasColumnName("vehiculoID");

                entity.Property(e => e.Vendido).HasColumnName("vendido");

                entity.HasOne(d => d.Combustible)
                    .WithMany(p => p.VehiculosVender)
                    .HasForeignKey(d => d.CombustibleId)
                    .HasConstraintName("FK_vehiculos_vender_combustibles");

                entity.HasOne(d => d.Vehiculo)
                    .WithMany(p => p.VehiculosVender)
                    .HasForeignKey(d => d.VehiculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_vehiculos_Vender_vehiculos1");
            });

            modelBuilder.Entity<Vendedores>(entity =>
            {
                entity.ToTable("vendedores");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("FK_vendedores_usuarios");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NumVentas).HasColumnName("numVentas");

                entity.Property(e => e.UsuarioId).HasColumnName("usuarioId");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Vendedores)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_vendedores_usuarios");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
