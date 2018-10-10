using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cohorts
            Cohort Evening8 = new Cohort("Evening 8");
            Cohort Day25 = new Cohort("Day 25");
            Cohort Day26 = new Cohort("Day 26");
            Cohort Day27 = new Cohort("Day 27");

            //instructors
            Instructor Meg = new Instructor("Meg", "Ducharme", "slack", Day25);
            Instructor Jenna = new Instructor("Jenna", "Solis", "slack", Day26);
            Instructor Steve = new Instructor("Steve", "Lastname", "Slack", Day27);

            //students
            Student Gretchen = new Student("Gretchen", "Ward", "slack", Day27);
            Student Maddie = new Student("Maddie", "lastname", "slack", Day27);
            Student Leah = new Student("Leah", "Gwinn", "LeahGwinn", Day26);
            Student Wyatt = new Student("Wyatt", "Nutter", "WyattN", Day27);

            //exercises
            Exercise classes = new Exercise("classes", "C#");
            Exercise hashsets = new Exercise("hashsets", "C#");
            Exercise chickenMonkey = new Exercise("chickenMonkey", "JavaScript");
            Exercise nutshell = new Exercise("nutshell", "React");
            Exercise loops = new Exercise("loops", "JavaScript");
            Exercise practice = new Exercise("practice", "JavaScript");

            //assign exercises
            Meg.AssignExercise(classes, Gretchen);
            Meg.AssignExercise(hashsets, Gretchen);
            Meg.AssignExercise(classes, Leah);
            Meg.AssignExercise(loops, Leah);
            Meg.AssignExercise(nutshell, Wyatt);
            Meg.AssignExercise(loops, Wyatt);
            Jenna.AssignExercise(chickenMonkey, Maddie);
            Jenna.AssignExercise(nutshell, Maddie);
            Jenna.AssignExercise(chickenMonkey, Leah);
            Jenna.AssignExercise(practice, Leah);
            Jenna.AssignExercise(classes, Wyatt);
            Jenna.AssignExercise(loops, Wyatt);
            Steve.AssignExercise(nutshell, Leah);
            Steve.AssignExercise(hashsets, Leah);
            Steve.AssignExercise(classes, Maddie);
            Steve.AssignExercise(hashsets, Maddie);
            Steve.AssignExercise(chickenMonkey, Gretchen);
            
             List<Student> students = new List<Student>();
             students.Add(Gretchen);
             students.Add(Wyatt);
             students.Add(Maddie);
             students.Add(Leah);

             List<Exercise> exercise = new List<Exercise>();
            exercise.Add(loops);
            exercise.Add(hashsets);
            exercise.Add(classes);
            exercise.Add(chickenMonkey);
            exercise.Add(practice);
            exercise.Add(nutshell);


        }
    }
}



