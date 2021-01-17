using System;
using System.Collections.Generic;
using System.Text;

namespace TransferProject
{
    class Transferred
    {

        public void TransferCompleted(Players players, Clubs clubs)
        {
            Console.WriteLine("----------Son Dakika-----------");

            Console.WriteLine("Oyuncu Adı : " + players.PlayerName);

            Console.WriteLine("Transfer olduğu kulüp : " + clubs.ClubName);

            Console.WriteLine("Transfer edildiği kulüp : " + players.PlayerClub);

            Console.WriteLine("Transfer için ödenen ücret : " + players.PlayerPrice + " milyon euro ");

            Console.WriteLine("Oyuncunun yıllık ücreti : " + players.PlayerWage + " milyon euro ");

            Console.WriteLine("-------------------------------");

        }
    }
}
