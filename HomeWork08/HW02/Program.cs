using HW02;

internal class Program
{
    private static void Main(string[] args)
    {
        Engine engine = new Engine();

        Car car = new Car();
        car.Engine = engine;
        car.Move();  // Выводит "Автомобиль движется." и "Двигатель запущен."

        Plane plane = new Plane();
        plane.Engine = engine;
        plane.Move();  // Выводит "Самолет летит." и "Двигатель запущен."
    }
}