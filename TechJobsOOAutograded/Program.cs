using System;
using System.Collections.Generic;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {

            TechJobs techJobs = new TechJobs();
            techJobs.RunProgram();
            string e = "ID: 7\r\nName: Product tester\r\nEmployer: ACME\r\nLocation: Desert\r\nPosition Type: Quality control\r\nCore Competency: Persistence\r\n\r\n\r\nID: 8\r\nName: Web Developer\r\nEmployer: LaunchCode\r\nLocation: St. Louis\r\nPosition Type: Front-end developer\r\nCore Competency: JavaScript\r\n\r\n\r\nID: 9\r\nName: Ice cream tester\r\nEmployer: Data not available\r\nLocation: Home\r\nPosition Type: UX\r\nCore Competency: Tasting ability\r\n";
            string a = "ID: 7\r\nName: Product tester\r\nEmployer: ACME\r\nLocation: Desert\r\nPosition Type: Quality control\r\nCore Competency: Persistence\r\n\r\n\r\nID: 8\r\nName: Web Developer\r\nEmployer: LaunchCode\r\nLocation: St. Louis\r\nPosition Type: Front-end developer\r\nCore Competency: JavaScript\r\n\r\n\r\nID: 9\r\nName: Ice cream tester\r\nEmployer: Data not available\r\nLocation: Home\r\nPosition Type: UX\r\nCore Competency: Tasting ability\r\n";
            Console.WriteLine(e== a);

        }
    }
}