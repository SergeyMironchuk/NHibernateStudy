using ATB.RPO.NHibernateStudy.Models.Domain.Market.Entities;
using NHibernate.Mapping.ByCode.Conformist;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.Market.Mapping
{
    public class DocumentTypeMap: ClassMapping<DocumentType>
    {
        public DocumentTypeMap()
        {
            Table("Doc_Type");
            Lazy(false);
            Id(a => a.DocTypeID, m => m.Column("Doc_Type_ID"));
            Property(a => a.DocTypeName, m => m.Column("Doc_Type_Name"));
        }
    }
}