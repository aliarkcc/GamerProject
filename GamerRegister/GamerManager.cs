using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject

{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.GamerID + "|" + gamer.GamerName + "|" + gamer.GamerSurname + "|" + gamer.GamerBirthday + "|" + gamer.GamerTcNo + " Eklendi.");
            }
            else
            {
                Console.WriteLine("Kayıt Eklenemedi.");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.GamerID + "|" + gamer.GamerName + "|" + gamer.GamerSurname + "|" + gamer.GamerBirthday + "|" + gamer.GamerTcNo + " Silindi.");
            }
            else
            {
                Console.WriteLine("Kayıt Silinemedi.");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.GamerID + "|" + gamer.GamerName + "|" + gamer.GamerSurname + "|" + gamer.GamerBirthday + "|" + gamer.GamerTcNo + " Güncellendi.");
            }
            else
            {
                Console.WriteLine("Kayıt Güncellenemedi.");
            }
        }
    }
}
