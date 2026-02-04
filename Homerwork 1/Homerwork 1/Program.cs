using Homerwork_1.Personal;
using Homerwork_1.Entidades;
namespace MapaClassPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Maestro
            teacher maestro = new teacher();
            maestro.name = "Juan Pérez";
            maestro.age = 35;
            maestro.subject = "Matemáticas";
            maestro.lever = "Secundaria";

            // Administrador
            admin admin = new admin();
            admin.name = "María Rodríguez";
            admin.age = 40;
            admin.subject = "Gestión";
            admin.AreaAdministrada = "Recursos Humanos";

            // Administrativo
            Administrativo administrative = new Administrativo();
            administrative.Name = "Carlos Gómez";
            administrative.age = 30;
            administrative.Department= "Finanzas";

            // Mostrar resultados
            Console.WriteLine("=== PERSONAL DEL CENTRO EDICATIVO TODOS PODEMOS APRENDER ===\n");

            Console.WriteLine("Maestro:");
            Console.WriteLine($"Nombre: {maestro.name}");
            Console.WriteLine($"Edad: {maestro.age}");
            Console.WriteLine($"Materia: {maestro.subject}");
            Console.WriteLine($"Nivel: {maestro.lever}\n");

            Console.WriteLine("Administrador:");
            Console.WriteLine($"Nombre: {admin.name}");
            Console.WriteLine($"Edad: {admin.age}");
            Console.WriteLine($"Materia: {admin.subject}");
            Console.WriteLine($"Área: {admin.AreaAdministrada}\n");

            Console.WriteLine("Administrativo:");
            Console.WriteLine($"Nombre: {administrative.Name}");
            Console.WriteLine($"Edad: {administrative.age}");
            Console.WriteLine($"Departamento: {administrative.Department}");

            Console.ReadKey();
        }
    }
}
