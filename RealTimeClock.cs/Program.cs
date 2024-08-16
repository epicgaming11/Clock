using System.Text;

namespace RealTimeClock.cs
{
    public class Program
    {

        public static void Main(string[] args)
        {
            
            while(true) 
            {
                //Set CursorPosition so it updates same place, so it dont blink since i use System.Threading.Thread.Sleep(1000);.
                Console.SetCursorPosition(0, 0);
                //DateTime.Now is renamed as a variable "Time".
                //I only want to display the time so i made it "ToLongTimeString" so the date is not displayed.
                DateTime Time = DateTime.Now;
                string formattedTime = Time.ToLongTimeString();
                string fTime = Time.ToString("HH:mm:ss");
               // Console.Write(formattedTime);

                System.Threading.Thread.Sleep(1000);//Updates program every second.
                
                Int32 TimeLength = formattedTime.Length;
                char[] chars = formattedTime.ToCharArray();

                for (int i = 0; i < TimeLength; i++)
                {
                    //Console.Write(chars[i]);
                    DrawNumbers(chars[i], 5 + (i * 10), 5);
                }

            }

        }
        public static void vandretStreg(int x, int y, bool onOff, int Length)
        {
            if (onOff)
            {
                for (int i = 0; i < Length; i++)
                {
                    Console.SetCursorPosition(x + i, y);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('█');

                }

            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    Console.SetCursorPosition(x + i, y);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write('█');
                }
            }
        }
        public static void LodretStreg(int y, int x, bool onOff, int Height)
        {
            if (onOff)
            {
                for (int i = 0; i < Height; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write('█');

                }

            }
            else
            {
                for (int i = 0; i < Height; i++)
                {
                    Console.SetCursorPosition(x,y + i);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write('█');
                }
            }
        }
        public static void DrawNumbers(char time, int x, int y)
        {
            switch(time)
            {
                case '0':
                    vandretStreg(x, y, true, 5);
                    LodretStreg(x+6, y+1, true, 5);
                    LodretStreg(x-2, y+1, true, 5);
                    vandretStreg(x, y+5, false, 5);
                    LodretStreg(x-2, y+6, true, 5);
                    LodretStreg(x+6, y+6, true, 5);
                    vandretStreg(x, y+10, true, 5);
                    break;

                case '1':
                    vandretStreg(x, y, false, 5);
                    LodretStreg(x+6, y+1, false, 5);
                    LodretStreg(x-2, y+1, true, 5);
                    vandretStreg(x, y+5, false, 5);
                    LodretStreg(x-2, y+6, false, 5);
                    LodretStreg(x+6, y+6, true, 5);
                    vandretStreg(x, y+10, false, 5);
                    break;

                case '2':
                    vandretStreg(x,y, true, 5);
                    LodretStreg(x+6,y+1, false, 5);
                    LodretStreg(x-2,y+1, true, 5);
                    vandretStreg(x,y+5, true, 5);
                    LodretStreg(x-2,y+6, true, 5);
                    LodretStreg(x+6,y+6, false, 5);
                    vandretStreg(x,y+10, true, 5);
                    break;

                case '3':
                    vandretStreg(x,y, true, 5);
                    LodretStreg(x+6,y+1, false, 5);
                    LodretStreg(x-2,y+1, true, 5);
                    vandretStreg(x,y+5, true, 5);
                    LodretStreg(x-2,y+6, false, 5);
                    LodretStreg(x+6,y+6, true, 5);
                    vandretStreg(x,y+10, true, 5);
                    break;

                case '4':
                    vandretStreg(x, y, false, 5);
                    LodretStreg(x+6,y+1, true, 5);
                    LodretStreg(x-2,y+1, true, 5);
                    vandretStreg(x,y+5, true, 5);
                    LodretStreg(x-2,y+6, false, 5);
                    LodretStreg(x+6,y+6, true, 5);
                    vandretStreg(x,y+10, false, 5);
                    break;

                case '5':
                    vandretStreg(x,y, true, 5);
                    LodretStreg(x+6,y+1, true, 5);
                    LodretStreg(x-2,y+1, false, 5);
                    vandretStreg(x,y+5, true, 5);
                    LodretStreg(x-2,y+6, false, 5);
                    LodretStreg(x+6,y+6, true, 5);
                    vandretStreg(x,y+10, true, 5);
                    break;

                case '6':
                    vandretStreg(x,y, true, 5);
                    LodretStreg(x+6,y+1, true, 5);
                    LodretStreg(x-2,y+1, false, 5);
                    vandretStreg(x,y+5, true, 5);
                    LodretStreg(x-2,y+6, true, 5);
                    LodretStreg(x+6,y+6, true, 5);
                    vandretStreg(x,y+10, true, 5);
                    break;

                case '7':
                    vandretStreg(x, y, true, 5);
                    LodretStreg(x+6,y+1, false, 5);
                    LodretStreg(x-2,y+1, true, 5);
                    vandretStreg(x,y+5, false, 5);
                    LodretStreg(x-2,y+6, false, 5);
                    LodretStreg(x+6,y+6, true, 5);
                    vandretStreg(x,y+10, false, 5);
                    break;

                case '8':
                    vandretStreg(x, y, true, 5);
                    LodretStreg(x+6, y+1, true, 5);
                    LodretStreg(x-2, y+1, true, 5);
                    vandretStreg(x, y+5,true, 5);
                    LodretStreg(x-2,y+6, true, 5);
                    LodretStreg(x+6,y+6, true, 5);
                    vandretStreg(x, y+10, true, 5);
                    break;

                case '9':
                    vandretStreg(x, y, true, 5);
                    LodretStreg(x+6,y+1, true, 5);
                    LodretStreg(x-2, y+1, true, 5);
                    vandretStreg(x, y+5, true, 5);
                    LodretStreg(x-2, y+6, false, 5);
                    LodretStreg(x+6, y+6, true, 5);
                    vandretStreg(x, y+10, true, 5);
                    break;
            }   
        }
    }
}
