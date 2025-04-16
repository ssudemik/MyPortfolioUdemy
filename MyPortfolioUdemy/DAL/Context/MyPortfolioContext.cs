using Microsoft.EntityFrameworkCore;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.DAL.Context
{
    public class MyPortfolioContext : DbContext //dbcontext sınıfına ait proportyleri kullanabilmek için.
    {
        //override //mevcuttaki bir metodu ezip istediğimiz formatta kullanabilmek için.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //bağlantı stringinin verdiğim method.
        {
            optionsBuilder.UseSqlServer("Server=MODELSUDE;initial Catalog=MyPortfolioDb;integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        //sınıfları sql'e yansıtma.
        //code first yapısı kullanarak db bağlantılı işlem yapma.


        //About c# daki sınıf ismiyken Abouts sqldeki tablo ismi. Böylece entitiyler birbiri ile karışmayacak.
        public DbSet<About> Abouts { get; set; } 
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
