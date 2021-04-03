using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_app.Data.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }


        public int PublisherId { get; set; }
        public List<int> AuthorIds { get; set; } 
        //List jer cemo ponuditi da se Book spremi u pivot tablicu Book_Authors, knjiga može imati više autora.
    }
}
