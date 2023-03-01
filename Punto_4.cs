//PUNTO 4

double Bonificacion=50000;

double Inaceptable = 0;
double Aceptable = 0.4;
double Meritorio = 0.6;

double puntaje=0;

Console.Write("ingresa el puntaje a validar: ");
double Nota=double.Parse(Console.ReadLine());

if(Nota == Inaceptable){
    Console.WriteLine("Su desempeño es inaceptable");
    Console.WriteLine("Se debe cobrar: "+(Bonificacion*Nota)+"$");
    Environment.Exit(0);
} else{

      if(Nota == Aceptable){
          Console.WriteLine("Su desempeño es aceptable");
          Console.WriteLine("Se debe cobrar: "+(Bonificacion*Nota)+"$");
          Environment.Exit(0);
      } else{

              if(Nota == Meritorio){
                    Console.WriteLine("Su desempeño es meritorio");
                    Console.WriteLine("Se debe cobrar: "+(Bonificacion*Nota)+"$");
                    Environment.Exit(0);
              } else{
                    Console.WriteLine("El número digitado no es valido");
                }
        }
    }
     
  
  // --------------------------------------------------------------------------------------------- 

