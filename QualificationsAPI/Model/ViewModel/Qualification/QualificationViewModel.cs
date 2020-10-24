using QualificationsAPI.Model.ViewModel.Activity;
using System.Collections.Generic;

namespace QualificationsAPI.Model.ViewModel.Qualification
{
    public class QualificationViewModel
    {
        public int Id { get; set; }
        public int Cort { get; set; }
        public decimal TotalPartial { get; set; }
        public decimal TotalPercent { get; set; }
        public decimal TotalActivitiesPercent { get; set; }
        public decimal Total { get; set; }

        public List<ActivityViewModel> Activities { get; set; }
    }
}
