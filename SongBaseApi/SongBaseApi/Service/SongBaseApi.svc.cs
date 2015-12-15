using SongBase.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SongBaseApi" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SongBaseApi.svc or SongBaseApi.svc.cs at the Solution Explorer and start debugging.
    public class SongBaseApi : ISongBaseApi
    {
        public Song GetSong(string idString)
        {
            int songId = 0;
            int.TryParse(idString, out songId);
            return new Song
            {
                SongId = songId,
                Title = string.Format("Sample Song #{0}", songId),
                Year = 1990
            };
        }

        public List<Song> GetSongs()
        {
            List<Song> result = new List<Song>();
            for (int i = 0; i < 10; i++)
            {
                result.Add(new Song
                {
                    SongId = i + 1,
                    Title = string.Format("Sample Song #{0}", i + 1),
                    Year = 1990
                });
            }
            return result;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
