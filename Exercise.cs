using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Exercise
    {


        // You must define a type for representing an exercise in code.
        // An exercise can be assigned to many students.Name of exercise
        // Language of exercise (JavaScript, Python, CSharp, etc.)
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public Exercise(string name, string language)
        {
            Name = name;
            Language = language;
        }
    public  Exercise()
    {

    }

    }
}