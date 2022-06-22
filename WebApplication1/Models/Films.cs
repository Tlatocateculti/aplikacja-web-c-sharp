using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Films
    {
        public int ID { set; get;  }
        public string Name { set; get; }
        public int Count { set;  get; }
        
        public void AddFilm()
        {
            Count++;
        }
    }
}
