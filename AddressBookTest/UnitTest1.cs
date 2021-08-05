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
        public void TestMethod1()
        {
        }
    }
}
