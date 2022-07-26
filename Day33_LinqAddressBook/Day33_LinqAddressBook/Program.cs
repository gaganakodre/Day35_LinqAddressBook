namespace Day33_LinqAddressBook
{
    public class Program
    {
        public static void Main(string[]args)
        {
            List<AddressBookInformation> list = new List<AddressBookInformation>();
            Console.WriteLine("AddressBook Information");
            Console.WriteLine("1.RetriveAllInfoFromAddressBook\n2.Retrive based on city\n3.updating the data\n4.deleting data using city name\n5.Count by AddressBook or state\n" +
                "6.count by city\n7.sort list alphabetically");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    AddingDataToAddressBook(list);
                    Console.WriteLine("data addes sussesFully");
                    break;
                case 2:
                    Console.WriteLine("before retriving data according to city or state");
                    AddingDataToAddressBook(list);
                    Console.WriteLine("after retriving data according to city or state");
                    AddressBookRepo.RetriveBasedOnCity(list);
                    break;
                case 3:
                    Console.WriteLine("Before updating");
                    AddingDataToAddressBook(list);
                    AddressBookRepo.UpdateData(list);
                    Console.WriteLine("Aftre updating");
                    AddingDataToAddressBook(list);
                    break;
                case 4:
                    
                    AddressBookRepo.DeleteData(list);
                    break;
                case 5:
                    AddingDataToAddressBook(list);
                    AddressBookRepo.GetCountByAddressBookType(list);
                    break;
                case 6:
                    AddingDataToAddressBook(list);
                    AddressBookRepo.GetCountByCity(list);
                    break;
                case 7:
                    AddingDataToAddressBook(list);
                    AddressBookRepo.RetriveBysortingAlphabetically(list);
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
                list.Add(new AddressBookInformation() { ID = 7, FirstName = "sheshank", LastName = "YK", Address = "jayanagara", City = "hubli", State = "Karnataka", Zip = "4238", PhoneNumber = "12345", Email = "Thsgva@gmail.com", AddressBookName = "AddressBook1", AddressBookType = "Family" });
                RetriveAllData(list);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}