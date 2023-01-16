namespace CoreApp;

public class Class2
{
    public void Test(Use1 parameter)
    {
        // type check
        string? s;
        switch (parameter)
        {
            case
                //comment
            { 
                Use2_Field.Use3_Field.List: [{ tuple.Item2: { Length: > 0, Length: var s22 } }] list,
                Use2_Field.Use3_Field.List2.Count: 1
            }:
            {
                s = "Use1";
                break;
            }
            case
                //comment
            { 
                Use2_Field.Use3_Field.List: [{ tuple.Item2: { Length: > 1, Length: var s22 } }] list,
                Use2_Field.Use3_Field.List2.Count: 2
            }:
            {
                s = "Use1";
                break;
            }
            default:
                s = "Unknown";
                break;
        }
    }
}

public class Use1
{
    public const int Age = 1;

    public static Use2 Use2_StaticField;

    public Use2 Use2_Field;
    public Use2 Use2_Property { get; set; }

    public static Use2 Use2_StaticProperty { get; set; }
}

public class Use2
{
    public static Use3 Use3_StaticField;
    public Use3 Use3_Field;
    public Use3 Use3_Property { get; set; }

    public static Use3 Use3_StaticProperty { get; set; }
}

public class Use3
{
    public List<((int, string, bool) tuple, string Name)> List { get; set; }
    public List<(int Age, string Name)> List2 { get; set; }
}