using Vaux.VNPayIntegration;

namespace Vaux.Repositories.Interface
{
    public interface IVnPayServiceRepo
    {
        string CreatePaymentUrl(PaymentInformation model, HttpContext context);
        PaymentResponse PaymentExecute(IQueryCollection collections);
    }
}
