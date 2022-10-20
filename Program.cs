using UserRegistrationProgram;

Console.WriteLine("Please Enter Name");
string pattern = Console.ReadLine();
FirstName obj = new FirstName();
bool val = obj.ValidateFirstName(pattern);
if (val)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
Console.WriteLine("---------------");



Console.WriteLine("Please Enter Name");
string pattern1 = Console.ReadLine();
LastName obj1 = new LastName();
bool val1 = obj1.ValidateLastName(pattern1);
if (val1)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
Console.WriteLine("---------------");


Console.WriteLine("Please Enter Email");
string pattern2 = Console.ReadLine();
ValidE_Mail obj2 = new ValidE_Mail();
bool val2 = obj2.ValidateEmail(pattern2);
if (val2)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
Console.WriteLine("---------------");


Console.WriteLine("Please Enter Phone Number");
string patterns3 = Console.ReadLine();
MobilFormat obj3 = new MobilFormat();
bool val3 = obj3.ValidPhoneNumber(patterns3);
if (val3)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
Console.WriteLine("-----------------");


Console.WriteLine("Please Enter Password");
string pass1 = Console.ReadLine();
Pre_DefinedPassword predefined = new Pre_DefinedPassword();
bool val4 = predefined.ValidPassword(pass1);
if (val4)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
Console.WriteLine("-------------");


Console.WriteLine("Please Enter Password");
string pass2 = Console.ReadLine();
UpperCase upperCase = new UpperCase();
bool val5 = upperCase.ValidPassword(pass2);
if (val5)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
Console.WriteLine("------------------");


Console.WriteLine("Please Enter Password");
string numpass = Console.ReadLine();
NumberPassword numberPass = new NumberPassword();
bool val6 = numberPass.ValidPassword(numpass);
if (val6)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
Console.WriteLine("----------------");



Console.WriteLine("Please Enter Password E.g- Shree23@Nil06");
string pattrn7 = Console.ReadLine();
SpecialCharacter password3 = new SpecialCharacter();
bool val7 = password3.ValidatePassword(pattrn7);
if (val7)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
Console.WriteLine("----------------");



Console.WriteLine("Please Enter Password ");
string pattrn8 = Console.ReadLine();
EmailSample password9 = new EmailSample();
bool val8 = password9.ValidateEmailAdd(pattrn8);
if (val8)
    Console.WriteLine("Pattern Matched");
else
    Console.WriteLine("Pattern Not Matched");
Console.WriteLine("--------------");



