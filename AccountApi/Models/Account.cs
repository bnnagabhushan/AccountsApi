using System;
namespace AccountApi.Models
{
    public class Account
    {
        public string AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountType { get; set; }
        public Account()
        {
        }
    }
}
