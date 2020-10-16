using DemoEntity.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoEntity.Data
{
    public interface ItraffictraineesContext
    {
        DbSet<AdminUser> AdminUser { get; set; }
        DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        DbSet<AspNetRoles> AspNetRoles { get; set; }
        DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        DbSet<AspNetUsers> AspNetUsers { get; set; }
        DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        DbSet<Books> Books { get; set; }
        DbSet<CarDetails> CarDetails { get; set; }
        DbSet<DeletedCarDetails> DeletedCarDetails { get; set; }
        DbSet<DeletedUsers> DeletedUsers { get; set; }
        DbSet<Events> Events { get; set; }
        DbSet<OtpVerification> OtpVerification { get; set; }
        DbSet<PreviousCarDetails> PreviousCarDetails { get; set; }
        DbSet<TrafficViolationArabic> TrafficViolationArabic { get; set; }
        DbSet<TrafficViolationDat> TrafficViolationDat { get; set; }
        DbSet<TrafficViolationDetails> TrafficViolationDetails { get; set; }
    }
}