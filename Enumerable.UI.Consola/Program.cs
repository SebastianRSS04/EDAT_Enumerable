using Enumerable.UI.Consola;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("Enumerable");
        Console.WriteLine("------------------------");
        Console.WriteLine("\n");
        Console.WriteLine("**Lista**             list<T>");

        #region Lista
        var lista = new List<Alumnos>
        {
            new Alumnos {Matricula = 1,Nombre = "Juan",Precio = 24.459M},
            new Alumnos {Matricula = 2,Nombre = "Jose",Precio = 22.456M},
            new Alumnos {Matricula = 3,Nombre = "lleny",Precio = 18.980M},
            new Alumnos {Matricula = 4,Nombre = "Larla",Precio = 17.233M},
            new Alumnos {Matricula = 5,Nombre = "Casco",Precio = 20.234M},
            new Alumnos {Matricula = 6,Nombre = "Mitzi",Precio = 15.233M},
            new Alumnos {Matricula = 7,Nombre = "Karla",Precio = 23.123M},
            new Alumnos {Matricula = 8,Nombre = "Isabel",Precio = 27.154M},
            new Alumnos {Matricula = 9,Nombre = "Zuri",Precio = 22.543M},
         

            
         
        };

        lista = lista.OrderBy(x => x.Precio).ToList();

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }


        #endregion
        Console.Read();
    }
    
}