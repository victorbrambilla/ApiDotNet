using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiDotNet.Domain.Authentication;
using Isopoh.Cryptography.Argon2;


namespace ApiDotNet.Infra.Data.Authentication
{
    public class Hashing : IHashing
    {
        public string UseArgon2(string value)
        {
            return Argon2.Hash(value);
        }
        public bool VerifyArgon2(string original, string value)
        {
            return Argon2.Verify(original, value);
        }
    }
}
