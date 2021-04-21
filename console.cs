using System;


namespace Util
{
    class console
    {
        static public string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
