namespace CoreApp;

public class ListPattern
{
    public void Test(List<ListPatternClass> list)
    {
        var s = list switch
        {
            [{ InnerClass: { Name: "", Age: 1 } }] => "",
            [{ InnerClass: { Name: not null or null, Name: var s2, Age: 1 } }] => s2,
            [
                { InnerClass.Name: { Length: 1 or 2, Length: var s2 } },
                { InnerClass: { Name.Length: 1 or 2, Name.Length: var s3 } },
                { InnerClass.Name.Length: 1 or 2, InnerClass.Name.Length: var s4 }
            ] => s2.ToString(),
            _ => throw new ArgumentOutOfRangeException(nameof(list))
        };
    }
}

public class ListPatternClass
{
    public int Field1;

    public InnerClass1 InnerClass { get; set; }


    public class InnerClass1
    {
        public int Age;
        public string Name { get; set; }
    }
}

/* var newState = (GetState(), action, hasKey) switch {
        (DoorState.Closed, Action.Open, _) => DoorState.Opened,
        (DoorState.Opened, Action.Close, _) => DoorState.Closed,
        (DoorState.Closed, Action.Lock, true) => DoorState.Locked,
        (DoorState.Locked, Action.Unlock, true) => DoorState.Closed,
        (var state, _, _) => state };*/