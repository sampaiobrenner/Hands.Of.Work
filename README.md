# Hands.Of.Work

Antes de iniciar o projeto é necessário executar o docker-compose disponibilizado na pasta 'tools' para realizar a criação do container com o SQL Server.

- Para subir o docker-compose, acesse a pasta tools pelo cmd e execute o comando: docker-compose up -d

Após o container do SQL Server ser iniciado, você precisa executar as migrations deste projeto, para isso acesse o Package Manager Console e digite o comando: update-database

Caso você tenha criado uma nova entidade nesse projeto, para criar uma nova migration acesse o Package Manager Console e digite o comando: add-migration [digite-aqui-uma-descricao]

