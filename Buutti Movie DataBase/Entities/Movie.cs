using System;
using System.Collections.Generic;
using System.Text;

namespace Buutti_Movie_DataBase.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Length { get; set; }
        public string MoviePosterUrl { get; set; }
    }
}
