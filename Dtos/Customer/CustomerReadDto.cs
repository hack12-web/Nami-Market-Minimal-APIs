namespace NamiMarket.Dtos
{
    public class CustomerReadDto
    {
        public int Id { get; set; }
        public string? Cust_ID { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Phone_Number { get; set; }
        public string? Country { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? NumCNI { get; set; }
        public DateTime Date { get; set; }
        public string? Num_Stand { get; set; }
    }
}