using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_DeBord_Joshua
{
    class Game
    {
        public string title, genre;

        //I don't know how to explain what these do exactly in my own words but i do have it in my head 
        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;


        }




    }
}
