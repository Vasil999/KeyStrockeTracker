using System;
//Important to handle files
using System.IO;

//Vasil Paskalev
//07.04.2020
//Application, that is tracking the keystrockes, converts them to Text and adds the text as new content to a textfile 
namespace KeyStrockeTracker
{
    //outputtype changed to Windows Application, so that it will be hidden 
    class Program
    {
        static void Main(string[] args)
        {
            string content = File.ReadAllText("Text_entered_by_the_user.txt");
            string newContent = "";

            while (true)
            {
                ConsoleKeyInfo currentKeyStrocke = Console.ReadKey();
                newContent += Convert.ToString(currentKeyStrocke.Key);
                content += newContent;
                File.WriteAllText("Text_entered_by_the_user.txt", newContent);
            }
        }
    }
}
