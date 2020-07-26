using System;
using System.ComponentModel.DataAnnotations;

namespace IssueMS.Models
{
    public class Issue
    {
        public int Id { get; set; }

        [Display(Name = "Web Application")]
        public string AppId { get; set; }
        public string Title { get; set; }
        public string Report { get; set; }

        [DataType(DataType.Date)]
        public DateTime Time { get; set; }
        

    }
}
