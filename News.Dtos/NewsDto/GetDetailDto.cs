using News.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Dtos.NewsDto
{
    public class GetDetailDto
    {
        public Detail Detail { get; set; } = new();
    }
}
