namespace Day33_LinqAddressBook
{
    public class Program
    {
        public static void Main(string[]args)
        {
            List<AddressBookInformation> list = new List<AddressBookInformation>();
            Console.WriteLine("AddressBook Information");
            Console.WriteLine("1.AddingInfoToList\n2.RetriveAllInfoFromAddressBook");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    AddingDataToAddressBook(list);
                    Console.WriteLine("data addes sussesFully");
                    break;
                case 2:
                    
                    break;
            }
        }
        public static void RetriveAllData(List<AddressBookInformation> list)
        {
            try
            {
                foreach (AddressBookInformation item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AddingDataToAddressBook(List<AddressBookInformation> list)
        {
            try
            {
                list.Add(new AddressBookInformation() { ID = 1, FirstName = "Shree", LastName = "Gowri", Address = "Rtc Layout", City = "Bengaluru", State = "Karnataka", Zip = "4232", PhoneNumber = "12345", Email = "TVfc@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Family" });
                list.Add(new AddressBookInformation() { ID = 2, FirstName = "Lokesh", LastName = "gowda", Address = "Rtc Layout", City = "Bengaluru", State = "Karnataka", Zip = "4232", PhoneNumber = "12345", Email = "TVfd@gmail.com", AddressBookName = "AddressBook2", AddressBookType = "Friends" });
                list.Add(new AddressBookInformation() { ID = 3, FirstName = "jaganatha", LastName = "reddy", Address = "HSR Layout", City = "Hydrabad", State = "Telangana", Zip = "4233", PhoneNumber = "12345", Email = "TVfe@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Professional" });
                list.Add(new AddressBookInformation() { ID = 4, FirstName = "jadadeesha", LastName = "luhur", Address = "RCB Layout", City = "VijayaWada", State = "AndraPradesh", Zip = "4234", PhoneNumber = "12345", Email = "TVfg@gmail.com", AddressBookName = "AddressBook2", AddressBookType = "Family" });
                list.Add(new AddressBookInformation() { ID = 5, FirstName = "kalavathi", LastName = "jaga", Address = "HSDG Layout", City = "VijayaWada", State = "Andrapradesh", Zip = "4235", PhoneNumber = "12345", Email = "TVfh@gmail.com", AddressBookName = "AddressBook2", AddressBookType = "Friends" });
                list.Add(new AddressBookInformation() { ID = 6, FirstName = "Swati", LastName = "koduru", Address = "DDJDJ Layout", City = "Hydrabad", State = "Telangana", Zip = "4236", PhoneNumber = "12345", Email = "TVfshg@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Professional" });
                list.Add(new AddressBookInformation() { ID = 7, FirstName = "sheshank", LastName = "YK", Address = "jayanagara", City = "Bengaluru", State = "Karnataka", Zip = "4238", PhoneNumber = "12345", Email = "Thsgva@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Family" });
                RetriveAllData(list);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}