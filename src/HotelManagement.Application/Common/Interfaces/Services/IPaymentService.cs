using HotelManagement.Domain.Common.Enums;

namespace HotelManagement.Application.Common.Interfaces.Services;

public interface IPaymentService {
    Task<bool> ProcessPayment(string cardNumber, string expiryDate, string amount, PaymentMethod paymentMethod);
}