//PUNTO 3


Console.WriteLine(" Bienvenidos a Pizzas el Fercho ");
Console.WriteLine("Qué pizza desea ordenar ? \n");
Console.WriteLine("1. Pizza Vegetariana");
Console.WriteLine("2. Pizza no Vegetariana.");

string Op = Console.ReadLine();
Console.Clear();    //borra la consola si la consola lo permite. 

//PIZZA VEGETARIANA
switch(Op){

    case"1":
        Console.WriteLine("Pizza Vegetariana");
        Console.WriteLine("Escoja sus ingredientes para la pizza\n");
        Console.WriteLine("1. Pimiento");
        Console.WriteLine("2. Champiñones");

        string Op1=Console.ReadLine();

        switch(Op1){

            case"1":
                Console.WriteLine("La pizza es vegetariana");
                Console.WriteLine("Tendra los siguientes ingredientes Tomate, Mozarella y Pimiento");
            break;
            case"2":
                Console.WriteLine("La pizza es vegetariana");
                Console.WriteLine("Tendra los siguientes ingredientes Tomate, Mozarella y Champiñones");
            break;
        }break;

            // PIZZA NO VEGETARIANA
            case"2":
                Console.WriteLine("Pizza no vegetariana");
                Console.WriteLine("Escoja sus ingredientes para la pizza\n");
                Console.WriteLine("1. Pepperoni");
                Console.WriteLine("2. Salami");
                Console.WriteLine("3. Pollo");

            string Op2=Console.ReadLine();

                    switch(Op2){
                        case"1":
                            Console.WriteLine("La pizza no es vegetariana");
                            Console.WriteLine("Tendra los siguientes ingredientes Tomate, Mozarella y Pepperoni");
                        break;
                        case"2":
                            Console.WriteLine("La pizza no es vegetariana");
                            Console.WriteLine("Tendra los siguientes ingredientes Tomate, Mozarella y Salami");
                        break;
                        case"3":
                            Console.WriteLine("La pizza no es vegetariana");
                            Console.WriteLine("Tendra los siguientes ingredientes Tomate, Mozarella y Pollo");
                        break;

                    }break;
}

  // --------------------------------------------------------------------------------------------- 

