namespace DataLib
{
    public static class DatabaseSettings
    {
        #region Database properties
        private const string SERVER = "borrowlend222";
        private const string DATABASE = "DOU";
        private const string LOGIN = "roman";
        private const string PASSWORD = "Cap_obviousness1";
        #endregion

        public static string СonnectionString => $@"Data Source={SERVER}.database.windows.net;
                       Initial Catalog={DATABASE};
                       Integrated Security=True; 
                       User ID={LOGIN};
                       Password={PASSWORD}; 
                       Trusted_Connection=False; 
                       Encrypt=True;";
    }
}
