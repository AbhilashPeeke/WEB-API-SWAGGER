using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWAGGER_PRACTISE.Model
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Place { get; set; }
    }
}
