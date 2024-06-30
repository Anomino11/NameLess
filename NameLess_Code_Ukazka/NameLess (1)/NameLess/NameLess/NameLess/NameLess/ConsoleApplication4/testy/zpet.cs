using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testy
{
    class zpet
    {
        public zpet(string jmeno, byte poprve, byte VelkyStrom, byte ProzkoumavaniVelkehoStromu, byte rozhlednuti, byte PoprveLouka, byte prozkoumaniSstr, byte lezeni, byte pochod, byte zapad, byte sever, byte vedomostiBrany, byte Prvni, byte Druha, byte Treti, byte Odchazi, byte zjisteni, byte pojistkaM, byte PouzeJednou, byte prozkoumavaniVesnicky)
        {
            Console.Clear();
            Console.WriteLine("zpět");
            Console.ReadKey();
            testující_třída testující_třída = new testující_třída(poprve, VelkyStrom);
        }
    }
}
