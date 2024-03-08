Para executar o Docker
docker build -t counter-image -f Dockerfile .
docker run -it --rm --entrypoint "cmd.exe" counter-image

README.md
Gerenciador de Tarefas API
Visão Geral
O Gerenciador de Tarefas API é um sistema desenvolvido em .NET Core 7 para permitir que os usuários organizem e monitorem suas tarefas diárias, além de colaborar com colegas de equipe. O sistema permite a criação, visualização e gerenciamento de projetos e tarefas associadas a esses projetos.
Funcionalidades Implementadas
* Listagem de Projetos
* Visualização de Tarefas de um Projeto
* Criação de Projetos
* Criação de Tarefas em um Projeto
* Atualização de Tarefas (status e detalhes)
* Remoção de Tarefas de um Projeto
  
Regras de Negócio Implementadas
  Prioridades de Tarefas
  Restrições de Remoção de Projetos
  Histórico de Atualizações
  Limite de Tarefas por Projeto
  Relatórios de Desempenho
  Comentários nas Tarefas
Requisitos de Avaliação
* Não é necessário CRUD para usuários
* Não é necessário autenticação
* Cobertura de testes de unidade de pelo menos 80%
* Utilização do Git para versionamento
* Utilização de um banco de dados para persistência
* Utilização de frameworks e bibliotecas adequados
* Execução no Docker, com instruções disponíveis no README.md
  
Fase 2: Refinamento
Para a segunda fase, gostaria de discutir com o Product Owner (PO) algumas melhorias e refinamentos para o sistema. Alguns pontos que gostaria de abordar são:
Feedback dos usuários: Obter feedback dos usuários sobre a usabilidade e funcionalidades do sistema para identificar áreas de melhoria.
Melhorias na documentação: Refinar a documentação do código-fonte e do usuário para tornar o sistema mais fácil de entender e usar.
Integração contínua: Implementar integração contínua e entrega contínua (CI/CD) para automatizar o processo de teste e implantação.
  
Fase 3: Final
Para a terceira fase, identifico algumas áreas de melhoria e pontos para futuras implementações:
Implementação de padrões de design: Utilizar padrões de design como MVC, Dependency Injection, e DDD para melhorar a arquitetura do sistema.
Escalabilidade: Projetar o sistema visando a escalabilidade, utilizando serviços em nuvem e arquitetura de microsserviços, se necessário.
Segurança: Implementar medidas de segurança, como autenticação e autorização, para proteger os dados do usuário.
Monitoramento e logging: Adicionar recursos de monitoramento e logging para acompanhar o desempenho e identificar problemas no sistema.
Melhorias de desempenho: Identificar e resolver gargalos de desempenho para garantir uma experiência rápida e responsiva para os usuários.
