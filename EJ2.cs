// Sala de juegos - José David Romero

//Solcito los datos por consola
Console.WriteLine("Ingrese su nombre completo: ");
string complete_name = Console.ReadLine();
Console.WriteLine("Ingrese su edad: ");
int age = Int32.Parse(Console.ReadLine());

//Creo las variables con las reglas de negocio
string discount_0 = "Gratis niñ@!";
double discount_1 = 0.05;
double discount_2 = 0.03;
double access = 15000;


//Aplico las condiciones de negocio, una vez cumplida calculo, imprimo y corto las condición para que no siga
if(age < 4){
Console.WriteLine(complete_name+" la entrada es: "+ discount_0);
Environment.Exit(0);
}
if(age >= 4 && age <= 18){
    access = access - (access*discount_1);
    Console.WriteLine(complete_name+" la entrada tiene un valor de: "+access+" aplicado un descuento del: "+discount_1.ToString("0.0%"));
    Environment.Exit(0);
}else{
    access = access - (access*discount_2);
    Console.WriteLine(complete_name+" la entrada tiene un valor de: "+access+" aplicado un descuento del: "+discount_2.ToString("0.0%"));
    Environment.Exit(0);
}