using CSharpOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpOOP.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *   Step 1 - Create Models folder
             *   Step 2 - Create Context Class, and any required model classes
             *   Step 3 - For each Class:
             *   a - Name the tables for the model classes.
             *   b - Declare Primary Key Property.
             *   c - Specify other columns.
             *   Step 4 - Setup Context.
             *   - Inherit from DbContext
             *   - Declare table DbSets
             *   - Implement OnConfiguring wiht Connection String
             *   Implemenet OnModelCreating with string collation and foreign keys
             *   Step 5 - Create a migration using 'dotnet ef migrations add initialMigration' in package manager console (in the project folder).
             * 
             *  Foreign Keys:
             *  - Create the property to serve as the key itself (typically an int)
             *  - Create the navigation property in the child model (singular) with [ForeignKey)]
             *  - Create the navigation property in the parent model (plural).
             * **/


        }
    }
}