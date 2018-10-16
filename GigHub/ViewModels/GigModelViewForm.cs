using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.ViewModels
{
    public class GigModelViewForm
    {
        public string Local { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}