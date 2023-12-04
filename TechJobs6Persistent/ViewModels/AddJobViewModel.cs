using Microsoft.AspNetCore.Mvc.Rendering; //adding this to make selected list item list work, since needs rendering with html
using System.ComponentModel.DataAnnotations;
using TechJobs6Persistent.Models;

namespace TechJobs6Persistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job name is required.")]
        public string jobName { get; set; }
        public int employerId { get; set; }
        public List<SelectListItem> Employers { get; set; } = new List<SelectListItem>();

        public AddJobViewModel(List<Employer> employers)
        {
             //List<SelectListItem> selectList = new List<SelectListItem>();

            foreach (var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }
    }
}
