namespace ConsoleTestApplication
{
    public class QuantityNumbers
    {
        public int QuantityPrimeNumbers { get; set; }
        public int QuantityNotPrimeNumbers { get; set; }
        public QuantityNumbers(int quantityPrimeNumbers, int quantityNotPrimeNumbers)
        {
            QuantityPrimeNumbers = quantityPrimeNumbers;
            QuantityNotPrimeNumbers = quantityNotPrimeNumbers;
        }
    }
}
