﻿using Application.Abstraction.Services.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services.Account
{
    public class FileService : IFileService
    {
        public string ReadFile(string path, string body)
        {
            using (StreamReader reader = new StreamReader(path)) 
            {
                body = reader.ReadToEnd();

            }
            return body;
        }
    }
}
