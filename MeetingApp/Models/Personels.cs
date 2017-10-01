using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MeetingApp.Models
{
    public class Personels
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Personel_ID { get; set; }

        public string Personel_Name { get; set; }

        public string Personel_Surname { get; set; }
    }
}