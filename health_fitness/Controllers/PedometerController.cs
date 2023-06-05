using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using health_fitness.Models;

namespace health_fitness.Controllers
{
    public class PedometerController : Controller
    {
        private stepscontext _stContext;
        public PedometerController(stepscontext stContext)
        {
            _stContext = stContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Steps()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StepsToCalories(StepInfo NumOfSteps)
        {
            NumOfSteps.time = DateTime.Now;
            
            double TotalCaloriesBurned = NumOfSteps.stepsnumber * 0.04;
            _stContext.StepSInfo.Add(NumOfSteps);
            _stContext.SaveChanges ();
            return View(TotalCaloriesBurned);
        }
    }
}
