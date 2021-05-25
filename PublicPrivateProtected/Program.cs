using System;

namespace PublicPrivateProtected
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPublicFacebookPost.PublicPost();

            MyPrivateFaceBookPost.GetPrivatePost();

            //Have Access both for Public and Protected access modifiers 
            MyProtectedFacebookPost.PublicPost();
            MyProtectedFacebookPost.GetProtectedPost();
        }
    }
}
