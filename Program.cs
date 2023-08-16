using Menu;


var platazos = new List<Platos>();

var plato =new Platos("tallarines",1500, 2); //Esto es con el constructor con items

//esto es si el constructor esta vacio
// plato.Nombre = "tallarines";
// plato.Precio = 1500;
// plato.Tamanio = 2;

Console.WriteLine("Plato: "+plato.Nombre);
Console.WriteLine("precio: "+plato.Precio);
Console.WriteLine("Tamaño: "+plato.Tamanio);

platazos.Add(plato);

platazos.Add(new Platos("pizza",2500, 4));
platazos.Add(new Platos("hamburguesa",2000, 1));

Console.WriteLine("Plato: "+platazos[1].Nombre);
Console.WriteLine("precio: "+platazos[1].Precio);
Console.WriteLine("Tamaño: "+platazos[1].Tamanio);


Console.WriteLine("\n");
Console.WriteLine("Menu completo\n"); 

foreach (var item in platazos)
{
    Console.WriteLine("Plato: "+item.Nombre);
    Console.WriteLine("precio: "+item.Precio);
    Console.WriteLine("Tamaño: "+item.Tamanio);
    Console.WriteLine("\n");
}