using System;
using System.Collections.Generic;
using System.Linq;

namespace Approg3_lab.Models
{
    public class People
    {
        public List<PersonModels> peopleList = new List<PersonModels>();
        public People()
        {
            peopleList.Add(new PersonModels
            {
                Id = 1,
                Name = "Elon",
                Surname = "Musk",
                Position = "Engineer"
            });

            
        }

        public void CreatePerson(PersonModels person)
        {
            try
            {
                int maxId = peopleList.Count == 0 ? 0 : peopleList.Select(item => item.Id).Max();
                person.Id = maxId + 1;
                peopleList.Add(person);
            }
            catch (Exception)
            { }
        }

        public void UpdatePerson(PersonModels person)
        {
            try
            {
                //foreach (BookModels bm in booksList)
                //{
                //    if (bm.Id == bookModel.Id)
                //    {
                //        booksList.Remove(bm);
                //        booksList.Add(bookModel);
                //        break;
                //    }
                //}
                PersonModels pm = peopleList.Find(item => item.Id == person.Id);
                    pm.Name = person.Name;
                    pm.Surname = person.Surname;
                    pm.Position = person.Position;
            }
            catch (Exception)
            {
            }
        }

        //Advanced task
        public PersonModels ShowPerson(int Id)
        {
            return peopleList.Find(item => item.Id == Id);
        }

        public void DeletePerson(int Id)
        {
            try
            {
                    peopleList.Remove(peopleList.Find(item => item.Id == Id));
            }
            catch (Exception)
            {
            }          
        }
    }
}