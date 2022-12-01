namespace static_class;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: {0}",Worker.WorkerNum);

        Worker worker=new Worker("Metehan","Metinoğlu","Yazılım");
        Console.WriteLine("Çalışsan Sayısı: {0}",Worker.WorkerNum);

        Console.WriteLine(Processes.addition(23,22));
        Console.WriteLine(Processes.subtraction(23,22));
    }

}

class Worker
{
    private static int workerNum;

    public static int WorkerNum { get => workerNum;}
    private string name;
    private string surname;
    private string departmant;

      static Worker()
    {
        workerNum=0;
    }

    public Worker(string name, string surname, string departmant)
    {
        this.name = name;
        this.surname = surname;
        this.departmant = departmant;
        workerNum++;
    }

  
}
static class Processes
{
    public static long addition(long sayi1,long sayi2)
    {
        return sayi1+sayi2;
    }
      public static long subtraction(long sayi1,long sayi2)
    {
        return sayi1-sayi2;
    }
}
