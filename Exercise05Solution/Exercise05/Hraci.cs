﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Hraci
    {
        int pocet;
        Hrac[] poleHracu;


        public void vymaz(int index)
        {
            for (int i = index; i < pocet; i++)
            {
                poleHracu[i] = poleHracu[i + 1];
            }
            poleHracu[pocet] = null;
            pocet--;
        }

        public void pridej(Hrac hrac)
        {
            poleHracu[pocet] = hrac;
            pocet++;
        }

        //indexer

        /*
        public void najdiNejlepsiKluby(kluby, golPocet)
        {

        }
        */
    }
}
