using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comboBox.Classes
{
    class ShippingCharges
    {
        private double weight;

        public ShippingCharges(double packageWeight)
        {
            this.weight = packageWeight;
        }

        public string CalculateShippingCharges(double distance)
        {
            double standardRate = 0.0;

            // Calculate number of 500-mile increments
            int MileIncrements = (int)Math.Ceiling(distance / 500);

            if (weight <= 2)
            {
                standardRate = 1.10;
            }
            else if (weight > 2 && weight <= 6)
            {
                standardRate = 2.20;
            }
            else if (weight > 6 && weight <= 10)
            {
                standardRate = 3.70;
            }
            else if (weight > 10)
            {
                standardRate = 4.80;
            }

            // Calculate the total charges
            double totalCharges = standardRate * MileIncrements;

            return totalCharges+" CAD";
        }
    }
}
