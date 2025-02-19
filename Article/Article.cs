using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    internal class Article
    {
        public String Title { get; set; }
        public String Content { get; set; }
        public String Author { get; set; }

        public Article(String title, String content, String author) { 
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(String content) {
            this.Content = content;
        }

        public void ChangeAuthor(String author)
        {
            this.Author = author;
        }
        public void Rename(String title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"Edit: {this.Title} - {this.Content}: {this.Author}";
        } 

    }
}
