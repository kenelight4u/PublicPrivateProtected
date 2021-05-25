using System;
using System.Collections.Generic;
using System.Text;

namespace PublicPrivateProtected
{
    public class MyPrivateFaceBookPost
    {
        private static void PrivatePost()
        {
            Console.WriteLine($"My First Private Post in Facebook. Only me can see the Post ");
        }

        public static void GetPrivatePost()
        {
            PrivatePost();
        }
    }
}
