using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comboBox.Classes
{
    class BankCharges
    {
        private decimal endingBalance;
        private int numberOfChecks;

        public BankCharges(decimal endingBalance, int numberOfChecks)
        {
            this.endingBalance = endingBalance;
            this.numberOfChecks = numberOfChecks;
        }

        public string CalculateServiceFees()
        {
            // Base service fee of $10
            decimal serviceFees = 10;

            // Extra fee if the balance falls below $400
            if (endingBalance < 400)
            {
                serviceFees += 15;
            }

            // Calculate fees based on the number of checks
            if (numberOfChecks < 20)
            {
                serviceFees += numberOfChecks * 0.10m;
            }
            else if (numberOfChecks >= 20 && numberOfChecks <= 39)
            {
                serviceFees += numberOfChecks * 0.08m;
            }
            else if (numberOfChecks >= 40 && numberOfChecks <= 59)
            {
                serviceFees += numberOfChecks * 0.06m;
            }
            else
            {
                serviceFees += numberOfChecks * 0.04m;
            }

            return serviceFees+" CAD";
        }
    }
}
