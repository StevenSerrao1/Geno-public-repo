using System;
using System.Collections.Generic;
using Geno_App.Components.Courses;
using static Geno_App.Components.Courses.Course_1;

public class CourseData
{
    private Dictionary<string, ICourse> _courseData;

    public CourseData()
    {
        _courseData = new Dictionary<string, ICourse>();

        // Initialize courses
        InitializeCourses();
    }

    private void InitializeCourses()
    {
        var programmingCourse1 = new Course(
            CourseDescription: "This is an introduction to programming. :)",
            CourseID: "01",
            CourseName: "Introduction To Programming",
            CourseDifficulty: "Introductory/Beginner",
            CourseVersion: 1.0f,
            InstructorName: "Won Juan One Huan"
        );

        var programmingCourse2 = new Course(
            CourseDescription: "This is an introduction to Python. :)",
            CourseID: "02",
            CourseName: "Introduction To Python",
            CourseDifficulty: "Introductory/Beginner",
            CourseVersion: 1.0f,
            InstructorName: "Won Juan One Huan"
        );

        var programmingCourse3 = new Course(
            CourseDescription: "This is where you will build your first basic Python script. :)",
            CourseID: "03",
            CourseName: "First Python Script",
            CourseDifficulty: "Introductory/Beginner",
            CourseVersion: 1.0f,
            InstructorName: "Won Juan One Huan"
        );

        // Add courses to the dictionary
        AddCourse(programmingCourse1);
        AddCourse(programmingCourse2);
        AddCourse(programmingCourse3);
    }

    public void AddCourse(ICourse course)
    {
        if (!_courseData.ContainsKey(course.courseId))
        {
            _courseData.Add(course.courseId, course);
        }
        else
        {
            throw new ArgumentException($"A course with the code {course.courseId} already exists.");
        }
    }

    public ICourse GetCourse(string courseCode)
    {
        if (_courseData.TryGetValue(courseCode, out var course))
        {
            return course;
        }
        else
        {
            throw new KeyNotFoundException($"No course found with the code {courseCode}.");
        }
    }

    public IEnumerable<ICourse> GetAllCourses()
    {
        return _courseData.Values;
    }
}
