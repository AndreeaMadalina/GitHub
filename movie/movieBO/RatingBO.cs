using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieBO
{
    public class RatingBO
    {
        public int RatingID { get; set; }
        public double Rating { get; set; }
        public int MovieID { get; set; }
        public int UserID { get; set; }
    }
}
