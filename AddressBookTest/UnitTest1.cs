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
        [TestMethod]
        public void DeleteCOntactTest()
        {
            int expected = 1;
            addressBook.AddAddresss();
            int actual = addressBook.DeleteContact(2);
            Assert.AreEqual(expected, actual);
        }
        //UC6-retrival of records
        [TestMethod]
        public void RetrivalBaseonCityOrStateTest()
        {
            string expected = "tim jessi marcus ";
            addressBook.AddAddresss();
            string actual = addressBook.RetriveOnCityOrState("madurai","TamilNadu");
            Assert.AreEqual(expected, actual);
        }
        //UC7-Counting the person based in city
        [TestMethod]
        public void CountBaseonCityOrStateTest()
        {
            string expected = "ymg 1 madurai 2 abc 1 chennai 1 xxx 1 ";
            addressBook.AddAddresss();
            string actual = addressBook.CountOfList();
            Assert.AreEqual(expected, actual);
        }
        //UC7-Sorting of list
        [TestMethod]
        public void CSortingOfList()
        {
            string expected = "jessi tim ";
            addressBook.AddAddresss();
            string actual = addressBook.SortingOfList("madurai");
            Assert.AreEqual(expected, actual);
        }
        //UC10-Count by type
        [TestMethod]
        public void CountBaseonType()
        {
            string expected = "friends 3 profession 1 family 2 ";
            addressBook.AddAddresss();
            string actual = addressBook.CountOfListByType();
            Assert.AreEqual(expected, actual);
        }
    }
}
