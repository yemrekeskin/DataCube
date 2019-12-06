using ExistingDatabase.Models;
using System;
using System.Linq;

namespace ExistingDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Install
            // Microsoft.EntityFrameworkCore.Design

            // Scaffold - DbContext 
            // "Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models

            // PUBS DB
            //Scaffold - DbContext "Server=.\SQLExpress;Database=pubs;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models

            using (PubsContext context = new PubsContext())
            {
                var list = context.Authors.AsQueryable().ToList();
                // record 23                
            };

            Console.ReadLine();
        }
    }
}
