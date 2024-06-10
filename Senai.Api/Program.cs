using AutoMapper;
using Senai.Domain.Interfaces;
using Senai.Repository.Context;
using Senai.Repository.Repositories;
using Senai.Repository.Repository;
using Senai.Service.Interfaces;
using Senai.Service.Services;

namespace Senai.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<SenaiContext>();

            #region Injeção Services

            builder.Services.AddScoped<IEscolaService, EscolaService>();
            builder.Services.AddScoped<IProfessorService, ProfessorService>();
            builder.Services.AddScoped<IAlunoService, AlunoService>();
            builder.Services.AddScoped<IClasseService, ClasseService>();

            #endregion

            builder.Services.AddScoped<IEscolaRepository, EscolaRepository>();
            builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
            builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
            builder.Services.AddScoped<IClasseRepository, ClasseRepository>();


            MapperConfiguration mapperConfiguration = new MapperConfiguration(mapperConfiguration =>
            {
                mapperConfiguration.AddMaps(new[] { "Senai.Service" });

            });
            builder.Services.AddSingleton(mapperConfiguration.CreateMapper());

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseSwagger();
            app.UseSwaggerUI(
                c => {

                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Senai v1");
             }) ;

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

    }
}
