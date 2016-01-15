using System.Linq;
using ATB.RPO.NHibernateStudy.Models.Domain.Market.Entities;

namespace ATB.RPO.NHibernateStudy.Models.Domain.Market
{
    public interface IRepository
    {
        IQueryable<DocumentWithVersion> GetDocumentWithVersions();
    }
}