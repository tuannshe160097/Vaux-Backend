using Vaux.Models;

namespace Vaux.Repositories.Interface
{
    public interface IVnPayServiceRepo
    {
        string CreatePaymentUrl(PaymentInformationDTO model, HttpContext context);
        PaymentResponseDTO PaymentExecute(IQueryCollection collections);
    }
}
