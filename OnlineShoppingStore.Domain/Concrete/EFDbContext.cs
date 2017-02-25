﻿using OnlineShoppingStore.Domain.Entities;
using System.Data.Entity;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
