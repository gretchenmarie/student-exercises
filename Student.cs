using System;
using System.Collections.Generic;

namespace StudentExercises
{
    // You must define a type for representing a student in code.
    //  A student can only be in one cohort at a time.
    // A student can be working on many exercises at a time.
    public class Student
    {

        // First name
        public string FirstName { get; set; }
        // Last name
        public string LastName { get; set; }
        // Slack handle
        public string SlackHandle { get; set; }
        //Cohort instead of string is used so that you are getting back everything that is grouped with cohort-
        public Cohort Cohort { get; set; }

        //first cohort is the type second is the variable name (taco) *reference to line 25 public string cohort cohort {get;set;}
        // The collection of exercises that the student is
        //currently working on
       public List<Exercise> Exercises = new List<Exercise>();

        //constructor
        public Student(string firstname, string lastname, string slackhandle, Cohort cohort)
        {
            FirstName = firstname;
            LastName = lastname;
            SlackHandle = slackhandle;
            Cohort = cohort;

        }
    }

}








