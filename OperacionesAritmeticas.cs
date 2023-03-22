class OperacionesAritmeticas
{
    
    //Atributos (atributos)
    //metodos para recibir(set) y para entregar (get)
    //el valor de la propiedad
    public int numero_uno {get; set;}
    public int numero_dos {get; set;}
    public string oper { get; set; } 


    
    //Metodos(Funciones o acciones)
    //metodo sin parametros
    //mod acc tipo retorno nombreMetodo
    /*public void sumar_num(){
        //operaciones
        int resultado = numero_uno + numero_dos;

        //salida. puede ser impresa o return
        Console.WriteLine("El resultado es: " + resultado);

    }
    */


    //separar las responsabilidades de los metodos 
    //metodo con retorno(return)
    public int sumar_num(int n1, int n2)
    {
        //operaciones
        int resultadoSuma = 0;
        resultadoSuma = n1 + n2;
        //retornar el resultado
        return resultadoSuma;
    }
    
    /*
    public int calcular_edad(){
        int edad = 0;
        edad = date_now() - fecha_nacimiento;
        return edad;
    }
    */



    public void multiplicar_num(){

    int resultado = numero_uno * numero_dos;

    Console.WriteLine("El resultado es: " + resultado);

    }

    //Metodo constructor
    /*OperacionesAritmeticas(0){   
        asdasd
        agasfas
        ahasgfa
    }
    */

    public void mostrarResultados(){
        switch(oper)
        {
            case "+":
                ImprimirSuma();
                break;
            case "*":
                ImprimirMult(): 
                break;
            default:
                Console.WriteLine("Operacion no valida");
                break;
        }
    }


}