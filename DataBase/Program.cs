using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen.Concrete;
using Domen.Entities;


namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
           var efrep = new EfUserRepository();

        //    var id = efrep.AddUser(new User
        //    {
        //        Login = "xattab",
        //        FirstName = "uri",
        //        LastName = "-",
        //        MailAdress = "-",
        //        Password = "111234"
        //    });

        //    Console.WriteLine(id);

            foreach (var item in efrep.Users)
            {
                Console.WriteLine(item.Login);
            }

            Console.ReadLine();
        }
    }
}
