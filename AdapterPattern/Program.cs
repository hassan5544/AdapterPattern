using AdapterPattern;

class Program
{
    public static void Main()
    {
        OldPamentMethod old = new OldPamentMethod();
        IPaymentAdapter newPaymentMethod = new NewPaymentMethhod(old);

        Console.WriteLine(newPaymentMethod.PaymentMethod());
    }
}