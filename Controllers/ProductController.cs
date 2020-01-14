using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using net_core_bootcamp_b1.DTOs;
using net_core_bootcamp_b1.Services;
using System;
using System.Collections.Generic;

namespace net_core_bootcamp_b1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]
    public class ProductController
    {
        private readonly IProductService _productService;

        public ProducController(IProductService productService)
            

    }
}
