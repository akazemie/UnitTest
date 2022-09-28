namespace Test
{
    /// <summary>
    /// check DividedBy3And5 then return FizzBazz
    /// check DividedBy3 then return Fizz
    /// check DividedBy5 then return Bazz
    /// check NotDividedBy3or5 then return same number
    /// </summary>
    public class FizzBazz
    {
        public string GetOutPut(int num)
        {
            if (((num % 3) == 0) && (num % 5) == 0)
                return "FizzBazz";

            if (((num % 3) == 0))
                return "Fizz";

            if (((num % 5) == 0))
                return "Bazz";

            return num.ToString();
        }
    }
}
