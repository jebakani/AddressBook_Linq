using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Linq
{
    public class AddressBookManager
    {
        List<ContactDetails> address=new List<ContactDetails>();

        //adding item to the address book
        public List<ContactDetails> AddAddresss()
        {
            address.Add(new ContactDetails { personId = 1,  firstName = "tom", lastName = "jerry", address = "tod road", state = "kerala", city = "ymg",zipCode=869542,phoneNumber=8546321556,emailAddress="jerry@gmail.com" });
            address.Add(new ContactDetails { personId = 2,   firstName = "tim", lastName = "teddy", address = "mgm coloney", state = "TamilNadu", city = "madurai", zipCode = 568942, phoneNumber = 8542631564, emailAddress = "eddy@gmail.com" });
            address.Add(new ContactDetails { personId = 3,   firstName = "jack", lastName = "brown", address = "vng road", state = "Kerala", city = "abc", zipCode = 845126, phoneNumber = 5423698542, emailAddress = "jack@gmail.com" });
            address.Add(new ContactDetails { personId = 6,  firstName = "jessi", lastName = "Arul", address = "hall road", state = "TamilNadu", city = "madurai", zipCode = 956152, phoneNumber = 9856123457, emailAddress = "jessi@gmail.com" });
            address.Add(new ContactDetails { personId = 4,  firstName = "marcus", lastName = "Daniel", address = "yng coloney", state = "TamilNadu", city = "chennai", zipCode = 758462, phoneNumber = 7856954236, emailAddress = "marcus@gmail.com" });
            address.Add(new ContactDetails { personId = 5,  firstName = "stephan", lastName = "Kingsley", address = "mgr nagar", state = "kerala", city = "xxx", zipCode = 869542, phoneNumber = 6548597235, emailAddress = "stephank@gmail.com" });
            return address;
        }

        //UC2-Insert Into AddressBook
        public int InsertIntoAddressBook(ContactDetails contact)
        {
            contact.personId = 7;
            contact.firstName = "jeba";
            contact.lastName = "kani";
            contact.address = "xyr nagar";
            contact.city = "madurai";
            contact.state = "tamil nadu";
            contact.zipCode = 845236;
            contact.phoneNumber = 7856423695;
            contact.emailAddress = "ghk@gmail.com";
            AddAddresss();
            address.Add(contact);
            return 1;
        }

        //UC3-Edit contact
        public int EditContact(int personid,string firstName,long phoneNumber)
        {
            ContactDetails contact = (from add in address where add.personId == personid && add.firstName.Equals(firstName) select add).First();
            if(contact==null)
            {
                return 0;
            }
            else
            {
                contact.phoneNumber = phoneNumber;
                return 1;
            }
        }
        //UC5-Deteling the contact from list
        public int DeleteContact(int personid)
        {
            ContactDetails contact = (from add in address where add.personId == personid  select add).First();
            if (contact == null)
            {
                return 0;
            }
            else
            {
                address.Remove(contact);
                return 1;
            }
        }
        //UC6-Retriving the contact from list
        public string RetriveOnCityOrState(string city, string state)
        {
            string result = "";
            var res = (from add in address where (add.city == city || add.state == state) select add).ToList();
            foreach(var r in res)
            {
                result += "" + r.firstName + " ";
            }
            return result;
        }
        //UC7-Count the contact from list
        public string CountOfList()
        {
            string result = "";
            var res = address.GroupBy(x => x.city).Select(x => new { personId = x.Key, count = x.Count() });
            foreach (var r in res)
            {
                result += "" + r.personId + " "+r.count+" ";
            }
            return result;
        }
    }
}
