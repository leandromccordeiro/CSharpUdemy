﻿namespace SecFourteen.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice()
        {
            
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            string result = $"Basic payment: {BasicPayment.ToString("F2")}\n" +
                $"Tax: {Tax.ToString("F2")}\n" +
                $"Total payment: {TotalPayment.ToString("F2")}";
            return result ;
        }
    }
}
