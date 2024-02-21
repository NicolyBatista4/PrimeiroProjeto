 namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string nome = "Nicoly";
            int idade = 16;
            string cidade = "Campos do Jordão";

            Console.WriteLine("Digite seu nome: "); nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:"); idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua cidade: "); cidade = Console.ReadLine();

            Console.WriteLine("nome:{0}", nome);
            Console.WriteLine("idade:{0} anos", idade);
            Console.WriteLine("cidade:{0}", cidade);
            Console.WriteLine("Nome:{0} \n idade:{1} \n Cidade: {2}", nome,idade,cidade);
        }
        
    }
}
