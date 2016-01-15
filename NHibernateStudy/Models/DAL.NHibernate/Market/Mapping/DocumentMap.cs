using ATB.RPO.NHibernateStudy.Models.Domain.Market.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.Market.Mapping
{
    public class DocumentMap: ClassMapping<Document>
    {
        public DocumentMap()
        {
            Table("Doc");
            Id(d => d.DocID, m => m.Column("Doc_Version_ID"));
            Property(d => d.DocNumber, m => m.Column("Doc_Number"));
            ManyToOne(d => d.DocumentType, m => m.Column("Doc_Type_ID"));
        }
    }
}