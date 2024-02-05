using Autoteknik;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoteknikTests
{
    
    [TestClass]
    public class RepositoryTest
    {
        public IRepository<int, Owner> RepoOwner { get; set; }
        public IRepository<int, Owner> RepoMechanic { get; set; }
        public void SetUp()
        {
            RepoOwner = new Repository<int, Owner>();
        }
    }
}
