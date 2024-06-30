using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApplication4
{
    class END
    {
        public END(string jmeno, byte poprve, byte VelkyStrom, byte ProzkoumavaniVelkehoStromu, byte rozhlednuti, byte PoprveLouka, byte prozkoumaniSstr, byte lezeni, byte pochod, byte zapad, byte sever, byte vedomostiBrany, byte Prvni, byte Druha, byte Treti, byte Odchazi, byte zjisteni, byte pojistkaM, byte PouzeJednou, byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran, byte pozice, byte NovaKonverzace)
        {
            pozice = 6;
            //POKUD příjde -> bonusova konverzace = 1;
            NovaKonverzace = 1;
            string Akce;
            byte neco = 0;
            bool test = false;
            // vedomostiBrany = 1; VLOŽIT !!!!!!
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                if (oko == 1 && jablko == 1)
                {
                    popis2();
                    do
                    {
                        Akce = Convert.ToString(Console.ReadLine());
                        if (Akce == "otevri branu")
                        {
                            //END s drakem + alternativa
                            popis3();
                            FightDRAK(zbran);
                            test = true;
                        }
                        if (Akce == "/save")
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
                            tw.Close();

                            //     , byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran)
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Tvá hra je uložena ...");
                            test = false;
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                    } while (!(test == true));
                }
                if (oko == 0 && jablko == 1 || oko == 1 && jablko == 0 ||oko == 0 && jablko == 0)
                {
                    popis();

                    Akce = Convert.ToString(Console.ReadLine());









                    if (Akce == "zkusit otevrit branu" || Akce == "otevri branu" || Akce == "prolom barieru")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bránu nezle otevřít");
                        Console.ForegroundColor = ConsoleColor.White;
                        test = false;
                    }


                    //chůze
                    if (Akce == "jdi na jih")
                    {
                        //LOUKA !!!
                        ValecnikV1SEVER3_VYCHOD vj = new ValecnikV1SEVER3_VYCHOD(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    }
                    if (Akce == "jdi na sever" && otevreni == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Na sever jít nelze, v cestě stojí zeď ...");
                        Console.ForegroundColor = ConsoleColor.White;
                        test = false;
                    }
                    if (Akce == "jdi na vychod" || Akce == "jdi na zapad")
                    {
                        Console.WriteLine("Rozhodl jsi se to nakonec všechno skončit a skočil přímo do světla vyřazující lávy, kde se tvé tělo velice rychle rozpustilo ...");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("TVÁ VYPRAVÁ KONČÍ, ZMÁČKNI LIBOVOLNÉ TLAČÍTKO");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        Console.Clear();
                    }

                    //formality
                    if (Akce == "/stat")
                    {
                        zbran = statyW(EG, zbran, trida);
                        test = false;
                    }
                    if (Akce == "/inv")
                    {
                        EG = inventarP(jablko, oko, EG, trida);
                        test = false;
                    }
                    if (Akce == "/save")
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
                        tw.Close();

                        //     , byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran)
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Tvá hra je uložena ...");
                        test = false;
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                }
            } while (!(test == true));

        }
        static void popis()
        {
            //pokud poprvé
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Přicházíš k obrovské železné bráně, stojící na kameném povrchu");
            Thread.Sleep(2500);
            Console.WriteLine("Čím blíže přistupuješ, tím více si uvědomuješ, jak jsi oproti ní titěrný");
            Thread.Sleep(2500);
            Console.WriteLine("Najednou si všimneš, přímo před tebou zhruba v úrovni tvých očí, dvě vyryté siluety uvnitř brány");
            Thread.Sleep(2500);
            Console.WriteLine("První z nich, na pravé straně od druhé, je vytvarovaná do nějaké zvláštní elipsy, jen s tím, že v dolní části je i na levo, i na pravo trochu vypuklá část");
            Thread.Sleep(4500);
            Console.Write("Ta druhá je mnohem menší oproti té první a připomíná spíše jakýsi");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" kosočtverec");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2500);
            Console.WriteLine("Zbytek zdi je kompletně hladký ... možná až příliš");
            Thread.Sleep(2500);
            Console.WriteLine("Kvůli až neobyčejně upraveném a dokonalém povrchu to spíše vypadá, jako by se něco snažilo skrýt ... I ta záhadná energie vyřazující ze zdi ... magie");
            Thread.Sleep(2500);
            Console.WriteLine("I se sebelepší magii by žádný člověk nedokázal takhle dokonalou zeď udělat ... člověk určitě ne");
            Thread.Sleep(2500);
            Console.WriteLine("Vlastně existuje pouze jediné stvoření z legend, které by něčeho takjového bylo schopno ... ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("drak");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("!");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Chcete vypsat bonusové informace ohledně kouzelníků ?");
            Console.ForegroundColor = ConsoleColor.White;
            string vyber = Convert.ToString(Console.ReadLine());
            if (vyber == "ano" || vyber == "jo" || vyber == "jasně")
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("________________________________________________________________________________________");
                Console.Write("V teoretické části učiva se schopnosti kouzelníku porovnávají vyvoláním takzvaných ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("bariér ");
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(4500);
                Console.WriteLine("Celá bariéra připomíná zeď, ale už od pohledu i bez znalosti kuzel lze usoudit o schopnostech toho, kdo vyčaroval bariéru ...");
                Thread.Sleep(2500);
                Console.WriteLine("________________________________________________________________________________________");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Dobrá tedy");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.Write("Zbytek krajiny není nijak zvláštní, je to holá pustina skal a ... ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("lebek");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2500);
            Console.Write("Na ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("východě");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" i na ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("západě ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("vidíš puze světlo vyřazující lavý obtékající kolem celého zbytku skal ...");
            //pokud podruhé
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
            if(zbran == "TWG")
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
            if(zbran == "sekera battlefury" || zbran == "battlefury")
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
        static void popis2()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vracíš se na velmi povědomé místo, ale tentokrát je něco jiné");
            Thread.Sleep(2500);
            Console.WriteLine("Celá atmosféra je nyní jaksi jiná ...");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void popis3()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Po otevření  brány na tebe přímo vydychuje jakási temná atmosféra, společně s temnou mlhou vycházející přímo z brány");
            Thread.Sleep(3500);
            Console.WriteLine(""); //potom doělat :)
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void FightDRAK(string zbran)
        {
            if (zbran == "TWG" || zbran == "lovcovy kratke mece" || zbran == "kratke mece" || zbran == "sekera battlefury" || zbran == "battlefury" || zbran == "mec broadsword" || zbran == "broadsword")
            {
                if (zbran == "sekera battlefury" || zbran == "battlefury")
                {
                    int zivoty = 280;
                    int zivotyMax = 280;
                    int zivotyNMax = 999;
                    int zivotyN = 999;
                    int cislo1 = 0;
                    int poskozeniS = -42;
                    int poskozeniR = -42 / 2;
                    int poskozeniN = -666;
                    string utok;
                    Console.WriteLine("A nyní zvol jednu ze dvou možných úderů : 'silny'; 'rychly'");
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ty: {0}/{1} HP", zivoty, zivotyMax);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("              Nepřítel:{0}/{1}HP", zivotyN, zivotyNMax);
                        Console.ForegroundColor = ConsoleColor.White;


                        if (zivotyN <= 0 || zivoty <= 0)
                        {
                            Console.WriteLine("Nepřítel umírá v mukách a tobě se právem připisuje hrdniství za výhru v tutoriaulu");
                            Thread.Sleep(2500);
                            break;
                        }
                        utok = Convert.ToString(Console.ReadLine());
                        switch (utok)
                        {
                            case "silny":
                                Random Sil = new Random();
                                cislo1 = Sil.Next(1, 5);
                                if (cislo1 == 2 || cislo1 == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniS);
                                    zivotyN = zivotyN + poskozeniS;
                                }
                                if (cislo1 == 1 || cislo1 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Miss !");
                                    if (zivotyN > 0)
                                    {

                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N = new Random();
                                        int reakce = N.Next(1, 5);
                                        if (reakce == 1 || reakce == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;




                            case "rychly":
                                Random Rych = new Random();
                                int cislo2 = Rych.Next(1, 5);
                                if (cislo2 == 1 || cislo2 == 3 || cislo2 == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniR);
                                    zivotyN = zivotyN + poskozeniR;
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N2 = new Random();
                                        int reakce2 = N2.Next(1, 5);
                                        if (reakce2 == 1 || reakce2 == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Miss !");
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N2 = new Random();
                                        int reakce2 = N2.Next(1, 5);
                                        if (reakce2 == 1 || reakce2 == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Neplatná akce");
                                break;


                        }

                    } while (zivotyN >= 0 || zivoty >= 0);
                }//KONEC BATTLEFURY

                if (zbran == "mec broadsword" || zbran == "broadsword")
                {
                    int zivoty = 250;
                    int zivotyMax = 250;
                    int zivotyN = 999;
                    int zivotyNMax = 999;
                    int cislo1 = 0;
                    int poskozeniS = -17;
                    int poskozeniR = -17 / 2;
                    int poskozeniN = -666;
                    string utok;
                    Console.WriteLine("A nyní zvol jednu ze dvou možných úderů : 'silny'; 'rychly'");
                    do
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ty: {0}/{1} HP", zivoty, zivotyMax);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("              Nepřítel:{0}/{1}HP", zivotyN, zivotyNMax);
                        Console.ForegroundColor = ConsoleColor.White;


                        if (zivotyN <= 0 || zivoty <= 0)
                        {
                            Console.WriteLine("Nepřítel umírá v mukách a tobě se právem připisuje hrdniství za výhru v tutoriaulu");
                            Thread.Sleep(2500);
                            break;
                        }
                        utok = Convert.ToString(Console.ReadLine());
                        switch (utok)
                        {
                            case "silny":
                                Random Sil = new Random();
                                cislo1 = Sil.Next(1, 5);
                                if (cislo1 == 2 || cislo1 == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniS);

                                    zivotyN = zivotyN + poskozeniS;
                                    Thread.Sleep(2000);
                                    Random N = new Random();
                                    int reakce = N.Next(1, 5);
                                    if (reakce == 1 || reakce == 3 || reakce == 4)
                                    {
                                        Console.WriteLine("Nepřítel minul a jsi na tahu");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                        zivoty = zivoty + poskozeniN;
                                    }
                                }
                                if (cislo1 == 1 || cislo1 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Miss !");
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N = new Random();
                                        int reakce = N.Next(1, 5);
                                        if (reakce == 1 || reakce == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        if (!(reakce == 1 || reakce == 3) && zivotyN > 0)
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case "rychly":
                                Random Rych = new Random();
                                int cislo2 = Rych.Next(1, 5);
                                if (cislo2 == 1 || cislo2 == 3 || cislo2 == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniR);
                                    zivotyN = zivotyN + poskozeniR;
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N2 = new Random();
                                        int reakce2 = N2.Next(1, 5);
                                        if (reakce2 == 1 || reakce2 == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        if (!(reakce2 == 1 || reakce2 == 3) && zivotyN > 0)
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Miss !");
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N2 = new Random();
                                        int reakce2 = N2.Next(1, 5);
                                        if (!(reakce2 == 1 || reakce2 == 3 || reakce2 == 4) && zivotyN > 0)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Neplatná akce");
                                break;
                        }

                    } while (zivotyN >= 0 || zivoty >= 0);
                }//KONEC BROADSWORDU
                if (zbran == "lovcovy kratke mece" || zbran == "kratke mece")
                {
                    int zivotyMax = 160;
                    int zivoty = 160;
                    int manaMax = 10;
                    int mana = 10;
                    int vydrz = 50 + 5;
                    int sila = 10;
                    int obratnost = 60;
                    int inteligence = 32;
                    int zivotyN = 999;
                    int zivotyNMax = 999;
                    int cislo1 = 0;
                    int poskozeniS = -666;
                    int poskozeniR = -10 / 2;
                    int poskozeniN = -35;
                    string utok;
                    Console.WriteLine("A nyní zvol jednu ze dvou možných úderů : 'silny'; 'rychly'");
                    do
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ty: {0}/{1} HP", zivoty, zivotyMax);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("              Nepřítel:{0}/{1}HP", zivotyN, zivotyNMax);
                        Console.ForegroundColor = ConsoleColor.White;


                        if (zivotyN <= 0 || zivoty <= 0)
                        {
                            Console.WriteLine("Nepřítel umírá v mukách a tobě se právem připisuje hrdniství za výhru v tutoriaulu");
                            Thread.Sleep(2500);
                            break;
                        }
                        utok = Convert.ToString(Console.ReadLine());
                        switch (utok)
                        {
                            case "silny":
                                Random Sil = new Random();
                                cislo1 = Sil.Next(1, 5);
                                if (cislo1 == 2 || cislo1 == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniS);

                                    zivotyN = zivotyN + poskozeniS;
                                    Thread.Sleep(2000);
                                    Random N = new Random();
                                    int reakce = N.Next(1, 5);
                                    if (reakce == 1 || reakce == 3)
                                    {
                                        Console.WriteLine("Nepřítel minul a jsi na tahu");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                        zivoty = zivoty + poskozeniN;
                                    }
                                }
                                if (cislo1 == 1 || cislo1 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Miss !");
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N = new Random();
                                        int reakce = N.Next(1, 5);
                                        if (reakce == 1 || reakce == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        if (!(reakce == 1 || reakce == 3) && zivotyN > 0)
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case "rychly":
                                Random Rych = new Random();
                                int cislo2 = Rych.Next(1, 5);
                                if (cislo2 == 1 || cislo2 == 3 || cislo2 == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniR);
                                    zivotyN = zivotyN + poskozeniR;
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N2 = new Random();
                                        int reakce2 = N2.Next(1, 5);
                                        if (reakce2 == 1 || reakce2 == 3 || reakce2 == 4)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        if (!(reakce2 == 1 || reakce2 == 3) && zivotyN > 0)
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Miss !");
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N2 = new Random();
                                        int reakce2 = N2.Next(1, 5);
                                        if (!(reakce2 == 1 || reakce2 == 3) && zivotyN > 0)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Neplatná akce");
                                break;
                        }

                    } while (zivotyN >= 0 || zivoty >= 0);
                }
                if (zbran == "TWG")
                {

                    int zivoty = 99999;
                    int zivotyMax = 99999;
                    int zivotyNMax = 125;
                    int zivotyN = 125;
                    int cislo1 = 0;
                    int poskozeniS = -99999;
                    int poskozeniR = -99999 / 2;
                    int poskozeniN = -50;
                    string utok;
                    Console.WriteLine("A nyní zvol jednu ze dvou možných úderů : 'silny'; 'rychly'");
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ty: {0}/{1} HP", zivoty, zivotyMax);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("              Nepřítel:{0}/{1}HP", zivotyN, zivotyNMax);
                        Console.ForegroundColor = ConsoleColor.White;


                        if (zivotyN <= 0 || zivoty <= 0)
                        {
                            Console.WriteLine("Nepřítel umírá v mukách a tobě se právem připisuje hrdniství za výhru v tutoriaulu");
                            Thread.Sleep(2500);
                            break;
                        }
                        utok = Convert.ToString(Console.ReadLine());
                        switch (utok)
                        {
                            case "silny":
                                Random Sil = new Random();
                                cislo1 = Sil.Next(1, 5);
                                if (cislo1 == 2 || cislo1 == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniS);
                                    zivotyN = zivotyN + poskozeniS;
                                }
                                if (cislo1 == 1 || cislo1 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Miss !");
                                    if (zivotyN > 0)
                                    {

                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N = new Random();
                                        int reakce = N.Next(1, 5);
                                        if (reakce == 1 || reakce == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;




                            case "rychly":
                                Random Rych = new Random();
                                int cislo2 = Rych.Next(1, 5);
                                if (cislo2 == 1 || cislo2 == 3 || cislo2 == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniR);
                                    zivotyN = zivotyN + poskozeniR;
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N2 = new Random();
                                        int reakce2 = N2.Next(1, 5);
                                        if (reakce2 == 1 || reakce2 == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Miss !");
                                    if (zivotyN > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N2 = new Random();
                                        int reakce2 = N2.Next(1, 5);
                                        if (reakce2 == 1 || reakce2 == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Neplatná akce");
                                break;


                        }

                    } while (zivotyN >= 0 || zivoty >= 0);
                }//KONEC TWG
            }//KONEC NA BLIZKO
            if (zbran == "vrhaci noze" || zbran == "kuchynske vrhaci noze" || zbran == "supacky luk a sipy" || zbran == "luk a sipy")
            {
                if (zbran == "vrhaci noze" || zbran == "kuchynske vrhaci noze")
                {
                    int zivoty = 170;
                    int zivotyMax = 170;
                    int zivotyN = 999;
                    int zivotyNMax = 999;
                    int cislo1 = 0;
                    int poskozeniR = -4;
                    int poskozeniM = -8;
                    int poskozeniN = -666;
                    int vzdalenost = 3;
                    int noze = 25;
                    string utok;

                    do
                    {
                        if (zivotyN <= 0 || zivoty <= 0)
                        {
                            Console.WriteLine("Nepřítel umírá v mukách a tobě se právem připisuje hrdniství za výhru v tutoriaulu");
                            Thread.Sleep(2500);
                            break;
                        }
                        Console.WriteLine("A nyní zvol jednu ze dvou možných úderů : 'mireny'; 'rychly'");
                        Console.WriteLine("Nože: x{0}", noze);
                        Console.WriteLine();
                        Thread.Sleep(500);
                        Console.WriteLine("Vzdálenost: {0} ", vzdalenost);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ty: {0}/{1} HP", zivoty, zivotyMax);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("              Nepřítel:{0}/{1}HP", zivotyN, zivotyNMax);
                        Console.ForegroundColor = ConsoleColor.White;

                        Random Sip = new Random();
                        int zasahy = Sip.Next(4, 8);
                        utok = Convert.ToString(Console.ReadLine());
                        switch (utok)
                        {
                            case "rychly":
                                noze--;
                                noze--;
                                Console.WriteLine("Nože: x{0}", noze);
                                Random Mir = new Random();
                                cislo1 = Mir.Next(1, 5);
                                {
                                    if (cislo1 == 1 || cislo1 == 4)
                                    {
                                        Console.Clear();

                                        zivotyN = zivotyN + poskozeniM;
                                        if (zasahy == 5 || zasahy == 7)
                                        {
                                            Console.WriteLine("Nože: x{0}", noze);
                                            Console.WriteLine("Zásah oběma střelama!");
                                            Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniM * 2);
                                        }
                                        if (zasahy == 6 || zasahy == 4)
                                        {
                                            Console.WriteLine("Nože: x{0}", noze);
                                            Console.WriteLine("Zásah jednou střelou!");
                                            Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniM);
                                        }
                                    }
                                    if (cislo1 == 2 || cislo1 == 3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Miss !");
                                        if (zivotyN > 0 && vzdalenost > 0)
                                        {
                                            Console.WriteLine("Nepřítel je na tahu!");
                                            vzdalenost = vzdalenost - 1;
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            Console.WriteLine("Nepřítel se přiblížil");
                                            Console.WriteLine("Nože: x{0}", noze);
                                            Console.WriteLine();
                                            Console.WriteLine("Vzdálenost: {0} ", vzdalenost);
                                            Console.WriteLine("Jsi na tahu!");

                                        }
                                    }
                                    if (vzdalenost == 0 && zivotyN > 0)
                                    {
                                        Console.WriteLine("Miss!");
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N = new Random();
                                        int reakce = N.Next(1, 5);
                                        if (reakce == 1 || reakce == 3)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                            Console.WriteLine("Vzdálenost: {0}", vzdalenost);
                                            Console.WriteLine("Nože: x{0}", noze);
                                            Console.WriteLine("Jsi na tahu!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            Console.WriteLine("Nože: x{0}", noze);
                                            Console.WriteLine();
                                            Console.WriteLine("Vzdálenost: {0} ", vzdalenost);
                                            Console.WriteLine("Jsi na tahu!");
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }


                                    else
                                    {
                                        break;
                                    }
                                }
                                break;

                            case "mireny":
                                noze--;
                                noze--;
                                Console.WriteLine("Šípy: x{0}", noze);
                                Random Rych = new Random();
                                int cislo2 = Rych.Next(1, 5);
                                if (cislo2 == 1 || cislo2 == 3 || cislo2 == 4)
                                {
                                    Console.Clear();
                                    zivotyN = zivotyN + poskozeniM;
                                    if (zasahy == 5 || zasahy == 7)
                                    {
                                        Console.WriteLine("Zásah oběma střelama!");
                                        Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniR * 2);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Zásah !");
                                        Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniM);
                                    }
                                }
                                if (cislo1 == 2 || cislo1 == 5)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Miss !");

                                }
                                if (zivotyN > 0 && vzdalenost > 0)
                                {
                                    Console.WriteLine("Nepřítel je na tahu!");
                                    vzdalenost = vzdalenost - 1;
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.WriteLine("Nepřítel se přiblížil");
                                    Console.WriteLine("Vzdálenost: {0}", vzdalenost);
                                    Console.WriteLine("Jsi na tahu!");


                                }
                                if (vzdalenost == 0 && zivotyN > 0)
                                {

                                    Console.WriteLine("Nepřítel je na tahu!");
                                    Thread.Sleep(2000);
                                    Random N = new Random();
                                    int reakce = N.Next(1, 5);
                                    if (reakce == 1 || reakce == 3)
                                    {
                                        Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        Console.WriteLine("Vzdálenost: {0}", vzdalenost);
                                        Console.WriteLine("Jsi na tahu!");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                        zivoty = zivoty + poskozeniN;
                                        Console.WriteLine("Vzdálenost: {0} ", vzdalenost);
                                        Console.WriteLine("Jsi na tahu!");
                                    }
                                }
                                else
                                {
                                    break;
                                }
                                break;

                            default:
                                Console.WriteLine("Neplatná akce");
                                break;
                        }
                    } while (zivotyN >= 0 || zivoty >= 0);
                }//KONEC NOZU
                if (zbran == "supacky luk a sipy" || zbran == "luk a sipy")
                {
                    int zivoty = 200;
                    int zivotyMax = 200;
                    int zivotyNMax = 999;
                    int zivotyN = 999;
                    int cislo1 = 0;
                    int poskozeniR = -20;
                    int poskozeniM = -40;
                    int poskozeniN = -666;
                    int vzdalenost = 3;
                    int sipy = 25;
                    string utok;
                    Console.WriteLine("A nyní zvol jednu ze dvou možných úderů : 'mireny'; 'rychly'");
                    Console.WriteLine("Vzdálenost: {0}", vzdalenost);
                    do
                    {
                        if (zivotyN <= 0 || zivoty <= 0)
                        {
                            Console.WriteLine("Nepřítel umírá v mukách a tobě se právem připisuje hrdniství za výhru v tutoriaulu");
                            Thread.Sleep(2500);
                            break;
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ty: {0}/{1} HP", zivoty, zivotyMax);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("              Nepřítel:{0}/{1}HP", zivotyN, zivotyNMax);
                        Console.ForegroundColor = ConsoleColor.White;

                        utok = Convert.ToString(Console.ReadLine());
                        switch (utok)
                        {
                            case "mireny":
                                sipy--;
                                Console.WriteLine("Šípy: x{0}", sipy);
                                Random Mir = new Random();
                                cislo1 = Mir.Next(1, 5);
                                if (cislo1 == 2 || cislo1 == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniM);
                                    zivotyN = zivotyN + poskozeniM;
                                }
                                if (cislo1 == 1 || cislo1 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Miss !");
                                    if (zivotyN > 0 && vzdalenost > 0)
                                    {
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        vzdalenost = vzdalenost - 1;
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        Console.WriteLine("Nepřítel se přiblížil");
                                        Console.WriteLine("Vzdálenost: {0}", vzdalenost);
                                        Console.WriteLine("Jsi na tahu!");

                                    }
                                    if (vzdalenost == 0 && zivotyN > 0)
                                    {
                                        Console.WriteLine("Miss!");
                                        Console.WriteLine("Nepřítel je na tahu!");
                                        Thread.Sleep(2000);
                                        Random N = new Random();
                                        int reakce = N.Next(1, 5);
                                        if (reakce == 1 || reakce == 3 || reakce == 4)
                                        {
                                            Console.WriteLine("Nepřítel minul a jsi na tahu");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                            zivoty = zivoty + poskozeniN;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;

                            case "rychly":
                                sipy--;
                                Console.WriteLine("Šípy: x{0}", sipy);
                                Random Rych = new Random();
                                int cislo2 = Rych.Next(1, 5);
                                if (cislo2 == 1 || cislo2 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zásah !");
                                    Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", -poskozeniR);
                                    zivotyN = zivotyN + poskozeniR;
                                }
                                if (cislo1 == 1 || cislo1 == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Miss !");

                                }
                                if (zivotyN > 0 && vzdalenost > 0)
                                {
                                    Console.WriteLine("Nepřítel je na tahu!");
                                    vzdalenost = vzdalenost - 1;
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.WriteLine("Nepřítel se přiblížil");
                                    Console.WriteLine("Vzdálenost: {0}", vzdalenost);
                                    Console.WriteLine("Jsi na tahu!");


                                }
                                if (vzdalenost == 0 && zivotyN > 0)
                                {
                                    Console.WriteLine("Nepřítel je na tahu!");
                                    Thread.Sleep(2000);
                                    Random N = new Random();
                                    int reakce = N.Next(1, 5);
                                    if (reakce == 1 || reakce == 3)
                                    {
                                        Console.WriteLine("Nepřítel minul a jsi na tahu");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                        zivoty = zivoty + poskozeniN;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                                break;
                            default:
                                Console.WriteLine("Neplatná akce");
                                break;
                        }

                    } while (zivotyN >= 0 || zivoty >= 0);

                }//KONEC LUKU
            }//KONEC STREDNI
            if (zbran == "hul novice")
            {
                int zivoty = 170;
                int zivotyMax = 0;
                int manaMax = 85;
                int mana = 85;
                int inteligence = 57;
                int zivotyN = 999;
                int zivotyNMax = 999;
                int poskozeniN = -666;
                int vzdalenost = 6;
                string utok;

                do
                {
                    if (zivotyN <= 0 || zivoty <= 0)
                    {
                        Console.WriteLine("Nepřítel umírá v mukách a tobě se právem připisuje hrdniství za výhru v tutoriaulu");
                        Thread.Sleep(2500);
                        break;
                    }
                    Console.WriteLine("Paletka kouzel: 'Ignis augue'    [-10 MP] (vyvolání ohnivé koule)");
                    Console.WriteLine("                'Luminosi lumen' [-5 MP] (vyvolání světelné záře)");
                    Console.WriteLine("");

                    Thread.Sleep(1500);
                    Console.Write("Vzdálenost: {0}             ", vzdalenost);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mana: {0} MP / {1} MP", manaMax, mana);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Ty: {0}/{1} HP", zivoty, zivotyMax);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("              Nepřítel:{0}/{1}HP", zivotyN, zivotyNMax);
                    Console.ForegroundColor = ConsoleColor.White;


                    utok = Convert.ToString(Console.ReadLine());
                    switch (utok)
                    {
                        case "Ignis augue":
                            Random posIg = new Random();
                            int poskozeniIg = posIg.Next(17, 58);
                            mana = mana - 10;
                            Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", poskozeniIg);
                            zivotyN = zivotyN - poskozeniIg;

                            if (zivotyN > 0 && vzdalenost > 0)
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("Nepřítel je na tahu!");
                                vzdalenost = vzdalenost - 1;
                                Thread.Sleep(2000);
                                Console.WriteLine("Nepřítel se přiblížil");
                                Console.WriteLine();
                                Console.WriteLine("Paletka kouzel: 'Ignis augue'    [-10 MP] (vyvolání ohnivé koule)");
                                Console.WriteLine("                'Luminosi lumen' [-5 MP] (vyvolání světelné záře)");
                                Thread.Sleep(1500);
                                Console.Write("Vzdálenost: {0}             ", vzdalenost);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Mana: {0} MP / {1} MP", manaMax, mana);
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                            if (vzdalenost == 0 && zivotyN > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Paletka kouzel: 'Ignis augue'    [-10 MP] (vyvolání ohnivé koule)");
                                Console.WriteLine("                'Luminosi lumen' [-5 MP] (vyvolání světelné záře)");
                                Console.Write("Vzdálenost: {0}             ", vzdalenost);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Mana: {0} MP / {1} MP", manaMax, mana);
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.WriteLine("Nepřítel je na tahu!");
                                Thread.Sleep(2000);
                                Random N = new Random();
                                int reakce = N.Next(1, 5);
                                if (reakce == 1 || reakce == 3 || reakce == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Paletka kouzel: 'Ignis augue'    [-10 MP] (vyvolání ohnivé koule)");
                                    Console.WriteLine("                'Luminosi lumen' [-5 MP] (vyvolání světelné záře)");

                                    Console.WriteLine("Nepřítel minul a jsi na tahu");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Paletka kouzel: 'Ignis augue'    [-10 MP] (vyvolání ohnivé koule)");
                                    Console.WriteLine("                'Luminosi lumen' [-5 MP] (vyvolání světelné záře)");

                                    Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                    zivoty = zivoty + poskozeniN;
                                }
                            }
                            else
                            {
                                break;
                            }

                            break;

                        case "Luminosi lumen":
                            Random posLum = new Random();
                            int poskozeniLum = posLum.Next(5, 21);
                            mana = mana - 5;
                            Console.WriteLine("Nepřítel ztrácí {0} HP a je na řadě", poskozeniLum);
                            zivotyN = zivotyN - poskozeniLum;

                            if (zivotyN > 0 && vzdalenost > 0)
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("Nepřítel je na tahu!");
                                vzdalenost = vzdalenost - 1;
                                Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("Nepřítel se přiblížil");
                                Console.WriteLine("Paletka kouzel: 'Ignis augue'    [-10 MP] (vyvolání ohnivé koule)");
                                Console.WriteLine("                'Luminosi lumen' [-5 MP] (vyvolání světelné záře)");

                                Console.Write("Vzdálenost: {0}             ", vzdalenost);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Mana: {0} MP / {1} MP", manaMax, mana);
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Jsi na tahu!");
                            }
                            if (vzdalenost == 0 && zivotyN > 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Paletka kouzel: 'Ignis augue'    [-10 MP] (vyvolání ohnivé koule)");
                                Console.WriteLine("                'Luminosi lumen' [-5 MP] (vyvolání světelné záře)");

                                Console.WriteLine("Nepřítel je na tahu!");
                                Thread.Sleep(2000);
                                Random N = new Random();
                                int reakce = N.Next(1, 5);
                                if (reakce == 1 || reakce == 3 || reakce == 4)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Paletka kouzel: 'Ignis augue'    [-10 MP] (vyvolání ohnivé koule)");
                                    Console.WriteLine("                'Luminosi lumen' [-5 MP] (vyvolání světelné záře)");

                                    Console.WriteLine("Nepřítel minul a jsi na tahu");

                                    Console.Write("Vzdálenost: {0}             ", vzdalenost);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Mana: {0} MP / {1} MP", manaMax, mana);
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                else
                                {
                                    Console.WriteLine("Zásah ze strany nepřítele, ztrácíš {0} HP a jsi na tahu !", -poskozeniN);
                                    zivoty = zivoty + poskozeniN;
                                }
                            }
                            else
                            {
                                break;
                            }
                            break;

                        default:
                            Console.WriteLine("Neplatná akce");
                            break;
                    }

                } while (zivotyN >= 0 || zivoty >= 0);
            }//KONEC DALKY A I HOLE
        }
    }
}
