using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public class Autors
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }

        public List<Books> Books { get; set; } = new();
    }
}
