// See https://aka.ms/new-console-template for more information

using Assignment01;

Exercise03 instance = new Exercise03();
// instance.FizzBuzz(100);
// instance.GuessMyNumber();
instance.PrintAPyramid();
// instance.BirthDateAnniversary();
// instance.Greetings();
// instance.Counting();


// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//     WriteLine(i);
// }
/* This code will not compile since WriteLine does not have Console. on it but if this were to execute,
 since byte can carry up to 255, after 255 there will be an overflow and will start from 0, ending the final number in 244.
 */