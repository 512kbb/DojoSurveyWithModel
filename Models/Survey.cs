using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DojoSurveyWithModel.Models
{
    public class Survey
    {
        public string Name {get; set;}
        public string DojoLocation {get; set;}
        public string FavoriteLanguage {get; set;}
        public string? Comment {get; set;}

    }
}