/// <summary>
/// Represents command to do nothing
/// </summary>
public class NoCommand : ICommand
{
    public NoCommand() {}

    public object Execute() => null;
}