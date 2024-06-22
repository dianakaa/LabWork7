using LabWork7;

Console.WriteLine("Исходные значения:\n");

Book book = new();
book.Print();

Book book1 = new("Евгений Онегин", "A.C.Пушкин", 340);
book1.Print();

Book book2 = new("Мастер и Маргарита", "М.А. Булгаков", 488);
book2.Print();

book++;
Console.WriteLine("Значения после ++: ");
book.Print();

Book book3 = new Book();
book3.Price = book1.Price + book2.Price;
Console.WriteLine("Значения после +: ");
book3.Print();

if (book1 == book2)
    Console.WriteLine("Книги равны");
else
    Console.WriteLine("Книги не равны");

if (book1 != book2)
    Console.WriteLine("Книги не равны");
else
    Console.WriteLine("Книги равны");

Book book4 = new() { Price = -138 };

if (book4)
    Console.WriteLine("Цена больше или равна 0");
else
    Console.WriteLine("Цена меньше 0");
