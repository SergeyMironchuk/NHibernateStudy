using System;

namespace ATB.RPO.NHibernateStudy.Models.Domain.Market.Entities
{
    public class DocumentWithVersion: Document
    {
        //public virtual Guid DocVersionID { get; set; }
        public virtual DateTime OperationDate { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ApprovedDate { get; set; }
        public virtual int VersionNumber { get; set; }
        public virtual string Comment { get; set; }
    }
}