namespace Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            List<Article> articles = new List<Article>();
            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                String line = Console.ReadLine();
                string[] tokens = line.Split(", ");
                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            String option = Console.ReadLine();
            if (option == "title")
            {
                foreach (Article article in articles.OrderBy(t => t.Title)) {
                    Console.WriteLine(article);
                }
            }
            if (option == "content")
            {
                foreach (Article article in articles.OrderBy(c => c.Content))
                {
                    Console.WriteLine(article);
                }
            }
            if (option == "author")
            {
                foreach (Article article in articles.OrderBy(a => a.Author))
                {
                    Console.WriteLine(article);
                }
            }
            Console.ReadKey();
        }
    }
}
