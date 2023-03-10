namespace CoreApp;

public class Class1
{
    private static void Main(string[] args)
    {
    }

    public void Test(UseMe parameter)
    {
        if (parameter is
            {
                Property1.InnerClass2.List: [{ Age.AgeField: 1, Age.AgeField2: 2 }],
                Property1.InnerClass2.List: [{ Age.AgeField: 1, Age.AgeField2: 2 }]
            })
        {
        }
    }

    public class UseMe
    {
        public InnerClass Property1 { get; set; }
        public InnerClass2 Property2 { get; set; }


        public class InnerClass
        {
            public InnerClass2? InnerClass2 { get; set; }
            public InnerClass Me { get; set; }
        }

        public class InnerClass2
        {
            public List<(string Name, Age Age)> List { get; set; }
        }
    }
}

public class Age
{
    public int AgeField;
    public int AgeField2;
}