namespace estia.pos.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EstiaModel : DbContext
    {
        public EstiaModel()
            : base("name=EstiaDb")
        {
        }

        public virtual DbSet<appartment> appartments { get; set; }
        public virtual DbSet<Aytonomia_analysh> Aytonomia_analysh { get; set; }
        public virtual DbSet<Aytonomia_metrisis> Aytonomia_metrisis { get; set; }
        public virtual DbSet<Aytonomia_Metritis_diam> Aytonomia_Metritis_diam { get; set; }
        public virtual DbSet<BuildAdmin> BuildAdmins { get; set; }
        public virtual DbSet<BuildEjoda> BuildEjodas { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<eidos_plhrvmhs> eidos_plhrvmhs { get; set; }
        public virtual DbSet<Eispraksei> Eisprakseis { get; set; }
        public virtual DbSet<ejoda> ejodas { get; set; }
        public virtual DbSet<esoda> esodas { get; set; }
        public virtual DbSet<KoinoCat> KoinoCats { get; set; }
        public virtual DbSet<Koinoxrista> Koinoxristas { get; set; }
        public virtual DbSet<KoinoxristaAnalyshDiamer> KoinoxristaAnalyshDiamers { get; set; }
        public virtual DbSet<KoinoxristaAnalyshKtirio> KoinoxristaAnalyshKtirios { get; set; }
        public virtual DbSet<KoinoxrostaMynhmata> KoinoxrostaMynhmatas { get; set; }
        public virtual DbSet<Tameio> Tameios { get; set; }
        public virtual DbSet<Trapeza> Trapezas { get; set; }
        public virtual DbSet<WorkCategory> WorkCategories { get; set; }
        public virtual DbSet<XreosiPistosi> XreosiPistosis { get; set; }
        public virtual DbSet<XreosiPistosi_Eidos> XreosiPistosi_Eidos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<appartment>()
                .Property(e => e.appid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.buildid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.apptitle)
                .IsUnicode(false);

            modelBuilder.Entity<appartment>()
                .Property(e => e.ownerid)
                .IsUnicode(false);

            modelBuilder.Entity<appartment>()
                .Property(e => e.resedentid)
                .IsUnicode(false);

            modelBuilder.Entity<appartment>()
                .Property(e => e.sn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xkoino)
                .HasPrecision(16, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pkoino)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xelev)
                .HasPrecision(16, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pelev)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.ei)
                .HasPrecision(18, 4);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xowner)
                .HasPrecision(16, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.powner)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xother)
                .HasPrecision(16, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pother)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.klisto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pklisto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xther)
                .HasPrecision(16, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pther)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.ektiposi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.remowner)
                .IsUnicode(false);

            modelBuilder.Entity<appartment>()
                .Property(e => e.remresident)
                .IsUnicode(false);

            modelBuilder.Entity<appartment>()
                .Property(e => e.remappartment)
                .IsUnicode(false);

            modelBuilder.Entity<appartment>()
                .Property(e => e.eiboiler)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.fiboiler)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xOther1)
                .HasPrecision(16, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xOther2)
                .HasPrecision(16, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xOther3)
                .HasPrecision(12, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xOther4)
                .HasPrecision(16, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.xOther5)
                .HasPrecision(16, 2);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pOther1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pOther2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pOther3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pOther4)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .Property(e => e.pOther5)
                .HasPrecision(18, 0);

            modelBuilder.Entity<appartment>()
                .HasMany(e => e.KoinoxristaAnalyshDiamers)
                .WithRequired(e => e.appartment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.prohg_metr)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.torini_metr)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.mesi_timi_litroy)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.ei)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.fi)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.wres)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.ei_wres)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.sum_ei_wres)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.ei_fi)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.sum_ei_fi)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.analogia_pagioy)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.analogia_wrwn)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_analysh>()
                .Property(e => e.synolo)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.BuildID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.cm)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.prohg_metr_cm)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.torini_metr_cm)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.prohg_metr_LT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.torini_metr_LT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.timi_litroy_agoras)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.mesi_timi_litroy)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.diafora_lt)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.kostos_fill)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.trexon_syn_kostos)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.BuildEjodaID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .Property(e => e.sum_litrwn)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Aytonomia_metrisis>()
                .HasMany(e => e.Aytonomia_analysh)
                .WithRequired(e => e.Aytonomia_metrisis)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Aytonomia_Metritis_diam>()
                .Property(e => e.appid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Aytonomia_Metritis_diam>()
                .HasMany(e => e.Aytonomia_analysh)
                .WithRequired(e => e.Aytonomia_Metritis_diam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BuildAdmin>()
                .Property(e => e.BuildAdminID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BuildAdmin>()
                .Property(e => e.BuildID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BuildEjoda>()
                .Property(e => e.BuildEjodaID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BuildEjoda>()
                .Property(e => e.BuildID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BuildEjoda>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<BuildEjoda>()
                .Property(e => e.ContactID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BuildEjoda>()
                .Property(e => e.workid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BuildEjoda>()
                .Property(e => e.timh_ana_litro)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Building>()
                .Property(e => e.BuildID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Building>()
                .Property(e => e.Area)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.StreetNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.TK)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.DEHnum)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.EYDAPnum)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Gasnum)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.Apothematiko)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Building>()
                .Property(e => e.PetreleoDejamenis)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Building>()
                .Property(e => e.KodHlekPlhr)
                .IsUnicode(false);

            modelBuilder.Entity<Building>()
                .Property(e => e.litra_ana_cm)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Building>()
                .HasMany(e => e.appartments)
                .WithRequired(e => e.Building)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.ContactID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Contact>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.WorkID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Contact>()
                .Property(e => e.PhoneHome)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.PhoneMoblie)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.PhoneWork)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.PhoneFax)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Contact>()
                .Property(e => e.pososto_prom)
                .HasPrecision(7, 6);

            modelBuilder.Entity<Eispraksei>()
                .Property(e => e.APPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ejoda>()
                .Property(e => e.ejodaid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ejoda>()
                .Property(e => e.descr)
                .IsUnicode(false);

            modelBuilder.Entity<ejoda>()
                .Property(e => e.poso)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ejoda>()
                .Property(e => e.fpa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ejoda>()
                .Property(e => e.tamias)
                .IsUnicode(false);

            modelBuilder.Entity<esoda>()
                .Property(e => e.esodaid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<esoda>()
                .Property(e => e.buildid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<esoda>()
                .Property(e => e.workid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<esoda>()
                .Property(e => e.poso)
                .HasPrecision(19, 4);

            modelBuilder.Entity<esoda>()
                .Property(e => e.fpa)
                .HasPrecision(19, 4);

            modelBuilder.Entity<esoda>()
                .Property(e => e.ergatika)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KoinoCat>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<KoinoCat>()
                .HasMany(e => e.KoinoxristaAnalyshDiamers)
                .WithRequired(e => e.KoinoCat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KoinoCat>()
                .HasMany(e => e.KoinoxristaAnalyshKtirios)
                .WithRequired(e => e.KoinoCat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Koinoxrista>()
                .Property(e => e.buildid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Koinoxrista>()
                .Property(e => e.appid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Koinoxrista>()
                .Property(e => e.ownerposo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Koinoxrista>()
                .Property(e => e.residentposo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KoinoxristaAnalyshDiamer>()
                .Property(e => e.appid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KoinoxristaAnalyshDiamer>()
                .Property(e => e.ei)
                .HasPrecision(18, 4);

            modelBuilder.Entity<KoinoxristaAnalyshDiamer>()
                .Property(e => e.fi)
                .HasPrecision(18, 4);

            modelBuilder.Entity<KoinoxristaAnalyshDiamer>()
                .Property(e => e.prohg_metr)
                .HasPrecision(18, 4);

            modelBuilder.Entity<KoinoxristaAnalyshDiamer>()
                .Property(e => e.torini_metr)
                .HasPrecision(18, 4);

            modelBuilder.Entity<KoinoxristaAnalyshKtirio>()
                .Property(e => e.BuildID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tameio>()
                .Property(e => e.tameioID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tameio>()
                .Property(e => e.buildID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tameio>()
                .Property(e => e.APPID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tameio>()
                .Property(e => e.AppTitle)
                .IsFixedLength();

            modelBuilder.Entity<WorkCategory>()
                .Property(e => e.workid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorkCategory>()
                .Property(e => e.worktitle)
                .IsUnicode(false);

            modelBuilder.Entity<WorkCategory>()
                .Property(e => e.sn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<XreosiPistosi>()
                .Property(e => e.appid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<XreosiPistosi>()
                .Property(e => e.eidos_xp_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<XreosiPistosi>()
                .Property(e => e.contact_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<XreosiPistosi_Eidos>()
                .Property(e => e.eidos_xp_id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<XreosiPistosi_Eidos>()
                .HasMany(e => e.XreosiPistosis)
                .WithRequired(e => e.XreosiPistosi_Eidos)
                .WillCascadeOnDelete(false);
        }
    }
}
