using System;
using System.Collections.Generic;

// Abstract JobRole class
abstract class JobRole {
    public string RoleName { get; set; }
    public JobRole(string roleName) {
        RoleName = roleName;
    }
}

// Specific job roles
class SoftwareEngineer : JobRole {
    public SoftwareEngineer() : base("Software Engineer") { }
}

class DataScientist : JobRole {
    public DataScientist() : base("Data Scientist") { }
}

// Generic Resume class
class Resume<T> where T : JobRole {
    public string CandidateName { get; set; }
    public T Role { get; set; }

    public Resume(string candidateName, T role) {
        CandidateName = candidateName;
        Role = role;
    }

    public void DisplayResume() {
        Console.WriteLine("Candidate: "+CandidateName+" | Applying for: "+Role.RoleName);
    }
}

// Resume screening system
class ResumeScreening {
    public static void ProcessResumes<T>(List<Resume<T>> resumes) where T : JobRole {
        Console.WriteLine("\nResumes.");
        foreach (var resume in resumes) {
            resume.DisplayResume();
        }
    }
}

// Main execution
class Program {
    static void Main() {
        // Creating resumes for different job roles
        Resume<SoftwareEngineer> resume1 = new Resume<SoftwareEngineer>("Alice", new SoftwareEngineer());
        Resume<DataScientist> resume2 = new Resume<DataScientist>("Bob", new DataScientist());

        // Storing resumes in lists
        List<Resume<SoftwareEngineer>> softwareResumes = new List<Resume<SoftwareEngineer>> { resume1 };
        List<Resume<DataScientist>> dataResumes = new List<Resume<DataScientist>> { resume2 };

        // Processing resumes
        ResumeScreening.ProcessResumes(softwareResumes);
        ResumeScreening.ProcessResumes(dataResumes);
    }
}
