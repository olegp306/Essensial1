using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask2
{
    public class MyDocument
    {
        DocPart title = null;
        DocPart body = null;
        DocPart footer = null;

        public string Title { set { title.Content = value; } }
        public string Body { set { body.Content = value; } }
        public string Footer { set { footer.Content = value; } }


        void InitializeDocument()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();

        }
        public MyDocument()
        {
            InitializeDocument();
        }

        public MyDocument(string title, string body, string footer)
        {
            InitializeDocument();

            this.title.Content = title;
            this.body.Content = body;
            this.footer.Content = footer;
        }
        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }

    }
}

