using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Linq
{
    class AddressBookManager
    {
        List<ContactDetails> address;

        public List<ContactDetails> AddAddresss()
        {
            address.Add(new ContactDetails { personId = 1, adrsBookName = "TVS", firstName = "tom", lastName = "jerry", address = "tod road", state = "kerala", city = "ymg",zipCode=869542,phoneNumber=8546321556,emailAddress="jerry@gmail.com" });
            address.Add(new ContactDetails { personId = 2, adrsBookName = "CTS", firstName = "tim", lastName = "teddy", address = "mgm coloney", state = "TamilNadu", city = "madurai", zipCode = 568942, phoneNumber = 8542631564, emailAddress = "eddy@gmail.com" });
            address.Add(new ContactDetails { personId = 3, adrsBookName = "CTS", firstName = "jack", lastName = "brown", address = "vng road", state = "Kerala", city = "abc", zipCode = 845126, phoneNumber = 5423698542, emailAddress = "jack@gmail.com" });
            address.Add(new ContactDetails { personId = 6, adrsBookName = "TVS", firstName = "jessi", lastName = "Arul", address = "hall road", state = "TamilNadu", city = "madurai", zipCode = 956152, phoneNumber = 9856123457, emailAddress = "jessi@gmail.com" });
            address.Add(new ContactDetails { personId = 4, adrsBookName = "CTS", firstName = "marcus", lastName = "Daniel", address = "yng coloney", state = "TamilNadu", city = "chennai", zipCode = 758462, phoneNumber = 7856954236, emailAddress = "marcus@gmail.com" });
            address.Add(new ContactDetails { personId = 5, adrsBookName = "CTS", firstName = "stephan", lastName = "Kingsley", address = "mgr nagar", state = "kerala", city = "xxx", zipCode = 869542, phoneNumber = 6548597235, emailAddress = "stephank@gmail.com" });
            return address;
        }
    }
}
