namespace Step1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
    }

    public class BookListView
    {
        public static void PopulateListView(ListView listView, List<Book> books)
        {
            listView.View = View.Details;
            listView.Columns.Add("Title", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Author", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Year Published", -2, HorizontalAlignment.Left);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            foreach (Book book in books)
            {
                ListViewItem item = new ListViewItem(book.Title);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.YearPublished.ToString());
                listView.Items.Add(item);
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}