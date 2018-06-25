using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public class Account
    {
        public Human Human { get; set; }
        public Addres Addres { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }

        public Account(Human human, Addres addres, string email, string passWord)
        {
            Human = human;
            Addres = addres;
            Email = email;
            PassWord = passWord;
        }
    }
}
