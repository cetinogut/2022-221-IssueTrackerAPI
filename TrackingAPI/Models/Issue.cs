
using System.ComponentModel.DataAnnotations;
using TrackingAPI.Utilities

namespace TrackingAPI.Models
{
    public class Issue
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public Priority Priority { get; set; }
        public IssueType IssueType { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Completed { get; set; } // if null the issue is not completed yet


    }
}
