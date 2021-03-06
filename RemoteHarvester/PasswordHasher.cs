﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RemoteHarvester
{
    public class PasswordHasher
    {
        public static byte[] CalculateHash(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            var hashstring = HashAlgorithm.Create();
            return hashstring.ComputeHash(passwordBytes);
        }
    }
}
