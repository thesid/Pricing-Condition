using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingCondition
{
    public class Condition
    {

        public int id { get; set; }
        public int Sequence { get; set; }
        public string PricingConditionId { get; set; }
        public int PricingEventId { get; set; }
        public int UserId { get; set; }
        public int? SubsctiptionTypeId { get; set; }
        public int PromotionId { get; set; }
        public DateTime ValidityStart { get; set; }
        public DateTime ValidityEnd { get; set; }
        public int Amount { get; set; }
        public String Currency { get; set; }
        public String Comments { get; set; }

    }
}
