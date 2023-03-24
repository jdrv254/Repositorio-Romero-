using Trabajo;


Vehiculo vec = new Vehiculo("McLaren", "1");
Vehiculo vec2 = new Vehiculo("Ferraria", "2");
Vehiculo vec3 = new Vehiculo("Redbull", "3");
Circuito cir = new Circuito(6, "Nascar");


cir.AñadirVehiculo(vec);
var vtt = cir.RealizarPrueba();
cir.SacarVehiculo(vec);
Console.WriteLine($"El vehiculo: {vec.Tipo} realizo las pruebas en {vtt}");

cir.AñadirVehiculo(vec2);
var vtt1 = cir.RealizarPrueba();
cir.SacarVehiculo(vec2);
Console.WriteLine($"El vehiculo: {vec2.Tipo} realizo las pruebas en {vtt1}");

cir.AñadirVehiculo(vec3);
var vtt2 = cir.RealizarPrueba();
cir.SacarVehiculo(vec3);
Console.WriteLine($"El vehiculo: {vec3.Tipo} realizo las pruebas en {vtt2}");






