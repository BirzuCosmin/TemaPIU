using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace masini
{
    
    class Class1
    {
        
        static void Main(string[]args)
        { 
            masina[] vanzari=new masina[300];
             int nrvanzari=0;
            
           
        //IStocareData adminMasini = Stocare;
        //IStocareData adminMasini= S  

        // masina.IdUltimaVanare = nrmasini;
        var m = new masina();
            string s = m.info();
            Console.WriteLine(s);

            masina m2 = new masina("cosmin", "alin", "Audi", "A4");
            string s1 = m2.info();
            Console.WriteLine(s1);
            masina m3 = new masina("Alex Matei BMW m3");
            string s2 = m2.ConversieLaSir();
            Console.WriteLine(m3.info());
            Console.WriteLine(s2);   
            if (m3.Comparatie(m2) == true)
            {
                Console.WriteLine("s-a introdus aceeasi vanzare de 2 ori");
            }
            else
                Console.WriteLine("vanzarile sunt diferite");
            string optiune;
             do
             {
                 Console.WriteLine("L.  lista vanzari");
                 Console.WriteLine("C.  adauga masina");
                 Console.WriteLine("S.  salvare fisier");
                Console.WriteLine("P.  afisare date fisier");
                 Console.WriteLine("X.  Inchidere program");
                 Console.WriteLine("alegeti o optiune");
                 optiune = Console.ReadLine();
                 switch (optiune.ToUpper())
                 {
  
                     case "C":
                        var k = new masina();
                          k  = CitireTastatura();
                         vanzari[nrvanzari] = k;
                        nrvanzari++;
 
                        break;
                    case "L":
                        AfisareMasini(vanzari, nrvanzari);
                         break;  
                    case "S":
                        using (StreamWriter sr= new StreamWriter("vanzari.txt", true))
                        {
                            for (int i=0;i<nrvanzari;i++)
                            {   
                                sr.WriteLine(vanzari[i].ConversieLaSir());
                            }
                        }
                        break;
                    case "P":
                        using (StreamReader sw = new StreamReader("vanzari.txt", true))
                        {
                            string linie;
                            nrvanzari = 0;
                            while((linie=sw.ReadLine())!=null)
                            {
                                vanzari[nrvanzari++] = new masina(linie);
                            }
                            
                        }
                        for (int i =0 ; i <nrvanzari; i++)
                        {
                            Console.WriteLine(vanzari[i].ConversieLaSir());
                        }
                        break;
                    case "V":
                        Console.WriteLine("itroduceti numele vanzatorului pe care doriti sa il schimbati");
                        string NumeV = Console.ReadLine();
                        Console.WriteLine("introduceti nume nou al vanzatorului");
                        string numenou = Console.ReadLine();
                        cautareVanzator(vanzari, NumeV,numenou);
                        

                        
                            break;
                        
                 }
             } while (optiune.ToUpper() != "X");
            Console.ReadKey();
        }
         public static masina CitireTastatura()
         {
             Console.WriteLine("introduceti nume vanzator");
             string numev = Console.ReadLine();
             Console.WriteLine("introduceti nume cumparator");
             string numec = Console.ReadLine();
             Console.WriteLine("introduceti firma masinii");
             string numef = Console.ReadLine();
             Console.WriteLine("introduceti modelul masinii");
             string numem = Console.ReadLine();
             masina m = new masina(numev, numec, numef, numem);
             return m;
         }
         public static void AfisareMasini(masina[] vanzari,int NrMasini)
         {
             Console.WriteLine("vanzarile sunt: ");
             for(int i=0; i<NrMasini;i++)
             {
                 Console.WriteLine( vanzari[i].ConversieLaSir());
                Console.ReadKey();
             }
         }
         public  static void cautareVanzator(masina[] vanzari,string numev,string numenou)
        { 

            int nrvanzari = 0;
            using (StreamReader sw = new StreamReader("vanzari.txt", true))
            {
                string linie;
               
                while ((linie = sw.ReadLine()) != null)
                {
                    vanzari[nrvanzari++] = new masina(linie);
                }
            }
            for (int i = 0; i < nrvanzari; i++)
            {
                if(vanzari[i].comp(numev)==true)
                {
                    vanzari[i].set(numenou);
                }
                    
            }
        }
    }
}
