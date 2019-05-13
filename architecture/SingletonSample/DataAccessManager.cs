namespace SingletonSample
{
    class DataAccessManager
    {
        private static DataAccessManager _instance;
        private DataAccessManager()
        {

        }

        public DataAccessManager Create()
        {
            if (_instance == null)
            {
                _instance = new DataAccessManager();
            }
            return _instance;
        }

        public void Save()
        {
            //Durch alles iterieren udn Änderungen speichern
        }
    }
}
