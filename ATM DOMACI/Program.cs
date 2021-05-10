using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_DOMACI
{
    class Program
    {
        static void Main(string[] args)
        {
            long suma = 20000, n, trenutno, pin = 2222, pin1, pin2, depozit,pin3;
            string odgovor = "d";
            Console.WriteLine("Unesite pin");
            pin1 = int.Parse(Console.ReadLine());

            while (odgovor == "d")
            {
                if (pin1 == pin)
                {
                  
                    Console.WriteLine("Izaberite zeljenu opciju");
                   
                    Console.WriteLine("1.Proverite stanje na racunu");
                   
                    Console.WriteLine("2.Podizanje gotovine");
                   
                    

                    Console.WriteLine("3.Uplacivanje sredstava na racun");
                    
                   
                    Console.WriteLine("4.Promena pina");


                    string operacija = (Console.ReadLine());

                    switch (operacija)
                    {
                        case "1":

                            Console.WriteLine("trenutno stanje na racunu je rsd {0}", suma);
                            break;
                        case "2":
                            Console.WriteLine("Unesite sumu koju zelite da podignete ");
                            trenutno = int.Parse(Console.ReadLine());
                            if (trenutno % 100 != 0)
                            {
                                Console.WriteLine(" Unesite sumu vecu od 100");
                            }
                            else if (trenutno > (suma))
                            {
                                Console.WriteLine(" Nedovoljno sredstava na racunu");
                            }
                            else
                            {
                                suma = suma - trenutno;
                                Console.WriteLine(" Podignite novac");
                                Console.WriteLine(" Vase trenutno stanje na racunu je rsd {0}", suma);
                            }
                            break;
                            
                          

                        case "3":
                            Console.WriteLine("Unesite sumu koju zelite da uplatite na racun");
                            depozit = int.Parse(Console.ReadLine());
                            suma = suma + depozit;
                            Console.WriteLine("Trenutno stanje na racunu je rsd {0}", suma);
                            break;

                        case "4":
                            Console.WriteLine("Da li zelite da promenite pin");
                            Console.WriteLine("Unesite prethodni", pin);
                            int prepin = int.Parse(Console.ReadLine());
                            if (prepin == pin)
                            {
                                Console.WriteLine("Unesite nov pin");
                                pin2 = int.Parse(Console.ReadLine());
                                pin1 = pin2;
                                Console.WriteLine("Vas pin je promenjen,ukucajte nov pin");
                                pin = int.Parse(Console.ReadLine());
                                pin = pin2;
                            }
                            else
                                Console.WriteLine("Ukucajte validan pin");

                            break;


                    }



                }
                else
                {
                    Console.WriteLine("Ukucajte validan pin");
                    pin2 = int.Parse(Console.ReadLine());
                    pin1 = pin2;
                    Console.WriteLine("Ukucajte validan pin");
                    pin3 = int.Parse(Console.ReadLine());
                    pin2 = pin3;
                }

                
                Console.ReadKey();

            }
        }
    }
}