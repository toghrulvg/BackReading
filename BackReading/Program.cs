using System;

    namespace homework
    {
        class Program
        {
            static void Main(String[] args)
            {
            BackReading("Togrul");
            BackReading("ey melek kelem ye");
            }
            
            static void BackReading(string text)
            {
                string backReading = string.Empty;
                
                for (int i=text.Length - 1; i>= 0; i--)
                {
                    backReading += text[i];
                }
            Console.WriteLine($"BackReading text is : {backReading} ");
            }   
        }

            
    }
        