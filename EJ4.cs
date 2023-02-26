// Premios en una empresa

//Declaro las puntuaciones
double score_0 = 0.0;
double score_1 = 0.4;
double score_2 = 0.6;
double bonus = 50000;

//Solicito ingreso de nivel
Console.WriteLine("Niveles: \n -Inaceptable \n -Aceptable \n -Meritorio \n Ingrese el Nivel:");
string level = Console.ReadLine();

//Aplico reglas de negocio, calculo e imprimo bonus deacuerdo al nivel
if( level == "Inaceptable"){
     bonus = bonus * score_0;
     Console.WriteLine("Su nivel de evalución es: "+level+" para un bono de: "+ bonus);
     Environment.Exit(0);
}
if( level == "Aceptable"){
     bonus = bonus * score_1;
     Console.WriteLine("Su nivel de evalución es: "+level+" para un bono de: "+ bonus);
     Environment.Exit(0);
}
if( level == "Meritorio"){
     bonus = bonus * score_2;
     Console.WriteLine("Su nivel de evalución es: "+level+" para un bono de: "+ bonus);
     Environment.Exit(0);
}else{
    Console.WriteLine("No has ingresado un nivel valido");
}