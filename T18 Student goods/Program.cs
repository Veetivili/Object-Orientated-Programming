namespace T18_Student_goods
{
    public class Shelf
    {
        public int NumberOfItems { get; set; }
    }
    public class Book : Shelf
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }        
        public override string ToString()
        {
            return $"Book name: {Name}, Author: {Author}, Pages: {Pages}, PCS: {NumberOfItems}";
        }
    }
    public class Laptop : Shelf
    {
        public string Manufactor { get; set; }
        public string Model { get; set; }
        public override string ToString()
        {
            return $"Manufactor: {Manufactor}, Model: {Model}, PCS: {NumberOfItems}";
        }
    }
    public class Phone : Laptop
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shelf shelf = new Shelf();
            Book book = new Book();
            Laptop laptop = new Laptop();
            
            book.Name = "Harry Potter: Order of the Phoenix";
            book.Author = "J.K Rowling";
            book.Pages = 312;
            book.NumberOfItems = 2;
            Console.WriteLine(book.ToString());

            laptop.Manufactor = "Lenovo";
            laptop.Model = "T470S";
            laptop.NumberOfItems = 1;
            Console.WriteLine(laptop.ToString());

            Phone phone = new Phone();
            phone.Manufactor = "Apple";
            phone.Model = "13 Pro";
            phone.NumberOfItems = 1;
            Console.WriteLine(phone.ToString());
        }
    }
}