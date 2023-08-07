using Repository_Pattern.Data;
using Repository_Pattern.Models;
using Repository_Pattern.Repository;
using Repository_Pattern.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            using (var unitOfWork = new UnitOfWork(context))
            {
                IRepository<Product> productRepository = new ProductRepository(context);
                IRepository<User> userRepository = new UserRepository(context);
                IRepository<Category> categoryRepository = new CategoryRepository(context);
                IRepository<Order> orderRepository = new OrderRepository(context);
                IRepository<Reviews> reviewsRepository = new ReviewsRepository(context);


                var product = new Product { Name = "Water Bottle", Price = 19.99M, Description="abcd" };
                var user = new User { Username = "Taha",Email= "taha@gmail.com",Password="abcd" };
                var category = new Category { Name = "Bottles" };
                var order = new Order { OrderDate = DateTime.Now, UserId = user.Id};
                var reviews = new Reviews { Content="Good Product", Rating=5,ProductId = product.Id+1 };

                productRepository.Insert(product);
                userRepository.Insert(user);
                categoryRepository.Insert(category);
                orderRepository.Insert(order);
                reviewsRepository.Insert(reviews);

                unitOfWork.SaveChanges();

                var products = productRepository.GetAll();
                var users = userRepository.GetAll();
                var categories = categoryRepository.GetAll();
                var orders =orderRepository.GetAll();
                var review = reviewsRepository.GetAll();

                Console.WriteLine("Products:");
                foreach (var p in products)
                {
                    Console.WriteLine($"{p.Id}: {p.Name} - {p.Price:C}");
                }
                Console.WriteLine("Categories:");
                foreach (var c in categories)
                {
                    Console.WriteLine($"{c.Id}: {c.Name}");
                }
                Console.WriteLine("Orders:");
                foreach (var c in orders)
                {
                    Console.WriteLine($"{c.Id}: {c.UserId} - {c.OrderDate}");
                }
                Console.WriteLine("Reviews:");
                foreach (var c in review)
                {
                    Console.WriteLine($"{c.Id}: {c.Rating} - {c.ProductId}");
                }
                Console.WriteLine("Users:");
                foreach (var c in users)
                {
                    Console.WriteLine($"{c.Id}: {c.Username}- {c.Email}");
                }
               

            }
        }
    }
}
