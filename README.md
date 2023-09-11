# Spaced Repetition System - SrsApi

Table: Topic

Id: ID (Chave Primária)
Name: Nome do Assunto
Description: Descrição do Assunto
DateOfAddition: Data de Adição
LastReviewDate: Última Data de Revisão

### Intervalos do Método Herbinhaus

Primeira Revisão: Imediatamente após o aprendizado.
Segunda Revisão: 1 dia após a primeira revisão.
Terceira Revisão: 7 dias após a segunda revisão.
Quarta Revisão: 30 dias após a terceira revisão.
E assim por diante, com intervalos fixos subsequentes.

# CLI
Install dotnet-ef to handle migrations
$ dotnet tool install --global dotnet-ef

Init migrations (Create migrations to reference the models)
$ dotnet ef migrations add InitialCreate

Update database (Populate the database in this case)
$ dotnet ef database update

Install packages
$ dotnet add package <name>

Uninstall packages
$ dotnet remove package <name>

Run seed and execute api
$ dotnet run seeddatav