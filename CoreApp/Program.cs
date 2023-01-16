var record1 = new Record1(new A());


if (record1 is  { MyInnerClass.Name: "", MyInnerClass.Age: 0 } ) Console.WriteLine("Record1 is empty");
if (record1 is { MyInnerClass: { Name: "", Age: 0 } }) Console.WriteLine("Record1 is empty");


internal record Record1(A? MyInnerClass);

internal class A
{
    public string? Name { get; set; }
    public int Age { get; set; }
}