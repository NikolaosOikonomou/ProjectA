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
    class JsonTrainerDataService: School
    {
        public JsonTrainerDataService(string file, int numberOfEntries) 
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string json = reader.ReadToEnd();
                School dataInput = JsonConvert.DeserializeObject<School>(json);
                List<Trainer> trainers = new List<Trainer>();
                for (int i = 0; i < numberOfEntries; i++)
                {
                    Trainer trainer = new Trainer(dataInput.Trainers[i].FirstName, dataInput.Trainers[i].LastName, dataInput.Trainers[i].Subject);                   
                    trainers.Add(trainer); 
                }
                Trainers = trainers;
            }
        }  
    }
}
