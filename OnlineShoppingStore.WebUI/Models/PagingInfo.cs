using System;

namespace OnlineShoppingStore.WebUI.Models
{
    public class PagingInfo
    {

        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int Currentpage { get; set; }
        public int CurrentPage { get; set; }
        public int Totalpages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
            }
        }
    }
}