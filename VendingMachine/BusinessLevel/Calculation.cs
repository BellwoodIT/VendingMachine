using System;
using System.Collections.Generic;

namespace VendingMachine.BusinessLevel
{

    public class Calculation
    {
        const int denoSupported = 5;
        const int INIT_QUANTITY = 5;
        public Deno[] acceptedCoin = new Deno[denoSupported];
        //Dictionary that holds all change.
        public Dictionary<double, int> changes = new Dictionary<double, int>();

        public Calculation()
        {
            acceptedCoin[0] = new Deno(5.0, INIT_QUANTITY, 0, false);
            acceptedCoin[1] = new Deno(1.0, INIT_QUANTITY, 0, false);
            acceptedCoin[2] = new Deno(0.25, INIT_QUANTITY, 0, false);
            acceptedCoin[3] = new Deno(0.1, INIT_QUANTITY, 0, false);
            acceptedCoin[4] = new Deno(0.05, INIT_QUANTITY, 0, false);
        }

        public bool CalculateChange(double productAmount)
        {
            bool changeSuccess = false;
            double cost = productAmount;
            double acceptedAmount = CalculateAcceptedCoin();
            double change = acceptedAmount - cost;
            Console.WriteLine("Change: " + change.ToString("0.00"));

            for (int i = 0; i < acceptedCoin.Length; i++)
            {
                change = Math.Round(change, 2);
                double denoRequired = 0.00;
                if (change >= acceptedCoin[i].Value && acceptedCoin[i].Quantity>0)
                {
                    // Caculate the deno required
                    denoRequired = Math.Floor(change / acceptedCoin[i].Value);
                    Console.WriteLine("Change of $" + acceptedCoin[i].Value.ToString("0.00") + ": " + denoRequired.ToString());
                    Console.WriteLine("current quantity of $" + acceptedCoin[i].Value.ToString("0.00") + ": " + acceptedCoin[i].Quantity.ToString());
                    // Check whether the deno is enough or not
                    if (denoRequired <= acceptedCoin[i].Quantity)
                    {
                        // Reduce the change
                        change -= (acceptedCoin[i].Value * denoRequired);
                        changes.Add(acceptedCoin[i].Value, (int)denoRequired);
                        Console.WriteLine("Change: " + change.ToString("0.00"));
                    }
                    else
                    {
                        // Based on current deno quantity to reduce the change
                        change -= (acceptedCoin[i].Value * acceptedCoin[i].Quantity);
                        changes.Add(acceptedCoin[i].Value, acceptedCoin[i].Quantity);
                        Console.WriteLine("Change: " + change.ToString("0.00"));
                    }

                    // Check whether the change is done
                    if (change == 0)
                    {
                        changeSuccess = true;
                        return changeSuccess;
                    }
                }
            }

            // Clear the changes
            changes.Clear();
            return changeSuccess;
        }

        public void ResetDeno()
        {
            // Reset the deno
            changes.Clear();
            for (int i = 0; i < acceptedCoin.Length; i++)
            {
                acceptedCoin[i].Quantity = INIT_QUANTITY;
                // clear the accepted coin
                acceptedCoin[i].AcceptedQuantity = 0;
                acceptedCoin[i].Accepted = false;
                Console.WriteLine("Accepted coin for deno " + acceptedCoin[i].Value + " X " + acceptedCoin[i].Quantity.ToString());
            }
        }

        public void EndCalculation()
        {
            // Update the deno after accepted coin
            for(int i=0;i<acceptedCoin.Length;i++)
            {
                if(acceptedCoin[i].Accepted)
                {
                    acceptedCoin[i].Quantity += acceptedCoin[i].AcceptedQuantity;
                    // clear the accepted coin
                    acceptedCoin[i].AcceptedQuantity = 0;
                    acceptedCoin[i].Accepted = false;                    
                }
                Console.WriteLine("Accepted coin for deno " + acceptedCoin[i].Value + " X " + acceptedCoin[i].Quantity.ToString());
            }

            // Update the deno after change coin
            for (int i = 0; i < acceptedCoin.Length;i++)
            {
                if(changes.ContainsKey(acceptedCoin[i].Value))
                {
                    Console.WriteLine("Before Change: Accepted coin for deno " + acceptedCoin[i].Value + " X " + acceptedCoin[i].Quantity.ToString());
                    int changeQty = changes[acceptedCoin[i].Value];
                    int remainQty = acceptedCoin[i].Quantity - changeQty;
                    acceptedCoin[i].Quantity = remainQty;
                    Console.WriteLine("Change coin for deno " + acceptedCoin[i].Value + " X " + changeQty.ToString());
                }
                Console.WriteLine("After Change: Accepted coin for deno " + acceptedCoin[i].Value + " X " + acceptedCoin[i].Quantity.ToString());
            }

            changes.Clear();
        }

        private double CalculateAcceptedCoin()
        {
            double totalAcceptedCoin = 0;
            for(int i=0;i<acceptedCoin.Length;i++)
            {
                if(acceptedCoin[i].Accepted)
                {
                    totalAcceptedCoin += (acceptedCoin[i].Value * acceptedCoin[i].AcceptedQuantity);
                }
            }
            return totalAcceptedCoin;
        }
    }
}
