using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace QualificationsAPI.Model
{
    public class Qualification
    {
        public const int MAX_PERCENT = 1;

        [Key]
        public int Id { get; set; }

        [Range(1, 3), Required]
        public int Cort { get; set; }

        public List<Activity> Activities { get; set; } = new List<Activity>();

        public decimal TotalPartial { get; set; }
        public decimal TotalPercent
        {
            get
            {
                switch (Cort)
                {
                    case 1:
                    case 2:
                        return 0.3M;
                    case 3:
                        return 0.4M;
                    default:
                        return 0.0M;
                }
            }
        }
        public decimal TotalActivitiesPercent { get; set; }
        public decimal Total { get; set; }

        public bool AddActivity(Activity activity)
        {
            Calculate();

            if ((TotalActivitiesPercent + activity.Percent) > MAX_PERCENT)
                return false;

            Activities.Add(activity);
            return true;
        }

        public void Calculate()
        {
            TotalActivitiesPercent = Activities.Sum(a => a.Percent);
            TotalPartial = Activities.Sum(a => a.Value);
            Total = TotalPartial * TotalPercent;
        }
    }
}
