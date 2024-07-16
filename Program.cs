
    string Validation(string phoneNumber)
    {
        //check if phone number starts with +234
        if(!phoneNumber.StartsWith("+234"))
        {  
            return "start number with +234"; 
        }
        // check if lenght after +234 is 10 digits
        string digitNumber = phoneNumber.Substring(4);
        if (digitNumber.Length != 10)
        {
            return "your number must be a 10 digits" ;
        }
        //ensure all character after +234 are digits
        foreach(char number in digitNumber) 
        {
        if(!char.IsDigit(number))
            {
                return "enter digits";
            }
        }
        return "valid number";
    }
Console.WriteLine("enter phone number");
var phoneNumber = Console.ReadLine();

Console.WriteLine(Validation(phoneNumber));







//bool Validation(string phoneNumber)
//{
//    //check if phone number starts with +234
//    if (!phoneNumber.StartsWith("+234"))
//    {
//        return false;
//    }
//    // check if lenght after +234 is 10 digits
//    string digitNumber = phoneNumber.Substring(4);
//    if (digitNumber.Length != 10)
//    {
//        return false;
//    }
//    //ensure all character after +234 are digits
//    foreach (char number in digitNumber)
//    {
//        if (!char.IsDigit(number))
//        {
//            return false;
//        }
//    }
//    return true;
//}
