using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIA.Models
{
    public class RecallModel
    {
        public string Count { get; set; }
        public string Message { get; set; }
        public List<RecallProduct> Results { get; set; }
    }

    public class RecallProduct
    {
        public string ModelYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
