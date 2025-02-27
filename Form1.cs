namespace Step1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        List<Book> books = new List<Book>
            {
                new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", YearPublished = 1937 },
                new Book { Title = "1984", Author = "George Orwell", YearPublished = 1949 },
                new Book { Title = "Fahrenheit 451", Author = "Ray Bradbury", YearPublished = 1953 }
            };

        BookListView.PopulateListView(listView1, books);
    }
}
