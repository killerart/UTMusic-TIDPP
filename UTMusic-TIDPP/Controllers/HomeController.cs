using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UTMusic.BusinessLogic.DataTransfer;
using UTMusic.BusinessLogic.Interfaces;
using UTMusic_TIDPP.Models;

namespace UTMusic_TIDPP.Controllers
{
    public class HomeController : Controller
    {
        private IMusicApi MusicService { get; }
        public HomeController(IMusicApi musicService) {
            MusicService = musicService;
        }
        /// <summary>
        /// Действие главной страницы
        /// </summary>
        /// <returns>Главная страница</returns>
        [HttpGet]
        public ActionResult Index() {
            var model = new SongListModel {
                AllSongs = MusicService.GetSongs()
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult SearchSong(string searchValue) {
            var model = new SongListModel {
                AllSongs = MusicService.SearchSongs(searchValue)
            };
            return PartialView("SongList", model);
        }
        /// <summary>
        /// Загрузка песни на сайт
        /// </summary>
        /// <param name="file">Файл с песней в формате .mp3</param>
        /// <returns>Главная страница</returns>
        [HttpPost]
        public ActionResult UploadSong(HttpPostedFileBase file) {
            var result = MusicService.SaveSongToDisk(file, Server.MapPath("~/Music"), out SongDTO songDTO);
            if (result.Succeeded) {
                MusicService.AddSong(songDTO);
            }
            var model = new SongListModel {
                AllSongs = MusicService.GetSongs()
            };
            return PartialView("SongList", model);
        }
    }
}