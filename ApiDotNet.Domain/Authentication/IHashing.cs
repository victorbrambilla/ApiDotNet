using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Domain.Authentication
{
    public interface IHashing
    {
        string UseArgon2(string value);
        bool VerifyArgon2(string original, string value);
    }
}
