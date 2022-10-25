using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TEClient.Attributes;
using TEClient.Interfaces;
using TEClient.Methods.FederalReserve;

namespace TEClient.Methods.Earnings.Queries;

[ApiEndpoint("/earnings")]
internal class GetEarnings : EarningsResponse, IGet, IGetWithQuery
{

}
