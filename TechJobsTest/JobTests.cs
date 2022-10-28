using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using TechJobsOO;
namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        TechJob t1;
        TechJob t2;
        TechJob t3;
        TechJob t4;
        TechJob t5;
        TechJob t6;
        TechJob t7;
        TechJob t8;
        [TestInitialize]
        public void CreateObjects()
        {
            t1 = new TechJob();
            t2 = new TechJob();
            t3 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            t4 = new TechJob("Fullstack Web Developer", new Employer("Cybertron"), new Location("Home"), new PositionType("Fullstack"), new CoreCompetency("C#"));
            t5 = new TechJob("Fullstack Web Developer", new Employer("Cybertron"), new Location("Home"), new PositionType("Fullstack"), new CoreCompetency("C#"));
            t6 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            t7 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            t8 = new TechJob("Software Developer", new Employer("Boston Dynamics"), new Location("Boston"), new PositionType("Robotics"), new CoreCompetency(""));

            ////Fix Ids
            //t3.SetId(15);
            //t4.SetId(16);
            //t5.SetId(17);
            //t6.SetId(9);
            //t7.SetId(10);
            //t8.SetId(11);
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(t1.Equals(t2));
            Assert.IsTrue(t2.Id - t1.Id == 1);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(t3.Name, "Product tester");
            Assert.AreEqual(t3.EmployerName.Value, "ACME");
            Assert.AreEqual(t3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(t3.JobType.Value, "Quality control");
            Assert.AreEqual(t3.JobCoreCompetency.Value, "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(t4.Equals(t5));
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string returned = t6.ToString();
            Assert.IsTrue(returned[0] == '\n' && returned[^1] == '\n');
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string jobData = t7.ToString();
            Dictionary<string, string> labelsData= new Dictionary<string, string> { 
                {"ID", (t7.Id).ToString()},
                {"Name", t7.Name },
                {"Employer", t7.EmployerName.Value },
                {"Location", t7.EmployerLocation.Value },
                {"Position Type", t7.JobType.Value},
                {"Core Competency", t7.JobCoreCompetency.Value } 
            };

            foreach(KeyValuePair<string,string> row in labelsData)
            {
                Assert.IsTrue(jobData.Contains(row.Key) && jobData.Contains(row.Value));
            }

        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string jobData = t8.ToString();
            Assert.IsTrue(jobData.Contains("Core Competency: Data not available"));

        }
    }
}
