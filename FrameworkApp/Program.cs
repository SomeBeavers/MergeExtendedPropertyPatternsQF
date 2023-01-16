using System.Collections.Generic;

namespace FrameworkApp;

internal class Program
{
    private static void Main(string[] args)
    {
    }

    public void Test(UseMe parameter)
    {
        if (parameter is not null && parameter.Property1.InnerClass2.List[0].Age == 1 &&
            parameter.Property1.InnerClass2.List[0].Name is "")
        {
        }
    }
}

internal class UseMe
{
    public InnerClass Property1 { get; set; }
    public InnerClass2 Property2 { get; set; }


    internal class InnerClass
    {
        public InnerClass2 InnerClass2 { get; set; }
        public InnerClass Me { get; set; }
    }

    internal class InnerClass2
    {
        public List<(string Name, int Age)> List { get; set; }
    }
}