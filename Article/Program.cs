namespace Article
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articles = Console.ReadLine().Split(", ");

            string title = articles[0];
            string content = articles[1];
            string author = articles[2];

            Article article = new Article(title, content, author)
            {
                Title = title,
                Content = content,
                Author = author
            };

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> commands = Console.ReadLine().Split(": ").ToList();

                string command = commands[0];

                if (command == "Edit")
                {
                    string newContent = commands[1];
                    article.Edit(newContent);
                }

                if (command == "ChangeAuthor")
                {
                    string newAuthor = commands[1];
                    article.ChangeAuthor(newAuthor);
                }

                if(command == "Rename")
                {
                    string newTitle = commands[1];
                    article.Rename(newTitle);
                }
            }

            Console.WriteLine(article);
            Console.ReadKey();

        }
    }
}
