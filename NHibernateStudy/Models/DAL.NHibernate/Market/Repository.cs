using System.Linq;
using ATB.RPO.NHibernateStudy.Models.Domain.Market;
using ATB.RPO.NHibernateStudy.Models.Domain.Market.Entities;
using NHibernate.Linq;

namespace ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.Market
{
    public class Repository: IRepository
    {
        public IQueryable<DocumentWithVersion> GetDocumentWithVersions()
        {
            var session = NHibernateHelper.GetCurrentSession();
            return session.Query<DocumentWithVersion>()
                .Fetch(d => d.DocumentType);
        }
    }
}