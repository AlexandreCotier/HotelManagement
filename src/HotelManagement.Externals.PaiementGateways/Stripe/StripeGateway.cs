namespace HotelManagement.Externals.PaiementGateways.Stripe;

public class StripeGateway
{
    public Task<bool> ProcessPaymentAsync(StripePayementInfo payementInfo)
    {
        Console.WriteLine("Processing payment with Stripe calling Stripe API");
        return Task.FromResult(true);
    }
}