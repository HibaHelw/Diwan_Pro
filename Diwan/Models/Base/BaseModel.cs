using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiwanModels.Models.Base
{
    public class BaseModel
    {
        public int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsExist { get; set; }

        public BaseModel()
        {
            CreatedAt = DateTime.Now;
            IsExist = true;
        }
    }
}
