﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Attendence
    {
        public Course Course { get; set; }

        [Key]
        [Column(Order =1)]
        public int CourseId { get; set; }
        public ApplicationUser Attendee { get; set; }

        [Key]
        [Column(Order =2)]
        public string AttendeeId { get; set; }
    }
}