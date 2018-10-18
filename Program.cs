using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.Sqlite;

namespace StudentExercises
{
    public class Program
    {
        static void Main(string[] args)
       {
            SqliteConnection db = DatabaseInterface.Connection;
            DatabaseInterface.CheckExerciseTable();
            DatabaseInterface.CheckInstructorTable();
            DatabaseInterface.CheckCohortTable();


            /*
                1. Query database
                2. Convert result to list
                3. Use ForEach to iterate the collection
            */
            // List<Exercise> exercises = db.Query<Exercise>(@"SELECT * FROM Exercise").ToList();
            // exercises.ForEach(ex => Console.WriteLine($"{ex.Name}"));

            // Chaining LINQ statements together
             db.Query<Exercise>(@"SELECT * FROM Exercise ")
              .ToList()
              .ForEach(ex => Console.WriteLine($"{ex.Name}"));

              db.Execute($@"
                    INSERT INTO Exercise (Name, Language) VALUES ('SQL', 'C#'); ");
              db.Execute($@"
                    INSERT INTO Instructor (FirstName,LastName,SlackHandle,CohortId) VALUES ('Kimmie', 'Bird','KimmieBird','3'); ");


                 db.Query<Instructor, Cohort,Instructor>(@"
                SELECT instr.CohortId,
                       instr.FirstName,
                       instr.LastName,
                       instr.Id,
                       c.Id,
                       c.Name
                FROM Instructor instr
                JOIN Cohort c ON c.Id = instr.CohortId
            ", (instructor, cohort) =>
            {
                instructor.Cohort = cohort;
                return instructor;
            })

              .ToList()
              .ForEach(instr => Console.WriteLine($"{instr.FirstName} {instr.LastName} {instr.Cohort}"));

              db.Query<Student>(@"SELECT * FROM Student ")
              .ToList()
              .ForEach(stu => Console.WriteLine($"{stu.FirstName}{stu.LastName}{stu.Cohort}"));


         //   //Cohort Evening8 = new Cohort("Evening 8");
        //     Cohort Day25 = new Cohort("Day 25");
        //     Cohort Day26 = new Cohort("Day 26");
        //     Cohort Day27 = new Cohort("Day 27");

        //     //instructors
        //     Instructor Meg = new Instructor("Meg", "Ducharme", "slack", Day25);
        //     Instructor Jenna = new Instructor("Jenna", "Solis", "slack", Day26);
        //     Instructor Steve = new Instructor("Steve", "Lastname", "Slack", Day27);

        //     //students
        //     Student Gretchen = new Student("Gretchen", "Ward", "slack", Day27);
        //     Student Maddie = new Student("Maddie", "lastname", "slack", Day27);
        //     Student Leah = new Student("Leah", "Gwinn", "LeahGwinn", Day26);
        //     Student Wyatt = new Student("Wyatt", "Nutter", "WyattN", Day27);

        //     //exercises
        //     Exercise classes = new Exercise("classes", "C#");
        //     Exercise hashsets = new Exercise("hashsets", "C#");
        //     Exercise chickenMonkey = new Exercise("chickenMonkey", "JavaScript");
        //     Exercise nutshell = new Exercise("nutshell", "React");
        //     Exercise loops = new Exercise("loops", "JavaScript");
        //     Exercise practice = new Exercise("practice", "JavaScript");



        //     //assign exercises

        //     Meg.AssignExercise(classes, Leah);
        //     Meg.AssignExercise(loops, Leah);
        //     Meg.AssignExercise(nutshell, Wyatt);
        //     Meg.AssignExercise(loops, Wyatt);
        //     Jenna.AssignExercise(chickenMonkey, Maddie);
        //     Jenna.AssignExercise(nutshell, Maddie);
        //     Jenna.AssignExercise(chickenMonkey, Leah);
        //     Jenna.AssignExercise(practice, Leah);
        //     Jenna.AssignExercise(classes, Wyatt);
        //     Jenna.AssignExercise(loops, Wyatt);
        //     Steve.AssignExercise(nutshell, Leah);
        //     Steve.AssignExercise(hashsets, Leah);
        //     Steve.AssignExercise(classes, Maddie);
        //     Steve.AssignExercise(hashsets, Maddie);


        //    // Create a list of students. Add all of the student instances to it.
        //     List<Student> students = new List<Student> ()
        //     {
        //        Gretchen,
        //        Maddie,
        //        Leah,
        //        Wyatt
        //     };
        //     List<Cohort> Cohorts = new List<Cohort> ()
        //     {
        //        Evening8,
        //        Day25,
        //        Day26,
        //        Day27
        //     };

        //     // Create a list of exercises. Add all of the exercise instances to it.
        //     List<Exercise> exercises = new List<Exercise> ()
        //     {
        //         classes,
        //         hashsets,
        //         loops,
        //         chickenMonkey,
        //         nutshell,
        //         practice
        //     };

        //     // list instructors
        //     List<Instructor> instructors = new List<Instructor>()
        //     {
        //        Meg,
        //        Steve,
        //        Jenna
        //     };




        //     // Display any students that aren't working on any exercises
        //     var studentsWithNoExercises = students.Where(stu => stu.Exercises.Count() == 0);
        //     foreach (var stu in studentsWithNoExercises)
        //     {
        //         Console.WriteLine($"Students who aren't working on exercises: {stu.FirstName} {stu.LastName}");
        //     }

        //     var studentsWithExercises = students.Where(stu => stu.Exercises.Count() != 0);
        //     foreach (var stu in studentsWithExercises)
        //     {
        //         Console.WriteLine($"Students with exercises: {stu.FirstName} {stu.LastName}");
        //     }

        //    // List exercises for Javascript with where linq method

        //     IEnumerable<Exercise> JS = from JavaScript in exercises
        //     where JavaScript.Language == "JavaScript"
        //     select JavaScript;

        //     JS.ToList().ForEach(e => Console.WriteLine(e.Name));

        //     // List instructors in a cohort with linq method
        //    IEnumerable<Instructor> inst = from instructor in instructors
        //    where instructor.Cohort == Day25
        //    select instructor;

        //    inst.ToList().ForEach(i => Console.WriteLine($"instructor {i.FirstName} {i.Cohort.Name}"));


        }
    }
}




