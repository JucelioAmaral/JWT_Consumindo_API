
# .NET 5 + JWT: consumindo uma API que utiliza tokens.

.NET 5 + JWT: consumindo uma API que utiliza tokens.Serviço Windows e Api Restful, feita em .Net 5, em camadas, usando Dapper para persistencia e acesso ao banco de dados.Swagger para documentação da Api e SQLServer como SGBD.
JWT (JSON Web Tokens) como mecanismo de segurança no acesso a APIs REST criadas com o .NET 5. Demonstra como consumir uma API que usa JWT sendo consumida por uma aplicação/serviço windows construída a partir do .NET.
Referência: .NET Core 2.0 + JWT: consumindo uma API que utiliza tokens
https://renatogroffe.medium.com/net-core-2-0-jwt-consumindo-uma-api-que-utiliza-tokens-414f32f670de
 
## Pré requisitos
 
1. [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/)

## Como baixar o código

git clone

## Como configurar a api(Backend)?

1. Abrir a Visual Code ou Studio;
2. Configurar o arquivo "appsettings.json" com a connectionString, apontando para o banco SQL server;
3. Instalar os pacotes necessários;
4. Executar o script em anexo.

**API roda na porta 5001 e pode ser testada pelo link: https://localhost:5001/swagger/index.html**

