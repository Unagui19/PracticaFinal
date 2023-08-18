using Menu;
using System.IO;

var path="disponibles.txt";
var path2="pepe.tct";

if (File.Exists(path))
{
    Console.WriteLine("TRUE");
    Console.WriteLine("");
    string cadena = File.ReadAllText(path);//para leer todo el texto del archivo
    Console.WriteLine(""+cadena);
    Console.WriteLine("");

    var listaDeCadenas = File.ReadAllLines(path).ToList();//para leer linea por linea el texto del archivo
    
    foreach (var item in listaDeCadenas)
    {
        Console.WriteLine(""+item);
    }
    Console.WriteLine("");


}
else{
    Console.WriteLine("False");
}

// var verduras = new FileStream("pruebaCSV.csv",FileMode.Open);//abrir el archivo
// var sr = new StreamReader(verduras);//instanciar para leer

// var res=verduras.capa;
// Console.WriteLine(res);


using (var verduras = new FileStream("pruebaCSV.csv",FileMode.Open))//abrir el archivo
{
    using(var sr = new StreamReader(verduras))// para leer
    {
        while (!sr.EndOfStream)
        {
        string line = sr.ReadLine();
        string[] fields = line.Split(';');//para leer cada uno de los elementos hasta el ;

        foreach (string field in fields)//para mostrar cada uno de los elementos
        {
            Console.WriteLine(field + "\t");
        }
        Console.WriteLine("");
        // aux = sr.ReadToEnd();
        // verduras.Close();
        }
    }
    verduras.Close();
}
        // Console.WriteLine("");

// using (var csv = new FileStream("pruebaCSV.csv",FileMode.Open))//abrir el archivo
// {   
//     using (var sw = new StreamWriter(csv))
//     {
//         sw.WriteLine("cacahuate");
//         sw.Close();
//     }
// }

//para modificar el csv

List<string> modificar = new List<string>();
using (var csv = new FileStream("pruebaCSV.csv",FileMode.Open))//abrir el archivo
{
    using(var sr = new StreamReader(csv))// para leer
    {
        while (!sr.EndOfStream)
        {
        string linea = sr.ReadLine();
        string[] fields = linea.Split(';');//para leer cada uno de los elementos hasta el ;
        //hago las modificaciones
        // string agregar = string.Join(";","cebolla");

        fields[4]=fields[4] + "laal";
        Console.WriteLine("{4}",fields);
        string extra ="mpalta";
        string[] extra2 = new string[]{"cebolla"};
        List<string> modified = new List<string>(fields);//creo una lista de strings
        Console.WriteLine("\n Capacidad: {0}",modified.Capacity);
        modified.Add(extra);
        modified.InsertRange(3,extra2);

        foreach (string item in modified)//para mostrar cada uno de los elementos
        {

            Console.WriteLine(item + "\t");
        }
        Console.WriteLine("");

        string aux = string.Join(";",modified.ToArray()); 
        Console.WriteLine(""+aux);
        
        modificar.Add(aux);
        }
    }
    
    csv.Close();
}

Console.WriteLine("\t MODIFICADA");
Console.WriteLine(modificar[0]);

using (var csv = new FileStream("pruebaCSV.csv",FileMode.Open))//abrir el archivo
{   
    using (var sw = new StreamWriter(csv))
    {
        foreach (var item in modificar)
        {
            sw.WriteLine(item);       
        }
    }
    csv.Close();
}

// //PARA LEER ARCHIVOS JSON REALMENTE
// string verdura;
// using(var verduras = new FileStream("pruebaCSV.csv",FileMode.Open))    //abrir el archivo a leer
// {
//     using (var leerCsv = new StreamReader(verduras))//leo el archivo 
//     {
//         verdura=leerCsv.ReadToEnd();
//         verduras.Close();        
//     }
// }

// foreach (var item in verdura)
// {
//     Console.WriteLine(""+item);
// }


// var platazos = new List<Platos>();

// var plato =new Platos("tallarines",1500, 2); //Esto es con el constructor con items

// //esto es si el constructor esta vacio
// // plato.Nombre = "tallarines";
// // plato.Precio = 1500;
// // plato.Tamanio = 2;

// Console.WriteLine("Plato: "+plato.Nombre);
// Console.WriteLine("precio: "+plato.Precio);
// Console.WriteLine("Tamaño: "+plato.Tamanio);

// platazos.Add(plato);

// platazos.Add(new Platos("pizza",2500, 4));
// platazos.Add(new Platos("hamburguesa",2000, 1));

// Console.WriteLine("Plato: "+platazos[1].Nombre);
// Console.WriteLine("precio: "+platazos[1].Precio);
// Console.WriteLine("Tamaño: "+platazos[1].Tamanio);


// Console.WriteLine("\n");
// Console.WriteLine("Menu completo\n"); 

// foreach (var item in platazos)
// {
//     Console.WriteLine("Plato: "+item.Nombre);
//     Console.WriteLine("precio: "+item.Precio);
//     Console.WriteLine("Tamaño: "+item.Tamanio);
//     Console.WriteLine("\n");
// }