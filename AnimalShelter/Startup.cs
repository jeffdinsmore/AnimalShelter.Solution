﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AnimalShelter.Models;
using Microsoft.OpenApi.Models; //Use for swagger

namespace AnimalShelter
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<AnimalShelterContext>(opt =>
        opt.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

      //Use for swagger
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Animal Shelter API", Version = "v1" });
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      // app.UseHttpsRedirection();
      app.UseMvc();
      app.UseSwagger(); //Use for swagger
      app.UseSwaggerUI(c => //Use for swagger
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cretaceous Park API V1");
      }); //Use for swagger
    }
  }
}
