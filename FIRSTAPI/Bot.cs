using System.IO;
using System.Net;
using System;
using System.Text;


string urlString = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}"; //Эта ссылка едина для всех ботов. Её менять не нужно.
Console.Write("Введите Токен Бота: ");//В файле README написано откуда его взять и как он выглядит
string apiToken = Console.ReadLine();
Console.Write("Введите ID Получателя: ");//В файле README написано откуда его взять
string chatId = Console.ReadLine();
Console.Write("Введите текст: ");
string text = Console.ReadLine();
urlString = String.Format(urlString, apiToken, chatId, text);
WebRequest request = WebRequest.Create(urlString);
Stream rs = request.GetResponse().GetResponseStream();
StreamReader reader = new StreamReader(rs);
string line = "";
StringBuilder sb = new StringBuilder();
while (line != null)
{
    line = reader.ReadLine();
    if (line != null)
        sb.Append(line);
}
string response = sb.ToString();
