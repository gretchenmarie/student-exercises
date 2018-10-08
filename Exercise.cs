using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Exercises
    {
// You must define a type for representing an exercise in code.
// An exercise can be assigned to many students.Name of exercise
// Language of exercise (JavaScript, Python, CSharp, etc.)
    public int Id {get;set;}
      public string exerciseName {get; set;}
      public string exerciseLanguage {get;set;}
public List<Student> AssignedExercises {get;set}
    }
}