namespace Payment
{
    public abstract class Payment
    {
        public double Amount;

        protected Payment(double amount)
        {
            this.Amount = amount;
        }

        public string? printReceipt()
        {
            return $"The amount deducted is {this.Amount}";
        }

        public abstract string? Pay();
    }

    public class UpiPayment : Payment
    {
        public string? UpiId;
        public UpiPayment(string? upiId, int amount) : base(amount)
        {
            this.UpiId = upiId;
        }

        public override string? Pay()
        {
                       return $"The amount {this.Amount} has been paid using UPI ID: {this.UpiId}";

        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Payment payment = new UpiPayment("user@upi", 500);
        }
    }

}
