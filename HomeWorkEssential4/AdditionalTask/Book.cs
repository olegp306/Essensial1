using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    
    class Book
    {
        Author author= new Author();
        Title title=new Title();
        Content content=new Content();

        public void AddAutor(string autor)
        {
            Console.WriteLine("Изменен автор книги");
            this.author.Name = autor;
            this.author.Show();
        }

        public void AddTitle(string title)
        {
            Console.WriteLine("Изменен Title книги");
            this.title.Name = title;
            this.title.Show();
        }

        public void AddContent(string content)
        {
            Console.WriteLine("Изменен content книги");
            this.content.Name = content;
            this.content.Show();
        }


    }
}
