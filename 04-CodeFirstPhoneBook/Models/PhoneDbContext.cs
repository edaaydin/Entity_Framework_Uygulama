using Microsoft.EntityFrameworkCore;

namespace _04_CodeFirstPhoneBook.Models
{
    public class PhoneDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        // baglantı cumlecigimi - connection string 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.; Database = TelefonRehberi; Trusted_Connection = True; MultipleActiveResultSets = true; TrustServerCertificate = True;");
        }
    }
}
