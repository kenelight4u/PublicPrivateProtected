namespace PublicPrivateProtected
{
    public class MyProtectedFacebookPost : MyPublicFacebookPost
    {
        public static void GetProtectedPost()
        {
           ProtectedPost();
        }
    }
}
