using Engine.Cards.TurnCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class World
    {
        public static List<Player> players = new List<Player>();
        public List<FortuneCard> fortuneCardDeck = new List<FortuneCard>();
        public List<IntelligenceCard> intelligenceCardDeck = new List<IntelligenceCard>();
        public List<TurnCard> turnCardsDeck = new List<TurnCard>();

        public World(int numPlayers, List<FortuneCard> fortuneCards, List<IntelligenceCard> intelligenceCards, List<TurnCard> turnCards)
        {
            
            ShuffleDecks(fortuneCards, intelligenceCards, turnCards);
            InitializePlayers(numPlayers);
        }

        private void ShuffleDecks(List<FortuneCard> fortuneCards, List<IntelligenceCard> intelligenceCards, List<TurnCard> turnCards)
        {
          fortuneCardDeck.Clear();
          intelligenceCardDeck.Clear();
          turnCardsDeck.Clear();
        
          Random rng1 = new Random();
          Random rng2 = new Random();
          Random rng3 = new Random();

          int n = fortuneCards.Count;
          int m = intelligenceCards.Count;
          int l = turnCards.Count;

          while (n > 1)
          {
            n--;
            int k = rng1.Next(n + 1);
            FortuneCard card = fortuneCards[k];
            fortuneCards[k] = fortuneCards[n];
            fortuneCards[n] = card;
          }

          while (m > 1)
          {
            m--;
            int k = rng2.Next(m + 1);
            IntelligenceCard card = intelligenceCards[k];
            intelligenceCards[k] = intelligenceCards[m];
            intelligenceCards[m] = card;
          }

          while (l > 1)
          {
            l--;
            int k = rng3.Next(l + 1);
            TurnCard card = turnCards[k];
            turnCards[k] = turnCards[l];
            turnCards[l] = card;
          }

          fortuneCardDeck.AddRange(fortuneCards);
          intelligenceCardDeck.AddRange(intelligenceCards);
          turnCardsDeck.AddRange(turnCards);
        }

        public void InitializePlayers(int numPlayers)
        {
            

            for (int i=1; i <= numPlayers; i++)
            {
                FortuneCard fortuneCard = fortuneCardDeck[0];
                fortuneCardDeck.Remove(fortuneCard);
                IntelligenceCard intelligenceCard = intelligenceCardDeck[0];
                intelligenceCardDeck.Remove(intelligenceCard);
                TurnCard turnCard = turnCardsDeck[0];
                turnCardsDeck.Remove(turnCard);
                players.Add(new Player(this, i, 5, 5, fortuneCard, intelligenceCard, turnCard));
            }
            foreach (Player player in players)
            {
              player.mTurnCard.AddTurnCardBenifitsToPlayer(player);
              player.playerForm.Show();
              player.updatePlayerUI();
            }
        }

        public void RemovePlayer(Player player)
        {
          player.active = false;
        }

        public Boolean RemovePlayersPeasant(int playerId) {
          foreach (Player player in players)
          {
            if (player.playerId == playerId)
            {
              player.RemovePeasants(1);
              player.updatePlayerUI();
              if (!player.ControlsPeasants()) RemovePlayer(player);
              return true;
            }
          }
          return false;
        }
    }
}
