using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevRes.Domain.Models.Enums;
namespace RevRes.Domain.Infrastructure
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataAccess>
    {
        protected override void Seed(DataAccess db)
        {
            #region Users
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jeff",
                    LastName = "Chan",
                    Password = "0016",
                    UserName = "jchan",
                    Role = Models.Enums.Role.Admin
                }
            );
            db.SaveChanges();
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "James",
                    LastName = "Yap",
                    Password = "0018",
                    UserName = "jyap",
                    Role = Models.Enums.Role.Admin
                }
            );
            db.SaveChanges();

            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Japeth",
                    LastName = "Aguilar",
                    Password = "0024",
                    UserName = "jaguilar",
                    Role = Models.Enums.Role.Cashier
                }
            );
            db.SaveChanges();

            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jervy",
                    LastName = "Cruz",
                    Password = "0011",
                    UserName = "jcruz",
                    Role = Models.Enums.Role.Cashier
                }
            );
            db.SaveChanges();

            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jericho",
                    LastName = "Cruz",
                    Password = "0012",
                    UserName = "jecruz",
                    Role = Models.Enums.Role.Chef
                }
            );
            db.SaveChanges();

            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Beau",
                    LastName = "Belga",
                    Password = "0013",
                    UserName = "bbelga",
                    Role = Models.Enums.Role.Chef
                }
            );
            db.SaveChanges();

            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Marc",
                    LastName = "Pingris",
                    Password = "0015",
                    UserName = "mpingris",
                    Role = Models.Enums.Role.InventoryController
                }
            );
            db.SaveChanges();

            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Greg",
                    LastName = "Slaughter",
                    Password = "0014",
                    UserName = "gslaughter",
                    Role = Models.Enums.Role.InventoryController
                }
            );
            db.SaveChanges();

            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "LA",
                    LastName = "Tenerio",
                    Password = "0017",
                    UserName = "ltenerio",
                    Role = Models.Enums.Role.Waiter
                }
            );
            db.SaveChanges();

            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Paul",
                    LastName = "Lee",
                    Password = "003",
                    UserName = "plee",
                    Role = Models.Enums.Role.Waiter
                }
            );
            db.SaveChanges();
            #endregion

            #region Categories
            db.Categories.Add(
                new Models.Category()
                {
                    Id = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac0"),
                    Name = "Beverages"
                }
            );
            db.SaveChanges();

            db.Categories.Add(
                new Models.Category()
                {
                    Id = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac1"),
                    Name = "Alcoholic",
                    ParentId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac0")
                }
            );
            db.SaveChanges();

            db.Categories.Add(
                new Models.Category()
                {
                    Id = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac2"),
                    Name = "Non-alcoholic",
                    ParentId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac0")
                }
            );
            db.SaveChanges();
            #endregion

            #region Products
            db.Products.Add(
                new Models.Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Beer",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac1"),
                    Price = decimal.Parse("50")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Rhum",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac1"),
                    Price = decimal.Parse("750")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Whiskey",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac1"),
                    Price = decimal.Parse("550")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Juice",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac2"),
                    Price = decimal.Parse("50")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Soda",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac2"),
                    Price = decimal.Parse("40")
                }
            );
            db.SaveChanges();

            db.Products.Add(
                new Models.Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Shake",
                    CategoryId = Guid.Parse("9f701a1e-e90a-4f23-8434-7c8372de0ac2"),
                    Price = decimal.Parse("80")
                }
            );
            db.SaveChanges();
            #endregion
        }
    }
}
