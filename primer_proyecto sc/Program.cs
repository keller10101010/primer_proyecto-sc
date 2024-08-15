using System;

public class program
{

    static void Main(string[] args)
    {

        

        Console.WriteLine("Bienvenidos a nuestro pirmer sistema creado en C#");

        Console.WriteLine("Ingresa tu nombre para continuar");
        string Nombre = Console.ReadLine();//Para recibir valores de caracter
        Console.WriteLine("Ingrese su edad");// Para recibir la edad 
        int Edad=Convert.ToInt32(Console.ReadLine());// Convertir a dato tipo double
        double EdadMeses = Edad * 12;// Calculos Matematicos 
        Console.WriteLine(Nombre +" tu edad en Meses es: " + EdadMeses + "Meses");//Concatenacion
        if (Edad > 18)
        {
        Console.WriteLine("Usted es Mayor de edad");
        }
        else
        {
            Console.WriteLine("Usted es Menor de edad");
        }
    
    
    
    }


}