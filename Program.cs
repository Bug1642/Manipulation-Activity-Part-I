using System;
namespace ConcatenateExercise {
    public class Student {
        public string getFullName(string firstName, string lastName) {
           string fullName = firstName + lastName;
            return fullName;
        }
    }
 class Program{
    static void Main(string[] args ){
        Student fulls = new Student();
        Console.WriteLine(fulls.getFullName("ali ","veli"));
    }
 }
}