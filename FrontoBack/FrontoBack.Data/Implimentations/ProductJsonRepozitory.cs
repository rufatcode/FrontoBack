﻿using System;
using FrontoBack.Core.Interfaces;
using FrontoBack.DAL;
using FrontoBack.Models;

namespace FrontoBack.Data.Implimentations
{
	public class ProductJsonRepozitory:Repozitory<ProductJson>, IProductJsonRepozitory
    {
		public ProductJsonRepozitory(AppDbContext context) : base(context)
        {
		}
	}
}

