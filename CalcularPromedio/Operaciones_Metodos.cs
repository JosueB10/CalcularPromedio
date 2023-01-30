using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPromedio
{
    public class Operaciones_Metodos
    {
        string Nom;
        string NE, NM, NF, NI;

        public Operaciones_Metodos()
        {
        }

        public Operaciones_Metodos(string nombre, string ne, string nm, string nf, string ni)
        {
            

            Nom = nombre;
            NE = ne;
            NM = nm;
            NF = nf;
            NI = ni;

        }


        //set y get 

        public string getNom()
        {

            return Nom;

        }

        public void setNom(string nombre)
        {

            Nom = nombre;

        }




        public string getNE()
        {

            return NE;

        }

        public void setNE(string ne)
        {

            NE = ne;

        }


        public string getNM()
        {

            return NM;

        }

        public void setNM(string nm)
        {

            NM = nm;

        }

        public string getNF()
        {

            return NF;

        }

        public void setNF(string nf)
        {

            NF = nf;

        }



        public string getNI()
        {

            return NI;

        }

        public void setNI(string ni)
        {

            NI = ni;

        }

        



    }
}
