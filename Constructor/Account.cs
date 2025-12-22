namespace OopsSession.Constructor { 

    
    public class Account
    {
        public int AccountNumber { get; set; }
        public string? AccountHolderName { get; set; }


        public Account(int accountNumber, string accountHolderName)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolderName = accountHolderName;
        }

        public void GetAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Account Holder Name: {AccountHolderName}");
        }

    }
}