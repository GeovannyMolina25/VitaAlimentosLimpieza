using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LimpiezaProyect.Models
{
    public partial class PqsaContext : DbContext
    {
        public PqsaContext()
        {
        }

        public PqsaContext(DbContextOptions<PqsaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppProducto> AppProductos { get; set; } = null!;
        public virtual DbSet<AppProductoImpuesto> AppProductoImpuestos { get; set; } = null!;
        public virtual DbSet<BlArmado> BlArmados { get; set; } = null!;
        public virtual DbSet<BlComprado> BlComprados { get; set; } = null!;
        public virtual DbSet<BlPrecio> BlPrecios { get; set; } = null!;
        public virtual DbSet<BlProducido> BlProducidos { get; set; } = null!;
        public virtual DbSet<BlResuman> BlResumen { get; set; } = null!;
        public virtual DbSet<BlVendido> BlVendidos { get; set; } = null!;
        public virtual DbSet<CaRegistroAccesoHikCentral> CaRegistroAccesoHikCentrals { get; set; } = null!;
        public virtual DbSet<CaRegistroAccesoHikCentralHist> CaRegistroAccesoHikCentralHists { get; set; } = null!;
        public virtual DbSet<Certificado> Certificados { get; set; } = null!;
        public virtual DbSet<Clbarrio> Clbarrios { get; set; } = null!;
        public virtual DbSet<Clbloque> Clbloques { get; set; } = null!;
        public virtual DbSet<Clcategorium> Clcategoria { get; set; } = null!;
        public virtual DbSet<Clcliente> Clclientes { get; set; } = null!;
        public virtual DbSet<ClclienteChiVistum> ClclienteChiVista { get; set; } = null!;
        public virtual DbSet<ClclienteNorteVistum> ClclienteNorteVista { get; set; } = null!;
        public virtual DbSet<ClclienteNuevasRuta> ClclienteNuevasRutas { get; set; } = null!;
        public virtual DbSet<ClclienteSurVistum> ClclienteSurVista { get; set; } = null!;
        public virtual DbSet<ClclienteTumVistum> ClclienteTumVista { get; set; } = null!;
        public virtual DbSet<Clgiro> Clgiros { get; set; } = null!;
        public virtual DbSet<ClientesCensado> ClientesCensados { get; set; } = null!;
        public virtual DbSet<Clparroquium> Clparroquia { get; set; } = null!;
        public virtual DbSet<Clproyecto> Clproyectos { get; set; } = null!;
        public virtual DbSet<Clrutum> Clruta { get; set; } = null!;
        public virtual DbSet<Clzonaadmin> Clzonaadmins { get; set; } = null!;
        public virtual DbSet<ComedorParametrosServicio> ComedorParametrosServicios { get; set; } = null!;
        public virtual DbSet<ComedorRegistroServicio> ComedorRegistroServicios { get; set; } = null!;
        public virtual DbSet<Companyview> Companyviews { get; set; } = null!;
        public virtual DbSet<Despacho> Despachos { get; set; } = null!;
        public virtual DbSet<DespachoFactura> DespachoFacturas { get; set; } = null!;
        public virtual DbSet<DespachoFacturaDetalle> DespachoFacturaDetalles { get; set; } = null!;
        public virtual DbSet<DespachoJaba> DespachoJabas { get; set; } = null!;
        public virtual DbSet<DespachoPallet> DespachoPallets { get; set; } = null!;
        public virtual DbSet<DespachoProductoTerminado> DespachoProductoTerminados { get; set; } = null!;
        public virtual DbSet<DirPartyTable> DirPartyTables { get; set; } = null!;
        public virtual DbSet<FechaProceso> FechaProcesos { get; set; } = null!;
        public virtual DbSet<InfControlProceso> InfControlProcesos { get; set; } = null!;
        public virtual DbSet<InvCierreCompuestosDet> InvCierreCompuestosDets { get; set; } = null!;
        public virtual DbSet<InvCierreCompuestosHead> InvCierreCompuestosHeads { get; set; } = null!;
        public virtual DbSet<InvDisponibleCierredium> InvDisponibleCierredia { get; set; } = null!;
        public virtual DbSet<LimpArea> LimpAreas { get; set; } = null!;
        public virtual DbSet<LimpFormulario> LimpFormularios { get; set; } = null!;
        public virtual DbSet<LimpFormularioActividad> LimpFormularioActividads { get; set; } = null!;
        public virtual DbSet<LimpRegistro> LimpRegistros { get; set; } = null!;
        public virtual DbSet<LimpRegistroDetalle> LimpRegistroDetalles { get; set; } = null!;
        public virtual DbSet<Logisticselectronicaddress> Logisticselectronicaddresses { get; set; } = null!;
        public virtual DbSet<LpdpCliente> LpdpClientes { get; set; } = null!;
        public virtual DbSet<LpdpProveedor> LpdpProveedors { get; set; } = null!;
        public virtual DbSet<MensajesError> MensajesErrors { get; set; } = null!;
        public virtual DbSet<MntProperty> MntProperties { get; set; } = null!;
        public virtual DbSet<Parametro> Parametros { get; set; } = null!;
        public virtual DbSet<ParametrosPago> ParametrosPagos { get; set; } = null!;
        public virtual DbSet<PmsCostosReales01> PmsCostosReales01s { get; set; } = null!;
        public virtual DbSet<PmsListaprecio> PmsListaprecios { get; set; } = null!;
        public virtual DbSet<PmsParametro> PmsParametros { get; set; } = null!;
        public virtual DbSet<PmsPrecioUnitario> PmsPrecioUnitarios { get; set; } = null!;
        public virtual DbSet<PmsServiciosBasico> PmsServiciosBasicos { get; set; } = null!;
        public virtual DbSet<Precios2022> Precios2022s { get; set; } = null!;
        public virtual DbSet<Presupuesto> Presupuestos { get; set; } = null!;
        public virtual DbSet<PresupuestoVistum> PresupuestoVista { get; set; } = null!;
        public virtual DbSet<PriceDiscTable> PriceDiscTables { get; set; } = null!;
        public virtual DbSet<PurchLine> PurchLines { get; set; } = null!;
        public virtual DbSet<PurchTable> PurchTables { get; set; } = null!;
        public virtual DbSet<Pvitem> Pvitems { get; set; } = null!;
        public virtual DbSet<PvitemLineaSublinea> PvitemLineaSublineas { get; set; } = null!;
        public virtual DbSet<Pvlinea> Pvlineas { get; set; } = null!;
        public virtual DbSet<Pvprecio> Pvprecios { get; set; } = null!;
        public virtual DbSet<Pvpresupuesto> Pvpresupuestos { get; set; } = null!;
        public virtual DbSet<Pvpresupuestover> Pvpresupuestovers { get; set; } = null!;
        public virtual DbSet<Pvpresupuestoverline> Pvpresupuestoverlines { get; set; } = null!;
        public virtual DbSet<Pvsublinea> Pvsublineas { get; set; } = null!;
        public virtual DbSet<Pvsubundnegocio> Pvsubundnegocios { get; set; } = null!;
        public virtual DbSet<Pvundnegocio> Pvundnegocios { get; set; } = null!;
        public virtual DbSet<Pvundnegocioitem> Pvundnegocioitems { get; set; } = null!;
        public virtual DbSet<ResultadoAnalisi> ResultadoAnalises { get; set; } = null!;
        public virtual DbSet<ResultadoAnalisisBak> ResultadoAnalisisBaks { get; set; } = null!;
        public virtual DbSet<Resultadoanalaismalo20230828> Resultadoanalaismalo20230828s { get; set; } = null!;
        public virtual DbSet<Resultadoanalisisal31jul> Resultadoanalisisal31juls { get; set; } = null!;
        public virtual DbSet<ResultadosEquipo> ResultadosEquipos { get; set; } = null!;
        public virtual DbSet<ResultadosEquiposParametrosEnsayo> ResultadosEquiposParametrosEnsayos { get; set; } = null!;
        public virtual DbSet<ResultadosEquiposProvLeche> ResultadosEquiposProvLeches { get; set; } = null!;
        public virtual DbSet<SysListaEmpresaSitio> SysListaEmpresaSitios { get; set; } = null!;
        public virtual DbSet<TablaPago> TablaPagos { get; set; } = null!;
        public virtual DbSet<TablaPagoCbt> TablaPagoCbts { get; set; } = null!;
        public virtual DbSet<TablaPagoGrasaProteina> TablaPagoGrasaProteinas { get; set; } = null!;
        public virtual DbSet<TrnsRutadet> TrnsRutadets { get; set; } = null!;
        public virtual DbSet<TrnsRutaline> TrnsRutalines { get; set; } = null!;
        public virtual DbSet<TrnsRutum> TrnsRuta { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<VdatosCalificacionParaPaginaWeb> VdatosCalificacionParaPaginaWebs { get; set; } = null!;
        public virtual DbSet<VendCertType> VendCertTypes { get; set; } = null!;
        public virtual DbSet<VendTable> VendTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-CNQN4CO; Database=Pqsa; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AppProducto>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK_AppVitaProducto");

                entity.ToTable("AppProducto");

                entity.Property(e => e.ItemId).HasMaxLength(8);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.TaxItemGroupId).HasMaxLength(128);
            });

            modelBuilder.Entity<AppProductoImpuesto>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Factor).HasColumnType("numeric(24, 20)");

                entity.Property(e => e.ItemId).HasMaxLength(16);

                entity.Property(e => e.TaxId).HasMaxLength(8);
            });

            modelBuilder.Entity<BlArmado>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("BL_ARMADOS");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(16)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(128)
                    .HasColumnName("ITEMDESC");
            });

            modelBuilder.Entity<BlComprado>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("BL_COMPRADOS");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(16)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(128)
                    .HasColumnName("ITEMDESC");
            });

            modelBuilder.Entity<BlPrecio>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("BL_PRECIOS");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(16)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(128)
                    .HasColumnName("ITEMDESC");
            });

            modelBuilder.Entity<BlProducido>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("BL_PRODUCIDOS");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(16)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(128)
                    .HasColumnName("ITEMDESC");
            });

            modelBuilder.Entity<BlResuman>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("BL_RESUMEN");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(16)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Armado)
                    .HasMaxLength(2)
                    .HasColumnName("ARMADO");

                entity.Property(e => e.Comprado)
                    .HasMaxLength(2)
                    .HasColumnName("COMPRADO");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(128)
                    .HasColumnName("ITEMDESC");

                entity.Property(e => e.Producido)
                    .HasMaxLength(2)
                    .HasColumnName("PRODUCIDO");

                entity.Property(e => e.RevisadoPrecios)
                    .HasMaxLength(2)
                    .HasColumnName("REVISADO_PRECIOS");

                entity.Property(e => e.Vendido)
                    .HasMaxLength(2)
                    .HasColumnName("VENDIDO");
            });

            modelBuilder.Entity<BlVendido>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.ToTable("BL_VENDIDOS");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(16)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(128)
                    .HasColumnName("ITEMDESC");
            });

            modelBuilder.Entity<CaRegistroAccesoHikCentral>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CaRegistroAccesoHikCentral");

                entity.Property(e => e.Direccion).HasMaxLength(50);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'PQSA')");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Cargado')");

                entity.Property(e => e.FechaAcceso).HasMaxLength(50);

                entity.Property(e => e.FechaHoraAcceso).HasMaxLength(50);

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaHoraMarcacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraProceso).HasColumnType("datetime");

                entity.Property(e => e.HoraAcceso).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdEmpleado).HasMaxLength(50);

                entity.Property(e => e.Importado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreDispositivo).HasMaxLength(50);

                entity.Property(e => e.NombrePersona).HasMaxLength(50);

                entity.Property(e => e.NumSerieDispositivo).HasMaxLength(50);

                entity.Property(e => e.NumTarjeta).HasMaxLength(50);
            });

            modelBuilder.Entity<CaRegistroAccesoHikCentralHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CaRegistroAccesoHikCentralHist");

                entity.Property(e => e.Direccion).HasMaxLength(50);

                entity.Property(e => e.Empresa).HasMaxLength(5);

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.FechaAcceso).HasMaxLength(50);

                entity.Property(e => e.FechaHoraAcceso).HasMaxLength(50);

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraMarcacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraProceso).HasColumnType("datetime");

                entity.Property(e => e.HoraAcceso).HasMaxLength(50);

                entity.Property(e => e.IdEmpleado).HasMaxLength(50);

                entity.Property(e => e.Importado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreDispositivo).HasMaxLength(50);

                entity.Property(e => e.NombrePersona).HasMaxLength(50);

                entity.Property(e => e.NumSerieDispositivo).HasMaxLength(50);

                entity.Property(e => e.NumTarjeta).HasMaxLength(50);
            });

            modelBuilder.Entity<Certificado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Certificados", "PagoProvLeche");

                entity.Property(e => e.ActualizadoPor).HasMaxLength(8);

                entity.Property(e => e.Comentarios).HasMaxLength(100);

                entity.Property(e => e.CreadoPor).HasMaxLength(8);

                entity.Property(e => e.Empresa).HasMaxLength(4);

                entity.Property(e => e.FechaExpiracion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.NumeroDocumento).HasMaxLength(30);

                entity.Property(e => e.TipoCertificado).HasMaxLength(10);
            });

            modelBuilder.Entity<Clbarrio>(entity =>
            {
                entity.HasKey(e => e.Barriocod);

                entity.ToTable("CLBARRIO");

                entity.HasIndex(e => e.Barriocod, "CLBARRIO_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Barriocod).HasColumnName("BARRIOCOD");

                entity.Property(e => e.Barriodesc)
                    .HasMaxLength(128)
                    .HasColumnName("BARRIODESC");
            });

            modelBuilder.Entity<Clbloque>(entity =>
            {
                entity.HasKey(e => e.Bloquecod);

                entity.ToTable("CLBLOQUE");

                entity.HasIndex(e => e.Bloquecod, "CLBLOQUE_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Bloquecod).HasColumnName("BLOQUECOD");

                entity.Property(e => e.Bloquedesc)
                    .HasMaxLength(128)
                    .HasColumnName("BLOQUEDESC");
            });

            modelBuilder.Entity<Clcategorium>(entity =>
            {
                entity.HasKey(e => e.Categoriacod);

                entity.ToTable("CLCATEGORIA");

                entity.HasIndex(e => e.Categoriacod, "CLCATEGORIA_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Categoriacod).HasColumnName("CATEGORIACOD");

                entity.Property(e => e.Categoriadesc)
                    .HasMaxLength(128)
                    .HasColumnName("CATEGORIADESC");
            });

            modelBuilder.Entity<Clcliente>(entity =>
            {
                entity.HasKey(e => new { e.Clientecod, e.Proyectocod, e.Bloquecod, e.Rutacod, e.Barriocod, e.Parroquiacod, e.Zonaadmincod, e.Girocod, e.Categoriacod, e.Codigo });

                entity.ToTable("CLCLIENTE");

                entity.HasIndex(e => new { e.Clientecod, e.Proyectocod, e.Bloquecod, e.Rutacod, e.Barriocod, e.Parroquiacod, e.Zonaadmincod, e.Girocod, e.Categoriacod, e.Codigo }, "CLCLIENTE_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Clientecod)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CLIENTECOD");

                entity.Property(e => e.Proyectocod).HasColumnName("PROYECTOCOD");

                entity.Property(e => e.Bloquecod).HasColumnName("BLOQUECOD");

                entity.Property(e => e.Rutacod).HasColumnName("RUTACOD");

                entity.Property(e => e.Barriocod).HasColumnName("BARRIOCOD");

                entity.Property(e => e.Parroquiacod).HasColumnName("PARROQUIACOD");

                entity.Property(e => e.Zonaadmincod).HasColumnName("ZONAADMINCOD");

                entity.Property(e => e.Girocod).HasColumnName("GIROCOD");

                entity.Property(e => e.Categoriacod).HasColumnName("CATEGORIACOD");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(16)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Accountnum)
                    .HasMaxLength(16)
                    .HasColumnName("ACCOUNTNUM");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .HasColumnName("CEDULA");

                entity.Property(e => e.Censoabc)
                    .HasMaxLength(2)
                    .HasColumnName("CENSOABC");

                entity.Property(e => e.Censoexiste)
                    .HasMaxLength(2)
                    .HasColumnName("CENSOEXISTE");

                entity.Property(e => e.Censofch)
                    .HasColumnType("datetime")
                    .HasColumnName("CENSOFCH");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(256)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Latitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LATITUD");

                entity.Property(e => e.Longitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LONGITUD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Razonsocial)
                    .HasMaxLength(256)
                    .HasColumnName("RAZONSOCIAL");

                entity.Property(e => e.Salesroute)
                    .HasMaxLength(8)
                    .HasColumnName("SALESROUTE");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(16)
                    .HasColumnName("TELEFONO");

                entity.HasOne(d => d.BarriocodNavigation)
                    .WithMany(p => p.Clclientes)
                    .HasForeignKey(d => d.Barriocod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLCLIENT_REFERENCE_CLBARRIO");

                entity.HasOne(d => d.BloquecodNavigation)
                    .WithMany(p => p.Clclientes)
                    .HasForeignKey(d => d.Bloquecod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLCLIENT_REFERENCE_CLBLOQUE");

                entity.HasOne(d => d.CategoriacodNavigation)
                    .WithMany(p => p.Clclientes)
                    .HasForeignKey(d => d.Categoriacod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLCLIENT_REFERENCE_CLCATEGO");

                entity.HasOne(d => d.GirocodNavigation)
                    .WithMany(p => p.Clclientes)
                    .HasForeignKey(d => d.Girocod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLCLIENT_REFERENCE_CLGIRO");

                entity.HasOne(d => d.ParroquiacodNavigation)
                    .WithMany(p => p.Clclientes)
                    .HasForeignKey(d => d.Parroquiacod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLCLIENT_REFERENCE_CLPARROQ");

                entity.HasOne(d => d.ProyectocodNavigation)
                    .WithMany(p => p.Clclientes)
                    .HasForeignKey(d => d.Proyectocod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLCLIENT_REFERENCE_CLPROYEC");

                entity.HasOne(d => d.RutacodNavigation)
                    .WithMany(p => p.Clclientes)
                    .HasForeignKey(d => d.Rutacod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLCLIENT_REFERENCE_CLRUTA");

                entity.HasOne(d => d.ZonaadmincodNavigation)
                    .WithMany(p => p.Clclientes)
                    .HasForeignKey(d => d.Zonaadmincod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLCLIENT_REFERENCE_CLZONAAD");
            });

            modelBuilder.Entity<ClclienteChiVistum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CLCLIENTE_CHI_VISTA");

                entity.Property(e => e.Accountnum)
                    .HasMaxLength(16)
                    .HasColumnName("ACCOUNTNUM");

                entity.Property(e => e.Axruta)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("AXRUTA");

                entity.Property(e => e.Axsalesgroup)
                    .HasMaxLength(130)
                    .HasColumnName("AXSALESGROUP");

                entity.Property(e => e.Barriocod).HasColumnName("BARRIOCOD");

                entity.Property(e => e.Bloquecod).HasColumnName("BLOQUECOD");

                entity.Property(e => e.Categoriacod).HasColumnName("CATEGORIACOD");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .HasColumnName("CEDULA");

                entity.Property(e => e.Clientecod).HasColumnName("CLIENTECOD");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(16)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(256)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Girocod).HasColumnName("GIROCOD");

                entity.Property(e => e.Latitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LATITUD");

                entity.Property(e => e.Longitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LONGITUD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Parroquiacod).HasColumnName("PARROQUIACOD");

                entity.Property(e => e.Proyectocod).HasColumnName("PROYECTOCOD");

                entity.Property(e => e.Razonsocial)
                    .HasMaxLength(256)
                    .HasColumnName("RAZONSOCIAL");

                entity.Property(e => e.Rutacod).HasColumnName("RUTACOD");

                entity.Property(e => e.Rutacodt).HasColumnName("RUTACODT");

                entity.Property(e => e.Rutadesc)
                    .HasMaxLength(128)
                    .HasColumnName("RUTADESC");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(16)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.Zonaadmincod).HasColumnName("ZONAADMINCOD");
            });

            modelBuilder.Entity<ClclienteNorteVistum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CLCLIENTE_NORTE_VISTA");

                entity.Property(e => e.Accountnum)
                    .HasMaxLength(16)
                    .HasColumnName("ACCOUNTNUM");

                entity.Property(e => e.Axruta)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("AXRUTA");

                entity.Property(e => e.Axsalesgroup)
                    .HasMaxLength(130)
                    .HasColumnName("AXSALESGROUP");

                entity.Property(e => e.Barriocod).HasColumnName("BARRIOCOD");

                entity.Property(e => e.Bloquecod).HasColumnName("BLOQUECOD");

                entity.Property(e => e.Categoriacod).HasColumnName("CATEGORIACOD");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .HasColumnName("CEDULA");

                entity.Property(e => e.Clientecod).HasColumnName("CLIENTECOD");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(16)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(256)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Girocod).HasColumnName("GIROCOD");

                entity.Property(e => e.Latitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LATITUD");

                entity.Property(e => e.Longitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LONGITUD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Parroquiacod).HasColumnName("PARROQUIACOD");

                entity.Property(e => e.Proyectocod).HasColumnName("PROYECTOCOD");

                entity.Property(e => e.Razonsocial)
                    .HasMaxLength(256)
                    .HasColumnName("RAZONSOCIAL");

                entity.Property(e => e.Rutacod).HasColumnName("RUTACOD");

                entity.Property(e => e.Rutacodt).HasColumnName("RUTACODT");

                entity.Property(e => e.Rutadesc)
                    .HasMaxLength(128)
                    .HasColumnName("RUTADESC");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(16)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.Zonaadmincod).HasColumnName("ZONAADMINCOD");
            });

            modelBuilder.Entity<ClclienteNuevasRuta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CLCLIENTE_NUEVAS_RUTAS");

                entity.Property(e => e.Barriodesc)
                    .HasMaxLength(128)
                    .HasColumnName("BARRIODESC");

                entity.Property(e => e.CodClienteDynamics)
                    .HasMaxLength(16)
                    .HasColumnName("COD_CLIENTE_DYNAMICS");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(256)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.GiroDeNegocio)
                    .HasMaxLength(128)
                    .HasColumnName("GIRO_DE_NEGOCIO");

                entity.Property(e => e.Latitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LATITUD");

                entity.Property(e => e.Longitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LONGITUD");

                entity.Property(e => e.Nombrelocal)
                    .HasMaxLength(256)
                    .HasColumnName("NOMBRELOCAL");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(256)
                    .HasColumnName("NOMBRES");

                entity.Property(e => e.Parroquia)
                    .HasMaxLength(128)
                    .HasColumnName("PARROQUIA");

                entity.Property(e => e.RucCedula)
                    .HasMaxLength(13)
                    .HasColumnName("RUC_CEDULA");

                entity.Property(e => e.RutaOriginal)
                    .HasMaxLength(128)
                    .HasColumnName("RUTA ORIGINAL");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(16)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.Zona)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ZONA");
            });

            modelBuilder.Entity<ClclienteSurVistum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CLCLIENTE_SUR_VISTA");

                entity.Property(e => e.Accountnum)
                    .HasMaxLength(16)
                    .HasColumnName("ACCOUNTNUM");

                entity.Property(e => e.Axruta)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("AXRUTA");

                entity.Property(e => e.Axsalesgroup)
                    .HasMaxLength(130)
                    .HasColumnName("AXSALESGROUP");

                entity.Property(e => e.Barriocod).HasColumnName("BARRIOCOD");

                entity.Property(e => e.Bloquecod).HasColumnName("BLOQUECOD");

                entity.Property(e => e.Categoriacod).HasColumnName("CATEGORIACOD");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .HasColumnName("CEDULA");

                entity.Property(e => e.Clientecod).HasColumnName("CLIENTECOD");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(16)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(256)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Girocod).HasColumnName("GIROCOD");

                entity.Property(e => e.Latitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LATITUD");

                entity.Property(e => e.Longitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LONGITUD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Parroquiacod).HasColumnName("PARROQUIACOD");

                entity.Property(e => e.Proyectocod).HasColumnName("PROYECTOCOD");

                entity.Property(e => e.Razonsocial)
                    .HasMaxLength(256)
                    .HasColumnName("RAZONSOCIAL");

                entity.Property(e => e.Rutacod).HasColumnName("RUTACOD");

                entity.Property(e => e.Rutacodt).HasColumnName("RUTACODT");

                entity.Property(e => e.Rutadesc)
                    .HasMaxLength(128)
                    .HasColumnName("RUTADESC");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(16)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.Zonaadmincod).HasColumnName("ZONAADMINCOD");
            });

            modelBuilder.Entity<ClclienteTumVistum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CLCLIENTE_TUM_VISTA");

                entity.Property(e => e.Accountnum)
                    .HasMaxLength(16)
                    .HasColumnName("ACCOUNTNUM");

                entity.Property(e => e.Axruta)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("AXRUTA");

                entity.Property(e => e.Barriocod).HasColumnName("BARRIOCOD");

                entity.Property(e => e.Bloquecod).HasColumnName("BLOQUECOD");

                entity.Property(e => e.Categoriacod).HasColumnName("CATEGORIACOD");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .HasColumnName("CEDULA");

                entity.Property(e => e.Clientecod).HasColumnName("CLIENTECOD");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(16)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(256)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Girocod).HasColumnName("GIROCOD");

                entity.Property(e => e.Latitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LATITUD");

                entity.Property(e => e.Longitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LONGITUD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Parroquiacod).HasColumnName("PARROQUIACOD");

                entity.Property(e => e.Proyectocod).HasColumnName("PROYECTOCOD");

                entity.Property(e => e.Razonsocial)
                    .HasMaxLength(256)
                    .HasColumnName("RAZONSOCIAL");

                entity.Property(e => e.Rutacod).HasColumnName("RUTACOD");

                entity.Property(e => e.Rutacodt).HasColumnName("RUTACODT");

                entity.Property(e => e.Rutadesc)
                    .HasMaxLength(128)
                    .HasColumnName("RUTADESC");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(16)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.Zonaadmincod).HasColumnName("ZONAADMINCOD");
            });

            modelBuilder.Entity<Clgiro>(entity =>
            {
                entity.HasKey(e => e.Girocod);

                entity.ToTable("CLGIRO");

                entity.HasIndex(e => e.Girocod, "CLGIRO_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Girocod).HasColumnName("GIROCOD");

                entity.Property(e => e.Girodesc)
                    .HasMaxLength(128)
                    .HasColumnName("GIRODESC");

                entity.Property(e => e.Subsegmentid)
                    .HasMaxLength(128)
                    .HasColumnName("SUBSEGMENTID");
            });

            modelBuilder.Entity<ClientesCensado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClientesCensados");

                entity.Property(e => e.Accountnum)
                    .HasMaxLength(16)
                    .HasColumnName("ACCOUNTNUM");

                entity.Property(e => e.Axruta)
                    .HasMaxLength(33)
                    .IsUnicode(false)
                    .HasColumnName("AXRUTA");

                entity.Property(e => e.Axsalesgroup)
                    .HasMaxLength(130)
                    .HasColumnName("AXSALESGROUP");

                entity.Property(e => e.Barriocod).HasColumnName("BARRIOCOD");

                entity.Property(e => e.Bloquecod).HasColumnName("BLOQUECOD");

                entity.Property(e => e.Categoriacod).HasColumnName("CATEGORIACOD");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(13)
                    .HasColumnName("CEDULA");

                entity.Property(e => e.CensoFecha).HasColumnType("datetime");

                entity.Property(e => e.Clientecod).HasColumnName("CLIENTECOD");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(16)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(256)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Existe).HasMaxLength(2);

                entity.Property(e => e.Girocod).HasColumnName("GIROCOD");

                entity.Property(e => e.Latitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LATITUD");

                entity.Property(e => e.Longitud)
                    .HasColumnType("decimal(16, 8)")
                    .HasColumnName("LONGITUD");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Parroquiacod).HasColumnName("PARROQUIACOD");

                entity.Property(e => e.Proyectocod).HasColumnName("PROYECTOCOD");

                entity.Property(e => e.Razonsocial)
                    .HasMaxLength(256)
                    .HasColumnName("RAZONSOCIAL");

                entity.Property(e => e.Rutacod).HasColumnName("RUTACOD");

                entity.Property(e => e.Rutacodt).HasColumnName("RUTACODT");

                entity.Property(e => e.Rutadesc)
                    .HasMaxLength(128)
                    .HasColumnName("RUTADESC");

                entity.Property(e => e.Secuencia).HasColumnName("SECUENCIA");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(16)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.Zonaadmincod).HasColumnName("ZONAADMINCOD");
            });

            modelBuilder.Entity<Clparroquium>(entity =>
            {
                entity.HasKey(e => e.Parroquiacod);

                entity.ToTable("CLPARROQUIA");

                entity.HasIndex(e => e.Parroquiacod, "CLPARROQUIA_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Parroquiacod).HasColumnName("PARROQUIACOD");

                entity.Property(e => e.Parroquiadesc)
                    .HasMaxLength(128)
                    .HasColumnName("PARROQUIADESC");
            });

            modelBuilder.Entity<Clproyecto>(entity =>
            {
                entity.HasKey(e => e.Proyectocod);

                entity.ToTable("CLPROYECTO");

                entity.HasIndex(e => e.Proyectocod, "CLPROYECTO_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Proyectocod).HasColumnName("PROYECTOCOD");

                entity.Property(e => e.Proyectodec)
                    .HasMaxLength(128)
                    .HasColumnName("PROYECTODEC");
            });

            modelBuilder.Entity<Clrutum>(entity =>
            {
                entity.HasKey(e => e.Rutacod);

                entity.ToTable("CLRUTA");

                entity.HasIndex(e => e.Rutacod, "CLRUTA_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Rutacod).HasColumnName("RUTACOD");

                entity.Property(e => e.Rutadesc)
                    .HasMaxLength(128)
                    .HasColumnName("RUTADESC");
            });

            modelBuilder.Entity<Clzonaadmin>(entity =>
            {
                entity.HasKey(e => e.Zonaadmincod);

                entity.ToTable("CLZONAADMIN");

                entity.HasIndex(e => e.Zonaadmincod, "CLZONAADMIN_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Zonaadmincod).HasColumnName("ZONAADMINCOD");

                entity.Property(e => e.Zonaadmindesc)
                    .HasMaxLength(128)
                    .HasColumnName("ZONAADMINDESC");
            });

            modelBuilder.Entity<ComedorParametrosServicio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ComedorParametrosServicio");

                entity.Property(e => e.Sitio).HasMaxLength(10);

                entity.Property(e => e.TipoServicio).HasMaxLength(20);
            });

            modelBuilder.Entity<ComedorRegistroServicio>(entity =>
            {
                entity.Property(e => e.CedulaRuc).HasMaxLength(30);

                entity.Property(e => e.CodigoAlternoPersona)
                    .HasMaxLength(50)
                    .HasColumnName("CODIGO_ALTERNO_PERSONA");

                entity.Property(e => e.CreadoPor).HasMaxLength(100);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaHoraRegistro).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.OrigenRegistro).HasMaxLength(60);

                entity.Property(e => e.SitioServicio).HasMaxLength(10);

                entity.Property(e => e.TipoServicio).HasMaxLength(20);
            });

            modelBuilder.Entity<Companyview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("COMPANYVIEW", "Ax2012");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("NAME");

                entity.Property(e => e.Partition).HasColumnName("PARTITION");

                entity.Property(e => e.Recid).HasColumnName("RECID");
            });

            modelBuilder.Entity<Despacho>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("Despacho");

                entity.Property(e => e.Almacen).HasMaxLength(30);

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Estado).HasMaxLength(30);

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaHoraFin).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraInicio).HasColumnType("datetime");

                entity.Property(e => e.Localidad).HasMaxLength(30);

                entity.Property(e => e.ResponsableJabas).HasMaxLength(100);

                entity.Property(e => e.ResponsableJabasCodigo).HasMaxLength(10);
            });

            modelBuilder.Entity<DespachoFactura>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DespachoProductoTerminado");

                entity.ToTable("DespachoFactura");

                entity.HasIndex(e => new { e.CustInvoiceJourRecId, e.Empresa }, "NonClusteredIndex-20220629-155250")
                    .IsUnique()
                    .HasFillFactor(80);

                entity.Property(e => e.CodigoCliente).HasMaxLength(20);

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.Empresa).HasMaxLength(4);

                entity.Property(e => e.FechaFactura).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.NumFactura).HasMaxLength(20);

                entity.Property(e => e.NumberSequenceGroup).HasMaxLength(30);

                entity.Property(e => e.OrdenVenta).HasMaxLength(20);

                entity.HasOne(d => d.DespachoRec)
                    .WithMany(p => p.DespachoFacturas)
                    .HasForeignKey(d => d.DespachoRecId)
                    .HasConstraintName("FK_DespachoFactura_Despacho");
            });

            modelBuilder.Entity<DespachoFacturaDetalle>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("DespachoFacturaDetalle");

                entity.Property(e => e.Almacen).HasMaxLength(30);

                entity.Property(e => e.Articulo).HasMaxLength(40);

                entity.Property(e => e.ArticuloCodigo).HasMaxLength(60);

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.Empresa).HasMaxLength(4);

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Localidad).HasMaxLength(10);

                entity.Property(e => e.Lote).HasMaxLength(50);

                entity.HasOne(d => d.DespachoFacturaRec)
                    .WithMany(p => p.DespachoFacturaDetalles)
                    .HasForeignKey(d => d.DespachoFacturaRecId)
                    .HasConstraintName("FK_DespachoFacturaDetalle_DespachoFactura");
            });

            modelBuilder.Entity<DespachoJaba>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.ToTable("DespachoJaba");

                entity.Property(e => e.Almacen).HasMaxLength(30);

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItemId).HasMaxLength(60);

                entity.Property(e => e.JabaId).HasMaxLength(20);

                entity.Property(e => e.Localidad).HasMaxLength(30);

                entity.HasOne(d => d.DespachoRec)
                    .WithMany(p => p.DespachoJabas)
                    .HasForeignKey(d => d.DespachoRecId)
                    .HasConstraintName("FK_DespachoJaba_Despacho");
            });

            modelBuilder.Entity<DespachoPallet>(entity =>
            {
                entity.HasKey(e => e.RecId);

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.Empresa)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaProduccion).HasColumnType("date");

                entity.Property(e => e.ItemId).HasMaxLength(60);

                entity.Property(e => e.JabaId).HasMaxLength(20);

                entity.Property(e => e.NumLote).HasMaxLength(60);

                entity.Property(e => e.PalletId).HasMaxLength(200);

                entity.HasOne(d => d.DespachoRec)
                    .WithMany(p => p.DespachoPallets)
                    .HasForeignKey(d => d.DespachoRecId)
                    .HasConstraintName("FK_DespachoPallets_Despacho");
            });

            modelBuilder.Entity<DespachoProductoTerminado>(entity =>
            {
                entity.HasKey(e => e.RecId)
                    .HasName("PK_DespachoProductoTerminado_1");

                entity.ToTable("DespachoProductoTerminado");

                entity.Property(e => e.Almacen).HasMaxLength(30);

                entity.Property(e => e.Articulo).HasMaxLength(40);

                entity.Property(e => e.ArticuloCodigo).HasMaxLength(60);

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.Empresa).HasMaxLength(4);

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Localidad).HasMaxLength(30);

                entity.HasOne(d => d.DespachoRec)
                    .WithMany(p => p.DespachoProductoTerminados)
                    .HasForeignKey(d => d.DespachoRecId)
                    .HasConstraintName("FK_DespachoProductoTerminadoDetalle_Despacho");
            });

            modelBuilder.Entity<DirPartyTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DirPartyTable", "Ax2012");

                entity.Property(e => e.Abc).HasColumnName("ABC");

                entity.Property(e => e.AccountantLt)
                    .HasMaxLength(100)
                    .HasColumnName("ACCOUNTANT_LT");

                entity.Property(e => e.AccountingpersonnelJp)
                    .HasMaxLength(100)
                    .HasColumnName("ACCOUNTINGPERSONNEL_JP");

                entity.Property(e => e.Accountofficerefnum)
                    .HasMaxLength(13)
                    .HasColumnName("ACCOUNTOFFICEREFNUM");

                entity.Property(e => e.Activitycode)
                    .HasMaxLength(9)
                    .HasColumnName("ACTIVITYCODE");

                entity.Property(e => e.Addrformat)
                    .HasMaxLength(30)
                    .HasColumnName("ADDRFORMAT");

                entity.Property(e => e.Anniversaryday).HasColumnName("ANNIVERSARYDAY");

                entity.Property(e => e.Anniversarymonth).HasColumnName("ANNIVERSARYMONTH");

                entity.Property(e => e.Anniversaryyear).HasColumnName("ANNIVERSARYYEAR");

                entity.Property(e => e.Bank)
                    .HasMaxLength(10)
                    .HasColumnName("BANK");

                entity.Property(e => e.Bankacctusedfor1099)
                    .HasMaxLength(10)
                    .HasColumnName("BANKACCTUSEDFOR1099");

                entity.Property(e => e.Bankcentralbankpurposecode)
                    .HasMaxLength(10)
                    .HasColumnName("BANKCENTRALBANKPURPOSECODE");

                entity.Property(e => e.Bankcentralbankpurposetext)
                    .HasMaxLength(140)
                    .HasColumnName("BANKCENTRALBANKPURPOSETEXT");

                entity.Property(e => e.Birthday).HasColumnName("BIRTHDAY");

                entity.Property(e => e.Birthmonth).HasColumnName("BIRTHMONTH");

                entity.Property(e => e.Birthyear).HasColumnName("BIRTHYEAR");

                entity.Property(e => e.Branchid)
                    .HasMaxLength(10)
                    .HasColumnName("BRANCHID");

                entity.Property(e => e.Branchnumber)
                    .HasMaxLength(13)
                    .HasColumnName("BRANCHNUMBER");

                entity.Property(e => e.BusinessactivitySa)
                    .HasMaxLength(10)
                    .HasColumnName("BUSINESSACTIVITY_SA");

                entity.Property(e => e.BusinessactivitydescSa)
                    .HasMaxLength(100)
                    .HasColumnName("BUSINESSACTIVITYDESC_SA");

                entity.Property(e => e.BusinesscommenceddateJp)
                    .HasColumnType("datetime")
                    .HasColumnName("BUSINESSCOMMENCEDDATE_JP");

                entity.Property(e => e.BusinessinitialcapitalJp)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("BUSINESSINITIALCAPITAL_JP");

                entity.Property(e => e.BusinessitemJp)
                    .HasMaxLength(30)
                    .HasColumnName("BUSINESSITEM_JP");

                entity.Property(e => e.BusinessnumberCa)
                    .HasMaxLength(9)
                    .HasColumnName("BUSINESSNUMBER_CA");

                entity.Property(e => e.CertifiedtaxaccountantJp)
                    .HasMaxLength(100)
                    .HasColumnName("CERTIFIEDTAXACCOUNTANT_JP");

                entity.Property(e => e.Childrennames)
                    .HasMaxLength(150)
                    .HasColumnName("CHILDRENNAMES");

                entity.Property(e => e.CnaeBr)
                    .HasMaxLength(10)
                    .HasColumnName("CNAE_BR");

                entity.Property(e => e.Combinedfedstatefiler).HasColumnName("COMBINEDFEDSTATEFILER");

                entity.Property(e => e.Commercialregister)
                    .HasMaxLength(40)
                    .HasColumnName("COMMERCIALREGISTER");

                entity.Property(e => e.Commercialregisterinsetnumber)
                    .HasMaxLength(10)
                    .HasColumnName("COMMERCIALREGISTERINSETNUMBER");

                entity.Property(e => e.Commercialregistersection)
                    .HasMaxLength(10)
                    .HasColumnName("COMMERCIALREGISTERSECTION");

                entity.Property(e => e.Communicatorsignin).HasColumnName("COMMUNICATORSIGNIN");

                entity.Property(e => e.Companynafcode).HasColumnName("COMPANYNAFCODE");

                entity.Property(e => e.Companyregcomfr)
                    .HasMaxLength(30)
                    .HasColumnName("COMPANYREGCOMFR");

                entity.Property(e => e.CompanyrepresentativeJp)
                    .HasMaxLength(100)
                    .HasColumnName("COMPANYREPRESENTATIVE_JP");

                entity.Property(e => e.CompanytypeMx).HasColumnName("COMPANYTYPE_MX");

                entity.Property(e => e.Conversiondate)
                    .HasColumnType("datetime")
                    .HasColumnName("CONVERSIONDATE");

                entity.Property(e => e.Coregnum)
                    .HasMaxLength(25)
                    .HasColumnName("COREGNUM");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(8)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATETIME");

                entity.Property(e => e.CucIt)
                    .HasMaxLength(8)
                    .HasColumnName("CUC_IT");

                entity.Property(e => e.CurpMx)
                    .HasMaxLength(18)
                    .HasColumnName("CURP_MX");

                entity.Property(e => e.CustomscustomernumberFi)
                    .HasMaxLength(20)
                    .HasColumnName("CUSTOMSCUSTOMERNUMBER_FI");

                entity.Property(e => e.CustomslicensenumberFi)
                    .HasMaxLength(20)
                    .HasColumnName("CUSTOMSLICENSENUMBER_FI");

                entity.Property(e => e.Dataarea)
                    .HasMaxLength(4)
                    .HasColumnName("DATAAREA");

                entity.Property(e => e.Dba)
                    .HasMaxLength(100)
                    .HasColumnName("DBA");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Dunsnumberrecid).HasColumnName("DUNSNUMBERRECID");

                entity.Property(e => e.Dvrid)
                    .HasMaxLength(20)
                    .HasColumnName("DVRID");

                entity.Property(e => e.Enterprisecode)
                    .HasMaxLength(50)
                    .HasColumnName("ENTERPRISECODE");

                entity.Property(e => e.Enterprisenumber)
                    .HasMaxLength(50)
                    .HasColumnName("ENTERPRISENUMBER");

                entity.Property(e => e.FicreditoridDk)
                    .HasMaxLength(8)
                    .HasColumnName("FICREDITORID_DK");

                entity.Property(e => e.FilenumberSa)
                    .HasMaxLength(15)
                    .HasColumnName("FILENUMBER_SA");

                entity.Property(e => e.FiscalcodeIt)
                    .HasMaxLength(11)
                    .HasColumnName("FISCALCODE_IT");

                entity.Property(e => e.Foreignentityindicator).HasColumnName("FOREIGNENTITYINDICATOR");

                entity.Property(e => e.FssRu)
                    .HasMaxLength(10)
                    .HasColumnName("FSS_RU");

                entity.Property(e => e.FssaccountRu)
                    .HasMaxLength(20)
                    .HasColumnName("FSSACCOUNT_RU");

                entity.Property(e => e.Gender).HasColumnName("GENDER");

                entity.Property(e => e.Giro)
                    .HasMaxLength(35)
                    .HasColumnName("GIRO");

                entity.Property(e => e.Girocontract)
                    .HasMaxLength(10)
                    .HasColumnName("GIROCONTRACT");

                entity.Property(e => e.Girocontractaccount)
                    .HasMaxLength(11)
                    .HasColumnName("GIROCONTRACTACCOUNT");

                entity.Property(e => e.Hcmworker).HasColumnName("HCMWORKER");

                entity.Property(e => e.HeadLt)
                    .HasMaxLength(100)
                    .HasColumnName("HEAD_LT");

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(150)
                    .HasColumnName("HOBBIES");

                entity.Property(e => e.Importvatnum)
                    .HasMaxLength(20)
                    .HasColumnName("IMPORTVATNUM");

                entity.Property(e => e.Importvatnumbranchid)
                    .HasMaxLength(10)
                    .HasColumnName("IMPORTVATNUMBRANCHID");

                entity.Property(e => e.Initials)
                    .HasMaxLength(10)
                    .HasColumnName("INITIALS");

                entity.Property(e => e.Instancerelationtype).HasColumnName("INSTANCERELATIONTYPE");

                entity.Property(e => e.Intrastatcode)
                    .HasMaxLength(10)
                    .HasColumnName("INTRASTATCODE");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Isconsolidationcompany).HasColumnName("ISCONSOLIDATIONCOMPANY");

                entity.Property(e => e.Iseliminationcompany).HasColumnName("ISELIMINATIONCOMPANY");

                entity.Property(e => e.Issuingsignature)
                    .HasMaxLength(20)
                    .HasColumnName("ISSUINGSIGNATURE");

                entity.Property(e => e.Key).HasColumnName("KEY_");

                entity.Property(e => e.Knownas)
                    .HasMaxLength(100)
                    .HasColumnName("KNOWNAS");

                entity.Property(e => e.Languageid)
                    .HasMaxLength(7)
                    .HasColumnName("LANGUAGEID");

                entity.Property(e => e.Lastfilingindicator).HasColumnName("LASTFILINGINDICATOR");

                entity.Property(e => e.Legalformfr)
                    .HasMaxLength(100)
                    .HasColumnName("LEGALFORMFR");

                entity.Property(e => e.LegalnatureIt).HasColumnName("LEGALNATURE_IT");

                entity.Property(e => e.LegalrepresentativeJp)
                    .HasMaxLength(100)
                    .HasColumnName("LEGALREPRESENTATIVE_JP");

                entity.Property(e => e.LegalrepresentativecurpMx)
                    .HasMaxLength(18)
                    .HasColumnName("LEGALREPRESENTATIVECURP_MX");

                entity.Property(e => e.LegalrepresentativenameMx)
                    .HasMaxLength(50)
                    .HasColumnName("LEGALREPRESENTATIVENAME_MX");

                entity.Property(e => e.LegalrepresentativerfcMx)
                    .HasMaxLength(13)
                    .HasColumnName("LEGALREPRESENTATIVERFC_MX");

                entity.Property(e => e.Maritalstatus).HasColumnName("MARITALSTATUS");

                entity.Property(e => e.MntCommercialname)
                    .HasMaxLength(100)
                    .HasColumnName("MNT_COMMERCIALNAME");

                entity.Property(e => e.MntContribuyenteespecial)
                    .HasMaxLength(10)
                    .HasColumnName("MNT_CONTRIBUYENTEESPECIAL");

                entity.Property(e => e.MntObligadocontabilidad).HasColumnName("MNT_OBLIGADOCONTABILIDAD");

                entity.Property(e => e.Mntcontribuyenteespecial1)
                    .HasMaxLength(10)
                    .HasColumnName("MNTCONTRIBUYENTEESPECIAL");

                entity.Property(e => e.Mntobligadocontabilidad1).HasColumnName("MNTOBLIGADOCONTABILIDAD");

                entity.Property(e => e.Mntversionretencion).HasColumnName("MNTVERSIONRETENCION");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(8)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATETIME");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("NAME");

                entity.Property(e => e.Namealias)
                    .HasMaxLength(100)
                    .HasColumnName("NAMEALIAS");

                entity.Property(e => e.Namecontrol)
                    .HasMaxLength(4)
                    .HasColumnName("NAMECONTROL");

                entity.Property(e => e.Namesequence).HasColumnName("NAMESEQUENCE");

                entity.Property(e => e.Numberofemployees).HasColumnName("NUMBEROFEMPLOYEES");

                entity.Property(e => e.Omoperatingunitnumber)
                    .HasMaxLength(8)
                    .HasColumnName("OMOPERATINGUNITNUMBER");

                entity.Property(e => e.Omoperatingunittype).HasColumnName("OMOPERATINGUNITTYPE");

                entity.Property(e => e.OrganizationlegalformRu)
                    .HasMaxLength(40)
                    .HasColumnName("ORGANIZATIONLEGALFORM_RU");

                entity.Property(e => e.Organizationtype).HasColumnName("ORGANIZATIONTYPE");

                entity.Property(e => e.Orgid)
                    .HasMaxLength(10)
                    .HasColumnName("ORGID");

                entity.Property(e => e.Orgnumber)
                    .HasMaxLength(25)
                    .HasColumnName("ORGNUMBER");

                entity.Property(e => e.Packmaterialfeelicensenum)
                    .HasMaxLength(20)
                    .HasColumnName("PACKMATERIALFEELICENSENUM");

                entity.Property(e => e.Partition).HasColumnName("PARTITION");

                entity.Property(e => e.Partynumber)
                    .HasMaxLength(40)
                    .HasColumnName("PARTYNUMBER");

                entity.Property(e => e.Payminstruction1).HasColumnName("PAYMINSTRUCTION1");

                entity.Property(e => e.Payminstruction2).HasColumnName("PAYMINSTRUCTION2");

                entity.Property(e => e.Payminstruction3).HasColumnName("PAYMINSTRUCTION3");

                entity.Property(e => e.Payminstruction4).HasColumnName("PAYMINSTRUCTION4");

                entity.Property(e => e.Paymroutingdnb)
                    .HasMaxLength(8)
                    .HasColumnName("PAYMROUTINGDNB");

                entity.Property(e => e.Paymtradernumber)
                    .HasMaxLength(4)
                    .HasColumnName("PAYMTRADERNUMBER");

                entity.Property(e => e.Personalsuffix).HasColumnName("PERSONALSUFFIX");

                entity.Property(e => e.Personaltitle).HasColumnName("PERSONALTITLE");

                entity.Property(e => e.PersoninchargeJp)
                    .HasMaxLength(100)
                    .HasColumnName("PERSONINCHARGE_JP");

                entity.Property(e => e.PfregnumRu)
                    .HasMaxLength(14)
                    .HasColumnName("PFREGNUM_RU");

                entity.Property(e => e.Phoneticfirstname)
                    .HasMaxLength(25)
                    .HasColumnName("PHONETICFIRSTNAME");

                entity.Property(e => e.Phoneticlastname)
                    .HasMaxLength(25)
                    .HasColumnName("PHONETICLASTNAME");

                entity.Property(e => e.Phoneticmiddlename)
                    .HasMaxLength(25)
                    .HasColumnName("PHONETICMIDDLENAME");

                entity.Property(e => e.Phoneticname)
                    .HasMaxLength(100)
                    .HasColumnName("PHONETICNAME");

                entity.Property(e => e.Planningcompany).HasColumnName("PLANNINGCOMPANY");

                entity.Property(e => e.Primaryaddresslocation).HasColumnName("PRIMARYADDRESSLOCATION");

                entity.Property(e => e.Primarycontactemail).HasColumnName("PRIMARYCONTACTEMAIL");

                entity.Property(e => e.Primarycontactfax).HasColumnName("PRIMARYCONTACTFAX");

                entity.Property(e => e.Primarycontactphone).HasColumnName("PRIMARYCONTACTPHONE");

                entity.Property(e => e.Primarycontacttelex).HasColumnName("PRIMARYCONTACTTELEX");

                entity.Property(e => e.Primarycontacturl).HasColumnName("PRIMARYCONTACTURL");

                entity.Property(e => e.PrintcorrinvoicelabelDe).HasColumnName("PRINTCORRINVOICELABEL_DE");

                entity.Property(e => e.PrintcorrinvoicelabeleffdateDe)
                    .HasColumnType("datetime")
                    .HasColumnName("PRINTCORRINVOICELABELEFFDATE_DE");

                entity.Property(e => e.PrintenterpriseregisterNo).HasColumnName("PRINTENTERPRISEREGISTER_NO");

                entity.Property(e => e.PrintinnkppinaddressRu).HasColumnName("PRINTINNKPPINADDRESS_RU");

                entity.Property(e => e.Professionalsuffix)
                    .HasMaxLength(50)
                    .HasColumnName("PROFESSIONALSUFFIX");

                entity.Property(e => e.Professionaltitle)
                    .HasMaxLength(50)
                    .HasColumnName("PROFESSIONALTITLE");

                entity.Property(e => e.Raliencorpcountry)
                    .HasMaxLength(30)
                    .HasColumnName("RALIENCORPCOUNTRY");

                entity.Property(e => e.Raliencorpname)
                    .HasMaxLength(100)
                    .HasColumnName("RALIENCORPNAME");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Recversion).HasColumnName("RECVERSION");

                entity.Property(e => e.Regnum)
                    .HasMaxLength(25)
                    .HasColumnName("REGNUM");

                entity.Property(e => e.Relationtype).HasColumnName("RELATIONTYPE");

                entity.Property(e => e.ResidentW).HasColumnName("RESIDENT_W");

                entity.Property(e => e.RfcMx)
                    .HasMaxLength(13)
                    .HasColumnName("RFC_MX");

                entity.Property(e => e.Rfullname)
                    .HasMaxLength(100)
                    .HasColumnName("RFULLNAME");

                entity.Property(e => e.Shippingcalendarid)
                    .HasMaxLength(10)
                    .HasColumnName("SHIPPINGCALENDARID");

                entity.Property(e => e.Siacode)
                    .HasMaxLength(5)
                    .HasColumnName("SIACODE");

                entity.Property(e => e.SoftwareidentificationcodeCa)
                    .HasMaxLength(8)
                    .HasColumnName("SOFTWAREIDENTIFICATIONCODE_CA");

                entity.Property(e => e.StateinscriptionMx)
                    .HasMaxLength(30)
                    .HasColumnName("STATEINSCRIPTION_MX");

                entity.Property(e => e.Subordinatecode)
                    .HasMaxLength(5)
                    .HasColumnName("SUBORDINATECODE");

                entity.Property(e => e.Tax1099regnum)
                    .HasMaxLength(11)
                    .HasColumnName("TAX1099REGNUM");

                entity.Property(e => e.TaxauthorityRu)
                    .HasMaxLength(30)
                    .HasColumnName("TAXAUTHORITY_RU");

                entity.Property(e => e.Taxrepresentative)
                    .HasMaxLength(45)
                    .HasColumnName("TAXREPRESENTATIVE");

                entity.Property(e => e.Tcc)
                    .HasMaxLength(5)
                    .HasColumnName("TCC");

                entity.Property(e => e.Teamadministrator)
                    .HasMaxLength(8)
                    .HasColumnName("TEAMADMINISTRATOR");

                entity.Property(e => e.Teammembershipcriterion).HasColumnName("TEAMMEMBERSHIPCRITERION");

                entity.Property(e => e.TemplatefolderW)
                    .HasMaxLength(259)
                    .HasColumnName("TEMPLATEFOLDER_W");

                entity.Property(e => e.Upsnum)
                    .HasMaxLength(20)
                    .HasColumnName("UPSNUM");

                entity.Property(e => e.Validate1099onentry).HasColumnName("VALIDATE1099ONENTRY");

                entity.Property(e => e.Vatnum)
                    .HasMaxLength(20)
                    .HasColumnName("VATNUM");

                entity.Property(e => e.Vatnumbranchid)
                    .HasMaxLength(10)
                    .HasColumnName("VATNUMBRANCHID");
            });

            modelBuilder.Entity<FechaProceso>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.Empresa });

                entity.ToTable("FechaProceso", "PagoProvLeche");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Empresa).HasMaxLength(10);

                entity.Property(e => e.EstadoCalidad).HasMaxLength(20);

                entity.Property(e => e.EstadoPago).HasMaxLength(20);

                entity.Property(e => e.EstadoRecepcion).HasMaxLength(20);
            });

            modelBuilder.Entity<InfControlProceso>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Descripcion).HasMaxLength(300);

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.IdProceso).HasMaxLength(120);

                entity.Property(e => e.Origen).HasMaxLength(200);
            });

            modelBuilder.Entity<InvCierreCompuestosDet>(entity =>
            {
                entity.HasKey(e => new { e.IdInvfin, e.Itemid });

                entity.ToTable("INV_CIERRE_COMPUESTOS_DET");

                entity.HasIndex(e => new { e.IdInvfin, e.Itemid }, "INV_CIERRE_COMPUESTOS_DET_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.IdInvfin).HasColumnName("ID_INVFIN");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(128)
                    .HasColumnName("ITEMDESC");

                entity.Property(e => e.Litros)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("LITROS");

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("UNIDADES");

                entity.HasOne(d => d.IdInvfinNavigation)
                    .WithMany(p => p.InvCierreCompuestosDets)
                    .HasForeignKey(d => d.IdInvfin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INV_CIER_CIERRECMP_INV_CIER");
            });

            modelBuilder.Entity<InvCierreCompuestosHead>(entity =>
            {
                entity.HasKey(e => e.IdInvfin);

                entity.ToTable("INV_CIERRE_COMPUESTOS_HEAD");

                entity.HasIndex(e => e.IdInvfin, "INV_CIERRE_COMPUESTOS_HEAD_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.IdInvfin).HasColumnName("ID_INVFIN");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Fchcierre)
                    .HasColumnType("datetime")
                    .HasColumnName("FCHCIERRE");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(128)
                    .HasColumnName("ITEMDESC");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Litros)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("LITROS");

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<InvDisponibleCierredium>(entity =>
            {
                entity.HasKey(e => e.IdInvcierredia);

                entity.ToTable("INV_DISPONIBLE_CIERREDIA");

                entity.Property(e => e.IdInvcierredia).HasColumnName("ID_INVCIERREDIA");

                entity.Property(e => e.Armado)
                    .HasMaxLength(2)
                    .HasColumnName("ARMADO");

                entity.Property(e => e.Bodega)
                    .HasMaxLength(16)
                    .HasColumnName("BODEGA");

                entity.Property(e => e.BodegaDesc)
                    .HasMaxLength(128)
                    .HasColumnName("BODEGA_DESC");

                entity.Property(e => e.DespAutoservicios)
                    .HasMaxLength(16)
                    .HasColumnName("DESP_AUTOSERVICIOS");

                entity.Property(e => e.DiasRestantes).HasColumnName("DIAS_RESTANTES");

                entity.Property(e => e.EstadoDispLote)
                    .HasMaxLength(16)
                    .HasColumnName("ESTADO_DISP_LOTE");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.FactorEstad)
                    .HasColumnType("decimal(6, 3)")
                    .HasColumnName("FACTOR_ESTAD");

                entity.Property(e => e.FchAutoservicios)
                    .HasColumnType("datetime")
                    .HasColumnName("FCH_AUTOSERVICIOS");

                entity.Property(e => e.FchCaducidad)
                    .HasColumnType("datetime")
                    .HasColumnName("FCH_CADUCIDAD");

                entity.Property(e => e.FchProduccion)
                    .HasColumnType("datetime")
                    .HasColumnName("FCH_PRODUCCION");

                entity.Property(e => e.Fchcierre)
                    .HasColumnType("datetime")
                    .HasColumnName("FCHCIERRE");

                entity.Property(e => e.ItemDesc)
                    .HasMaxLength(128)
                    .HasColumnName("ITEM_DESC");

                entity.Property(e => e.ItemLinea)
                    .HasMaxLength(128)
                    .HasColumnName("ITEM_LINEA");

                entity.Property(e => e.ItemSublinea)
                    .HasMaxLength(128)
                    .HasColumnName("ITEM_SUBLINEA");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(16)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.LineaProduccion)
                    .HasMaxLength(16)
                    .HasColumnName("LINEA_PRODUCCION");

                entity.Property(e => e.Localidad)
                    .HasMaxLength(128)
                    .HasColumnName("LOCALIDAD");

                entity.Property(e => e.NoLote)
                    .HasMaxLength(16)
                    .HasColumnName("NO_LOTE");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("PORCENTAJE");

                entity.Property(e => e.Sitio)
                    .HasMaxLength(16)
                    .HasColumnName("SITIO");

                entity.Property(e => e.TipoDeInventario)
                    .HasMaxLength(32)
                    .HasColumnName("TIPO_DE_INVENTARIO");

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("UNIDADES");

                entity.Property(e => e.UnidadesEstad)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("UNIDADES_ESTAD");

                entity.Property(e => e.VidautilDias).HasColumnName("VIDAUTIL_DIAS");
            });

            modelBuilder.Entity<LimpArea>(entity =>
            {
                entity.HasKey(e => new { e.CodArea, e.CodEmpresa });

                entity.ToTable("LimpArea", "Prod");

                entity.Property(e => e.CodArea)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActualizadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodRegistro).ValueGeneratedOnAdd();

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<LimpFormulario>(entity =>
            {
                entity.HasKey(e => new { e.CodFormulario, e.CodEmpresa })
                    .HasName("PK_LimpConfFormulario_1");

                entity.ToTable("LimpFormulario", "Prod");

                entity.Property(e => e.CodFormulario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActualizadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodArea)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodRegistro).ValueGeneratedOnAdd();

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.LimpFormularios)
                    .HasForeignKey(d => new { d.CodArea, d.CodEmpresa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LimpConfFormulario_LimpArea");
            });

            modelBuilder.Entity<LimpFormularioActividad>(entity =>
            {
                entity.HasKey(e => new { e.CodActividad, e.CodEmpresa, e.CodFormulario })
                    .HasName("PK_LimpConfFormularioActividad_1");

                entity.ToTable("LimpFormularioActividad", "Prod");

                entity.Property(e => e.CodActividad).ValueGeneratedOnAdd();

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodFormulario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActualixzadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Decsripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.LimpFormularioActividads)
                    .HasForeignKey(d => new { d.CodFormulario, d.CodEmpresa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LimpConfFormularioActividad_LimpConfFormulario");
            });

            modelBuilder.Entity<LimpRegistro>(entity =>
            {
                entity.HasKey(e => e.NumFormulario);

                entity.ToTable("LimpRegistro", "Prod");

                entity.Property(e => e.CodArea)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodFormulario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraRevisado).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraVerificacion).HasColumnType("datetime");

                entity.Property(e => e.RevisadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.Turno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VerificadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((20))");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.LimpRegistros)
                    .HasForeignKey(d => new { d.CodFormulario, d.CodEmpresa })
                    .HasConstraintName("FK_LimpRegistro_LimpFormulario");
            });

            modelBuilder.Entity<LimpRegistroDetalle>(entity =>
            {
                entity.HasKey(e => e.CodRegistro);

                entity.ToTable("LimpRegistroDetalle", "Prod");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodFormulario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.CodResponsable)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraVerificacion).HasColumnType("datetime");

                entity.Property(e => e.RevisadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VerificadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.NumFormularioNavigation)
                    .WithMany(p => p.LimpRegistroDetalles)
                    .HasForeignKey(d => d.NumFormulario)
                    .HasConstraintName("FK_LimpRegistroDetalle_LimpRegistro");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.LimpRegistroDetalles)
                    .HasForeignKey(d => new { d.CodActividad, d.CodEmpresa, d.CodFormulario })
                    .HasConstraintName("FK_LimpRegistroDetalle_LimpFormularioActividad");
            });

            modelBuilder.Entity<Logisticselectronicaddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LOGISTICSELECTRONICADDRESS", "Ax2012");

                entity.Property(e => e.Countryregioncode)
                    .HasMaxLength(5)
                    .HasColumnName("COUNTRYREGIONCODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Isinstantmessage).HasColumnName("ISINSTANTMESSAGE");

                entity.Property(e => e.Ismobilephone).HasColumnName("ISMOBILEPHONE");

                entity.Property(e => e.Isprimary).HasColumnName("ISPRIMARY");

                entity.Property(e => e.Isprivate).HasColumnName("ISPRIVATE");

                entity.Property(e => e.Location).HasColumnName("LOCATION");

                entity.Property(e => e.Locator)
                    .HasMaxLength(255)
                    .HasColumnName("LOCATOR");

                entity.Property(e => e.Locatorextension)
                    .HasMaxLength(10)
                    .HasColumnName("LOCATOREXTENSION");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(8)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Partition).HasColumnName("PARTITION");

                entity.Property(e => e.Privateforparty).HasColumnName("PRIVATEFORPARTY");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Recversion).HasColumnName("RECVERSION");

                entity.Property(e => e.Type).HasColumnName("TYPE");
            });

            modelBuilder.Entity<LpdpCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("LPDP_CLIENTE");

                entity.HasIndex(e => e.Codigo, "LPDP_CLIENTE_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.IdCliente)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(4)
                    .HasColumnName("EMPRESA");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(128)
                    .HasColumnName("RAZON_SOCIAL");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(20)
                    .HasColumnName("RUC");

                entity.Property(e => e.TipoPnj)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PNJ")
                    .IsFixedLength();
            });

            modelBuilder.Entity<LpdpProveedor>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("LPDP_PROVEEDOR");

                entity.HasIndex(e => e.Codigo, "LPDP_PROVEEDOR_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.IdCliente)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CLIENTE");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(4)
                    .HasColumnName("EMPRESA");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(128)
                    .HasColumnName("RAZON_SOCIAL");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(20)
                    .HasColumnName("RUC");

                entity.Property(e => e.TipoPnj)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("TIPO_PNJ")
                    .IsFixedLength();
            });

            modelBuilder.Entity<MensajesError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MensajesError", "PagoProvLeche");

                entity.Property(e => e.Empresa).HasMaxLength(10);

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mensaje).HasMaxLength(4000);

                entity.Property(e => e.OrdenCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Procedimiento).HasMaxLength(128);

                entity.Property(e => e.RecIdLineaOc).HasColumnName("RecIdLineaOC");
            });

            modelBuilder.Entity<MntProperty>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mnt_property", "Ax2012");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("CITY");

                entity.Property(e => e.County)
                    .HasMaxLength(30)
                    .HasColumnName("COUNTY");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(8)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATETIME");

                entity.Property(e => e.Dataareaid)
                    .HasMaxLength(4)
                    .HasColumnName("DATAAREAID");

                entity.Property(e => e.Group)
                    .HasMaxLength(100)
                    .HasColumnName("GROUP_");

                entity.Property(e => e.Invoiceaccount)
                    .HasMaxLength(20)
                    .HasColumnName("INVOICEACCOUNT");

                entity.Property(e => e.Partition).HasColumnName("PARTITION");

                entity.Property(e => e.Precioruta)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PRECIORUTA");

                entity.Property(e => e.Propertyid).HasColumnName("PROPERTYID");

                entity.Property(e => e.Propertyname)
                    .HasMaxLength(100)
                    .HasColumnName("PROPERTYNAME");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Recversion).HasColumnName("RECVERSION");

                entity.Property(e => e.Shortname)
                    .HasMaxLength(100)
                    .HasColumnName("SHORTNAME");

                entity.Property(e => e.State)
                    .HasMaxLength(30)
                    .HasColumnName("STATE");

                entity.Property(e => e.Tipocentroacopio).HasColumnName("TIPOCENTROACOPIO");
            });

            modelBuilder.Entity<Parametro>(entity =>
            {
                entity.HasKey(e => e.CodRegistro)
                    .HasName("PK_Parametros");

                entity.ToTable("Parametro", "labCal");

                entity.Property(e => e.CodEmpresa).HasMaxLength(10);

                entity.Property(e => e.CodParametro).HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Texto).HasMaxLength(100);
            });

            modelBuilder.Entity<ParametrosPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ParametrosPago", "PagoProvLeche");

                entity.Property(e => e.Empresa).HasMaxLength(4);

                entity.Property(e => e.GrasaMaxima).HasColumnType("numeric(32, 16)");

                entity.Property(e => e.GrasaMinima).HasColumnType("numeric(32, 16)");

                entity.Property(e => e.PrecioMinimoCalidad).HasColumnType("numeric(32, 16)");

                entity.Property(e => e.ProteinaMaxima).HasColumnType("numeric(32, 16)");

                entity.Property(e => e.ProteinaMinima).HasColumnType("numeric(32, 16)");
            });

            modelBuilder.Entity<PmsCostosReales01>(entity =>
            {
                entity.HasKey(e => new { e.Empresa, e.Anio, e.Mes, e.Sitio, e.CodTipoCosto });

                entity.ToTable("PMS_CostosReales01");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sitio).HasMaxLength(16);

                entity.Property(e => e.CodTipoCosto).HasMaxLength(64);

                entity.Property(e => e.Valor).HasColumnType("numeric(16, 2)");
            });

            modelBuilder.Entity<PmsListaprecio>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("PMS_LISTAPRECIOS");

                entity.HasIndex(e => e.Codigo, "PMS_LISTAPRECIOS_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(32)
                    .HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(128)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");
            });

            modelBuilder.Entity<PmsParametro>(entity =>
            {
                entity.HasKey(e => e.IdParam);

                entity.ToTable("PMS_PARAMETROS");

                entity.Property(e => e.IdParam).HasColumnName("ID_PARAM");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.FchfinalPlan)
                    .HasColumnType("datetime")
                    .HasColumnName("FCHFINAL_PLAN");

                entity.Property(e => e.FchinicialLc)
                    .HasColumnType("datetime")
                    .HasColumnName("FCHINICIAL_LC");

                entity.Property(e => e.FchinicialPrecios)
                    .HasColumnType("datetime")
                    .HasColumnName("FCHINICIAL_PRECIOS");
            });

            modelBuilder.Entity<PmsPrecioUnitario>(entity =>
            {
                entity.HasKey(e => new { e.Anio, e.Mes, e.Itemid });

                entity.ToTable("PMS_PRECIO_UNITARIO");

                entity.HasIndex(e => new { e.Anio, e.Mes, e.Itemid }, "PMS_PRECIO_UNITARIO_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.Mes).HasColumnName("MES");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Fchreferencia)
                    .HasColumnType("datetime")
                    .HasColumnName("FCHREFERENCIA");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("PRECIO");
            });

            modelBuilder.Entity<PmsServiciosBasico>(entity =>
            {
                entity.HasKey(e => new { e.Empresa, e.Anio, e.Mes, e.Sitio, e.CodTipoServicio });

                entity.ToTable("PMS_ServiciosBasicos");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Sitio).HasMaxLength(16);

                entity.Property(e => e.CodTipoServicio).HasMaxLength(16);

                entity.Property(e => e.Consumo).HasColumnType("numeric(16, 2)");

                entity.Property(e => e.ValorUnitario).HasColumnType("numeric(16, 2)");
            });

            modelBuilder.Entity<Precios2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRECIOS2022$");

                entity.Property(e => e.F1).HasMaxLength(255);

                entity.Property(e => e.F2).HasMaxLength(255);
            });

            modelBuilder.Entity<Presupuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Presupuestos");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.ItemDesc)
                    .HasMaxLength(100)
                    .HasColumnName("ITEM DESC");

                entity.Property(e => e.Itemcod)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMCOD");

                entity.Property(e => e.Linea)
                    .HasMaxLength(131)
                    .HasColumnName("LINEA");

                entity.Property(e => e.Litros)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("LITROS");

                entity.Property(e => e.Sublinea)
                    .HasMaxLength(131)
                    .HasColumnName("SUBLINEA");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("SUBTOTAL");

                entity.Property(e => e.SubundNegocio)
                    .HasMaxLength(130)
                    .HasColumnName("SUBUND. NEGOCIO");

                entity.Property(e => e.Txt)
                    .HasMaxLength(128)
                    .HasColumnName("TXT");

                entity.Property(e => e.UndNegocio)
                    .HasMaxLength(131)
                    .HasColumnName("UND. NEGOCIO");

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<PresupuestoVistum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Presupuesto_Vista");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.ItemDesc)
                    .HasMaxLength(100)
                    .HasColumnName("ITEM DESC");

                entity.Property(e => e.Itemcod)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMCOD");

                entity.Property(e => e.Linea)
                    .HasMaxLength(131)
                    .HasColumnName("LINEA");

                entity.Property(e => e.Litros)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("LITROS");

                entity.Property(e => e.Precioltprom)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("PRECIOLTPROM");

                entity.Property(e => e.Sublinea)
                    .HasMaxLength(131)
                    .HasColumnName("SUBLINEA");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("SUBTOTAL");

                entity.Property(e => e.SubundNegocio)
                    .HasMaxLength(131)
                    .HasColumnName("SUBUND. NEGOCIO");

                entity.Property(e => e.UndNegocio)
                    .HasMaxLength(131)
                    .HasColumnName("UND. NEGOCIO");

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("UNIDADES");
            });

            modelBuilder.Entity<PriceDiscTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PriceDiscTable", "Ax2012");

                entity.Property(e => e.Accountcode).HasColumnName("ACCOUNTCODE");

                entity.Property(e => e.Accountrelation)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTRELATION");

                entity.Property(e => e.Agreement)
                    .HasMaxLength(10)
                    .HasColumnName("AGREEMENT");

                entity.Property(e => e.AgreementheaderextRu).HasColumnName("AGREEMENTHEADEREXT_RU");

                entity.Property(e => e.Allocatemarkup).HasColumnName("ALLOCATEMARKUP");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Calendardays).HasColumnName("CALENDARDAYS");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(8)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATETIME");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.Dataareaid)
                    .HasMaxLength(4)
                    .HasColumnName("DATAAREAID");

                entity.Property(e => e.Deliverytime).HasColumnName("DELIVERYTIME");

                entity.Property(e => e.Disregardleadtime).HasColumnName("DISREGARDLEADTIME");

                entity.Property(e => e.Fromdate)
                    .HasColumnType("datetime")
                    .HasColumnName("FROMDATE");

                entity.Property(e => e.Genericcurrency).HasColumnName("GENERICCURRENCY");

                entity.Property(e => e.InventbaileefreedaysRu).HasColumnName("INVENTBAILEEFREEDAYS_RU");

                entity.Property(e => e.Inventdimid)
                    .HasMaxLength(20)
                    .HasColumnName("INVENTDIMID");

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemrelation)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMRELATION");

                entity.Property(e => e.Markup)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("MARKUP");

                entity.Property(e => e.MaximumretailpriceIn)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("MAXIMUMRETAILPRICE_IN");

                entity.Property(e => e.Mcrfixedamountcur)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("MCRFIXEDAMOUNTCUR");

                entity.Property(e => e.Mcrmerchandisingeventid)
                    .HasMaxLength(10)
                    .HasColumnName("MCRMERCHANDISINGEVENTID");

                entity.Property(e => e.Mcrpricediscgrouptype).HasColumnName("MCRPRICEDISCGROUPTYPE");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(8)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATETIME");

                entity.Property(e => e.Module).HasColumnName("MODULE");

                entity.Property(e => e.Originalpricediscadmtransrecid).HasColumnName("ORIGINALPRICEDISCADMTRANSRECID");

                entity.Property(e => e.Partition).HasColumnName("PARTITION");

                entity.Property(e => e.Pdscalculationid)
                    .HasMaxLength(10)
                    .HasColumnName("PDSCALCULATIONID");

                entity.Property(e => e.Percent1)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PERCENT1");

                entity.Property(e => e.Percent2)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PERCENT2");

                entity.Property(e => e.Priceunit)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PRICEUNIT");

                entity.Property(e => e.Quantityamountfrom)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("QUANTITYAMOUNTFROM");

                entity.Property(e => e.Quantityamountto)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("QUANTITYAMOUNTTO");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Recversion).HasColumnName("RECVERSION");

                entity.Property(e => e.Relation).HasColumnName("RELATION");

                entity.Property(e => e.Searchagain).HasColumnName("SEARCHAGAIN");

                entity.Property(e => e.Todate)
                    .HasColumnType("datetime")
                    .HasColumnName("TODATE");

                entity.Property(e => e.Unitid)
                    .HasMaxLength(10)
                    .HasColumnName("UNITID");
            });

            modelBuilder.Entity<PurchLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchLine", "Ax2012");

                entity.Property(e => e.Accountingdistributiontemplate).HasColumnName("ACCOUNTINGDISTRIBUTIONTEMPLATE");

                entity.Property(e => e.Activitynumber)
                    .HasMaxLength(50)
                    .HasColumnName("ACTIVITYNUMBER");

                entity.Property(e => e.Addressrefrecid).HasColumnName("ADDRESSREFRECID");

                entity.Property(e => e.Addressreftableid).HasColumnName("ADDRESSREFTABLEID");

                entity.Property(e => e.Agreementskipautolink).HasColumnName("AGREEMENTSKIPAUTOLINK");

                entity.Property(e => e.Assetbookid)
                    .HasMaxLength(10)
                    .HasColumnName("ASSETBOOKID");

                entity.Property(e => e.Assetgroup)
                    .HasMaxLength(30)
                    .HasColumnName("ASSETGROUP");

                entity.Property(e => e.Assetid)
                    .HasMaxLength(20)
                    .HasColumnName("ASSETID");

                entity.Property(e => e.Assettranstypepurch).HasColumnName("ASSETTRANSTYPEPURCH");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(80)
                    .HasColumnName("BARCODE");

                entity.Property(e => e.Barcodetype)
                    .HasMaxLength(30)
                    .HasColumnName("BARCODETYPE");

                entity.Property(e => e.Blocked).HasColumnName("BLOCKED");

                entity.Property(e => e.Casetagging).HasColumnName("CASETAGGING");

                entity.Property(e => e.CfoptableBr).HasColumnName("CFOPTABLE_BR");

                entity.Property(e => e.Complete).HasColumnName("COMPLETE");

                entity.Property(e => e.Confirmeddlv)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMEDDLV");

                entity.Property(e => e.Confirmedtaxamount)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("CONFIRMEDTAXAMOUNT");

                entity.Property(e => e.Confirmedtaxwritecode)
                    .HasMaxLength(30)
                    .HasColumnName("CONFIRMEDTAXWRITECODE");

                entity.Property(e => e.Countyorigdest)
                    .HasMaxLength(30)
                    .HasColumnName("COUNTYORIGDEST");

                entity.Property(e => e.Covref).HasColumnName("COVREF");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(8)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATETIME");

                entity.Property(e => e.Createfixedasset).HasColumnName("CREATEFIXEDASSET");

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYCODE");

                entity.Property(e => e.Customerref)
                    .HasMaxLength(100)
                    .HasColumnName("CUSTOMERREF");

                entity.Property(e => e.Custpurchaseorderformnum)
                    .HasMaxLength(20)
                    .HasColumnName("CUSTPURCHASEORDERFORMNUM");

                entity.Property(e => e.Dataareaid)
                    .HasMaxLength(4)
                    .HasColumnName("DATAAREAID");

                entity.Property(e => e.Defaultdimension).HasColumnName("DEFAULTDIMENSION");

                entity.Property(e => e.Deliverydate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELIVERYDATE");

                entity.Property(e => e.Deliveryname)
                    .HasMaxLength(100)
                    .HasColumnName("DELIVERYNAME");

                entity.Property(e => e.Deliverypostaladdress).HasColumnName("DELIVERYPOSTALADDRESS");

                entity.Property(e => e.Deliverytype).HasColumnName("DELIVERYTYPE");

                entity.Property(e => e.Depreciationstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("DEPRECIATIONSTARTDATE");

                entity.Property(e => e.Discamount)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("DISCAMOUNT");

                entity.Property(e => e.Discpercent)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("DISCPERCENT");

                entity.Property(e => e.Editableinworkflow).HasColumnName("EDITABLEINWORKFLOW");

                entity.Property(e => e.Externalitemid)
                    .HasMaxLength(20)
                    .HasColumnName("EXTERNALITEMID");

                entity.Property(e => e.GsthsttaxtypeCa).HasColumnName("GSTHSTTAXTYPE_CA");

                entity.Property(e => e.Intercompanyinventtransid)
                    .HasMaxLength(20)
                    .HasColumnName("INTERCOMPANYINVENTTRANSID");

                entity.Property(e => e.Intercompanyorigin).HasColumnName("INTERCOMPANYORIGIN");

                entity.Property(e => e.IntrastatfulfillmentdateHu)
                    .HasColumnType("datetime")
                    .HasColumnName("INTRASTATFULFILLMENTDATE_HU");

                entity.Property(e => e.Inventdimid)
                    .HasMaxLength(20)
                    .HasColumnName("INVENTDIMID");

                entity.Property(e => e.Inventinvoicenow)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("INVENTINVOICENOW");

                entity.Property(e => e.Inventreceivednow)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("INVENTRECEIVEDNOW");

                entity.Property(e => e.Inventrefid)
                    .HasMaxLength(20)
                    .HasColumnName("INVENTREFID");

                entity.Property(e => e.Inventreftransid)
                    .HasMaxLength(20)
                    .HasColumnName("INVENTREFTRANSID");

                entity.Property(e => e.Inventtransid)
                    .HasMaxLength(20)
                    .HasColumnName("INVENTTRANSID");

                entity.Property(e => e.Isdeleted).HasColumnName("ISDELETED");

                entity.Property(e => e.Isfinalized).HasColumnName("ISFINALIZED");

                entity.Property(e => e.Isinvoicematched).HasColumnName("ISINVOICEMATCHED");

                entity.Property(e => e.Ismodified).HasColumnName("ISMODIFIED");

                entity.Property(e => e.Ispwp).HasColumnName("ISPWP");

                entity.Property(e => e.Itembomid)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMBOMID");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Itempbaid)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMPBAID");

                entity.Property(e => e.Itemreftype).HasColumnName("ITEMREFTYPE");

                entity.Property(e => e.Itemrouteid)
                    .HasMaxLength(20)
                    .HasColumnName("ITEMROUTEID");

                entity.Property(e => e.Itemtagging).HasColumnName("ITEMTAGGING");

                entity.Property(e => e.Ledgerdimension).HasColumnName("LEDGERDIMENSION");

                entity.Property(e => e.Lineamount)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("LINEAMOUNT");

                entity.Property(e => e.Linedeliverytype).HasColumnName("LINEDELIVERYTYPE");

                entity.Property(e => e.Linedisc)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("LINEDISC");

                entity.Property(e => e.Lineheader)
                    .HasMaxLength(80)
                    .HasColumnName("LINEHEADER");

                entity.Property(e => e.Linenumber).HasColumnName("LINENUMBER");

                entity.Property(e => e.Linepercent)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("LINEPERCENT");

                entity.Property(e => e.Manualentrychangepolicy).HasColumnName("MANUALENTRYCHANGEPOLICY");

                entity.Property(e => e.Manualmodifiedfield).HasColumnName("MANUALMODIFIEDFIELD");

                entity.Property(e => e.Matchingagreementline).HasColumnName("MATCHINGAGREEMENTLINE");

                entity.Property(e => e.Matchingpolicy).HasColumnName("MATCHINGPOLICY");

                entity.Property(e => e.Mcrdropshipcomment)
                    .HasMaxLength(250)
                    .HasColumnName("MCRDROPSHIPCOMMENT");

                entity.Property(e => e.Mcrdropshipment).HasColumnName("MCRDROPSHIPMENT");

                entity.Property(e => e.Mcrdropshipstatus).HasColumnName("MCRDROPSHIPSTATUS");

                entity.Property(e => e.Mcrorderline2pricehistoryref).HasColumnName("MCRORDERLINE2PRICEHISTORYREF");

                entity.Property(e => e.MntAdiccertificate)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("MNT_ADICCERTIFICATE");

                entity.Property(e => e.MntCarriername)
                    .HasMaxLength(20)
                    .HasColumnName("MNT_CARRIERNAME");

                entity.Property(e => e.MntDeliverynumber).HasColumnName("MNT_DELIVERYNUMBER");

                entity.Property(e => e.MntDischargenumber).HasColumnName("MNT_DISCHARGENUMBER");

                entity.Property(e => e.MntPropertyid).HasColumnName("MNT_PROPERTYID");

                entity.Property(e => e.MntRouteid)
                    .HasMaxLength(15)
                    .HasColumnName("MNT_ROUTEID");

                entity.Property(e => e.MntTankerid)
                    .HasMaxLength(15)
                    .HasColumnName("MNT_TANKERID");

                entity.Property(e => e.MntValuegp)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("MNT_VALUEGP");

                entity.Property(e => e.MntValueufc)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("MNT_VALUEUFC");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(8)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATETIME");

                entity.Property(e => e.Multilndisc)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("MULTILNDISC");

                entity.Property(e => e.Multilnpercent)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("MULTILNPERCENT");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .HasColumnName("NAME");

                entity.Property(e => e.OperationtypeMx).HasColumnName("OPERATIONTYPE_MX");

                entity.Property(e => e.Overdeliverypct)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("OVERDELIVERYPCT");

                entity.Property(e => e.Pallettagging).HasColumnName("PALLETTAGGING");

                entity.Property(e => e.Partition).HasColumnName("PARTITION");

                entity.Property(e => e.Pdscalculationid)
                    .HasMaxLength(10)
                    .HasColumnName("PDSCALCULATIONID");

                entity.Property(e => e.Pdscwinventreceivednow)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PDSCWINVENTRECEIVEDNOW");

                entity.Property(e => e.Pdscwqty)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PDSCWQTY");

                entity.Property(e => e.Pdscwremaininventfinancial)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PDSCWREMAININVENTFINANCIAL");

                entity.Property(e => e.Pdscwremaininventphysical)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PDSCWREMAININVENTPHYSICAL");

                entity.Property(e => e.Planreference).HasColumnName("PLANREFERENCE");

                entity.Property(e => e.Port)
                    .HasMaxLength(30)
                    .HasColumnName("PORT");

                entity.Property(e => e.Pqprecioacuerdocomercial)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PQPRECIOACUERDOCOMERCIAL");

                entity.Property(e => e.Pqpreciocbt)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PQPRECIOCBT");

                entity.Property(e => e.Pqpreciotransportelc)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PQPRECIOTRANSPORTELC");

                entity.Property(e => e.Pqrefrecidprecio).HasColumnName("PQREFRECIDPRECIO");

                entity.Property(e => e.Priceunit)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PRICEUNIT");

                entity.Property(e => e.Procurementcategory).HasColumnName("PROCUREMENTCATEGORY");

                entity.Property(e => e.Projcategoryid)
                    .HasMaxLength(30)
                    .HasColumnName("PROJCATEGORYID");

                entity.Property(e => e.Projid)
                    .HasMaxLength(20)
                    .HasColumnName("PROJID");

                entity.Property(e => e.Projlinepropertyid)
                    .HasMaxLength(10)
                    .HasColumnName("PROJLINEPROPERTYID");

                entity.Property(e => e.Projsalescurrencyid)
                    .HasMaxLength(3)
                    .HasColumnName("PROJSALESCURRENCYID");

                entity.Property(e => e.Projsalesprice)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PROJSALESPRICE");

                entity.Property(e => e.Projsalesunitid)
                    .HasMaxLength(10)
                    .HasColumnName("PROJSALESUNITID");

                entity.Property(e => e.Projtaxgroupid)
                    .HasMaxLength(30)
                    .HasColumnName("PROJTAXGROUPID");

                entity.Property(e => e.Projtaxitemgroupid)
                    .HasMaxLength(30)
                    .HasColumnName("PROJTAXITEMGROUPID");

                entity.Property(e => e.Projtransid)
                    .HasMaxLength(20)
                    .HasColumnName("PROJTRANSID");

                entity.Property(e => e.Projworker).HasColumnName("PROJWORKER");

                entity.Property(e => e.Psaretainscheduleid)
                    .HasMaxLength(20)
                    .HasColumnName("PSARETAINSCHEDULEID");

                entity.Property(e => e.Psatotalretainamount)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PSATOTALRETAINAMOUNT");

                entity.Property(e => e.Purchasetype).HasColumnName("PURCHASETYPE");

                entity.Property(e => e.PurchcommitmentlinePsn).HasColumnName("PURCHCOMMITMENTLINE_PSN");

                entity.Property(e => e.Purchid)
                    .HasMaxLength(20)
                    .HasColumnName("PURCHID");

                entity.Property(e => e.Purchmarkup)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PURCHMARKUP");

                entity.Property(e => e.Purchprice)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PURCHPRICE");

                entity.Property(e => e.Purchprice1)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PURCHPRICE1");

                entity.Property(e => e.Purchqty)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PURCHQTY");

                entity.Property(e => e.Purchreceivednow)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PURCHRECEIVEDNOW");

                entity.Property(e => e.Purchreqid)
                    .HasMaxLength(25)
                    .HasColumnName("PURCHREQID");

                entity.Property(e => e.Purchreqlinerefid).HasColumnName("PURCHREQLINEREFID");

                entity.Property(e => e.Purchstatus).HasColumnName("PURCHSTATUS");

                entity.Property(e => e.Purchunit)
                    .HasMaxLength(10)
                    .HasColumnName("PURCHUNIT");

                entity.Property(e => e.Qtyordered)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("QTYORDERED");

                entity.Property(e => e.Rbopackagelinenum)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("RBOPACKAGELINENUM");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Recversion).HasColumnName("RECVERSION");

                entity.Property(e => e.Remainder)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("REMAINDER");

                entity.Property(e => e.Remaininventfinancial)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("REMAININVENTFINANCIAL");

                entity.Property(e => e.Remaininventphysical)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("REMAININVENTPHYSICAL");

                entity.Property(e => e.Remainpurchfinancial)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("REMAINPURCHFINANCIAL");

                entity.Property(e => e.Remainpurchphysical)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("REMAINPURCHPHYSICAL");

                entity.Property(e => e.Reqattention)
                    .HasMaxLength(255)
                    .HasColumnName("REQATTENTION");

                entity.Property(e => e.Reqplanidsched)
                    .HasMaxLength(10)
                    .HasColumnName("REQPLANIDSCHED");

                entity.Property(e => e.Reqpoid)
                    .HasMaxLength(20)
                    .HasColumnName("REQPOID");

                entity.Property(e => e.Requester).HasColumnName("REQUESTER");

                entity.Property(e => e.Retaillinenumex1)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("RETAILLINENUMEX1");

                entity.Property(e => e.Retailpackageid)
                    .HasMaxLength(10)
                    .HasColumnName("RETAILPACKAGEID");

                entity.Property(e => e.Retailtempvalueex2)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("RETAILTEMPVALUEEX2");

                entity.Property(e => e.Returnactionid)
                    .HasMaxLength(30)
                    .HasColumnName("RETURNACTIONID");

                entity.Property(e => e.Returndispositioncodeid)
                    .HasMaxLength(10)
                    .HasColumnName("RETURNDISPOSITIONCODEID");

                entity.Property(e => e.Returnstatus).HasColumnName("RETURNSTATUS");

                entity.Property(e => e.Scrap).HasColumnName("SCRAP");

                entity.Property(e => e.Serviceaddress)
                    .HasMaxLength(250)
                    .HasColumnName("SERVICEADDRESS");

                entity.Property(e => e.Servicedate)
                    .HasColumnType("datetime")
                    .HasColumnName("SERVICEDATE");

                entity.Property(e => e.Shippingdateconfirmed)
                    .HasColumnType("datetime")
                    .HasColumnName("SHIPPINGDATECONFIRMED");

                entity.Property(e => e.Shippingdaterequested)
                    .HasColumnType("datetime")
                    .HasColumnName("SHIPPINGDATEREQUESTED");

                entity.Property(e => e.Skipdistributionupdate).HasColumnName("SKIPDISTRIBUTIONUPDATE");

                entity.Property(e => e.Sourcedocumentline).HasColumnName("SOURCEDOCUMENTLINE");

                entity.Property(e => e.StatisticvalueLt)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("STATISTICVALUE_LT");

                entity.Property(e => e.Statprocid)
                    .HasMaxLength(10)
                    .HasColumnName("STATPROCID");

                entity.Property(e => e.Stattriangulardeal).HasColumnName("STATTRIANGULARDEAL");

                entity.Property(e => e.Stockedproduct).HasColumnName("STOCKEDPRODUCT");

                entity.Property(e => e.Systementrychangepolicy).HasColumnName("SYSTEMENTRYCHANGEPOLICY");

                entity.Property(e => e.Systementrysource).HasColumnName("SYSTEMENTRYSOURCE");

                entity.Property(e => e.Tamitemvendrebategroupid)
                    .HasMaxLength(20)
                    .HasColumnName("TAMITEMVENDREBATEGROUPID");

                entity.Property(e => e.Tax1099amount)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("TAX1099AMOUNT");

                entity.Property(e => e.Tax1099fields).HasColumnName("TAX1099FIELDS");

                entity.Property(e => e.Tax1099recid).HasColumnName("TAX1099RECID");

                entity.Property(e => e.Tax1099state)
                    .HasMaxLength(30)
                    .HasColumnName("TAX1099STATE");

                entity.Property(e => e.Tax1099stateamount)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("TAX1099STATEAMOUNT");

                entity.Property(e => e.Taxautogenerated).HasColumnName("TAXAUTOGENERATED");

                entity.Property(e => e.Taxgroup)
                    .HasMaxLength(30)
                    .HasColumnName("TAXGROUP");

                entity.Property(e => e.Taxitemgroup)
                    .HasMaxLength(30)
                    .HasColumnName("TAXITEMGROUP");

                entity.Property(e => e.TaxservicecodeBr)
                    .HasMaxLength(10)
                    .HasColumnName("TAXSERVICECODE_BR");

                entity.Property(e => e.TaxwithholdbasecurTh)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("TAXWITHHOLDBASECUR_TH");

                entity.Property(e => e.TaxwithholdgroupTh)
                    .HasMaxLength(30)
                    .HasColumnName("TAXWITHHOLDGROUP_TH");

                entity.Property(e => e.TaxwithholditemgroupheadingTh).HasColumnName("TAXWITHHOLDITEMGROUPHEADING_TH");

                entity.Property(e => e.Transactioncode)
                    .HasMaxLength(30)
                    .HasColumnName("TRANSACTIONCODE");

                entity.Property(e => e.Transport)
                    .HasMaxLength(30)
                    .HasColumnName("TRANSPORT");

                entity.Property(e => e.Underdeliverypct)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("UNDERDELIVERYPCT");

                entity.Property(e => e.Variantid)
                    .HasMaxLength(10)
                    .HasColumnName("VARIANTID");

                entity.Property(e => e.Vendaccount)
                    .HasMaxLength(20)
                    .HasColumnName("VENDACCOUNT");

                entity.Property(e => e.Vendgroup)
                    .HasMaxLength(30)
                    .HasColumnName("VENDGROUP");

                entity.Property(e => e.Wfdeliveryduestate).HasColumnName("WFDELIVERYDUESTATE");

                entity.Property(e => e.Wfinvreceivedstate).HasColumnName("WFINVRECEIVEDSTATE");

                entity.Property(e => e.Workflowstate).HasColumnName("WORKFLOWSTATE");
            });

            modelBuilder.Entity<PurchTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PurchTable", "Ax2012");

                entity.Property(e => e.Accountingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ACCOUNTINGDATE");

                entity.Property(e => e.Accountingdistributiontemplate).HasColumnName("ACCOUNTINGDISTRIBUTIONTEMPLATE");

                entity.Property(e => e.Addressrefrecid).HasColumnName("ADDRESSREFRECID");

                entity.Property(e => e.Addressreftableid).HasColumnName("ADDRESSREFTABLEID");

                entity.Property(e => e.Autosummarymoduletype).HasColumnName("AUTOSUMMARYMODULETYPE");

                entity.Property(e => e.Availsalesdate)
                    .HasColumnType("datetime")
                    .HasColumnName("AVAILSALESDATE");

                entity.Property(e => e.Bankcentralbankpurposecode)
                    .HasMaxLength(10)
                    .HasColumnName("BANKCENTRALBANKPURPOSECODE");

                entity.Property(e => e.Bankcentralbankpurposetext)
                    .HasMaxLength(140)
                    .HasColumnName("BANKCENTRALBANKPURPOSETEXT");

                entity.Property(e => e.Bankdocumenttype).HasColumnName("BANKDOCUMENTTYPE");

                entity.Property(e => e.Cashdisc)
                    .HasMaxLength(30)
                    .HasColumnName("CASHDISC");

                entity.Property(e => e.Cashdiscpercent)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("CASHDISCPERCENT");

                entity.Property(e => e.Changerequestrequired).HasColumnName("CHANGEREQUESTREQUIRED");

                entity.Property(e => e.CifPorc)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("CIF_PORC");

                entity.Property(e => e.Confirmeddlv)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMEDDLV");

                entity.Property(e => e.Confirmeddlvearliest)
                    .HasColumnType("datetime")
                    .HasColumnName("CONFIRMEDDLVEARLIEST");

                entity.Property(e => e.Confirmingpo).HasColumnName("CONFIRMINGPO");

                entity.Property(e => e.ConstargetJp).HasColumnName("CONSTARGET_JP");

                entity.Property(e => e.Contactpersonid)
                    .HasMaxLength(20)
                    .HasColumnName("CONTACTPERSONID");

                entity.Property(e => e.ContractnumSa)
                    .HasMaxLength(60)
                    .HasColumnName("CONTRACTNUM_SA");

                entity.Property(e => e.Countyorigdest)
                    .HasMaxLength(30)
                    .HasColumnName("COUNTYORIGDEST");

                entity.Property(e => e.Covstatus).HasColumnName("COVSTATUS");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(8)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATETIME");

                entity.Property(e => e.Crossdockingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CROSSDOCKINGDATE");

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCYCODE");

                entity.Property(e => e.Dataareaid)
                    .HasMaxLength(4)
                    .HasColumnName("DATAAREAID");

                entity.Property(e => e.Defaultdimension).HasColumnName("DEFAULTDIMENSION");

                entity.Property(e => e.DelPresencetypeBr).HasColumnName("DEL_PRESENCETYPE_BR");

                entity.Property(e => e.Deliverydate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELIVERYDATE");

                entity.Property(e => e.Deliveryname)
                    .HasMaxLength(100)
                    .HasColumnName("DELIVERYNAME");

                entity.Property(e => e.Deliverypostaladdress).HasColumnName("DELIVERYPOSTALADDRESS");

                entity.Property(e => e.Deliverytype).HasColumnName("DELIVERYTYPE");

                entity.Property(e => e.Discpercent)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("DISCPERCENT");

                entity.Property(e => e.Dlvmode)
                    .HasMaxLength(30)
                    .HasColumnName("DLVMODE");

                entity.Property(e => e.Dlvterm)
                    .HasMaxLength(30)
                    .HasColumnName("DLVTERM");

                entity.Property(e => e.Documentstate).HasColumnName("DOCUMENTSTATE");

                entity.Property(e => e.Documentstatus).HasColumnName("DOCUMENTSTATUS");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Embarquedate)
                    .HasColumnType("datetime")
                    .HasColumnName("EMBARQUEDATE");

                entity.Property(e => e.Enddisc)
                    .HasMaxLength(30)
                    .HasColumnName("ENDDISC");

                entity.Property(e => e.Enterprisenumber)
                    .HasMaxLength(50)
                    .HasColumnName("ENTERPRISENUMBER");

                entity.Property(e => e.Exchangeratedate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXCHANGERATEDATE");

                entity.Property(e => e.Finalizeclosingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("FINALIZECLOSINGDATE");

                entity.Property(e => e.Fixedduedate)
                    .HasColumnType("datetime")
                    .HasColumnName("FIXEDDUEDATE");

                entity.Property(e => e.Fixedexchrate)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("FIXEDEXCHRATE");

                entity.Property(e => e.Freightsliptype).HasColumnName("FREIGHTSLIPTYPE");

                entity.Property(e => e.Freightzone)
                    .HasMaxLength(30)
                    .HasColumnName("FREIGHTZONE");

                entity.Property(e => e.Fshautocreated).HasColumnName("FSHAUTOCREATED");

                entity.Property(e => e.Incltax).HasColumnName("INCLTAX");

                entity.Property(e => e.Intercompanyallowindirectcreation).HasColumnName("INTERCOMPANYALLOWINDIRECTCREATION");

                entity.Property(e => e.Intercompanycompanyid)
                    .HasMaxLength(4)
                    .HasColumnName("INTERCOMPANYCOMPANYID");

                entity.Property(e => e.Intercompanycustpurchorderformnum)
                    .HasMaxLength(20)
                    .HasColumnName("INTERCOMPANYCUSTPURCHORDERFORMNUM");

                entity.Property(e => e.Intercompanydirectdelivery).HasColumnName("INTERCOMPANYDIRECTDELIVERY");

                entity.Property(e => e.Intercompanyorder).HasColumnName("INTERCOMPANYORDER");

                entity.Property(e => e.Intercompanyorigin).HasColumnName("INTERCOMPANYORIGIN");

                entity.Property(e => e.Intercompanyoriginalcustaccount)
                    .HasMaxLength(20)
                    .HasColumnName("INTERCOMPANYORIGINALCUSTACCOUNT");

                entity.Property(e => e.Intercompanyoriginalsalesid)
                    .HasMaxLength(20)
                    .HasColumnName("INTERCOMPANYORIGINALSALESID");

                entity.Property(e => e.Intercompanysalesid)
                    .HasMaxLength(20)
                    .HasColumnName("INTERCOMPANYSALESID");

                entity.Property(e => e.IntrastataddvalueLv)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("INTRASTATADDVALUE_LV");

                entity.Property(e => e.IntrastatfulfillmentdateHu)
                    .HasColumnType("datetime")
                    .HasColumnName("INTRASTATFULFILLMENTDATE_HU");

                entity.Property(e => e.Inventlocationid)
                    .HasMaxLength(30)
                    .HasColumnName("INVENTLOCATIONID");

                entity.Property(e => e.Inventsiteid)
                    .HasMaxLength(10)
                    .HasColumnName("INVENTSITEID");

                entity.Property(e => e.Invoiceaccount)
                    .HasMaxLength(20)
                    .HasColumnName("INVOICEACCOUNT");

                entity.Property(e => e.InvoiceregisterLt).HasColumnName("INVOICEREGISTER_LT");

                entity.Property(e => e.Isencumbrancerequired).HasColumnName("ISENCUMBRANCEREQUIRED");

                entity.Property(e => e.Ismodified).HasColumnName("ISMODIFIED");

                entity.Property(e => e.Itembuyergroupid)
                    .HasMaxLength(30)
                    .HasColumnName("ITEMBUYERGROUPID");

                entity.Property(e => e.Languageid)
                    .HasMaxLength(7)
                    .HasColumnName("LANGUAGEID");

                entity.Property(e => e.Linedisc)
                    .HasMaxLength(30)
                    .HasColumnName("LINEDISC");

                entity.Property(e => e.Listcode).HasColumnName("LISTCODE");

                entity.Property(e => e.Localdeliverydate)
                    .HasColumnType("datetime")
                    .HasColumnName("LOCALDELIVERYDATE");

                entity.Property(e => e.Manualentrychangepolicy).HasColumnName("MANUALENTRYCHANGEPOLICY");

                entity.Property(e => e.Markupgroup)
                    .HasMaxLength(30)
                    .HasColumnName("MARKUPGROUP");

                entity.Property(e => e.Matchingagreement).HasColumnName("MATCHINGAGREEMENT");

                entity.Property(e => e.Mcrdropshipment).HasColumnName("MCRDROPSHIPMENT");

                entity.Property(e => e.Mntgarantia)
                    .HasMaxLength(10)
                    .HasColumnName("MNTGARANTIA");

                entity.Property(e => e.Mntobservaciones).HasColumnName("MNTOBSERVACIONES");

                entity.Property(e => e.Mntorigenfondosbe).HasColumnName("MNTORIGENFONDOSBE");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(8)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATETIME");

                entity.Property(e => e.Multilinedisc)
                    .HasMaxLength(30)
                    .HasColumnName("MULTILINEDISC");

                entity.Property(e => e.Numbersequencegroup)
                    .HasMaxLength(30)
                    .HasColumnName("NUMBERSEQUENCEGROUP");

                entity.Property(e => e.Numpedimport)
                    .HasMaxLength(15)
                    .HasColumnName("NUMPEDIMPORT");

                entity.Property(e => e.Onetimesupplier).HasColumnName("ONETIMESUPPLIER");

                entity.Property(e => e.Onetimevendor).HasColumnName("ONETIMEVENDOR");

                entity.Property(e => e.Orderaccount)
                    .HasMaxLength(20)
                    .HasColumnName("ORDERACCOUNT");

                entity.Property(e => e.PackingslipregisterLt).HasColumnName("PACKINGSLIPREGISTER_LT");

                entity.Property(e => e.Partition).HasColumnName("PARTITION");

                entity.Property(e => e.Payment)
                    .HasMaxLength(30)
                    .HasColumnName("PAYMENT");

                entity.Property(e => e.Paymentsched)
                    .HasMaxLength(30)
                    .HasColumnName("PAYMENTSCHED");

                entity.Property(e => e.Paymmode)
                    .HasMaxLength(30)
                    .HasColumnName("PAYMMODE");

                entity.Property(e => e.Paymspec)
                    .HasMaxLength(30)
                    .HasColumnName("PAYMSPEC");

                entity.Property(e => e.Port)
                    .HasMaxLength(30)
                    .HasColumnName("PORT");

                entity.Property(e => e.Postingprofile)
                    .HasMaxLength(10)
                    .HasColumnName("POSTINGPROFILE");

                entity.Property(e => e.Pricegroupid)
                    .HasMaxLength(30)
                    .HasColumnName("PRICEGROUPID");

                entity.Property(e => e.Projid)
                    .HasMaxLength(20)
                    .HasColumnName("PROJID");

                entity.Property(e => e.Purchasetype).HasColumnName("PURCHASETYPE");

                entity.Property(e => e.Purchid)
                    .HasMaxLength(20)
                    .HasColumnName("PURCHID");

                entity.Property(e => e.Purchname)
                    .HasMaxLength(100)
                    .HasColumnName("PURCHNAME");

                entity.Property(e => e.Purchpoolid)
                    .HasMaxLength(30)
                    .HasColumnName("PURCHPOOLID");

                entity.Property(e => e.Purchstatus).HasColumnName("PURCHSTATUS");

                entity.Property(e => e.Reasontableref).HasColumnName("REASONTABLEREF");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Recversion).HasColumnName("RECVERSION");

                entity.Property(e => e.Replenishmentlocation)
                    .HasMaxLength(30)
                    .HasColumnName("REPLENISHMENTLOCATION");

                entity.Property(e => e.Reqattention)
                    .HasMaxLength(255)
                    .HasColumnName("REQATTENTION");

                entity.Property(e => e.Requester).HasColumnName("REQUESTER");

                entity.Property(e => e.Retailconcessionpurch).HasColumnName("RETAILCONCESSIONPURCH");

                entity.Property(e => e.Retaildriverdetails)
                    .HasMaxLength(100)
                    .HasColumnName("RETAILDRIVERDETAILS");

                entity.Property(e => e.Retailretailstatustype).HasColumnName("RETAILRETAILSTATUSTYPE");

                entity.Property(e => e.Returnitemnum)
                    .HasMaxLength(10)
                    .HasColumnName("RETURNITEMNUM");

                entity.Property(e => e.Returnreasoncodeid)
                    .HasMaxLength(10)
                    .HasColumnName("RETURNREASONCODEID");

                entity.Property(e => e.Returnreplacementcreated).HasColumnName("RETURNREPLACEMENTCREATED");

                entity.Property(e => e.Serviceaddress)
                    .HasMaxLength(250)
                    .HasColumnName("SERVICEADDRESS");

                entity.Property(e => e.Servicecategory)
                    .HasMaxLength(10)
                    .HasColumnName("SERVICECATEGORY");

                entity.Property(e => e.Servicedate)
                    .HasColumnType("datetime")
                    .HasColumnName("SERVICEDATE");

                entity.Property(e => e.Servicename)
                    .HasMaxLength(20)
                    .HasColumnName("SERVICENAME");

                entity.Property(e => e.Settlevoucher).HasColumnName("SETTLEVOUCHER");

                entity.Property(e => e.Sourcedocumentheader).HasColumnName("SOURCEDOCUMENTHEADER");

                entity.Property(e => e.Sourcedocumentline).HasColumnName("SOURCEDOCUMENTLINE");

                entity.Property(e => e.Statprocid)
                    .HasMaxLength(10)
                    .HasColumnName("STATPROCID");

                entity.Property(e => e.Systementrychangepolicy).HasColumnName("SYSTEMENTRYCHANGEPOLICY");

                entity.Property(e => e.Systementrysource).HasColumnName("SYSTEMENTRYSOURCE");

                entity.Property(e => e.Tamvendrebategroupid)
                    .HasMaxLength(20)
                    .HasColumnName("TAMVENDREBATEGROUPID");

                entity.Property(e => e.Taxgroup)
                    .HasMaxLength(30)
                    .HasColumnName("TAXGROUP");

                entity.Property(e => e.TaxperiodpaymentcodePl)
                    .HasMaxLength(10)
                    .HasColumnName("TAXPERIODPAYMENTCODE_PL");

                entity.Property(e => e.Transactioncode)
                    .HasMaxLength(30)
                    .HasColumnName("TRANSACTIONCODE");

                entity.Property(e => e.Transport)
                    .HasMaxLength(30)
                    .HasColumnName("TRANSPORT");

                entity.Property(e => e.Transportationdocument).HasColumnName("TRANSPORTATIONDOCUMENT");

                entity.Property(e => e.UnitedvatinvoiceLt).HasColumnName("UNITEDVATINVOICE_LT");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.Vatnum)
                    .HasMaxLength(20)
                    .HasColumnName("VATNUM");

                entity.Property(e => e.Vendgroup)
                    .HasMaxLength(30)
                    .HasColumnName("VENDGROUP");

                entity.Property(e => e.VendinvoicedeclarationIs).HasColumnName("VENDINVOICEDECLARATION_IS");

                entity.Property(e => e.Vendorref)
                    .HasMaxLength(100)
                    .HasColumnName("VENDORREF");

                entity.Property(e => e.Workerpurchplacer).HasColumnName("WORKERPURCHPLACER");
            });

            modelBuilder.Entity<Pvitem>(entity =>
            {
                entity.HasKey(e => new { e.Lineacod, e.Sublineacod, e.Itemcod });

                entity.ToTable("PVITEM");

                entity.HasIndex(e => new { e.Lineacod, e.Sublineacod, e.Itemcod }, "PVITEM_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Lineacod).HasColumnName("LINEACOD");

                entity.Property(e => e.Sublineacod).HasColumnName("SUBLINEACOD");

                entity.Property(e => e.Itemcod)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMCOD");

                entity.Property(e => e.Factorlt)
                    .HasColumnType("numeric(8, 4)")
                    .HasColumnName("FACTORLT");

                entity.HasOne(d => d.Pvsublinea)
                    .WithMany(p => p.Pvitems)
                    .HasForeignKey(d => new { d.Lineacod, d.Sublineacod })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVITEM_PVITEM_SU_PVSUBLIN");
            });

            modelBuilder.Entity<PvitemLineaSublinea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PVItemLineaSublinea");

                entity.Property(e => e.ItemDesc).HasMaxLength(100);

                entity.Property(e => e.Itemcod)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMCOD");

                entity.Property(e => e.Lineacod).HasColumnName("LINEACOD");

                entity.Property(e => e.Lineadesc)
                    .HasMaxLength(128)
                    .HasColumnName("LINEADESC");

                entity.Property(e => e.Sublineacod).HasColumnName("SUBLINEACOD");

                entity.Property(e => e.Sublineadesc)
                    .HasMaxLength(128)
                    .HasColumnName("SUBLINEADESC");
            });

            modelBuilder.Entity<Pvlinea>(entity =>
            {
                entity.HasKey(e => e.Lineacod);

                entity.ToTable("PVLINEA");

                entity.HasIndex(e => e.Lineacod, "PVLINEA_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Lineacod).HasColumnName("LINEACOD");

                entity.Property(e => e.Lineadesc)
                    .HasMaxLength(128)
                    .HasColumnName("LINEADESC");

                entity.Property(e => e.Lineaord).HasColumnName("LINEAORD");
            });

            modelBuilder.Entity<Pvprecio>(entity =>
            {
                entity.HasKey(e => new { e.Lineacod, e.Sublineacod, e.Undnegociocod, e.Subundnegociocod, e.Itemcod, e.Anio });

                entity.ToTable("PVPRECIO");

                entity.HasIndex(e => new { e.Lineacod, e.Sublineacod, e.Undnegociocod, e.Subundnegociocod, e.Itemcod, e.Anio }, "PVPRECIO_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Lineacod).HasColumnName("LINEACOD");

                entity.Property(e => e.Sublineacod).HasColumnName("SUBLINEACOD");

                entity.Property(e => e.Undnegociocod).HasColumnName("UNDNEGOCIOCOD");

                entity.Property(e => e.Subundnegociocod).HasColumnName("SUBUNDNEGOCIOCOD");

                entity.Property(e => e.Itemcod)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMCOD");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Valor)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("VALOR");

                entity.HasOne(d => d.Pvsubundnegocio)
                    .WithMany(p => p.Pvprecios)
                    .HasForeignKey(d => new { d.Undnegociocod, d.Subundnegociocod })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVPRECIO_REFERENCE_PVSUBUND");

                entity.HasOne(d => d.Pvitem)
                    .WithMany(p => p.Pvprecios)
                    .HasForeignKey(d => new { d.Lineacod, d.Sublineacod, d.Itemcod })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVPRECIO_REFERENCE_PVITEM");
            });

            modelBuilder.Entity<Pvpresupuesto>(entity =>
            {
                entity.HasKey(e => new { e.Lineacod, e.Sublineacod, e.Undnegociocod, e.Subundnegociocod, e.Itemcod, e.Anio });

                entity.ToTable("PVPRESUPUESTO");

                entity.HasIndex(e => new { e.Lineacod, e.Sublineacod, e.Undnegociocod, e.Subundnegociocod, e.Itemcod, e.Anio }, "PVPRESUPUESTO_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Lineacod).HasColumnName("LINEACOD");

                entity.Property(e => e.Sublineacod).HasColumnName("SUBLINEACOD");

                entity.Property(e => e.Undnegociocod).HasColumnName("UNDNEGOCIOCOD");

                entity.Property(e => e.Subundnegociocod).HasColumnName("SUBUNDNEGOCIOCOD");

                entity.Property(e => e.Itemcod)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMCOD");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.Costoprdtlc)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("COSTOPRDTLC");

                entity.Property(e => e.Costoprduio)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("COSTOPRDUIO");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Litros)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("LITROS");

                entity.Property(e => e.Porcpart)
                    .HasColumnType("numeric(16, 8)")
                    .HasColumnName("PORCPART");

                entity.Property(e => e.Precioltprom)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("PRECIOLTPROM");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("SUBTOTAL");

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("UNIDADES");

                entity.HasOne(d => d.Pvsubundnegocio)
                    .WithMany(p => p.Pvpresupuestos)
                    .HasForeignKey(d => new { d.Undnegociocod, d.Subundnegociocod })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVPRESUP_PVSUBUN2");

                entity.HasOne(d => d.Pvitem)
                    .WithMany(p => p.Pvpresupuestos)
                    .HasForeignKey(d => new { d.Lineacod, d.Sublineacod, d.Itemcod })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVPRESUP_PVITE1");
            });

            modelBuilder.Entity<Pvpresupuestover>(entity =>
            {
                entity.HasKey(e => new { e.Anio, e.Numver });

                entity.ToTable("PVPRESUPUESTOVER");

                entity.HasIndex(e => new { e.Anio, e.Numver }, "PVPRESUPUESTOVER_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.Numver)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NUMVER");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Txt)
                    .HasMaxLength(128)
                    .HasColumnName("TXT");
            });

            modelBuilder.Entity<Pvpresupuestoverline>(entity =>
            {
                entity.HasKey(e => new { e.Anio, e.Numver, e.Lineacod, e.Sublineacod, e.Undnegociocod, e.Subundnegociocod, e.Itemcod });

                entity.ToTable("PVPRESUPUESTOVERLINE");

                entity.HasIndex(e => new { e.Anio, e.Numver, e.Lineacod, e.Sublineacod, e.Undnegociocod, e.Subundnegociocod, e.Itemcod }, "PVPRESUPUESTOVERLINE_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.Numver).HasColumnName("NUMVER");

                entity.Property(e => e.Lineacod).HasColumnName("LINEACOD");

                entity.Property(e => e.Sublineacod).HasColumnName("SUBLINEACOD");

                entity.Property(e => e.Undnegociocod).HasColumnName("UNDNEGOCIOCOD");

                entity.Property(e => e.Subundnegociocod).HasColumnName("SUBUNDNEGOCIOCOD");

                entity.Property(e => e.Itemcod)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMCOD");

                entity.Property(e => e.Costoprdtlc)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("COSTOPRDTLC");

                entity.Property(e => e.Costoprduio)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("COSTOPRDUIO");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Litros)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("LITROS");

                entity.Property(e => e.Precioltprom)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("PRECIOLTPROM");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("SUBTOTAL");

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(16, 4)")
                    .HasColumnName("UNIDADES");

                entity.HasOne(d => d.Pvpresupuestover)
                    .WithMany(p => p.Pvpresupuestoverlines)
                    .HasForeignKey(d => new { d.Anio, d.Numver })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVPRESUP_PVPRESVL__PVPRESUP");

                entity.HasOne(d => d.Pvsubundnegocio)
                    .WithMany(p => p.Pvpresupuestoverlines)
                    .HasForeignKey(d => new { d.Undnegociocod, d.Subundnegociocod })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVPRESUP_PVSUBUN3");

                entity.HasOne(d => d.Pvitem)
                    .WithMany(p => p.Pvpresupuestoverlines)
                    .HasForeignKey(d => new { d.Lineacod, d.Sublineacod, d.Itemcod })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVPRESUP_PRESUP_IT_PVITE1");
            });

            modelBuilder.Entity<Pvsublinea>(entity =>
            {
                entity.HasKey(e => new { e.Lineacod, e.Sublineacod });

                entity.ToTable("PVSUBLINEA");

                entity.HasIndex(e => new { e.Lineacod, e.Sublineacod }, "PVSUBLINEA_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Lineacod).HasColumnName("LINEACOD");

                entity.Property(e => e.Sublineacod)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SUBLINEACOD");

                entity.Property(e => e.Sublineadesc)
                    .HasMaxLength(128)
                    .HasColumnName("SUBLINEADESC");

                entity.Property(e => e.Sublineaord).HasColumnName("SUBLINEAORD");

                entity.HasOne(d => d.LineacodNavigation)
                    .WithMany(p => p.Pvsublineas)
                    .HasForeignKey(d => d.Lineacod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVSUBLIN_PV_SUBL_L_PVLINEA");
            });

            modelBuilder.Entity<Pvsubundnegocio>(entity =>
            {
                entity.HasKey(e => new { e.Undnegociocod, e.Subundnegociocod });

                entity.ToTable("PVSUBUNDNEGOCIO");

                entity.HasIndex(e => new { e.Undnegociocod, e.Subundnegociocod }, "PVSUBUNDNEGOCIO_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Undnegociocod).HasColumnName("UNDNEGOCIOCOD");

                entity.Property(e => e.Subundnegociocod)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SUBUNDNEGOCIOCOD");

                entity.Property(e => e.Clientecod)
                    .HasMaxLength(8)
                    .HasColumnName("CLIENTECOD");

                entity.Property(e => e.Subundnegociodesc)
                    .HasMaxLength(128)
                    .HasColumnName("SUBUNDNEGOCIODESC");

                entity.Property(e => e.Subundnegocioord).HasColumnName("SUBUNDNEGOCIOORD");

                entity.HasOne(d => d.UndnegociocodNavigation)
                    .WithMany(p => p.Pvsubundnegocios)
                    .HasForeignKey(d => d.Undnegociocod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVSUBUND_PVSUBU_UN_PVUNDNEG");
            });

            modelBuilder.Entity<Pvundnegocio>(entity =>
            {
                entity.HasKey(e => e.Undnegociocod);

                entity.ToTable("PVUNDNEGOCIO");

                entity.HasIndex(e => e.Undnegociocod, "PVUNDNEGOCIO_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Undnegociocod).HasColumnName("UNDNEGOCIOCOD");

                entity.Property(e => e.Undnegociodesc)
                    .HasMaxLength(128)
                    .HasColumnName("UNDNEGOCIODESC");

                entity.Property(e => e.Undnegocioord).HasColumnName("UNDNEGOCIOORD");
            });

            modelBuilder.Entity<Pvundnegocioitem>(entity =>
            {
                entity.HasKey(e => new { e.Undnegociocod, e.Subundnegociocod, e.Itemcod });

                entity.ToTable("PVUNDNEGOCIOITEM");

                entity.HasIndex(e => new { e.Undnegociocod, e.Subundnegociocod, e.Itemcod }, "PVUNDNEGOCIOITEM_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Undnegociocod).HasColumnName("UNDNEGOCIOCOD");

                entity.Property(e => e.Subundnegociocod).HasColumnName("SUBUNDNEGOCIOCOD");

                entity.Property(e => e.Itemcod)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMCOD");

                entity.Property(e => e.Clientecod)
                    .HasMaxLength(8)
                    .HasColumnName("CLIENTECOD");

                entity.HasOne(d => d.Pvsubundnegocio)
                    .WithMany(p => p.Pvundnegocioitems)
                    .HasForeignKey(d => new { d.Undnegociocod, d.Subundnegociocod })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PVUNDNEG_REFERENCE_PVSUBUND");
            });

            modelBuilder.Entity<ResultadoAnalisi>(entity =>
            {
                entity.HasKey(e => e.CodRegistro);

                entity.ToTable("ResultadoAnalisis", "PagoProvLeche");

                entity.Property(e => e.Antibioticos).HasMaxLength(20);

                entity.Property(e => e.BonificacionSanidadAnimal).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Cbt)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CBT");

                entity.Property(e => e.Ccs)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CCS");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodTanquero)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.DescuentoLinea).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.DescuentoPct).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.DireccionCorreo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(20);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaEnvioCorreo).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.Grasa).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InventTransId).HasMaxLength(40);

                entity.Property(e => e.LabResultadosCalificacion).HasColumnName("Lab_ResultadosCalificacion");

                entity.Property(e => e.Mensaje).HasMaxLength(500);

                entity.Property(e => e.NombrePredio)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumOrdenCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PctAgua).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PrecioAcuerdoComercial).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PrecioCbt)
                    .HasColumnType("numeric(6, 4)")
                    .HasColumnName("PrecioCBT");

                entity.Property(e => e.PrecioGrasaProteina).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PrecioUnitario).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.PrecioUnitarioPorCalidad).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.Proteina).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Sitio).HasMaxLength(20);

                entity.Property(e => e.TipoCalculoPrecio).HasMaxLength(20);

                entity.Property(e => e.Valor).HasColumnType("numeric(12, 4)");
            });

            modelBuilder.Entity<ResultadoAnalisisBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ResultadoAnalisisBak", "PagoProvLeche");

                entity.Property(e => e.Antibioticos).HasMaxLength(20);

                entity.Property(e => e.BonificacionSanidadAnimal)
                    .HasColumnType("numeric(6, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Cbt)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CBT");

                entity.Property(e => e.Ccs)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CCS");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodRegistro).ValueGeneratedOnAdd();

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.DescuentoLinea).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.DescuentoPct).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.DireccionCorreo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'ABIERTO')");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaEnvioCorreo).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.Grasa).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InventTransId).HasMaxLength(40);

                entity.Property(e => e.LabResultadosCalificacion).HasColumnName("Lab_ResultadosCalificacion");

                entity.Property(e => e.Mensaje).HasMaxLength(500);

                entity.Property(e => e.NombrePredio)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumOrdenCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PctAgua).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PrecioAcuerdoComercial)
                    .HasColumnType("numeric(6, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioCbt)
                    .HasColumnType("numeric(6, 4)")
                    .HasColumnName("PrecioCBT");

                entity.Property(e => e.PrecioGrasaProteina)
                    .HasColumnType("numeric(6, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioUnitario).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.PrecioUnitarioPorCalidad)
                    .HasColumnType("numeric(6, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Proteina).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Sitio).HasMaxLength(20);

                entity.Property(e => e.TipoCalculoPrecio).HasMaxLength(20);

                entity.Property(e => e.Valor).HasColumnType("numeric(12, 4)");
            });

            modelBuilder.Entity<Resultadoanalaismalo20230828>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("resultadoanalaismalo20230828", "PagoProvLeche");

                entity.Property(e => e.Antibioticos).HasMaxLength(20);

                entity.Property(e => e.BonificacionSanidadAnimal).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Cbt)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CBT");

                entity.Property(e => e.Ccs)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CCS");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodRegistro).ValueGeneratedOnAdd();

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.DescuentoLinea).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.DescuentoPct).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.DireccionCorreo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(20);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaEnvioCorreo).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.Grasa).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InventTransId).HasMaxLength(40);

                entity.Property(e => e.LabResultadosCalificacion).HasColumnName("Lab_ResultadosCalificacion");

                entity.Property(e => e.Mensaje).HasMaxLength(500);

                entity.Property(e => e.NombrePredio)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumOrdenCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PctAgua).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PrecioAcuerdoComercial).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PrecioCbt)
                    .HasColumnType("numeric(6, 4)")
                    .HasColumnName("PrecioCBT");

                entity.Property(e => e.PrecioGrasaProteina).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PrecioUnitario).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.PrecioUnitarioPorCalidad).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.Proteina).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Sitio).HasMaxLength(20);

                entity.Property(e => e.TipoCalculoPrecio).HasMaxLength(20);

                entity.Property(e => e.Valor).HasColumnType("numeric(12, 4)");
            });

            modelBuilder.Entity<Resultadoanalisisal31jul>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("resultadoanalisisal31jul", "PagoProvLeche");

                entity.Property(e => e.Antibioticos).HasMaxLength(20);

                entity.Property(e => e.BonificacionSanidadAnimal).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Cbt)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CBT");

                entity.Property(e => e.Ccs)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CCS");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.DescuentoLinea).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.DescuentoPct).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.DireccionCorreo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(20);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaEnvioCorreo).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.Grasa).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InventTransId).HasMaxLength(40);

                entity.Property(e => e.LabResultadosCalificacion).HasColumnName("Lab_ResultadosCalificacion");

                entity.Property(e => e.Mensaje).HasMaxLength(500);

                entity.Property(e => e.NombrePredio)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumOrdenCompra)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PctAgua).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PrecioAcuerdoComercial).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PrecioCbt)
                    .HasColumnType("numeric(6, 4)")
                    .HasColumnName("PrecioCBT");

                entity.Property(e => e.PrecioGrasaProteina).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PrecioUnitario).HasColumnType("numeric(12, 4)");

                entity.Property(e => e.PrecioUnitarioPorCalidad).HasColumnType("numeric(6, 4)");

                entity.Property(e => e.Proteina).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Sitio).HasMaxLength(20);

                entity.Property(e => e.TipoCalculoPrecio).HasMaxLength(20);

                entity.Property(e => e.Valor).HasColumnType("numeric(12, 4)");
            });

            modelBuilder.Entity<ResultadosEquipo>(entity =>
            {
                entity.HasKey(e => e.CodRegistro);

                entity.ToTable("ResultadosEquipos", "lab");

                entity.Property(e => e.ActualizadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AprobadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.BatchId)
                    .HasMaxLength(60)
                    .HasColumnName("BatchID");

                entity.Property(e => e.BatchType).HasMaxLength(60);

                entity.Property(e => e.Ccsmax)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CCSMax");

                entity.Property(e => e.Ccsmin)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("CCSMin");

                entity.Property(e => e.Cfu)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("CFU");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodTransporte).HasMaxLength(20);

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionCorreo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Equipo)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasMaxLength(20);

                entity.Property(e => e.Fat).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.FechaAnalisis).HasColumnType("date");

                entity.Property(e => e.FechaDescargaLc)
                    .HasColumnType("date")
                    .HasColumnName("FechaDescargaLC");

                entity.Property(e => e.FechaHoraAprobado).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraGeneracionPdf).HasColumnType("date");

                entity.Property(e => e.FechaHoraRevisado).HasColumnType("datetime");

                entity.Property(e => e.Fpd)
                    .HasColumnType("numeric(8, 3)")
                    .HasColumnName("FPD");

                entity.Property(e => e.GrasaMax).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrasaMin).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrasaP).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Grupo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraAnalisis)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ibc)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("IBC");

                entity.Property(e => e.Index)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Index_");

                entity.Property(e => e.Lactose).HasColumnType("numeric(5, 3)");

                entity.Property(e => e.NombrePredio)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProteinaP).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.ProteinaTotalMax).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ProteinaTotalMin).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RevisadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RutaArchivo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Scc)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("SCC");

                entity.Property(e => e.Snf)
                    .HasColumnType("numeric(5, 3)")
                    .HasColumnName("SNF");

                entity.Property(e => e.SolidosMax).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.SolidosMin).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Solids).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TotalP).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TrueP).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Urea).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.VersionInforme)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResultadosEquiposParametrosEnsayo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ResultadosEquiposParametrosEnsayo", "lab");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodEnsayo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Maximo).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Minimo).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ResultadosEquiposProvLeche>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ResultadosEquiposProvLeche", "lab");

                entity.Property(e => e.Cbt)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("CBT");

                entity.Property(e => e.Ccs)
                    .HasColumnType("numeric(11, 0)")
                    .HasColumnName("CCS");

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.Fpd)
                    .HasColumnType("numeric(8, 3)")
                    .HasColumnName("FPD");

                entity.Property(e => e.Grasa).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Lactosa).HasColumnType("numeric(5, 3)");

                entity.Property(e => e.Proteina).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ProteinaTotal).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ProteinaVerdadera).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Sng)
                    .HasColumnType("numeric(5, 3)")
                    .HasColumnName("SNG");

                entity.Property(e => e.Solidos).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.Ufc)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("UFC");

                entity.Property(e => e.Urea).HasColumnType("numeric(5, 2)");
            });

            modelBuilder.Entity<SysListaEmpresaSitio>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SysListaEmpresaSitio");

                entity.Property(e => e.EmpresaCod).HasMaxLength(4);

                entity.Property(e => e.Sitio).HasMaxLength(143);

                entity.Property(e => e.SitioCod).HasMaxLength(10);
            });

            modelBuilder.Entity<TablaPago>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TablaPago", "PagoProvLeche");

                entity.Property(e => e.ActualizadoPor).HasMaxLength(8);

                entity.Property(e => e.CreadoPor).HasMaxLength(8);

                entity.Property(e => e.Empresa).HasMaxLength(4);

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaInicial).HasColumnType("datetime");
            });

            modelBuilder.Entity<TablaPagoCbt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TablaPagoCbt", "PagoProvLeche");

                entity.Property(e => e.ActualizadoPor).HasMaxLength(8);

                entity.Property(e => e.CreadoPor).HasMaxLength(8);

                entity.Property(e => e.Empresa).HasMaxLength(4);

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.Valor).HasColumnType("numeric(32, 16)");
            });

            modelBuilder.Entity<TablaPagoGrasaProteina>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TablaPagoGrasaProteina", "PagoProvLeche");

                entity.Property(e => e.ActualizadoPor)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa).HasMaxLength(4);

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.Property(e => e.Grasa).HasColumnType("numeric(32, 16)");

                entity.Property(e => e.Proteina).HasColumnType("numeric(32, 16)");

                entity.Property(e => e.Valor).HasColumnType("numeric(32, 16)");
            });

            modelBuilder.Entity<TrnsRutadet>(entity =>
            {
                entity.HasKey(e => new { e.Transporteid, e.Numguiarem, e.Itemid });

                entity.ToTable("TRNS_RUTADET");

                entity.HasIndex(e => new { e.Transporteid, e.Numguiarem, e.Itemid }, "TRNS_RUTADET_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Transporteid).HasColumnName("TRANSPORTEID");

                entity.Property(e => e.Numguiarem)
                    .HasMaxLength(16)
                    .HasColumnName("NUMGUIAREM");

                entity.Property(e => e.Itemid)
                    .HasMaxLength(8)
                    .HasColumnName("ITEMID");

                entity.Property(e => e.Bodegadestino)
                    .HasMaxLength(16)
                    .HasColumnName("BODEGADESTINO");

                entity.Property(e => e.Bodegaorigen)
                    .HasMaxLength(16)
                    .HasColumnName("BODEGAORIGEN");

                entity.Property(e => e.Clienteid)
                    .HasMaxLength(8)
                    .HasColumnName("CLIENTEID");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Litros)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("LITROS");

                entity.Property(e => e.Unidades)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("UNIDADES");

                entity.Property(e => e.Valorusd)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("VALORUSD");

                entity.HasOne(d => d.TrnsRutaline)
                    .WithMany(p => p.TrnsRutadets)
                    .HasForeignKey(d => new { d.Transporteid, d.Numguiarem })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRNS_RUT_REFERENCE_TRNS_RUT");
            });

            modelBuilder.Entity<TrnsRutaline>(entity =>
            {
                entity.HasKey(e => new { e.Transporteid, e.Numguiarem });

                entity.ToTable("TRNS_RUTALINE");

                entity.HasIndex(e => new { e.Transporteid, e.Numguiarem }, "TRNS_RUTALINE_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Transporteid).HasColumnName("TRANSPORTEID");

                entity.Property(e => e.Numguiarem)
                    .HasMaxLength(16)
                    .HasColumnName("NUMGUIAREM");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Litrostotal)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("LITROSTOTAL");

                entity.Property(e => e.Numordventa)
                    .HasMaxLength(16)
                    .HasColumnName("NUMORDVENTA");

                entity.HasOne(d => d.Transporte)
                    .WithMany(p => p.TrnsRutalines)
                    .HasForeignKey(d => d.Transporteid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRNS_RUT_REFRLINE__TRNS_RUT");
            });

            modelBuilder.Entity<TrnsRutum>(entity =>
            {
                entity.HasKey(e => e.Transporteid);

                entity.ToTable("TRNS_RUTA");

                entity.HasIndex(e => e.Transporteid, "TRNS_RUTA_AK")
                    .HasFillFactor(80);

                entity.Property(e => e.Transporteid).HasColumnName("TRANSPORTEID");

                entity.Property(e => e.Areacomercial)
                    .HasMaxLength(8)
                    .HasColumnName("AREACOMERCIAL");

                entity.Property(e => e.Diarionum)
                    .HasMaxLength(16)
                    .HasColumnName("DIARIONUM");

                entity.Property(e => e.EtlFchcarga)
                    .HasColumnType("datetime")
                    .HasColumnName("ETL_FCHCARGA");

                entity.Property(e => e.Fchdiario)
                    .HasColumnType("datetime")
                    .HasColumnName("FCHDIARIO");

                entity.Property(e => e.Fchflete)
                    .HasColumnType("datetime")
                    .HasColumnName("FCHFLETE");

                entity.Property(e => e.Proveedor)
                    .HasMaxLength(16)
                    .HasColumnName("PROVEEDOR");

                entity.Property(e => e.Rutadesc)
                    .HasMaxLength(128)
                    .HasColumnName("RUTADESC");

                entity.Property(e => e.Rutaid)
                    .HasMaxLength(64)
                    .HasColumnName("RUTAID");

                entity.Property(e => e.Valoruta)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("VALORUTA");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.CodRegistro);

                entity.ToTable("Usuario", "Seg");

                entity.Property(e => e.CodUsuario).HasMaxLength(20);

                entity.Property(e => e.CreadoPor).HasMaxLength(20);

                entity.Property(e => e.EmpresaInicial).HasMaxLength(10);

                entity.Property(e => e.Estado).HasMaxLength(20);

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VdatosCalificacionParaPaginaWeb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VDatosCalificacionParaPaginaWeb", "PagoProvLeche");

                entity.Property(e => e.BonoSanidad).HasColumnType("numeric(32, 16)");

                entity.Property(e => e.Cbt)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CBT");

                entity.Property(e => e.Ccs)
                    .HasColumnType("numeric(12, 0)")
                    .HasColumnName("CCS");

                entity.Property(e => e.CodProveedor)
                    .HasMaxLength(20)
                    .HasColumnName("COD_PROVEEDOR");

                entity.Property(e => e.Empresa).HasMaxLength(4);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Grasa).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Linenumber).HasColumnName("LINENUMBER");

                entity.Property(e => e.Litros)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("LITROS");

                entity.Property(e => e.NombrePredio).HasMaxLength(100);

                entity.Property(e => e.NombreProveedor).HasMaxLength(100);

                entity.Property(e => e.PorcentajeAgua).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("PRECIO_UNITARIO");

                entity.Property(e => e.Proteina).HasColumnType("numeric(5, 1)");

                entity.Property(e => e.Purchid)
                    .HasMaxLength(20)
                    .HasColumnName("PURCHID");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Valor).HasColumnType("numeric(32, 16)");

                entity.Property(e => e.ValorGrasaProteina).HasColumnType("numeric(32, 16)");

                entity.Property(e => e.ValorPorCbt)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("ValorPorCBT");

                entity.Property(e => e.Vendgroup)
                    .HasMaxLength(30)
                    .HasColumnName("VENDGROUP");
            });

            modelBuilder.Entity<VendCertType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VendCertType", "Ax2012");

                entity.Property(e => e.Dataareaid)
                    .HasMaxLength(4)
                    .HasColumnName("DATAAREAID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.MntIncentivepay).HasColumnName("MNT_INCENTIVEPAY");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("NAME");

                entity.Property(e => e.Partition).HasColumnName("PARTITION");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Recversion).HasColumnName("RECVERSION");
            });

            modelBuilder.Entity<VendTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VendTable", "Ax2012");

                entity.Property(e => e.Accountnum)
                    .HasMaxLength(20)
                    .HasColumnName("ACCOUNTNUM");

                entity.Property(e => e.Bankaccount)
                    .HasMaxLength(10)
                    .HasColumnName("BANKACCOUNT");

                entity.Property(e => e.Bankcentralbankpurposecode)
                    .HasMaxLength(10)
                    .HasColumnName("BANKCENTRALBANKPURPOSECODE");

                entity.Property(e => e.Bankcentralbankpurposetext)
                    .HasMaxLength(140)
                    .HasColumnName("BANKCENTRALBANKPURPOSETEXT");

                entity.Property(e => e.BankcentralbanktranstypecurRu)
                    .HasMaxLength(30)
                    .HasColumnName("BANKCENTRALBANKTRANSTYPECUR_RU");

                entity.Property(e => e.BankorderofpaymentRu)
                    .HasMaxLength(2)
                    .HasColumnName("BANKORDEROFPAYMENT_RU");

                entity.Property(e => e.Bidonly).HasColumnName("BIDONLY");

                entity.Property(e => e.BirthcountycodeIt)
                    .HasMaxLength(2)
                    .HasColumnName("BIRTHCOUNTYCODE_IT");

                entity.Property(e => e.Birthdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BIRTHDATE");

                entity.Property(e => e.Birthplace)
                    .HasMaxLength(100)
                    .HasColumnName("BIRTHPLACE");

                entity.Property(e => e.Blocked).HasColumnName("BLOCKED");

                entity.Property(e => e.Blockedreleasedate)
                    .HasColumnType("datetime")
                    .HasColumnName("BLOCKEDRELEASEDATE");

                entity.Property(e => e.Blockedreleasedatetzid).HasColumnName("BLOCKEDRELEASEDATETZID");

                entity.Property(e => e.CashaccountingregimeEs).HasColumnName("CASHACCOUNTINGREGIME_ES");

                entity.Property(e => e.Cashdisc)
                    .HasMaxLength(30)
                    .HasColumnName("CASHDISC");

                entity.Property(e => e.CcmnumBr)
                    .HasMaxLength(20)
                    .HasColumnName("CCMNUM_BR");

                entity.Property(e => e.Changerequestallowoverride).HasColumnName("CHANGEREQUESTALLOWOVERRIDE");

                entity.Property(e => e.Changerequestenabled).HasColumnName("CHANGEREQUESTENABLED");

                entity.Property(e => e.Changerequestoverride).HasColumnName("CHANGEREQUESTOVERRIDE");

                entity.Property(e => e.Ciscompanyregnum)
                    .HasMaxLength(8)
                    .HasColumnName("CISCOMPANYREGNUM");

                entity.Property(e => e.Cisnationalinsurancenum)
                    .HasMaxLength(9)
                    .HasColumnName("CISNATIONALINSURANCENUM");

                entity.Property(e => e.Cisstatus).HasColumnName("CISSTATUS");

                entity.Property(e => e.Cisuniquetaxpayerref)
                    .HasMaxLength(10)
                    .HasColumnName("CISUNIQUETAXPAYERREF");

                entity.Property(e => e.Cisverificationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CISVERIFICATIONDATE");

                entity.Property(e => e.Cisverificationnum)
                    .HasMaxLength(13)
                    .HasColumnName("CISVERIFICATIONNUM");

                entity.Property(e => e.Clearingperiod)
                    .HasMaxLength(30)
                    .HasColumnName("CLEARINGPERIOD");

                entity.Property(e => e.CnaeBr)
                    .HasMaxLength(10)
                    .HasColumnName("CNAE_BR");

                entity.Property(e => e.CnpjcpfnumBr)
                    .HasMaxLength(20)
                    .HasColumnName("CNPJCPFNUM_BR");

                entity.Property(e => e.Commercialregister)
                    .HasMaxLength(40)
                    .HasColumnName("COMMERCIALREGISTER");

                entity.Property(e => e.Commercialregisterinsetnumber)
                    .HasMaxLength(10)
                    .HasColumnName("COMMERCIALREGISTERINSETNUMBER");

                entity.Property(e => e.Commercialregistersection)
                    .HasMaxLength(10)
                    .HasColumnName("COMMERCIALREGISTERSECTION");

                entity.Property(e => e.Companychainid)
                    .HasMaxLength(20)
                    .HasColumnName("COMPANYCHAINID");

                entity.Property(e => e.Companyidsiret)
                    .HasMaxLength(14)
                    .HasColumnName("COMPANYIDSIRET");

                entity.Property(e => e.Companynafcode).HasColumnName("COMPANYNAFCODE");

                entity.Property(e => e.CompanytypeMx).HasColumnName("COMPANYTYPE_MX");

                entity.Property(e => e.ConsdayJp).HasColumnName("CONSDAY_JP");

                entity.Property(e => e.Contactpersonid)
                    .HasMaxLength(20)
                    .HasColumnName("CONTACTPERSONID");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(8)
                    .HasColumnName("CREATEDBY");

                entity.Property(e => e.Createddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDDATETIME");

                entity.Property(e => e.Creditmax)
                    .HasColumnType("numeric(32, 16)")
                    .HasColumnName("CREDITMAX");

                entity.Property(e => e.Creditrating)
                    .HasMaxLength(10)
                    .HasColumnName("CREDITRATING");

                entity.Property(e => e.CurpMx)
                    .HasMaxLength(18)
                    .HasColumnName("CURP_MX");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.Dataareaid)
                    .HasMaxLength(4)
                    .HasColumnName("DATAAREAID");

                entity.Property(e => e.Dba)
                    .HasMaxLength(100)
                    .HasColumnName("DBA");

                entity.Property(e => e.Defaultdimension).HasColumnName("DEFAULTDIMENSION");

                entity.Property(e => e.Defaultinventstatusid)
                    .HasMaxLength(10)
                    .HasColumnName("DEFAULTINVENTSTATUSID");

                entity.Property(e => e.DelCreatedtime).HasColumnName("DEL_CREATEDTIME");

                entity.Property(e => e.DelModifiedtime).HasColumnName("DEL_MODIFIEDTIME");

                entity.Property(e => e.Destinationcodeid)
                    .HasMaxLength(30)
                    .HasColumnName("DESTINATIONCODEID");

                entity.Property(e => e.DiotcountrycodeMx)
                    .HasMaxLength(30)
                    .HasColumnName("DIOTCOUNTRYCODE_MX");

                entity.Property(e => e.Disabledowned).HasColumnName("DISABLEDOWNED");

                entity.Property(e => e.Dlvmode)
                    .HasMaxLength(30)
                    .HasColumnName("DLVMODE");

                entity.Property(e => e.Dlvterm)
                    .HasMaxLength(30)
                    .HasColumnName("DLVTERM");

                entity.Property(e => e.Enddisc)
                    .HasMaxLength(30)
                    .HasColumnName("ENDDISC");

                entity.Property(e => e.Enterprisecode)
                    .HasMaxLength(50)
                    .HasColumnName("ENTERPRISECODE");

                entity.Property(e => e.Enterprisenumber)
                    .HasMaxLength(50)
                    .HasColumnName("ENTERPRISENUMBER");

                entity.Property(e => e.Ethnicoriginid)
                    .HasMaxLength(15)
                    .HasColumnName("ETHNICORIGINID");

                entity.Property(e => e.Factoringaccount)
                    .HasMaxLength(20)
                    .HasColumnName("FACTORINGACCOUNT");

                entity.Property(e => e.Femaleowned).HasColumnName("FEMALEOWNED");

                entity.Property(e => e.FinecodeBr)
                    .HasMaxLength(30)
                    .HasColumnName("FINECODE_BR");

                entity.Property(e => e.Fiscalcode)
                    .HasMaxLength(16)
                    .HasColumnName("FISCALCODE");

                entity.Property(e => e.Foreignentityindicator).HasColumnName("FOREIGNENTITYINDICATOR");

                entity.Property(e => e.ForeigneridBr)
                    .HasMaxLength(20)
                    .HasColumnName("FOREIGNERID_BR");

                entity.Property(e => e.ForeignresidentRu).HasColumnName("FOREIGNRESIDENT_RU");

                entity.Property(e => e.ForeigntaxregistrationMx)
                    .HasMaxLength(40)
                    .HasColumnName("FOREIGNTAXREGISTRATION_MX");

                entity.Property(e => e.Freightzone)
                    .HasMaxLength(30)
                    .HasColumnName("FREIGHTZONE");

                entity.Property(e => e.HeirIt).HasColumnName("HEIR_IT");

                entity.Property(e => e.Hubzone).HasColumnName("HUBZONE");

                entity.Property(e => e.IcmscontributorBr).HasColumnName("ICMSCONTRIBUTOR_BR");

                entity.Property(e => e.IenumBr)
                    .HasMaxLength(20)
                    .HasColumnName("IENUM_BR");

                entity.Property(e => e.Incltax).HasColumnName("INCLTAX");

                entity.Property(e => e.InssceiBr)
                    .HasMaxLength(15)
                    .HasColumnName("INSSCEI_BR");

                entity.Property(e => e.IntbankLv)
                    .HasMaxLength(10)
                    .HasColumnName("INTBANK_LV");

                entity.Property(e => e.InterestcodeBr)
                    .HasMaxLength(30)
                    .HasColumnName("INTERESTCODE_BR");

                entity.Property(e => e.Inventlocation)
                    .HasMaxLength(30)
                    .HasColumnName("INVENTLOCATION");

                entity.Property(e => e.InventprofileidRu)
                    .HasMaxLength(30)
                    .HasColumnName("INVENTPROFILEID_RU");

                entity.Property(e => e.InventprofiletypeRu).HasColumnName("INVENTPROFILETYPE_RU");

                entity.Property(e => e.Inventsiteid)
                    .HasMaxLength(10)
                    .HasColumnName("INVENTSITEID");

                entity.Property(e => e.Invoiceaccount)
                    .HasMaxLength(20)
                    .HasColumnName("INVOICEACCOUNT");

                entity.Property(e => e.IspaymfeecoveredJp).HasColumnName("ISPAYMFEECOVERED_JP");

                entity.Property(e => e.IsresidentLv).HasColumnName("ISRESIDENT_LV");

                entity.Property(e => e.Itembuyergroupid)
                    .HasMaxLength(30)
                    .HasColumnName("ITEMBUYERGROUPID");

                entity.Property(e => e.Linedisc)
                    .HasMaxLength(30)
                    .HasColumnName("LINEDISC");

                entity.Property(e => e.Lineofbusinessid)
                    .HasMaxLength(30)
                    .HasColumnName("LINEOFBUSINESSID");

                entity.Property(e => e.Locallyowned).HasColumnName("LOCALLYOWNED");

                entity.Property(e => e.Lvpaymtranscodes).HasColumnName("LVPAYMTRANSCODES");

                entity.Property(e => e.Maincontactworker).HasColumnName("MAINCONTACTWORKER");

                entity.Property(e => e.MandatoryvatdatePl).HasColumnName("MANDATORYVATDATE_PL");

                entity.Property(e => e.Markupgroup)
                    .HasMaxLength(30)
                    .HasColumnName("MARKUPGROUP");

                entity.Property(e => e.Matchingpolicy).HasColumnName("MATCHINGPOLICY");

                entity.Property(e => e.Memo).HasColumnName("MEMO");

                entity.Property(e => e.Minorityowned).HasColumnName("MINORITYOWNED");

                entity.Property(e => e.MntAccionista).HasColumnName("MNT_ACCIONISTA");

                entity.Property(e => e.MntCodigopais)
                    .HasMaxLength(3)
                    .HasColumnName("MNT_CODIGOPAIS");

                entity.Property(e => e.MntCustaccount)
                    .HasMaxLength(20)
                    .HasColumnName("MNT_CUSTACCOUNT");

                entity.Property(e => e.MntDobtrib).HasColumnName("MNT_DOBTRIB");

                entity.Property(e => e.MntExtsujret).HasColumnName("MNT_EXTSUJRET");

                entity.Property(e => e.MntFpago)
                    .HasMaxLength(2)
                    .HasColumnName("MNT_FPAGO");

                entity.Property(e => e.MntPagolocext).HasColumnName("MNT_PAGOLOCEXT");

                entity.Property(e => e.MntPagoregfis).HasColumnName("MNT_PAGOREGFIS");

                entity.Property(e => e.Mntdenoregimenfiscal)
                    .HasMaxLength(500)
                    .HasColumnName("MNTDENOREGIMENFISCAL");

                entity.Property(e => e.Mntpaispagoregimengeneral)
                    .HasMaxLength(3)
                    .HasColumnName("MNTPAISPAGOREGIMENGENERAL");

                entity.Property(e => e.Mntparaisofiscal)
                    .HasMaxLength(2)
                    .HasColumnName("MNTPARAISOFISCAL");

                entity.Property(e => e.Mntregimenfiscalext)
                    .HasMaxLength(2)
                    .HasColumnName("MNTREGIMENFISCALEXT");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(8)
                    .HasColumnName("MODIFIEDBY");

                entity.Property(e => e.Modifieddatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIEDDATETIME");

                entity.Property(e => e.Multilinedisc)
                    .HasMaxLength(30)
                    .HasColumnName("MULTILINEDISC");

                entity.Property(e => e.Namecontrol)
                    .HasMaxLength(4)
                    .HasColumnName("NAMECONTROL");

                entity.Property(e => e.NationalityMx)
                    .HasMaxLength(50)
                    .HasColumnName("NATIONALITY_MX");

                entity.Property(e => e.NitBr)
                    .HasMaxLength(14)
                    .HasColumnName("NIT_BR");

                entity.Property(e => e.NontaxableBr).HasColumnName("NONTAXABLE_BR");

                entity.Property(e => e.Numbersequencegroup)
                    .HasMaxLength(30)
                    .HasColumnName("NUMBERSEQUENCEGROUP");

                entity.Property(e => e.Offsetaccounttype).HasColumnName("OFFSETACCOUNTTYPE");

                entity.Property(e => e.Offsetledgerdimension).HasColumnName("OFFSETLEDGERDIMENSION");

                entity.Property(e => e.Onetimevendor).HasColumnName("ONETIMEVENDOR");

                entity.Property(e => e.OperationtypeMx).HasColumnName("OPERATIONTYPE_MX");

                entity.Property(e => e.Organizationnumber)
                    .HasMaxLength(20)
                    .HasColumnName("ORGANIZATIONNUMBER");

                entity.Property(e => e.Orgid)
                    .HasMaxLength(10)
                    .HasColumnName("ORGID");

                entity.Property(e => e.Partition).HasColumnName("PARTITION");

                entity.Property(e => e.Party).HasColumnName("PARTY");

                entity.Property(e => e.Paymdayid)
                    .HasMaxLength(30)
                    .HasColumnName("PAYMDAYID");

                entity.Property(e => e.Paymid)
                    .HasMaxLength(200)
                    .HasColumnName("PAYMID");

                entity.Property(e => e.Paymmode)
                    .HasMaxLength(30)
                    .HasColumnName("PAYMMODE");

                entity.Property(e => e.Paymsched)
                    .HasMaxLength(30)
                    .HasColumnName("PAYMSCHED");

                entity.Property(e => e.Paymspec)
                    .HasMaxLength(30)
                    .HasColumnName("PAYMSPEC");

                entity.Property(e => e.Paymtermid)
                    .HasMaxLength(30)
                    .HasColumnName("PAYMTERMID");

                entity.Property(e => e.PresencetypeBr).HasColumnName("PRESENCETYPE_BR");

                entity.Property(e => e.Pricegroup)
                    .HasMaxLength(30)
                    .HasColumnName("PRICEGROUP");

                entity.Property(e => e.Purchamountpurchaseorder).HasColumnName("PURCHAMOUNTPURCHASEORDER");

                entity.Property(e => e.Purchcalendarid)
                    .HasMaxLength(10)
                    .HasColumnName("PURCHCALENDARID");

                entity.Property(e => e.Purchpoolid)
                    .HasMaxLength(30)
                    .HasColumnName("PURCHPOOLID");

                entity.Property(e => e.Recid).HasColumnName("RECID");

                entity.Property(e => e.Recversion).HasColumnName("RECVERSION");

                entity.Property(e => e.RegnumW)
                    .HasMaxLength(25)
                    .HasColumnName("REGNUM_W");

                entity.Property(e => e.Residenceforeigncountryregionid)
                    .HasMaxLength(30)
                    .HasColumnName("RESIDENCEFOREIGNCOUNTRYREGIONID");

                entity.Property(e => e.RfcMx)
                    .HasMaxLength(13)
                    .HasColumnName("RFC_MX");

                entity.Property(e => e.Secondtin).HasColumnName("SECONDTIN");

                entity.Property(e => e.Segmentid)
                    .HasMaxLength(20)
                    .HasColumnName("SEGMENTID");

                entity.Property(e => e.SeparatedivisionidRu)
                    .HasMaxLength(20)
                    .HasColumnName("SEPARATEDIVISIONID_RU");

                entity.Property(e => e.ServicecodeondlvaddressBr).HasColumnName("SERVICECODEONDLVADDRESS_BR");

                entity.Property(e => e.Smallbusiness).HasColumnName("SMALLBUSINESS");

                entity.Property(e => e.StateinscriptionMx)
                    .HasMaxLength(30)
                    .HasColumnName("STATEINSCRIPTION_MX");

                entity.Property(e => e.StructdepartmentRu)
                    .HasMaxLength(30)
                    .HasColumnName("STRUCTDEPARTMENT_RU");

                entity.Property(e => e.Subsegmentid)
                    .HasMaxLength(20)
                    .HasColumnName("SUBSEGMENTID");

                entity.Property(e => e.Suppitemgroupid)
                    .HasMaxLength(30)
                    .HasColumnName("SUPPITEMGROUPID");

                entity.Property(e => e.Tamrebategroupid)
                    .HasMaxLength(20)
                    .HasColumnName("TAMREBATEGROUPID");

                entity.Property(e => e.Tax1099fields).HasColumnName("TAX1099FIELDS");

                entity.Property(e => e.Tax1099namechoice).HasColumnName("TAX1099NAMECHOICE");

                entity.Property(e => e.Tax1099regnum)
                    .HasMaxLength(11)
                    .HasColumnName("TAX1099REGNUM");

                entity.Property(e => e.Tax1099reports).HasColumnName("TAX1099REPORTS");

                entity.Property(e => e.Taxgroup)
                    .HasMaxLength(30)
                    .HasColumnName("TAXGROUP");

                entity.Property(e => e.Taxidtype).HasColumnName("TAXIDTYPE");

                entity.Property(e => e.TaxperiodpaymentcodePl)
                    .HasMaxLength(10)
                    .HasColumnName("TAXPERIODPAYMENTCODE_PL");

                entity.Property(e => e.Taxwithholdcalculate).HasColumnName("TAXWITHHOLDCALCULATE");

                entity.Property(e => e.Taxwithholdgroup)
                    .HasMaxLength(30)
                    .HasColumnName("TAXWITHHOLDGROUP");

                entity.Property(e => e.TaxwithholdvendortypeTh).HasColumnName("TAXWITHHOLDVENDORTYPE_TH");

                entity.Property(e => e.UnitedvatinvoiceLt).HasColumnName("UNITEDVATINVOICE_LT");

                entity.Property(e => e.Usecashdisc).HasColumnName("USECASHDISC");

                entity.Property(e => e.Vatnum)
                    .HasMaxLength(20)
                    .HasColumnName("VATNUM");

                entity.Property(e => e.VatoperationcodeRu)
                    .HasMaxLength(10)
                    .HasColumnName("VATOPERATIONCODE_RU");

                entity.Property(e => e.VatpartnerkindRu).HasColumnName("VATPARTNERKIND_RU");

                entity.Property(e => e.VattaxagentRu).HasColumnName("VATTAXAGENT_RU");

                entity.Property(e => e.VendconsumptionBr).HasColumnName("VENDCONSUMPTION_BR");

                entity.Property(e => e.Vendexceptiongroup).HasColumnName("VENDEXCEPTIONGROUP");

                entity.Property(e => e.Vendgroup)
                    .HasMaxLength(30)
                    .HasColumnName("VENDGROUP");

                entity.Property(e => e.VendincomecodeBr)
                    .HasMaxLength(10)
                    .HasColumnName("VENDINCOMECODE_BR");

                entity.Property(e => e.VendinvoicedeclarationIs).HasColumnName("VENDINVOICEDECLARATION_IS");

                entity.Property(e => e.Venditemgroupid)
                    .HasMaxLength(30)
                    .HasColumnName("VENDITEMGROUPID");

                entity.Property(e => e.Vendorportaladministratorrecid).HasColumnName("VENDORPORTALADMINISTRATORRECID");

                entity.Property(e => e.VendortypeMx).HasColumnName("VENDORTYPE_MX");

                entity.Property(e => e.VendpaymfeegroupJp)
                    .HasMaxLength(20)
                    .HasColumnName("VENDPAYMFEEGROUP_JP");

                entity.Property(e => e.Vendpricetolerancegroupid)
                    .HasMaxLength(30)
                    .HasColumnName("VENDPRICETOLERANCEGROUPID");

                entity.Property(e => e.Veteranowned).HasColumnName("VETERANOWNED");

                entity.Property(e => e.W9included).HasColumnName("W9INCLUDED");

                entity.Property(e => e.Youraccountnum)
                    .HasMaxLength(20)
                    .HasColumnName("YOURACCOUNTNUM");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
