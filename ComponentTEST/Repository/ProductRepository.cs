using ComponentTEST.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComponentTEST.Repository
{
    public class ProductRepository
    {
        public async Task<List<Product>> GetProduct()
        {
            var q= await (new NorthwindContext()).Products.ToListAsync();
            return q;
        }

    }
}
