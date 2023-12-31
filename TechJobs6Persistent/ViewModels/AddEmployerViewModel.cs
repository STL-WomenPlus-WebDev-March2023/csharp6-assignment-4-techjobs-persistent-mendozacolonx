﻿using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage="Employer name is required.")]

        public string? Name { get; set; }
        [Required(ErrorMessage = "Employer location is required.")]
        public string? Location { get; set; }
    }
}
