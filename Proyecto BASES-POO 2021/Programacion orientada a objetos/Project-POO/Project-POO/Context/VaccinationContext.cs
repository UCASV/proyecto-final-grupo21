using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Project_POO
{
    public partial class VaccinationContext : DbContext
    {
        public VaccinationContext()
        {
        }

        public VaccinationContext(DbContextOptions<VaccinationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Consult> Consults { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Gestor> Gestors { get; set; }
        public virtual DbSet<Gestorxcabin> Gestorxcabins { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Register> Registers { get; set; }
        public virtual DbSet<SecondaryEffect> SecondaryEffects { get; set; }
        public virtual DbSet<Sickness> Sicknesses { get; set; }
        public virtual DbSet<TypeEmployee> TypeEmployees { get; set; }
        public virtual DbSet<VaccinationProcess> VaccinationProcesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-AU4EUCNG\\MSSQLSERVER01;Database=VacunacionDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("CABIN");

                entity.HasIndex(e => e.Email, "UQ__CABIN__AB6E616474775BEA")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "UQ__CABIN__B43B145F77CF4829")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Phone).HasColumnName("phone");
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.ToTable("CITIZEN");

                entity.HasIndex(e => e.Adress, "UQ__CITIZEN__08D1A4B856963338")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__CITIZEN__AB6E6164D1782CED")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "UQ__CITIZEN__B43B145F91933365")
                    .IsUnique();

                entity.HasIndex(e => e.Dui, "UQ__CITIZEN__C03671B96340C409")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Dui)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DUI");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("full_name");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_gest__5629CD9C");

                entity.HasOne(d => d.IdInstitutionNavigation)
                    .WithMany(p => p.Citizens)
                    .HasForeignKey(d => d.IdInstitution)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITIZEN__id_inst__5535A963");
            });

            modelBuilder.Entity<Consult>(entity =>
            {
                entity.ToTable("CONSULT");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConsultationDay)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("consultation_day");

                entity.Property(e => e.ConsultationTime)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("consultation_time");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Consults)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONSULT__id_cabi__5812160E");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Consults)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONSULT__id_citi__59063A47");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.HasIndex(e => e.Adress, "UQ__EMPLOYEE__08D1A4B842FBE57B")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__EMPLOYEE__AB6E616448191D05")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdTypeEmployee).HasColumnName("id_type_employee");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__id_cab__5441852A");

                entity.HasOne(d => d.IdTypeEmployeeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdTypeEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__id_typ__534D60F1");
            });

            modelBuilder.Entity<Gestor>(entity =>
            {
                entity.ToTable("GESTOR");

                entity.HasIndex(e => e.Username, "UQ__GESTOR__F3DBC5728E51C6BD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Gestorxcabin>(entity =>
            {
                entity.ToTable("GESTORXCABIN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Gestorxcabins)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cabin_gestorxcabin");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Gestorxcabins)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_gestor_gestorxcabin");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("INSTITUTION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Institution1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("institution");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.ToTable("REGISTER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Gestor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gestor");

                entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

                entity.Property(e => e.LoginDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login_day");

                entity.Property(e => e.LoginTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login_time");

                entity.HasOne(d => d.IdGestorNavigation)
                    .WithMany(p => p.Registers)
                    .HasForeignKey(d => d.IdGestor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REGISTER__id_ges__52593CB8");
            });

            modelBuilder.Entity<SecondaryEffect>(entity =>
            {
                entity.ToTable("SECONDARY_EFFECTS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdVaccinationProcess).HasColumnName("id_vaccination_process");

                entity.Property(e => e.SeccondaryEffects)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("seccondary_effects");

                entity.HasOne(d => d.IdVaccinationProcessNavigation)
                    .WithMany(p => p.SecondaryEffects)
                    .HasForeignKey(d => d.IdVaccinationProcess)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SECONDARY__id_va__5AEE82B9");
            });

            modelBuilder.Entity<Sickness>(entity =>
            {
                entity.ToTable("SICKNESS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCitizen).HasColumnName("id_citizen");

                entity.Property(e => e.Sickness1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sickness");

                entity.HasOne(d => d.IdCitizenNavigation)
                    .WithMany(p => p.Sicknesses)
                    .HasForeignKey(d => d.IdCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SICKNESS__id_cit__571DF1D5");
            });

            modelBuilder.Entity<TypeEmployee>(entity =>
            {
                entity.ToTable("TYPE_EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TypeEmployee1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type_employee");
            });

            modelBuilder.Entity<VaccinationProcess>(entity =>
            {
                entity.ToTable("VACCINATION_PROCESS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CurrentStep)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("current_step");

                entity.Property(e => e.IdConsult).HasColumnName("id_consult");

                entity.Property(e => e.SecondVaccinationDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("second_vaccination_day");

                entity.Property(e => e.SecondVaccinationTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("second_vaccination_time");

                entity.Property(e => e.VaccunationDay)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vaccunation_day");

                entity.Property(e => e.VaccunationPlace)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vaccunation_place");

                entity.Property(e => e.VaccunationTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vaccunation_time");

                entity.HasOne(d => d.IdConsultNavigation)
                    .WithMany(p => p.VaccinationProcesses)
                    .HasForeignKey(d => d.IdConsult)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__id_co__59FA5E80");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
