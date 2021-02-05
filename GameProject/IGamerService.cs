using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Manager class ların interface lerini Service diye yazıyoruz. Manager olarak da yazılabilinir.
    interface IGamerService
    {
        //Daha gelişmiş sistemlerde Gamer class ını User olarak yazabiliriz.
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
