using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDeckCards
{
    class NewDeckCards
    {
        string face;
        int value;
        string suit;
        bool played;

        public NewDeckCards()
        {
            
        }

        public NewDeckCards(string Face, int Value, string Suit)
        {
            face = Face;
            value = Value;
            suit = Suit;
        }
        public string getFace()
        {
            string getFace = face;
            return face;
        }
        public void SetFace(string Face)
        {
            face = Face;
        }
        public void SetVal(int Val)
        {
            value = Val;
        }
        public void printInfo()
        {
            if (value == 11 || value == 24  || value == 37 || value == 50)
                Console.WriteLine("face:{0}  {1}  {2}", face, "Jack" , suit);
            else if (value == 12 || value == 25 || value == 38 || value == 51)
                Console.WriteLine("face:{0} {1} {2}", face, "Queen", suit);
            else if (value == 13 || value == 26 || value == 39 || value == 52)
                Console.WriteLine("face:{0} {1}  {2}", face, "King", suit);
            else if (value == 1 || value == 14 || value == 27 || value == 40)
                Console.WriteLine("face:{0}  {1} {2}", face, "Ace", suit);
            else 
            Console.WriteLine("face:{0}  {1}", face, suit);
        }

    }

    

}
