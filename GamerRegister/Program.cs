using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { GamerID = 1, GamerBirthday = 1999, GamerName = "Ali", GamerSurname = "Arkac", GamerTcNo = "2" });

            CompanyManager companyManager = new CompanyManager(new GamerValidationManager());
            companyManager.Add(new Company { CompanyId=1,CompanyName="Kampanya"});
        }
    }
}
