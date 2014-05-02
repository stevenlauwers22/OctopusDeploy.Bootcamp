using System;
using System.Configuration;
using System.Reflection;
using FluentMigrator.Runner.Announcers;
using FluentMigrator.Runner.Initialization;

namespace OctopusDeploy.QFrameBootcamp.DB
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                var migrationConnectionString = ConfigurationManager.ConnectionStrings["BootcampConnectionString"].ConnectionString;
                var migrationAssembly = typeof(Program).Assembly;
                Execute(migrationAssembly, "migrate:up", "SqlServer", migrationConnectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }

        private static void Execute(Assembly assembly, string task, string databaseType, string connectionString)
        {
            const bool verbose = true;
            var consoleAnnouncer = new TextWriterAnnouncer(Console.Out)
            {
                ShowElapsedTime = verbose,
                ShowSql = verbose
            };

            var runnerContext = new RunnerContext(consoleAnnouncer)
            {
                Database = databaseType,
                Connection = connectionString,
                Timeout = 90,
                Target = assembly.Location,
                Task = task
            };

            var taskExecutor = new TaskExecutor(runnerContext);
            taskExecutor.Execute();
        }
    }
}
