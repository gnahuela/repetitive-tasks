using SQLite;
using System;
using System.IO;

namespace RTask.Persistance
{
    public class SQLiteDataService : ILocalDataService
    {
        private SQLiteConnection _database;

        public void Initialize()
        {
            if (_database == null)
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RTaskDatabase.db3");

                _database = new SQLiteConnection(path);
            }
        }
    }
}
