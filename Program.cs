namespace ConsoleParamsRef.Tripe3;
class Program
{
    static void Main(string[] args)
    {

        Calculator Triple = new Calculator();
        /// Usando ref 
        int valor = 10;        
        Triple.Tripe(ref valor);
        Console.WriteLine(valor);

        /// Usando out
        int valor2 = 10;
        int triple;
        Triple.Tripe(valor2, out triple);
        Console.WriteLine(triple); 


    }
}