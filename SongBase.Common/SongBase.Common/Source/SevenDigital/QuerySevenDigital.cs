using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongBase.Common.Model;

namespace SongBase.Common.Source.SevenDigital
{
    public class QuerySevenDigital : ISongBaseSource
    {
        #region ISongBaseSource

        public List<Author> GetAuthors(IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }

        public List<Band> GetBands(IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }

        public List<Instrument> GetInstruments(IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }

        public List<Lyrics> GetLyrics(IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }

        public List<Musician> GetMusicians(IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPersons(IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }

        public List<Song> GetSongs(IDictionary<string, string> parameters)
        {
            throw new NotImplementedException();
        }

        #endregion

        private async Task<Response> SendRequest(string uri, IDictionary<string,string> Parameters)
        {

        }
    }
}
