using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;
        public Card(int suit_input, int val_input){
                //stringVal
            if(val_input==1){
                stringVal = "Ace";
            }
            else if(val_input==11){
                stringVal = "Jack";
            }
            else if(val_input==12){
                stringVal = "Queen";
            }
            else if(val_input==13){
                stringVal = "King";
            }
            else{
                stringVal = val_input.ToString();
            }
                //suit
            if(suit_input==1){
                suit = "Clubs";
            }
            else if(suit_input==2){
                suit = "Spades";
            }
            else if(suit_input==3){
                suit = "Hearts";
            }
            else if(suit_input==4){
                suit = "Diamonds";
            }
                //val
            val = val_input;
        }
    }

    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public Deck(){
            for(int iSuit=1; iSuit<=4; iSuit++){ //for four suits
                for(int iCardNum=1; iCardNum<=13; iCardNum++){ //for 13 card numbers
                    cards.Add(new Card(iSuit,iCardNum));
                }
            }
            Shuffle();
        }
        public Card Deal(){
            Card dealt_card = cards[0];
            cards.RemoveAt(0);
            return dealt_card;
        }
        public void Shuffle(){
            Random rand = new Random();
            for(int idx=0; idx<cards.Count-1; idx++){
                int randIdx = rand.Next(idx+1, cards.Count);
                Card temp = cards[idx];
                cards[idx] = cards[randIdx];
                cards[randIdx] = temp;
            }
        }
        public void Reset(){
            cards.Clear();
            for(int iSuit=1; iSuit<=4; iSuit++){ //for four suits
                for(int iCardNum=1; iCardNum<=13; iCardNum++){ //for 13 card numbers
                    cards.Add(new Card(iSuit,iCardNum));
                }
            }
            Shuffle();
        }
    }

    public class Player
    {
        public string name;
        public List<Card> hand;
        public Player(string name_input){
            name = name_input;
            hand = new List<Card>();
        }
        public Card Draw(Deck deck_input){
            Card drawn_card = deck_input.cards[0];
            hand.Add(drawn_card);
            return drawn_card;
        }
        public Card Discard(int hand_idx){
            Card discarded_card = hand[hand_idx];
            hand.RemoveAt(hand_idx);
            return discarded_card;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player zach = new Player("Zach");
            zach.Draw(new Deck());
            Console.WriteLine("I drew a {0} of {1}",zach.hand[0].stringVal,zach.hand[0].suit);
        }
    }
}
