using System;
using System.Diagnostics;

namespace FurkanOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            string furkan;
            Console.WriteLine("ip gir: ");//nmap'te taranacak ip için parametre alıyoruz.
            furkan = Console.ReadLine();
            Process process = new Process();//Nmap uygulamasını çalıştırmak için process oluşturuyoruz.
            process.StartInfo.FileName = "nmap.exe";
            process.StartInfo.Arguments = "nmap -T4 -A -v " + furkan; // nmap'te çalıştıralacak komutları buraya yazıyoruz ve değişkene girdiğimiz ip yi burada kullanıyoruz.
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();//process i başlatıp sonuçları ekrana yazdırıyoruz.

        }
    }
}