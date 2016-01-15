using System;
using System.Linq;
using ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.Market;
using NUnit.Framework;
namespace ATB.RPO.NHibernateStudy.Tests.Models.DAL.NHibernate.Market
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void TotalTest()
        {
            var repository = new Repository();
            var documents = repository.GetDocumentWithVersions()
                .Take(10)
                .ToList();
            foreach (var document in documents)
            {
                Console.WriteLine("{2} {0} {1}", document.VersionNumber, document.DocumentType.DocTypeName, document.DocID);
            }
        }
    }
}
