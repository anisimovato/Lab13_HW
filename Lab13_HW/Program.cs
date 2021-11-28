using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building(1, 2, 3, "Адрес");
            MultiBuilding multiBuilding = new MultiBuilding(1, 2, 3, "Адрес",4);
            Console.ReadKey();
        }
    }
    class Building
    {

        public double L { get; set; }
        public double S { get; set; }
        public double H { get; set; }
        public string Name { get; set; }

        public Building(double l, double s, double h, string name)
        {
            L = l;
            S = s;
            H = h;
            Name=name;
        }
        public void Print()
        {
            Console.WriteLine($"Здание длинной {0}, шириной {1}, высотой {3} , находящееся по адресу {4} ");
        }
    }
     sealed class MultiBuilding : Building
        
    {
        public double N { get; set; }

        public MultiBuilding(double l, double s, double h, string name, double n)
                : base(l, s, h, name)
            
        {
            N = n;
        }
        public void  Print1()
            
        {
            Console.WriteLine($"Здание длинной {0}, шириной {1}, высотой {3} , находящееся по адресу {4},количество этажей{5} ");
        }
    }
}


//Задан класс Building, который описывает здание. Класс содержит следующие элементы:

//адрес здания;
//длина здания;
//ширина здания;
//высота здания.
//В классе Building нужно реализовать следующие методы:

//конструктор с 4 параметрами;
//свойства get/set для доступа к полям класса;
//метод Print(), который выводит информацию о здании.
//Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:

//конструктор с 5 параметрами – реализует вызов конструктора базового класса;
//свойство get/set доступа к внутреннему полю класса;
//метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
//Класс MultiBuilding сделать таким, что не может быть унаследован.

//class Triangl
//{
//    public double A { get; set; }
//    public double B { get; set; }
//    public double C { get; set; }

//    public Triangl()    //конструктор по умолчанию
//    {
//        // может ничего не делать или присваивать начальные значения
//    }

//    public Triangl(double a, double b, double c)     // конструктор не наследуется
//    {
//        A = a;
//        B = b;
//        C = c;
//    }
//    public double GetAria()
//    {
//        double p = (A + B + C) / 2;
//        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
//    }
//}
//class RectangularTriangl : Triangl //класс прямоуг треуг, является наследником класс треугольник
//{
//    public RectangularTriangl(double a, double b)

//    {
//        A = a;
//        B = b;
//        C = Math.Sqrt(a * a + b * b);
//    }

