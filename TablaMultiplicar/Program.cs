int numTabla,inicioTabla, finTabla, producto;

Console.WriteLine("Ingrese el número de la tabla que desea");
numTabla = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el multiplicador con el cual quiere que empiece la tabla");
inicioTabla = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el multiplicador con el cual quiere que termine la tabla");
finTabla = int.Parse(Console.ReadLine());

for (int i = inicioTabla; i <= finTabla; i ++) 
{
    
    producto = numTabla * i;
    Console.WriteLine (numTabla+"*"+i+"="+producto);

}




