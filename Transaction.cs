using System;

namespace PassTask13
{

    public class Transaction
    {

        private TransferType _transfer;

        private int _amount;

        private string _from;

        private string _to;

        private Card _usedCard;


        public Transaction(TransferType transfer, int amount, string from, string to, Card usedCard)
        {
            _transfer = transfer;
            _amount = amount;
            _from = from;
            _to = to;
            _usedCard = usedCard;
        }



        public TransferType TransferType
        {
            get { return _transfer; }
            set { _transfer = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public string From
        {
            get { return _from; }
            set { _from = value; }
        }

        public string To
        {
            get { return _to; }
            set { _to = value; }
        }

        public string Suggestion()
        {
            return "We reccommend you using this card: ";
        }

        public void Implement(Card card)
        {

        }





    }
}