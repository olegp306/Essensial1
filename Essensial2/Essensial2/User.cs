using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial2
{
    public class User
    {
        readonly DateTime dateOfCompletion;

        public string Login { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }

        public int Age { get; set; }
        public DateTime DateOfCompletion
        {
            get
            {
                return dateOfCompletion;
            }
        }



        public User()
        {
            dateOfCompletion = DateTime.Now;
        }
        public User(string login,string name, string surename,int age)
            :this()
        {
            this.Login = login;
            this.Name = name;
            this.Surename = surename;
            this.Age = age;
        }


        public void Show()
        {
            Console.WriteLine("Login:{0} Name:{1} Surename:{2} Age:{3} Date of completion:{4}", Login, Name, Surename, Age, DateOfCompletion);
        }
    }
}
