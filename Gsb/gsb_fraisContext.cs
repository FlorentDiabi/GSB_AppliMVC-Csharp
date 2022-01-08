using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GSB_AppliMVC_Csharp.Gsb
{
    public partial class gsb_fraisContext : DbContext
    {
        public gsb_fraisContext()
        {
        }

        public gsb_fraisContext(DbContextOptions<gsb_fraisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<Fichefrais> Fichefrais { get; set; }
        public virtual DbSet<Fraisforfait> Fraisforfait { get; set; }
        public virtual DbSet<Lignefraisforfait> Lignefraisforfait { get; set; }
        public virtual DbSet<Lignefraishorsforfait> Lignefraishorsforfait { get; set; }
        public virtual DbSet<Lignepuissancevehicule> Lignepuissancevehicule { get; set; }
        public virtual DbSet<Puissancevehicule> Puissancevehicule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string host = ConfigurationManager.AppSettings["Server"];
                string port = ConfigurationManager.AppSettings["Port"];
                string db = ConfigurationManager.AppSettings["Database"];
                string login = ConfigurationManager.AppSettings["Username"];
                string pwd = ConfigurationManager.AppSettings["Password"];
                string csMysql = ConfigurationManager.ConnectionStrings["SqlConnexion"].ToString();
                string format = String.Format(csMysql, host, port, db, login, pwd);
                optionsBuilder.UseMySQL(format);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.AccountType)
                    .HasColumnName("accountType")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Adresse)
                    .HasColumnName("adresse")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Cp)
                    .HasColumnName("cp")
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Dateembauche)
                    .HasColumnName("dateembauche")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Mdp)
                    .HasColumnName("mdp")
                    .HasMaxLength(255);

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Prenom)
                    .HasColumnName("prenom")
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Ville)
                    .HasColumnName("ville")
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Etat>(entity =>
            {
                entity.ToTable("etat");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Fichefrais>(entity =>
            {
                entity.HasKey(e => new { e.Idvisiteur, e.Mois })
                    .HasName("PRIMARY");

                entity.ToTable("fichefrais");

                entity.HasIndex(e => e.Idetat)
                    .HasName("idetat");

                entity.Property(e => e.Idvisiteur)
                    .HasColumnName("idvisiteur")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mois)
                    .HasColumnName("mois")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Datemodif)
                    .HasColumnName("datemodif")
                    .HasColumnType("date");

                entity.Property(e => e.Idetat)
                    .HasColumnName("idetat")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'CR'");

                entity.Property(e => e.Montantvalide)
                    .HasColumnName("montantvalide")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Nbjustificatifs).HasColumnName("nbjustificatifs");

                entity.HasOne(d => d.IdetatNavigation)
                    .WithMany(p => p.Fichefrais)
                    .HasForeignKey(d => d.Idetat)
                    .HasConstraintName("fichefrais_ibfk_1");

                entity.HasOne(d => d.IdvisiteurNavigation)
                    .WithMany(p => p.Fichefrais)
                    .HasForeignKey(d => d.Idvisiteur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fichefrais_ibfk_2");
            });

            modelBuilder.Entity<Fraisforfait>(entity =>
            {
                entity.ToTable("fraisforfait");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Montant)
                    .HasColumnName("montant")
                    .HasColumnType("decimal(5,2)");
            });

            modelBuilder.Entity<Lignefraisforfait>(entity =>
            {
                entity.HasKey(e => new { e.Idvisiteur, e.Mois, e.Idfraisforfait })
                    .HasName("PRIMARY");

                entity.ToTable("lignefraisforfait");

                entity.HasIndex(e => e.Idfraisforfait)
                    .HasName("idfraisforfait");

                entity.Property(e => e.Idvisiteur)
                    .HasColumnName("idvisiteur")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mois)
                    .HasColumnName("mois")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Idfraisforfait)
                    .HasColumnName("idfraisforfait")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Quantite).HasColumnName("quantite");

                entity.HasOne(d => d.IdfraisforfaitNavigation)
                    .WithMany(p => p.Lignefraisforfait)
                    .HasForeignKey(d => d.Idfraisforfait)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lignefraisforfait_ibfk_2");

                entity.HasOne(d => d.Fichefrais)
                    .WithMany(p => p.Lignefraisforfait)
                    .HasForeignKey(d => new { d.Idvisiteur, d.Mois })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lignefraisforfait_ibfk_1");
            });

            modelBuilder.Entity<Lignefraishorsforfait>(entity =>
            {
                entity.ToTable("lignefraishorsforfait");

                entity.HasIndex(e => new { e.Idvisiteur, e.Mois })
                    .HasName("idvisiteur");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Idvisiteur)
                    .IsRequired()
                    .HasColumnName("idvisiteur")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100);

                entity.Property(e => e.Mois)
                    .IsRequired()
                    .HasColumnName("mois")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Montant)
                    .HasColumnName("montant")
                    .HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Lignepuissancevehicule>(entity =>
            {
                entity.HasKey(e => new { e.Idvisiteur, e.Mois })
                    .HasName("PRIMARY");

                entity.ToTable("lignepuissancevehicule");

                entity.HasIndex(e => e.Idpuissancevehicule)
                    .HasName("FK_IDPUISSANCEVEHICULE_PUISSANCEVEHICULE");

                entity.Property(e => e.Idvisiteur)
                    .HasColumnName("idvisiteur")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Mois)
                    .HasColumnName("mois")
                    .HasMaxLength(6)
                    .IsFixedLength();

                entity.Property(e => e.Idpuissancevehicule).HasColumnName("idpuissancevehicule");

                entity.HasOne(d => d.IdpuissancevehiculeNavigation)
                    .WithMany(p => p.Lignepuissancevehicule)
                    .HasForeignKey(d => d.Idpuissancevehicule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IDPUISSANCEVEHICULE_PUISSANCEVEHICULE");

                entity.HasOne(d => d.Fichefrais)
                    .WithOne(p => p.Lignepuissancevehicule)
                    .HasForeignKey<Lignepuissancevehicule>(d => new { d.Idvisiteur, d.Mois })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IDVISITEUR_MOIS_FICHEFRAIS");
            });

            modelBuilder.Entity<Puissancevehicule>(entity =>
            {
                entity.ToTable("puissancevehicule");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Prixkm)
                    .HasColumnName("prixkm")
                    .HasColumnType("decimal(3,2)");

                entity.Property(e => e.Puissance)
                    .IsRequired()
                    .HasColumnName("puissance")
                    .HasMaxLength(8);

                entity.Property(e => e.Typevehicule)
                    .HasColumnName("typevehicule")
                    .HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
