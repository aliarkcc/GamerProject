using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    interface ICompanyService
    {
        void Add(Company company);
        void Delete(Company company);
        void Update(Company company);
    }
}
