using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MeetingApp.Models
{
    public class MeetingDetail
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Meeting_ID { get; set; }

        [StringLength(50, ErrorMessage = "Must be at least 50 characters long.")]
        [Required(ErrorMessage = "Please write meeting title")]
        [Display(Name = "Title")]
        public string Meeting_Title { get; set; }

        [Required(ErrorMessage = "Please enter meeting Date")]
        [Display(Name = "Date")]
        public DateTime Meeting_Date { get; set; }

        [Required(ErrorMessage = "Please enter meeting start time")]
        [Display(Name = "Start Time")]
        public string Meeting_StartTime { get; set; }

        [Required(ErrorMessage = "Please enter meeting end time")]
        [Display(Name = "End Time")]
        public string Meeting_EndTime { get; set; }

        //[Required(ErrorMessage = "You must select at least 1 participants")]
        //[Display(Name = "Participants")]
        //public Personels[] Participants { get; set; }

    }
}