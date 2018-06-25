using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Ali","Yazar",33);
            Addres addres = new Addres("Keykubat","Ankara",06145);
            Account account = new Account(human,addres,"example@example.com","pass");

            Console.WriteLine(human.Name);
            Console.WriteLine(addres.Country);
            Console.WriteLine(account.Email);
            Console.WriteLine(account.Human.Surname);
            Console.ReadKey();
             // Sonradan emplooye ozelligide ekle
        }
    }
}
