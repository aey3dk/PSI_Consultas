using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.Repository;

namespace Teste.DAL
{
    [TestClass]
    public class TestBaseEntity
    {
        [TestMethod]
        public void TestRecriarBaseDados()
        {
            new BaseRepository().RecriarBaseDados();
        }

        [TestMethod]
        public void TestPopularBaseDados()
        {
            new BaseRepository().PopularBaseDados();
        }
    }
}
