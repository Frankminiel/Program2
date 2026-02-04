using System;

namespace Homerwork_1.Entidades
{
    namespace Homework_1.Entidades
    {
        public class membersfromcomunity

        {
            public string name { get; set; }
            public string greencard { get; set; }

            public void MostrarDatos()
            {
                Console.WriteLine($"Nombre: {name}");
                Console.WriteLine($"Cédula: {greencard}");
            }
        }
    }
}