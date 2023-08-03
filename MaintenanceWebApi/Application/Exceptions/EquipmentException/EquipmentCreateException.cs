using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions.EquipmentException
{
    public class EquipmentCreateException:Exception
    {
        public EquipmentCreateException() : base("The Provided Info is not Valid!")
        {
        }

        public EquipmentCreateException(string? message) : base(message)
        {
        }

        public EquipmentCreateException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
