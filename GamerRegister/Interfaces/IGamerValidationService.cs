using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject
{
    interface IGamerValidationService
    {
        bool Validate(Company company);
    }
}
