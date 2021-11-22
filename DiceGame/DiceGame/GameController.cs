using System;
using System.Collections.Generic;
namespace DiceGame
{
	public class GameController
	{
		private Player[] players; // 0 1 2 3
		private int rounds; // 30
		private int turn;
		public GameController(int rounds, int numberOfPlayers)
		{
			this.rounds = rounds;
			this.players = new Player[numberOfPlayers];
			this.turn = 0;
		}
		public int getNumberOfPlayes()
			{ return this.players.Length; }
		public Player getPlayer(int index)
		{
			return this.players[index];
		}
		public Boolean checkIndex(int index)
        {
			return index < this.players.Length;
        }
		public Boolean setPlayer(Player player)
		{
			if (player.getId() > -1 && player.getId() < this.players.Length)
			{
				this.players[player.getId()] = player;
				return true;
			}
			return false;
		}
		public Boolean RollDice()
		{
			Random random = new Random();
			int score = random.Next(1, 6);
			this.turn++;
			if (this.turn >= this.players.Length) //if the round is over
			{
				setRoundWinner();
				this.turn = 0;
				if (this.players[this.turn]
					.getRound() > rounds)
				{
					//this.setWinner(this.players);
					return false;
				}
				else
				{
					this.players[this.players.Length - 1].unSelect();
					this.players[this.players.Length - 1].fillBank(score);
					this.players[this.turn].selected();
					this.players[this.players.Length - 1].addRound();
					this.players[this.turn].addRound();
				}
			}
			else
			{
				this.players[this.turn - 1].unSelect();
				this.players[turn - 1].fillBank(score);
				this.players[this.turn].selected();
				this.players[this.turn - 1].addRound();
				this.players[this.turn].addRound();
			}

			return true;
		}

		public Player getWinner()
		{
			return this.setWinner();
		}
		public void setRoundWinner()
		{
			Player[] sortedPlayers = (Player[])this.players.Clone();
			for (int i = 0; i < sortedPlayers.Length; i++)
			{
				for (int j = 0; j < sortedPlayers.Length - 1; j++)
				{

					if (sortedPlayers[j].getBank() > sortedPlayers[j + 1].getBank())
					{
						Player tempPlayer = sortedPlayers[j];
						sortedPlayers[j] = sortedPlayers[j + 1];
						sortedPlayers[j + 1] = tempPlayer;

					}
				}
			}
			for (int i = players.Length - 1; i > 0; i--)
			{

				if (sortedPlayers[i].getBank() == sortedPlayers[i - 1].getPoints())
				{
					Player roundWinner = sortedPlayers[i];
					roundWinner.addPoints(2);
					this.players[roundWinner.getId()] = roundWinner;
					roundWinner = sortedPlayers[i - 1];
					roundWinner.addPoints(2);
					this.players[roundWinner.getId()] = roundWinner;
				}
				else
				{
					Player roundWinner = sortedPlayers[sortedPlayers.Length - 1];
					roundWinner.setRoundWinner();
					this.players[roundWinner.getId()] = roundWinner;
				}
			}
		}

		public Player setWinner()
		{
			Player[] sortedPlayers = this.players;
			for (int i = 0; i < sortedPlayers.Length; i++)
			{
				for (int j = 0; j < sortedPlayers.Length - 1; j++)
				{

					if (sortedPlayers[j].getPoints() > sortedPlayers[j + 1].getPoints())
					{
						Player tempPlayer = sortedPlayers[j];
						sortedPlayers[j] = sortedPlayers[j + 1];
						sortedPlayers[j + 1] = tempPlayer;

					}
				}
			}
			int highestEqual = 100 * 30; // no one will reach this score since the will be 30 rounds max
			for (int i = players.Length - 1; i > 0; i--)
			{
				if (sortedPlayers[i].getPoints() > sortedPlayers[i - 1].getPoints() && sortedPlayers[i].getPoints() < highestEqual)
				{
					return sortedPlayers[i];
				}
				if (sortedPlayers[i].getPoints() == sortedPlayers[i - 1].getPoints())
				{
					highestEqual = sortedPlayers[i].getPoints();
				}
			}
			return sortedPlayers[players.Length - 1];

		}
	}

}
