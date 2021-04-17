using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
           if(gamer.GamerID==1 && gamer.GamerTcNo=="2" && gamer.GamerName=="Ali" &&  gamer.GamerSurname=="Arkac" && gamer.GamerBirthday==1999)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}
