# Api-RESTful
teste de api RESTful simples

para rodar o projeto local é necessário atualizar a conection string do banco e executar o comando update-database para gerar o banco e as estruturas das tabelas.

![image](https://user-images.githubusercontent.com/27230971/115156100-22202e80-a059-11eb-86e0-54bba759c7e1.png)

para fins de testes a autenticação para gerar o Bearer Token está estático no AuthController:

![image](https://user-images.githubusercontent.com/27230971/115156139-4845ce80-a059-11eb-8510-3ac424ba9566.png)

ao iniciar o projeto o mesmo não possuirá registros no banco, sendo necessário chamar o método AtualizarBanco, apenas para popular com registros fakes.

![image](https://user-images.githubusercontent.com/27230971/115156195-775c4000-a059-11eb-9fe0-46bb2f3a5465.png)

o projeto foi desenvolvimento em 3 camadas sendo elas:

- Camada de Apresentação
- Camada da Lógica de negócios
- Camada de Acesso aos dados
