using System;
using System.Collections.Generic;
using System.Text;

namespace OopBankingProject {

    public class Checking : Account {

        private int lastCheckNumber { get; set; } = 0;

        public bool Pay(int CheckNumber, decimal Amount) {

            bool success = this.Withdraw(Amount);
            if(success) {
                this.lastCheckNumber = CheckNumber;
                return true;
            }
            return false;
        }

        public override string Print() {
            return base.Print() + $" | {lastCheckNumber}";
        }

    }
}
