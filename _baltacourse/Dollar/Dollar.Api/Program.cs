var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Request - Requisição

// GET, POST, PUT e DELETE
// Obter, Criar, Atualizar, Excluir - CRUD
// GET (NÃO TEM CORPO)
// Requisição -> Cabeçalho e Corpo
// POST, PUT, DELETE (Normalmente não tem corpo)
// JSON - JavaScript Object Notation
// {"name" : "jose"}
// Binding -> Vínculo, Ligação, Elo
// Transformar o objeto JSON em um objeto C# 


// Response - Resposta da Requisição
// Cabeçalho e Corpo
// Status Code - 404, 401, 403, 200, 201, 500, 400

// Endpoints -> URL para acesso
// Convenções de mercado
// https://localhost:0000/


// Versão ou versionamento
// Diversos Fronts
// App - Apple Stores -> Produtos
// -> QUEBRAR (Atualizar o App incluindo a descrição)
// 2 dias
// Contratos -> quebrou o contrato
// -> Antes não precisava da desc e agora precisa
// Versionamento


app.MapGet("/", () => "Hello World!");
app.MapPost("/", () => "Hello World!");
app.MapPut("/", () => "Hello World!");
app.MapDelete("/", () => "Hello World!");

app.Run();
