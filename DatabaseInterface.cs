using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;
using System.Collections;
using Dapper;
using StudentExercises;

namespace StudentExercises
{
    public class DatabaseInterface
    {
        public static SqliteConnection Connection
        {

            get
            {
                string _connectionString = $"Data Source=./StudentExercises.db";
                return new SqliteConnection(_connectionString);
            }

        }
        public static void CheckExerciseTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;



                }
        public static void CheckInstructorTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;



                }
        public static void CheckCohortTable()
        {
            SqliteConnection db = DatabaseInterface.Connection;



                }

            }

        }

