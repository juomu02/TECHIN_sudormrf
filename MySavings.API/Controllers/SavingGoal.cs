using Microsoft.AspNetCore.Mvc;
using MySavings.SavingGoal.Models;
using MySavings.Services;

namespace MySavings.Controllers
{
    [ApiController]
    [Route("goals")]
    public class GoalsController : ControllerBase
    {
        private readonly IGoalService _goalService;

        public GoalsController(IGoalService goalService)
        {
            _goalService = goalService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGoalDto dto)
        {
            var result = await _goalService.CreateGoalAsync(dto);
            return Ok(result);
        }
    }
}