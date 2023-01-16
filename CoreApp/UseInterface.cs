namespace CoreApp;

public class UseInterface
{
    public void Test(MyClass parameter)
    {
        if (parameter is { 
                /**/Interface2.Interface3.Age.Age.Age: >10 and var myAge ,
                Interface2.Interface3.Age.Age.Age: >10 and var myAge2,
        } x && /**/x is { Interface2.Interface3.Age.Age.Age: > 10 and var myAge3 })
        {
            Console.WriteLine(x);
        }
    }
}

internal interface IInterface1
{
    public static IInterface2 Field;
    public IInterface2 Interface2 { get; }
}

public class MyClass : IInterface1
{
    public string GetString()
    {
        return null;
    }

    private IInterface2 _interface2;

    public IInterface2 Interface2
    {
        get => _interface2;
        private set => _interface2 = value;
    }
}

public interface IInterface2
{
    public IInterface3 Interface3 { get; set; }
}

public interface IInterface3
{
    public string Name { get; set; }
    public MyAge Age { get; set; }
}

public class MyAge
{
    public MyAge2 Age;
}

public record MyAge2(int Age)
{
}