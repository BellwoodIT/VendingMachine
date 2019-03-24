namespace VendingMachine.BusinessLevel
{
    public class Deno
    {
        private double value;
        private int quantity;
        private int acceptedQuantity;
        private bool accepted;

        public Deno(double denoValue, int denoQuantity, int denoAcceptedQuantity, bool denoAccepted)
        {
            value = denoValue;
            quantity = denoQuantity;
            acceptedQuantity = denoAcceptedQuantity;
            accepted = denoAccepted;
        }

        public double Value
        {
            get
            {
                return value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int AcceptedQuantity
        {
            get { return acceptedQuantity; }
            set { acceptedQuantity = value; }
        }

        public bool Accepted
        {
            get { return accepted; }
            set { accepted = value; }
        }
    }
}
