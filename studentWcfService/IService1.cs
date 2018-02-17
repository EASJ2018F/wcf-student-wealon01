using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace studentWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
  

        [OperationContract]
        void AddStudent(string navn, string klasseNavn, string rum);

    
        [OperationContract]
        Student FindStudents(string navn);


        [OperationContract]
        List<Student> GetAllStudent();


        [OperationContract]
        void RemoveStudent(string navn);


        [OperationContract]

        void EditStudent(string navn, string newnavn, string klasseNavn, string rum);


    }
}
