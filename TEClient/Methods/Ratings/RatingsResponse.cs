using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEClient.Methods.Ratings;

public class RatingsResponse
{
    public string Country { get; set; }
    public string TE { get; set; }
    public string TE_Outlook { get; set; }
    public string SP { get; set; }
    public string SP_Outlook { get; set; }
    public string Moodys { get; set; }
    public string Moodys_Outlook { get; set; }
    public string Fitch { get; set; }
    public string Fitch_Outlook { get; set; }
    public string DBRS { get; set; }
    public string DBRS_Outlook { get; set; }
    
}
