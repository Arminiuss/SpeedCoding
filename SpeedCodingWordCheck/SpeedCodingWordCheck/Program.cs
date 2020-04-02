using System;

namespace SpeedCodingWordCheck
{
    class Program
    {
        static string m_userInput;
        static char[] m_userInputArray;
        static char[] m_safeChar;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Word!");
            m_userInput = Console.ReadLine();
            m_userInputArray = m_userInput.ToCharArray();
            if (m_userInput != null)
            {
                m_safeChar = m_userInputArray;
                for (int i = 0; i < m_userInputArray.Length; i++)
                {
                    foreach (char m_safeChar in m_userInputArray)
                    {

                        if (m_safeChar != m_userInputArray[i])
                        {
                            Console.WriteLine("Doppelter Buchstabe ist" + m_safeChar);
                        }
                    }

                }
            }

            Console.ReadLine();
        }
    }
}