using System;
namespace TechJobsOOAutoGraded6
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Task 3: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object? obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string? ToString()
        {
            if (Name == null || Name == "")
            {
                Name = "Data not available";
            }
            if (EmployerName.Value == null || EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value == null || EmployerName.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == null || EmployerName.Value == "")
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == null || EmployerName.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }
            return Environment.NewLine + $"ID: {Id}\r\nName: {Name}\r\nEmployer: {EmployerName.Value}\r\nLocation: {EmployerLocation.Value}\r\nPosition Type: {JobType.Value}\r\nCore Competency: {JobCoreCompetency.Value}" + Environment.NewLine;
        }

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

    }
}

