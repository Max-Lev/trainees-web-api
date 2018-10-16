using System;
using Microsoft.EntityFrameworkCore;
using Trainees.Data.Entities;
using System.Net.Sockets;
using System.Collections;

namespace Trainees.Data
{
    public class TraineesContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DbSet<Order>Orders {get;set;}

        public DbSet<Trainee> Clients { get; set; }

        public TraineesContext()
        {
            // constructor
        }

        public TraineesContext(DbContextOptions<TraineesContext> options): base(options)
        {
            // constructor override
        }

        //public void SaveTrainee(Trainee trainee)
        //{
        //    Clients.Add(trainee);
        //    this.SaveChanges(true);
        //}


    }
}
