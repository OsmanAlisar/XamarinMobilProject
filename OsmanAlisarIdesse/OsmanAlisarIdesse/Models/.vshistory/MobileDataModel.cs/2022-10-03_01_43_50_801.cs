using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    public class MobileDataModel
    {
        public long CardId { get; set; }
        public int CardTypeId { get; set; }
        public string CardTypeDescr { get; set; }
        public string CardName { get; set; }
        public bool CardIsMale { get; set; }
        public string CardTitleCode { get; set; }
        public string CardProfessionCode { get; set; }
        public bool CardIsInList { get; set; }
        public string CardMobilePhone { get; set; }
        public string CardStatus { get; set; }
        public string CardIdLocationId { get; set; }
        public long LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationPhone { get; set; }
        public string LocationBrickDescr { get; set; }
        public bool IsPharmacy { get; set; }
        public bool IsInMyList { get; set; }
        public string PropertyFrequency { get; set; }
        public string PropertySegment { get; set; }
        public string ThisMonthPlanCount { get; set; }
        public string ThisMonthRealizedPlanCount { get; set; }
        public string YtdPlanCount { get; set; }
        public string YtdRealizedPlanCount { get; set; }
        public string RealizedCountAvg { get; set; }
    }
}
