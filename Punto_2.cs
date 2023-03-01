//PUNTO 2


double PrecioB = 15000;
double Total=0, Result=0;

Console.WriteLine("ingrese el nombre completo: "); 
string? NombreC = Console.ReadLine();

Console.WriteLine("ingrese la edad: "); 
int Edad = Convert.ToInt32(Console.ReadLine());

if (Edad < 4){
    PrecioB = 0;
    Console.WriteLine("El usuario " + NombreC + " es menor de edad, su edad es " + Edad + " años, su entrada es gratis");
    Environment.Exit(Environment.ExitCode);
}else{
    if (Edad < 18){
        Total = PrecioB * 0.05;
        Result = PrecioB - Total;
        Console.WriteLine("El usuario " +NombreC+ " el precio de la entrada es: " +Result+ " se le aplica el descuento del 5%");
        Environment.Exit(Environment.ExitCode);
    }else{
        if (Edad > 18){
            Total = PrecioB * 0.03;
            Result = PrecioB - Total;
            Console.WriteLine("El usuario: " +NombreC+ " tiene un precio de entrada de: " +Result+ " tiene un descuento del 3%");
        Environment.Exit(Environment.ExitCode);
        }
    }
}
    


   
