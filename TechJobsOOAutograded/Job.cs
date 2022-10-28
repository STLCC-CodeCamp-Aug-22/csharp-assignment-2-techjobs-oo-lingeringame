using System;
using System.Collections.Immutable;

namespace TechJobsOO
{
    public class TechJob
    {

        public int Id { get; private set; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public TechJob()
        {
            Id = nextId;
            nextId++;
        }
        public TechJob(string name, Employer employer, Location location, PositionType positionType, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = positionType;
            JobCoreCompetency = coreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is TechJob job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            return $"\n" +
                $"ID: {Id}\n" +
                $"Name: {(CheckIfFieldValueIsNull(Name) ? "Data not available" : Name)}\n" +
                $"Employer: {(CheckIfFieldValueIsNull(EmployerName.Value) ? "Data not available" : EmployerName.Value)}\n" +
                $"Location: {(CheckIfFieldValueIsNull(EmployerLocation.Value) ? "Data not available" : EmployerLocation.Value)}\n" +
                $"Position Type: {(CheckIfFieldValueIsNull(JobType.Value) ? "Data not available" : JobType.Value)}\n" +
                $"Core Competency: {(CheckIfFieldValueIsNull(JobCoreCompetency.Value) ? "Data not available" : JobCoreCompetency.Value)}" +
                $"\n";
        }
        private bool CheckIfFieldValueIsNull(string value)
        {
            if(value == null || string.IsNullOrEmpty(value))
            {
                return true;
            } else
            {
                return false;
            }
        } 
        public void SetId(int value)
        {
            Id = value;
        }
    }
}