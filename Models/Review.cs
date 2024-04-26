using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByExample.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Reviewer { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        // navigation property
        public int RestaurantId { get; set; }
    }
}
