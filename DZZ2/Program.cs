namespace Semi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new Bits(7);
            try 
            {
                Console.WriteLine(b.GetBit(0)); 
                
            }
            catch  (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
