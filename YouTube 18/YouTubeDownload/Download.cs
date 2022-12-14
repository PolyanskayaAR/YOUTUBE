using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeDownload.Commands
{
    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class Download : Command
    {
        Video video;


        public Download(Video video)
        {
            this.video = video;
            Console.WriteLine("Создана команда по скачиванию видео по адресу {0}", video.Url);
        }

        // Выполнить
        public override async void Run()
        {
            video.Download();
        }

        // Отменить
        public override void Cancel()
        {
            Console.WriteLine("Отмена этой команды не реализована");
        }
    }
}
