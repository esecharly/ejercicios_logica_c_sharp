class Logica
{
    public void ejercicio1()
    {
        Console.WriteLine("Escribe tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Hola {nombre}");
        Console.ReadKey();
    }

    public void ejercicio2()
    {
        Console.WriteLine("Escribe la medida de la base");
        double baseR = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe la medida de la altura");
        double alturaR = Convert.ToInt32(Console.ReadLine());
        double perimetro = 2 * (baseR + alturaR);
        double area = baseR * alturaR;
        Console.WriteLine($"El perimetro es: {perimetro} y el area es: {area}");
        Console.ReadKey();
    }

    public void ejercicio3()
    {
        Console.WriteLine("Escribe la medida del cateto A");
        double catetoA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe la medida del cateto B");
        double catetoB = Convert.ToInt32(Console.ReadLine());

        catetoA = Math.Pow(catetoA, 2);
        catetoB = Math.Pow(catetoB, 2);
        double hipotenusa = Math.Sqrt(catetoA + catetoB);
        Console.WriteLine($"La hipotenusa es: {hipotenusa}");
        Console.ReadKey();
    }

    public void ejercicio4()
    {
        Console.WriteLine("Escribe el primer numero");
        double numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el segundo numero");
        double numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"La suma es: {numero1 + numero2}");
        Console.WriteLine($"La resta es: {numero1 - numero2}");
        Console.WriteLine($"La multiplicacion es: {numero1 * numero2}");
        Console.WriteLine($"La division es: {numero1 / numero2}");
        Console.ReadKey();

    }

    public void ejercicio5()
    {
        Console.WriteLine("Escribe el valor en grados Fahrenheit");
        double gradosF = Convert.ToInt32(Console.ReadLine());
        double gradosC = (gradosF - 32) * 5 / 9;
        Console.WriteLine($"El valor en grados celsius es: {gradosC}");
        Console.ReadKey();
    }

    public void ejercicio6()
    {
        Console.WriteLine("Escribe el primer numero");
        double numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el segundo numero");
        double numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el tercer numero");
        double numero3 = Convert.ToInt32(Console.ReadLine());

        double media = (numero1 + numero2 + numero3) / 3;
        Console.WriteLine($"La media de los numeros es: {media}");
        Console.ReadKey();
    }

    public void ejercicio7()
    {
        Console.WriteLine("Escribe la cantidad de minutos");
        int minutos = Convert.ToInt32(Console.ReadLine());
        int horas = minutos / 60;
        int minutosRestantes = minutos % 60;
        Console.WriteLine($"Las horas son: {horas}, los minutos son {minutosRestantes}");
        Console.ReadKey();
    }

    public void ejercicio8()
    {
        Console.WriteLine("Escribe el sueldo base del empleado");
        double sueldoBase = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el total de ventas del empleado");
        double totalVentas = Convert.ToInt32(Console.ReadLine());
        double comision = totalVentas * .1;
        Console.WriteLine($"El sueldo base es: {sueldoBase}");
        Console.WriteLine($"El total de ventas es: {totalVentas}");
        Console.WriteLine($"El sueldo total es: {sueldoBase + comision}");
        Console.ReadKey();

    }

    public void ejercicio9()
    {
        Console.WriteLine("Escribe el valor total de la compra");
        double totalCompra = Convert.ToInt32(Console.ReadLine());
        double descuentoCompra = totalCompra * .15;
        double totalNeto = totalCompra - descuentoCompra;
        Console.WriteLine($"El total de la compra es: ${totalCompra}");
        Console.WriteLine($"Con descuento del 15% es: ${totalNeto}");
        Console.ReadKey();
    }

    public void ejercicio10()
    {
        Console.WriteLine("Escribe la primera calificacion");
        double calificacion1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe la segunda calificacion");
        double calificacion2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe la tercera calificacion");
        double calificacion3 = Convert.ToInt32(Console.ReadLine());

        double promedio = (calificacion1 + calificacion2 + calificacion3) / 3;
        double parcial = promedio * .55;
        Console.WriteLine("Escribe la calificacion del examen final");
        double examenFinal = Convert.ToInt32(Console.ReadLine()) * .3;
        Console.WriteLine("Escribe la calificacion del trabajo final");
        double trabajoFinal = Convert.ToInt32(Console.ReadLine()) * .15;
        double calificacionFinal = examenFinal + trabajoFinal + parcial;
        Console.WriteLine($"Tu calificacion final es: {calificacionFinal}");
    }
    static void Main(string[] args)
    {
        Logica obj = new Logica();
        obj.ejercicio10();
    }
}