using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProyectData.Model
{

    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>();
            modelBuilder.Entity<Matricula>();
            modelBuilder.Entity<Det_Matricula>();

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Curso> Curso { get; set; } = null!;
        public virtual DbSet<Matricula> Matricula { get; set; } = null!;
        public virtual DbSet<Det_Matricula> Det_Matricula { get; set; } = null!;

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //                optionsBuilder.UseOracle("User Id=ejemplo_ef_core;Password=123456;Data Source=localhost:1521/xe;");
            //            }
        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseOracle(@"User Id=UPC;Password=12345678;Data Source=localhost:1529/xe");
        }


        /*   protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
           modelBuilder.HasDefaultSchema("EJEMPLO_EF_CORE");

             modelBuilder.Entity<Categorium>(entity =>
             {
                 entity.ToTable("CATEGORIA");

                 entity.Property(e => e.Id)
                     .HasColumnType("NUMBER(38)")
                     .ValueGeneratedOnAdd()
                     .HasColumnName("ID");

                 entity.Property(e => e.Nombre)
                     .HasMaxLength(50)
                     .IsUnicode(false)
                     .HasColumnName("NOMBRE");
             });

             modelBuilder.HasSequence("CATEGORIA_SEQ");

             OnModelCreatingPartial(modelBuilder);
         }*/

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
