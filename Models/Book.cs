using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Book
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public int PublicationYear { get; set; }
            public string Author { get; set; }
            public string Reviews { get; set; }
    }
}
