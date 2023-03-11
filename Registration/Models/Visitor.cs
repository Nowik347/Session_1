namespace Web_API.Models
{
    public class Visitor
    {
        // Info
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Purpose { get; set; }

        // Acceptor
        public string Otdel { get; set; }
        public string Sotrudnik { get; set; }

        // Visistor
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set;}
        public string? Company { get; set;}
        public string Note { get; set;}
        public string Date { get; set;}
        public int PassSerial { get; set; }
        public int PassNum { get; set; }

        // Files
        public int FileId { get; set; }
    }
}
