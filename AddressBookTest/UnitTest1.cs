using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBook_Linq;
namespace AddressBookTest
{
    
    [TestClass]
    public class UnitTest1
    {
        AddressBookManager addressBook;
        [TestInitialize]
        public void TestSetUp()
        {
            addressBook = new AddressBookManager();
        }
        [TestMethod]
        public void InsertionTest()
        {
            int expected = 1;
           ContactDetails contact= new ContactDetails();
            int actual=addressBook.InsertIntoAddressBook(contact);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EditCOntactTest()
        {
            int expected = 1;
            addressBook.AddAddresss();
            int actual = addressBook.EditContact(2, "tim", 87637489502);
            Assert.AreEqual(expected, actual);
        }
    }
}
