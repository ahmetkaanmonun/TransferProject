using System;

namespace TransferProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Clubs club1 = new Clubs();

            club1.ClubName = "Galatasaray";
            club1.ClubCoach = "Fatih Terim";
            club1.ClubCountry = "Turkey";

            Clubs club2 = new Clubs();

            club2.ClubName = "Fenerbahçe";
            club2.ClubCoach = "Erol Bulut";
            club2.ClubCountry = "Turkey";

            Players player1 = new Players();

            player1.PlayerName = "İrfan Can Kahveci";
            player1.PlayerPrice = 14000000;
            player1.PlayerClub = "Medipol Başakşehir";
            player1.PlayerWage = 1500000;

            Players player2 = new Players();

            player2.PlayerName = "Mesut Özil";
            player2.PlayerPrice = 2000000;
            player2.PlayerClub = "Arsenal";
            player2.PlayerWage = 5000000;


            Clubs[] clubs = new Clubs[] { club1, club2 };
            Players[] players = new Players[] { player1, player2 };

            foreach (Clubs club in clubs)
            {
                Console.WriteLine("Kulüp adı : " + club.ClubName);
                Console.WriteLine("Kulüp teknik direktörü : " + club.ClubCoach);
                Console.WriteLine("Kulübün bulunduğu ülke : " + club.ClubCountry);
                Console.WriteLine("-------------------------------");
            }
            foreach (Players player in players)
            {

                Console.WriteLine("Oyuncu adı : " + player.PlayerName);
                Console.WriteLine("Oyuncunun bonservis bedeli : " + player.PlayerPrice + " milyon euro");
                Console.WriteLine("Oyuncunun kulübü : " + player.PlayerClub);
                Console.WriteLine("-------------------------------");
            }


            Transferred transfer = new Transferred();

            transfer.TransferCompleted(player1, club1);
            transfer.TransferCompleted(player2, club2);
        }
    }
}
