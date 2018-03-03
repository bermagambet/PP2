using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class Snake
    {
        List<Point> body;
        string sign;
        ConsoleColor color;


        public int cnt;
        

        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(10, 10));
            sign = "*";
            color = ConsoleColor.Yellow;
            cnt = 0;
        }

        public void Move(int dx, int dy)
        {
            cnt++;


            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i] .y = body[i - 1].y;
                
            }
            body[0].x += dx;
            body[0].y += dy;


            if (body[0].x < 1)
                body[0].x = Console.WindowWidth - 1;
            if (body[0].x > Console.WindowWidth - 1)
                body[0].x = 1;

            if (body[0].y < 1)
                body[0].y = Console.WindowHeight - 1;
            if (body[0].y > Console.WindowHeight - 1)
                body[0].y = 1;
        }


        public void Draw(int direction)
        {

            int index = 0;
            foreach (Point p in body)
            {
                if (index == 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                index++;
            }
            /*
            for ( int i = 0; i < body.Count; i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);
                if (direction == 1)
                {
                    Console.SetCursorPosition(body[0].x - 1, body[0].y);
                    Console.Write(' ');

                }
                if (direction == 2)
                {
                    Console.SetCursorPosition(body[0].x + 1, body[0].y);
                    Console.Write(' ');

                }
                if (direction == 3)
                {
                    Console.SetCursorPosition(body[0].x, body[0].y - 1);
                    Console.Write(' ');

                 if (direction == 4)
                    {
                        Console.SetCursorPosition(body[0].x, body[0].y + 1);
                        Console.Write(' ');

                    }
                }
                */
        
            

        }


        public bool CollisionWithWall(Wall w)
        {
            foreach (Point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;
            }
            return false;
        }
        public bool FoodInMe(int a, int b)
        {
            for ( int i = 1; i < body.Count; i++)
            {
                if ( a == body[i].x && b == body[i].y )
                {
                    return false;
                }
                
            }
            return true;
        }
        public int Random1(int a, int b)
        {
            Random rnd2 = new Random();
            return rnd2.Next(a, b);
        }
        public int Random2(int a, int b)
        {
            Random rnd1 = new Random();
            return rnd1.Next(a, b);
        }
        public void DrawFood(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(a, b);
            Console.Write("z");
        }
        public bool CollisionWithFood(int a, int b)
        {
            if (a == body[0].x && b == body[0].y)
            {
                body.Add(new Point(0, 0));
                return true;
            }
            else
                return false;
        }
 
        public bool Collision()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            }
            return false;
        }


    }
}