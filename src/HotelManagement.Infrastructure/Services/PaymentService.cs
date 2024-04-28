using HotelManagement.Application.Common.Interfaces.Services;
using HotelManagement.Domain.Common.Enums;
using HotelManagement.Externals.PaiementGateways.Paypal;
using HotelManagement.Externals.PaiementGateways.Stripe;

namespace HotelManagement.Infrastructure.Services;

public class PaymentService : IPaymentService
{
    public async Task<bool> ProcessPayment(string cardNumber, string expiryDate, string amount, PaymentMethod paymentMethod)
    {
        switch(paymentMethod){
            case PaymentMethod.Stripe:
                return await new StripeGateway().ProcessPaymentAsync(
                    new StripePayementInfo{
                        CardNumber = cardNumber,
                        Amount = amount,
                        ExpiryDate = expiryDate});
            case PaymentMethod.Paypal:
                var paypalPayment = await new PaypalGateway().ProcessPaymentAsync(cardNumber, expiryDate, amount);
                return paypalPayment.Status == PaypalResultStatus.Success;
        }

        throw new Exception("Can't handle with selected payment method");
    }
}