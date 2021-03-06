﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Faker;
using Fare;
using FizzWare.NBuilder;
using IMED.Models;
using IMED.Services;

namespace IMED.Controllers
{
    [Authorize]
    public class ClaimsPaidController : ApiController
    {
        private readonly IClaimsPaidService service;
       
        public ClaimsPaidController(IClaimsPaidService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<PagedResult<ClaimsPaid>> GetPaidClaims([FromUri]PagedRequest<string> request)
        {
            return await service.GetPaidClaims(request);
        }
    }
}