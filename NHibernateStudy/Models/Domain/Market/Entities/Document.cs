using System;

namespace ATB.RPO.NHibernateStudy.Models.Domain.Market.Entities
{
    public class Document
    {
        public virtual Guid DocID { get; set; }
        public virtual string DocNumber { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}