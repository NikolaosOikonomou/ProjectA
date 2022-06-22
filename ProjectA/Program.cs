using ProjectA.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectA.domain;

namespace ProjectA
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Semester semester = new Semester();
            
            School school = semester.Start();
            PrinterService.ListPrinter(school);
            
        } 

    }
}
