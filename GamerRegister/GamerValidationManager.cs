using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Company company)
        {
            if (company.CompanyId==1 && company.CompanyName=="Kampanya") 
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
