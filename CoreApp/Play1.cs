using System.Numerics;

namespace CoreApp;

public class Play1
{
    public void Test(Play1_Use<PlayChild> parameter)
    {
        switch (parameter)
        {
            case { GenericProperty.Play2.Name: { Length: > 0 or < 100, Length: 1 } } test:
                break;
        }
    }
}

public class Play1_Use<T> where T : PlayParent, IT
{
    public T GenericProperty { get; set; }
}

public class PlayParent
{
    public virtual Play2 Play2 { get; set; }
}

public class Play2
{
    public string Name { get; set; }

}

public class PlayChild : PlayParent, IT
{
}

public interface IT
{
    public Play2 Play2 { get; set; }
}