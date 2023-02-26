// Pizzería

//Declaro la variable del ingrediente
string ingrediente = "";

//Solicito que tipo de pizza desea
Console.WriteLine("Que tipo de pizza deseas: \n Ingresa Vegatariana o No Vegetariana");

//Declaro y obtengo la pizza que desea
string pizza = Console.ReadLine();

//Aplico las reglas de negocio con condicionales e imprimo la solicitud
if(pizza == "Vegetariana"){
    Console.WriteLine("------Menú Pizzas el Fercho------\n Ingredientes: \n **TODAS LAS PIZZAS LLEVAN MOZZARELLA Y TOMATE**\n 1.Pimiento \n 2.Champiñones \n Escribe con que ingrediente la deseas: ");
     ingrediente = Console.ReadLine();
    if(ingrediente == "Pimiento" || ingrediente == "Champiñones" ){
    Console.WriteLine("Tu pizza es vegetariana y viene con mozzarella, tomate y "+ingrediente);
    Environment.Exit(0);
    }else{
        Console.WriteLine("No has ingresado una opción valida");
        Environment.Exit(0);
    }
}
if(pizza == "No Vegetariana"){
    Console.WriteLine("------Menú Pizzas el Fercho------\n Ingredientes: \n **TODAS LAS PIZZAS LLEVAN MOZZARELLA Y TOMATE**\n 1.Pepperoni \n 2.Salami \n 2.Pollo \n Escribe con que ingrediente la deseas: ");
     ingrediente = Console.ReadLine();
    if(ingrediente == "Pepperoni" || ingrediente == "Salami" || ingrediente == "Pollo"){
    Console.WriteLine("Tu pizza no es vegetariana y viene con mozzarella, tomate y "+ingrediente);
    Environment.Exit(0);
    }else{
        Console.WriteLine("No has ingresado una opción valida");
        Environment.Exit(0);
    }
}else{
    Console.WriteLine("No has ingresado una opción valida");
}



