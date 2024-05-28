using Microsoft.AspNetCore.Mvc;
using BlackjackAPI.Classes;

namespace BlackjackAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlackjackController : Controller
    {
        private static GameManager gameManager = new GameManager();

        [HttpPost("start")]
        public IActionResult StartGame()
        {
            gameManager.StartGame();
            return Ok("Game started. Get player and dealer hands to continue.");
        }

        [HttpGet("player-hand")]
        public IActionResult GetPlayerHand()
        {
            if (!gameManager.gameInProgress)
                return BadRequest("No game in progress. Start a new game first.");

            return Ok($"Your hand:\n{gameManager.GetPlayerHand()}Your Score: {gameManager.player.GetScore()}");
        }

        [HttpGet("dealer-hand")]
        public IActionResult GetDealerHand()
        {
            if (!gameManager.gameInProgress)
                return BadRequest("No game in progress. Start a new game first.");

            return Ok($"Dealer's hand:\n{gameManager.GetDealerHand(true)}");
        }

        [HttpPost("hit")]
        public IActionResult Hit()
        {
            if (!gameManager.gameInProgress)
                return BadRequest("No game in progress. Start a new game first.");

            gameManager.Hit();
            return Ok($"You hit.\nYour hand:\n{gameManager.GetPlayerHand()}Your Score: {gameManager.player.GetScore()}");
        }

        [HttpPost("stand")]
        public IActionResult Stand()
        {
            if (!gameManager.gameInProgress)
                return BadRequest("No game in progress. Start a new game first.");

            GameResult gameResult = gameManager.Stand();
            return Ok($"Game result: {gameResult}\nYour hand:\n{gameManager.GetPlayerHand()}Your Score: {gameManager.player.GetScore()}\n\n" +
                $"Dealer's hand:\n{gameManager.GetDealerHand(false)}Dealer's Score: {gameManager.dealer.GetScore()}");
        }
    }
}
