using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Wybierz numer Państwa\n---------------");
            List<Wycieczka> list = new List<Wycieczka>();
            list.Add(new Wycieczka("1.Hiszpania"));
            list.Add(new Wycieczka("2.Anglia"));
            list.Add(new Wycieczka("3.Niemcy"));
            list.Add(new Wycieczka("4.Francja"));
            list.Add(new Wycieczka("5.USA"));
            list.Add(new Wycieczka("6.Japonia"));
            list.Add(new Wycieczka("7.Chiny"));
            list.Add(new Wycieczka("8.Włochy"));


            foreach (Wycieczka item in list)
            {
                Console.WriteLine(item.Numer);

            }
                Console.WriteLine("-----------------");

            int liczba;
            int liczbaoferty;
            int liczbaoferty2;
            int liczbaoferty3;
            int liczbaoferty4;
            int liczbaoferty5;
            int liczbaoferty6;
            int liczbaoferty7;
            int liczbaoferty8;


            
            do
            {

                liczba = int.Parse(Console.ReadLine());


                if (liczba == 1)
                {

                    //Hiszpania
                    Hotel a1 = new Hotel();
                    a1.Country = "1.Hiszpania 12-19.06.2021";
                    a1.Kategoria = "*****";
                    a1.Nazwa = "Gran Canaria";
                    a1.PrizePerDay = 360;
                    a1.NumberOfDays = 7;
                    Console.WriteLine($"--------------------\n{a1.Country}\nGwiazdki: {a1.Kategoria}\n {a1.Nazwa}\nCena całkowita {a1.Prize} zł\n");

                    Hotel a2 = new Hotel();
                    a2.Country = "2.Hiszpania 10-24.05.2021";
                    a2.Kategoria = "****";
                    a2.Nazwa = "Madryt";
                    a2.PrizePerDay = 330;
                    a2.NumberOfDays = 14;
                    Console.WriteLine($"--------------------\n{a2.Country}\nGwiazdki: {a2.Kategoria}\n {a2.Nazwa}\nCena całkowita {a2.Prize} zł\n");

                    Hotel a3 = new Hotel();
                    a3.Country = "3.Hiszpania 25-06.05-06.2021";
                    a3.Kategoria = "***";
                    a3.Nazwa = "Barcelona";
                    a3.PrizePerDay = 310;
                    a3.NumberOfDays = 12;
                    Console.WriteLine($"--------------------\n{a3.Country}\nGwiazdki: {a3.Kategoria}\n {a3.Nazwa}\nCena całkowita {a3.Prize} zł\n");

                    Hotel a4 = new Hotel();
                    a4.Country = "4.Hiszpania 05-13.06,2021";
                    a4.Kategoria = "*";
                    a4.Nazwa = "Kordoba";
                    a4.PrizePerDay = 290;
                    a4.NumberOfDays = 8;
                    Console.WriteLine($"--------------------\n{a4.Country}\nGwiazdki: {a4.Kategoria}\n {a4.Nazwa}\nCena całkowita {a4.Prize} zł\n");

                    Console.Write("\nWybierz numer oferty: ");
                    liczbaoferty = int.Parse(Console.ReadLine());


                  

                        if (liczbaoferty == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Pierwsi turyści pojawili się na Gran Canarii ponad 150 lat temu." +
                                "\nZachwycił ich krajobraz i niezwykle łagodny klimat." +
                                "\nTa sielska atmosfera trwa na wyspie do dzisiaj." +
                                "\n\n  Życzymy udanych wakacji!!!");
                                  Console.ResetColor();
                            Console.ReadLine();
                            return;
                        
                            
                            
                        }

                        else if (liczbaoferty == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Stolica i największe miasto Hiszpanii"
                                + "\n  Nie zaomnij zobaczyć stadionu Realu Madryt");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;

                        }
                        else if (liczbaoferty == 3)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Barcelona jest stolicą Katalonii i drugim największym miastem w Hiszpanii." +
                                "\n Jest położona nad Morzem Śródziemnym i stanowi cel wycieczek dla milionów\n turystów rocznie." +
                                "\n Kojarzymy ją głównie z ciepłego klimatu, wyjątkowej architektury i FC Barcelony");
                            Console.ResetColor(); 
                            Console.ReadLine();
                            return;

                        }
                        else if (liczbaoferty == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Znalezione obrazy dla zapytania kordoba opis" +
                            "\nKordoba lub Kordowa(hiszp.Córdoba) – miasto w południowej Hiszpanii, ," +
                            "\nnad rzeką Gwadalkiwir stolica prowincji Kordoba, w regionie Andaluzja." +
                            "\nOśrodek przemysłowy, naukowy oraz turystyczny o znaczeniu światowym.\nW mieście znajduje się stacja kolejowa Córdoba.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else
                        {
                             Console.WriteLine("Liczba z poza zakresu");
                             Console.ReadLine();
                             return;
                            
                        }

                    
                    
                }


                else if (liczba == 2)
                {

                    Console.Clear();

                    //Anglia
                    Hotel a5 = new Hotel();
                    a5.Country = "1.Anglia 10-17.04.2021";
                    a5.Kategoria = "*****";
                    a5.Nazwa = "Londyn";
                    a5.PrizePerDay = 450;
                    a5.NumberOfDays = 7;
                    Console.WriteLine($"--------------------\n{a5.Country}\nGwiazdki: {a5.Kategoria}\n {a5.Nazwa}\nCena całkowita {a5.Prize} zł\n");

                    Hotel a6 = new Hotel();
                    a6.Country = "2.Anglia 19-30.04.2021";
                    a6.Kategoria = "***";
                    a6.Nazwa = "Leeds";
                    a6.PrizePerDay = 240;
                    a6.NumberOfDays = 11;
                    Console.WriteLine($"--------------------\n{a6.Country}\nGwiazdki: {a6.Kategoria}\n {a6.Nazwa}\nCena całkowita {a6.Prize} zł\n");

                    Hotel a7 = new Hotel();
                    a7.Country = "3.Anglia 03-12.11.2021";
                    a7.Kategoria = "****";
                    a7.Nazwa = "Manchester";
                    a7.PrizePerDay = 385;
                    a7.NumberOfDays = 12;
                    Console.WriteLine($"--------------------\n{a7.Country}\nGwiazdki: {a7.Kategoria}\n {a7.Nazwa}\nCena całkowita {a7.Prize} zł\n");

                    Hotel a8 = new Hotel();
                    a8.Country = "4.Anglia 14-18.09.2021";
                    a8.Kategoria = "*****";
                    a8.Nazwa = "Sheffield";
                    a8.PrizePerDay = 200;
                    a8.NumberOfDays = 4;
                    Console.WriteLine($"--------------------\n{a8.Country}\nGwiazdki: {a8.Kategoria}\n {a8.Nazwa}\nCena całkowita {a8.Prize} zł\n");

                    
                        Console.Write("\nWybierz numer oferty: ");
                        liczbaoferty2 = int.Parse(Console.ReadLine());

                 

                        if (liczbaoferty2 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Stolica Anglii i Wielkiej Brytanii, największe miasto królestwa," +
                                "\npołożone w jego południowo-wschodniej części nad Tamizą." +
                                "\nJest trzecim co do wielkości miastem Europy, po Moskwie i Stambule." +
                                "\nJest jednym z większych miast świata zarówno w skali samego miasta," +
                                "\njak i całej aglomeracji.");
                            Console.ResetColor();
                             Console.ReadLine();
                            return;
    
                        } 

                        else if (liczbaoferty2 == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Leeds to największe po Londynie centrum biznesowe oraz" +
                                "\nusług finansowych i prawnych. Gospodarka Leeds jest zróżnicowana." +
                                "\nZatrudnienie w usługach o wiele przewyższa zatrudnienie w tradycyjnym przemyśle.");
                            Console.ResetColor();
                            Console.ReadLine();
                             return;
                        }       
                        else if (liczbaoferty2 == 3)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Znalezione obrazy dla zapytania Manchester opis" +
                            "Manchester - miasto w Anglii w hrabstwie metropolitarnym Wielki Manchester," +
                            "\nstanowi samodzielny dystrykt metropolitalny.Położony u podnóża gór Pennińskich," +
                            "\nnad rzeką Irwell.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty2 == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Miasto w północnej Anglii w hrabstwie metropolitalnym" +
                                "\nSouth Yorkshire, w dystrykcie metropolitalnym Sheffield." +
                                "\nW 2001 roku miasto liczyło 439 866 mieszkańców, co czyni je piątym" +
                                "\nco do wielkości miastem w Anglii.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else
                        {
                            Console.WriteLine("Liczba z poza zakresu");
                            Console.ReadLine();
                            return;
                        }

                    
                }


                else if (liczba == 3)
                {

                    Console.Clear();
                    //Niemcy
                    Hotel a9 = new Hotel();
                    a9.Country = "1.Niemcy 21-28.10.2021";
                    a9.Kategoria = "*****";
                    a9.Nazwa = "Berlin";
                    a9.PrizePerDay = 270;
                    a9.NumberOfDays = 7;
                    Console.WriteLine($"--------------------\n{a9.Country}\nGwiazdki: {a9.Kategoria}\n {a9.Nazwa}\nCena całkowita {a9.Prize} zł\n");

                    Hotel a10 = new Hotel();
                    a10.Country = "2.Niemcy 01-04.03.2021";
                    a10.Kategoria = "***";
                    a10.Nazwa = "Dortmund";
                    a10.PrizePerDay = 120;
                    a10.NumberOfDays = 3;
                    Console.WriteLine($"--------------------\n{a10.Country}\nGwiazdki: {a10.Kategoria}\n {a10.Nazwa}\nCena całkowita {a10.Prize} zł\n");

                    Hotel a11 = new Hotel();
                    a11.Country = "3.Niemcy 13-20.06.2021";
                    a11.Kategoria = "****";
                    a11.Nazwa = "Hamburg";
                    a11.PrizePerDay = 170;
                    a11.NumberOfDays = 7;
                    Console.WriteLine($"--------------------\n{a11.Country}\nGwiazdki: {a11.Kategoria}\n {a11.Nazwa}\nCena całkowita {a11.Prize} zł\n");

                    Hotel a12 = new Hotel();
                    a12.Country = "4.Niemcy 24-30.08.2021";
                    a12.Kategoria = "****";
                    a12.Nazwa = "Monachium";
                    a12.PrizePerDay = 240;
                    a12.NumberOfDays = 6;
                    Console.WriteLine($"--------------------\n{a12.Country}\nGwiazdki: {a12.Kategoria}\n {a12.Nazwa}\nCena całkowita {a12.Prize} zł\n");

                    
                        Console.Write("\nWybierz numer oferty: ");
                        liczbaoferty3 = int.Parse(Console.ReadLine());

                   

                        if (liczbaoferty3 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Berlin jest stolicą i jednocześnie największym miastem Niemiec" +
                                "\nna prawach landu, położonym nad rzeką Sprewą. Leży tylko około 70 kilometrów" +
                                "\nod granicy z Polską. Zajmuje powierzchnię 890 km2, a zamieszkuje" +
                                "\nokoło 3,4 mln osób.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else if (liczbaoferty3 == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Miasto na prawach powiatu położone w zachodniej części Niemiec," +
                                "\nw kraju związkowym Nadrenia Północna-Westfalia, w rejencji Arnsberg." +
                                "\nPod koniec 2019 roku, z liczbą mieszkańców wynoszącą niecałe 590 tys." +
                                "\nDortmund zajmował dziewiąte miejsce w Niemczech pod względem liczby ludności.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty3 == 3)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Hamburg to miasto w północnych Niemczech niedaleko ujścia rzeki Łaby" +
                                "\ndo Morza Północnego, podzielone na 7 okręgów administracyjnych." +
                                "\nZnajduje się tu największy port morski, który jest centrum handlu" +
                                "\nz krajami Europy Wschodniej i Północnej.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty3 == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Monachium(niem.München, bawarski: Minga) to stolica niemieckiego kraju" +
                                "\nzwiązkowego Bawaria.W granicach miasta Monachium ma ponad 1, 5 miliona" +
                                "\nmieszkańców, co czyni go trzecim najbardziej zaludnionym miastem w Niemczech." +
                                "\nWiększy Monachium, w tym jego przedmieścia, ma 2, 7 miliona mieszkańców.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else
                        {
                            Console.WriteLine("Liczba z poza zakresu");
                            Console.ReadLine();
                            return;
                        }

                    
                }

                else if (liczba == 4)
                {

                    Console.Clear();
                    //Francja
                    Hotel a13 = new Hotel();
                    a13.Country = "1.Francja 13-27.07.2021";
                    a13.Kategoria = "*****";
                    a13.Nazwa = "Paryż";
                    a13.PrizePerDay = 320;
                    a13.NumberOfDays = 14;
                    Console.WriteLine($"--------------------\n{a13.Country}\nGwiazdki: {a13.Kategoria}\n {a13.Nazwa}\nCena całkowita {a13.Prize} zł\n");

                    Hotel a14 = new Hotel();
                    a14.Country = "2.Francja 12-19.08.2021";
                    a14.Kategoria = "***";
                    a14.Nazwa = "Rouen";
                    a14.PrizePerDay = 110;
                    a14.NumberOfDays = 7;
                    Console.WriteLine($"--------------------\n{a14.Country}\nGwiazdki: {a14.Kategoria}\n {a14.Nazwa}\nCena całkowita {a14.Prize} zł\n");

                    Hotel a15 = new Hotel();
                    a15.Country = "3.Francja 06-14.09.2021";
                    a15.Kategoria = "****";
                    a15.Nazwa = "Lyon";
                    a15.PrizePerDay = 200;
                    a15.NumberOfDays = 8;
                    Console.WriteLine($"--------------------\n{a15.Country}\nGwiazdki: {a15.Kategoria}\n {a15.Nazwa}\nCena całkowita {a15.Prize} zł\n");

                    Hotel a16 = new Hotel();
                    a16.Country = "4.Francja 20-25.12.2020";
                    a16.Kategoria = "**";
                    a16.Nazwa = "Limoges";
                    a16.PrizePerDay = 180;
                    a16.NumberOfDays = 5;
                    Console.WriteLine($"--------------------\n{a16.Country}\nGwiazdki: {a16.Kategoria}\n {a16.Nazwa}\nCena całkowita {a16.Prize} zł\n");

                   
                        Console.Write("\nWybierz numer oferty: ");
                        liczbaoferty4 = int.Parse(Console.ReadLine());

                   

                        if (liczbaoferty4 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Stolica i największe miasto Francji, położone w centrum" +
                                "\nBasenu Paryskiego, nad Sekwaną. Stanowi centrum polityczne," +
                                "\nekonomiczne i kulturalne kraju.");
                            Console.ResetColor();
                            
                        }

                        else if (liczbaoferty4 == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Katedra w Rouen – seria obrazów namalowanych w latach 1893-1894" +
                                "\nprzez Claude'a Moneta, reprezentująca kierunek artystyczny końca XIX wieku" +
                                "\nimpresjonizmu. Tematem cyklu, składającego się z 31 obrazów, jest gotycka" +
                                "\nkatedra Notre-Dame w Rouen.");
                            Console.ResetColor();
                            
                        }
                        else if (liczbaoferty4 == 3)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Miasto we Francji tworzy trzecią co do wielkości aglomerację we Francji" +
                                "\n(po Paryżu i Marsylii). Leży w środkowo-wschodniej części kraju, nad rzekami" +
                                "\nRodanem i Saoną, w regionie Owernia-Rodan-Alpy, w departamencie Rodan");
                            Console.ResetColor();
                            
                        }
                        else if (liczbaoferty4 == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Miasto i gmina we Francji, w regionie Nowa Akwitania," +
                                "\nw departamencie Haute-Vienne.");
                            Console.ResetColor();
                            
                        }

                        else
                        {
                            Console.WriteLine("Liczba z poza zakresu");
                            Console.ReadLine();
                            return;
                        }

                   
                }


                else if (liczba == 5)
                {

                    Console.Clear();
                    //Ameryka USA
                    Hotel a17 = new Hotel();
                    a17.Country = "1.USA 10-17.06.2021";
                    a17.Kategoria = "*****";
                    a17.Nazwa = "Los Angeles";
                    a17.PrizePerDay = 670;
                    a17.NumberOfDays = 7;
                    Console.WriteLine($"--------------------\n{a17.Country}\nGwiazdki: {a17.Kategoria}\n {a17.Nazwa}\nCena całkowita {a17.Prize} zł\n");

                    Hotel a18 = new Hotel();
                    a18.Country = "2.USA 01-13.07.2021";
                    a18.Kategoria = "*****";
                    a18.Nazwa = "Waszyngton";
                    a18.PrizePerDay = 580;
                    a18.NumberOfDays = 12;
                    Console.WriteLine($"--------------------\n{a18.Country}\nGwiazdki: {a18.Kategoria}\n {a18.Nazwa}\nCena całkowita {a18.Prize} zł\n");

                    Hotel a19 = new Hotel();
                    a19.Country = "3.USA 15-27.09.2021";
                    a19.Kategoria = "*****";
                    a19.Nazwa = "Las Vegas";
                    a19.PrizePerDay = 660;
                    a19.NumberOfDays = 12;
                    Console.WriteLine($"--------------------\n{a19.Country}\nGwiazdki: {a19.Kategoria}\n {a19.Nazwa}\nCena całkowita {a19.Prize} zł\n");

                    Hotel a20 = new Hotel();
                    a20.Country = "4.USA 07-21.10.2021";
                    a20.Kategoria = "*****";
                    a20.Nazwa = "California";
                    a20.PrizePerDay = 780;
                    a20.NumberOfDays = 14;
                    Console.WriteLine($"--------------------\n{a20.Country}\nGwiazdki: {a20.Kategoria}\n {a20.Nazwa}\nCena całkowita {a20.Prize} zł\n");

                    
                        Console.Write("\nWybierz numer oferty: ");
                        liczbaoferty5 = int.Parse(Console.ReadLine());

                     

                        if (liczbaoferty5 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Los Angeles – najludniejsze miasto amerykańskiego stanu Kalifornia," +
                                "\na zarazem drugie pod względem liczby mieszkańców miasto w Stanach Zjednoczonych" +
                                "\n(za Nowym Jorkiem), za sprawą populacji liczącej ok. 4 mln mieszkańców.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else if (liczbaoferty5 == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Waszyngton jest stolicą Stanów Zjednoczonych. Obszar metropolitalny" +
                                "\nmiasta, na który składa się między innymi Dystrykt Kolumbii, posiada 5,3 miliona" +
                                "\nludzi i jest siódmym co to wielkości, spośród tego typy jednostek, w kraju.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty5 == 3)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Las Vegas najbardziej zaludnione miasto w amerykańskim stanie Nevada," +
                                "\nw hrabstwie Clark. Na świecie kojarzone jest przede wszystkim z grami hazardowymi," +
                                "\nzakupami oraz wyszukanymi restauracjami i luksusowymi hotelami.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty5 == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Kalifornia to najludniejszy, najbogatszy oraz trzeci co do wielkości" +
                                "\n(po Alasce i Teksasie) stan Stanów Zjednoczonych. Położony na zachodnim wybrzeżu" +
                                "\nStanów Zjednoczonych, nad Oceanem Spokojnym.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else
                        {
                            Console.WriteLine("Liczba z poza zakresu");
                            Console.ReadLine();
                            return;
                        }

                }

                else if (liczba == 6)
                {

                    Console.Clear();
                    //Japonia
                    Hotel a21 = new Hotel();
                    a21.Country = "1.Japonia 09-21.07.2021";
                    a21.Kategoria = "*****";
                    a21.Nazwa = "Tokyo";
                    a21.PrizePerDay = 660;
                    a21.NumberOfDays = 12;
                    Console.WriteLine($"--------------------\n{a21.Country}\nGwiazdki: {a21.Kategoria}\n {a21.Nazwa}\nCena całkowita {a21.Prize} zł\n");

                    Hotel a22 = new Hotel();
                    a22.Country = "2.Japonia 15-25.12.2021";
                    a22.Kategoria = "****";
                    a22.Nazwa = "Osaka";
                    a22.PrizePerDay = 560;
                    a22.NumberOfDays = 10;
                    Console.WriteLine($"--------------------\n{a22.Country}\nGwiazdki: {a22.Kategoria}\n {a22.Nazwa}\nCena całkowita {a22.Prize} zł\n");

                    Hotel a23 = new Hotel();
                    a23.Country = "3.Japonia 11-19.11.2021";
                    a23.Kategoria = "****";
                    a23.Nazwa = "Jokohama";
                    a23.PrizePerDay = 550;
                    a23.NumberOfDays = 8;
                    Console.WriteLine($"--------------------\n{a23.Country}\nGwiazdki: {a23.Kategoria}\n {a23.Nazwa}\nCena całkowita {a23.Prize} zł\n");

                    Hotel a24 = new Hotel();
                    a24.Country = "4.Japonia 21-30.07.2021";
                    a24.Kategoria = "***";
                    a24.Nazwa = "Nagoya";
                    a24.PrizePerDay = 460;
                    a24.NumberOfDays = 9;
                    Console.WriteLine($"--------------------\n{a24.Country}\nGwiazdki: {a24.Kategoria}\n {a24.Nazwa}\nCena całkowita {a24.Prize} zł\n");

                    
                        Console.Write("\nWybierz numer oferty: ");
                        liczbaoferty6 = int.Parse(Console.ReadLine());

                   

                        if (liczbaoferty6 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Tokio to stolica i największe miasto Japonii," +
                                "\npołożone na największej japońskiej wyspie Honsiu, nad Oceanem Spokojnym." +
                                "\nObszar miasta stanowi najgęściej zaludniony obszar na świecie.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else if (liczbaoferty6 == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Trzecie co do wielkości miasto w Japonii." +
                                "\nOsaka jest jednym z najważniejszych ośrodków przemysłowych," +
                                "\nhandlowo-usługowych, kulturalno-naukowych i rozrywkowych w kraju," +
                                "\no niezwykle potężnym potencjale ekonomicznym, konkurującym z Tokio.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty6 == 3)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Jokohama drugie co do wielkości miasto w Japonii, największy port morski" +
                                "\ni jeden z większych ośrodków przemysłowych w kraju. Leży w środkowej" +
                                "\nczęści wyspy Honsiu");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty6 == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Nagoya to miasto w południowej części wyspy Honsiu," +
                                "\nktórego aglomerację zamieszkuje około 9 mln ludzi, co czyni ją trzecią" +
                                "\nco do wielkości w Japonii, po Tokio i Osace.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else
                        {
                            Console.WriteLine("Liczba z poza zakresu");
                            Console.ReadLine();
                            return;
                        }

                    
                }


                else if (liczba == 7)
                {


                    Console.Clear();
                    //Chiny
                    Hotel a25 = new Hotel();
                    a25.Country = "1.Chiny 06-18.08.2021";
                    a25.Kategoria = "*****";
                    a25.Nazwa = "Hong Kong";
                    a25.PrizePerDay = 720;
                    a25.NumberOfDays = 12;
                    Console.WriteLine($"--------------------\n{a25.Country}\nGwiazdki: {a25.Kategoria}\n {a25.Nazwa}\nCena całkowita {a25.Prize} zł\n");

                    Hotel a26 = new Hotel();
                    a26.Country = "2.Chiny 12-20.11.2020";
                    a26.Kategoria = "****";
                    a26.Nazwa = "Kanton";
                    a26.PrizePerDay = 660;
                    a26.NumberOfDays = 8;
                    Console.WriteLine($"--------------------\n{a26.Country}\nGwiazdki: {a26.Kategoria}\n {a26.Nazwa}\nCena całkowita {a26.Prize} zł\n");

                    Hotel a27 = new Hotel();
                    a27.Country = "3.Chiny 20-30.06.2021";
                    a27.Kategoria = "****";
                    a27.Nazwa = "Xiamen";
                    a27.PrizePerDay = 640;
                    a27.NumberOfDays = 10;
                    Console.WriteLine($"--------------------\n{a27.Country}\nGwiazdki: {a27.Kategoria}\n {a27.Nazwa}\nCena całkowita {a27.Prize} zł\n");

                    Hotel a28 = new Hotel();
                    a28.Country = "4.Chiny 05-12.11.2020";
                    a28.Kategoria = "***";
                    a28.Nazwa = "Nanning";
                    a28.PrizePerDay = 560;
                    a28.NumberOfDays = 7;
                    Console.WriteLine($"--------------------\n{a28.Country}\nGwiazdki: {a28.Kategoria}\n {a28.Nazwa}\nCena całkowita {a28.Prize} zł\n");

                    
                        Console.Write("\nWybierz numer oferty: ");
                        liczbaoferty7 = int.Parse(Console.ReadLine());

                  

                   
                        if (liczbaoferty7 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Hong Kong to specjalny region administracyjny Chińskiej Republiki" +
                                "\nLudowej, znajdujący się nad Morzem Południowochińskim, w Delcie Rzeki Perłowej.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else if (liczbaoferty7 == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Guangzhou, znane jako Kanton, jest nowoczesną, dynamiczną" +
                                "\nmetropolią.Jest to trzecie co do wielkości miasto w Chinach" +
                                "\ni jest politycznym, gospodarczym, naukowo-technicznym, edukacyjnym" +
                                "\ni kulturalnym centrum południowych Chin.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty7 == 3)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Xiamen jest ośrodkiem szkolnictwa wyższego.Od 1981 roku" +
                                "\nXiamen posiada status specjalnej strefy ekonomicznej.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty7 == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Nanning miasto o statusie prefektury miejskiej w Chinach," +
                                "\nstolica regionu autonomicznego Kuangsi zamieszkanego przez mówiących" +
                                "\npo tajsku Zhuangów.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;

                        }

                        else
                        {
                            Console.WriteLine("Liczba z poza zakresu");
                            Console.ReadLine();
                            return;
                        }

                    
                }


                else if (liczba == 8)
                {
                    Console.Clear();
                    //Włochy
                    Hotel a29 = new Hotel();
                    a29.Country = "1.Włochy 13-27.06.2021";
                    a29.Kategoria = "*****";
                    a29.Nazwa = "Rzym";
                    a29.PrizePerDay = 360;
                    a29.NumberOfDays = 14;
                    Console.WriteLine($"--------------------\n{a29.Country}\nGwiazdki: {a29.Kategoria}\n {a29.Nazwa}\nCena całkowita {a29.Prize} zł\n");

                    Hotel a30 = new Hotel();
                    a30.Country = "2.Włochy 09-16.07.2021";
                    a30.Kategoria = "***";
                    a30.Nazwa = "Florencja";
                    a30.PrizePerDay = 290;
                    a30.NumberOfDays = 7;
                    Console.WriteLine($"--------------------\n{a30.Country}\nGwiazdki: {a30.Kategoria}\n {a30.Nazwa}\nCena całkowita {a30.Prize} zł\n");

                    Hotel a31 = new Hotel();
                    a31.Country = "3.Włochy 03-15.08.2021";
                    a31.Kategoria = "****";
                    a31.Nazwa = "Neapol";
                    a31.PrizePerDay = 340;
                    a31.NumberOfDays = 11;
                    Console.WriteLine($"--------------------\n{a31.Country}\nGwiazdki: {a31.Kategoria}\n {a31.Nazwa}\nCena całkowita {a31.Prize} zł\n");

                    Hotel a32 = new Hotel();
                    a32.Country = "4.Włochy 11-20.09.2021";
                    a32.Kategoria = "***";
                    a32.Nazwa = "Bolonia";
                    a32.PrizePerDay = 260;
                    a32.NumberOfDays = 9;
                    Console.WriteLine($"--------------------\n{a32.Country}\nGwiazdki: {a32.Kategoria}\n {a32.Nazwa}\nCena całkowita {a32.Prize} zł\n");

                   
                        Console.Write("\nWybierz numer oferty: ");
                        liczbaoferty8 = int.Parse(Console.ReadLine());

                    

                        if (liczbaoferty8 == 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Rzym to stolica i największe miasto Włoch, położone w środkowej" +
                                "\nczęści kraju nad rzeką Tyber i Morzem Śródziemnym.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }

                        else if (liczbaoferty8 == 2)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Otoczona wzgórzami, leży nad rzeką Arno, która przepływa" +
                                "\nprzez miasto, historyczne centrum jest na prawym brzegu. Florencja była" +
                                "\nważnym miejscem w historii regionu, Włoch, a również i świata.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty8 == 3)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Miasto położone w południowych Włoszech, w centrum Zatoki" +
                                "\nNeapolitańskiej. Stolica regionu Kampania oraz Prowincji Neapol." +
                                "\nMiasto położone jest u podnóża Wezuwiusza. Neapol jest trzecim" +
                                "\npod względem populacji miastem Włoch, ustępując pod tym względem" +
                                "\nRzymowi oraz Mediolanowi.");
                            Console.ResetColor();
                            Console.ReadLine();
                            return;
                        }
                        else if (liczbaoferty8 == 4)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Bolonia to miasto w północnych Włoszech, położone jest między" +
                                "\nPadem a Apeninami na wysokości 54 m n.p.m. Miasto leży nad dwoma rzekami" +
                                "\nReno i Saveną. Stolica regionu Emilia-Romania.");
                            Console.ResetColor();
                             Console.ReadLine();
                             return;

                        }

                        else
                        {
                        Console.WriteLine("Liczba z poza zakresu");
                        Console.ReadLine();
                        return;
                        }

                    

                }

                else
                {
                    Console.WriteLine("Liczba z poza zakresu");
                    Console.ReadLine();
                    return;
                }
                
                        
                   
                

            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);
            Console.ReadKey();

        }




    }


        
    
}

