// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBConnection.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace AddressBookUnitTestProject
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using AddressBookServices;

    [TestClass]
    public class UnitTestClass
    {
        /// <summary>
        /// Common arrange for the entire MS Test Cases
        /// </summary>
        public static AddressBookRepository bookRepository = new AddressBookRepository();
        /// <summary>
        /// Instance of the address book model so as to create a entity for addition
        /// </summary>
        public static AddressBookModel addressBookModel = new AddressBookModel();
        /// <summary>
        /// TC 1 -- Check For Update of the Record and integrity of update method
        /// </summary>
        [TestMethod]
        public void EditUsingNameAndCheckForUpdate()
        {
            /// Act
            bool expected = true;
            /// Invoking the edit contact using name method so as to update the contact type
            /// Vijay -First name for the data row
            /// Family - New contact type
            /// 1 - update for contact type, 2- update the address book name
            bool actual = bookRepository.EditContactUsingName("Vijay", "Family", 1);
            /// Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 2 -- Check For Delete of the Record and integrity of delete method
        /// </summary>
        [TestMethod]
        public void DeleteUsingNameAndCheckForDelete()
        {
            /// Act
            bool expected = true;
            /// Invoking the delete contact using  first name method so as to delete the contact type
            /// Raju -First name for the data row
            bool actual = bookRepository.DeleteContactUsingName("Raju");
            /// Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 3 -- Check For Addition of the Record and integrity of add to record method
        /// </summary>
        [TestMethod]
        public void AddUsingInstanceOfAddressBookModelAndCheckForAdd()
        {
            /// Act
            bool expected = true;
            /// Initialising the instances with the values of the data attributes
            addressBookModel = new AddressBookModel
            {
                firstName = "Shardul",
                secondName = "Mehta",
                address = "Sec-5",
                city = "Jabalpur",
                state = "MP",
                zip = 482005,
                phoneNumber = 98784565,
                emailId = "shardul@gmail.com",
                contactType = "Profession",
                addressBookName = "PraveenRecord"
            };
            /// Invoking the add contact using the instance of the address bookmodel class so as to add the record
            bool actual = bookRepository.AddDataToTable(addressBookModel);
            /// Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
