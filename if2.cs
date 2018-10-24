using System;
class if2
{
        static void Main()
        {

               int x;
               string s;

               Console.Clear();
               Console.Write("Masukan sebuah bilangan : ");
               s = Console.ReadLine();
               x= int.Parse(s);

               if(x<0)
               {

                      Console.WriteLine(x + "Merupakan bilangan negatif");
                      Environment.Exit(1);
               }else if (x>0)
               {
                      Console.WriteLine( x + " Merupakan bilangan positif");
                      Environment.Exit(1);
               }
               {

                      Console.WriteLine("Anda memasukan bilangan " + x);
               }

        }
}