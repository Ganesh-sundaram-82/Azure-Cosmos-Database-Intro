using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosDB
{
    public class Employee
    {
        [JsonProperty("id")]
        public string EmployeeID { get; set; }
        [JsonProperty("name")]
        public Name EmployeeName { get; set; }
        public Address PresentAddress { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public DateTime DateJoined { get; set; }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName} {Suffix}";
        }
    }
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public override string ToString()
        {
            return $"\n Address1: {this.Address1} \n Address2: {this.Address2} \n City: {this.City} \n State: {this.State} \n Zip: {this.ZipCode}";
        }
    }
    public enum EmploymentType
    {
        FullTime = 1,
        PartTime = 2,
        Contrator = 3
    }
}
