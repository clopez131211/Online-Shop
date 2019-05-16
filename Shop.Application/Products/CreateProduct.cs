using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shop.Database;
using Shop.Domain.Models;

namespace Shop.Application.Products
{
    public class CreateProduct
    {
        private ApplicationDBContext _context;
        public CreateProduct(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Do(int id, string Name, string Description)
        {
            _context.Products.Add(new Product { Id = id, Name = Name, Description = Description });
        }
    }
}
