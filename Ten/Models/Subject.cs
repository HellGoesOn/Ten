namespace Ten.Models
{
    public class Subject : IModel
    {
        public Subject(int? id, string name)
        {
            Id = id;
            Name = name;
        }

        public int? Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"[ {this.GetType().Name} : (Id={Id}, Name={Name}) ]";
        }
    }
}
