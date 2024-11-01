# Marcador de Ponto

Este é um projeto de um sistema de registro de ponto desenvolvido em .NET 8. O sistema permite registrar e consultar pontos de entrada e saída de funcionários.

## Estrutura do Projeto

```
.
├── .dockerignore
├── .gitignore
├── .vs/
│   ├── MarcadorDePonto/
│   ├── config/
│   ├── CopilotIndices/
│   ├── DesignTimeBuild/
│   ├── FileContentIndex/
│   └── v17/
├── ProjectEvaluation/
├── sd/
├── backend/
│   ├── bin/
│   │   └── Debug/
│   ├── Controllers/
│   │   └── 
PointsController.cs
│   ├── Infra/
│   │   └── 
ApplicationDbContext.cs
│   ├── Models/
│   │   └── 
Ponto.cs
│   ├── obj/
│   │   └── Debug/
│   ├── Properties/
│   │   └── 
launchSettings.json
│   ├── 
MarcadorDePonto.csproj
│   ├── 
MarcadorDePonto.csproj.user
│   ├── 
MarcadorDePonto.http
│   ├── 
Program.cs
│   └── Dockerfile
├── frontend/
│   └── 
tela.html
├── 
MarcadorDePonto.sln
└── Dockerfile
```

## Configuração do Ambiente

### Pré-requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started)

### Configuração do Banco de Dados

O projeto utiliza um banco de dados em memória para fins de desenvolvimento. Não é necessária nenhuma configuração adicional para o banco de dados.

## Executando o Projeto

### Localmente

1. Clone o repositório:
   ```sh
   git clone <URL_DO_REPOSITORIO>
   cd MarcadorDePonto
   ```

2. Navegue até a pasta `backend` e execute o projeto:
   ```sh
   cd backend
   dotnet run
   ```

3. O projeto estará disponível em `http://localhost:5070` e `https://localhost:7048`.

### Usando Docker

1. Construa a imagem Docker:
   ```sh
   docker build -t marcador-de-ponto .
   ```

2. Execute o contêiner:
   ```sh
   docker run -p 8080:80 -p 8081:443 marcador-de-ponto
   ```

3. O projeto estará disponível em `http://localhost:8080` e `https://localhost:8081`.

## Endpoints da API

### Registrar Ponto

- **URL:** `/api/pontos`
- **Método:** `POST`
- **Corpo da Requisição:**
  ```json
  {
    "data": "2021-01-01",
    "entrada": "08:00:00",
    "saida": "17:00:00"
  }
  ```

### Consultar Ponto

- **URL:** `/api/pontos/{id}`
- **Método:** `GET`

## Interface Web

A interface web está localizada em `frontend/tela.html`. Para utilizá-la, abra o arquivo em um navegador.

## Contribuição

Sinta-se à vontade para contribuir com o projeto. Para isso, faça um fork do repositório, crie uma branch para suas alterações e envie um pull request.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
```

Este README fornece uma visão geral do projeto, instruções de configuração e execução, detalhes sobre os endpoints da API e informações sobre a interface web.