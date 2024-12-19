using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiwanModels.Models.Base;

namespace DiwanModels.Models
{
    public class PostEmployee : BaseModel
    {
        public int ReceiverId { get; set; }
        public int PostId { get; set; }
        public string State { get; set; }
    }
}
