using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] givenArticle = Console.ReadLine().Split(", ");
            Article article = new Article(givenArticle[0], givenArticle[1], givenArticle[2]);
            int changesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < changesCount; i++)
            {
                string[] action = Console.ReadLine().Split(": ");
                string command = action[0];
                string argument = action[1];
                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangedAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article);

        }
        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Rename(string title) => Title = title;
            public void Edit(string content) => Content = content;
            public void ChangedAuthor(string author) => Author = author;

            public override string ToString() => $"{Title} - {Content}: {Author}";
        }
    }
}
