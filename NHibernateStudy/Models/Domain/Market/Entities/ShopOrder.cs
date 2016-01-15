using System;

namespace ATB.RPO.NHibernateStudy.Models.Domain.Market.Entities
{
    public class ShopOrder: DocumentWithVersion
    {
        public virtual Guid ContragentID { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual string AutoOrderNumber { get; set; }
        public virtual int AutoOrderVersion { get; set; }
        public virtual DateTime ReceiptDate { get; set; }
        public virtual DateTime DeliveryDate { get; set; }
    }
}