//aqui abrimos directorios y eso
using System.IO;//Manejo de archivos  using Sistem.io
using Personas;

// Leyendo disco lógicos 
            List<string> Discos = Directory.GetLogicalDrives().ToList();
            foreach (string discoX in Discos)
            {
                Console.WriteLine(discoX);
            }
            Console.ReadKey();

            //listar Carpetas o directorios del disco C:\
            List<string> ListadoDeCarpetas = Directory.GetDirectories(@"c:\").ToList();
            foreach (string CarpetaY in ListadoDeCarpetas)
            {
                Console.WriteLine(CarpetaY);
            }

            Console.ReadKey();

            // obtiene información de un determinado directorio 
            string Directorio = @"D:\Pruebas"; // aquí debes poner un directorio propio de tu pc 
            string info = Directory.GetDirectoryRoot(Directorio);

            Console.WriteLine("Info sobre la raiz del directorio: " + info);

            Console.ReadKey();

            // Ksuta Carpetas del directorio ingresado anteriormente
            List<string> ListadoDeCarpetasEnRepo = Directory.GetDirectories(Directorio).ToList();
            Console.WriteLine("------------------------ ");
            Console.WriteLine("Carpetas en repositorio - " + Directorio);
            foreach (string Carpeta in ListadoDeCarpetasEnRepo)
            {
                Console.WriteLine(Carpeta);
            }

            //obtiene la ruta de windows desde la variables de ambiente 
            string winDir = System.Environment.GetEnvironmentVariable("windir");
            
            //Información de un determinado archivo. (en este caso es Notepad.exe)
            FileInfo FileOp = new FileInfo(winDir + "\\Notepad.exe");
            Console.WriteLine("File Name = " + FileOp.FullName);
            Console.WriteLine("Creation Time = " + FileOp.CreationTime);
            Console.WriteLine("Last Access Time = " + FileOp.LastAccessTime);
            Console.WriteLine("Last Write TIme = " + FileOp.LastWriteTime);
            Console.WriteLine("Size = {0} Kb", ((FileOp.Length) / 2014));

            Console.WriteLine();

            if(!(Directory.Exists(Directorio + @"\Tempo")))
            {
                Directory.CreateDirectory(Directorio + @"\Tempo");
            }
            
            // Listado de carpetas en respositorio
            List<string> ListadoDeCarpetasEnRepo2 = Directory.GetDirectories(Directorio).ToList();
            Console.WriteLine("------------------------ ");
            Console.WriteLine("Carpetas en repositorio - " + Directorio);
            foreach (string Carpeta in ListadoDeCarpetasEnRepo2)
            {
                Console.WriteLine(Carpeta);
            }

            //Utilizando el objeto File 
            string NuevoArchivo = Directorio + @"\Tempo" + @"\Prueba.txt";
            string NuevoArchivoCopia = Directorio + @"\Tempo" + @"\Prueba_Copia.txt";
            
            //Controla si el archivo existe, en caso de no existir lo crea
            if (!File.Exists(NuevoArchivo))
            {
                File.Create(NuevoArchivo);// crea el archivo en la ruta especificada 
            }
            
            // Mueve un archivo de una ubicación a otra
            // File.Move(NuevoArchivo, NuevoArchivoCopia);

            //Lee un archivo , libreria StreamReader.

            string RutaArchivo = NuevoArchivoCopia;
            if (File.Exists(RutaArchivo))
            {
                FileStream Fstream = new FileStream(RutaArchivo, FileMode.Open);
                StreamReader Streamr = new StreamReader(Fstream);

                string linea;
                do 
                {
                    linea = Streamr.ReadLine(); // lee una linea completa
                    Console.WriteLine(linea);

                } while (linea != null);

                
                Streamr.Close();

            }
            else
            {
                Console.WriteLine("Archivo no encontrado : {0}",RutaArchivo);
            }



            //ahora vamos a escribir en el archivo de texto
            string RutaArchivo2 = @"D:\pruebas\prueba2.txt";
            if (!File.Exists(RutaArchivo2))
            {
                File.Create(NuevoArchivo);// crea el archivo en la ruta especificada 
            }
            

            string texto = File.ReadAllText(RutaArchivo); //lee todo el texto del archivo
            Console.WriteLine("Contenido: {0}", texto);

            List<string> LineasDelArchivo = File.ReadAllLines(RutaArchivo).ToList();

            foreach (string Linea in LineasDelArchivo)
            {
                Console.WriteLine("\t" + Linea);
            }   


            string[] MisLineas = { "Prueba 1 ", "Prueba 2" };
            File.WriteAllLines(RutaArchivo, MisLineas);
            
        
            









// ENUM

// mes mesActual = mes.Enero;
// Console.WriteLine(mesActual);//aqui me devuelve el string 
// Console.WriteLine((int)mesActual); //aqui en numero

// mes miMes = mes.Febrero | mes.Febrero;
// Console.WriteLine((int)miMes);//me devuelve la suma de los enum mencionados


// [Flags]
// enum mes
// {
//     Enero = 1,
//     Febrero = 2,
//     Marzo =3,
//     Abril = 4,
//     Mayo = 5,
//     Junio = 6    
// }

// //--------------------COLECCIONES

// List<int> lista= new List<int>(); //inicializo lista
// Dictionary<int,string> diccionario=new Dictionary<int, string>();//inicializo diccionario 

// Console.WriteLine("Lista: ");
// mostrarLista(lista);
// Console.WriteLine("Diccionario:");
// mostrarDiccionario(diccionario);

// //agregar elementos
// lista.Add(3);
// lista.Add(5);
// Console.WriteLine("Lista: "+lista+"\n");
// Console.WriteLine("Lista: ");
// mostrarLista(lista);
// Console.WriteLine("Lista: ");
// mostrarLista(lista);
// diccionario.Add(1,"a");
// diccionario.Add(2,"b");
// Console.WriteLine("Diccionario: ");
// mostrarDiccionario(diccionario);

// //quitar elementos
// lista.Remove(3);
// Console.WriteLine("Lista: ");
// mostrarLista(lista);
// diccionario.Remove(1);
// Console.WriteLine("Diccionario: ");
// mostrarDiccionario(diccionario);

// //concatenar elementos
// lista.Concat(lista);//solo funciona en strings
// Console.WriteLine("Lista: ");
// mostrarLista(lista);



// void mostrarLista (List<int> lista)
// {
//     foreach (var item in lista)
//     {
//         Console.WriteLine(item);
//     }
// }

// void mostrarDiccionario (Dictionary<int,string> diccionario)
// {
//     foreach (var item in diccionario)
//     {
//         Console.WriteLine(item);
//     }
// }

// //ARREGLOS Y MATRICES
// int [] arreglo1=new int[3];
// int [] arreglo2={1,2,3};

// int arre;
// //arreglo
// arreglo1[0]=1;
// arre=arreglo1[0];
// Console.WriteLine(arre);

// Personal [] arreglo3 = new Personal[3];



// //matrices
// int [,] matriz1 = new int[2,2];
// string [,] matriz2 = {{"a","b","c"},{"d","e","f"}};


//dato generico <T> (NO SALIO)
// MiClase<int> instancia = new MiClase<int>();

// //listas
// public class MiClase <T>
// {
//     T Value;

//     public T Value1 { get => Value; }

//     public MiClase(T t)
//     {
//         Value=t;
//     }
// }





// LlenarMatriz(matriz1);


// void LlenarMatriz(int[,] matriz1)
// {
//     int i=0,j=0;
//     for (i=0; i < 2; i++)
//     {
//         for ( j = 0; j < 2; j++)
//         {
//             int rand=new Random().Next(140,203);
//             matriz1[i,j]=rand;
//             Console.WriteLine(matriz1[i,j]);
//         }
//     }



// FOREACH PARA COPIAS SIN METODO (UNA CACA)
// foreach (var item in arreglo3)
// {
//     // int rand=new Random().Next(140,203);
    
//     var rand = new Random();
//     var pers = new Personal();
//     pers.Nombre=""+i;
//     pers.Altura=rand.Next(140,205);
//     Console.WriteLine(pers.Nombre);
//     Console.WriteLine(pers.Altura);
//     i++;
// }


