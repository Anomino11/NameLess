using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace ConsoleApplication4
{
    class ValecnikV1SEVER3_VYCHOD
    {
        public ValecnikV1SEVER3_VYCHOD(string jmeno, byte poprve, byte VelkyStrom, byte ProzkoumavaniVelkehoStromu, byte rozhlednuti, byte PoprveLouka, byte prozkoumaniSstr, byte lezeni, byte pochod, byte zapad, byte sever, byte vedomostiBrany, byte Prvni, byte Druha, byte Treti, byte Odchazi, byte zjisteni, byte pojistkaM, byte PouzeJednou, byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran, byte pozice, byte NovaKonverzace)
        {
            pozice = 4;
            bool test = false;
            bool test2 = false;
            popis();
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                string Akce = Convert.ToString(Console.ReadLine());
                //pokud vyleze


                if (Akce == "jdi na sever" && rozhlednuti == 1)
                {
                    //END
                    END bariera = new END(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    break;

                }
                if (Akce == "jdi na jih")
                {
                    //zpět k velkému stromu
                    ValecnikV1SEVER2 zakladKapitola4 = new ValecnikV1SEVER2(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);
                    break;


                }
                if ((Akce == "jdi na vychod" || Akce == "jid na východ") && rozhlednuti == 1)
                {
                    //vesnice
                    break;
                }
                if ((Akce == "jdi na zapad" || Akce == "jdi na západ") && rozhlednuti == 1)
                {
                    //Zpět k velkému stromu


                    ValecnikV1SEVER2 zakladKapitola4 = new ValecnikV1SEVER2(jmeno, poprve, VelkyStrom, ProzkoumavaniVelkehoStromu, rozhlednuti, PoprveLouka, prozkoumaniSstr, lezeni, pochod, zapad, sever, vedomostiBrany, Prvni, Druha, Treti, Odchazi, zjisteni, pojistkaM, PouzeJednou, prozkoumavaniVesnicky, otevreni, jablko, oko, EG, trida, zbran, pozice, NovaKonverzace);

                    break;
                }





                if ((Akce == "prozkoumej strom" || Akce == "prozkoumat strom") && prozkoumaniSstr == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Strom už jsi prozkoumal ...");
                    Console.ForegroundColor = ConsoleColor.White;
                    test = false;

                }
                if ((Akce == "prozkoumej strom" || Akce == "prozkoumat strom") && prozkoumaniSstr == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Rozhodl jsi se prozkoumat strom a přicházíš k němu blíže");
                    Thread.Sleep(2500);
                    Console.WriteLine("I když je strom starý, definitivně, to však neznamená že není vysoký a nedal by se na nic využít ...");
                    Console.ForegroundColor = ConsoleColor.White;

                    prozkoumaniSstr = 1;
                    test = false;
                }




                if (Akce == "vylez na strom" && prozkoumaniSstr == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Rozhodl jsi se vyšplhat na strom ...");
                    Console.ForegroundColor = ConsoleColor.White;
                    lezeni = 1;
                    do
                    {

                        Akce = Convert.ToString(Console.ReadLine());

                        if ((Akce == "rozhledni se" || Akce == "koukni se kolem" || Akce == "rozhlydni se") && lezeni == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Rozhlížíš se kolem a vidíš, že na sever od tebe je skalnatá plocha a o pořádný kus v pozadí je vidět jakýsi obrovský kopec");
                            Thread.Sleep(5000);
                            Console.WriteLine("Na východ je vidět nějaká malá vesnička");
                            Thread.Sleep(2500);
                            Console.WriteLine("Každopádně jsi se zorientoval a nyní víš, kudy kam ...");
                            Console.ForegroundColor = ConsoleColor.White;
                            lezeni = 1;
                            test = false;
                        }

                        if ((Akce == "skoc dolu" || Akce == "seskoc") && lezeni == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Rozhodl jsi se seskočit dolů");
                            Thread.Sleep(1000);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Pád ti ubral 10 HP");
                            Thread.Sleep(1000);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Nacházíš se zase na zemi před stromem ...");
                            Console.ForegroundColor = ConsoleColor.White;
                            lezeni = 0;
                            test2 = false;
                            test = false;
                        }
                        if ((Akce == "slez" || Akce == "slez dolu" || Akce == "opatrne slez" || Akce == "opatrne slez dolu") && lezeni == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Rozhodl jsi se bezpečně slézt dolů");
                            Thread.Sleep(1000);
                            Console.WriteLine("Nacházíš se zase na zemi před stromem ...");
                            Console.ForegroundColor = ConsoleColor.White;
                            lezeni = 0;
                            break;
                            test2 = false;
                            test = false;
                        }
                        if (!(Akce == "rozhledni se" || Akce == "koukni se kolem" || Akce == "rozhlydni se" || Akce == "skoc dolu" || Akce == "seskoc" || Akce == "slez" || Akce == "slez dolu" || Akce == "opatrne slez" || Akce == "opatrne slez dolu") && lezeni == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Jsem na stromě, nemůžu nikam teď jít ...");
                            Console.ForegroundColor = ConsoleColor.White;
                            test2 = false;
                            rozhlednuti = 1;
                        }

                    } while (!(test2 == true));
                }










                //pokud nevyleze
                if (Akce == "jdi na sever" && lezeni == 0 && pochod < 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nacházíš se na louce ...");
                    Console.ForegroundColor = ConsoleColor.White;
                    test = false;
                    pochod++;
                    sever++;
                }
                if (Akce == "jdi na sever" && lezeni == 0 && pochod == 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Konečně jsi opustil louku ...");
                    //jde na sever
                    test = true;
                }
                if (Akce == "jdi na vychod" && lezeni == 0 && pochod < 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nacházíš se na louce ...");
                    Console.ForegroundColor = ConsoleColor.White;
                    test = false;
                    pochod++;
                }
                if (Akce == "jdi na vychod" && lezeni == 0 && pochod == 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Konečně jsi opustil louku ...");
                    //jde na východ (VESNICE)
                    test = true;
                }
                if (Akce == "jdi na jih" && lezeni == 0 && pochod < 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nacházíš se na louce ...");
                    Console.ForegroundColor = ConsoleColor.White;
                    test = false;
                    pochod++;
                }
                if (Akce == "jdi na jih" && lezeni == 0 && pochod == 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Konečně jsi opustil louku ...");
                    //Vrací se do lesa
                    test = true;
                }

                if (Akce == "jdi na zapad" && lezeni == 0 && pochod < 12)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    if (Akce == "jdi na zapad" && !(sever == 3))
                    {



                        Console.WriteLine("Nacházíš se na louce ...");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    test = false;
                    pochod++;
                }
                if (Akce == "jdi na zapad" && lezeni == 0 && pochod == 12)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Konečně jsi opustil louku ...");
                    //Z útesu -> RIP
                    test = true;
                }





                if (Akce == "/inv")
                {
                    EG = inventarP(jablko, oko, EG, trida);
                    test = false;
                }
                if (Akce == "/stats")
                {
                    zbran = statyW(EG, zbran, trida);
                    test = false;
                }







                //EasterEgg :)


                if (Akce == "jdi na zapad" && lezeni == 0 && pochod < 12 && sever == 3)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    //EasterEgg - > Nejsilnější zbraň ve hře TWG longsword
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Získáváš TWG longsword a ukládáš ho do inventáře!");
                    EG = 1;
                    Thread.Sleep(2500);
                    Console.WriteLine("//Zmáčni libovolné tlačítko//");
                    Console.ForegroundColor = ConsoleColor.White;
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
                    tw.WriteLine(NovaKonverzace);
                    tw.Close();
                    test = false;
                    //     , byte prozkoumavaniVesnicky, byte otevreni, byte jablko, byte oko, byte EG, string trida, string zbran)
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Tvá hra je uložena ...");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            } while (!(test == true));    
    }
        static void popis()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pokračuješ stále na sever a nacházíš se na obilné louce");
            Thread.Sleep(2500);
            Console.WriteLine("Klasy obilí nepřerostou ani tvůj pas, ale přesto je velice obtížné se pohybovat");
            Thread.Sleep(2500);
            Console.WriteLine("Jediné co značně převyšuje tuto obrovskou planinu je jeden starý strom uprostřed louky ...");


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
    }
}
