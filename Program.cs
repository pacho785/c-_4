// See https://aka.ms/new-console-template for more information
using System.Diagnostics.SymbolStore;

Console.WriteLine("Hello, World!");
// && = and (Todas las condiciones deben ser verdaderas para que se ejecute) 
// || = or ( una de las condiciones debe ser verdadera para que se ejecute )
// ! not- negacion 
// XOR ^ ( alt + 94 )

//&&

//bool valor1 = true;
//bool valor2 = true;
//bool valor3 = true;
var (valor1, valor2, valor3) = (true, true, false);
bool resultado = valor1 && valor2;

Console.WriteLine(resultado);

//  ||
bool result0r = valor1 || valor2 || valor3;
Console.WriteLine(result0r);


bool resultANDOR = (valor1 && valor2) || valor3;
Console.WriteLine(resultANDOR);

// ! NOT ( Invierte algo en este caso el true a un false ) 

bool resulNot = !valor1;
Console.WriteLine(resulNot);

//XOR ^ 

bool resulXor =(valor1  ^ valor2) ^ valor3; 
Console.WriteLine(resulXor); 