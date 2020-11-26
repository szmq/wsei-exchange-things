using System;
using Microsoft.AspNetCore.Mvc;
using ExchangeThings.Models;
using System.Collections.Generic;
using Wsei.ExchangeThings.Web.Database;
using Wsei.ExchangeThings.Web.Entities;
using ExchangeThings.Models;

namespace ExchangeThings.Controllers
{
    [ApiController]
    [Route("api/company")]
    public class ApiController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;

        public ApiController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Post(CompanyModel company)
        {
            try
            {
                CompanyAddedViewModel response = new CompanyAddedViewModel
                {
                    NumberOfCharsInName = company.Name.Length,
                    NumberOfCharsInDescription = company.Description.Length,
                    IsHidden = !company.IsVisible
                };

                var entity = new ItemEntity
                {
                    Name = company.Name,
                    Description = company.Description,
                    IsVisible = company.IsVisible,
                };

                _dbContext.Items.Add(entity);
                _dbContext.SaveChanges();

                return Ok(response);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }
    }
}
