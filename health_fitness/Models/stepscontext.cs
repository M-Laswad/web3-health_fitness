using Microsoft.EntityFrameworkCore;

namespace health_fitness.Models

{
    public class stepscontext:DbContext
    {
        public stepscontext(DbContextOptions<stepscontext> options)
            :base(options)
        {

        }
        //اسم المودل بالمفرد داخل الحاصرات وبالجمع بعدها
        public DbSet<StepInfo> StepSInfo { get; set; }
    }
}
