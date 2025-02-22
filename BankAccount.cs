using System;
using System.Collections.Generic;

namespace PassTask13
{

    public class BankAccount
    {
        private int _bankNo;

        private string _bankName;


        public BankAccount(int bankNo, string bankName)
        {
            _bankNo = bankNo;
            _bankName = bankName;
        }

        public int BankNo
        {
            get { return _bankNo; }
            set { _bankNo = value; }

        }
        public string BankNama
        {
            get { return _bankName; }
            set { _bankName = value; }

        }

        public string CardInfo(Card card)
        {
            return "Card Name: " + card.CardName
            + "\nCard Type: " + card.CardType
            + "\nCard Number: " + card.CardNumber + "\n";
        }

        public string BankInfo()
        {
            return "Bank Number: " + BankNo + "\nBank Name: " + BankNama + "\n";
        }


    }

}