using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Concrete
{
    public partial class PilsanDatabaseContext : DbContext
    {
        public PilsanDatabaseContext()
        {
        }

        public PilsanDatabaseContext(DbContextOptions<PilsanDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departman> Departmen { get; set; } = null!;
        public virtual DbSet<Durak> Duraks { get; set; } = null!;
        public virtual DbSet<Kimlik> Kimliks { get; set; } = null!;
        public virtual DbSet<Personel> Personels { get; set; } = null!;
        public virtual DbSet<Servi> Servis { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<Vardiya> Vardiyas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source = /Users/kutluhanyegit/Desktop/Pilsan2/DataAccess/Data/PilsanDatabase.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departman>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("departman");

                entity.Property(e => e.Adi).HasColumnName("ADI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Sirket).HasColumnName("SIRKET");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Durak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("durak");

                entity.Property(e => e.DurakAdi).HasColumnName("DURAK_ADI");

                entity.Property(e => e.DurakKodu).HasColumnName("DURAK_KODU");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.ServisKodu).HasColumnName("SERVIS_KODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");
            });

            modelBuilder.Entity<Kimlik>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kimlik");

                entity.Property(e => e.Aileno).HasColumnName("AILENO");

                entity.Property(e => e.Anne).HasColumnName("ANNE");

                entity.Property(e => e.Baba).HasColumnName("BABA");

                entity.Property(e => e.Ciltno).HasColumnName("CILTNO");

                entity.Property(e => e.Cinsyt).HasColumnName("CINSYT");

                entity.Property(e => e.Czno).HasColumnName("CZNO");

                entity.Property(e => e.Czseri).HasColumnName("CZSERI");

                entity.Property(e => e.Dini).HasColumnName("DINI");

                entity.Property(e => e.Dogil).HasColumnName("DOGIL");

                entity.Property(e => e.Dogilce).HasColumnName("DOGILCE");

                entity.Property(e => e.Dogtar).HasColumnName("DOGTAR");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Il).HasColumnName("IL");

                entity.Property(e => e.Ilce).HasColumnName("ILCE");

                entity.Property(e => e.Kangrb).HasColumnName("KANGRB");

                entity.Property(e => e.Kayitno).HasColumnName("KAYITNO");

                entity.Property(e => e.Koy).HasColumnName("KOY");

                entity.Property(e => e.Mahalle).HasColumnName("MAHALLE");

                entity.Property(e => e.Medhal).HasColumnName("MEDHAL");

                entity.Property(e => e.Onsoy).HasColumnName("ONSOY");

                entity.Property(e => e.Prsicil).HasColumnName("PRSICIL");

                entity.Property(e => e.Sirano).HasColumnName("SIRANO");

                entity.Property(e => e.Tckmno).HasColumnName("TCKMNO");

                entity.Property(e => e.Uyruk).HasColumnName("UYRUK");

                entity.Property(e => e.Verned).HasColumnName("VERNED");

                entity.Property(e => e.Vertar).HasColumnName("VERTAR");

                entity.Property(e => e.Veryer).HasColumnName("VERYER");
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("personel");

                entity.Property(e => e.Adi).HasColumnName("ADI");

                entity.Property(e => e.Aktif).HasColumnName("AKTIF");

                entity.Property(e => e.Altdepart).HasColumnName("ALTDEPART");

                entity.Property(e => e.Altdepart2).HasColumnName("ALTDEPART2");

                entity.Property(e => e.Altdepart3).HasColumnName("ALTDEPART3");

                entity.Property(e => e.Altdepart4).HasColumnName("ALTDEPART4");

                entity.Property(e => e.Altdeptar).HasColumnName("ALTDEPTAR");

                entity.Property(e => e.Altdeptar2).HasColumnName("ALTDEPTAR2");

                entity.Property(e => e.Altdeptar3).HasColumnName("ALTDEPTAR3");

                entity.Property(e => e.Altdeptar4).HasColumnName("ALTDEPTAR4");

                entity.Property(e => e.Amir1).HasColumnName("AMIR1");

                entity.Property(e => e.Amir2).HasColumnName("AMIR2");

                entity.Property(e => e.Amir3).HasColumnName("AMIR3");

                entity.Property(e => e.Amir4).HasColumnName("AMIR4");

                entity.Property(e => e.Amir5).HasColumnName("AMIR5");

                entity.Property(e => e.BirimKodu).HasColumnName("BIRIM_KODU");

                entity.Property(e => e.BirimTarihi).HasColumnName("BIRIM_TARIHI");

                entity.Property(e => e.Cikndn).HasColumnName("CIKNDN");

                entity.Property(e => e.Depart).HasColumnName("DEPART");

                entity.Property(e => e.Deptar).HasColumnName("DEPTAR");

                entity.Property(e => e.DomainUsername).HasColumnName("DOMAIN_USERNAME");

                entity.Property(e => e.Durak).HasColumnName("DURAK");

                entity.Property(e => e.DurakTarihi).HasColumnName("DURAK_TARIHI");

                entity.Property(e => e.GecisYetkituru).HasColumnName("GECIS_YETKITURU");

                entity.Property(e => e.Gmyaka).HasColumnName("GMYAKA");

                entity.Property(e => e.Gorev).HasColumnName("GOREV");

                entity.Property(e => e.Gorevtar).HasColumnName("GOREVTAR");

                entity.Property(e => e.GrupKodu).HasColumnName("GRUP_KODU");

                entity.Property(e => e.GrupTarihi).HasColumnName("GRUP_TARIHI");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Iscikt).HasColumnName("ISCIKT");

                entity.Property(e => e.Isgirt).HasColumnName("ISGIRT");

                entity.Property(e => e.Kadro).HasColumnName("KADRO");

                entity.Property(e => e.Kadrotar).HasColumnName("KADROTAR");

                entity.Property(e => e.Kartno).HasColumnName("KARTNO");

                entity.Property(e => e.Kisitlama).HasColumnName("KISITLAMA");

                entity.Property(e => e.Kod1).HasColumnName("KOD1");

                entity.Property(e => e.Kod2).HasColumnName("KOD2");

                entity.Property(e => e.Kredi).HasColumnName("KREDI");

                entity.Property(e => e.KrediBastar).HasColumnName("KREDI_BASTAR");

                entity.Property(e => e.KrediBittar).HasColumnName("KREDI_BITTAR");

                entity.Property(e => e.Krttar).HasColumnName("KRTTAR");

                entity.Property(e => e.Masraf).HasColumnName("MASRAF");

                entity.Property(e => e.Masraftar).HasColumnName("MASRAFTAR");

                entity.Property(e => e.Mesai).HasColumnName("MESAI");

                entity.Property(e => e.Meslek).HasColumnName("MESLEK");

                entity.Property(e => e.Meslektar).HasColumnName("MESLEKTAR");

                entity.Property(e => e.OnySifre).HasColumnName("ONY_SIFRE");

                entity.Property(e => e.Pertip).HasColumnName("PERTIP");

                entity.Property(e => e.Pertiptar).HasColumnName("PERTIPTAR");

                entity.Property(e => e.PiCardid).HasColumnName("PI_CARDID");

                entity.Property(e => e.PiIdno).HasColumnName("PI_IDNO");

                entity.Property(e => e.PiIdnoYdk).HasColumnName("PI_IDNO_YDK");

                entity.Property(e => e.Posta).HasColumnName("POSTA");

                entity.Property(e => e.Postar).HasColumnName("POSTAR");

                entity.Property(e => e.Puantb).HasColumnName("PUANTB");

                entity.Property(e => e.Servis).HasColumnName("SERVIS");

                entity.Property(e => e.Servistar).HasColumnName("SERVISTAR");

                entity.Property(e => e.Sicilno).HasColumnName("SICILNO");

                entity.Property(e => e.Sifre).HasColumnName("SIFRE");

                entity.Property(e => e.Soyadi).HasColumnName("SOYADI");

                entity.Property(e => e.SubeKodu).HasColumnName("SUBE_KODU");

                entity.Property(e => e.SubeTarihi).HasColumnName("SUBE_TARIHI");

                entity.Property(e => e.Tpgirt).HasColumnName("TPGIRT");

                entity.Property(e => e.Ucrettipi).HasColumnName("UCRETTIPI");

                entity.Property(e => e.Ucretturu).HasColumnName("UCRETTURU");

                entity.Property(e => e.Yetkituru).HasColumnName("YETKITURU");

                entity.Property(e => e.Yilizhesapt).HasColumnName("YILIZHESAPT");
            });

            modelBuilder.Entity<Servi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("servis");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.Kodu).HasColumnName("KODU");

                entity.Property(e => e.Srkodu).HasColumnName("SRKODU");

                entity.Property(e => e.Turu).HasColumnName("TURU");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("Shift");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Vardiya>(entity =>
            {
                entity.ToTable("vardiya");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
