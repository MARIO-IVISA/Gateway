# API Gateway com Ocelot

## Tags
`net6.0` `api-gateway` `ocelot` `cursos` `usuarios` `matriculas`

Este é um API Gateway desenvolvido em .NET 6.0 utilizando o Ocelot. Ele roteia requisições para vários serviços back-end e expõe uma única interface para os clientes.

## Configuração das Rotas

### Rota: Cursos
- **Descrição**: Rota para acessar os serviços relacionados a cursos.
- **Endpoint**: `/gateway/cursos`
- **Métodos HTTP**: GET, POST
- **Servidor Back-end**: `http://localhost:37782`

### Rota: Curso por ID
- **Descrição**: Rota para acessar um curso específico por ID.
- **Endpoint**: `/gateway/cursos/{id}`
- **Método HTTP**: GET
- **Servidor Back-end**: `http://localhost:37782`

### Rota: Login
- **Descrição**: Rota para autenticação de usuários.
- **Endpoint**: `/gateway/login`
- **Método HTTP**: POST
- **Servidor Back-end**: `http://localhost:12614`

### Rota: Cadastro de Usuário
- **Descrição**: Rota para cadastrar novos usuários.
- **Endpoint**: `/gateway/cadastro`
- **Método HTTP**: POST
- **Servidor Back-end**: `http://localhost:12614`

### Rota: Listagem de Usuários
- **Descrição**: Rota para listar todos os usuários cadastrados.
- **Endpoint**: `/gateway/usuarios`
- **Método HTTP**: GET
- **Servidor Back-end**: `http://localhost:12614`

### Rota: Verificar Matrícula
- **Descrição**: Rota para verificar a matrícula de um aluno em um curso.
- **Endpoint**: `/gateway/Matriculas/VerificarMatricula`
- **Método HTTP**: POST
- **Servidor Back-end**: `http://localhost:5293`

### Rota: Buscar Matrícula por Curso
- **Descrição**: Rota para buscar as matrículas de um curso específico.
- **Endpoint**: `/gateway/Matriculas/BuscarMatriculaPorCurso/{id}`
- **Método HTTP**: GET
- **Servidor Back-end**: `http://localhost:5293`

### Rota: Atualizar Matrícula
- **Descrição**: Rota para atualizar as informações de uma matrícula.
- **Endpoint**: `/gateway/Matriculas`
- **Método HTTP**: PUT
- **Servidor Back-end**: `http://localhost:5293`

### Rota: Matrícula
- **Descrição**: Rota para matrícula em um curso.
- **Endpoint**: `/gateway/Matriculas`
- **Método HTTP**: POST
- **Servidor Back-end**: `http://localhost:5293`

## Tecnologias Utilizadas

- .NET 6.0
- Ocelot
