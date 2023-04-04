using DAL.EF;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private string _connectionString;

        public ProductRepository()
        {

        }

        public Product GetById(int id)
        {
            using (IngredientContext db = new IngredientContext())
            {
                return db.Products.Where(pr => pr.Id == id).FirstOrDefault();
            }
        }

        public List<Product> GetAll()
        {
            using (var db = new IngredientContext())
            {
                return db.Products.ToList();
            }
        }

        public void Add(Product item)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
