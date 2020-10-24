using System.ComponentModel.DataAnnotations;

namespace QualificationsAPI.Model
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Range(0, 5)]
        public decimal Note { get; set; }

        [Range(0, 1)]
        public decimal Percent { get; set; }

        public decimal Value { get => Note * Percent; }

        public int QualificationId { get; set; }
    }
}
