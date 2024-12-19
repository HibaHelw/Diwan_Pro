using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiwanModels.Models.Base;

namespace DiwanModels.Models
{
    public class PostState : BaseModel
    {
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
