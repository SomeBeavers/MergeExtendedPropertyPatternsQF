namespace CoreApp;

public class UseGeneric<T> where T : Parent
{
}

public abstract class Parent
{
    public abstract List<MyClass2> Property1 { get; set; }
}

public class MyClass2
{
}

public class Child1 : Parent
{
    public override List<MyClass2> Property1 { get; set; }
}