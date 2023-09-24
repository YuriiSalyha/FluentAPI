using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI
{
    public class Books
    {
        public int Id { get; set; }
        public string Title {  get; set; }
        public int Pages { get; set; }
        public int? Price { get; set; }
        public int? VariableToDelete { get; set; } 

        public int? IdPublisher { get; set; }
        public Publisher? Publisher { get; set; }

        public List<Autors> Autors { get; set; } = new();
    }
}
