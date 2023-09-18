using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.User.UserToken;

namespace Application.Abstraction.IToken
{
    public interface ITokenHandler
    {
        Token CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}
