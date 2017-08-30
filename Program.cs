using System;
class program
{
 static void Main()
    {
      
        Console.WriteLine("el programon");
        int min, fecha, min2 = 0;
        for (int i = 1; i <= 1; i++)
        {
            Console.WriteLine("¿cuantos minutos tardas en bañarte al dia?:");
            min = Convert.ToInt32(Console.ReadLine());
            min2 = min * 12;
            Console.WriteLine("el agua que gastas al dia equivale a esta cantidad de botellas de agua:" + min2);
            Console.ReadKey();

            Console.WriteLine("¿cual es tu fecha de cumpleaños?:(yyyymmdd)");
            fecha = Convert.ToInt32(Console.ReadLine());
           
            DateTime hoy = DateTime.Today;
            DateTime cumple =  new DateTime(2018,01,19);
            TimeSpan diaEntre = cumple - hoy;
            System.Console.WriteLine(diaEntre.TotalDays);
            double  promedio;
            promedio = diaEntre.TotalDays * min2;
            Console.WriteLine("el resultado de botellas que gastarias asta tu cumpleaños es de:" + promedio);
          Console.ReadKey();

        }
        
    }
}