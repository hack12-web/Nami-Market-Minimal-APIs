namespace NamiMarket.Dtos
{
    public class PayrollReadDto
    {
        public int Id { get; set; }

        public string? Employee_ID { get; set; }

        public string? Employee_Name { get; set; }

        public string? Total_Days { get; set; }

        public string? Salary { get; set; }

        public string? Days_Works { get; set; }

        public DateTime Date { get; set; }
    }
}