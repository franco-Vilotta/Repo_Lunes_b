using System;
using System.Linq;
using System.Collections.Generic;

namespace linq_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de linq para el miercoles");

            int[]  arrPuntajes = new int[] {2,2,85, 60,30,15,20,61};

            string[] arrNombres= new string[]{"Franco","Walter","Gustavo","Avel","Florencia","Walter"};

            
            IEnumerable<string> consultaNombres= 
            from vNombre
            in arrNombres
            where 
                 vNombre == "Walter"
            select vNombre;

            //va "=="

            //60,61

        //Consulta de Sinstaxis
        IEnumerable<int> consultaLinq  =
            from  vEntero                    
            in    arrPuntajes                  
            where vEntero > 50
            select vEntero             ;


                foreach (string strNombre in consultaNombres)
                {
                    Console.WriteLine("nombre:" + strNombre);
                }



        }
    }
}
