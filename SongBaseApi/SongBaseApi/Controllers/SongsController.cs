using SongBaseApi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SongBaseApi2.Controllers
{
    public class SongsController : ApiController
    {
        Song[] songs = new Song[]
         {
            new Song { Id = 1, Title = "Happy Birthday" },
            new Song { Id = 2, Title = "Imagine" },
            new Song { Id = 3, Title = "Hey Joe" }
         };

        public IEnumerable<Song> GetAllSongs()
        {
            return songs;
        }

        public IHttpActionResult GetSong(int id)
        {
            var song = songs.FirstOrDefault((p) => p.Id == id);
            if (song == null)
            {
                return NotFound();
            }
            return Ok(song);
        }
    }
}

