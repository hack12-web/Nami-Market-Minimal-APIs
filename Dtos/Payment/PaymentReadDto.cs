namespace NamiMarket.Dtos
{
    public class PaymentReadDto
    {
        public int Id { get; set; }

        public string? Fina_ID { get; set; }

        public string? Cust_ID { get; set; }

        public string? Cust_Name { get; set; }

        public string? TypeOfPay { get; set; }

        public string? Num_Stand { get; set; }

        public string? Amount_Pay { get; set; }
        
        public DateTime Date { get; set; }
    }
}