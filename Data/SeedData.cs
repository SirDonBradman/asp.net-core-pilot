using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContosoPets.Api.Models;

namespace Core.Data
{
    public static class SeedData
    {
        public static void Initialize(EMSContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Id = "1",
                        Name = "Squeaky Bone",
                        Price = 20.99m
                    },
                    new Product
                    {
                        Id = "2",
                        Name = "Knotted Rope",
                        Price = 12.99m
                    },
                    new Product
                    {
                        Id = "3",
                        Name = "Bats",
                        Price = 12.99m
                    },
                    new Product
                    {
                        Id = "4",
                        Name = "Balls",
                        Price = 12.99m
                    },
                    new Product
                    {
                        Id = "5",
                        Name = "Leg Guards",
                        Price = 12.99m
                    }
                );

                context.SaveChanges();
            }
        }
    }
}