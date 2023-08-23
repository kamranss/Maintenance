using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrets
{
    public enum Roles
    {
        [Description("SUPER_ADMIN")]
        SUPER_ADMIN = 1,
        [Description("ADMIN")]
        ADMIN,
        [Description("MEMBER")]
        MEMBER,
        [Description("VIEWER")]
        VIEWER

    }
}
