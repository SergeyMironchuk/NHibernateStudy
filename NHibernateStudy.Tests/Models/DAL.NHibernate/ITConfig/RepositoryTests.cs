using System;
using System.Linq;
using ATB.RPO.NHibernateStudy.Models.DAL.NHibernate.ITConfig;
using NUnit.Framework;

namespace ATB.RPO.NHibernateStudy.Tests.Models.DAL.NHibernate.ITConfig
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void TotalTest()
        {
            var repository = new Repository();
            var essences = repository
                .GetEssences()
                .Take(10)
                .ToList();

            //foreach (var essence in essences)
            //{
            //    Console.WriteLine("{0}", essence.EssenceName);
            //    foreach (var value in essence.Values)
            //    {
            //        Console.WriteLine("\t{0} = {1}", value.Attribute.AttributeName, value.Value);
            //    }
            //}
        }
    }
}
