using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles2._0
{
    internal class Article
    {
        public String Title { get; set; }
        public String Content { get; set; }
        public String Author { get; set; }

        public Article(String title, String content, String author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"Edit: {this.Title} - {this.Content}: {this.Author}";
        }
    }
}
