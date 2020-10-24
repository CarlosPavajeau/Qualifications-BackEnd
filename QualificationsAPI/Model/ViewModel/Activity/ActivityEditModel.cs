using System.ComponentModel.DataAnnotations;

namespace QualificationsAPI.Model.ViewModel.Activity
{
    public class ActivityEditModel
    {
        [Required]
        public string Name { get; set; }

        [Range(0, 5)]
        public decimal Note { get; set; }

        [Range(0, 1)]
        public decimal Percent { get; set; }

        public int QualificationId { get; set; }
    }
}
