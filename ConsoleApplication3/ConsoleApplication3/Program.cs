using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportClassLibrary1;
using metClassLibrary2;






namespace обучалка
{
    public static class airportrefit : airport
    {
        int lenght = 0;
        public int Getlenght()
        {
            return lenght;
        }
        public int Setlenght(int c)
        {
            this.lenght = c;
            return lenght;
        }
    
    }

    public class newmet : met
    {
        static override void center()
        {
            
        }
        public int Getlenght()
        {
            
        }
        public int Setlenght(int c)
        {

        }
    }
    
    
    class Program  //базовый класс
    {
        static void Main(string[] args) //точка входа в программу
        {
            metClassLibrary2.met.center();   //просто передача управления в наш метод-интерфейс
            Console.WriteLine("Остановка прогр.");
            Console.ReadKey();
        }
    }
}
