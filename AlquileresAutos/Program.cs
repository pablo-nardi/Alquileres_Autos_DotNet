﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AlquileresAutos.Data;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
//    options.UseSqlServer(builder.Configuration.GetConnectionString("AlquileresAutosModelos") ?? throw new InvalidOperationException("Connection string 'AlquileresAutosModelos' not found.")));

builder.Services.AddDbContext<AlquileresAutosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AlquileresAutosContext") ?? throw new InvalidOperationException("Connection string 'AlquileresAutosContext' not found.")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<AlquileresAutosContext>();
    context.Database.EnsureCreated();
    //DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();