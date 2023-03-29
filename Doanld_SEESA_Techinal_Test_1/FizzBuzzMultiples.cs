namespace Doanld_SEESA_Techinal_Test_1
{
    public class FizzBuzzMultiples
    {
        public List<String> FizzBuzz()
        {
            List<String> list = new List<String>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add($"Buzz{i}");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }
            return list;
        }
    }
}
