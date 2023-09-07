using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services.Account
{
    public class OTPService
    {
        public static string GenerateOTP()
        {
            Random random = new Random();
            int otpnumber = random.Next(100000, 999999); // we will give squence and it will provide random number -- length will be 6
            return otpnumber.ToString();
        }
    }
}
