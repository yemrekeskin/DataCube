using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conventions.MyCarContext
{
    /// <summary>
    /// BackingField, KeyId, KeyTypeNameId
    /// </summary>
    public class MyCarContext 
        : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }

    public class Car
    {
        public int Id { get; set; }  
        //public string Id { get; set; }
        //public string CarId { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }

        // backing field
        private string _engine;
        public string Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }
    }
}
