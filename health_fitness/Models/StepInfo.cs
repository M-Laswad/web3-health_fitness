using System.ComponentModel.DataAnnotations;

namespace health_fitness.Models
{
	public class StepInfo
	{
        public int stepsnumber { get; set; }
        [Key]
        public DateTime time { get; set; }
    }
}
