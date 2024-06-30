using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{
    class ValecnikV1SEVER1
    {
        public ValecnikV1SEVER1(string jmeno, byte poprve, byte VelkyStrom, byte ProzkoumavaniVelkehoStromu, byte rozhlednuti, byte PoprveLouka, byte prozkoumaniSstr, byte lezeni, byte pochod, byte zapad, byte sever, byte vedomostiBrany, byte Prvni, byte Druha, byte Treti, byte Odchazi, byte zjisteni, byte pojistkaM, byte PouzeJednou, byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran, byte pozice, byte NovaKonverzace)
        {
            pozice = 2;
            Console.Clear();
            if (poprve == 0)
            {
                popis();
                poprve = 1;
                Akce(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                //zde bude cestování (uvnitř akce)

            }
            if (poprve == 1)
            {
                popis2();
                Akce(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
            }

        }
        static void popis()
        {
            Console.WriteLine("Nacházíš se v hlubokém lese");
            Thread.Sleep(2500);
            Console.WriteLine("Sledoval jsi stopy koní směřující do lesa, ale na určitém místě ty stopy ... ZMIZELY ??");
            Thread.Sleep(2500);
            Console.WriteLine("Ale stopy musí jít stranou, protože jsi si uvědomil, že se musíš odsud rychle dostat");
            Thread.Sleep(2500);
            Console.WriteLine("Cesta na sever vede hlouběji do lesa, kde není žádná lesní cesta a ani moc světla");
            Thread.Sleep(2500);
            Console.WriteLine("Jak na východě, tak i na západě můžeš v dáli vidět konec lesa (kdo ví, co je na konci)");
            Thread.Sleep(2500);
            Console.WriteLine("Samozřejmě vždycky se nabízi možnost se vrátit ...");
        }
        static byte inventarP(byte jablko, byte oko, byte EG, string trida)
        {
            //Vše !
            if (jablko == 1 && oko == 1 && EG == 1)
            {
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.WriteLine("|----------------------------------|------------------8--------------|----------------------------------------------|");
                Console.WriteLine("|-----------/*---------------------|-----------------8---8-----------|-----------UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU|");
                Console.WriteLine("|--------__||__--------------------|----------------8----88----------|8x8========}_______0___0___0___0_____0_______/|");
                Console.WriteLine("|----.'`  `-'  ``.-----------------|-----------8-8-8 8-8-8-----------|8x8========}________________________________/-|");
                Console.WriteLine("|---:        *    :----------------|---------8-----8 ´---------------|----------------------------------------------|");
                Console.WriteLine("|---:       *     :----------------|-------8------* 8----------------|----------------------------------------------|");
                Console.WriteLine("|----:     *     :-----------------|------8------///-----------------|----------------------------------------------|");
                Console.WriteLine("|     `.__.-.__.':-----------------|-----8-----//   //---------------|----------------------------------------------|");
                Console.WriteLine("|----  ----------------------------|----8----//   0  //--------------|----------------------------------------------|");
                Console.WriteLine("|------ ---------------------------|----*-----//    //---------------|----------------------------------------------|");
                Console.WriteLine("|------.-------- ------------------|-----------//:://----------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|--------------*------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|__________________________________|_________________________________|______________________________________________|");
            }





            //bez EG
            if (jablko == 1 && oko == 1 && EG == 0)
                Console.WriteLine("_____________________________________________________________________________________________________________________");
            Console.WriteLine("|----------------------------------|------------------8--------------|----------------------------------------------|");
            Console.WriteLine("|-----------/*---------------------|-----------------8---8-----------|----------------------------------------------|");
            Console.WriteLine("|--------__||__--------------------|----------------8----88----------|----------------------------------------------|");
            Console.WriteLine("|----.'`  `-'  ``.-----------------|-----------8-8-8 8-8-8-----------|----------------------------------------------|");
            Console.WriteLine("|---:        *    :----------------|---------8-----8 ´---------------|----------------------------------------------|");
            Console.WriteLine("|---:       *     :----------------|-------8------* 8----------------|----------------------------------------------|");
            Console.WriteLine("|----:     *     :-----------------|------8------///-----------------|----------------------------------------------|");
            Console.WriteLine("|     `.__.-.__.':-----------------|-----8-----//   //---------------|----------------------------------------------|");
            Console.WriteLine("|----  ----------------------------|----8----//   0  //--------------|----------------------------------------------|");
            Console.WriteLine("|------ ---------------------------|----*-----//    //---------------|----------------------------------------------|");
            Console.WriteLine("|------.-------- ------------------|-----------//:://----------------|----------------------------------------------|");
            Console.WriteLine("|----------------------------------|--------------*------------------|----------------------------------------------|");
            Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
            Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
            Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
            Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
            Console.WriteLine("|__________________________________|_________________________________|______________________________________________|");



            //BEZ OKA, S EG !!!
            if (jablko == 1 && oko == 0 && EG == 1)
            {
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|-----------/*---------------------|---------------------------------|-----------UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU|");
                Console.WriteLine("|--------__||__--------------------|---------------------------------|8x8========}_______0___0___0___0_____0_______/|");
                Console.WriteLine("|----.'`  `-'  ``.-----------------|---------------------------------|8x8========}________________________________/-|");
                Console.WriteLine("|---:        *    :----------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|---:       *     :----------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----:     *     :-----------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|     `.__.-.__.':-----------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----  ----------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|------ ---------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|------.-------- ------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|__________________________________|_________________________________|______________________________________________|");
            }
            //POUZE JABLKO
            if (jablko == 1 && oko == 0 && EG == 0)
            {
                Console.WriteLine("________________________________________________________________________________________________________");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|-----------/*---------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|--------__||__--------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----.'`  `-'  ``.-----------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|---:        *    :----------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|---:       *     :----------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----:     *     :-----------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|     `.__.-.__.':-----------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----  ----------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|------ ---------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|------.-------- ------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|__________________________________|_________________________________|_________________________________|");
            }

            //POUZE OKO
            if (jablko == 0 && oko == 1 && EG == 0)
            {
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.WriteLine("|----------------------------------|------------------8--------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|-----------------8---8-----------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|----------------8----88----------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|-----------8-8-8 8-8-8-----------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------8-----8 ´---------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|-------8------* 8----------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|------8------///-----------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|-----8-----//   //---------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|----8----//   0  //--------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|----*-----//    //---------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|-----------//:://----------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|--------------*------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|__________________________________|_________________________________|______________________________________________|");
            }
            //POUZE EG
            if (jablko == 0 && oko == 0 && EG == 1)
            {
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|-----------UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU|");
                Console.WriteLine("|----------------------------------|---------------------------------|8x8========}_______0___0___0___0_____0_______/|");
                Console.WriteLine("|----------------------------------|---------------------------------|8x8========}________________________________/-|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|------ ---------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|----------------------------------------------|");
                Console.WriteLine("|__________________________________|_________________________________|______________________________________________|");

            }




            //NIC


            if (jablko == 0 && oko == 0 && EG == 0)
            {
                Console.WriteLine("________________________________________________________________________________________________________");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
                Console.WriteLine("|__________________________________|_________________________________|_________________________________|");
            }
            Console.WriteLine("/zpet");



            int pojistka = 0;
            do
            {
                string inventar = Convert.ToString(Console.ReadLine());
                if ((inventar == "/eq TWG Longsword" || inventar == "/eq TWG") && EG == 1)
                {
                    EG = 2;
                    pojistka = 0;
                }
                if ((inventar == "/stats TWG Longsword" || inventar == "/stats TWG") && EG == 1)
                {
                    int zivotyMax = 99999;
                    int zivoty = 99999;
                    int manaMax = 99999;
                    int mana = 99999;
                    int vydrz = 99999;
                    int sila = 99999;
                    int obratnost = 99999;
                    int inteligence = 99999;

                    Console.WriteLine("                                                                               {0}: lvl {1}", trida);
                    Console.WriteLine("                                                                               Životy: {0} / {1} HP ", zivoty, zivotyMax);
                    Console.WriteLine("                                                                               Mana: {0} / {1} MP", mana, manaMax);
                    Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
                    Console.WriteLine("                                                                               Síla: {0} ", sila);
                    Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
                    Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);

                    pojistka = 0;
                }

                if (inventar == "/zpet")
                {
                    pojistka = 1;
                    Console.Clear();
                }


            } while (pojistka < 1);

            return EG;
        }
        static string statyW(byte EG, string zbran, string trida)
        {
            if (EG == 2)
            {
                zbran = "TWG";
            }
            if (zbran == "TWG")
            {
                int zivotyMax = 99999;
                int zivoty = 99999;
                int manaMax = 99999;
                int mana = 99999;
                int vydrz = 99999;
                int sila = 99999;
                int obratnost = 99999;
                int inteligence = 99999;

                Console.WriteLine("                                                                               {0}: lvl {1}", trida);
                Console.WriteLine("                                                                               Životy: {0}/{1} HP", zivoty, zivotyMax);
                Console.WriteLine("                                                                               Mana: {0}/{1} MP", mana, manaMax);
                Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
                Console.WriteLine("                                                                               Síla: {0} ", sila);
                Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
                Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);

            }
            if (zbran == "sekera battlefury" || zbran == "battlefury")
            {
                int zivotyMax = 250;
                int zivoty = 250;
                int manaMax = 10;
                int mana = 10;
                int vydrz = 30;
                int sila = 32 + 10;
                int obratnost = 7 - 2;
                int inteligence = 22 - 7;

                Console.WriteLine("                                                                               Válečník: lvl {0}");
                Console.WriteLine("                                                                               Životy: {0}/{1} HP", zivoty, zivotyMax);
                Console.WriteLine("                                                                               Mana: {0}/{1} MP", mana, manaMax);
                Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
                Console.WriteLine("                                                                               Síla: {0} ", sila);
                Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
                Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);
            }
            if (zbran == "hul novice")
            {
                int zivotyMax = 170;
                int zivoty = 170;
                int manaMax = 50 + 15;
                int mana = 50 + 15;
                int vydrz = 15 - 3;
                int sila = 3;
                int obratnost = 1;
                int inteligence = 49 + 8;

                Console.WriteLine("                                                                               Mág: lvl {0}");
                Console.WriteLine("                                                                               Životy: {0} / {1} HP ", zivoty, zivotyMax);
                Console.WriteLine("                                                                               Mana: {0} / {1} MP", mana, manaMax);
                Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
                Console.WriteLine("                                                                               Síla: {0} ", sila);
                Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
                Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);
            }
            if (zbran == "kuchynske vrhaci noze" || zbran == "vrhaci noze")
            {
                int zivotyMax = 170;
                int zivoty = 170;
                int manaMax = 50 - 5;
                int mana = 50 - 5;
                int vydrz = 15 + 5;
                int sila = 3;
                int obratnost = 1 + 7;
                int inteligence = 49;

                Console.WriteLine("                                                                               Mág: lvl {0}");
                Console.WriteLine("                                                                               Životy: {0} / {1} HP ", zivoty, zivotyMax);
                Console.WriteLine("                                                                               Mana: {0} / {1} MP", mana, manaMax);
                Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
                Console.WriteLine("                                                                               Síla: {0} ", sila);
                Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
                Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);
            }
            if (zbran == "supacky luk a sipy" || zbran == "luk a sipy")
            {
                int zivotyMax = 200;
                int zivoty = 200;
                int manaMax = 10;
                int mana = 10;
                int vydrz = 50 + 14;
                int sila = 10;
                int obratnost = 35 + 5;
                int inteligence = 32 - 5;

                Console.WriteLine("                                                                               Lovec: lvl {0}");
                Console.WriteLine("                                                                               Životy: {0} / {1} HP ", zivoty, zivotyMax);
                Console.WriteLine("                                                                               Mana: {0} / {1} MP", mana, manaMax);
                Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
                Console.WriteLine("                                                                               Síla: {0} ", sila);
                Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
                Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);

            }
            if (zbran == "lovcovy kratke mece" || zbran == "kratke mece")
            {
                int zivotyMax = 200 - 40;
                int zivoty = 200 - 40;
                int manaMax = 10;
                int mana = 10;
                int vydrz = 50 + 5;
                int sila = 10;
                int obratnost = 35 + 25;
                int inteligence = 32;

                Console.WriteLine("                                                                               Lovec: lvl {0}");
                Console.WriteLine("                                                                               Životy: {0} / {1} HP ", zivoty, zivotyMax);
                Console.WriteLine("                                                                               Mana: {0} / {1} MP", mana, manaMax);
                Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
                Console.WriteLine("                                                                               Síla: {0} ", sila);
                Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
                Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);

            }
            if (zbran == "mec broadsword" || zbran == "broadsword")
            {
                int zivotyMax = 250;
                int zivoty = 250;
                int manaMax = 10;
                int mana = 10;
                int vydrz = 37;
                int sila = 17;
                int obratnost = 22;
                int inteligence = 22;


                Console.WriteLine("                                                                               Válečník: lvl {0}");
                Console.WriteLine("                                                                               Životy: {0} / {1} HP ", zivoty, zivotyMax);
                Console.WriteLine("                                                                               Mana: {0} / {1} MP", mana, manaMax);
                Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
                Console.WriteLine("                                                                               Síla: {0} ", sila);
                Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
                Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);
            }
            Console.WriteLine();
            Console.WriteLine("/zpet");
            int pojistka = 0;
            do
            {
                string staty = Convert.ToString(Console.ReadLine());
                if (staty == "/zpet")
                {
                    pojistka = 1;
                    Console.Clear();
                }


            } while (pojistka < 1);
            return zbran;
        }
        static void Akce(string jmeno, byte poprve, byte VelkyStrom, byte ProzkoumavaniVelkehoStromu, byte rozhlednuti, byte PoprveLouka, byte prozkoumaniSstr, byte lezeni, byte pochod, byte zapad, byte sever, byte vedomostiBrany, byte Prvni, byte Druha, byte Treti, byte Odchazi, byte zjisteni, byte pojistkaM, byte PouzeJednou, byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran, byte pozice, byte NovaKonverzace)
        {
            bool test1 = false;
            int pojistka = 0;
            do
            {
                string akce1 = Convert.ToString(Console.ReadLine());


                if (akce1 == "jdi na sever")
                {
                    //hluboký les
                    ValecnikV1SEVER2 zakladKapitola4 = new ValecnikV1SEVER2(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    test1 = true;
                }
                if (akce1 == "jdi na vychod" || akce1 == "jdi na východ")
                {
                    //Konec lesa --> na louku
                    test1 = true;
                }
                if (akce1 == "jdi na zapad" || akce1 == "jdi na západ")
                {
                    Console.WriteLine("Vyběhl jsi z lesa směrem na západ");
                    Thread.Sleep(1500);
                    Console.WriteLine("Za hustým kapradím nevidíš nic ... jen moře které vypadalo, že nikde nekončí");
                    //zkusit vymyslet odpočet ;)
                    test1 = true;
                }
                if (akce1 == "jdi na jih")
                {
                    ValecnikV1 zakladKapitola2 = new ValecnikV1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    test1 = true;
                }








                if (akce1 == "vezmy do ruky sekeru" || akce1 == "tas zbran" || akce1 == "vezmy do ruky zbran")
                {
                    pojistka++;
                    Console.WriteLine("Vzal jsi do ruky svojí sekeru battlefury ...");
                    akce1 = Convert.ToString(Console.ReadLine());
                }
                if (akce1 == "zabij se" || akce1 == "usekni si hlavu" && pojistka == 1)
                {
                    Console.WriteLine("Tak to jsi zabil ... Doslova jsi se zabil a končí tvá výprava ...");
                    Thread.Sleep(4000);
                    break;
                }
                if (akce1 == "schovej zbran" && pojistka == 1)
                {
                    Console.WriteLine("Schoval jsi svojí zbraň ...");
                    pojistka = 0;
                }
                if (akce1 == "/stats")
                {
                    Console.Clear();
                    zbran = statyW(EG, zbran, trida);
                    Console.Clear();
                    popis();
                    test1 = false;
                }
                if (akce1 == "/inv")
                {
                    Console.Clear();
                    EG = inventarP(jablko, oko, EG, trida);
                    Console.Clear();
                    popis();
                    test1 = false;
                }
                if (akce1 == "/save")
                {

                    //ulozit
                    TextWriter tw = new StreamWriter("Savo.txt");
                    tw.WriteLine(jmeno); //string
                    tw.WriteLine(poprve);
                    tw.WriteLine(VelkyStrom);
                    tw.WriteLine(ProzkoumavaniVelkehoStromu);
                    tw.WriteLine(rozhlednuti);
                    tw.WriteLine(PoprveLouka);
                    tw.WriteLine(prozkoumaniSstr);
                    tw.WriteLine(lezeni);
                    tw.WriteLine(pochod);
                    tw.WriteLine(zapad);
                    tw.WriteLine(sever);
                    tw.WriteLine(vedomostiBrany);
                    tw.WriteLine(Prvni);
                    tw.WriteLine(Druha);
                    tw.WriteLine(Treti);
                    tw.WriteLine(Odchazi);
                    tw.WriteLine(zjisteni);
                    tw.WriteLine(pojistkaM);
                    tw.WriteLine(PouzeJednou);
                    tw.WriteLine(prozkoumavaniVesnicky);
                    tw.WriteLine(otevreni);
                    tw.WriteLine(jablko);
                    tw.WriteLine(oko);
                    tw.WriteLine(EG);
                    tw.WriteLine(trida); //string
                    tw.WriteLine(zbran); //string
                    tw.WriteLine(NovaKonverzace);
                    tw.Close();

                    //     , byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran)
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tvá hra je uložena ...");
                    Console.ForegroundColor = ConsoleColor.White;
                    test1 = false;
                }
            } while (test1 == false);
        }
        static void popis2()
        {
            Console.WriteLine("Nacházíš se v hlubokém lese");
            Thread.Sleep(2500);
            Console.WriteLine("Cesta na sever vede hlouběji do lesa, kde není lesní cesta a ani moc světla");
            Console.WriteLine("Jak na východě, tak i na západě můžeš v dáli vidět konec lesa (kdo ví, co je na konci)...");
            
        }
    }
}
