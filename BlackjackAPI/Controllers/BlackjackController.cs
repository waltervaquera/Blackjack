using Microsoft.AspNetCore.Mvc;
using BlackjackAPI.Classes;

namespace BlackjackAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlackjackController : Controller
    {
        private GameManager gameManager;

        public BlackjackController()
        {
            gameManager = new GameManager();
        }

        [HttpPost("start")]
        public IActionResult StartGame()
        {
            gameManager.StartGame();
            return Ok();
        }

        [HttpGet("player-hand")]
        public IActionResult GetPlayerHand()
        {
            return Ok(gameManager.GetPlayerHand());
        }

        [HttpGet("dealer-hand")]
        public IActionResult GetDealerHand()
        {
            return Ok(gameManager.GetDealerHand());
        }

        [HttpPost("hit")]
        public IActionResult Hit()
        {
            gameManager.Hit();
            return Ok();
        }

        [HttpPost("stand")]
        public IActionResult Stand()
        {
            GameResult gameResult = gameManager.Stand();
            return Ok(gameResult);
        }
    }
}
