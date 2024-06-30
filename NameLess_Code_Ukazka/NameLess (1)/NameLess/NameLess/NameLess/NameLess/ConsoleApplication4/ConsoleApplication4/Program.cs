using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication4
{
    class Program
    {


        static void Main(string[] args)
        {
          //   FightBlizkaV2(); // FUNGUJE
            
            //FightBlizkaV1(); //FUNGUJE
       //     FightStredniV1(); //FUNGUJE
         //   FightStredniV2(); //FUNGUJE
          //  FightDalky1(); //FUNGUJE
            
            byte pozice = 0;
            byte poprve = 0;

            //inventar
            byte jablko = 0;
            byte oko = 0;
            byte EG = 0;



            //



            //LOUKA
            byte rozhlednuti = 0;
            byte PoprveLouka = 0;
            byte prozkoumaniSstr = 0;
            byte lezeni = 0;
            byte pochod = 0;
            byte zapad = 0;
            byte sever = 0;
            //
            //DODĚLAT END alternativu na konec


            //   ( jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM,PouzeJednou,prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace)
            //(string jmeno, byte poprve,byte VelkyStrom,byte ProzkoumavaniVelkehoStromu, byte rozhlednuti,byte PoprveLouka,byte prozkoumaniSstr,byte lezeni,byte pochod,byte zapad,byte sever,byte vedomostiBrany,byte Prvni,byte Druha,byte Treti,byte Odchazi,byte zjisteni,byte pojistkaM,byte PouzeJednou,byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran, byte pozice, byte NovaKonverzace)

            //END
            byte vedomostiBrany = 0;
            byte otevreni = 0;
            byte NovaKonverzace = 0;

            //
            //VESNICE

            byte Prvni = 0;
            byte Druha = 0;
            byte Treti = 0;
            byte Odchazi = 0;
            byte zjisteni = 0;
            byte pojistkaM = 0;
            byte PouzeJednou = 0;
            byte prozkoumavaniVesnicky = 0;


            //

            //Velký strom

            byte VelkyStrom = 0;
            byte ProzkoumavaniVelkehoStromu = 0;
            //
            string trida = "";
            string zbrane = "";
            string jmeno = "";

            byte UVOD;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1 - Spustit novou hru");
            Console.WriteLine("2 - Nahrát uloženou hru");
            Console.WriteLine("3 - Kredity"); //dodělat ještě
            Console.ForegroundColor = ConsoleColor.White;

            do
            {
                UVOD = Convert.ToByte(Console.ReadLine());
                if(UVOD == 1)
                {
                    Console.Clear();
                // FightBlizkaV2();
                /*FightBlizkaV1();
                FightStredniV1();
                FightStredniV2();
                FightDalky1();
                */



                //DOLADIT TUTORIÁL

                //dát do END popisu druhou možnost !!!!!
                //     Vesnice neco = new Vesnice(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, trida);
                //   ValecnikV1SEVER2 zakladKapitola4 = new ValecnikV1SEVER2(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, trida, zbran);
                //ValecnikV1SEVER1 zakladKapitola3 = new ValecnikV1SEVER1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu);
                //ValecnikV1 zakladKapitola2 = new ValecnikV1();
                //Začít kapitolu 3 (sever) u válečníka v1 (zbraně jsou u Valečníka vyřešeny, jen broadsword boj skřípe, ale to ještě počká ...)
                //FightStredniV2();
                // FightDalky1();
                //cestovani();
                // BojovySystem();
                // FightStredniV1();



                {
                    Animace();
                }

                string zbraneV;
                string zbraneM;
                string zbraneL;
                string moznost1;
                string moznost2;
                string moznost3;
                string moznost4;
                string moznost5;
                string moznost6;
                bool test;


                Console.WriteLine("Vítej ve světě mladý hrdino.");
                Console.WriteLine("Řekni mi své jméno: ");
               jmeno = Convert.ToString(Console.ReadLine());


                Console.WriteLine("{0},jakou třídou jsi se vyučil?", jmeno);
                {

                    do
                    {
                        Console.WriteLine("'valecnik' / 'mag' / 'lovec'");
                        trida = Console.ReadLine();

                        switch (trida)
                        {

                            case "valecnik":
                                trida = "valecnik";
                                test = true;
                                break;

                            case "mag":

                                trida = "mag";
                                test = true;
                                break;
                            case "lovec":
                                trida = "lovec";
                                test = true;

                                break;
                            default:
                                Console.WriteLine("Neplatná třída, zkus to znova");
                                test = false;
                                break;

                                //alt 124 |
                        }

                    }
                    while (test == false);
                    {
                    }
                    Console.Clear();
                    if (trida == "valecnik")
                    {
                        Console.WriteLine("Zvolil jsi třídu Válečník");
                    }
                    if (trida == "mag")
                    {
                        Console.WriteLine("Zvolil jsi třídu mág");
                    }
                    if (trida == "lovec")
                    {
                        Console.WriteLine("Zvolil jsi třídu Lovec");
                    }
                    Console.WriteLine("Chceš vysvětlit základy této hry ?");
                    Console.WriteLine("'ano'/'ne'");

                    string help;
                    do
                    {
                        help = Console.ReadLine();
                        if (!(help == "ano" || help == "ne"))
                        {
                            Console.WriteLine("Neplatný výraz, zkus to znova");

                        }
                    } while (!(help == "ano" || help == "ne"));
                    Console.Clear();


                    if (help == "ano")
                    {
                        Console.WriteLine("Pomocí příkazu '/inv' si můžeš zobrazit svůj čuprovej inventář");

                        moznost1 = Convert.ToString(Console.ReadLine());

                        if (moznost1 == "/inv")
                        {
                            inventarP();
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Jasně, zatím tady nic není, ale ty se divíš ??");
                            Console.WriteLine("Neboj, za chvíli budeš mít možnost to napravit !");
                            Console.WriteLine("");
                            Console.WriteLine("");
                        }
                    }

                    if (trida == "valecnik" && help == "ano")
                    {
                        string staty;
                        Console.WriteLine("Svoje staty si můžeš zobrazit kdykoliv příkazem '/stats'");
                        staty = Convert.ToString(Console.ReadLine());
                        if (staty == "/stats")
                        {
                            Console.WriteLine("                                                                               Válečník: lvl {0}");
                            Console.WriteLine("                                                                               Životy: 250/250 HP");
                            Console.WriteLine("                                                                               Mana: 10/10 MP");
                            Console.WriteLine("                                                                               Výdrž: 30 ");
                            Console.WriteLine("                                                                               Síla: 32 ");
                            Console.WriteLine("                                                                               Obratnost: 7 ");
                            Console.WriteLine("                                                                               Inteligence: 22 ");
                            Console.WriteLine();
                        }
                    }
                    if (trida == "mag" && help == "ano")
                    {
                        Console.WriteLine("Svoje staty si můžeš zobrazit kdykoliv příkazem '/stats'");
                        string staty = Convert.ToString(Console.ReadLine());
                        if (staty == "/stats")
                        {
                            Console.WriteLine("Svoje staty si můžeš zobrazit kdykoliv příkazem '/stats'");
                            Console.ReadLine();
                            Console.WriteLine("                                                                               Mág: lvl {0}");
                            Console.WriteLine("                                                                               Životy: 170/170 HP");
                            Console.WriteLine("                                                                               Mana: 50/50 MP");
                            Console.WriteLine("                                                                               Výdrž: 15 ");
                            Console.WriteLine("                                                                               Síla: 3 ");
                            Console.WriteLine("                                                                               Obratnost: 1 ");
                            Console.WriteLine("                                                                               Inteligence: 49 ");
                            Console.WriteLine();
                            Console.WriteLine("Nyní budeš mít možnost zvolit si jednu ze dvou zbraní");
                            Console.WriteLine("Chceš-li vidět staty, které vám daná zbraň přidá, zadejte příkaz '/stats' (název zbraně)");
                        }
                    }
                    if (trida == "lovec" && help == "ano")
                    {

                        Console.WriteLine("Svoje staty si můžeš zobrazit kdykoliv příkazem '/stats'");
                        string staty = Convert.ToString(Console.ReadLine());
                        if (staty == "/stats")
                        {
                            Console.WriteLine("                                                                               Lovec: lvl {0}");
                            Console.WriteLine("                                                                               Životy: 200/200 HP");
                            Console.WriteLine("                                                                               Mana: 10/10 MP");
                            Console.WriteLine("                                                                               Výdrž: 50 ");
                            Console.WriteLine("                                                                               Síla: 10 ");
                            Console.WriteLine("                                                                               Obratnost: 35 ");
                            Console.WriteLine("                                                                               Inteligence: 32 ");
                            Console.WriteLine("Nyní budeš mít možnost zvolit si jednu ze dvou zbraní");
                            Console.WriteLine("Chceš-li vidět staty, které vám daná zbraň přidá, zadejte příkaz '/stats' (název zbraně)");
                        }
                    }

                    if (help == "ne")
                    {
                        Console.WriteLine("Dobrá tedy, ");
                    }

                    if (trida == "valecnik")
                    {

                        Console.WriteLine("Stiskni ENTER");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Nyní budeš mít možnost zvolit si jednu ze dvou zbraní");
                        Console.WriteLine("Chceš-li vidět staty, které vám daná zbraň přidá, zadejte příkaz '/stats' (název zbraně)");
                        Console.WriteLine("Až se rozhodneš, která zbraň je hodna tvé velikosti a úžasnosti, napiš '(název zbraně)'");
                        {
                            Console.WriteLine("                 ^       ^^^^^                                                                   ");
                            Console.WriteLine("                / /______|   |                                                                       ");
                            Console.WriteLine("               /             |                                                                    ");
                            Console.WriteLine("              /              |                                                                      ");
                            Console.WriteLine("             /               |                        [                                                       ");
                            Console.WriteLine("             /               |                        |                                                     ");
                            Console.WriteLine("              /              |               @XX/XX/XX|{:::::::::::::::::::::::::::::::::>                 ");
                            Console.WriteLine("               /   _____     |               @X/XX/XXX|{:::::::::::::::::::::::::::::::::>                                                  ");
                            Console.WriteLine("                / /     |    |                        |                                                         ");
                            Console.WriteLine("                 v      |    |                        [                                                            ");
                            Console.WriteLine("                        |----|                                                                               ");
                            Console.WriteLine("                        |----|                                                                                   ");
                            Console.WriteLine("                        |----|                          'mec broadsword'                                                       ");
                            Console.WriteLine("                        |----|                                                                                       ");
                            Console.WriteLine("                        |----|                                                                                    ");
                            Console.WriteLine("                        |____|                                                                                         ");
                            Console.WriteLine("");
                            Console.WriteLine("                        'sekera battlefury'               ");
                            int jen = 5;
                            zbrane = volba1(jen);

                            Thread.Sleep(2000);
                            Console.WriteLine("Dobře, máme za sebou formality a nyní se můžeme vrhnout na samotnou hru !");
                            Thread.Sleep(2500);
                            Kapitola1(jmeno);
                                ValecnikV1 zakladKapitola2 = new ValecnikV1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbrane, pozice, NovaKonverzace);

                        }
                    }


                    if (trida == "mag")
                    {
                        Console.WriteLine("Stiskni ENTER");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Nyní budeš mít možnost zvolit si jednu ze dvou zbraní");
                        Console.WriteLine("Chceš-li vidět staty, které vám daná zbraň přidá, zadejte příkaz '/stats' (název zbraně)");
                        Console.WriteLine("Až se rozhodneš, která zbraň je hodna tvé velikosti a úžasnosti, napiš '(název zbraně)'");

                        {


                            Console.WriteLine("             **                                                                    ");
                            Console.WriteLine("            *****                                                                      ");
                            Console.WriteLine("           *******                                                                     ");
                            Console.WriteLine("            *****              @XXX|{::::::>                                                          ");
                            Console.WriteLine("             |*|                                                     ");
                            Console.WriteLine("             |||                             @XXX|{::::::>                      ");
                            Console.WriteLine("             |||                                                        ");
                            Console.WriteLine("            ||||                @XXX|{::::::>                                    ");
                            Console.WriteLine("            ||||                                                          ");
                            Console.WriteLine("             |||                                                               ");
                            Console.WriteLine("             |||                      'kuchynske vrhaci noze'                                                                    ");
                            Console.WriteLine("             ||||                           ( x25 )                                                                ");
                            Console.WriteLine("             ||||                                                                                            ");
                            Console.WriteLine("              ||                                                                                                 ");
                            Console.WriteLine("             |||                                                                                             ");
                            Console.WriteLine("                                                                                                                  ");
                            Console.WriteLine("       'hul novice'    ");
                            Console.WriteLine("                                       ");
                             zbrane = volba2();
                            Thread.Sleep(2000);
                            Console.WriteLine("Dobře, máme za sebou formality a nyní se můžeme vrhnout na samotnou hru !");
                            Thread.Sleep(2500);
                            Kapitola1(jmeno);
                                ValecnikV1 zakladKapitola2 = new ValecnikV1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbrane, pozice, NovaKonverzace);
                        }
                    }


                    if (trida == "lovec")
                    {
                        Console.WriteLine("Stiskni ENTER");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Nyní budeš mít možnost zvolit si jednu ze dvou zbraní");
                        Console.WriteLine("Chceš-li vidět staty, které vám daná zbraň přidá, zadejte příkaz '/stats' (název zbraně)");
                        Console.WriteLine("Až se rozhodneš, která zbraň je hodna tvé velikosti a úžasnosti, napiš '(název zbraně)'");
                        {

                            Console.WriteLine("                                                                                 ");
                            Console.WriteLine("              ^^^                                                                    ");
                            Console.WriteLine("            //  |/|                                                             |         ");
                            Console.WriteLine("           //   /||    +      <------------*                             @XXXXX|{:::::::::::>                                                     ");
                            Console.WriteLine("          //    |||               (x25)                                         |                                                          ");
                            Console.WriteLine("         //     ||/                                                                                                                   ");
                            Console.WriteLine("        //      |/|                                                                         ");
                            Console.WriteLine("        //      /||                                                              |                                    ");
                            Console.WriteLine("         //     |||                                                       @XXXXX|{::::::::::>                                          ");
                            Console.WriteLine("          //    ||/                                                              |                                   ");
                            Console.WriteLine("            //  |/|                                                                                         ");
                            Console.WriteLine("                                                                                                         ");
                            Console.WriteLine("                  'supacky luk a sipy'                                    'lovcovy kratke mece'                                                    ");
                            Console.WriteLine("");
                             zbrane = volba3();
                            Thread.Sleep(2000);
                            Console.WriteLine("Dobře, máme za sebou formality a nyní se můžeme vrhnout na samotnou hru !");
                            Thread.Sleep(2500);
                            Kapitola1(jmeno);
                                ValecnikV1 zakladKapitola2 = new ValecnikV1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbrane, pozice, NovaKonverzace);
                        }
                    }


                }
            }
                if(UVOD == 2)
                {
                    Console.Clear();
                    //nahrát
                    TextReader tr = new StreamReader("Savo.txt");
                    string a = tr.ReadLine(); //jmeno -> nemusí se convertovat
                    string b = tr.ReadLine();
                    string c = tr.ReadLine();
                    string d = tr.ReadLine();
                    string e = tr.ReadLine();
                    string f = tr.ReadLine();
                    string g = tr.ReadLine();
                    string h = tr.ReadLine();
                    string i = tr.ReadLine();
                    string j = tr.ReadLine();
                    string k = tr.ReadLine();
                    string l = tr.ReadLine();
                    string m = tr.ReadLine();
                    string n = tr.ReadLine();
                    string o = tr.ReadLine();
                    string p = tr.ReadLine();
                    string q = tr.ReadLine();
                    string r = tr.ReadLine();
                    string s = tr.ReadLine();
                    string t = tr.ReadLine();
                    string u = tr.ReadLine();
                    string v = tr.ReadLine();
                    string w = tr.ReadLine();
                    string x = tr.ReadLine();
                    string y = tr.ReadLine(); //trida
                    string z = tr.ReadLine(); //zbran
                    string az = tr.ReadLine(); //pozice
                    string ab = tr.ReadLine();

                    jmeno = Convert.ToString(a);
                    poprve = Convert.ToByte(b);
                    VelkyStrom = Convert.ToByte(c);
                    ProzkoumavaniVelkehoStromu = Convert.ToByte(d);
                    rozhlednuti = Convert.ToByte(e);
                    PoprveLouka = Convert.ToByte(f);
                    prozkoumaniSstr = Convert.ToByte(g);
                    lezeni = Convert.ToByte(h);
                    pochod = Convert.ToByte(i);
                    zapad = Convert.ToByte(j);
                    sever = Convert.ToByte(k);
                    vedomostiBrany = Convert.ToByte(l);
                    Prvni = Convert.ToByte(m);
                    Druha = Convert.ToByte(n);
                    Treti = Convert.ToByte(o);
                    Odchazi = Convert.ToByte(p);
                    zjisteni = Convert.ToByte(q);
                    pojistkaM = Convert.ToByte(r);
                    PouzeJednou = Convert.ToByte(s);
                    prozkoumavaniVesnicky = Convert.ToByte(t);
                    otevreni = Convert.ToByte(u);
                    jablko = Convert.ToByte(v);
                    oko = Convert.ToByte(w);
                    EG = Convert.ToByte(x);
                    trida = Convert.ToString(y);
                    zbrane = Convert.ToString(z);

                    pozice = Convert.ToByte(az);
                    NovaKonverzace = Convert.ToByte(ab);

                    tr.Close();
                    if (pozice == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Není uložená žádná hra !!!");
                        Console.WriteLine("Zmáčkněte livbovolné tlačítko pro ukončení ...");
                        Console.ReadKey();

                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    if (pozice == 1)
                    {
                        ValecnikV1 jedno = new ValecnikV1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbrane, pozice, NovaKonverzace);
                    }
                    if (pozice == 2)
                    {
                        ValecnikV1SEVER1 jedno = new ValecnikV1SEVER1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbrane, pozice, NovaKonverzace);
                    }
                    if (pozice == 3)
                    {
                       ValecnikV1SEVER2 jedno = new ValecnikV1SEVER2 (jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbrane, pozice, NovaKonverzace);
                    }
                    if (pozice == 4)
                    {
                        ValecnikV1SEVER3_VYCHOD jedno = new ValecnikV1SEVER3_VYCHOD(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbrane, pozice, NovaKonverzace);
                    }
                    if (pozice == 5)
                    {
                        Vesnice jendo = new Vesnice(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbrane, pozice, NovaKonverzace);
                    }
                    if (pozice == 6)
                    {
                        END jedno = new END(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbrane, pozice, NovaKonverzace);
                    }
                }
            } while (!(UVOD == 1 || UVOD == 2));
            }
    
    static void inventarP()
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
    static void help()
    {
        Console.WriteLine("/stats                   ->        zobrazí staty hrdiny / zbraní");
        Console.WriteLine("/inv                     ->        zobrazí inventář hrdiny");
        Console.WriteLine("/eq (nazev zbrane)       ->        nasadí danou zbraň a aktualizuje staty hrdiny");
    }
    static void sekeraVinventari()
    {
        Console.WriteLine("_________________^_______^^^^^__________________________________________________________________________");
        Console.WriteLine("|---------------/ /______|   |-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------------/             |-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------------/     *        |-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|------------/     *         |-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------------/   *          |-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------------/   _____     |-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|---------------/ /-----|    |-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------v------|    |-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------------------|    |-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------------------|____|-----|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|__________________________________|_________________________________|_________________________________|");
    }
    static int statyWv1()
    {

        int zivotyMax = 280;
        int zivoty = 280;
        int manaMax = 10;
        int mana = 10;
        int vydrz = 30;
        int sila = 42;
        int obratnost = 5;
        int inteligence = 15;

        /*zivotyMax = 280;
        zivoty = 280;
        manaMax = 10;
        mana = 10;
        vydrz = 30;
        sila = 37;
        obratnost = 5;
        inteligence = 22;
        */

        Console.WriteLine("                                                                               Válečník: lvl {0}");
        Console.WriteLine("                                                                               Životy: {0} / {1} HP ", zivoty, zivotyMax);
        Console.WriteLine("                                                                               Mana: {0} / {1} MP", mana, manaMax);
        Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
        Console.WriteLine("                                                                               Síla: {0} ", sila);
        Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
        Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);
        return zivotyMax;
        return zivoty;
        return manaMax;
        return mana;
        return vydrz;
        return sila;
        return obratnost;
        return inteligence;
    }
    static int statyWv1Utok(int odecet)
    {
        odecet = 0;
        int zivotyMax = 280;
        int zivoty = 280 + odecet;
        int manaMax = 10;
        int mana = 10;
        int vydrz = 30;
        int sila = 42;
        int obratnost = 5;
        int inteligence = 15;

        /*zivotyMax = 280;
        zivoty = 280;
        manaMax = 10;
        mana = 10;
        vydrz = 30;
        sila = 37;
        obratnost = 5;
        inteligence = 22;
        */

        Console.WriteLine("                                                                               Válečník: lvl {0}");
        Console.WriteLine("                                                                               Životy: {0} / {1} HP ", zivoty, zivotyMax);
        Console.WriteLine("                                                                               Mana: {0} / {1} MP", mana, manaMax);
        Console.WriteLine("                                                                               Výdrž: {0} ", vydrz);
        Console.WriteLine("                                                                               Síla: {0} ", sila);
        Console.WriteLine("                                                                               Obratnost: {0} ", obratnost);
        Console.WriteLine("                                                                               Inteligence: {0} ", inteligence);
        return zivotyMax;
        //return zivoty;
        return manaMax;
        return mana;
        return vydrz;
        return sila;
        return obratnost;
        return inteligence;
    }
    static void mecVinventari()
    {

        Console.WriteLine("________________________________________________________________________________________________________");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|---------[------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|---------|------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|@XXX/XXX|{:::::::*:::::::::::::::>|---------------------------------|---------------------------------|");
        Console.WriteLine("|@XX/XX/X|{::::::*::::::::::::::::>|---------------------------------|---------------------------------|");
        Console.WriteLine("|---------|------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|---------[------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|__________________________________|_________________________________|_________________________________|");
    }
    static void hulVinventari()
    {
        Console.WriteLine("______________**________________________________________________________________________________________");
        Console.WriteLine("|------------*****-----------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------*******----------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|------------*****-----------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------------|*|------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------------|||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------------|||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|------------||||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|------------||||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------------||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------------||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------------|||-----------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------------|||-----------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------------||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------------|||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|__________________________________|_________________________________|_________________________________|");

    }
    static void nozeVinventari()
    {
        Console.WriteLine("________________________________________________________________________________________________________");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----@XXX|{::::::>----------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------------@XXX|{::::::>----|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------------@XXX|{::::::>-------|---------------------------------|---------------------------------|");
        Console.WriteLine("|---------@XXX|{::::::>------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|------@XXX|{::::::>---------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------------------@XXX|{::::::>--|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|__________________________________|_________________________________|_________________________________|");
    }
    static void lukVinventari()
    {
        Console.WriteLine("________________________________________________________________________________________________________");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----------^^^--------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|---------//--|/|------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------//   /||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------//----|||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----- //-----||/------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|---- //------|/|------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|--- //-------/||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-----//------|||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------//----||/------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|---------//  |/|------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------//-|||------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------<------------*----|---------------------------------|---------------------------------|");
        Console.WriteLine("|--------------------(x25)---------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|__________________________________|_________________________________|_________________________________|");


    }
    static void meceVinventari()
    {
        Console.WriteLine("________________________________________________________________________________________________________");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------|-----------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|---@XXXXX|{*::::::::::>-----------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------|-----------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------------------|--------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|------------@XXXXX|{:::::*:::::>--|---------------------------------|---------------------------------|");
        Console.WriteLine("|-------------------|--------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
        Console.WriteLine("|__________________________________|_________________________________|_________________________________|");
    }
    static void inventarSekera()
    {
        string invV1;
        string staty;
        string battlefury;
        bool test5;
        Console.WriteLine("Jak vidíš, zbraň zmizela z inventáře a aktualizovala tvoje staty");
        Console.WriteLine("Pamatuj ! Aktivní zbraň můžeš mít pouze JEDNU");
        Console.WriteLine("Nyní, pokud se chceš přesvědčit o svých statech, použíj příkaz");

        do
        {
            staty = Convert.ToString(Console.ReadLine());


            if (staty == "/stats")
            {
                int statyW = statyWv1();
                test5 = true;
            }
            if (!(staty == "/stats"))
            {
                test5 = false;
            }
        } while (test5 = false);
    }
    static void inventarHul()
    {
        string staty;
        bool test5;
        Console.WriteLine("Jak vidíš, zbraň zmizela z inventáře a aktualizovala tvoje staty");
        Console.WriteLine("Pamatuj ! Aktivní zbraň můžeš mít pouze JEDNU");
        Console.WriteLine("Nyní, pokud se chceš přesvědčit o svých statech, použíj příkaz");

        do
        {
            staty = Convert.ToString(Console.ReadLine());


            if (staty == "/stats")
            {
                int statyM = statyMv1();
                test5 = true;
            }
            if (!(staty == "/stats"))
            {
                test5 = false;
            }
        } while (test5 = false);
    }
    static void inventarNoze()
    {
        bool test5;
        string staty;
        Console.WriteLine("Jak vidíš, zbraň zmizela z inventáře a aktualizovala tvoje staty");
        Console.WriteLine("Pamatuj ! Aktivní zbraň můžeš mít pouze JEDNU");
        Console.WriteLine("Nyní, pokud se chceš přesvědčit o svých statech, použíj příkaz");

        do
        {
            staty = Convert.ToString(Console.ReadLine());


            if (staty == "/stats")
            {
                int statyM = statyMv2();
                test5 = true;
            }
            if (!(staty == "/stats"))
            {
                test5 = false;
            }
        } while (test5 = false);
    }
    static void inventarLuk()
    {
        string staty;
        bool test5;
        Console.WriteLine("Jak vidíš, zbraň zmizela z inventáře a aktualizovala tvoje staty");
        Console.WriteLine("Pamatuj ! Aktivní zbraň můžeš mít pouze JEDNU");
        Console.WriteLine("Nyní, pokud se chceš přesvědčit o svých statech, použíj příkaz");

        do
        {
            staty = Convert.ToString(Console.ReadLine());


            if (staty == "/stats")
            {
                int statyL = statyLv1();
                test5 = true;
            }
            if (!(staty == "/stats"))
            {
                test5 = false;
            }
        } while (test5 = false);
    }
    static int statyWv2()
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

        return zivotyMax;
        return zivoty;
        return manaMax;
        return mana;
        return vydrz;
        return sila;
        return obratnost;
        return inteligence;
    }
    static int statyMv1()
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

        return zivotyMax;
        return zivoty;
        return manaMax;
        return mana;
        return vydrz;
        return sila;
        return obratnost;
        return inteligence;

    }
    static int statyMv2()
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

        return zivotyMax;
        return zivoty;
        return manaMax;
        return mana;
        return vydrz;
        return sila;
        return obratnost;
        return inteligence;
    }
    static int statyLv1()
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

        return zivotyMax;
        return zivoty;
        return manaMax;
        return mana;
        return vydrz;
        return sila;
        return obratnost;
        return inteligence;
    }
    static int statyLv2()
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

        return zivotyMax;
        return zivoty;
        return manaMax;
        return mana;
        return vydrz;
        return sila;
        return obratnost;
        return inteligence;
    }
    static void inventarMec()
    {
        bool test5;
        string staty;
        Console.WriteLine("Jak vidíš, zbraň zmizela z inventáře a aktualizovala tvoje staty");
        Console.WriteLine("Pamatuj ! Aktivní zbraň můžeš mít pouze JEDNU");
        Console.WriteLine("Nyní, pokud se chceš přesvědčit o svých statech, použíj příkaz");

        do
        {
            staty = Convert.ToString(Console.ReadLine());


            if (staty == "/stats")
            {
                int statyW = statyWv2();
                test5 = true;
            }
            if (!(staty == "/stats"))
            {
                test5 = false;
            }
        } while (test5 = false);
    }
    static void inventarMece()
    {
        bool test5;
        string staty;
        Console.WriteLine("Jak vidíš, zbraň zmizela z inventáře a aktualizovala tvoje staty");
        Console.WriteLine("Pamatuj ! Aktivní zbraň můžeš mít pouze JEDNU");
        Console.WriteLine("Nyní, pokud se chceš přesvědčit o svých statech, použíj příkaz");

        do
        {
            staty = Convert.ToString(Console.ReadLine());


            if (staty == "/stats")
            {
                int statyL = statyLv2();
                test5 = true;
            }
            if (!(staty == "/stats"))
            {
                test5 = false;
            }
        } while (test5 = false);
    }
    static void sekera1()
    {
        bool test6;
        do
        {
            string volbaZbrane;
            ;

            volbaZbrane = Convert.ToString(Console.ReadLine());
            if (volbaZbrane == "sekera battlefury" || volbaZbrane == "battlefury")
            {
                // inventarSekera(volbaZbrane);
                test6 = true;

            }


            if (volbaZbrane == "/stats sekera battlefury" || volbaZbrane == "/stats battlefury")
            {
                Console.WriteLine("");
                Console.WriteLine("životy: +30 HP");
                Console.WriteLine("síla: +5");
                Console.WriteLine("obratnost: -2");
                test6 = false;
            }
        } while (!(test6 = true));

    }
    static string volba1(int neco)
    {
        string zbraneV;
        do
        {
            zbraneV = Convert.ToString(Console.ReadLine());

            if (zbraneV == "/stats sekera battlefury" || zbraneV == "/stats battlefury")
            {
                Console.WriteLine("Životy: +30 HP");
                Console.WriteLine("Síla: +10");
                Console.WriteLine("inteligence: -7");
            }
            if (zbraneV == "/stats mec broadsword" || zbraneV == "/stats broadsword")
            {
                Console.WriteLine("Výdrž: +7");
                Console.WriteLine("Obratnost: +15 ");
                Console.WriteLine("Síla: -15");
            }

        } while (!(zbraneV == "sekera battlefury" || zbraneV == "battlefury" || zbraneV == "mec broadsword" || zbraneV == "broadsword"));

        if (zbraneV == "sekera battlefury" || zbraneV == "battlefury")
        {
            string INV;
            do
            {
                Console.Clear();
                Console.WriteLine("Nyní zobraz svůj inventář");
                INV = Convert.ToString(Console.ReadLine());
            } while (!(INV == "/inv"));
            sekeraVinventari();
            Console.WriteLine("");
            Console.WriteLine("Jak vidíš, zbraň se ti automaticky vložila do inventáře");
            Console.WriteLine("Avšak pokud chceš zbraň používat a  aktualizovat si svoje staty, musíš si ji NASADIT");
            Console.WriteLine("Nasadit zbraň si můžeš pomocí příkazu '/eq (název zbraně)'");
            string vybaveni;

            vybaveni = Convert.ToString(Console.ReadLine());
            Console.Clear();
            do
            {
                if (vybaveni == "/eq sekera battlefury" || vybaveni == "battlefury")
                {
                }

            } while (!(vybaveni == "/eq sekera battlefury" || vybaveni == "/eq battlefury"));
            inventarP();
            inventarSekera();

        }
        if (zbraneV == "mec broadsword" || zbraneV == "broadsword")
        {
            string INV;
            do
            {
                Console.WriteLine("Nyní zobraz svůj inventář");
                INV = Convert.ToString(Console.ReadLine());
            } while (!(INV == "/inv"));
            mecVinventari();
            Console.WriteLine("");
            Console.WriteLine("Jak vidíš, zbraň se ti automaticky vložila do inventáře");
            Console.WriteLine("Avšak pokud chceš zbraň používat a  aktualizovat si svoje staty, musíš si ji NASADIT");
            Console.WriteLine("Nasadit zbraň si můžeš pomocí příkazu '/eq (název zbraně)'");
            string vybaveni;

            vybaveni = Convert.ToString(Console.ReadLine());
            do
            {
                if (vybaveni == "/eq mec broadsword" || vybaveni == "broadsword")
                {

                }

            } while (!(vybaveni == "/eq mec broadsword" || vybaveni == "/eq broadsword"));
            inventarP();
            inventarMec();
        }
        if (zbraneV == "sekera battlefury" || zbraneV == "battlefury")
        {
            next1();
        }
        if (zbraneV == "mec broadsword" || zbraneV == "broadsword")
        {
            next2();
        }
            return zbraneV;
    }
    static string volba2()
    {
        string zbraneM;
        do
        {
            zbraneM = Convert.ToString(Console.ReadLine());

            if (zbraneM == "/stats hul novice")
            {
                Console.WriteLine("Mana: +15 MP");
                Console.WriteLine("Výdrž -2");
                Console.WriteLine("Inteligence: +8");
            }
            if (zbraneM == "/stats kuchynske vrhaci noze" || zbraneM == "/stats vrhaci noze")
            {
                Console.WriteLine("Výdrž: +5");
                Console.WriteLine("Obratnost: +7 ");
                Console.WriteLine("Mana: -5 MP");
            }

        } while (!(zbraneM == "hul novice" || zbraneM == "kuchynske vrhaci noze" || zbraneM == "vrhaci noze"));

        if (zbraneM == "hul novice")
        {
            string INV;
            do
            {
                Console.WriteLine("Nyní zobraz svůj inventář");
                INV = Convert.ToString(Console.ReadLine());
            } while (!(INV == "/inv"));
            hulVinventari();
            Console.WriteLine("");
            Console.WriteLine("Jak vidíš, zbraň se ti automaticky vložila do inventáře");
            Console.WriteLine("Avšak pokud chceš zbraň používat a  aktualizovat si svoje staty, musíš si ji NASADIT");
            Console.WriteLine("Nasadit zbraň si můžeš pomocí příkazu '/eq (název zbraně)'");
            string vybaveni;

            vybaveni = Convert.ToString(Console.ReadLine());
            Console.Clear();
            do
            {
                if (vybaveni == "/eq hul novice")
                {

                }

            } while (!(vybaveni == "/eq hul novice"));
            inventarP();
            inventarHul();
            {
                next4();
            }
        }
        if (zbraneM == "kuchynske vrhaci noze" || zbraneM == "vrhaci noze")
        {
            string INV;
            do
            {
                Console.Clear();
                Console.WriteLine("Nyní zobraz svůj inventář");
                INV = Convert.ToString(Console.ReadLine());
            } while (!(INV == "/inv"));
            nozeVinventari();
            Console.WriteLine("");
            Console.WriteLine("Jak vidíš, zbraň se ti automaticky vložila do inventáře");
            Console.WriteLine("Avšak pokud chceš zbraň používat a  aktualizovat si svoje staty, musíš si ji NASADIT");
            Console.WriteLine("Nasadit zbraň si můžeš pomocí příkazu '/eq (název zbraně)'");
            string vybaveni;

            vybaveni = Convert.ToString(Console.ReadLine());
            do
            {
                if (vybaveni == "/eq kuchynske vrhaci noze" || vybaveni == "vrhaci noze")
                {
                    next6();
                }

            } while (!(vybaveni == "/eq kuchynske vrhaci noze" || vybaveni == "/eq vrhaci noze"));
            inventarP();
            inventarNoze();
        }

            return zbraneM;
    }
    static string volba3()
    {
        string zbraneL;
        do
        {
            zbraneL = Convert.ToString(Console.ReadLine());

            if (zbraneL == "/stats supacky luk a sipy" || zbraneL == "/stats luk a sipy")
            {
                Console.WriteLine("Výdrž: +14");
                Console.WriteLine("Obratnost: +5");
                Console.WriteLine("Inteligence: - 5");
            }
            if (zbraneL == "/stats lovcovy kratke mece" || zbraneL == "/stats kratke mece")
            {
                Console.WriteLine("Životy: -40 HP");
                Console.WriteLine("Výdrž: +5");
                Console.WriteLine("Obratnost: +25");
            }

        } while (!(zbraneL == "supacky luk a sipy" || zbraneL == "luk a sipy" || zbraneL == "lovcovy kratke mece" || zbraneL == "kratke mece"));

        if (zbraneL == "supacky luk a sipy" || zbraneL == "luk a sipy")
        {
            string INV;
            do
            {
                Console.WriteLine("Nyní zobraz svůj inventář");
                INV = Convert.ToString(Console.ReadLine());
            } while (!(INV == "/inv"));
            lukVinventari();
            Console.WriteLine("");
            Console.WriteLine("Jak vidíš, zbraň se ti automaticky vložila do inventáře");
            Console.WriteLine("Avšak pokud chceš zbraň používat a  aktualizovat si svoje staty, musíš si ji NASADIT");
            Console.WriteLine("Nasadit zbraň si můžeš pomocí příkazu '/eq (název zbraně)'");
            string vybaveni;

           
            Console.Clear();
            do
                {
                    vybaveni = Convert.ToString(Console.ReadLine());
                    if (vybaveni == "/eq supacky luk a sipy" || vybaveni == "/eq luk a sipy")
                {

                }

            } while (!(vybaveni == "/eq supacky luk a sipy" || vybaveni == "/eq luk a sipy"));
            inventarP();
            inventarLuk();
            {
                next3();
            }
        }
        if (zbraneL == "lovcovy kratke mece" || zbraneL == "kratke mece")
        {
            string INV;
            do
            {
                Console.Clear();
                Console.WriteLine("Nyní zobraz svůj inventář");
                INV = Convert.ToString(Console.ReadLine());
            } while (!(INV == "/inv"));
            meceVinventari();
            Console.WriteLine("");
            Console.WriteLine("Jak vidíš, zbraň se ti automaticky vložila do inventáře");
            Console.WriteLine("Avšak pokud chceš zbraň používat a  aktualizovat si svoje staty, musíš si ji NASADIT");
            Console.WriteLine("Nasadit zbraň si můžeš pomocí příkazu '/eq (název zbraně)'");
            string vybaveni;

            vybaveni = Convert.ToString(Console.ReadLine());
            do
            {
                if (vybaveni == "/eq lovcovy kratke mece" || vybaveni == "kratke mece")
                {

                }

            } while (!(vybaveni == "/eq lovcovy kratke mece" || vybaveni == "/eq kratke mece"));
            inventarP();
            inventarMece();
        }
        {
            next4();
        }
            return zbraneL;  
    }
    static void next1()
    {

        Console.WriteLine("Zmáčkni libovolné tlačítko");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Nyní, když už umíš základní příkazy, je na čase si vysvětlit pokročilejší mechaniky tj.  cestování a bojový systém");
        Console.WriteLine("Začněme cestováním!");
        cestovani();
        Console.WriteLine("");
        Console.WriteLine("A nyní bojový systém");
        Thread.Sleep(1000);
        BojovySystemWv1();


    }
    static void next2()
    {
        Console.WriteLine("Zmáčkni libovolné tlačítko");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Nyní, když už umíš základní příkazy, je na čase si vysvětlit pokročilejší mechaniky tj.  cestování a bojový systém");
        Console.WriteLine("Začněme cestováním!");
        cestovani();
        Console.WriteLine("");
        Console.WriteLine("A nyní bojový systém");
        Thread.Sleep(1000);
        BojovySystemWv2();
    }
    static void next3()
    {
        Console.WriteLine("Zmáčkni libovolné tlačítko");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Nyní, když už umíš základní příkazy, je na čase si vysvětlit pokročilejší mechaniky tj.  cestování a bojový systém");
        Console.WriteLine("Začněme cestováním!");
        cestovani();
        Console.WriteLine("");
        Console.WriteLine("A nyní bojový systém");
        Thread.Sleep(1000);
        BojovySystemHv1();
    }
    static void next4()
    {
        Console.WriteLine("Zmáčkni libovolné tlačítko");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Nyní, když už umíš základní příkazy, je na čase si vysvětlit pokročilejší mechaniky tj.  cestování a bojový systém");
        Console.WriteLine("Začněme cestováním!");
        cestovani();
        Console.WriteLine("");
        Console.WriteLine("A nyní bojový systém");
        Thread.Sleep(1000);
        BojovySystemHv2();
    }
    static void next5()
    {
        Console.WriteLine("Zmáčkni libovolné tlačítko");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Nyní, když už umíš základní příkazy, je na čase si vysvětlit pokročilejší mechaniky tj.  cestování a bojový systém");
        Console.WriteLine("Začněme cestováním!");
        cestovani();
        Console.WriteLine("");
        Console.WriteLine("A nyní bojový systém");
        Thread.Sleep(1000);
        BojovySystemMv1();
    }
    static void next6()
    {
        Console.WriteLine("Zmáčkni libovolné tlačítko");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Nyní, když už umíš základní příkazy, je na čase si vysvětlit pokročilejší mechaniky tj.  cestování a bojový systém");
        Console.WriteLine("Začněme cestováním!");
        cestovani();
        Console.WriteLine("");
        Console.WriteLine("A nyní bojový systém");
        Thread.Sleep(1000);
        BojovySystemMv2();
    }
    static void cestovani()
    {

            Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("Vždycky ti já, jako vypravěč (zeleně), nastíním situaci a popíši okolí");
        Console.WriteLine("Tvým jedniným úkolem, jako hrdina, je napsat co chceš udělat");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Bude-li barva žlutě, je to dialog od NPC");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("A pokud to bude Cyan barvou, v popisu/dialogu je něco důležité/klíčové");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(2500);
            Console.WriteLine("Dejme si příklad: ");
        Console.WriteLine("");
        Console.WriteLine("----------------------------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Jsi uprostřed velkého obilného pole");
            Thread.Sleep(2500);
        Console.WriteLine("Celý tvůj horizont pokrývá obilí");
            Thread.Sleep(2500);
        Console.WriteLine("Ale najednou si všimneš něčeho, co leží na zemi a zdánlivě vypadá jako člověk ...");
            Thread.Sleep(2500);
        Console.WriteLine("3x tečky na konci věty ukazují, že můžeš psát(A nyní napiš co uděláš)");
            Console.ForegroundColor = ConsoleColor.White;

            string dal;
        bool CoDal;
        do
        {
            dal = Convert.ToString(Console.ReadLine());
            if (dal == "jdi se podivat" || dal == "Jdi se podivat" || dal == "jdi blíž" || dal == "Jdi blíž" || dal == "jdi blíže" || dal == "Jdi blíže" || dal == "jdi bliz" || dal == "Jdi bliz" || dal == "prozkoumej to!" || dal == "Prozkoumej to!" || dal == "Prozkoumej to" || dal == "prozkoumej to" || dal == "Jdi se podívat" || dal == "jdi se podvíat" || dal == "jít se podívat" || dal == "Jít se podívat" || dal == "prohledat ho" || dal == "Prohledat ho" || dal == "Prohledat člověka" || dal == "prohledat tělo" || dal == "Prohledat tělo" || dal == "prozkoumat to")
            {
                Console.WriteLine("Rozhodl jsi se to prověřit a pomalu se přibližuješ");
                Console.WriteLine("Blíž a blíž");
                Console.WriteLine("Čím blíže jsi, tím více si začínáš uvědomovat, že ten člověk už není člověk, nýbrž jen kosti ... ozůstatky");
                CoDal = true;
            }
            if (dal == "Jít pryč" || dal == "jít pryč" || dal == "Jit pryc" || dal == "jit pryc" || dal == "utect" || dal == "Uteč" || dal == "uteč" || dal == "Utýct" || dal == "utýct" || dal == "Utyct" || dal == "utyct" || dal == "Utec" || dal == "utec" || dal == "Vratit se" || dal == "vratit se" || dal == "Jit pryc" || dal == "jit pryc" || dal == "jít pryč" || dal == "Jít pryč" || dal == "vrátit se" || dal == "Vrátit se" || dal == "jít dál" || dal == "Jít dál" || dal == "jít od toho dál" || dal == "Jít od toho dál" || dal == "jít od toho dále" || dal == "Jít od toho dále" || dal == "utéct" || dal == "utéct" || dal == "Utýct" || dal == "utýct")
            {
                Console.WriteLine("Rozhodl jsi se to neprověřit a vracíš se zpátky");
                CoDal = true;
            }
            if (dal == "/inv" || dal == "/stats")
            {
                Console.WriteLine("Nyní není možnost použít tento příkaz");
                CoDal = false;
            }
            else
            {
                CoDal = false;
            }
        } while (!(CoDal == true));
        Thread.Sleep(1000);


    }
    static void VysvetleniBojovyhoSystemu1()
    {
        Console.WriteLine("Dobře, nyní si představ, že jsi narazil na nějakou tu špatenku a není jiná možnost, než se s touto ztracenou duší vypořádat");
        Console.WriteLine("Jakmile uvidíš, kdo před tebou stojí, všímej si především tří hlavních bodů");
        Console.WriteLine("1) Svoje životy ---> Samozřejmě asi nejdůležitější věc v boji je neumřít ");
        Console.WriteLine("Jakmile ti životy, nebo dále zvané HP, klesnou na nul, popřípadě do záporných hodnot, umřeš a tím končí i tvá epická výprava");
        Console.WriteLine("2) Životy nepřítele ---> Stejně tak, jak pro tebe s úmrtím, to samé platí i pro nepřátele");
        Console.WriteLine("Jakmile uvidíš nepřítele, namísto cifer, označující jeho životy uvidíš '??? HP'");
        Console.WriteLine("To znamená, že o daném nepřítely nic nevíš a aby jsi tak napravil, musíš ho chvíli pozorovat !");
        Console.WriteLine("3) Vzdálenost ---> Odsud se odvíjí volba zbraně a třídy");
        Console.WriteLine("Samozřejmě jako válečník, s obrovskou sekerou dosahující až k tvé duté hlavě, si nebudeš držet takový odstup ,jako lovec s lukem a šípy");
        Console.WriteLine("");
        Console.ReadKey();
        Console.WriteLine("Bojuje se na kola, kde jeden tvůj pohyb sebere celé tvoje kolo a dává prostor pro nepřítelovu odpověď");
        Console.WriteLine("Souboj samotný se dělí do čtyřech možností, co podnikat během svého kola");
        Console.WriteLine("Základ úspěchu je pozorovat chvíli nepřítele ... Ať už se jedná o jeho rychlost pohybu, nebo slabiny");
        Console.WriteLine("Nikdy není na škodu obětovat pár svých kol, aby jsi o svém nepříteli zjistil více");
        Console.WriteLine("Druhá možnost je ustoupit, aby jsi získal odstup");
        Console.ReadKey();
        Console.WriteLine("Třetí možnost je uskočit útoku, nebo popřípadě vykrýt útok ... Opět závisý na třídě, páč jako mág s dřevěnou holí nevykryjete tolik, jako válečník s železným štítem štítem");
        Console.WriteLine("Zde skvěle fungují tvoje statistiky ... obratnost se používá na úskok a úhyb ... výdrž na vykrytí útoků ...");
        Console.WriteLine("Poslední, čtvrtou, možností je zaútočit ... Samozřejmě jak jinač chceš vyhrát souboj, když nebudeš útočit");
        Console.WriteLine(" Zde funguje síla, jako silný útok z krátke vzdálenosti, čím větší síla, tím větší šance na kritický zásah a větší poškození ... Obratnost na útok ze střední vzdálenosti a rychlé a slabé útoky z krátké vzdálenosti ... Inteligence na útoky z velké dálky");
        Console.ReadKey();
    }
    static void BojovySystemWv1()
    {
        VysvetleniBojovyhoSystemu1();
        Random nh = new Random();

        int cislo = nh.Next(1, 2);
        if (cislo == 1)
        {
            Console.WriteLine("Zlý trol");
            ZlyTrolFightWv1lvl1();
        }
        if (cislo == 2)
        {
            Console.WriteLine("Slimák");
        }
        if (cislo == 3)
        {
            Console.WriteLine("Beznadějný bandita");
        }
        if (cislo == 4)
        {
            Console.WriteLine("Vyplašený vlk");
        }
        if (cislo == 5)
        {
            Console.WriteLine("Žijící Zombie");
        }
        if (cislo == 6)
        {
            Console.WriteLine("Hydra");
        }
        if (cislo == 7)
        {
            Console.WriteLine("Banší");
        }
        if (cislo == 8)
        {
            Console.WriteLine("Silný slimák");
        }
        if (cislo == 9)
        {
            Console.WriteLine("Nechtěné mládě draka");
        }
        if (cislo == 10)
        {
            Console.WriteLine("Drak");
        }

    }
    static void BojovySystemWv2()
    {
        VysvetleniBojovyhoSystemu1();
        Random nh = new Random();
        int cislo = nh.Next(1, 2);
        if (cislo == 1)
        {
            Console.WriteLine("Zlý trol");
            ZlyTrolFightWv2lvl1();
        }
    }
    static void BojovySystemHv1()
    {
        VysvetleniBojovyhoSystemu1();
        Random nh = new Random();
        int cislo = nh.Next(1, 2);
        if (cislo == 1)
        {
            Console.WriteLine("Zlý trol");
            ZlyTrolFightHv1lvl1();
        }
    }
    static void BojovySystemHv2()
    {
        VysvetleniBojovyhoSystemu1();
        Random nh = new Random();
        int cislo = nh.Next(1, 2);
        if (cislo == 1)
        {
            Console.WriteLine("Zlý trol");
            ZlyTrolFightHv2lvl1();
        }
    }
    static void BojovySystemMv1()
    {
        VysvetleniBojovyhoSystemu1();
        Random nh = new Random();
        int cislo = nh.Next(1, 2);
        if (cislo == 1)
        {
            Console.WriteLine("Zlý trol");
            ZlyTrolFightMv1lvl1();
        }
    }
    static void BojovySystemMv2()
    {
        VysvetleniBojovyhoSystemu1();
        Random nh = new Random();
        int cislo = nh.Next(1, 2);
        if (cislo == 1)
        {
            Console.WriteLine("Zlý trol");
            ZlyTrolFightMv2lvl1();
        }
    }
    static void FightBlizkaV1()
    {
        int zivoty = 280;
            int zivotyMax = 280;
            int zivotyN = 40;
            int zivotyNMax = 40;
        int cislo1 = 0;
        int poskozeniS = -42;
        int poskozeniR = -42 / 2;
        int poskozeniN = -15;
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
                            if (reakce2 == 1 || reakce2 == 3 || reakce2 == 4)
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
    static void FightBlizkaV2()
    {
        int zivoty = 250;
        int zivotyMax = 250;
        int zivotyN = 40;
        int zivotyNMax = 40;
        int cislo1 = 0;
        int poskozeniS = -17;
        int poskozeniR = -17 / 2;
        int poskozeniN = -15;
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
                                if (reakce == 1 || reakce == 3 || reakce == 4)
                                {
                                    Console.WriteLine("Nepřítel minul a jsi na tahu");
                                }
                                if (!(reakce == 1 || reakce == 3 || reakce == 4) && zivotyN > 0)
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
                                if (!(reakce2 == 1 || reakce2 == 3 || reakce2 == 4) && zivotyN > 0)
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
    }
    static void FightBlizkaV3()
        {
            int zivotyMax = 160;
            int zivoty = 160;
            int manaMax = 10;
            int mana = 10;
            int vydrz = 50 + 5;
            int sila = 10;
            int obratnost = 60;
            int inteligence = 32;
            int zivotyN = 40;
            int zivotyNMax = 40;
            int cislo1 = 0;
            int poskozeniS = -10;
            int poskozeniR = -10 / 2;
            int poskozeniN = -15;
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
                                if (reakce == 1 || reakce == 3 || reakce == 4)
                                {
                                    Console.WriteLine("Nepřítel minul a jsi na tahu");
                                }
                                if (!(reakce == 1 || reakce == 3 || reakce == 4) && zivotyN > 0)
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
                                if (!(reakce2 == 1 || reakce2 == 3 || reakce2 == 4) && zivotyN > 0)
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
        }
    static void FightStredniV1()
    {
        int zivoty = 200;
            int zivotyMax = 200;
            int zivotyNMax = 40;
        int zivotyN = 40;
        int cislo1 = 0;
        int poskozeniR = -20;
        int poskozeniM = -40;
        int poskozeniN = -15;
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
                    if (cislo2 == 1 || cislo2 == 3 || cislo2 == 4)
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
                    break;
                default:
                    Console.WriteLine("Neplatná akce");
                    break;
            }

        } while (zivotyN >= 0 || zivoty >= 0);
    }
    static void FightStredniV2()
    {
        int zivoty = 170;
            int zivotyMax = 170;
        int manaMax = 45;
        int mana = 45;
        int zivotyN = 40;
            int zivotyNMax = 40;
        int cislo1 = 0;
        int poskozeniR = -4;
        int poskozeniM = -8;
        int poskozeniN = -15;
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
                        if (cislo1 == 2 || cislo1 == 3) ;
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
                            if (reakce == 1 || reakce == 3 || reakce == 4)
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
                        if (reakce == 1 || reakce == 3 || reakce == 4)
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
    }
    static void FightDalky1()
    {
        int zivoty = 170;
            int zivotyMax = 0;
        int manaMax = 65;
        int mana = 65;
        //int inteligence = 57;
        int zivotyN = 40;
            int zivotyNMax = 40;
        int cislo1 = 0;
        int poskozeniN = -15;
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
    }

    static void ZlyTrolFightWv1lvl1()
    {
        Console.Clear();
        Console.WriteLine("Zvol jednu ze tří možností ('utok z dalky' ; 'utok ze stredni' ; 'utok z blizka' ");
        bool test = false;
        string akce;
        do
        {
            akce = Convert.ToString(Console.ReadLine());
            switch (akce)
            {
                case "utok z dalky":
                    test = false;
                    Console.WriteLine("Nelze provést útok z dálky, páč nemáš na to potřebné vybavení !");
                    break;
                case "utok ze stredni":

                    Console.WriteLine("Nelze provést útok ze střední vzdálenosti, páč nemáš na to potřebné vybavení !");
                    test = false;
                    break;
                case "utok z blizka":
                    FightBlizkaV1();
                    test = true;
                    break;
                default:
                    Console.WriteLine("Nesprávný příkaz !");
                    test = false;
                    break;

            }
        } while (test == false);
    }
    static void ZlyTrolFightWv2lvl1()
    {
        Console.Clear();
        Console.WriteLine("Zvol jednu ze tří možností ('utok z dalky' ; 'utok ze stredni' ; 'utok z blizka' ");
        bool test = false;
        string akce;
        do
        {
            akce = Convert.ToString(Console.ReadLine());
            switch (akce)
            {
                case "utok z dalky":
                    test = false;
                    Console.WriteLine("Nelze provést útok z dálky, páč nemáš na to potřebné vybavení !");
                    break;
                case "utok ze stredni":

                    Console.WriteLine("Nelze provést útok ze střední vzdálenosti, páč nemáš na to potřebné vybavení !");
                    test = false;
                    break;
                case "utok z blizka":
                    FightBlizkaV2();
                    test = true;
                    break;
                default:
                    Console.WriteLine("Nesprávný příkaz !");
                    test = false;
                    break;
            }
        } while (test == false);
    }
    static void ZlyTrolFightHv1lvl1()
    {
        Console.Clear();
        Console.WriteLine("Zvol jednu ze tří možností ('utok z dalky' ; 'utok ze stredni' ; 'utok z blizka' ");
        bool test = false;
        string akce;
        do
        {
            akce = Convert.ToString(Console.ReadLine());
            switch (akce)
            {
                case "utok z dalky":
                    test = false;
                    Console.WriteLine("Nelze provést útok z dálky, páč nemáš na to potřebné vybavení !");
                    break;
                case "utok ze stredni":
                    FightStredniV1();
                    test = true;
                    break;

                case "utok z blizka":
                    Console.WriteLine("Nelze provést útok z blízka, páč nemáš na to potřebné vybavení !");

                    test = false;
                    break;
                default:
                    Console.WriteLine("Nesprávný příkaz !");
                    test = false;
                    break;

            }
        } while (test == false);
    }
    static void ZlyTrolFightHv2lvl1()
    {
        Console.Clear();
        Console.WriteLine("Zvol jednu ze tří možností ('utok z dalky' ; 'utok ze stredni' ; 'utok z blizka' ");
        bool test = false;
        string akce;
        do
        {
            akce = Convert.ToString(Console.ReadLine());
            switch (akce)
            {
                case "utok z dalky":
                    test = false;
                    Console.WriteLine("Nelze provést útok z dálky, páč nemáš na to potřebné vybavení !");
                    break;
                case "utok ze stredni":

                    Console.WriteLine("Nelze provést útok ze střední vzdálenosti, páč nemáš na to potřebné vybavení !");
                    test = false;
                    break;
                case "utok z blizka":
                    FightBlizkaV3();
                    test = true;
                    break;
                default:
                    Console.WriteLine("Nesprávný příkaz !");
                    test = false;
                    break;

            }
        } while (test == false);
    }
    static void ZlyTrolFightMv1lvl1()
    {
        Console.Clear();
        Console.WriteLine("Zvol jednu ze tří možností ('utok z dalky' ; 'utok ze stredni' ; 'utok z blizka' ");
        bool test = false;
        string akce;
        do
        {
            akce = Convert.ToString(Console.ReadLine());
            switch (akce)
            {
                case "utok z dalky":
                    test = false;
                    FightDalky1();
                    break;
                case "utok ze stredni":
                    Console.WriteLine("Nelze provést útok ze střední, páč nemáš na to potřebné vybavení !");
                    test = true;
                    break;

                case "utok z blizka":
                    Console.WriteLine("Nelze provést útok z blízka, páč nemáš na to potřebné vybavení !");

                    test = false;
                    break;
                default:
                    Console.WriteLine("Nesprávný příkaz !");
                    test = false;
                    break;

            }
        } while (test == false);
    }
    static void ZlyTrolFightMv2lvl1()
    {
        Console.Clear();
        Console.WriteLine("Zvol jednu ze tří možností ('utok z dalky' ; 'utok ze stredni' ; 'utok z blizka' ");
        bool test = false;
        string akce;
        do
        {
            akce = Convert.ToString(Console.ReadLine());
            switch (akce)
            {
                case "utok z dalky":
                    test = false;
                    Console.WriteLine("Nelze provést útok z dálky, páč nemáš na to potřebné vybavení !");
                    break;
                case "utok ze stredni":
                    FightStredniV2();
                    test = true;
                    break;

                case "utok z blizka":
                    Console.WriteLine("Nelze provést útok z blízka, páč nemáš na to potřebné vybavení !");

                    test = false;
                    break;
                default:
                    Console.WriteLine("Nesprávný příkaz !");
                    test = false;
                    break;

            }
        } while (test == false);
    }

    static string Kapitola1(string x)
    {
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Jorald (velitel stráží): 'Vítej {0}, slyšel jsem, že jsi byl jeden z nejlepších ve svém ročníku ...'", x);
        Console.ReadKey();
        Console.WriteLine("Jorald: 'Nic moc mi k tomu neřekneš hm?'");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Jorald: 'Každopádně víš, jak to u nás chodí ...'");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Jorald: 'Aby jsi splnil poslední zkoušku a stal se jedním z nás, budeš muset, jak už jistě tušíš, prozkoumat zdejší krajiny'");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Jorald: 'Jasně, asi to nebude úplně jednoduché, obvzláště na začátku, ale vez že praxe je nejlepší způsob učení'");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Jorald: 'Sice tě tam ve škole naučili, jak držet zbraň a různé tyhle základní věci, ale co z toho, když to nebudeš umět požívat v praxi ??'");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("Jorald: 'Každopádně zítra brzy ráno vyjíždíme, tak když už nic, tak si aspoň pořádně odpočiň !'");
        Console.ReadKey();
        Console.WriteLine("");
        Console.WriteLine("//                     Velitel zavřel za sebou dveře a nechal tě samotného ve své komnatě                       //");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Tvá komnata je málá místonst do kruhu ... Není moc velká, ale aspoň postel a malá skříňka se sem vešli ...");
        Console.WriteLine("Ve skříňce vidíš jeden šuplík, a na šuplíku je položená zapálená svíčka ...");
        Console.WriteLine("Co uděláš ?");

        bool testKomnaty;
        do
        {
            string komnata1 = Convert.ToString(Console.ReadLine());
            if (komnata1 == "Podívat se do šuplíku" || komnata1 == "kouknout do šuplíku" || komnata1 == "podivat se do supliku" || komnata1 == "kouknout do suplíku" || komnata1 == "Podivat se do supliku" || komnata1 == "Kouknout do supliku")
            {
                Console.WriteLine("Zkoušíš otevřít šuplík, ale je zamčený");
                testKomnaty = false;
            }
            if (komnata1 == "Zhasnout svíčku" || komnata1 == "zhasnout svíčku" || komnata1 == "Zhasnout svicku" || komnata1 == "zhasnout svicku")
            {
                Console.WriteLine("Zhasnul jsi svíčku a celá komnata se zatemnila");
                testKomnaty = false;
            }
            if (komnata1 == "Jít spát" || komnata1 == "jít spát" || komnata1 == "jit spat" || komnata1 == "jit spat" || komnata1 == "ulehnout" || komnata1 == "Ulehnout" || komnata1 == "usnout" || komnata1 == "Usnout")
            {
                Console.WriteLine("Položil jsi si hlavu na polštář, zavřel oči a tvrdě usnul");
                testKomnaty = true;
                    break;
            }
        } while (testKomnaty = true);

        return x;
    }
        static void Animace()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("         |||||                 |||||                   |||||            |||||");
            Console.WriteLine("         |||||                 ||||||||||||||            ||||             ||||");
            Console.WriteLine("         |||||                 |||||                     ||||             ||||");
            Console.WriteLine("         |||||                 |||||              |||    ||||     |||     ||||");
            Console.WriteLine("         ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Thread.Sleep(500);
            Console.Clear();



            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("________ |||||                 |||||                   |||||            |||||");
            Console.WriteLine("_________|||||                 ||||||||||||||            ||||             ||||");
            Console.WriteLine("________ |||||                 |||||                     ||||             ||||");
            Console.WriteLine("         |||||                 |||||              |||    ||||     |||     ||||");
            Console.WriteLine("         ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");

            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("_________|||||____             |||||                   |||||            |||||");
            Console.WriteLine("_________|||||_____            ||||||||||||||            ||||             ||||");
            Console.WriteLine("_________|||||____             |||||                     ||||             ||||");
            Console.WriteLine("         |||||                 |||||              |||    ||||     |||     ||||");
            Console.WriteLine("         ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");

            Thread.Sleep(500);


            Console.Clear();



            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("_________|||||_________________|||||_                 |||||            |||||");
            Console.WriteLine("_________|||||_________________||||||||||||||            ||||             ||||");
            Console.WriteLine("_________|||||_________________|||||_                    ||||             ||||");
            Console.WriteLine("         |||||                 |||||              |||    ||||     |||     ||||");
            Console.WriteLine("         ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");


            Thread.Sleep(500);

            Console.Clear();

            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("_________|||||_________________|||||________________   |||||            |||||");
            Console.WriteLine("_________|||||_________________||||||||||||||________    ||||             ||||");
            Console.WriteLine("_________|||||_________________|||||________________     ||||             ||||");
            Console.WriteLine("         |||||                 |||||              |||    ||||     |||     ||||");
            Console.WriteLine("         ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");


            Thread.Sleep(500);

            Console.Clear();


            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("_________|||||_________________|||||___________________|||||            |||||");
            Console.WriteLine("_________|||||_________________||||||||||||||____________||||_            ||||");
            Console.WriteLine("_________|||||_________________|||||_____________________||||             ||||");
            Console.WriteLine("         |||||                 |||||              |||    ||||     |||     ||||");
            Console.WriteLine("         ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");

            Thread.Sleep(500);


            Console.Clear();

            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("_________|||||_________________|||||___________________|||||______      |||||");
            Console.WriteLine("_________|||||_________________||||||||||||||____________||||______       ||||");
            Console.WriteLine("_________|||||_________________|||||_____________________||||_____        ||||");
            Console.WriteLine("         |||||                 |||||              |||    ||||     |||     ||||");
            Console.WriteLine("         ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");


            Thread.Sleep(500);


            Console.Clear();


            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("_________|||||_________________|||||___________________|||||____________|||||");
            Console.WriteLine("_________|||||_________________||||||||||||||____________||||_____________||||");
            Console.WriteLine("_________|||||_________________|||||_____________________||||_____________||||");
            Console.WriteLine("         |||||                 |||||              |||    ||||     |||     ||||");
            Console.WriteLine("         ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");

            Thread.Sleep(500);


            Console.Clear();

            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("         |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("_________|||||_________________|||||___________________|||||____________|||||");
            Console.WriteLine("_________|||||_________________||||||||||||||____________||||_____________||||_");
            Console.WriteLine("_________|||||_________________|||||_____________________||||_____________||||");
            Console.WriteLine("         |||||                 |||||              |||    ||||     |||     ||||");
            Console.WriteLine("         ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");

            Thread.Sleep(500);


            Console.Clear();

            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("     X   |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("    X    |||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("===X_____|||||_________________|||||___________________|||||____________|||||_____ ");
            Console.WriteLine("===X_____|||||_________________||||||||||||||____________||||____________||||______");
            Console.WriteLine("===X_____|||||_________________|||||_____________________||||____________||||_____");
            Console.WriteLine("    X    |||||                 |||||              |||    ||||     |||    ||||");
            Console.WriteLine("     X   ||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");


            Thread.Sleep(500);




            Console.Clear();


            Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||     ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      ||||||||||||||      ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||               ");
            Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      ||||||||||||||     ");
            Console.WriteLine("");
            Console.WriteLine("         |||||                 |||||||||||||||       |||||||         |||||||  ");
            Console.WriteLine("         |||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("        X|||||                 |||||               ||||    |||     ||||    |||");
            Console.WriteLine("        X|||||                 |||||               ||||||          ||||||     ");
            Console.WriteLine("=======X_|||||_________________|||||___________________|||||____________|||||_______ ");
            Console.WriteLine("=======X_|||||_________________||||||||||||||____________||||____________||||_________");
            Console.WriteLine("=======X_|||||_________________|||||_____________________||||____________||||________");
            Console.WriteLine("        X|||||                 |||||              |||    ||||     |||    ||||");
            Console.WriteLine("        X||||||||||||||        |||||              |||   ||||      |||    |||| ");
            Console.WriteLine("         ||||||||||||||        ||||||||||||||      ||||||||        ||||||||");
            Console.WriteLine("  ");
            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.White;

        }
        }
}
