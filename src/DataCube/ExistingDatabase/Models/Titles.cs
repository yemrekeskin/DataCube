using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExistingDatabase.Models
{
    public partial class Titles
    {
        public Titles()
        {
            Roysched = new HashSet<Roysched>();
            Sales = new HashSet<Sales>();
            Titleauthor = new HashSet<Titleauthor>();
        }

        public string TitleId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string PubId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Advance { get; set; }
        public int? Royalty { get; set; }
        public int? YtdSales { get; set; }
        public string Notes { get; set; }
        public DateTime Pubdate { get; set; }

        public virtual Publishers Pub { get; set; }
        [NotMapped]
        public virtual ICollection<Roysched> Roysched { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
        public virtual ICollection<Titleauthor> Titleauthor { get; set; }
    }
}
