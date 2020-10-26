using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UTMusic.BusinessLogic.DataTransfer;

namespace UTMusic_TIDPP.Models
{
    public class SongListModel
    {
        public IEnumerable<SongDTO> AllSongs { get; set; }
    }
}