using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApplication4
{
    class Vesnice
    {
        public Vesnice(string jmeno, byte poprve, byte VelkyStrom, byte ProzkoumavaniVelkehoStromu, byte rozhlednuti, byte PoprveLouka, byte prozkoumaniSstr, byte lezeni, byte pochod, byte zapad, byte sever, byte vedomostiBrany, byte Prvni, byte Druha, byte Treti, byte Odchazi, byte zjisteni, byte pojistkaM, byte PouzeJednou, byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran, byte pozice, byte NovaKonverzace)
        {
            pozice = 5;

            string zeptani; //nechat !

            string Akce;
            int zabije = 3; //nechat
            bool test = false;
            bool test2 = false;
            bool test3 = false;
            if (vedomostiBrany == 1 && NovaKonverzace == 1)
            {
                //Musí k němu promluvit a otevře se nová konverzace (5)
                popis();
                do
                {

                    Akce = Convert.ToString(Console.ReadLine()); // Zadá co chce dělat



                    //futrováni
                    if (Akce == "koukni se do domu" || Akce == "prohledej domy" || Akce == "koukni se kolem") //ještě další samozřejmě ...
                    {
                        if (prozkoumavaniVesnicky == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Rozhodl jsi se podívat po vesničce");
                            Thread.Sleep(2500);
                            Console.WriteLine("Hned na první pohled bylo jasné, že jediné, co bude stát za pozornost bude prozkoumat ty domy");
                            Thread.Sleep(2500);
                            Console.WriteLine("Zkoušíš otevřít první dveře ... zamčené");
                            Thread.Sleep(2500);
                            Console.WriteLine("Zkoušíš otevřít druhé dveře, opět s nadějí ... zamčené");
                            Thread.Sleep(2500);
                            Console.WriteLine("Nezůstáva ti už tedy nic jiného než zkusit třetí dům ... Přestože jsi byl na začátku dotyku kliky trochu skeptický, nakonec bylo otevřeno !");
                            Thread.Sleep(3500);
                            Console.WriteLine("Ovšem při vstupu do třetího domu, kromě slabé vůně plísně a bílích zdí se sláměnou střechou, jsi si všiml pár detailů");
                            Thread.Sleep(3600);
                            Console.WriteLine("V pravém rohu při vstupu byla jenom jedna duchna a rozkopaná deka");
                            Thread.Sleep(2500);
                            Console.WriteLine("Naproti tobě byl sporák, kde byla hromada špinavého nádobí");
                            Thread.Sleep(2500);
                            Console.Write("Už se skoro snažíš vyprovodit ven, ale v tom si všimneš, že na zemi je vyřezáno");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(" 'NEVĚŘ MU!'");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Thread.Sleep(2500);
                            Console.WriteLine("Po tomhle jsi si jistý, že už jsi prozkoumal vše a vracíš se zase ven, kde se vůbec nic nezměnilo ...");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("//zmáčni libovolné tlačitko//");
                            Console.ReadKey();
                            Console.Clear();

                            prozkoumavaniVesnicky = 1;
                            test = false;
                        }
                        if (prozkoumavaniVesnicky == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Není důvod tuto vesnici nova prozkoumávat !");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("//zmáčni libovolné tlačitko//");
                            Console.ReadKey();
                            Console.Clear();
                            test = false;
                        }
                    }



                    if (Akce == "rozhlidni se" || Akce == "rozhledni se")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        popis();
                        test = false;
                        Console.ForegroundColor = ConsoleColor.White;

                    }


                    //konverzace (HOTOVO)
                    if (Akce == "promluv s vesnicanem" || Akce == "optej se vesnicana" || Akce == "zeptej se vesnicana" || Akce == "oslov vesnicana" || Akce == "promluv si s vesnicanem" || Akce == "pokecej s vesnicanem" || Akce == "promluv si s nim" || Akce == "pokecej s nim")
                    {
                        Console.Clear();
                        if (Akce == "promluv si s nim" || Akce == "pokecej s nim")
                        {
                            string sKym;
                            do
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("S kým ?");
                                Console.ForegroundColor = ConsoleColor.White;
                                sKym = Convert.ToString(Console.ReadLine());
                                if (sKym == "s vesnicanem" || sKym == "vesnicanem")
                                {
                                    test3 = true;
                                }
                                if (sKym == "nikym")
                                {
                                    test3 = false;

                                }
                            } while (!(test3 == true));
                        }
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Rozhodl jsi se oslovit vesničana ...");
                        Thread.Sleep(2500);
                        do
                        {
                                popisBonusovaKonverzace();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            if (NovaKonverzace == 0)
                            {
                                Console.Write("1 - Kdo jste ? "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("3 - Co se to tady děje ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("4 - Promiň dědo, teď už musím jít ..."); Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("5 - Promluvit si o bariéře "); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("[]");
                            }
                            if (NovaKonverzace == 1)
                            {
                                Console.Write("1 - Kdo jste ? "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("3 - Co se to tady děje ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("4 - Promiň dědo, teď už musím jít ..."); Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("5 - Promluvit si o bariéře "); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("[x]");

                            }
                            Console.ForegroundColor = ConsoleColor.White;

                            zeptani = Convert.ToString(Console.ReadLine());
                            Console.Clear();
                            if (zeptani == "1")
                            {

                                //první možnost
                                KdoJsem(zjisteni);
                                zjisteni = 1;
                                Prvni = 1; // PAMATOVAT !!!!!
                                pojistkaM = 1;
                                test2 = false;
                            }
                            if (zeptani == "2")
                            {
                                //druhá možnost
                                Vysvetleni(zjisteni);
                                Druha = 1; //PAMATOVAT !!!
                                pojistkaM = 1;
                                test2 = false;


                            }
                            if (zeptani == "3")
                            {
                                //třetí možnost
                                Deni(zjisteni);
                                Treti = 1; //PAMATOVAT !!!!
                                pojistkaM = 1;
                                test2 = false;

                            }
                            if (zeptani == "4")
                            {
                                if (Prvni == 1 && Druha == 1 && Treti == 1 && PouzeJednou == 0 && vedomostiBrany == 1)
                                {
                                    //DODĚLAT
                                    PouzeJednou = 1;
                                    test2 = true;
                                }
                                //konec rozhovoru
                                pojistkaM = 1;
                                Odchazi = 1;
                                test2 = true;

                            }
                            if (zeptani == "5")
                            {

                                //Potřebné info -> náhrdelník
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Kerilardiir: Aha, tak jsi teda našel "); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("baréeru");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Thread.Sleep(2500);
                                Console.WriteLine("Kerilardiir: [pod nosem] Takže on chce, abych se s ním střetnul sám ... ještě ne !");
                                Thread.Sleep(2500);
                                Console.WriteLine("Kerilardiir: Tady, podle popisu by tohle mělo pasovat do bariéry ... ");
                                Thread.Sleep(2500);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Získáváš drahokam ziso a ukládáš ho do inventáře!");
                                oko = 1;
                                Thread.Sleep(2500);
                                Console.WriteLine("//Zmáčni libovolné tlačítko//");
                                Console.ForegroundColor = ConsoleColor.White;































                            }
                            if (!(zeptani == "1" || zeptani == "2" || zeptani == "3" || zeptani == "4" || zeptani == "5"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Proč bych to dělal ? ...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2500);
                                Console.Clear();
                                test2 = false;
                            }
                            if (Odchazi == 1)
                            {

                                string jeste;
                                do
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Máš ještě nějaké otázky ?");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("//'ano' 'ne'//");

                                    jeste = Convert.ToString(Console.ReadLine()); //po ukončení se zeptá jestli to je vše !!!

                                    switch (jeste)
                                    {
                                        case "ano":
                                            test2 = false;
                                            break;
                                        case "ne":
                                            test2 = true;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Odpovídej pouze 'ano' 'ne' !");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                    }
                                } while (!(jeste == "ano" || jeste == "ne"));
                            }
                        } while (!(test2 == true));
                        Odchazi = 0;

                    }




                    //Zabití vesnicana (HOTVO)
                    if (Akce == "strc do vesnicana" || Akce == "stouchni do vesnicana" || Akce == "zkopni vesnicana" || Akce == "zkopni vesnicana z utesu" || Akce == "shod vesnicana")
                    {
                        //dropne přivěšek a umře
                        ZabitiVesnicanaStouchnutim();

                        test = true; //konec
                    }

                    if (Akce == "zabij vesnicana")
                    {
                        zabije = ZabitiVesnicanaZbrani(zabije);
                        if (zabije == 1)
                        {
                            test = true; //konec
                        }
                        if (zabije == 0)
                        {
                            test = false; //hraje dál
                        }
                    }



                    //SMRTI (jenom tebe)
                    if (Akce == "jdi na sever" || Akce == "jdi na vychod" || Akce == "jdi na zapad")
                    {
                        smrt();
                        test = true;
                    }
                    if (Akce == "jdi na jih")
                    {
                        ValecnikV1SEVER3_VYCHOD vj = new ValecnikV1SEVER3_VYCHOD(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    }
                    //formality
                    if (Akce == "/inv")
                    {
                        EG = inventarP(jablko, oko, EG, trida);
                    }
                    if (Akce == "/stats")
                    {
                        zbran = statyW(EG, zbran, trida);
                        test = false;
                    }
                } while (!(test == true));
            
        }



















































            if (vedomostiBrany == 0 && NovaKonverzace == 0) // pokud  ještě nebyl u brány a už tady byl
            {
                popis();
                do
                {

                    Akce = Convert.ToString(Console.ReadLine()); // Zadá co chce dělat



                    //futrováni
                    if (Akce == "koukni se do domu" || Akce == "prohledej domy" || Akce == "koukni se kolem") //ještě další samozřejmě ...
                    {
                        if (prozkoumavaniVesnicky == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Rozhodl jsi se podívat po vesničce");
                            Thread.Sleep(2500);
                            Console.WriteLine("Hned na první pohled bylo jasné, že jediné, co bude stát za pozornost bude prozkoumat ty domy");
                            Thread.Sleep(2500);
                            Console.WriteLine("Zkoušíš otevřít první dveře ... zamčené");
                            Thread.Sleep(2500);
                            Console.WriteLine("Zkoušíš otevřít druhé dveře, opět s nadějí ... zamčené");
                            Thread.Sleep(2500);
                            Console.WriteLine("Nezůstáva ti už tedy nic jiného než zkusit třetí dům ... Přestože jsi byl na začátku dotyku kliky trochu skeptický, nakonec bylo otevřeno !");
                            Thread.Sleep(3500);
                            Console.WriteLine("Ovšem při vstupu do třetího domu, kromě slabé vůně plísně a bílích zdí se sláměnou střechou, jsi si všiml pár detailů");
                            Thread.Sleep(3600);
                            Console.WriteLine("V pravém rohu při vstupu byla jenom jedna duchna a rozkopaná deka");
                            Thread.Sleep(2500);
                            Console.WriteLine("Naproti tobě byl sporák, kde byla hromada špinavého nádobí");
                            Thread.Sleep(2500);
                            Console.Write("Už se skoro snažíš vyprovodit ven, ale v tom si všimneš, že na zemi je vyřezáno");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(" 'NEVĚŘ MU!'");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Thread.Sleep(2500);
                            Console.WriteLine("Po tomhle jsi si jistý, že už jsi prozkoumal vše a vracíš se zase ven, kde se vůbec nic nezměnilo ...");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("//zmáčni libovolné tlačitko//");
                            Console.ReadKey();
                            Console.Clear();

                            prozkoumavaniVesnicky = 1;
                            test = false;
                        }
                        if (prozkoumavaniVesnicky == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Není důvod tuto vesnici nova prozkoumávat !");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("//zmáčni libovolné tlačitko//");
                            Console.ReadKey();
                            Console.Clear();
                            test = false;
                        }
                    }



                    if (Akce == "rozhlidni se" || Akce == "rozhledni se")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        popis();
                        test = false;
                        Console.ForegroundColor = ConsoleColor.White;

                    }


                    //konverzace (HOTOVO)
                    if (Akce == "promluv s vesnicanem" || Akce == "optej se vesnicana" || Akce == "zeptej se vesnicana" || Akce == "oslov vesnicana" || Akce == "promluv si s vesnicanem" || Akce == "pokecej s vesnicanem" || Akce == "promluv si s nim" || Akce == "pokecej s nim")
                    {
                        Console.Clear();
                        if (Akce == "promluv si s nim" || Akce == "pokecej s nim")
                        {
                            string sKym;
                            do
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("S kým ?");
                                Console.ForegroundColor = ConsoleColor.White;
                                sKym = Convert.ToString(Console.ReadLine());
                                if (sKym == "s vesnicanem" || sKym == "vesnicanem")
                                {
                                    test3 = true;
                                }
                                if (sKym == "nikym")
                                {
                                    test3 = false;

                                }
                            } while (!(test3 == true));
                        }
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Rozhodl jsi se oslovit vesničana ...");
                        Thread.Sleep(2500);
                        do
                        {
                            if (pojistkaM == 0)
                            {
                                uvodkonverzace();
                            }

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            PtaniSe(Prvni, Druha, Treti);
                            Console.ForegroundColor = ConsoleColor.White;

                            zeptani = Convert.ToString(Console.ReadLine());
                            Console.Clear();
                            if (zeptani == "1")
                            {

                                //první možnost
                                KdoJsem(zjisteni);
                                zjisteni = 1;
                                Prvni = 1; // PAMATOVAT !!!!!
                                pojistkaM = 1;
                                test2 = false;
                            }
                            if (zeptani == "2")
                            {
                                //druhá možnost
                                Vysvetleni(zjisteni);
                                Druha = 1; //PAMATOVAT !!!
                                pojistkaM = 1;
                                test2 = false;


                            }
                            if (zeptani == "3")
                            {
                                //třetí možnost
                                Deni(zjisteni);
                                Treti = 1; //PAMATOVAT !!!!
                                pojistkaM = 1;
                                test2 = false;

                            }
                            if (zeptani == "4")
                            {
                                if (Prvni == 1 && Druha == 1 && Treti == 1 && PouzeJednou == 0 && vedomostiBrany == 1)
                                {
                                    //DODĚLAT
                                    PouzeJednou = 1;
                                    test2 = true;
                                }
                                //konec rozhovoru
                                pojistkaM = 1;
                                Odchazi = 1;
                                test2 = true;

                            }
                            if (!(zeptani == "1" || zeptani == "2" || zeptani == "3" || zeptani == "4"))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Proč bych to dělal ? ...");
                                Console.ForegroundColor = ConsoleColor.White;
                                Thread.Sleep(2500);
                                Console.Clear();
                                test2 = false;
                            }
                            if (Odchazi == 1)
                            {

                                string jeste;
                                do
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Máš ještě nějaké otázky ?");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("//'ano' 'ne'//");

                                    jeste = Convert.ToString(Console.ReadLine()); //po ukončení se zeptá jestli to je vše !!!

                                    switch (jeste)
                                    {
                                        case "ano":
                                            test2 = false;
                                            break;
                                        case "ne":
                                            test2 = true;
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("Odpovídej pouze 'ano' 'ne' !");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                    }
                                } while (!(jeste == "ano" || jeste == "ne"));
                            }
                        } while (!(test2 == true));
                        Odchazi = 0;

                    }




                    //Zabití vesnicana (HOTVO)
                    if (Akce == "strc do vesnicana" || Akce == "stouchni do vesnicana" || Akce == "zkopni vesnicana" || Akce == "zkopni vesnicana z utesu" || Akce == "shod vesnicana")
                    {
                        //dropne přivěšek a umře
                        ZabitiVesnicanaStouchnutim();

                        test = true; //konec
                    }

                    if (Akce == "zabij vesnicana")
                    {
                        zabije = ZabitiVesnicanaZbrani(zabije);
                        if (zabije == 1)
                        {
                            test = true; //konec
                        }
                        if (zabije == 0)
                        {
                            test = false; //hraje dál
                        }
                    }



                    //SMRTI (jenom tebe)
                    if (Akce == "jdi na sever" || Akce == "jdi na vychod" || Akce == "jdi na zapad")
                    {
                        smrt();
                        test = true;
                    }
                    if (Akce == "jdi na jih")
                    {
                        ValecnikV1SEVER3_VYCHOD vj = new ValecnikV1SEVER3_VYCHOD(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    }
                    //formality
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
                        tw.WriteLine(NovaKonverzace);
                        tw.Close();
                        test = false;
                        //     , byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran)
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Tvá hra je uložena ...");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    if (Akce == "/inv")
                    {
                        EG = inventarP(jablko, oko, EG, trida);
                    }
                    if (Akce == "/stats")
                    {
                        zbran = statyW(EG, zbran, trida);
                        test = false;
                    }
                } while (!(test == true));
            }
        }
        static void smrt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.WriteLine("OK, Tak jsi se rozhodl (i přes svůj šťavnatý progress) zabít skočením do nekonečné propasti ...");
            Thread.Sleep(3800);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TVÁ VYPRAVÁ KONČÍ, ZMÁČKNI LIBOVOLNÉ TLAČÍTKO");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void popis()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Po snad nekonečně dlouhé době jsi dorazil do vesnice o třech domech");
            Thread.Sleep(1500);
            Console.WriteLine("Vesnice je zarostlá, ale přesto obyvatelná");
            Thread.Sleep(1500);
            Console.Write("Kousek od tebe se nachází nějaká ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("postava");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(", koukající se z útesu přímo před ním");
            Thread.Sleep(1500);
            Console.WriteLine("Daleko za vesnicí v pozadí vidíš něco kamenného a dokonce i z téhle dálky vypadá to něco vážně vysoce");
            Thread.Sleep(2500);
            Console.Write("Stejně tak, jak na ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("severu");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(", na ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("západě");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" i na ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("východě");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" je pouhopouhá propast, směřující přímo do záhuby");
            Thread.Sleep(1500);
            Console.WriteLine("Směrem na jih se můžeš vrátit zpět na louku ...");
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void popisBonusovaKonverzace()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Znova přicházíš do vesnice a zjistíš, že se vůbec nic nezměnilo ...");
            Console.ForegroundColor = ConsoleColor.White;


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
        static int ZabitiVesnicanaZbrani(int zabije)
        {
            byte cyklusZabiti = 0; //LZE NECHAT V PROGRAMU -> je na nic
            byte pojistkaCisteni = 0; // taky nechat
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Čím ?");
                Console.ForegroundColor = ConsoleColor.White;
                string zabitiV = Convert.ToString(Console.ReadLine());
                Console.Clear();
                if (zabitiV == "sekerou" || zabitiV == "zbrani" || zabitiV == "svoji zbrani" || zabitiV == "svoji sekerou" || zabitiV == "sekerou battlefury")
                {
                    zabije = 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Rozhodl jsi se, zabít tohoto nebohého a určitě i nevinného vesničana svojí zbraní, když byl k tobě otočen zády");
                    Thread.Sleep(3500);
                    Console.WriteLine("Po silném úderu do jeho zad, tvá zbraň skrz něj prošla jak máslem a celou tvojí tvář zaslepila jeho krev ...");
                    Console.ForegroundColor = ConsoleColor.White;


                    string ocista;
                    do
                    {

                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.BackgroundColor = ConsoleColor.DarkRed;

                        ocista = Convert.ToString(Console.ReadLine());


                        if (!(ocista == "otri se" || ocista == "ocisti si tvar" || ocista == "utri se" || ocista == "otri si tvar"))
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Nic nevidím !");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (!(ocista == "ocisti si tvar" || ocista == "utri se" || ocista == "otri si tvar" || ocista == "otri se"));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Po utření tváře od krve jsi pohleděl ke svým nohám a uviděl vesničana, jak z posledních sil něco říká");
                    Thread.Sleep(4500);
                    Console.WriteLine("Absolutně tě nezajímalo, co říká, jaká jsou jeho poslední slova ... Ale přesto jsi zaslechl část těchto slov");
                    Thread.Sleep(3500);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
                    Console.WriteLine("Vesničan: ...ožáku... rve ... ignis [zakašlání krve] ... augue");
                    Thread.Sleep(4500);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Najednou si všimneš zvláštního přívěšku ležící vedle něj");
                    Thread.Sleep(2500);
                    Console.WriteLine("Po chvíli přemýšlení jsi se rozhod ho vzít ... Ale najednou celé tvé tělo zažehlo plameny a už jen vidíš, jak se ti pomalu, v obrovských bolestech zatmavuje před očima !");
                    Thread.Sleep(2500);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("TVÁ VYPRAVÁ KONČÍ, ZMÁČKNI LIBOVOLNÉ TLAČÍTKO (PONAUČENÍ: NEBUĎ DICK !)");
                    Console.ReadKey();

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    //Konec cyklu

                    zabije = 0;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("To asi ne !");
                    Thread.Sleep(2500);
                    Console.WriteLine("Po tak hříšném nápadu se ukidňuješ a opět se díváš na krajinu, stejně jak předtím ...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3500);
                    Console.Clear();
                    popis();
                    //odejde z cyklu
                    break;
                }


            } while (!(cyklusZabiti == 1));
            return zabije;
        }
        static void ZabitiVesnicanaStouchnutim()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rozhodl jsi se bez důvodu toho neznámého a bezbranného vesničana shodit z útesu");
            Thread.Sleep(2500);
            Console.Write("Když v tom najednou vidíš, že mu z ruky spadl nějaký zválštní ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("řetízek");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" a z nějakého důvodu cítíš, že by se ti mohl hodit");
            Thread.Sleep(5000);
            Console.WriteLine("Na základě tohoto uvažování se ho snažíš sebrat, když v tom najednou jen cítíš, jak se ti něco obmotalo kolem pasu a začalo tahat");
            Thread.Sleep(5000);
            Console.Write("Nakonec se ukázalo, že ten ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("vesničan");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" není až tak bezmocný a také to, že umí ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("kouzlit");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" !");
            Thread.Sleep(2500);
            Console.Write("I přes všechnu snahu co jsi vynaložil k udržení na pevné zemi jsi nakonec podlehl fyzice a pomocí tohoto zvláštního ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("'lana'");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" tě vesničan stáhl se sebou do záhuby !");
            Thread.Sleep(8000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TVÁ VYPRAVÁ KONČÍ, ZMÁČKNI LIBOVOLNÉ TLAČÍTKO (PONAUČENÍ: NEBUĎ DICK !)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        }
        static void uvodkonverzace()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Přicházíš k němu blíže a blíže");
            Thread.Sleep(3500);
            Console.WriteLine("Až když jsi od něj nějaké tři metry se vesničan otočí a povidá ...");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Vesničan: Konečně jsi dorazil {0}, čekal jsem tě ..."/*jmeno*/);
            Thread.Sleep(2500);
        }
        static void KdoJsem(byte Zjisteni)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (Zjisteni == 0)
            {
                Console.WriteLine("Vesničan: Jsi zvědavý chlapče");
                Thread.Sleep(2500);
                Console.WriteLine("Vesničan: Ale milerád ti na tvojí otázku odpovím");
                Thread.Sleep(3500);
            }

            if (Zjisteni == 1)
            {
                Console.WriteLine("Kerilardiir: Jsi zvědavý chlapče");
                Thread.Sleep(2500);
                Console.WriteLine("Kerilardiir: Ale milerád ti na tvojí otázku odpovím");
                Thread.Sleep(3500);
            }
            Console.Clear();
            Console.WriteLine("Kdysi dávno sem každý rok po staletí chodívali mladí chlapci, kteří skládali poslední zkoušku ... Stejně jako ty");
            Thread.Sleep(5000);
            Console.WriteLine("Před vážně dlouhou dobou jsem byl jedním z nich a ve stejných krajinách jsem ji také skládal ...");
            Thread.Sleep(3500);
            Console.WriteLine("Učil jsem se za mága a i když na to teď asi nevypadám, za ta léta, po tom co jsem se zde usadil, jsem se učil mocnějším a mocnějším kouzlům");
            Thread.Sleep(7500);
            Console.Write("Až mě jendoho dne zvolili, za nejmocnějšího mága a dali mi jméno ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Kerilardiir");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(2500);
            Console.WriteLine("Svoje pravé jméno si už dávno nepamatuji");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("//zmáčni libovolné tlačitko//");
            Console.ReadKey();
            Console.Clear();

        }
        static void PtaniSe(byte Prvni, byte Druha, byte Treti)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (Prvni == 0 && Druha == 0 && Treti == 0)
            {

                Console.Write("1 - Kdo jste ? "); Console.WriteLine("[]");
                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.WriteLine("[]");
                Console.Write("3 - Co se to tady děje ?"); Console.WriteLine("[]");
                Console.WriteLine("4 - Promiň dědo, teď už musím jít ...");
            }
            if (Prvni == 1 && Druha == 0 && Treti == 0)
            {
                Console.Write("1 - Kdo jste ? "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.WriteLine("[]");
                Console.Write("3 - Co se to tady děje ?"); Console.WriteLine("[]");
                Console.WriteLine("4 - Promiň dědo, teď už musím jít ...");
            }
            if (Prvni == 0 && Druha == 1 && Treti == 0)
            {
                Console.Write("1 - Kdo jste ? "); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("[]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("3 - Co se to tady děje ?"); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("[]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("4 - Promiň dědo, teď už musím jít ...");
            }
            if (Prvni == 0 && Druha == 0 && Treti == 1)
            {
                Console.Write("1 - Kdo jste ? "); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("[]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("[]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("3 - Co se to tady děje ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("4 - Promiň dědo, teď už musím jít ...");
            }
            if (Prvni == 1 && Druha == 1 && Treti == 0)
            {
                Console.Write("1 - Kdo jste ? "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("3 - Co se to tady děje ?"); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("[]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("4 - Promiň dědo, teď už musím jít ...");
            }
            if (Prvni == 1 && Druha == 0 && Treti == 1)
            {
                Console.Write("1 - Kdo jste ? "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("[]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("3 - Co se to tady děje ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("4 - Promiň dědo, teď už musím jít ...");
            }
            if (Prvni == 0 && Druha == 1 && Treti == 1)
            {
                Console.Write("1 - Kdo jste ? "); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("[]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("3 - Co se to tady děje ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("4 - Promiň dědo, teď už musím jít ...");
            }
            if (Prvni == 1 && Druha == 1 && Treti == 1)
            {
                Console.Write("1 - Kdo jste ? "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("2 - Čekal ? A odkud znáte moje jméno ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("3 - Co se to tady děje ?"); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("[x]"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("4 - Promiň dědo, teď už musím jít ...");
            }

        }
        static void Vysvetleni(byte Zjisteni)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (Zjisteni == 0)
            {
                Console.WriteLine("Vesničan: Chlapče já toho znám více, než si ty vůbec umíš představit");
                Thread.Sleep(2500);
                Console.WriteLine("Vesničan: Čekám tady na tebe od doby, co tě tady tví kumpáni na koni nechali a potom se nevrátili, aby mi oznámili, že je tady nový rekrut ...");
            }
            if (Zjisteni == 1)
            {
                Console.WriteLine("Kerilardiir: Chlapče já toho znám více, než si ty vůbec umíš představit");
                Thread.Sleep(2500);
                Console.WriteLine("Kerilardiir: Čekám tady na tebe od doby, co tě tady tví kumpáni na koni nechali a potom se nevrátili, aby mi oznámili, že je tady nový rekrut ...");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("//zmáčni libovolné tlačitko//");
            Console.ReadKey();
            Console.Clear();
        }
        static void Deni(byte Zjisteni)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (Zjisteni == 0)
            {
                Console.WriteLine("Vesničan: Víš, pamatuješ si, jak tě ti tví kupánové vysadili západo-jižně od tohodle místa ?");
                Thread.Sleep(2500);
                Console.WriteLine("Vesničan: Pravda je taková, že by mi měli dát vždycky vědět, jestli tady nějaký rekrut je, ale tentokrát to neudělali ...");
                Thread.Sleep(3500);
                Console.WriteLine("Vesničan: Když jsem se šel podívat, kde vězí, uviděl jsem pouze stopy, které uprostřed cesty mizí ...");
                Thread.Sleep(2500);
                Console.WriteLine("Vesničan: Nemuseli mi říkat, co se s nimi stalo ... Podle legendy se jednou za tisíc let probudí ze svého spánku [SLOVO V CIZÍM JAZYCE] a pouze oný rekrut má povinnost ho zastavit ");
                Thread.Sleep(2500);
                Console.WriteLine("Vesničan: Kdysi jsem ho zapečetil do železné brány a doufal, že to bude stačit ... Očividně prošel skrze moji barikádu ...");
                Thread.Sleep(3500);
                Console.WriteLine("Vesničan: Chlapče nerad to říkám, ale budeš muset pečet zlomit a dostat se tam, protože to, že ON se z toho dostal, neznamená, že ty se dostaneš za ním ...");
                Thread.Sleep(2500);
                Console.WriteLine("Vesničan: Běž nyní najít způsob, jak pečeť zlomit, protože dost možná ji upravil ...");
            }
            if (Zjisteni == 1)
            {
                Console.WriteLine("Kerilardiir: Víš, pamatuješ si, jak tě ti tví kupánové vysadili západo-jižně od tohodle místa ?");
                Thread.Sleep(2500);
                Console.WriteLine("Kerilardiir: Pravda je taková, že by mi měli dát vždycky vědět, jestli tady nějaký rekrut je, ale tentokrát to neudělali ...");
                Thread.Sleep(3500);
                Console.WriteLine("Kerilardiir: Když jsem se šel podívat, kde vězí, uviděl jsem pouze stopy, které uprostřed cesty mizí ...");
                Thread.Sleep(2500);
                Console.WriteLine("Kerilardiir: Nemuseli mi říkat, co se s nimi stalo ... Podle legendy se jednou za tisíc let probudí ze svého spánku [SLOVO V CIZÍM JAZYCE] a pouze oný rekrut má povinnost ho zastavit ");
                Thread.Sleep(2500);
                Console.WriteLine("Kerilardiir: Kdysi jsem ho zapečetil do železné brány a doufal, že to bude stačit ... Očividně prošel skrze moji barikádu ...");
                Thread.Sleep(3500);
                Console.WriteLine("Kerilardiir: Chlapče nerad to říkám, ale budeš muset pečet zlomit a dostat se tam, protože to, že ON se z toho dostal, neznamená, že ty se dostaneš za ním ...");
                Thread.Sleep(2500);
                Console.WriteLine("Kerilardiir: Běž nyní najít způsob, jak pečeť zlomit, protože dost možná ji upravil ...");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("//zmáčni libovolné tlačitko//");
            Console.ReadKey();
            Console.Clear();
        }
    }


    }

