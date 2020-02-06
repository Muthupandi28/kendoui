using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using kendoui.Models;
namespace kendoui.Data
{
    public class PizzashopsContext : DbContext
    {


        public PizzashopsContext() : base("name=PizzashopsContext")
        {
        }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
