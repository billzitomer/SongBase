using SongBase.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongBase.Common.Source
{
    public interface ISongBaseSource
    {
        List<Song> GetSongs(IDictionary<string, string> parameters);
        List<Author> GetAuthors(IDictionary<string, string> parameters);
        List<Band> GetBands(IDictionary<string, string> parameters);
        List<Instrument> GetInstruments(IDictionary<string, string> parameters);
        List<Musician> GetMusicians(IDictionary<string, string> parameters);
        List<Person> GetPersons(IDictionary<string, string> parameters);
        List<Lyrics> GetLyrics(IDictionary<string, string> parameters);
    }
}
