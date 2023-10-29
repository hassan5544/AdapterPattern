using System.Security.Cryptography.X509Certificates;

namespace AdapterPattern;

public class NewPaymentMethhod : IPaymentAdapter
{
    private OldPamentMethod _oldPamentMethod;

    public NewPaymentMethhod(OldPamentMethod oldPamentMethod)
    {
        _oldPamentMethod = oldPamentMethod;
    }

    public string PaymentMethod()
    {
        return "the method is called from New Payment " + _oldPamentMethod.PaymentMethhod();
    }
}