namespace ResourceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DBConnection db = new DBConnection();
            try
            {
                db.Execute();
            }
            finally {
                db?.Dispose();
            }*/

            /*using (DBConnection db = new DBConnection()) {
                db.Execute();
            } // db.Dispose();*/

            using DBConnection db = new DBConnection();
            db.Execute();




        }
    }
}
