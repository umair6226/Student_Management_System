namespace School_Management_System.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Students
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Registration_No { get; set; }

        [Required(ErrorMessage = "Enter Roll no")]
        public Nullable<int> Roll_No { get; set; }

        [Required(ErrorMessage = "Enter Student Name")]
        public string Student_Name { get; set; }

        [Required(ErrorMessage = "Enter Father Name")]
        public string Father_Name { get; set; }

        [Required(ErrorMessage = "Enter Student Contact No")]
        public string Student_Contact { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Father_Contact { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Class_Name { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Age")]
        public string Age { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        public string Address { get; set; }
    }
}
