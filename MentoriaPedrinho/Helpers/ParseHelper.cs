using MentoriaPedrinho.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaPedrinho.Helpers
{
    public static class ParseHelper
    {
        public static double ToDouble(this string value)
        {
            double.TryParse(value, out double valor);

            return valor;
        }
    }
}
