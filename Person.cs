namespace Producer.Data
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Person
    {
        public int Id { get; set; }
        public string Pin { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public byte[]? Photo { get; set; }  // ← добавь сюда
    }
}

