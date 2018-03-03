using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    [Serializable]
    class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;
        public int c = 0, c1 = 20;

        public void ReadLevel(int level)
        {
            StreamReader sr = new StreamReader(@"C:\level" + level + ".txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                    string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                    {
                        body.Add(new Point(j, i));
                    }
                    
                }

                
                
            }
            sr.Close();
        }
        public bool FoodInWall(int a, int b )
        {
            bool fiw = true;
               for ( int i = 0; i < body.Count; i++ )
            {
                    if ( a == body[i].x && b == body[i].y)
                {
                    fiw = false;
                }
             
            }
            if ( fiw == true )
            {
                return true;
            }
            return false;
        }
        public void ReadBoarder()
        {
            StreamReader sr = new StreamReader(@"C:\boarder.txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                    {
                        body.Add(new Point(j, i));
                    }

                }



            }
            sr.Close();
        }
        public Wall(int level)
        {
            body = new List<Point>();
            sign = "o";
            color = ConsoleColor.Magenta;
            ReadLevel(level);
            ReadBoarder();




        }

 

    public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }


        }
    }
}