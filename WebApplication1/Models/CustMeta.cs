using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication1.Models
{
    [MetadataType(typeof(MetaDataForCustomerMaster))]
    public partial class CustomerMaster
    {
    }
    [DataContract]
    public class MetaDataForCustomerMaster
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string PhoneAlt { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Bank { get; set; }
        [DataMember]
        public string SavingsAccountNumber { get; set; }
        [DataMember]
        public string IFSCCode { get; set; }
        [DataMember]
        public string ques1 { get; set; }
        [DataMember]
        public string ans1 { get; set; }
        [DataMember]
        public string ques2 { get; set; }
        [DataMember]
        public string ans2 { get; set; }
        [DataMember]
        public string ques3 { get; set; }
        [DataMember]
        public string ans3 { get; set; }
    }
}