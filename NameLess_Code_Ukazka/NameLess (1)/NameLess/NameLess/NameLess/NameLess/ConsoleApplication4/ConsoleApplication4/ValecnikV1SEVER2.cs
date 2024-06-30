using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{
    class ValecnikV1SEVER2
    {

        public ValecnikV1SEVER2(string jmeno, byte poprve, byte VelkyStrom, byte ProzkoumavaniVelkehoStromu, byte rozhlednuti, byte PoprveLouka, byte prozkoumaniSstr, byte lezeni, byte pochod, byte zapad, byte sever, byte vedomostiBrany, byte Prvni, byte Druha, byte Treti, byte Odchazi, byte zjisteni, byte pojistkaM, byte PouzeJednou, byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran, byte pozice, byte NovaKonverzace)
        {
            pozice = 3;
            if (VelkyStrom == 0)
            {
                popis();
                Akce(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
            }
            if (VelkyStrom == 1 && ProzkoumavaniVelkehoStromu == 1)
            {
                popis2();
                Akce2(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);

            } 
        }
        static void popis()
        {
            Console.Clear();
            Console.WriteLine("Kráčíš hlubokým lesem, ale už si nejsi ani jistý, jestli jdeš pořád rovně");
            Thread.Sleep(2500);
            Console.WriteLine("Najednou zakopneš o vyčnívající kořen a spadneš před velkou kulatou část, někde v lese, Kde jsou dva na první pohled normální stromy");
            Thread.Sleep(2500);
            Console.WriteLine("Ale uprotřed je obří strom, ve tvaru ... HLAVY ??");
            Thread.Sleep(2500);
            Console.WriteLine("Co je ale mnohem zajímavější je to, že místo, kde by byla 'ústa' u toho stromu je jakýsi vchod do temné místnosti");
            Thread.Sleep(2500);
            Console.WriteLine("Každopádně vidíš, že i na východě, i na severu už končí les a vede na jakousi planinu ...");
        }
        static void popis2()
        {
            Console.Clear();
            Console.WriteLine("Procházíš hustýmn lesem, ale zdá se ti to tu povědomé");
            Thread.Sleep(2500);
            Console.WriteLine("Najendou uvidíš velkou kulatou 'nelestnatou část' se dvěma normálníma stromama a uprostřed s velkým stromem ve vtaru s obličejem");
            Thread.Sleep(2500);
            Console.WriteLine("A před těma stromama vidíš mrtvé tělo netopýra, kterého jsi zabil");
            Thread.Sleep(2500);
            Console.WriteLine("Každopádně vidíš, že i na východě, i na severu už končí les a vede na jakousi planinu ...");
        }
        static void popisPoTruhle()
        {
            Console.WriteLine("Cítíš se nyní vážně mocně a držíš v rukou 'zlaté jablko' a uvažuješ k čemu by asi mohlo být");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Získáváš jablko hříchů a ukládáš ho do inventáře!");
            Thread.Sleep(2500);
            Console.WriteLine("//Zmáčni libovolné tlačítko//");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(1500);
            Console.WriteLine("Vycházíš ven z 'jeskyně' a vidíš, že  na východě a na severu už končí les a vede na jakousi planinu, zatímco na jihu od tebe je zase les ...");
            Thread.Sleep(2500);


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
                    //planina
                    ValecnikV1SEVER3_VYCHOD vj = new ValecnikV1SEVER3_VYCHOD(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    test1 = true;
                }
                if (akce1 == "jdi na vychod" || akce1 == "jdi na východ")
                {
                    //planina
                    ValecnikV1SEVER3_VYCHOD vj = new ValecnikV1SEVER3_VYCHOD(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);

                    test1 = true;
                }
                if (akce1 == "jdi na zapad" || akce1 == "jdi na západ")
                {
                    //smrt
                    test1 = true;
                }
                if (akce1 == "jdi na jih")
                {
                    //zpatky
                    ValecnikV1SEVER1 zakladKapitola3 = new ValecnikV1SEVER1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    test1 = true;
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
                    tw.Close();
                    test1 = false;
                    //     , byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran)
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tvá hra je uložena ...");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                if ((akce1 == "podivej se dovnitr" || akce1 == "prozkoumej to" || akce1 == "jdi dovnitr" || akce1 == "vlez dovnitr" || akce1 == "vstoupit" || akce1 == "prozkoumat" || akce1 == "vstoupit dovnitr" || akce1 == "prozkoumat to") && VelkyStrom == 0)
                {
                    
                   
                    Console.WriteLine("Rozhodl jsi se vstoupit dovnitř a prozkoumat to");
                    Thread.Sleep(2500);
                    Console.WriteLine("Hned po příchodu dovnitř jsi až žasl, jak se zprvu velká temná místnost proměnila na malou útulnou skrýš, kde se uvnitř nachází truhla ...");
                    Thread.Sleep(2500);
                    Console.WriteLine("Mám otevřít truhlu, nebo se vrátit ? ...");
                    string akce2 = Convert.ToString(Console.ReadLine());
                    if (akce2 == "otevri truhlu" || akce2 == "prozkoumej truhlu" || akce2 == "otervi to" || akce2 == "koukni se dovnitr" || akce2 == "prozkoumat to" || akce2 == "otevri ji")
                    {

                        Console.WriteLine("Otevřel jsi truhlu, která překvapivě nebyla začená, ale během vteřiny jsi pochopil proč, páč to co se ukrývalo uvnitř, střežilobří červený 'pradávný' netopýr, který se nekompromisně na tebe vrhnul !!!");
                        Thread.Sleep(3500);
                        //fight netopýr
                     //   PradavnyNetopyrWv1lvl1();
                        VelkyStrom = 1;
                        ProzkoumavaniVelkehoStromu = 1;
                        test1 = true;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Vracíš se zase ven ...");
                        Thread.Sleep(2500);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        
                        popisPoTruhle();
                        jablko = 1;
                        Akce2(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);

                    }
                    if (akce2 == "neotevirat" || akce2 == "vrat se" || akce2 == "zpatky" || akce2 == "neprozkoumavat")
                        {
                        Console.Clear();
                            Console.WriteLine("Vracíš se zase ven ...");

                            test1 = false;

                        }
                    
                }






                if (akce1 == "vezmy do ruky sekeru" || akce1 == "tas zbran" || akce1 == "vezmy do ruky zbran")
                {
                    pojistka++;
                    Console.WriteLine("Vzal jsi do ruky svojí sekeru battlefury ...");
                    akce1 = Convert.ToString(Console.ReadLine());
                }
                if ((akce1 == "zabij se" || akce1 == "usekni si hlavu")&& pojistka == 1)
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
            } while (test1 == false);
        }
        static void Akce2(string jmeno, byte poprve, byte VelkyStrom, byte ProzkoumavaniVelkehoStromu, byte rozhlednuti, byte PoprveLouka, byte prozkoumaniSstr, byte lezeni, byte pochod, byte zapad, byte sever, byte vedomostiBrany, byte Prvni, byte Druha, byte Treti, byte Odchazi, byte zjisteni, byte pojistkaM, byte PouzeJednou, byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran, byte pozice, byte NovaKonverzace)
        {
            bool test1 = false;
            int pojistka = 0;
            do
            {
                string akce1 = Convert.ToString(Console.ReadLine());


                if (akce1 == "jdi na sever")
                {
                    //planina
                    test1 = true;
                }
                if (akce1 == "jdi na vychod" || akce1 == "jdi na východ")
                {
                    //planina
                    test1 = true;
                }
                if (akce1 == "jdi na zapad" || akce1 == "jdi na západ")
                {
                    //smrt
                    test1 = true;
                }
                if (akce1 == "jdi na jih")
                {
                    //zpatky
                    ValecnikV1SEVER1 zakladKapitola3 = new ValecnikV1SEVER1(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    test1 = true;
                }

                if ((akce1 == "podivej se dovnitr" || akce1 == "prozkoumej to" || akce1 == "jdi dovnitr" || akce1 == "vlez dovnitr" || akce1 == "vstoupit" || akce1 == "prozkoumat" || akce1 == "vstoupit dovnitr" || akce1 == "prozkoumat to") && VelkyStrom == 0)
                {
                    Console.WriteLine("Uvnitř už jsi byl ! /n Není důvod se tam vracet znova ...");
                    test1 = false;
                }



                    if (akce1 == "vezmy do ruky sekeru" || akce1 == "tas zbran" || akce1 == "vezmy do ruky zbran")
                {
                    pojistka++;
                    Console.WriteLine("Vzal jsi do ruky svojí sekeru battlefury ...");
                    akce1 = Convert.ToString(Console.ReadLine());
                }
                if ((akce1 == "zabij se" || akce1 == "usekni si hlavu") && pojistka == 1)
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
                    tw.Close();
                    test1 = false;

                    //     , byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran)
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tvá hra je uložena ...");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            } while (test1 == false);
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
        static void PradavnyNetopyrWv1lvl1(string zbran)
        {
            Console.Clear();
            Console.WriteLine("PRADÁVNÝ NETOPÝR");
            Console.WriteLine("Zvol jednu ze tří možností ('utok z dalky' ; 'utok ze stredni' ; 'utok z blizka' ");
            bool test = false;
            string akce;
            do
            {
                akce = Convert.ToString(Console.ReadLine());
                switch (akce)
                {
                    case "utok z dalky":
                        if (!(zbran == "hul novice"))
                        {
                            test = false;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nelze provést útok z dálky, páč nemáš na to potřebné vybavení !");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        else
                        {
                            //fight
                            FightBlizkaV1(zbran);
                            test = true;
                        }
                        break;
                    case "utok ze stredni":
                        if (!(zbran == "vrhaci noze" || zbran == "kuchynske vrhaci noze" || zbran == "supacky luk a sipy" || zbran == "luk a sipy"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nelze provést útok ze střední vzdálenosti, páč nemáš na to potřebné vybavení !");
                            Console.ForegroundColor = ConsoleColor.White;

                            test = false;
                        }
                        else
                        {
                            //fight
                            FightBlizkaV1(zbran);
                            test = true;
                        }
                        break;
                    case "utok z blizka":
                        {
                            if (!(zbran == "TWG"||zbran == "lovcovy kratke mece" || zbran == "kratke mece" || zbran == "sekera battlefury" || zbran == "battlefury" || zbran == "mec broadsword" || zbran == "broadsword"))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Nelze provést útok ze střední vzdálenosti, páč nemáš na to potřebné vybavení !");
                                Console.ForegroundColor = ConsoleColor.White;
                                test = false;
                            }
                            else
                            {
                                //FIGHT
                                FightBlizkaV1(zbran);
                                test = true;
                            }
                        }

                        break;
                    default:
                        Console.WriteLine("Nesprávný příkaz !");
                        test = false;
                        break;

                }
            } while (test == false);
        }
        static void FightBlizkaV1(string zbran)
        {
            if (zbran == "TWG" || zbran == "lovcovy kratke mece" || zbran == "kratke mece" || zbran == "sekera battlefury" || zbran == "battlefury" || zbran == "mec broadsword" || zbran == "broadsword")
            {
                if (zbran == "sekera battlefury" || zbran == "battlefury")
                {
                    int zivoty = 280;
                    int zivotyMax = 280;
                    int zivotyNMax = 125;
                    int zivotyN = 125;
                    int cislo1 = 0;
                    int poskozeniS = -42;
                    int poskozeniR = -42 / 2;
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
                }//KONEC BATTLEFURY

                if (zbran == "mec broadsword" || zbran == "broadsword")
                {
                    int zivoty = 250;
                    int zivotyMax = 250;
                    int zivotyN = 125;
                    int zivotyNMax = 40;
                    int cislo1 = 0;
                    int poskozeniS = -17;
                    int poskozeniR = -17 / 2;
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
                    int zivotyN = 80;
                    int zivotyNMax = 80;
                    int cislo1 = 0;
                    int poskozeniS = -10;
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
                        int poskozeniR = -99999/2;
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
                    int zivotyN = 125;
                    int zivotyNMax = 125;
                    int cislo1 = 0;
                    int poskozeniR = -4;
                    int poskozeniM = -8;
                    int poskozeniN = -50;
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
                if(zbran == "supacky luk a sipy" || zbran == "luk a sipy")
                {
                    int zivoty = 200;
                    int zivotyMax = 200;
                    int zivotyNMax = 125;
                    int zivotyN = 125;
                    int cislo1 = 0;
                    int poskozeniR = -20;
                    int poskozeniM = -40;
                    int poskozeniN = -50;
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
                int zivotyN = 125;
                int zivotyNMax = 125;
                int poskozeniN = -50;
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

