//using Microsoft.AspNetCore.Builder;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using MiniCommerce.Domain.Entities;
//using MiniCommerce.Persistence.DbContexts;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MiniCommerce.Persistence.Configurations
//{
//    public  class DataGenerator
//    {
//        public static void Initialize(IServiceProvider serviceProvider)
//        {
//            using (var context = new MiniCommerceDbContext(serviceProvider.GetRequiredService<DbContextOptions<MiniCommerceDbContext>>()))
//            {

//                //context.Database.Migrate();     // migration varsa veritabanını tohumlar


//                #region Categories

//                if (!context.Categories.Any())
//                {
//                    context.Categories.AddRange(new List<Category>()
//                    {

//                        new Category {Name = "Mont", Description = "Soğuk kış günleri üşümeyin diye", CreatedDate = new DateTime(2022, 04, 16) },
//                        new Category {Name = "Hırka ve Süveter", Description = "Soğuk kış günleri üşümeyin diye", CreatedDate = new DateTime(2022, 04, 16) },
//                        new Category {Name = "Kazak", Description = "Soğuk kış günleri üşümeyin diye", CreatedDate =new DateTime(2022, 04, 16) },
//                        new Category {Name = "Bluz", Description = "7/24 Basic Trend", CreatedDate = new DateTime(2022, 04, 16) },
//                        new Category {Name = "Gömlek", Description = "Keten Rahatlığı", CreatedDate = new DateTime(2022, 04, 16) },
//                        new Category {Name = "Tişört", Description = "Güneşin keyfini çıkar", CreatedDate = new DateTime(2022, 04, 16) },
//                        new Category {Name = "Sweatshirt", Description = "Favorilerini seç, en trend ürünleri keşfet", CreatedDate = new DateTime(2022, 04, 16) },
//                        new Category {Name = "Jean", Description = "Sezonun en hit parçalarını keşfet", CreatedDate = new DateTime(2022, 04, 16) },
//                        new Category {Name = "Yeni", Description = "demodemodemo", CreatedDate = new DateTime(2022, 04, 16) },
//                    });
//                    context.SaveChanges();
//                }

//                #endregion

//                #region Products

//                if (!context.Products.Any())
//                {
//                    context.Products.AddRange(new List<Product>()
//                    {
//                        new Product { CategoryId = 1, UserId = 1, Name = "Dik Yaka Erkek Deri Mont", Stock = 400,  Price = 2699.99m, IsOfferable = true, IsSold= false, CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 1, UserId = 1, Name = "Biker Yaka Erkek Deri Mont", Stock = 400, Price = 2199.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 1, UserId = 1, Name = "Gömlek Yaka Erkek Şişme Mont", Stock = 400, Price = 599.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 2, UserId = 1, Name = "Kuşak Detaylı Uzun Kollu Kadın Triko Hırka", Stock = 400, Price = 499.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 2, UserId = 2, Name = "Kapüşonlu Kendinden Desenli Kadın Süveter", Stock = 400, Price = 189.99m, IsOfferable = true,IsSold= false, CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 3, UserId = 2, Name = "Balıkçı Yaka Uzun Kollu Erkek Triko Kazak", Stock = 400, Price = 79.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 3, UserId = 2, Name = "Bisiklet Yaka Uzun Kollu Çizgili Erkek Triko Kazak", Stock = 400, Price = 149.99m, IsOfferable = true,IsSold= false, CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 4, UserId = 2, Name = "Kalp Yaka Kolsız Kadın Blız", Stock = 400, Price = 449.99m, IsOfferable = true,IsSold= false, CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 4, UserId = 3, Name = "Renk Bloklu Uzun Kollu Kadın Bluz", Stock = 400, Price = 599.99m, IsOfferable = true,IsSold= false, CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 5, UserId = 3, Name = "Uzun Kollu Poplin Erkek Gömlek", Stock = 400, Price = 349.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 5, UserId = 3, Name = "Uzun Kollu Keten Erkek Gömlek", Stock = 400, Price = 349.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 6, UserId = 3, Name = "Tül Detaylı Kadın Lima Tişört", Stock = 400, Price = 199.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 6, UserId = 4, Name = "Bisiklet Yaka Baskılı Kadın Tişört", Stock = 400, Price = 199.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 7, UserId = 5, Name = "Baskılı Erkek Sweatshirt", Stock = 400, Price = 299.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 7, UserId = 6, Name = "Outdoor Kapüşonlu Erkek Sweatshirt", Stock = 400, Price = 269.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 8, UserId = 7, Name = "Tül Kemer Detaylı Kadın Jean", Stock = 400, Price = 349.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                        new Product { CategoryId = 8, UserId = 8, Name = "Cepli Kadın Flare Jean", Stock = 400, Price = 269.99m, IsOfferable = true, IsSold= false,CreatedDate = new DateTime(2022, 04, 16) },
//                    });
//                    context.SaveChanges();
//                }

//                #endregion

     
//                #region Offer

//                if (!context.Offers.Any())
//                {
//                    context.Offers.AddRange(new List<Offer>()
//                    {
//                        new Offer { Price = 50, CreatedDate = new DateTime(2022, 04, 16), ProductId = 1, UserId = 1 },
//                        new Offer { Price = 50, CreatedDate = new DateTime(2022, 04, 16), ProductId = 1, UserId = 2 },
//                        new Offer { Price = 50, CreatedDate = new DateTime(2022, 04, 16), ProductId = 1, UserId = 3 },
//                        new Offer { Price = 70, CreatedDate = new DateTime(2022, 04, 16), ProductId = 2, UserId = 1},
//                        new Offer { Price = 70, CreatedDate = new DateTime(2022, 04, 16), ProductId = 3, UserId = 1},
//                        new Offer { Price = 90, CreatedDate = new DateTime(2022, 04, 16), ProductId = 4, UserId = 1},
//                        new Offer { Price = 90, CreatedDate = new DateTime(2022, 04, 16), ProductId = 5, UserId = 1},
//                        new Offer { Price = 50, CreatedDate = new DateTime(2022, 04, 16), ProductId = 6, UserId = 1},
//                    });
//                    context.SaveChanges();
//                }
//                #endregion

//            }
//        }
    //}
//}

