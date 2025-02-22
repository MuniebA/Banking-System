using System;
using System.Collections.Generic;

namespace PassTask13
{

    public class User
    {

        private string _username;

        private string _password;

        private string _fname;

        private string _lname;

        private readonly List<BankAccount> _bankAcc;

        public User(string username, string password, string fname, string lname)
        {
            _username = "temp";
            _password = "password";
            _fname = fname;
            _lname = lname;
            _bankAcc = new List<BankAccount>();
        }

        public void AddAccount(BankAccount b)
        {
            _bankAcc.Add(b);
        }

        public void RemoveAccount(BankAccount b)
        {
            _bankAcc.Remove(b);
        }

        public List<BankAccount> BankAccounts
        {
            get { return _bankAcc; }
        }

        public BankAccount this[int i]
        {
            get { return _bankAcc[i]; }
        }

        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }

        public string Lname
        {
            get { return _lname; }
            set { _lname = value; }
        }


        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public string PrintDetails()
        {
            return $"Username: {_username}\nPassword: {_password}\nFirst name: {_fname}\nLast name: {_lname}\nNumber of accounts: {_bankAcc.Count}";
        }

    }

}