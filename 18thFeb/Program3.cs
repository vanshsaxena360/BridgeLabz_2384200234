using System;
using System.Collections.Generic;

// Abstract class representing different course types
abstract class CourseType {
    public string CourseName { get; set; }
    public string Department { get; set; }

    public CourseType(string courseName, string department) {
        CourseName = courseName;
        Department = department;
    }

    public abstract void Evaluate();
}

// Interface for Course to be handled in a generic way
interface ICourse {
    void DisplayCourseInfo();
}

// Exam-based course
class ExamCourse : CourseType, ICourse {
    public int ExamMarks { get; set; }

    public ExamCourse(string courseName, string department, int examMarks) 
        : base(courseName, department) {
        ExamMarks = examMarks;
    }

    public override void Evaluate() {
        Console.WriteLine("Course: " + CourseName + " (Dept: " + Department + ") - Evaluation Type: Exam (" + ExamMarks + " Marks)");
    }

    public void DisplayCourseInfo() {
        Evaluate();
    }
}

// Assignment-based course
class AssignmentCourse : CourseType, ICourse {
    public int AssignmentCount { get; set; }

    public AssignmentCourse(string courseName, string department, int assignmentCount) 
        : base(courseName, department) {
        AssignmentCount = assignmentCount;
    }

    public override void Evaluate() {
        Console.WriteLine("Course: " + CourseName + " (Dept: " + Department + ") - Evaluation Type: Assignments (" + AssignmentCount + " Assignments)");
    }

    public void DisplayCourseInfo() {
        Evaluate();
    }
}

// Generic Course class to handle different course types
class Course<T> where T : CourseType, ICourse {
    public T CourseDetails { get; set; }

    public Course(T courseDetails) {
        CourseDetails = courseDetails;
    }

    public void DisplayCourseInfo() {
        CourseDetails.DisplayCourseInfo();
    }
}

// University Course Management System
class University {
    private List<ICourse> courses = new List<ICourse>();

    public void AddCourse(ICourse course) {
        courses.Add(course);
    }

    public void ShowAllCourses() {
        Console.WriteLine("\nUniversity Course List:");
        foreach (var course in courses) {
            course.DisplayCourseInfo();
        }
    }
}

// Main execution
class Program {
    static void Main() {
        // Creating Exam-based and Assignment-based courses
        Course<ExamCourse> mathExam = new Course<ExamCourse>(new ExamCourse("Mathematics", "Science", 100));
        Course<AssignmentCourse> historyAssignment = new Course<AssignmentCourse>(new AssignmentCourse("History", "Arts", 5));

        // University system to manage courses
        University university = new University();
        
        // Add courses by casting them to ICourse
        university.AddCourse(mathExam.CourseDetails); // Casting to ICourse
        university.AddCourse(historyAssignment.CourseDetails); // Casting to ICourse

        // Display all courses
        university.ShowAllCourses();
    }
}
