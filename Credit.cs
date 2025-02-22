using System;

namespace PassTask13
{

    public class Credit : Card
    {

        private float _monthlyPayment;

        private int _cardLimit;

        private double _amountUsed;

        public Credit(string cardName, CardType cardType, int cardNumber, float monthlyPayment, int cardLimit, double amountUsed) : base(cardName, cardType, cardNumber)
        {
            _cardLimit = cardLimit;
            _monthlyPayment = monthlyPayment;
            _amountUsed = amountUsed;
        }

        public float MonthlyPayment
        {
            get { return _monthlyPayment; }
            set { _monthlyPayment = value; }
        }

        public int CardLimit
        {
            get { return _cardLimit; }
            set { _cardLimit = value; }
        }

        public double AmountUsed
        {
            get { return _amountUsed; }
            set { _amountUsed = value; }
        }

        public override string PrintDetials()
        {
            return "Card Name: " + CardName
             + "\nCard Number: " + CardNumber
             + "\nCard Type: " + CardType
             + "\nMonthly Payment: " + MonthlyPayment
             + "\nCard Limit: " + CardLimit + "\n";
        }
    }
}