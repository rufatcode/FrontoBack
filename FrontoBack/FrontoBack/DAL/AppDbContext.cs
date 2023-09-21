﻿using System;
using FrontoBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontoBack.DAL
{
	public class AppDbContext:DbContext
	{
		public DbSet<Slider> Sliders { get; set; }
		public DbSet<SliderContent> SliderContents { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Catagorie> Catagories { get; set; }
		public DbSet<FlowerExpert> FlowerExperts { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Accordion> Accordions { get; set; }
		public DbSet<NavBar> NavBars { get; set; }
		public AppDbContext(DbContextOptions options):base(options)
		{
		}
	}
}

