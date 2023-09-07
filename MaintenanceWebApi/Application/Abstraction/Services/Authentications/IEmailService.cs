using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Services.Authentications
{
    public interface IEmailService
    {
        void Send(string to, string subject, string body);
    }
}
