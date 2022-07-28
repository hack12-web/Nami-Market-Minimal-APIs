namespace NamiMarket.Dtos
{
    public class ReceptionistReadDto
    {
        public int Id { get; set; }

        public string? Rece_ID { get; set; }

        public string? First_Name { get; set; }

        public string? Last_Name { get; set; }

        public string? Gender { get; set; }
        
        public DateTime DateOfBirth { get; set; }

        public string? Phone_Number { get; set; }

        public string? Country { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }

        public DateTime JoiningDate { get; set; }

        public string? Username { get; set; }

        public string? Password { get; set; }
    }
}