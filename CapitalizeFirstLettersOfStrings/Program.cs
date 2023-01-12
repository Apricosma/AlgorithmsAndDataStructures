using System.Globalization;

string str1 = "lorem ipsum et es delorum regum";

TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

// the ToTitleCase() method returns a a new string based on the string
// passed into it and will capitalize every first letter, and lowercase other letters.
Console.WriteLine("\"{0}\" to titlecase: {1}", str1, textInfo.ToTitleCase(str1));