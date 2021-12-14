using System;
using System.ComponentModel.DataAnnotations;
using static proj_studyno_http.core.Res;

namespace proj_studyno_http.core
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [Required, StringLength(30)]
        public string Address { get; set; }

        public rescolor Color { get; set; }

        public Restaurant()
        {
            
            
    }
    }
}
