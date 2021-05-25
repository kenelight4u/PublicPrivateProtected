using System;
using System.Collections.Generic;
using System.Text;

namespace PublicPrivateProtected
{
    public class MyPublicFacebookPost
    {
        public static void PublicPost()
        {
            Console.WriteLine($"My First Public Post in Facebook. Everyone can see the Post ");
        }

        protected static void ProtectedPost()
        {
            Console.WriteLine($"My First Protected Post in Facebook. Only my Friends can see the Post ");
        }
    }
}
