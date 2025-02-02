﻿using Master.Rotas.Dominio.Interface.Servicos;
using Master.Rotas.Dominio.Services;
using Master.Rotas.Infra.Dados;
using Microsoft.Extensions.DependencyInjection;
using Master.Rotas.Dominio.Interface.Repositorios;
using Master.Rotas.Infra.Dados.Repositorios;
using Master.Rotas.Infra.Servicos;


namespace Master.Rotas.Config
{
    public static class InjecaoDepedenciaConfiguracoes
    {
        public static void AddInjecaoDependenciaConfig(this IServiceCollection services)
        {            
            services.AddScoped<IServicoKnight, ServiceKnights>();
            services.AddScoped<IRepositorioKnight,RepositorioKnight>();

            services.AddScoped<IServicoProvedorHttpClient, ServicoProvedorHttpClient>();
        }

    }
}
