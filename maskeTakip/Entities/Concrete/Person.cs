using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    
    interface IApplicantService
    {
        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);
    }
    public class ForeignerManager : IApplicantService
    {
        void IApplicantService.ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        bool IApplicantService.CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        List<Person> IApplicantService.GetList()
        {
            throw new NotImplementedException();
        }
    }
    public class PttManager
    {
        private IApplicantService _applicantService;
        PttManager(IApplicantService applicantService)
        {
            _applicantService= applicantService;
        }
        void GiveMask(Person person)
        {
            PersonManager personManager= new PersonManager();
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");
            }
        }
    }

    public class PersonManager:IApplicantService
    {
        void IApplicantService.ApplyForMask(Person person)
        {
            
        }

        List<Person> IApplicantService.GetList()
        {
            return new List<Person>();
        }

        bool IApplicantService.CheckPerson(Person person)
        {
            return true;
        }
    }
internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
    }
}
