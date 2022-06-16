using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniCommerce.Application.Abstract;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.DbContexts
{


    public class MiniCommerceDbContext : IdentityDbContext<User, Role, int>
    {
        public MiniCommerceDbContext(DbContextOptions<MiniCommerceDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Interceptor
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
                //_ = data.State switch
                //{
                //    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                //    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now
                //};

                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.Now;

                        break;
                    case EntityState.Modified:
                        data.Entity.UpdatedDate = DateTime.Now;
                        break;
                }
            }


            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            #region Unique

            modelBuilder.Entity<User>(u => u.HasIndex(x => x.Email).IsUnique());
            modelBuilder.Entity<Category>(u => u.HasIndex(x => x.Name).IsUnique());
            modelBuilder.Entity<Product>(u => u.HasIndex(x => x.Name).IsUnique());
            #endregion

            #region Default
            //modelBuilder.Entity<User>(u => u.Property(x => x.IsAdmin).HasDefaultValue(false));
            modelBuilder.Entity<Product>(u => u.Property(x => x.IsSold).HasDefaultValue(false));
            modelBuilder.Entity<Product>(u => u.Property(x => x.IsOfferable).HasDefaultValue(false));
            modelBuilder.Entity<Offer>(u => u.Property(x => x.IsApproved).HasDefaultValue(false));
            #endregion

            #region Not Null
            modelBuilder.Entity<Category>(u => u.Property(x => x.Name).IsRequired().HasMaxLength(150));
            modelBuilder.Entity<Category>(u => u.Property(x => x.Description).IsRequired().HasMaxLength(300));

            modelBuilder.Entity<Product>(u => u.Property(x => x.Name).IsRequired());
            modelBuilder.Entity<Product>(u => u.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)"));
            modelBuilder.Entity<Product>(u => u.Property(x => x.CategoryId).IsRequired());
            modelBuilder.Entity<Product>(u => u.Property(x => x.UsageId).IsRequired());

            modelBuilder.Entity<User>(u => u.Property(x => x.FirstName).IsRequired().HasMaxLength(15));
            modelBuilder.Entity<User>(u => u.Property(x => x.LastName).IsRequired().HasMaxLength(15));
            modelBuilder.Entity<User>(u => u.Property(x => x.Address).IsRequired());
            modelBuilder.Entity<User>(u => u.Property(x => x.Email).IsRequired());
            modelBuilder.Entity<User>(u => u.Property(x => x.PasswordHash).IsRequired());

            modelBuilder.Entity<Offer>(u => u.Property(x => x.Price).IsRequired().HasColumnType("decimal(18,2)"));

            modelBuilder.Entity<Color>(u => u.Property(x => x.Name).IsRequired().HasMaxLength(50));

            modelBuilder.Entity<Brand>(u => u.Property(x => x.Name).IsRequired().HasMaxLength(50));

            modelBuilder.Entity<Usage>(u => u.Property(x => x.Name).IsRequired().HasMaxLength(50));

            #endregion

            #region RenameTables    
            //modelBuilder.Entity<IdentityUser>().ToTable("Users").Property(p => p.Id).HasColumnName("UserId");
            //modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            //modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            //modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            //modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            #endregion

            #region Seed Data

            var hasher = new PasswordHasher<User>();

            var user1 = new User() { Id = 1, FirstName = "Kutay", LastName = "Demirel", Address = "İzmir", Email = "kutay@seeddata.com", EmailConfirmed = true, NormalizedEmail = "KUTAY@SEEDDATA.COM", UserName = "kutay@seeddata.com", NormalizedUserName = "KUTAY@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Kty.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };
            var user2 = new User() { Id = 2, FirstName = "Lale", LastName = "Gezer", Address = "İzmir", Email = "lale@seeddata.com", EmailConfirmed = true, NormalizedEmail = "LALE@SEEDDATA.COM", UserName = "lale@seeddata.com", NormalizedUserName = "LALE@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Lal.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };
            var user3 = new User() { Id = 3, FirstName = "Mehmet", LastName = "Turan", Address = "İzmir", Email = "mehmet@seeddata.com", EmailConfirmed = true, NormalizedEmail = "MEHMET@SEEDDATA.COM", UserName = "mehmet@seeddata.com", NormalizedUserName = "MEHMET@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Mht.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };
            var user4 = new User() { Id = 4, FirstName = "Sezer", LastName = "Yılmaz", Address = "İzmir", Email = "sezer@seeddata.com", EmailConfirmed = true, NormalizedEmail = "SEZER@SEEDDATA.COM", UserName = "sezer@seeddata.com", NormalizedUserName = "SEZER@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Szr.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };
            var user5 = new User() { Id = 5, FirstName = "Mert", LastName = "Durmaz", Address = "İzmir", Email = "mert@seeddata.com", EmailConfirmed = true, NormalizedEmail = "MERT@SEEDDATA.COM", UserName = "mert@seeddata.com", NormalizedUserName = "MERT@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Mrt.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };
            var user6 = new User() { Id = 6, FirstName = "Kaan", LastName = "Kara", Address = "İzmir", Email = "kaan@seeddata.com", EmailConfirmed = true, NormalizedEmail = "KAAN@SEEDDATA.COM", UserName = "kaan@seeddata.com", NormalizedUserName = "KAAN@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Kty.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };
            var user7 = new User() { Id = 7, FirstName = "Bora", LastName = "Kırılmaz", Address = "İzmir", Email = "bora@seeddata.com", EmailConfirmed = true, NormalizedEmail = "BORA@SEEDDATA.COM", UserName = "bora@seeddata.com", NormalizedUserName = "BORA@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Bra.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };
            var user8 = new User() { Id = 8, FirstName = "Ahmet", LastName = "Yıkılmaz", Address = "İzmir", Email = "ahmet@seeddata.com", EmailConfirmed = true, NormalizedEmail = "AHMET@SEEDDATA.COM", UserName = "ahmet@seeddata.com", NormalizedUserName = "AHMET@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Aht.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };
            var user9 = new User() { Id = 9, FirstName = "Fatma", LastName = "Gedik", Address = "İzmir", Email = "fatma@seeddata.com", EmailConfirmed = true, NormalizedEmail = "FATMA@SEEDDATA.COM", UserName = "fatma@seeddata.com", NormalizedUserName = "FATMA@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Ftm.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };
            var user10 = new User() { Id = 10, FirstName = "Ezgi", LastName = "Dene", Address = "İzmir", Email = "ezgi@seeddata.com", EmailConfirmed = true, NormalizedEmail = "EZGI@SEEDDATA.COM", UserName = "ezgi@seeddata.com", NormalizedUserName = "EZGI@SEEDDATA.COM", PasswordHash = hasher.HashPassword(null, "Ezg.123456"), SecurityStamp = Guid.NewGuid().ToString("D") };

            modelBuilder.Entity<User>().HasData(user1, user2, user3, user4, user5, user6, user7, user8, user9, user10);

            modelBuilder.Entity<Category>().HasData(
                        new Category { Id = 1, Name = "Mont", Description = "Soğuk zamanlarda bire bir", CreatedDate = new DateTime(2022, 04, 16) },
                        new Category { Id = 2, Name = "Hırka ve Süveter", Description = "Baharda üşümeyin tutar", CreatedDate = new DateTime(2022, 04, 16) },
                        new Category { Id = 3, Name = "Kazak", Description = "Kışın üşümeyin diye", CreatedDate = new DateTime(2022, 04, 16) },
                        new Category { Id = 4, Name = "Gömlek", Description = "Şık zamanların tercihi", CreatedDate = new DateTime(2022, 04, 16) },
                        new Category { Id = 5, Name = "Tişört", Description = "Güneşin keyfini çıkar", CreatedDate = new DateTime(2022, 04, 16) },
                        new Category { Id = 6, Name = "Sweatshirt", Description = "Favorilerini seç soğuktan korun", CreatedDate = new DateTime(2022, 04, 16) },
                        new Category { Id = 7, Name = "Jean", Description = "Rahat pantolonlarla kendini keşfet", CreatedDate = new DateTime(2022, 04, 16) },
                        new Category { Id = 8, Name = "Elbise", Description = "Güzel görünmenin vakti", CreatedDate = new DateTime(2022, 04, 16) }
            );


            modelBuilder.Entity<Product>().HasData(
                        new Product { Id = 1, CategoryId = 1, ColorId = 7, UserId = 1, UsageId = 1, BrandId = 4, ImageUrl = "LCWCASUALBejMont.jpg", Name = "Slim Fit Kapüşonlu İnce Erkek Kanguru Mont", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 309.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 2, CategoryId = 1, ColorId = 5, UserId = 1, UsageId = 2, BrandId = 4, ImageUrl = "LCWCASUALPembeMont.jpg", Name = "Dik Yaka Düz Uzun Kollu İnce Kadın Mont", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 319.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 3, CategoryId = 2, ColorId = 4, UserId = 1, UsageId = 3, BrandId = 5, ImageUrl = "LCWBASICBeyazHirka.jpg", Name = "Bisiklet Yaka Düz Uzun Kollu Viskon Kadın Hırka", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 59.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 4, CategoryId = 2, ColorId = 6, UserId = 1, UsageId = 1, BrandId = 2, ImageUrl = "XSIDEYeşilHırka.jpg", Name = "Dik Yaka Düz Uzun Kollu Crop Kadın Hırka", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 109.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 5, CategoryId = 3, ColorId = 2, UserId = 2, UsageId = 2, BrandId = 1, ImageUrl = "LCWVISIONSarıKazak.jpg", Name = "Bisiklet Yaka Uzun Kollu Erkek Triko Kazak", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 139.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 6, CategoryId = 3, ColorId = 3, UserId = 2, UsageId = 1, BrandId = 4, ImageUrl = "LCWCASUALKirmiziKazak.jpg", Name = "Bisiklet Yaka Düz Uzun Kollu Kadın Triko Kazak", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 99.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 7, CategoryId = 4, ColorId = 8, UserId = 3, UsageId = 1, BrandId = 6, ImageUrl = "LCWFORMALMaviGomlek.jpg", Name = "Slim Fit Uzun Kollu Poplin Erkek Gömlek", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 289.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 8, CategoryId = 4, ColorId = 4, UserId = 3, UsageId = 2, BrandId = 1, ImageUrl = "LCWVISIONBeyazGomlek.jpg", Name = "Önden Düğme Kapamalı Düz Kısa Kollu Poplin Kadın Gömlek", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 149.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 9, CategoryId = 5, ColorId = 2, UserId = 3, UsageId = 3, BrandId = 2, ImageUrl = "XSIDESarıTisort.jpg", Name = "Bisiklet Yaka Baskılı Kısa Kollu Pamuklu Crop Kadın Tişört", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 99.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 10, CategoryId = 5, ColorId = 1, UserId = 4, UsageId = 1, BrandId = 4, ImageUrl = "LCWCASUALSiyahTisort.jpg", Name = "Polo Yaka Kısa Kollu Pike Erkek Tişört", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 149.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 11, CategoryId = 6, ColorId = 8, UserId = 5, UsageId = 3, BrandId = 2, ImageUrl = "XSIDEMaviSweatShirt.jpg", Name = "Kapüşon Yaka Nakışlı Uzun Kollu Kadın Sweatshirt", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 89.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 12, CategoryId = 6, ColorId = 6, UserId = 6, UsageId = 2, BrandId = 2, ImageUrl = "XSIDEYeşilSweatShirt.jpg", Name = "Kapüşonlu Uzun Kollu Baskılı Erkek Sweatshirt", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 199.99m, IsOfferable = true, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 13, CategoryId = 7, ColorId = 9, UserId = 7, UsageId = 1, BrandId = 4, ImageUrl = "LCWCASULGriJean.jpg", Name = "750 Slim Fit Erkek Jean Pantolon", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 189.99m, IsOfferable = false, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 14, CategoryId = 8, ColorId = 6, UserId = 8, UsageId = 2, BrandId = 1, ImageUrl = "LCWVISIONYesilElbise.jpg", Name = "Halter Yaka Düz Kolsuz Kadın Elbise", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 199.99m, IsOfferable = false, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) },
                        new Product { Id = 15, CategoryId = 8, ColorId = 5, UserId = 2, UsageId = 1, BrandId = 3, ImageUrl = "LCWCASUALPembeElbise.jpg", Name = "U Yaka Düz Askılı A Kesim Poplin Kadın Elbise", Description = "Hayatın keyfini çıkarın", Stock = 1, Price = 199.99m, IsOfferable = false, IsSold = false, CreatedDate = new DateTime(2022, 04, 16) }
            );

            modelBuilder.Entity<Brand>().HasData(
                        new Brand { Id = 1, Name = "LCW VISION", CreatedDate = new DateTime(2022, 04, 16) },
                        new Brand { Id = 2, Name = "XSIDE", CreatedDate = new DateTime(2022, 04, 16) },
                        new Brand { Id = 3, Name = "LCW CLASSIC", CreatedDate = new DateTime(2022, 04, 16) },
                        new Brand { Id = 4, Name = "LCW CASUAL", CreatedDate = new DateTime(2022, 04, 16) },
                        new Brand { Id = 5, Name = "LCW BASIC", CreatedDate = new DateTime(2022, 04, 16) },
                        new Brand { Id = 6, Name = "LCW FORMAL", CreatedDate = new DateTime(2022, 04, 16) }
                        );

            modelBuilder.Entity<Color>().HasData(
                        new Color { Id = 1, Name = "Siyah", CreatedDate = new DateTime(2022, 04, 16) },
                        new Color { Id = 2, Name = "Sarı", CreatedDate = new DateTime(2022, 04, 16) },
                        new Color { Id = 3, Name = "Kırmızı", CreatedDate = new DateTime(2022, 04, 16) },
                        new Color { Id = 4, Name = "Beyaz", CreatedDate = new DateTime(2022, 04, 16) },
                        new Color { Id = 5, Name = "Pembe", CreatedDate = new DateTime(2022, 04, 16) },
                        new Color { Id = 6, Name = "Yeşil", CreatedDate = new DateTime(2022, 04, 16) },
                        new Color { Id = 7, Name = "Bej", CreatedDate = new DateTime(2022, 04, 16) },
                        new Color { Id = 8, Name = "Mavi", CreatedDate = new DateTime(2022, 04, 16) },
                        new Color { Id = 9, Name = "Gri", CreatedDate = new DateTime(2022, 04, 16) }

                        );

            modelBuilder.Entity<Usage>().HasData(
                        new Usage { Id = 1, Name = "Yeni", CreatedDate = new DateTime(2022, 04, 16) },
                        new Usage { Id = 2, Name = "Az Kullanılmış", CreatedDate = new DateTime(2022, 04, 16) },
                        new Usage { Id = 3, Name = "Çok Kullanılmış", CreatedDate = new DateTime(2022, 04, 16) }
                        );

            modelBuilder.Entity<Offer>().HasData(
                        new Offer { Id = 1, Price = 50.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 6, UserId = 1, IsApproved = false },
                        new Offer { Id = 2, Price = 250.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 1, UserId = 2, IsApproved = false },
                        new Offer { Id = 3, Price = 230.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 1, UserId = 3, IsApproved = false },
                        new Offer { Id = 4, Price = 280.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 2, UserId = 4, IsApproved = false },
                        new Offer { Id = 5, Price = 271.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 2, UserId = 5, IsApproved = false },
                        new Offer { Id = 6, Price = 85.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 3, UserId = 6, IsApproved = false },
                        new Offer { Id = 7, Price = 70.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 3, UserId = 7, IsApproved = false },
                        new Offer { Id = 8, Price = 90.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 4, UserId = 5, IsApproved = false },
                        new Offer { Id = 9, Price = 92.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 5, UserId = 1, IsApproved = true },
                        new Offer { Id = 10, Price = 85.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 6, UserId = 2, IsApproved = true },
                        new Offer { Id = 11, Price = 205.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 7, UserId = 1, IsApproved = true },
                        new Offer { Id = 12, Price = 78.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 8, UserId = 1, IsApproved = false },
                        new Offer { Id = 13, Price = 95.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 9, UserId = 3, IsApproved = false },
                        new Offer { Id = 14, Price = 56.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 10, UserId = 3, IsApproved = false },
                        new Offer { Id = 15, Price = 76.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 11, UserId = 4, IsApproved = false },
                        new Offer { Id = 16, Price = 63.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 12, UserId = 4, IsApproved = false },
                        new Offer { Id = 17, Price = 84.00m, CreatedDate = new DateTime(2022, 04, 16), ProductId = 12, UserId = 1, IsApproved = false }

            );
            #endregion

        }
    }
}
