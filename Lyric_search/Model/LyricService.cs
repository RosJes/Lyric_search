using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyric_search.Model
{
    public class LyricService
    {




        List<Lyric> _requests = new List<Lyric> {

        new Lyric{ Artist="Toto",lyric="Africa",VideoUrl="2374M0fQpWi3dLnB54qaLX",date=DateTime.Now}

        };

        List<Lyric> _videos = new List<Lyric> {

        new Lyric{ Artist="Toto",lyric="Africa",VideoUrl="2374M0fQpWi3dLnB54qaLX",date=DateTime.Now},
        new Lyric{ Artist="IRON MAIDEN",lyric="RUN TO THE HILLS",VideoUrl="4Zc7TCHzuNwL0AFBlyLdyr",date=DateTime.Now},
        new Lyric{ Artist="Rammstein",lyric="Deutschland",VideoUrl="2bPGTMB5sFfFYQ2YvSmup0",date=DateTime.Now},
        new Lyric{ Artist="Lady Gaga",lyric="Poker Face",VideoUrl="5R8dQOPq8haW94K7mgERlO",date=DateTime.Now}
        };

        int id = 2;
        public Lyric DisplayRequest()
        {
            return _requests.Last();
        }
        public Lyric[] Latest_Search()
        {
            return _requests.ToArray();
        }
        public void Create_Request(Lyric request)
        {


            _requests.Add(new Lyric
            {
                ID = id,
                Artist = request.Artist.ToUpper(),
                lyric = request.lyric.ToUpper(),
                date = DateTime.Now,
                VideoUrl = _videos.Where(o => o.lyric.ToUpper() == request.lyric.ToUpper() && o.Artist.ToUpper() == request.Artist.ToUpper()).Select(o => o.VideoUrl).FirstOrDefault(),
              


            }) ; 
            id++;
        }
    }
}
