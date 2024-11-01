using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialmedia
{
    internal class Program
    {
        public interface ILike
        {
            void Display();
        }
        public interface IComment
        {
            void Comment();
            void Print();
        }
        public interface IFollow
        {
            void Follow();
        }

        public class Like : ILike
        {
            public void Display()
            {
                Console.WriteLine($"User liked your post.");
            }
        }

        public class Comment : IComment
        {
            public void Comment()
            {
                Console.WriteLine($"User commented on your post.");
            }
            public void Print()
            {
                Console.WriteLine($"The comment is {comment}");
            }
        static void Main(string[] args)
        {
        }
    }
}
