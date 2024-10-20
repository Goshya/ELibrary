using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Elibrary.Models
{
    public class Book
    {
        public int Id { get;}
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int PubYear {  get; set; }
        public string RouteTitle { get; set; } = null!;
    }
}
