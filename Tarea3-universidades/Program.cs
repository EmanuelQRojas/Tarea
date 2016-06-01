using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tarea3_universidades
{
    class Program
    {
        
        struct estudiante {
            public int codigo;
            public string nombre;
            public int sexo;
            public int edad;

        }
        
        static int minimum = 5, menores=0, jovenes=0, adultos=0, hombres=0, mujeres=0;
        static int limit=minimum;
        static int contador = 0;
        
        static void AddStudent()
        {
            int sexo=0;
            int preguntar = 0;
            while (preguntar != 1)
            {
                Console.Clear();
                if (contador < estudiantes.Length)
                {
                    Console.WriteLine("-* Registro UH  *-*");
                    Console.WriteLine("Ingreso de Estudiantes.             ");
                    Console.Write("Digite el ID:                  ");
                    estudiantes[contador].codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del estudiante:    ");
                    estudiantes[contador].nombre = Console.ReadLine();
                    Console.Write("Digite el sexo del estudiante: 1-Masculino. 2-Femenino.    ");
                    sexo= Convert.ToInt32(Console.ReadLine());
                    estudiantes[contador].sexo = sexo;
                    if (sexo == 1)
                        hombres++;
                    if (sexo == 2)
                        mujeres++;
                    Console.WriteLine("Digite la edad del estudiante:");
                    estudiantes[contador].edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Desea agregar otro estudiante 0-Sí 1-No");
                    preguntar = int.Parse(Console.ReadLine());
                    contador++;
                }
                else
                {
                    Console.WriteLine("Registro de estudiantes lleno..");
                    preguntar = 1;
                    Console.ReadKey();
                }
            }

        }
        static void InitStudent()
        {
            int minimo = minimum;
            while (minimo>=0)
            {
                Console.Clear();
                if (contador < estudiantes.Length)
                {
                    Console.WriteLine("-* Registro UH  *-*");
                    Console.WriteLine("Ingreso de Estudiantes.             ");
                    Console.Write("Digite el ID:                  ");
                    estudiantes[contador].codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del estudiante:    ");
                    estudiantes[contador].nombre = Console.ReadLine();
                    Console.Write("Digite el sexo del estudiante: 1-Masculino. 2-Femenino.    ");
                    estudiantes[contador].sexo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite la edad del estudiante:");
                    estudiantes[contador].edad = Convert.ToInt32(Console.ReadLine());
                    
                    minimo--;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Registro de estudiantes lleno..");
                    Console.ReadKey();
                }
            }

        }
        static void ModifyStudent()
        {
            int sexo;
            int IDE = 0;
            int reg = 0;
            bool found = false;
            
                Console.Clear();
                Console.WriteLine("-* Registro UH  *-*");
                Console.WriteLine("Modificar Estudiante.           ");
                Console.WriteLine("Digite el codigo del estudiante a modificar");
                IDE = int.Parse(Console.ReadLine());
                for (int i = 0; i < estudiantes.Length; i++)
                {
                    if (IDE == estudiantes[i].codigo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.Write("Digite el codigo:                  ");
                        estudiantes[contador].codigo = int.Parse(Console.ReadLine());
                        Console.Write("Digite el nombre del estudiante:    ");
                        estudiantes[contador].nombre = Console.ReadLine();
                    Console.Write("Digite el sexo del estudiante: 1-Masculino. 2-Femenino.    ");
                    sexo = Convert.ToInt32(Console.ReadLine());
                    estudiantes[contador].sexo = sexo;
                    if (sexo == 1)
                        hombres++;
                    if (sexo == 2)
                        mujeres++;
                    Console.WriteLine("Digite la edad del estudiante:");
                        estudiantes[contador].edad = Convert.ToInt32(Console.ReadLine());
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
             
        }
        static void DeleteStudent()
        {
            int IDE = 0;
            int reg = 0;
            int check=0;
            bool found = false;
            
                Console.Clear();
                Console.WriteLine("-* Registro UH  *-*");
                Console.WriteLine("Modificar Estudiante.           ");
                Console.WriteLine("Digite el codigo del estudiante a modificar");
                IDE = int.Parse(Console.ReadLine());
                for (int i = 0; i < estudiantes.Length; i++)
                {
                    if (IDE == estudiantes[i].codigo)
                    {
                        Console.WriteLine("Seguro que desea eliminar éste libro?" +
                            "1.Sí\n2.No");
                        check = Convert.ToInt32(Console.ReadLine());
                        if (check == 1)
                        {
                            reg = i + 1;
                            Console.WriteLine("Registro: " + reg);
                            estudiantes[contador].codigo = 0;
                            estudiantes[contador].nombre = "";
                        if (estudiantes[contador].sexo == 1)
                            hombres--;
                        if (estudiantes[contador].sexo == 2)
                            mujeres--;
                            estudiantes[contador].sexo = 0;
                            estudiantes[contador].edad = 0;
                        contador--;
                        }
                        found = true;
                    }
                    }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
            
        }
        static void SeekStudent()
        {
            int codigo = 0;
            int reg = 0;
            int preguntar = 0;
            bool found = false;
            while (preguntar != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Registro UH  *-*");
                Console.WriteLine("Búsquedad de estudiantes.           ");
                Console.WriteLine("Digite el codigo del estudiante a buscar");
                codigo = int.Parse(Console.ReadLine());
                for (int i = 0; i < estudiantes.Length; i++)
                {
                    if (codigo == estudiantes[i].codigo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo:       " + estudiantes[i].codigo);
                        Console.WriteLine("Nombre:   " + estudiantes[i].nombre);
                        Console.WriteLine("Sexo:     " + estudiantes[i].sexo);
                        Console.WriteLine("Edad:   " + estudiantes[i].edad);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese codigo");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro estudiante 0-Sí 1-No");
                preguntar = int.Parse(Console.ReadLine());
            }
        }
        static void PrintList() {
            Console.Clear();
            Console.WriteLine("===================================================================");
            Console.WriteLine("*-*                  Listado Estudiantil                    *-*");
            Console.WriteLine("===================================================================");
            Console.WriteLine("Universidad UH\t\t\t\t");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Reg\t\t\tCódigo\t\t\tNombre\t\t\t\t\tSexo\t\t\tEdad");
            for (int i = 0; i < estudiantes.Length; i++) {
                int reg = i + 1;
                if (estudiantes[i].codigo!=0) {
                    Console.WriteLine(reg+"\t"+estudiantes[i].codigo+"\t"+estudiantes[i].nombre+"\t"+estudiantes[i].sexo+
                        "\t"+estudiantes[i].edad) ;
                    Console.WriteLine("===================================================================");
                    Console.WriteLine("Fin de Informe");
                    Console.ReadKey();
                }
            }
        }
        static estudiante[] estudiantes = new estudiante[limit];
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("Ingrese el numero maximo de estudiantes a procesar: ");
            limit=Convert.ToInt32(Console.ReadLine());
            
            InitStudent();
            do {
                Console.WriteLine("Menú principal"+
"1.Ingreso de estudiantes\n"+
"2.Modificación de estudiantes\n"+
"3.Borrado de estudiantes\n"+
"4.Búsqueda de estudiantes\n"+
"5.Listado de estudiantes\n"+
"6.Informe clasificación de estudiantes\n"+
"7.Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion) {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ModifyStudent();
                        break;
                    case 3:
                        DeleteStudent();
                        break;
                    case 4:
                        SeekStudent();
                        break;
                    case 5:
                        PrintList();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Por favor ingrese una opcion valida.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opcion!=7);
        }
    }
}
