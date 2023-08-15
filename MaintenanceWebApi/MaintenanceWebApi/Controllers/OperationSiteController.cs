﻿using Application.Abstraction.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaintenanceWebApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OperationSiteController : ControllerBase
    {
        private readonly IOperationSiteService _operationSiteService;

        public OperationSiteController(IOperationSiteService operationSiteService)
        {
            _operationSiteService = operationSiteService;
        }

        [HttpGet("All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOperationSites(int? pageSize, int? pageNumber)
        {
            var operationSite = _operationSiteService.GetOperationSitesAsync(pageSize, pageNumber);
            return Ok(operationSite);
        }
    }
}