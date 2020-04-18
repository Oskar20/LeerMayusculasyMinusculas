using System;

namespace LeerMayusculasyMinusculas
{
    class Program
    {

        private string cadena;
        private string verMayusculas = "";
        private string verMinusculas = "";
        private int n;
        private string[] Mayusculas;
        private string[] Minusculas;
        private string[] tempMy;
        private string[] tempMn;


        public Program(string cadena)
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new string[n];
            Minusculas = new string[n];
            tempMy = new string[n];
            tempMn = new string[n];
        }


        private string mayusculas()
        {
            for (int i = 0; i < n; i++)
            {
                //IsUpper indica si un ccáracter Unicod eestá categorizado como una letra mayúscula
                if (char.IsUpper(cadena[i]))
                {
                    tempMy[i] = Convert.ToString(cadena[i]);

                }
            }
            for (int i = 0; i < tempMy.Length; i++)
            {
                if (tempMy[i] != null)
                {
                    Mayusculas[i] = tempMy[i];
                    verMayusculas = $"{verMayusculas},{Mayusculas[i]}";
                }
            }
            return verMayusculas;
        }

        public string minusculas()
        {

            for (int i = 0; i < n; i++)
            {
                //IsUpper indica si un ccáracter Unicod eestá categorizado como una letra minúscula
                if (char.IsLower(cadena[i]))
                {
                    tempMn[i] = Convert.ToString(cadena[i]);

                }
            }


            for (int i = 0; i < tempMn.Length; i++)
            {
                if (tempMn[i] != null)
                {
                    Minusculas[i] = tempMy[i];
                    verMinusculas = $"{verMinusculas},{Minusculas[i]}";
                }
            }
            return verMinusculas;


        }

        static void Main(string[] args)
        {
            var cadena = Console.ReadLine();
            var data = new Program(cadena);
            Console.WriteLine("Las letras mayúsculas son : " + data.mayusculas() + "\n\n" + "Las Letras Minúsculas so: " + data.minusculas());

            Console.ReadLine();
        }
    }
}
