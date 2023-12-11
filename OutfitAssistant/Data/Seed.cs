using OutfitAssistant.Models;

namespace OutfitAssistant.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.AppUsers.Any())
                {
                    context.AppUsers.AddRange(new List<AppUser>()
                    {
                        new AppUser()
                        {
                            UserName = "admin",
                            PassWord = "admin",
                            Email = "dattran.uit.se@gmail.com",
                            FullName = "Trần Thành Đạt",
                            Age = 19,
                            Gender = "Male",
                            Height = (decimal)165,
                            Weight = (decimal)62.5,
                            IsDeleted = false
                        },
                        new AppUser()
                        {
                            UserName="mannhi",
                            PassWord="mannhi",
                            Email = "neban0444@gmail.com",
                            FullName ="Mẫn Nhi",
                            Age = 19,
                            Gender ="Female",
                            Height = (decimal)154,
                            Weight = (decimal) 45.2,
                            IsDeleted = false

                        }
                    });
                    context.SaveChanges();
                }
                if(!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Nike Sportswear",
                            Description="A SWOOSH BY ANY OTHER NAME.Love is in the Swoosh and this tee is all about it. Made with soft cotton and a roomy fit, it features an embroidered rose design that celebrates Valentine's Day.BenefitsEveryday cotton fabric feels soft and light.Slightly dropped shoulders and a loose fit provide a comfortable, confident feel.Product DetailsLoose fit for a roomy feelPrinted graphics100% cottonMachine washImportedShown: Bleached CoralStyle: DN5886-697",
                            Images = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/ededaf67-b3bc-4b11-a7f8-bd00d4d855d6/sportswear-womens-t-shirt-hRqn3F.png",
                            Brand = "Nike",
                            Color = "Bleached",
                            Currency = "USD",
                            Price = (decimal)34.97,
                            Availability = "InStock",
                            AvgRating = (decimal)4.5,
                            ScrapedAt = DateTime.Parse("2023-2-12"),
                            Url = "https://www.nike.com/t/sportswear-womens-t-shirt-hRqn3F",
                            IsDeleted=false
                        },
                        new Product()
                        {
                            Name = "Air Jordan XXXV Low DS PF",
                            Description="Â Basketball players create separation by cutting quicker, running faster and jumping higher than the competition. The ultra-lightweight Air Jordan XXXV Low helps transform your speed and power into linear and vertical separation. Similar to the inline game shoe, it uses a sculpted and stable midsole that's loaded with visible, large-volume Zoom Air units to help you exploit the space you create. The lower collar height allows ankle mobility while keeping you fully and comfortably contained. This PF version has an extra-durable outsole that's ideal for outdoor courts.Eclipse the CompetitionThe sculpted Eclipse plate 2.0 is raised along its upper edge to enhance side-to-side stability and support. It's hollowed out to reduce the shoe's overall weight while letting you see through the shoe.2x Visible ZoomZoom Air cushioning under the heel and forefoot has a springy, responsive feel. The large-volume heel unit provides impact cushioning, while the forefoot unit helps support your game. The edges of both units are visible through the hollow midsole plate.Lace Up, Lock InFlightwire cables stitched into the side radiate up from the curved plate. When you lace up they pull the material snugly over the sides and top of your foot to help keep you stable on the footbed.Traction and ControlThe rubber outsole uses a modified herringbone tread pattern that grips the court. It's designed to help you stop, start and change directions on the fly.More BenefitsThe extra-durable outsole rubber is designed to play on outdoor courts.Product DetailsFoam soleTongue pull tabNot intended for use as Personal Protective Equipment (PPE)Shown: Hyper Jade/Bright Crimson/Blue Orbit/Metallic SilverStyle: DJ2831-300\r\n",
                            Images = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/ff21da1f-71dc-40a1-bd2d-78c25e67d3a4/air-jordan-xxxv-low-ds-pf-basketball-shoes-5GGtjV.png",
                            Brand = "Nike",
                            Color = "Hyper Jade/Bright Crimson/Blue Orbit/Metallic Silver",
                            Currency = "USD",
                            Price = (decimal)165,
                            Availability = "InStock",
                            AvgRating = (decimal)4.9,
                            ScrapedAt = DateTime.Parse("2023-2-12"),
                            Url = "https://www.nike.com/t/air-jordan-xxxv-low-ds-pf-basketball-shoes-5GGtjV",
                            IsDeleted=false
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
