using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    class CompanyManager : ICompanyService
    {
        IGamerValidationService _gamerValidationService;
        public CompanyManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }
        public void Add(Company company)
        {
            if(_gamerValidationService.Validate(company)==true)
            {
                Console.WriteLine(company.CompanyId + "|" + company.CompanyName + " Eklendi");
            }
            else
            {
                Console.WriteLine("Kampanya Eklenemedi.");
            }

        }

        public void Delete(Company company)
        {
            if (_gamerValidationService.Validate(company) == true)
            {
                Console.WriteLine(company.CompanyId + "|" + company.CompanyName + " Silindi");
            }
            else
            {
                Console.WriteLine("Kampanya Silinemedi.");
            }
        }

        public void Update(Company company)
        {
            if (_gamerValidationService.Validate(company) == true)
            {
                Console.WriteLine(company.CompanyId + "|" + company.CompanyName + " Guncellendi");
            }
            else
            {
                Console.WriteLine("Kampanya Guncellenemedi.");
            }
        }
    }
}
