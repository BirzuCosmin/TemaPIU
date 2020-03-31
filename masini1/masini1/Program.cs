using System;
namespace masini
{
    class masina
    {

        string nume_vanzator;
       private  string nume_cumparator;
        private string firma;
       private  string model;
        public static int IdUltimaVanare { get; set; } = 0;
     
        public enum culoare
        {
            rosu = 1,
            albastru = 2,
            alb = 3,
            negru = 4,
            gri = 5,
            verde = 6
        };
        public enum dotari
        {
            aer_conditionat = 1,
            navigatie = 2,
            senzori_parcare = 3,
            cruise_control = 4,
        };
        public masina()
        {
            nume_vanzator = string.Empty;
            nume_cumparator = string.Empty;
            firma = string.Empty;
            model = string.Empty;
        }
        public masina(string nume_v, string nume_c, string _firma, string _model)
        {
            nume_vanzator = nume_v;
            nume_cumparator = nume_c;
            firma = _firma;
            model = _model;
        }
        public masina(string date)
        {
            string[] data = date.Split(" ");
            nume_vanzator = data[0];
            nume_cumparator = data[1];
            firma = data[2];
            model = data[3];

        }
        public string ConversieLaSir()
        {
            string sir;
            sir = string.Join(" ",nume_vanzator, nume_cumparator, firma, model);
            return sir;
        }

        public string info()
        {
            return string.Format("vanzatorul este {0}, cumparatorul este {1}, firma este {2}, modelul este {3}", nume_vanzator, nume_cumparator, firma, model);
        }
        public bool Comparatie (masina a)
        {
            if (a.nume_cumparator == nume_cumparator && a.nume_vanzator == nume_vanzator && a.firma ==firma && a.model == model)
                return true;
            else
                return false;
                
        }
        public bool comp( string nume)
        { if (nume_vanzator == nume)
                return true;
            else
                return false;

        
        }
        public string set(string Numev)
        {
            nume_cumparator = Numev;
            return null;
        }
        
    }
}
