namespace LabWork7
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book() : this("Собачье cердце", "М.А. Булгаков", 888) { }

        public Book(string name, string author, int price)
        {
            Name = name;
            Author = author;
            Price = price;
        }

        public static Book operator ++(Book book)
            => new() { Name = book.Name, Author = book.Author, Price = book.Price + 1 };

        public static Book operator +(Book book1, Book book2)
            => new() { Price = book1.Price + book2.Price, Name = book1.Name, Author = book1.Author };

        public static bool operator ==(Book book1, Book book2) 
            => book1.Price == book2.Price && book1.Name == book2.Name && book1.Author == book2.Author;

        public static bool operator !=(Book book1, Book book2) 
            => book1.Price != book2.Price || book1.Name != book2.Name || book1.Author != book2.Author;

        public static bool operator true(Book book4) => book4.Price >= 0;

        public static bool operator false(Book book4) => book4.Price < 0;

        public void Print()
        {
            Console.WriteLine($"Название: {Name}, Автор: {Author}, Цена: {Price}");
        }
    }

}
