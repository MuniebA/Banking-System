using System;

namespace PassTask13
{

    public abstract class Card
    {

        private string _cardName;

        private CardType _cardType;

        private int _cardNumber;

        public Card(string cardName, CardType cardType, int cardNumber)
        {
            _cardName = cardName;
            _cardNumber = cardNumber;
            _cardType = cardType;
        }

        public string CardName
        {
            get { return _cardName; }
            set { _cardName = value; }
        }

        public int CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        public CardType CardType
        {
            get { return _cardType; }
            set { _cardType = value; }
        }

        public abstract string PrintDetials();
    }
}