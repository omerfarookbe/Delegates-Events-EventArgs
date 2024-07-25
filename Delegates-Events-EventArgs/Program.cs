public class Program()
{
    public static void Main(string[] args)
    {
        Action<string> messageTarget;
        messageTarget = ShowMessage;
        messageTarget("Hello");

        var worker = new Worker();
        worker.WorkPerformed += (s, e) =>
        {
            Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType.ToString());
        };

        worker.WorkPerformed += (s, e) => Console.WriteLine("Work completed");

        worker.DoWork(8, WorkType.coding);

        Console.Read();
    }

    private static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

}

public enum WorkType
{
    meeting,
    coding,
    supporting,
}