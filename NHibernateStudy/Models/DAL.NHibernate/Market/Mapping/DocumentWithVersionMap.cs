using ATB.RPO.NHibernateStudy.Models.Domain.Market.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.Market.Mapping
{
    public class DocumentWithVersionMap: JoinedSubclassMapping<DocumentWithVersion>
    {
        public DocumentWithVersionMap()
        {
            Table("Doc_Version");
            Key(k => k.Column("Doc_Version_ID"));
            Property(d => d.ApprovedDate, m => m.Column("Approved_Date"));
            Property(d => d.CreatedDate, m => m.Column("Created_Date"));
            Property(d => d.OperationDate, m => m.Column("Operation_Date"));
            Property(d => d.Comment, m => m.Column("Comment"));
        }
    }
}