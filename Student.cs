using System;
using System.Collections.Generic;

namespace StudentExercises
{
// You must define a type for representing a student in code.
//  A student can only be in one cohort at a time.
// A student can be working on many exercises at a time.
  class Student{

// First name
public string FirstName {get;set;}
// Last name
public string lastName {get;set;}
// Slack handle
public string slackHandle {get;set;}
// The student's cohort
public string cohort {get;set;}
// The collection of exercises that the student is
//currently working on
  public List<Exercises> currentStudent = new List<Exercises>();
  }

}








