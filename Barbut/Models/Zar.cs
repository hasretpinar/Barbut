using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbut.Models
{
    class Zar

    {
        public byte Sayi { get; set; } // özellik

        Random _random = new Random(); // alan

        public void At() // davranış - zarın atılma davranışı 
        {
           Sayi = (byte) _random.Next(1, 7); // 1'le 6 arasında rastgele sayı üretiyor byte e cast ettik

        }
        

    }
}
