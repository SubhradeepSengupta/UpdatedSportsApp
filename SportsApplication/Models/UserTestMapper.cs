using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsApplication.Models
{
    public class UserTestMapper
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TestID { get; set; }
        public double CooperTestDistance { get; set; }
        public int SprintTestTime { get; set; }
        public String FitnessRating { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        [ForeignKey("TestID")]
        public virtual Test Test { get; set; }
    }
}
