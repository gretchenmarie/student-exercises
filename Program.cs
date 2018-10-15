using System;
using System.Collections.Generic;
using System.Linq;

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


           // Create a list of students. Add all of the student instances to it.
            List<Student> students = new List<Student> ()
            {
               Gretchen,
               Maddie,
               Leah,
               Wyatt
            };
            List<Cohort> Cohorts = new List<Cohort> ()
            {
               Evening8,
               Day25,
               Day26,
               Day27
            };

            // Create a list of exercises. Add all of the exercise instances to it.
            List<Exercise> exercises = new List<Exercise> ()
            {
                classes,
                hashsets,
                loops,
                chickenMonkey,
                nutshell,
                practice
            };

            // list instructors
            List<Instructor> instructors = new List<Instructor>()
            {
               Meg,
               Steve,
               Jenna
            };




            // Display any students that aren't working on any exercises
            var studentsWithNoExercises = students.Where(stu => stu.Exercises.Count() == 0);
            foreach (var stu in studentsWithNoExercises)
            {
                Console.WriteLine($"Students who aren't working on exercises: {stu.FirstName} {stu.LastName}");
            }

            var studentsWithExercises = students.Where(stu => stu.Exercises.Count() != 0);
            foreach (var stu in studentsWithExercises)
            {
                Console.WriteLine($"Students with exercises: {stu.FirstName} {stu.LastName}");
            }

           // List exercises for Javascript with where linq method

            IEnumerable<Exercise> JS = from JavaScript in exercises
            where JavaScript.Language == "JavaScript"
            select JavaScript;

            JS.ToList().ForEach(e => Console.WriteLine(e.Name));

            // List instructors in a cohort with linq method
           IEnumerable<Instructor> inst = from instructor in instructors
           where instructor.Cohort == Day25
           select instructor;

           inst.ToList().ForEach(i => Console.WriteLine($"instructor {i.FirstName} {i.Cohort.Name}"));


        }
    }
}




