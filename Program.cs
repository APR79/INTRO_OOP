// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int resultado = num_uno + num_dos;

Console.WriteLine("El resultado es: " + resultado);

//Programacion orientada a objetos
//entradas
Console.WriteLine("Numero Uno");
int num_uno = int.Parse(Console.ReadLine());

Console.WriteLine("Numero Dos");
int num_dos = int.Parse(Console.ReadLine());

public void sumar_numeros(){

    int resultado = num_uno + num_dos;

    Console.WriteLine("El resultado es: " + resultado);

}




//instanciar, crear un objeto o hacer una copia de la clase
//Forma orientada a objetos
//Instanciar la class OperacionesAritmeticas (objeto de class)
//Class objeto(instancia) (=new)sonPalabrasReservadas metodoConstructor
 
var operacion_uno = new OperacionesAritmeticas (){
    //oper = operacion,
    numero_uno = num_uno,
    numero_dos = num_dos
}


var operacion_dos = new OperacionesAritmeticas (){
    //oper = operacion,
    numero_uno = num_uno,
    numero_dos = num_dos
}

//Ver los resultados de las operaciones 
Console.WriteLine("En numero uno es :" + operacion_uno.numero_uno); //mostrar atributos
//operacion_uno.sumar_num();
//operacion_uno.ImprimirSuma();

operacion_uno.mostrarResultados();