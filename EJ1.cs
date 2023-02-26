//Tramos declaración de renta - José David Romero

//Declaro las variables de impuestos

double impuesto_1 = 0.05;
double impuesto_2 = 0.10;
double impuesto_3 = 0.15;
double impuesto_4 = 0.20;
double impuesto_5 = 0.30;

//Solicito los datos por consola  la vez que declaro las variables por trimestre en total 4 trimestres para el año
Console.WriteLine("Ingrese su valor del 1er trimestre: ");
double valores_t1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su valor del 2do trimestre: ");
double valores_t2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su valor del 3er trimestre: ");
double valores_t3 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su valor del 4to trimestre: ");
double valores_t4 = double.Parse(Console.ReadLine());

//Declaro una variable para el total pago
double total_p = 0;

//Declaro una variable para el valor anual
double anual = valores_t1+valores_t2+valores_t3+valores_t4;


//Aplico condiciones, imprimo resultado si cumple y corto la condición para no avanzar más,
//Se aplica cambio de formato al impuesto para mostrarlo como %

if(anual < 100000){
    total_p = anual + (anual * impuesto_1);
    Console.WriteLine("Su renta anual fue de: "+anual+" para un pago total de: "+total_p+" con un impuesto del: "+impuesto_1.ToString("0.0%"));
    Environment.Exit(0);
}
if (anual >= 100000 && anual < 200000){
    total_p = anual + (anual * impuesto_2);
    Console.WriteLine("Su renta anual fue de: "+anual+" para un pago total de: "+total_p+" con un impuesto del: "+impuesto_2.ToString("0.0%"));
    Environment.Exit(0);
}
if (anual >= 200000 && anual < 35000){
    total_p = anual + (anual * impuesto_3);
    Console.WriteLine("Su renta anual fue de: "+anual+" para un pago total de: "+total_p+" con un impuesto del: "+impuesto_3.ToString("0.0%"));
    Environment.Exit(0);
}
if(anual >= 350000 && anual < 45000){
    total_p = anual + (anual * impuesto_4);
    Console.WriteLine("Su renta anual fue de: "+anual+" para un pago total de: "+total_p+" con un impuesto del: "+impuesto_4.ToString("0.0%"));
    Environment.Exit(0);
}   else{
    total_p = anual + (anual * impuesto_5);
    Console.WriteLine("Su renta anual fue de: "+anual+" para un pago total de: "+total_p+" con un impuesto del: "+impuesto_5.ToString("0.0%"));
}


