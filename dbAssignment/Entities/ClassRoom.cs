using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp2.Entities
{
    public class ClassRoom
    {
        [Key] 
        public int Id { get; set; }
        public string ClassNo { get; set; }
    }
}
