using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DojoSurveyWithModel.Views.Home
{
    public class ResultSurvey : PageModel
    {
        private readonly ILogger<ResultSurvey> _logger;

        public ResultSurvey(ILogger<ResultSurvey> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}