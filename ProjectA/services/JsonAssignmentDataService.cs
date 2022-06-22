using Newtonsoft.Json;
using ProjectA.domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.services
{
    class JsonAssignmentDataService: School
    {
        public JsonAssignmentDataService(string file, int numberOfEntries)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string json = reader.ReadToEnd();
                School dataInput = JsonConvert.DeserializeObject<School>(json);
                List<Assignment> assignments = new List<Assignment>();
                for (int i = 0; i < numberOfEntries; i++)
                { 
                    Assignment assignment = new Assignment(dataInput.Assignments[i].Title, dataInput.Assignments[i].Description,
                        dataInput.Assignments[i].SubDateTime);
                    assignments.Add(assignment);
                }
                Assignments = assignments;
            }
        }
    }
}
