using BookStore.Models.DataModels;
using System.Collections.Generic;

namespace BookStore.Models.Models
{
    public class ListResponse<T> where T : class
    {
        public List<T> Records { get; set; }

        public int TotalRecords { get; set; }
    }
}