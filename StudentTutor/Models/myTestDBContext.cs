using Microsoft.EntityFrameworkCore;


namespace StudentTutor.Models
{
    public partial class myTestDBContext: DbContext
    {
        public myTestDBContext()
        {
        }

        public myTestDBContext(DbContextOptions<myTestDBContext> options)
            : base(options)
        {
        }
       
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<StudentDetails> StudentDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleEndDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduleStartDate).HasColumnType("datetime");

                entity.Property(e => e.ThemeColor)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentDetails>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__StudentD__32C52B99B907745A");

                entity.Property(e => e.StudentLevel)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
