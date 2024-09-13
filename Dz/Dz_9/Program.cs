using System;
using static System.Net.WebRequestMethods;

namespace Dz_9;
internal class Program
{
    public static async Task Main(string[] args)
    {
        Base @base = new Base();
        Downloader downloader = new Downloader();
        string url = "https://www.mozilla.org/ru/firefox/?utm_medium=firefox-desktop&utm_source=bookmarks-toolbar&utm_campaign=new-users&utm_content=-global";
        string filePath = "C:/Users/user/Desktop/test.txt";
        await downloader.DownloadDataAsync(url, filePath);//Не стал конструктор делать так как в задании написано использовать метод в мейн
    }
}
