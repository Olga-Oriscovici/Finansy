namespace Finansy.Models
{
    public class SavingsModel
    {
        public decimal InitialAmount { get; set; }
        public decimal MonthlyContribution { get; set; }
        public decimal AnnualInterestRate { get; set; }
        public int Years { get; set; }
        public decimal FutureValue { get; set; }

        public void CalculateFutureValue()
        {
            int months = Years * 12;
            decimal monthlyInterestRate = AnnualInterestRate / 100 / 12;
            FutureValue = InitialAmount;

            for (int i = 0; i < months; i++)
            {
                FutureValue = FutureValue * (1 + monthlyInterestRate) + MonthlyContribution;
            }
        }

    }
}
