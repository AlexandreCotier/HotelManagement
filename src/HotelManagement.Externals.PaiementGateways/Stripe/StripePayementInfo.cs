namespace HotelManagement.Externals.PaiementGateways.Stripe;

public class StripePayementInfo
{
    public string CardNumber { get; set; }
    public string ExpiryDate { get; set; }
    public string Amount { get; set; }
}