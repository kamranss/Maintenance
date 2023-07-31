using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions.EquipmentException
{
    public class EquipmentTypeException:Exception
    {
        public EquipmentTypeException() : base("The Provided Type is not Valid!")
        {
        }

        public EquipmentTypeException(string? message) : base(message)
        {
        }

        public EquipmentTypeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
