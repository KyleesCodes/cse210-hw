using System;

class Program
{
    static void Main(string[] args)
   {
        Reference ref1 = new Reference("John",3,16);
        Scripture scrip1 = new Scripture(ref1, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        string line = "enter";
        Reference ref2 = new Reference("Proverbs", 3,5,6);
        Scripture scrip2 = new Scripture(ref2,"Trust in the LORD with all your heart and lean not on your own understanding;in all your ways submit to him, and he will make your paths straight");
        Reference ref3 = new Reference("Revelation", 5,13);
        Scripture scrip3 = new Scripture(ref3, "And every creature which is in heaven, and on the earth, and under the earth, and such as are in the sea, and all that are in them, heard I saying, Blessing, and honour, and glory, and power, be unto him that sitteth upon the throne, and unto the Lambe for ever and.");

        List<Scripture> scripList = new List<Scripture>();

        scripList.Add(scrip1);
        scripList.Add(scrip2);
        scripList.Add(scrip3);

        Random sort = new Random();
        int num = sort.Next(0,scripList.Count());

        Scripture scripchosen = new Scripture(scripList[num].GetReference(), scripList[num].GetReference().GetDisplayText());
        scripchosen = scripList[num];

        bool hidden = scripchosen.IsCompletelyHidden();
      
        while ((line != "quit"))
        {
            Console.Clear();
            string reference = scripchosen.GetReference().GetDisplayText();
            string text = scripchosen.GetDisplayText();

            Console.WriteLine($"{reference} - {text}");
        
            Console.WriteLine("Please enter to continue or quit to exit: ");
            line = Console.ReadLine();

            if ((line == "quit") || (hidden == true))
            {
                
                Console.WriteLine("Game Over!");
                line = "quit";

            } else 
            {
                scripchosen.HideRandomWords();
                hidden = scripchosen.IsCompletelyHidden();
            }
        }
    }
}