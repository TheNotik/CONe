using Producer.Data;

namespace Producer.Service
{
    public class PersonService
    {
        private readonly AppDbContext _db;

        public PersonService(AppDbContext db)
        {
            _db = db;
        }

        public Person? GetByPin(string pin)
        {
            return _db.Persons.FirstOrDefault(p => p.Pin == pin);
        }

        public List<Person> GetAll()
        {
            return _db.Persons.ToList();
        }
        public void Add(Person person)
        {
            _db.Persons.Add(person);
            _db.SaveChanges();
        }

        public bool Delete(string pin)
        {
            var person = _db.Persons.FirstOrDefault(p => p.Pin == pin);
            if (person == null) return false;
            _db.Persons.Remove(person);
            _db.SaveChanges();
            return true;
        }
       
        }
    }
