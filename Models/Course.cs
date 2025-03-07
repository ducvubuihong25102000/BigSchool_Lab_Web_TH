﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public bool IsCanceled { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerID { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
       
        [Required]
        public byte CategoryId { get; set; }
        public Category Category { get; set; }
    }


}