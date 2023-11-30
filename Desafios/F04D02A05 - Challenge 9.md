### FIAP Pós Tech
#### Especialização em Arquitetura de Sistemas .NET com Azure: Fase IV - Disciplina II - Aula 05 - Challenge 9

# 0. Versionamento
| Data          | Versão        | Descrição                                  | Autor             |
| ------------- | ------------- | ----------------------                     | ----------------- |
| 28/11/2023    | 1.0           | Criação do documento                       | André Batemarchi  |
| 30/11/2023    | 1.1           | Escrita do documento                       | André Batemarchi  |

# 1. Considerações Preliminares e Motivação
A mensageria em sistemas distribuídos é fundamental para o seu correto funcionamento. Diversas são as vantagens de se utilizar mensageria: comunicação sem bloqueios, resiliência, flexibilidade, dentre outros. 

O objetivo do challenge 9 é desenvolver um Producer (API) e um Consumer (worker service) que se comunicam por meio do MassTransit e do RabbitMQ.

# 2. Resolvendo o Desafio
Na pasta [F04D02A05 - MassTransit](../projs/F04D02A05%20-%20MassTransit/) você encontra os projetos de um sistema de enquetes implementado com .NET 7 + MassTransit + RabbitMQ.

Para rodar um servidor para troca de mensagens via docker (evitar de instalar o RabbitMQ em sua máquina):

**docker run -p 15672:15672 -p 5672:5672 masstransit/rabbitmq**

# 3. Conclusões
O MassTransit permite uma implementação facilitada e desacoplada de um sistema que faz uso de mensageria com RabbitMQ. O consumer pode ser escalado conforme a necessidade e o producer não precisa ser necessariamente uma API. 

# 4. Referência
1. [Documentação do MassTransit](https://masstransit.io/documentation/transports/rabbitmq)

