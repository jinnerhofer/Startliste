using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using System.Linq;

namespace Startliste
{
    public class SqlDaten : Starter
    {
        private string Filename { get; set; } = "Startliste.db";
        private string Dir { get; set; } = Directory.GetCurrentDirectory();

        private string StartlisteFilePath { get; set; }

        private SQLiteConnection Conn { get; set; }
       
        public SqlDaten()
        {
            this.StartlisteFilePath = Path.Combine(this.Dir, this.Filename);

            var options = new SQLiteConnectionString(this.StartlisteFilePath, true);
            this.Conn = new SQLiteConnection(options);

            this.Conn.CreateTable<Starter>();
        }

        public List<IStarter> All()
        {
            // get all passwords
            var starter = from s in this.Conn.Table<Starter>()
                            select new Starter()
                            {
                                Startnummer = s.Startnummer,
                                Vorname = s.Vorname,
                                Nachname = s.Nachname,
                                Geschlecht = s.Geschlecht,
                                Nation = s.Nation
                            };
            return starter.ToList<IStarter>();
        }

        public bool Add(IStarter starter)
        {
            var count = this.Conn.Insert(starter);
            return count > 0;
        }

        public bool Delete(IStarter starter)
        {
            var item = from st in this.Conn.Table<Starter>()
                       where st.Startnummer == starter.Startnummer
                       select st;
            var count = this.Conn.Delete(item);
            return count > 0;
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }

}

