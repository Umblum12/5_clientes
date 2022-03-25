Datos[] estudiante = new Datos[5];
for (int i = 0; i <= 4; i++)
{
    Console.WriteLine("--------------------------------------------");
    Console.Write("Nombre del Cliente: ");
    estudiante[i].nombre = Console.ReadLine();
    Console.Write("Apellido del Cliente: ");
    estudiante[i].apellido = Console.ReadLine();
    Console.Write("Sexo del Cliente: ");
    estudiante[i].sexo = Console.ReadLine();
    Console.Write("Edad del Cliente: ");
    estudiante[i].edad = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------");
}

for (int i = 0; i <= 4; i++)
{
    Console.WriteLine("*------------------------------------------*");
    Console.WriteLine("Nombre: " + estudiante[i].nombre);
    Console.WriteLine("Apellido: " + estudiante[i].apellido);
    Console.WriteLine("Sexo: " + estudiante[i].sexo);
    Console.WriteLine("Edad: " + estudiante[i].edad);
    Console.WriteLine("*------------------------------------------*");
}

struct Datos
{
    public string nombre;
    public string apellido;
    public string sexo;
    public int edad;
}