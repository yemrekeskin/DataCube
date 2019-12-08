using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Blogging
{
    public class Blog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BlogId { get; set; }

        public string Url { get; set; }

        // backing fields
        private string _test;
        public string Test
        {
            get { return _test; }
            set { _test = value; }
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Inserted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastUpdated { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }

        public List<Post> Posts { get; } = new List<Post>();
    }
}
