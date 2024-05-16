# Blackjack Console Game

This is a simple implementation of the classic Blackjack game in a console application written in C#. The game follows the standard rules of Blackjack, where the player tries to get a hand value as close to 21 as possible without going over, while competing against the dealer.

## Features

- Single-player mode against the dealer
- Ability to hit (draw another card) or stand (keep the current hand)
- Automatic handling of Aces (counted as 1 or 11 based on the hand value)
- Scoring system following the standard Blackjack rules
- Shuffle and draw cards from a standard 52-card deck
- Prompt to play again after each game

## Getting Started

To run the Blackjack Console Game, you need to have the .NET Core runtime installed on your system. You can download it from the official [.NET Core website](https://dotnet.microsoft.com/download).

1. Clone the repository or download the source code.
2. Open a terminal or command prompt and navigate to the `Blackjack/` folder inside the project directory.
3. Run the command `dotnet run` to start the game.

## Project Structure

The project is organized into the following files and folders:

- `Program.cs`: The entry point of the application.
- `Classes/`:
  - `Card.cs`: Represents a single playing card with a suit and value.
  - `Deck.cs`: Manages the deck of cards, including shuffling and drawing cards.
  - `Hand.cs`: Represents a hand of cards held by a player.
  - `Player.cs`: Defines the player and their hand, including scoring logic.
  - `Dealer.cs`: Represents the dealer and their hand, with behavior for playing their hand.
  - `GameManager.cs`: Handles the game flow, including dealing cards, managing player input, and determining the winner.

> [!NOTE]
> This project is intended for educational purposes as part of a backend development course.
