### FIAP Pós Tech
#### Especialização em Arquitetura de Sistemas .NET com Azure: Fase III - Disciplina I - Aula 05 - Challenge 6

# 0. Versionamento
| Data          | Versão        | Descrição                                  | Autor             |
| ------------- | ------------- | ----------------------                     | ----------------- |
| 05/09/2023    | 1.0           | Criação do documento                       | André Batemarchi  |

# 1. Considerações Preliminares e Motivação
Monitorar e coletar métricas de desempenho são práticas comuns e necessárias para acompanhar e responder sobre a performance de nossas aplicações.

O desafio proposto tem como objetivo o desenvolvimento de uma aplicação que utiliza o Azure Application Insights para monitorar o desempenho dela.

# 2. Resolvendo o Desafio
Nossa abordagem busca seguir o fluxo abaixo:

1. Configurar o Application Insights usando o Azure Cloud Shell (Bash):

- az group create --name rg-challenge6 --location brazilsouth

- az monitor app-insights component create --app app-insights --resource-group rg-challenge6 --location brazilsouth

2. Criar o projeto .NET.

- dotnet new webapp -n challenge5

- [Projeto criado](../projs/F03D01A05%20-%20App%20Insights/)

3. Adicionar o pacote do Application Insights em nosso projeto.

- dotnet add package Microsoft.ApplicationInsights.AspNetCore

4. Adicionar o middleware do Application Insights.

- Vide configurações do Application Insights em [Program.cs](../projs/F03D01A05%20-%20App%20Insights/challenge6/Program.cs).

- Vide também configurações no [appsettings](../projs/F03D01A05%20-%20App%20Insights/challenge6/appsettings.json) - colocar a Instrumentation Key que pode ser obtida em *Overview*, do recurso para app insights criado na etapa 1.

5. Testar a aplicação e acompanhar as métricas e desempenhos pelo portal, no Application Insights. Dica: testar um excesso de requisições à página principal para acompanhar em Live metrics.

# 3. Conclusões
O Azure possui um mecanismo muito poderoso para monitoramento de aplicacões. Com passos simples, obtemos diversos insights sobre o desempenho de uma aplicação de forma com que possamos agir com correções necessárias. Notamos também que para usar o Application Insights, não precisamos publicar a aplicação e nem criar um recurso de web app no Azure.

# 4. Referência

1. [Application Insights for ASP.NET Core applications](https://learn.microsoft.com/en-us/azure/azure-monitor/app/asp-net-core?tabs=netcorenew%2Cnetcore6)

