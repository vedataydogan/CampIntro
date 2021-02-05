using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "Engin", BirthYear = 1984, IdentityNumber = 12345, LastName = "Demiroğ" });
            
        }
    }
}
