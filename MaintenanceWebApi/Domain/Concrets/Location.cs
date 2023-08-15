using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Concrets
{
    //[JsonConverter(typeof(StringEnumConverter))]
    public enum Location
    {
        [Description("ALAT")]
        ALAT = 1,
        [Description("GARADAGH")]
        GARADAGH=2,
        [Description("BAKU")]
        BAKU=3,
        [Description("SANGACHAL")]
        SANGACHAL=4,
        [Description("DUBANDI")]
        DUBANDI=5,
        [Description("SUMGAYIT")]
        SUMGAYIT=6
    }
}
