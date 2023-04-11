using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5.Model
{
    internal class priceModel : IToFindModel
    {
        public int cost { get; set; }
        public DateTime date { get; set; }
        public string details { get; set; }

    }
}
