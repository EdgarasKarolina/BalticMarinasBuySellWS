using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalticMarinasBuySellWS.Models
{
    public class SoldItem
    {
        private SoldItemContext context;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public int Sold { get; set; }
    }
}
