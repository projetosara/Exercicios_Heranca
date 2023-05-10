namespace EXE01;
class Program
{
    static void Main(string[] args)
    {
        Cao Flor = new Cao ();
        Gato Bella = new Gato ();
        Homem Kyle = new Homem ();

       


        Console.WriteLine("Chamei o gato e ele " + Bella.Fala());
        Console.WriteLine("Chamei o cão e ele " + Flor.Fala());
        Console.WriteLine("Chamei o homem e ele " + Kyle.Fala());
       
    }
}
