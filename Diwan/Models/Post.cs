using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiwanModels.Models.Base;

namespace DiwanModels.Models
{
    public class Post : BaseModel
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public string Details { get; set; }
        public string Notes { get; set; }
        public virtual PostType PostType { get; set; }
        public int PostTypeId { get; set; }
        public virtual Employee Sender { get; set; }
        public int SenderId { get; set; }
        public virtual List<Employee> Receivers { get; set; }
        public List<PostEmployee> ReceiverIds { get; set; }
        public virtual PostState PostState { get; set; }
        public int PostStateId { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime DateTime { get; set; }
        public int Year { get; set; }
        public byte[] Picture { get; set; }
        public string FilesPath { get; set; }
    }
}
