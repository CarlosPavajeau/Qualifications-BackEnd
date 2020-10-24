using System.ComponentModel.DataAnnotations;

namespace QualificationsAPI.Model.ViewModel.Subject
{
    public class SubjectEditModel
    {
        [Required]
        public string Name { get; set; }
    }
}
