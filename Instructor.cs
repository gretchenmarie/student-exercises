using System;

namespace StudentExercises{
 public class Instructor{
// You must define a type for representing an instructor in code.

// First name
public string FirstName {get;set;}
// Last name
public string LastName {get;set;}
// Slack handle
public string SlackHandle {get;set;}
// The instructor's cohort
public Cohort Cohort {get;set;}
//constructor
public Instructor(string firstname, string lastname, string slackhandle, Cohort cohort)
{
    FirstName = firstname;
    LastName = lastname;
    SlackHandle = slackhandle;
    Cohort  = cohort;

}

// A method to assign an exercise to a student
public Cohort cohort {get;set;}
//takes two arguments-exercise and student-takes the student and assigns and exercise to that
public void AssignExercise(Exercise exercise, Student student){
    student.Exercises.Add(exercise);

}
public Instructor()
{

}

    }


}