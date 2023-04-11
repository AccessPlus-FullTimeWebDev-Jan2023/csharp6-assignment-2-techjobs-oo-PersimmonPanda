// HERE IS WHERE I MAKE THE TESTS FOR MY TESTS

using System.Data;
using System.Xml.Linq;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        //Testing Objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //initalize your testing objects here
        [TestMethod]
        public void TestSettingJobId()
        {
            int diff = job2.Id - job1.Id;
            Assert.AreEqual(1, diff);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job4.Name, "Product tester");
            Assert.AreEqual(job4.EmployerName.Value, "ACME");
            Assert.AreEqual(job4.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job4.JobType.Value, "Quality control");
            Assert.AreEqual(job4.JobCoreCompetency.Value, "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.AreEqual(job3.ToString().StartsWith(Environment.NewLine), true);
            Assert.AreEqual(job3.ToString().EndsWith(Environment.NewLine), true);
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string CorrectLabelsAndData = Environment.NewLine + $"ID: {job3.Id}\r\nName: {job3.Name}\r\nEmployer: {job3.EmployerName.Value}\r\nLocation: {job3.EmployerLocation.Value}\r\nPosition Type: {job3.JobType.Value}\r\nCore Competency: {job3.JobCoreCompetency.Value}" + Environment.NewLine;

            Assert.AreEqual(CorrectLabelsAndData, job3.ToString());
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            job3.Name = "";
            string EmptyFieldToStringExampleOutput = Environment.NewLine + $"ID: {job3.Id}\r\nName: Data not available\r\nEmployer: {job3.EmployerName.Value}\r\nLocation: {job3.EmployerLocation.Value}\r\nPosition Type: {job3.JobType.Value}\r\nCore Competency: {job3.JobCoreCompetency.Value}" + Environment.NewLine;

            Assert.AreEqual(job3.ToString(), EmptyFieldToStringExampleOutput);
        }
    }
}

