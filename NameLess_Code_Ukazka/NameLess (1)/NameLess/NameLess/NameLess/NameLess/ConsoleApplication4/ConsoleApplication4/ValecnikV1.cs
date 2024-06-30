using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{

    class ValecnikV1
    {

        string trida = "valecnik";
        public ValecnikV1(string jmeno, byte poprve, byte VelkyStrom, byte ProzkoumavaniVelkehoStromu, byte rozhlednuti, byte PoprveLouka, byte prozkoumaniSstr, byte lezeni, byte pochod, byte zapad, byte sever, byte vedomostiBrany, byte Prvni, byte Druha, byte Treti, byte Odchazi, byte zjisteni, byte pojistkaM, byte PouzeJednou, byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran, byte pozice, byte NovaKonverzace)
        {
            pozice = 1;
            bool test1;
            bool test2 = false;
            Console.WriteLine("Ráno tě probudily rány vydavající ze štítu po tom, co do něj narážel vojínův meč...");
            Thread.Sleep(500);
            Console.WriteLine("Vojín: Vstávej ty šupáku, musíme vyrazit !");
            Thread.Sleep(200);
            Console.WriteLine("Pokoj od minulého večera zůstal nedotknut, jediné co se změnilo bylo to, že na tvé posteli leželo středně težké brnění ...");
            do
            {
                string vybavit = Convert.ToString(Console.ReadLine());
                switch (vybavit)
                {

                    case "vezmy si zbroj":
                        test1 = true;
                        break;
                    case "vybav se":
                        test1 = true;
                        break;
                    case "oblec se":
                        test1 = true;
                        break;
                    default:
                        test1 = false;
                        Console.WriteLine("Prvně se musím obléct !");
                        break;
                }

            } while (test1 == false);
            Console.Clear();
            prolog();
            int pokus = 0;
            do
            {
                string akce1 = Convert.ToString(Console.ReadLine());
                if (akce1 == "sundej si satek" || akce1 == "Sundej si satek" || akce1 == "sundej si šátek" || akce1 == "Sundej si šátek" || akce1 == "sundej si satek z oci" || akce1 == "Sundej si satek z oci" || akce1 == "sundej si šátek z očí" || akce1 == "Sundej si šátek z očí")
                {
                    pokus++;
                }
                else
                {
                    Console.WriteLine("Nic nevidím, měl bych si prvně sundat šátek !");
                    pokus = 0;
                }
            } while (pokus <= 0);
            popis();
            int pojistka = 0;
            do
            {
                string akce2 = Convert.ToString(Console.ReadLine());

                if (akce2 == "vezmi do ruky sekeru" || akce2 == "tas zbran" || akce2 == "vezmi do ruky zbran")
                {
                    pojistka++;
                    Console.WriteLine("Vzal jsi do ruky svojí sekeru battlefury ...");
                    akce2 = Convert.ToString(Console.ReadLine());
                }
                if (akce2 == "zabij se" || akce2 == "usekni si hlavu" && pojistka == 1)
                    {
                        Console.WriteLine("Tak to jsi zabil ... Doslova jsi se zabil a končí tvá výprava ...");
                        Thread.Sleep(4000);
                        break;
                    }
                if (akce2 == "schovej zbran" && pojistka == 1)
                {
                    Console.WriteLine("Schoval jsi svojí zbraň ...");
                    pojistka = 0;
                }
                if (akce2 == "jdi na sever")
                {
                    test2 = true;
                    ValecnikV1SEVER1 zakladKapitola3 = new ValecnikV1SEVER1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    break;
                }
                if (akce2 == "jdi na jih")
                {
                    //smrt
                    Console.WriteLine("Rozhodl jsi se jít na jih, kde se nachází svah útesu");
                    Thread.Sleep(2000);
                    Console.WriteLine("Po chvíli přemýšlení a prázdného dívání se na vlny narážející na svah uděláš ten důležitý krok");
                    Thread.Sleep(2000);
                    Console.WriteLine("Padáš ze svahu a postupně se ve vzduchu otáčíš, až najednou spadneš břichem na špičatou malou skálu pod útesem.");
                    Thread.Sleep(2000);
                    Console.WriteLine("A tím končí tvůj život a i epická výprava ...");
                    test2 = true;
                }
                if (akce2 == "jdi na zapad")
                {
                    Console.WriteLine("Rozhodl jsi se jít na západ");
                    Thread.Sleep(2500);
                    Console.WriteLine("I přes všechna varování vypravěče jsi se rozhodl jít na západ kde je pouze obrovský sešup přímo do moře a skály vyčnívající z něj");
                    Thread.Sleep(2500);
                    Console.WriteLine("Kažodpádně jsi si řek 'YOLO' a skočil z útesu a tím ukončil svůj život");

                    test2 = true;
                }
                if (akce2 == "jdi na vychod")
                {
                    test2 = true;

                    break;
                }
                if (akce2 == "/stats")
                {
                    Console.Clear();
                    zbran = statyW(EG, zbran, trida);
                    Console.Clear();
                    popis();
                    test2 = false;
                }
                if (akce2 == "/inv")
                {
                    Console.Clear();
                    EG = inventarP(jablko, oko, EG, trida);
                    Console.Clear();
                    popis();
                    test2 = false;

                }
                if (akce2 == "/save")
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
                    test2 = false;
                    //     , byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran)
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tvá hra je uložena ...");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                if (!(akce2 == "/save" ||akce2 == "usekni si hlavu" || akce2 == "zabij se" || akce2 == "schovej zbran" || akce2 == "vezmy do ruky sekeru" || akce2 == "tas zbran" || akce2 == "jdi na sever" || akce2 == "jdi na jih" || akce2 == "jdi na zapad" || akce2 == "jdi na vychod" || akce2 == "/stats" || akce2 == "/inv"))
                {
                    Console.WriteLine("Neplatný příkaz");
                    test2 = false;
                }
            } while (test2 == false);
        }
            static void prolog()
            {
                Console.WriteLine("Vojín tě chytil, závázal oči a táhl tě pryč z pokoje");
                Thread.Sleep(4000);
                Console.WriteLine("Sice jsi nic neviděl, ale zbytek smyslů ti fungovaly tak, jak měly");
                Thread.Sleep(4000);
                Console.WriteLine("Cítil jsi schody pod nohama, slyšel jsi jak si o tobě šuškají zdejší poddaní na hradě");
                Thread.Sleep(4000);
                Console.WriteLine("Stejně tak jsi najednou ucítil, že už nejsi uvnitř, trochu chladného ale stále útulného hradu, ale že jsi venku");
                Thread.Sleep(4000);
                Console.WriteLine("Slyšíš, jak si ptáčci pozpěvují po ránu");
                Thread.Sleep(4000);
                Console.WriteLine("Ale také slyšíš koně ... Určitě ne jednoho");
                Thread.Sleep(4000);
                Console.WriteLine("Najednou cítíš, jak tě něco nadzvedává a surově tě TO něco, nebo spíše někdo, hodil na koně, div ti dech nevyrazil ...");
                Thread.Sleep(6000);
                Console.Clear();
                Console.WriteLine("Cesta byla strašná a snad i nekonečná");
                Thread.Sleep(2500);
                Console.WriteLine("Po však té nekonečně dlouhé době došlo na to, na co jsi celý svůj život čekal ... ZAČALO TO !");
                Thread.Sleep(2500);
                Console.WriteLine("Hodili tě z koně a se smíchem odjeli ...");
                Thread.Sleep(2500);
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
        static void popis()
            {
                Console.WriteLine("Přímo za zády máš kraj útesu");
                Thread.Sleep(2000);
                Console.WriteLine("Před tebou, směrem na sever, jsou vidět čerstvé stopy od koní směřujích do lesa");
                Thread.Sleep(2500);
                Console.WriteLine("Oproti tomu, lze jít na východ, kde z dálky vidíš louku ...");
            }
        }
    }


