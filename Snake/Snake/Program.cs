using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Snake
{
    class Program
    {
        static public int direction = 1;
        static public int level = 1;
      
        static public Snake snake = new Snake();
        static public Wall wall = new Wall(level);
        
        static void game(object all1)
        {
           int a = 0, b = 40, c = 18, da = 1, lll = 3;
           int g = snake.Random1(a, b);
           int g1 = snake.Random2(a, c);
            while (true )
            {
                if (direction == 3)
                {
                    snake.Move(0, -1);
         
                }
                if (direction == 1)
                {
                    snake.Move(-1, 0);
                   
                    
                }
                if (direction == 2)
                {
                    snake.Move(1, 0);
                   
                }
                if (direction == 4)
                {
                    snake.Move(0, 1);
                    
                }
            
                if (snake.CollisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("GAME OVER!!!!");
                    Console.ReadKey();
                    snake = new Snake();
                    level = 1;
                    wall = new Wall(level);
                }
                 Console.Clear();
                if (da % lll == 0)
                {
                    lll *= 2;
                    level++;
                    wall = new Wall(level);
                }

                if (snake.CollisionWithFood(g, g1))
                {
                    da++;
                    g = snake.Random1(a, b);
                    g1 = snake.Random2(a, c);
                   
                }
                if (wall.FoodInWall(g, g1) == true && snake.FoodInMe(g, g1) == true )
                {
                    snake.DrawFood(g, g1);

                }
                else
                {




                    g = snake.Random1(a, b);
                    g1 = snake.Random2(a, c);
                    snake.DrawFood(g, g1);
                }
                
                snake.Draw(direction);
                wall.Draw();
                    
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(game);
            Thread thread1 = new Thread(game);
            thread.Start(direction);

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    direction = 4;
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = 3;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = 1;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = 2;
                if (keyInfo.Key == ConsoleKey.R)
                {
                    
                    level = 1;
                    snake = new Snake();
                    wall = new Wall(level);
                }
               /* if (keyInfo.Key == ConsoleKey.Enter)
                {

                    FileStream fs = new FileStream(@"snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    
                    
                    fs.Close();
                }
                if (keyInfo.Key == ConsoleKey.Backspace)
                {

                    FileStream fs = new FileStream(@"snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                    snake1 = (Snake)xs.Deserialize(fs);

                    fs.Close();
                    thread.Abort();
                    thread1.Start(direction);
                }
                */


            }
            
        }
    }
}
