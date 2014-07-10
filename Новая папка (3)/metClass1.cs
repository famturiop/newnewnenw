using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportClassLibrary1;
using ConsolevvodClass;

namespace metClassLibrary2
{
    public class met    //класс-набор методов
    {
        public static airport plane = new airport();//наш любимый самолётик
        static void print_menu()//просто пусть печать юудет в отделном вызываемом методе. в методе центр эта писанина лишняя наверное. да и так удобнее, хотя возможно это просто я так привык делать. 
        {//но если нам понадобится вызвать менюшку хотя бы в 2х и больше мест, то этот метод оправдан. так что считай, что это на вырост
            Console.WriteLine("Введите команду \n 1 - запуск двиг., \n 2 - остановка двиг., \n 3 - заправка, \n 4 - увелич. скорость, \n 5 - уменьшить скорость, \n 6 - увелич. высоту, \n 7 - уменьш. высоту.");
        }
        static void StartProgramm()       //метод, создающий объекты самолёт и заносящий их в Авиапарк. принимаемый параметр = количеству самолётов в авиапарке
        { }//хотя этот метод теперь лишний, но вс равно не удаляй. пусть он будет на будущее. ты там ещё создашь нормальный конструктор Самолёту и тогда заюзаешь


        public static void center()//"метод-интерфейс" для пользователя. показывает менюшку и перенаправляет по выбору.
        {
            Console.ReadKey();
            Console.Clear();
            met.print_menu();//вызов метода-мечати твоей менюшки. там расписанно подробно
            int command = Consolevvod.vvod();
            Console.Clear();    //чистим консоль... в эстетических целях)
            int hei = plane.Getheight();
            int speed = plane.Getspeed();
            int fuel = plane.Getfuel();
            if (hei > 0 && fuel == 0)
            {
                Console.WriteLine("Нету топлива на высоте > 0. Самолет упал и разбился.");
                return;
            }
                switch (command)
                {


                    case 1:
                        plane.startengine();
                        break;
                    case 2:
                        


                        if (hei > 0)  // тут ты обращался просто к полю метода.. но я даже не понимаю как оно бы сработало у тебя в мэине) либо делай все поля пабликами и тогда не мучайся, либо дела Set и Get для каждого поля класса.
                        {
                            Console.WriteLine("Откл. двигателя на высоте > 0. Самолет упал и разбился.");
                        }
                        else
                        {
                            plane.stopengine();
                        }
                        break;
                    case 3:
                        if (hei == 0 && speed == 0)
                        {
                            plane.getfuel();
                        }
                        else
                        {
                            Console.WriteLine("Невозможно осущ. заправку при скорости > 0 и при высоте > 0.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите увелич. скорости. (Макс скорость - 700 единиц.)");
                        int i = Convert.ToInt32(Console.ReadLine());
                        plane.morespeed(i);
                        break;
                    case 5:
                        Console.WriteLine("Введите уменьш. скорости. (Макс скорость - 700 единиц.)");
                        int j = Convert.ToInt32(Console.ReadLine());
                        plane.lessspeed(j);
                        break;
                    case 6:
                        Console.WriteLine("Введите увелич. высоты. (Макс высота - 900 единиц.)");
                        int t = Convert.ToInt32(Console.ReadLine());
                        plane.moreheight(t);
                        break;
                    case 7:
                        Console.WriteLine("Введите уменьш. высоты. (Макс высота - 900 единиц.)");
                        int m = Convert.ToInt32(Console.ReadLine());
                        plane.lessheight(m);
                        break;
                    default:
                        Console.WriteLine("Введите команду из списка.");
                        met.center();
                        break;
                }


        }
        //met.plane.startengine(); а это пример обращения к полю и тд. вот такую штуку вставь в конце каждого метода-действия. 
    }


    }

