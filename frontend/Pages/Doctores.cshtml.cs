using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace frontend.Pages
{
    public class DoctoresModel : PageModel
    {
        private readonly ILogger<DoctoresModel> _logger;
        public Doctores[] Doctcli { get; set; }

        public string ErrorMessage {get;set;}
        
        public DoctoresModel(ILogger<DoctoresModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet([FromServices]DoctorClient client)
        {
            Doctcli = await client.GetDoctcliAsync();
            
            if(Doctcli.Count()==0)
                ErrorMessage="We must be sold out. Try again tomorrow.";
            else
                ErrorMessage = string.Empty;
        }
    }
}