﻿using eshop.Domain;
using eshop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EshopDbContext dbContext;

        public CategoryRepository(EshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            return dbContext.Categories.AsEnumerable();
        }

        public Category GetById(int id)
        {
            return dbContext.Categories.FirstOrDefault(c => c.Id == id);
        }

        public bool IsExists(int id)
        {
           return dbContext.Categories.Any(c => c.Id == id);
        }

        public Task Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
