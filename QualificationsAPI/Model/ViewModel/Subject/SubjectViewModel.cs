using QualificationsAPI.Model.ViewModel.Qualification;
using System.Collections.Generic;

namespace QualificationsAPI.Model.ViewModel.Subject
{
    public class SubjectViewModel : SubjectInputModel
    {
        public List<QualificationViewModel> Qualifications { get; set; }
        public decimal Definitive { get; set; }
    }
}
