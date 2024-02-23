public class Pair
{
    private DateTime startTime;
    private DateTime endTime;
    private DateTime breakStartTime;
    private DateTime breakEndTime;
    private OtherClass otherClass;

    public Pair(DateTime startTime, DateTime endTime, DateTime breakStartTime, DateTime breakEndTime, string shiftLink)
    {
        this.startTime = startTime;
        this.endTime = endTime;
        this.breakStartTime = breakStartTime;
        this.breakEndTime = breakEndTime;
        this.otherClass = new OtherClass(shiftLink);
    }

    // Добавьте геттеры и сеттеры для доступа к закрытым полям, если необходимо

    public void CallOtherClassMethod()
    {
        otherClass.OtherMethod();
    }
}

public class OtherClass
{
    private string shiftLink;

    public OtherClass(string shiftLink)
    {
        this.shiftLink = shiftLink;
    }

    public void OtherMethod()
    {
        // Ваш код здесь
    }
}
