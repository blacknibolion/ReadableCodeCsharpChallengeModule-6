/*
string firstName = "Abdulmushin";
int amountOfFoodAte = 5;
//Testing a change to the message.
//int typesOfFood = 5;
//Console.WriteLine($"{firstName} ate {typesOfFood} types of food today!");
Console.WriteLine($"{firstName} ate {amountOfFoodAte} types of food only today!");
*/
/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/*Random random = new Random();
string [] orderIDs = new string[5];

for(int i = 0; i < orderIDs.Length; i++){

    int prefixValue = random.Next(65, 70);

    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}*/

//The high-level purpose of this code is to reverse a string 
//and count the number of times a particular character appears.
//string message = "The quick brown fox jumps over the lazy dog.";

/*
char[] newMessage = message.ToCharArray();

Array.Reverse(newMessage);
int countLetter = 0;

foreach (char character in newMessage){
  if( character == 'o'){
    countLetter ++;
    }
  

}
// convert back to string
  string updatedMessage = new string(newMessage);
  //print it out
  Console.WriteLine(updatedMessage);
  Console.WriteLine($"'o' appears {countLetter} times");
  */

bool flag = true;
int value = 0;
if(flag){
  
  Console.WriteLine($"Inside value in the block is: {value}");
}
value = 10;
Console.WriteLine($"Outside value in the block is: {value}");