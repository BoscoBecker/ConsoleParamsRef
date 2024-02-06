namespace ConsoleParamsRef.Tripe3
{
    public class Calculator
    {
        public void Tripe(ref int x)
        {
            x = x * 3;
        }

        public void Tripe(int origin, out int result)
        {
            result = origin * 3;

        }
    }
}
