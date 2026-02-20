using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//https://pspu.ru/about_the_university/news/
namespace Common
{
    public class News
    {
        public string Img { get; set; }
        public DateTime Date { get; set; }
        public string Badge { get; set; }
        public string Title { get; set; }
        public string Src { get; set; }

        public News(string img, DateTime date, string badge, string title, string src)


        {
            this.Img = img;
            this.Date = date;
            this.Badge = badge;
            this.Title = title;
            this.Src = src;
        }
    }
}
