# README

This README would normally document whatever steps are necessary to get your application up and running.

### What is this repository for?

- This application was developed for a simple pharmacy management with ASP.NET MVC 5
- 0.0.1

### How do I get set up?

- Database configuration:
  - Run MSSQL docker image on port 1433,
    ```
    docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=P@ssW0rd' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
    ```
  - Run the DB script from ./DataBase/BDD_Model.sql
  - If you change the password, please edit the connectionString in ./PharmaWeb/Web.config
