using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SportsStore.Data;
using SportsStore.Data.Entities;

namespace SportsStore.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly SportsStoreDbContext _db;

        public ProductsController(SportsStoreDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> GetAll()
        {
            return _db.Products;
        } 
    }
}
