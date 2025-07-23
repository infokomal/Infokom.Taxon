using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using AutoMapper;
using FluentValidation;
using Infokom.Taxon.App;
using Infokom.Taxon.App.Mappers;
using Infokom.Taxon.Data;
using Microsoft.EntityFrameworkCore;
using Infokom.Taxon.App.Commands.Users.Drivers;

namespace Infokom.Taxon.Apps.Web.WebAdmin
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();

			builder.Services.AddDbContext<TaxonDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
			});

			builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<DriverCreateCommand>());
			builder.Services.AddAutoMapper(cfg => { }, typeof(AutoMapperProfile).Assembly);
			builder.Services.AddValidatorsFromAssemblyContaining<CreateDriverCommandValidator>();

			builder.Services.AddScoped<IDriverService, DriverService>();

			builder.Services.AddBlazorBootstrap();

			builder.Services.AddRazorComponents().AddInteractiveServerComponents();


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error", createScopeForErrors: true);
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();
			app.UseAntiforgery();

			app.MapRazorComponents<App>()
			    .AddInteractiveServerRenderMode();

			app.Run();
		}
	}
}