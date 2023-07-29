using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RequestParameters
{
    public class Pagination<T>
    {
        public List<T> Items { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public Pagination(List<T> items, int currentPage, int pageCount)
        {
            Items = items;
            CurrentPage = currentPage;
            PageCount = pageCount;
        }
    }
}
