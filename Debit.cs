using System;

namespace PassTask13
{

    public class Debit: Card
    {
        private float _moneyAmount;

        public Debit(string cardName, CardType cardType, int cardNumber, float moneyAmount) : base(cardName, cardType, cardNumber)
        {
            _moneyAmount = moneyAmount;
        }

        public float MoneyAmount
        {
            get { return _moneyAmount; }
            set { _moneyAmount = value; }
        }

        public override string PrintDetials()
        {
            return "Caed Name: " + CardName
             + "\nCard Number: " + CardNumber
             + "\nCard Type: " + CardType
             + "\nAccount Balance: " + MoneyAmount + "\n";
        }
    }
}