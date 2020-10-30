using System.ComponentModel.DataAnnotations;

namespace QualificationsAPI.Model.ViewModel.Subject
{
    public class SubjectInputModel : SubjectEditModel
    {
        [Required, MaxLength(10)]
        public string Code { get; set; }
        public string UserId { get; set; }
    }
}
