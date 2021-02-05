/// <summary>
/// Summary description for RemoteControl.
/// </summary>
//
// This is the invoker
//
public class RemoteController
{
    Command[] onCommands;
    Command[] offCommands;
    public RemoteController() 
    {
        onCommands = new Command[7];
        offCommands = new Command[7];

        Command noCommand = new NoCommand();
        for (int i = 0; i < 7; i++) 
        {
            onCommands[i] = noCommand;
            offCommands[i] = noCommand;
        }
    }
}