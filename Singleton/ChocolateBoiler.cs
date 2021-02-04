public class ChocoloateBoiler
{
    private volatile static ChocoloateBoiler uniqueInstance;
    private static object syncRoot = new Object();

    private ChocoloateBoiler(){}

    public static ChocoloateBoiler GetInstance()
    {
        if(uniqueInstance == null){
            lock(syncRoot)
            {
                if(uniqueInstance == null)
                {
                    uniqueInstance = new ChocoloateBoiler();
                }
            }
        }
        return uniqueInstance;
    }
}