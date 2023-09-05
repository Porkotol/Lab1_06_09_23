using System.Linq.Expressions;

class Program
{
    public class Shar
    {
        double R;

        public Shar()
        { }

        public Shar(double r)
        {
            R = r;      ////конструктор з параметром
        }

        public bool Correct()
        {
            return R > 0; /////куля iснуе якщо радиус бiльше 0
        }

        public double Area()
        {
            double S = 4 * Math.PI * R * R; //////// площа поверхнi кулi
            return S;
        }

        public double Volume()
        {
            double V = (4 / 3) * Math.PI * Math.Pow(R,3);
            return V;
        }

        public void Print()
        {
            Console.WriteLine($"Радiус кулi: {R}");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введiть радiус кулi: ");
            double r = double.Parse(Console.ReadLine());
            Shar sp = new Shar(r); ///// Створення об'єкту за допомогою конструктора
            sp.Print(); ////Виведення на экран методу Paint

            if (sp.Correct()) ////перевiрка через метод Correct
            {
                double S = sp.Area(); 
                double V = sp.Volume();
                Console.WriteLine($"Площа поверхнi кулi: {S}");
                Console.WriteLine($"Об'єм кулi:{V}");
            }
            else
            {
                Console.WriteLine("Куля не може iснувати");
            }
            
        }
        catch
        {
            Console.WriteLine($"Помилка!!!");
        }
    }
}