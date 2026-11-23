

/*var p1 = new PointRecord(10, 20);
var p2 = p1 with { x = 15, y = 30 };

Console.WriteLine(p1);
Console.WriteLine(p2);

record class PointRecord(int x, int y);*/


/*Employee manager = new Employee("Губка", "боб");
manager.Name = "губка";
manager.age = 33;
manager.Position = "Менеджер";

manager.Greet();
manager.Work();




public class Person
{
    public string Name { get; set;}
    public int age { get; set; }

    public Person(string name)
    {
        Name = name;
        Console.WriteLine("Конструктор Person сработал!");
    }

    public void Greet()
    {
        Console.WriteLine($"Привет меня зовут: {Name}");
    }
}



public class Employee : Person
{
    public string Position { get; set; }

    public Employee(string name, string position) : base(name)
    {
        Position = position;
        Console.WriteLine("Конструктор Employee сработал");
    }
    
    public void Work()
    {
        Console.WriteLine($"Я работаю на должности: {Position}");
    }
}*/

List<Shape> shapes = new List<Shape>();
shapes.Add(new Shape());
shapes.Add(new Circle());
shapes.Add(new Rectangle());

foreach (Shape shape in shapes)
{
    shape.Draw();
}


public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Рисую какуюто фигуру!");
    }
}



public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Рисую окружность!");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Рисую прямоугольник!");
    }
}