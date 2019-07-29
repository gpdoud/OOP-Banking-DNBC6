using System;
using System.Collections.Generic;
using System.Text;

namespace OopBankingProject {
    public class MoneyMarket : Account {

        public double MMRate { get; set; } = 0.03;

        public override string Print() {
            return base.Print() + $" | {MMRate}";
        }
        public void PayInterest(int months) {
            double interestToBePaid =
                this.MMRate / 12 * months * (double)this.GetBalance();
            decimal intToBePaidAsDecimal = (decimal)interestToBePaid;
            this.Deposit(intToBePaidAsDecimal);
        }
    }
}
