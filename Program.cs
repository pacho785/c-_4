// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var (valor1,valor2, valor3) = (10, 10, 2);
Console.WriteLine("los valores son: " + valor1 +", " + valor2 + ", " + valor3);

//== igual a
//!= diferente a 
//> mayor que
//< menor que
//>= mayor a igual
//<= menor o igual 

bool resultado = valor1 == valor2;
Console.WriteLine("El resultado de la comparacion es: " + resultado);

bool rsultado2  = valor2 != valor2;
Console.WriteLine("El resultado de la comparacion es: " + rsultado2 );

bool resultado3 = valor1 > valor2;
Console.WriteLine("El resultado de la comparacion es : " + resultado3);

bool resultado4 =  valor1 < valor2;
Console.WriteLine("El resultado de la comparacion es: " + resultado4);

bool resultado5 = valor1 >= valor2;
Console.WriteLine("El resultado de la comparacion es: " + resultado5);

bool resultado6 = valor1 <= valor2;
Console.WriteLine("El resultado de la comparcion es: " + resultado6);