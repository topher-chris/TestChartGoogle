using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace TestChartGoogle.Models
{
    [Table("RunningSpot")]
    public class RunningSpot
    {
        public decimal Rate { get; set; }
        public string LocationName { get; set; }
    }
}
