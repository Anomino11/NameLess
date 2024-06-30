using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {


        static void Main(string[] args)
        {
            {
                Console.WriteLine("  ");
                Console.WriteLine("     |||||||               |||||||            |||||||   |||||||          |||||||||||||||");
                Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||          ");
                Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||          ");
                Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||          ");
                Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||          ");
                Console.WriteLine("|||||       |||||     |||||||||||||||||     |||||    |||||    |||||      |||||||||||||| ");
                Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||          ");
                Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||          ");
                Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||          ");
                Console.WriteLine("|||||       |||||     |||||       |||||     |||||    |||||    |||||      |||||||||||||||");
                Console.WriteLine("");
            }
            int pokus;
            int pokus2;

            int pokus3;
            int pokus4;
            int pokus5;
            int pokus6;
            int pokus7;
            int pokus8;
            string jmeno;
            string zbrane;
            string zbraneM;
            string zbraneL;
            string moznost1;
            string moznost2;
            string moznost3;
            string moznost4;
            string moznost5;
            string moznost6;

            string inv;
            bool test;
            bool test2;
            bool test3;
            bool test4;

            Console.WriteLine("Vítej ve světě mladý hrdino.");
            Console.WriteLine("Řekni mi své jméno: ");
            jmeno = Convert.ToString(Console.ReadLine());


            Console.WriteLine("{0},jakou třídou jsi se vyučil?", jmeno);
            //Console.WriteLine("'valecnik' / 'mag' / 'lovec'");

            //string trida = Console.ReadLine();
            {
                do
                {
                    Console.WriteLine("'valecnik' / 'mag' / 'lovec'");
                    string trida = Console.ReadLine();

                    switch (trida)

                    {

                        case "valecnik":
                            //   Console.WriteLine("Zvolil jsi třídu Válečník");
                            trida = "valecnik";
                            test = true;
                            break;

                        case "mag":
                            // Console.WriteLine("Zvolil jsi třídu Mág");

                            trida = "mag";
                            test = true;
                            break;
                        case "lovec":
                            trida = "lovec";
                            //Console.WriteLine("Zvolil jsi třídu Lovec");
                            test = true;

                            break;
                        default:
                            Console.WriteLine("Neplatná třída, zkus to znova");
                            test = false;
                            break;

                            //alt 124 |
                    }
                }

                while (test == false); //(!(test == true));
                {
                }
                Console.Clear();
                Console.WriteLine("Určitě ?");
                Console.WriteLine("Takových je tu plno ...");
                Console.WriteLine("Potvrď zadáním role ještě jednou");
                string trida2 = Convert.ToString(Console.ReadLine());
                if (trida2 == "valecnik")
                {
                    Console.WriteLine("Zvolil jsi třídu Válečník");
                }
                if (trida2 == "mag")
                {
                    Console.WriteLine("Zvolil jsi třídu mág");
                }
                if (trida2 == "lovec")
                {
                    Console.WriteLine("Zvolil jsi třídu Lovec");
                }
                /* else
                 {
                     Console.WriteLine("Neplatná třída");
                 }*/
                // Console.WriteLine("Aha, takže  huh ?");
                //Console.WriteLine("Těch je tu plno, tak uvidíme, jestli se od nich nějakým způsobem odlišíš");
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

                {
                    if (help == "ano")
                    {
                        Console.WriteLine("Pomocí příkazu '/inv' si můžeš zobrazit svůj čuprovej inventář");
                    }

                    if (help == "ne")
                    {
                        Console.WriteLine("Dobrá tedy, ");
                    }

                    moznost1 = Convert.ToString(Console.ReadLine());

                    if (moznost1 == "/inv")
                    {
                        //inventarP();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Jasně, zatím tady nic není, ale ty se divíš ??");
                        Console.WriteLine("Neboj, za chvíli budeš mít možnost to napravit !");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }

                    //   string tridaV; 

                    if (trida2 == "valecnik")
                    {
                        Console.WriteLine("Svoje staty si můžeš zobrazit kdykoliv příkazem '/stats'");
                        Console.ReadLine();
                        Console.WriteLine("                                                                               Válečník: lvl {0}");
                        Console.WriteLine("                                                                               Životy: 250/250 HP");
                        Console.WriteLine("                                                                               Mana: 10/10 MP");
                        Console.WriteLine("                                                                               Výdrž: 30 ");
                        Console.WriteLine("                                                                               Síla: 32 ");
                        Console.WriteLine("                                                                               Obratnost: 7 ");
                        Console.WriteLine("                                                                               Inteligence: 22 ");
                        Console.WriteLine();
                        Console.WriteLine("Nyní budeš mít možnost zvolit si jednu ze dvou zbraní");
                        Console.WriteLine("Chceš-li vidět staty, které vám daná zbraň přidá, zadejte příkaz '/stats' (název zbraně)");
                        Console.WriteLine("Stiskni ENTER");


                        Console.ReadLine();
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

                            //sekera1();
                            Console.WriteLine("");
                        }
                        /*if (mec == "mec broadsword" || mec == "broadsword")
                        {
                            inventarMec();
                        }
                        if (mec == "/stats mec broadsword")
                        {

                        }*/

                    }




                }
                if (trida2 == "mag")
                {

                    Console.WriteLine("Svoje staty si můžeš zuobrazit kdykoliv příkazem '/stats'");
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
                    Console.ReadLine();
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
                    }

                    do
                    {
                        zbraneM = Convert.ToString(Console.ReadLine());

                        if (zbraneM == "/stats hul novice")
                        {
                            Console.WriteLine("Mana: +15 MP");
                            Console.WriteLine("Výdrž -2");
                            Console.WriteLine("Inteligence: +8");
                        }
                        if (zbraneM == "/stats kuchynske vrhaci noze")
                        {
                            Console.WriteLine("Výdrž: +5");
                            Console.WriteLine("Obratnost: +7 ");
                            Console.WriteLine("Mana: -5 MP");
                        }
                        switch (zbraneM)
                        {
                            case "hul novice":
                                zbraneM = "hul novice";

                                test3 = true;
                                break;

                            case "kuchynske vrhaci noze":
                                zbraneM = "kuchynske vrhaci noze";
                                test3 = true;
                                break;

                            default:

                                test3 = false;
                                break;
                        }
                    } while (!(test3 == true));

                }
                if (trida2 == "lovec")
                {
                    // Console.WriteLine("Po stisknutí ENTER budeš vidět svoje staty na pravé straně");
                    Console.WriteLine("Svoje staty si můžeš zuobrazit kdykoliv příkazem '/stats'");
                    Console.ReadLine();
                    Console.WriteLine("                                                                               Lovec: lvl {0}");
                    Console.WriteLine("                                                                               Životy: 200/200 HP");
                    Console.WriteLine("                                                                               Mana: 10/10 MP");
                    Console.WriteLine("                                                                               Výdrž: 50 ");
                    Console.WriteLine("                                                                               Síla: 10 ");
                    Console.WriteLine("                                                                               Obratnost: 35 ");
                    Console.WriteLine("                                                                               Inteligence: 32 ");
                    Console.WriteLine("Nyní budeš mít možnost zvolit si jednu ze dvou zbraní");
                    Console.WriteLine("Chceš-li vidět staty, které vám daná zbraň přidá, zadejte příkaz '/stats' (název zbraně)");

                    Console.ReadLine();
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

                    }
                    do
                    {
                        zbraneL = Convert.ToString(Console.ReadLine());

                        if (zbraneL == "/stats supacky luk a sipy")
                        {
                            Console.WriteLine("Výdrž: +14");
                            Console.WriteLine("Obratnost: +5");
                            Console.WriteLine("Inteligence: - 5");

                        }
                        if (zbraneL == "/stats lovcovy kratke mece")
                        {
                            Console.WriteLine("Životy: -40 HP");
                            Console.WriteLine("Výdrž: +5");
                            Console.WriteLine("Obratnost: +25");
                        }
                        switch (zbraneL)
                        {
                            case "supacky luk a sipy":
                                zbraneL = "supacky luk a sipy";

                                test4 = true;
                                break;

                            case "lovcovy kratke mece":
                                zbraneL = "lovcovy kratke mece";
                                test4 = true;
                                break;

                            default:

                                test4 = false;
                                break;
                        }
                    } while (!(test4 == true));

                }

            }


        }
        static void inventarV1()
        {
            Console.WriteLine("_________________^ ______^^^^^__________________________________________________________________________");
            Console.WriteLine("|---------------/ /______|   |-----|---------------------------------|---------------------------------|");
            Console.WriteLine("|--------------/             |-----|---------------------------------|---------------------------------| ");
            Console.WriteLine("|-------------/       1      |-----|---------------------------------|---------------------------------|                                                                     ");
            Console.WriteLine("|------------/       1       |-----|---------------------------------|---------------------------------|                                                                               ");
            Console.WriteLine("|------------/      1        |-----|---------------------------------|---------------------------------|                                                                             ");
            Console.WriteLine("|-------------/    1         |-----|---------------------------------|---------------------------------|                             ");
            Console.WriteLine("|--------------/   _____     |-----|---------------------------------|---------------------------------|                                                                 ");
            Console.WriteLine("|---------------/ /-----|    |-----|---------------------------------|---------------------------------|                                                                                 ");
            Console.WriteLine("|-----------------------|    |-----|---------------------------------|---------------------------------|                                                                                    ");
            Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|                                                                               ");
            Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|                                                                                   ");
            Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|                                                                                ");
            Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|                                                                                       ");
            Console.WriteLine("|-----------------------|----|-----|---------------------------------|---------------------------------|                                                                                    ");
            Console.WriteLine("|-----------------------|____|-----|---------------------------------|---------------------------------| ");
            Console.WriteLine("|-----------------------|____|-----|---------------------------------|---------------------------------|");
            Console.WriteLine("|__________________________________|_________________________________|_________________________________|                               ");

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
        static int statyWv1()
        {
            int zivotyMax = 280;
            int zivoty = 280;
            int manaMax = 10;
            int mana = 10;
            int vydrz = 30;
            int sila = 37;
            int obratnost = 5;
            int inteligence = 22;

            /*zivotyMax = 280;
            zivoty = 280;
            manaMax = 10;
            mana = 10;
            vydrz = 30;
            sila = 37;
            obratnost = 5;
            inteligence = 22;
            */
            Console.ReadLine();
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
        static void inventarMec()
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
            Console.WriteLine("|@XX/XX/X|{::::::*::::::::::::::::>|---------------------------------|---------------------------------|---------------------------------|");
            Console.WriteLine("|---------|------------------------|---------------------------------|---------------------------------|");
            Console.WriteLine("|---------[------------------------|---------------------------------|---------------------------------|");
            Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
            Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
            Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
            Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
            Console.WriteLine("|----------------------------------|---------------------------------|---------------------------------|");
            Console.WriteLine("|__________________________________|_________________________________|_________________________________|");
        }
        static void inventarSekera(string volbaZbrane)

        {
            string invV1;
            string staty;
            string battlefury;
            bool test5;
            // volbaZbrane = Convert.ToString(Console.ReadLine());
            if (volbaZbrane == "sekera battlefury")
            {
                Console.WriteLine("Nyní si zobraz inevntář");
                invV1 = Convert.ToString(Console.ReadLine());
                if (invV1 == "/inv")
                {
                    inventarV1();
                }
                Console.WriteLine("");
                Console.WriteLine("Jak vidíš, zbraň se ti automaticky vložila do inventáře");
                Console.WriteLine("Avšak pokud chceš zbraň používat a  aktualizovat si svoje staty, musíš si ji NASADIT");
                Console.WriteLine("Nasadit zbraň si můžeš pomocí příkazu '/eq (název zbraně)'");
                string vybaveni;
                vybaveni = Convert.ToString(Console.ReadLine());
                if (vybaveni == "/eq sekera battlefury")
                {

                    inventarP();
                    Console.WriteLine("Jak vidíš, zbraň zmizela z inventáře a aktualizovala tvoje staty");
                    Console.WriteLine("Pamatuj ! Aktivní zbraň můžeš mít pouze JEDNU");
                    Console.WriteLine("Nyní, pokud se chceš přesvědčit o svých statech, použíj příkaz");
                }
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
    }
}


        

