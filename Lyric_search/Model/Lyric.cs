using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyric_search.Model
{
    public class Lyric
    {
        public int ID { get; set; }
        public string Artist { get; set; }
        public string lyric { get; set; }
        public DateTime date{ get; set; }
        public string VideoUrl{ get; set; }
    }
}
