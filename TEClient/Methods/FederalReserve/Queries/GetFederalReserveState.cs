﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TEClient.Attributes;
using TEClient.Interfaces;

namespace TEClient.Methods.FederalReserve.Models;

[ApiEndpoint("/fred/states")]
internal class GetFederalReserveState : FederalReserveResponse, IGet
{ }
