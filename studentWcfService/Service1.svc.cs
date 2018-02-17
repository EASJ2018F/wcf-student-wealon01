using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace studentWcfService
{   
    public class Service1 : IService1
    {
          static List<Student> elev = new List<Student>();


        public void AddStudent(string navn, string klasseNavn, string rum)
        {
            elev.Add(new Student(navn, klasseNavn, rum));
            
        }


        public void EditStudent(string navn, string newnavn, string klasseNavn, string rum)
        {
            Student aa = elev.Find(x => x.Navn == navn);
        
            aa.Navn = newnavn;
            aa.KlasseNavn = klasseNavn;
            aa.Rum = rum;
        }

  
        public Student FindStudents(string navn)
        {           
            return elev.Find(x => x.Navn == navn);
        }


        public List<Student> GetAllStudent()
        {
            return elev;
        }
  

        public void RemoveStudent(string navn)
        {
            elev.Remove(FindStudents(navn));
        }

    }
} 

       