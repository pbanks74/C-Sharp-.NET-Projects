﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck  Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);

            //logs every card that is dealt...**true means to append text in the file
            using (StreamWriter file = new StreamWriter(@"C:\Basic_C#_Programs\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now); //adds timestamp
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
