using System;
using DemoEntity.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoEntity.Data
{
    public partial class traffictraineesContext : DbContext, ItraffictraineesContext
    {
        public traffictraineesContext()
        {
        }

        public traffictraineesContext(DbContextOptions<traffictraineesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminUser> AdminUser { get; set; }
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<CarDetails> CarDetails { get; set; }
        public virtual DbSet<DeletedCarDetails> DeletedCarDetails { get; set; }
        public virtual DbSet<DeletedUsers> DeletedUsers { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<OtpVerification> OtpVerification { get; set; }
        public virtual DbSet<PreviousCarDetails> PreviousCarDetails { get; set; }
        public virtual DbSet<TrafficViolationArabic> TrafficViolationArabic { get; set; }
        public virtual DbSet<TrafficViolationDat> TrafficViolationDat { get; set; }
        public virtual DbSet<TrafficViolationDetails> TrafficViolationDetails { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }
        //public virtual DbSet<UserRoles> UserRoles { get; set; }
        //public virtual DbSet<Verification> Verification { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=n6.iworklab.com;Database=traffic-trainees;User ID=traffic-trainees;Password=TR32D9aWJRUS20#;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__AdminUse__719FE488DB08D6A7");

                entity.Property(e => e.AdminEmailId).IsRequired();

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FullName).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Role).IsUnicode(false);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<CarDetails>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CarDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CarDetails_UserId_PK_UserDetails_UserId");
            });

            modelBuilder.Entity<DeletedCarDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeletedUsers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.Verify).HasColumnName("verify");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.Property(e => e.Direction).HasMaxLength(450);

                entity.Property(e => e.EventDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EventName).IsRequired();

                entity.Property(e => e.ExpireDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireTime)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Location).HasMaxLength(550);

                entity.Property(e => e.ModifyDateTime).HasColumnType("datetime");

                entity.Property(e => e.Other).HasMaxLength(850);

                entity.Property(e => e.RoadStreet)
                    .HasColumnName("Road_Street")
                    .HasMaxLength(250);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtpVerification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExpirationTime).HasColumnType("datetime");

                entity.Property(e => e.Otp).HasColumnName("OTP");
            });

            modelBuilder.Entity<PreviousCarDetails>(entity =>
            {
                entity.HasIndex(e => e.CarDetailsId);

                entity.HasIndex(e => e.UserId);
            });

            modelBuilder.Entity<TrafficViolationArabic>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrafficViolationDat>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IndexOnDAT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cd).HasColumnName("CD");
            });

            modelBuilder.Entity<TrafficViolationDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CarSpeed)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).IsRequired();

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SiteSpeed)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserId_TrafficViolationDetails_PK_UserId_UserDetails");
            });

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.ActivatedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ActivatedDate).HasColumnType("date");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.VerifiedDate).HasColumnType("date");

                entity.Property(e => e.Verify).HasColumnName("verify");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Verification>(entity =>
            {
                entity.ToTable("verification");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
