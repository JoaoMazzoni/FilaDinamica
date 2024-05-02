using FilaDinamica;

internal class Program
{ 

    private static void Main(string[] args)
    {

        Console.WriteLine("Hello, Fila!");

        FilaPessoa filaPessoa = new FilaPessoa();


        filaPessoa.Push(new Pessoa("Odair")); //Cria um objeto da Classe Pessoa.
        filaPessoa.Push(new Pessoa("Alexa"));
        filaPessoa.Push(new Pessoa("João"));
        filaPessoa.Print();
        filaPessoa.Pop();
        filaPessoa.Pop();
        filaPessoa.Pop();
        filaPessoa.Print();
      
    }




}           