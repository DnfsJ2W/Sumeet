using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace dbfirstcore.Models
{
    public partial class employeedbContext : DbContext
    {
        public employeedbContext()
        {
        }

        public employeedbContext(DbContextOptions<employeedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employeee> Employeees { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Tbldepartment> Tbldepartments { get; set; }
        public virtual DbSet<Tblemployee> Tblemployees { get; set; }
        public virtual DbSet<Tbllogin> Tbllogins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=employeedb;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employeee>(entity =>
            {
                entity.Property(e => e.Ename).IsRequired();

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbldepartment>(entity =>
            {
                entity.ToTable("tbldepartment");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblemployee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__tblemplo__AF2DBB992103FC89");

                entity.ToTable("tblemployee");

                entity.Property(e => e.Ename)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Esalary).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Tblemployees)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblemploy__DeptI__25869641");
            });

            modelBuilder.Entity<Tbllogin>(entity =>
            {
                entity.ToTable("tbllogin");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
