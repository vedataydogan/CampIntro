﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKredisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı");
        }
    }
}
