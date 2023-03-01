//PUNTO 1

double TotalR;
double Result;

Console.WriteLine("ingrese renta trimestral del año: "); 
int RentaTri = Convert.ToInt32(Console.ReadLine());

if(RentaTri < 10000){
    TotalR = RentaTri*5/100;
    Console.WriteLine("El impuesto agregado es del 5%");
}else{
    if(RentaTri < 20000){
        TotalR =RentaTri*10/100;
        Console.WriteLine("El impuesto agregado es del 10%");
    }else{
        if(RentaTri < 35000){
            TotalR = RentaTri*15/100;
            Console.WriteLine("El impuesto agregado es del 15%");
        }else{
            if(RentaTri < 45000){
                TotalR = RentaTri*20/100;
                Console.WriteLine("El impuesto agregado es del 20%");
            }else{
                TotalR = RentaTri*30/100;
                Console.WriteLine("El impuesto agregado es del 30%");
            }
        }
    }
    Result = TotalR*4;
Console.WriteLine("Total renta a pagar con descuento es: $" + TotalR+ " La renta anual es: $" + Result);
} 
  // --------------------------------------------------------------------------------------------- 

