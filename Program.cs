using Menu;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;
using monedaSpace;

var url = $"https://api.coindesk.com/v1/bpi/currentprice.json";
var request = (HttpWebRequest) WebRequest.Create(url);
request.Method="GET";
request.ContentType="application/json.";
request.Accept="application/json";

try
{
    using (WebResponse response = (HttpWebResponse)request.GetResponse())//obtengo la respuesta del recurso online
    {
        using (var sr = new StreamReader (response.GetResponseStream()))//convierte la respuesta en un un stream (flujo de datos)
        {
            if (sr != null)
            {
                string text = sr.ReadToEnd(); //convierto el sr en un string
                Moneda? moneda = JsonSerializer.Deserialize<Moneda>(text);    //para pasar lo obtenido del json a los atributos de mi clase

                Console.WriteLine("PRECIOS DE BITCOIN EN DIFERENTES MONEDAS: ");
                Console.WriteLine("\nUSD= U$S"+moneda.bpi.USD.rate);
                Console.WriteLine("\nEUR= €"+moneda.bpi.EUR.rate);
                Console.WriteLine("\nGBR= £"+moneda.bpi.GBP.rate);
                Console.WriteLine("");
                Console.WriteLine("Ingrese un tipo de cambio");
                Console.WriteLine("\n1- USD");
                Console.WriteLine("\n2- EUR");
                Console.WriteLine("\n3- GBR");
                Console.WriteLine("");
                int opcion;
                bool ingreso = int.TryParse(Console.ReadLine(),out opcion);//asi ingreso el valor, si es true cambiaba el valor de opcion
                if (ingreso && opcion>=1 && opcion<=3)
                {
                    switch (opcion)
                    {
                        case 1: 
                
                                Console.WriteLine("\nCode: "+moneda.bpi.USD.code);
                                Console.WriteLine("\n Description: "+moneda.bpi.USD.description);
                                Console.WriteLine("\n Symbol: "+moneda.bpi.USD.symbol);
                                Console.WriteLine("\n Rate: "+moneda.bpi.USD.rate);
                                Console.WriteLine("\n Rate_float: "+moneda.bpi.USD.rate_float);
                                break;
                        case 2: 
                                Console.WriteLine("\nCode: "+moneda.bpi.EUR.code);
                                Console.WriteLine("\n Description: "+moneda.bpi.EUR.description);
                                Console.WriteLine("\n Symbol: "+moneda.bpi.EUR.symbol);
                                Console.WriteLine("\n Rate: "+moneda.bpi.EUR.rate);
                                Console.WriteLine("\n Rate_float: "+moneda.bpi.EUR.rate_float);
                                break;
                        default:
                                Console.WriteLine("\nCode: "+moneda.bpi.GBP.code);
                                Console.WriteLine("\n Description: "+moneda.bpi.GBP.description);
                                Console.WriteLine("\n Symbol: "+moneda.bpi.GBP.symbol);
                                Console.WriteLine("\n Rate: "+moneda.bpi.GBP.rate);
                                Console.WriteLine("\n Rate_float: "+moneda.bpi.GBP.rate_float);
                                break;
                    }
                }
                else{
                    Console.WriteLine("opcion invalida");
                }

                Console.WriteLine("Hora actualizada: "+moneda.time.updated);
            }
        }

    }
}
catch (WebException)
{
    Console.WriteLine("Problemas de acceso a la API");
    throw;
}






// string documento; 
// using (var fs = new FileStream("platos.json",FileMode.Open))//abrir el archivo
// {
//     using(var sr = new StreamReader(fs))// para leer
//     {
//        documento= sr.ReadToEnd(); 
//        sr.Close();
//     }
//     fs.Close();     
// }

// Console.WriteLine(documento);
// List<Platos>? plato = JsonSerializer.Deserialize<List<Platos>>(documento);
// Console.WriteLine($"Nombre: {plato[0].Nombre}");
// Console.WriteLine($"Precio: {plato[0].Precio}");
// Console.WriteLine($"stock: {plato[0].Stock}");

// // List<Platitos>? listadoPlatos = JsonSerializer.DeserializeAsync<List<Platitos>>(documento);
// // Console.WriteLine(""+plato.Nombre);

// foreach (var item in plato)
// {   
//     Console.WriteLine($"{item.Nombre}");
//     Console.WriteLine($"{item.Precio}");
//     Console.WriteLine($"{item.Stock}");
//     Console.WriteLine("\n");
// }//lo hiceeeeeeeeee, asi se lee un json!!!

// var fst = new FileStream("platos.json",FileMode.Create);
// Platos LALA = new Platos("milanga",4000,6);
// plato.Add(LALA);
// var options = new JsonSerializerOptions { WriteIndented = true };//para darle un formato mas limpio al json
// string acrchivoJson = JsonSerializer.Serialize(plato,options);
// using (var sw =new StreamWriter(fst))
// {
//     sw.WriteLine(acrchivoJson);
//     sw.Close();
// }//PARA CREAR UN JSON y guardar o solo guardar y funcionooooooooooo giiiiiiiiiiiiiiil
// fst.Close();



// using (var csv = new FileStream("pruebaCSV.csv",FileMode.Open))//abrir el archivo
// {   
//     using (var sw = new StreamWriter(csv))
//     {
//         sw.WriteLine("cacahuate");
//         sw.Close();
//     }
// }

//para modificar el csv

// List<string> modificar = new List<string>();
// using (var csv = new FileStream("pruebaCSV.csv",FileMode.Open))//abrir el archivo
// {
//     using(var sr = new StreamReader(csv))// para leer
//     {
//         while (!sr.EndOfStream)
//         {
//         string linea = sr.ReadLine();
//         string[] fields = linea.Split(';');//para leer cada uno de los elementos hasta el ;
//         //hago las modificaciones
//         // string agregar = string.Join(";","cebolla");

//         fields[4]=fields[4] + "laal";
//         Console.WriteLine("{4}",fields);
//         string extra ="mpalta";
//         string[] extra2 = new string[]{"cebolla"};
//         List<string> modified = new List<string>(fields);//creo una lista de strings
//         Console.WriteLine("\n Capacidad: {0}",modified.Capacity);
//         modified.Add(extra);
//         modified.InsertRange(3,extra2);

//         foreach (string item in modified)//para mostrar cada uno de los elementos
//         {

//             Console.WriteLine(item + "\t");
//         }
//         Console.WriteLine("");

//         string aux = string.Join(";",modified.ToArray()); 
//         Console.WriteLine(""+aux);
        
//         modificar.Add(aux);
//         }
//     }
    
//     csv.Close();
// }

// Console.WriteLine("\t MODIFICADA");
// Console.WriteLine(modificar[0]);

// using (var csv = new FileStream("pruebaCSV.csv",FileMode.Open))//abrir el archivo
// {   
//     using (var sw = new StreamWriter(csv))
//     {
//         foreach (var item in modificar)
//         {
//             sw.WriteLine(item);       
//         }
//     }
//     csv.Close();
// }

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