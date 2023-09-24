namespace FluentAPI
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Books> Books { get; set; } = new();
    }
}