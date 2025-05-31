using System.Configuration;

namespace DAL
{
    public static class DB
    {
        public static CTYXAYDUNGDataContext GetContext()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            return new CTYXAYDUNGDataContext(connStr);
        }
    }
}
