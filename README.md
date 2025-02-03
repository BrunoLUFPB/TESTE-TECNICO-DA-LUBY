# Desafio Técnico - Programa de Estágio ASP.NET Luby

Este repositório contém as soluções para o desafio técnico proposto pela Luby para o programa de estágio na incubadora ASP.NET. O desafio é composto por três partes:

1. **Lógica de Programação e Estrutura de Dados** (10 questões)
2. **Criação de Scripts SQL** (10 questões)
3. **Desenvolvimento de uma Vending Machine (Máquina de Venda de Bebidas em Lata)** utilizando os conceitos de **Orientação a Objetos**.

## 🛠️ Tecnologias Utilizadas
- **Linguagem**: C# (.NET Core)
- **Banco de Dados**: PostgreSQL e PGadmin 
- **Interface**: Console Application
- **IDE**: Visual Studio/Visual Studio Code

## 📁 Estrutura do Projeto

```
├── LógicaDeProgramação
│   ├── CalcularFatorial.cs
│   ├── CalcularPremio.cs
│   ├── ContarNumerosPrimos.cs
│   ├── CalcularVogais.cs
│   ├── CalcularValorComDescontoFormatado.cs
│   ├── CalcularDiferencaData.cs
│   ├── ObterElementosPares.cs
│   ├── BuscarPessoa.cs
│   ├── TransformarEmMatriz.cs
│   └── ObterElementosFaltantes.cs
│
├── ScriptsSQL
│   ├── SelectPessoasComEventos.sql
│   ├── SelectPessoasDoe.sql
│   ├── InsertEventoLisaRomero.sql
│   ├── UpdateEventoDParaJohnDoe.sql
│   ├── DeleteEventoB.sql
│   ├── DeletePessoasSemEventos.sql
│   ├── AlterTablePessoaAdicionarIdade.sql
│   ├── CreateTableTelefone.sql
│   ├── CreateUniqueIndexTelefone.sql
│   └── DropTableTelefone.sql
│
└── VendingMachineApp
    ├── Program.cs
    ├── VendingMachine.cs
    ├── Produto.cs
    └── README.md (Instruções de Execução)
```

## 🚀 Como Rodar Localmente

### Requisitos:
- .NET Core SDK instalado.
- SQL Server ou outro SGBD compatível.

### Passos para executar o projeto:
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   ```
2. Acesse a pasta do projeto:
   ```bash
   cd seu-repositorio
   ```
3. Execute os projetos conforme instruções nas pastas **Logica de Programacao**, **Questoes SQL**, e **VendingMachine**.

### Executando o Aplicativo Vending Machine:
1. Navegue até a pasta `VendingMachine`:
   ```bash
   cd VendingMachine
   ```
2. Compile o projeto:
   ```bash
   dotnet build
   ```
3. Execute o programa:
   ```bash
   dotnet run
   ```
4. Siga as instruções no console para interagir com a máquina de vendas.

## 1️⃣ Lógica de Programação e Estrutura de Dados

As seguintes questões foram resolvidas utilizando **C#**, com foco em boas práticas de programação e eficiência:

1. **Calcular Fatorial** - Calcula o fatorial de um número.
2. **Calcular Valor do Prêmio com Fatores** - Aplica fatores de multiplicação para calcular o prêmio.
3. **Contar Números Primos** - Conta quantos números primos existem até o número informado.
4. **Calcular Número de Vogais** - Conta a quantidade de vogais em uma string.
5. **Aplicar Porcentagem de Desconto** - Aplica um desconto percentual a um valor e retorna o resultado formatado.
6. **Calcular Diferença de Datas** - Calcula a diferença de dias entre duas datas.
7. **Obter Elementos Pares** - Retorna todos os elementos pares de um vetor.
8. **Buscar Pessoas** - Busca nomes em um vetor com base em uma string informada.
9. **Transformar String em Matriz** - Converte uma string de números em uma matriz de inteiros.
10. **Obter Elementos Faltantes** - Compara dois vetores e retorna os elementos faltantes.

Cada questão está devidamente comentada e com exemplos de execução nos próprios arquivos.

## 2️⃣ Scripts SQL

Os scripts SQL foram desenvolvidos utilizando as tabelas fornecidas no desafio. Eles incluem comandos **SELECT**, **INSERT**, **UPDATE**, **DELETE**, além de alterações em tabelas e criação de índices.

### Tabelas Utilizadas:

**tabela_pessoa**
| id  | nome         |
|-----|--------------|
| 1   | John Doe     |
| 2   | Jane Doe     |
| 3   | Alice Jones  |
| 4   | Bobby Louis  |
| 5   | Lisa Romero  |

**tabela_evento**
| id  | evento    | pessoa_id |
|-----|-----------|-----------|
| 1   | Evento A  | 2         |
| 2   | Evento B  | 3         |
| 3   | Evento C  | 2         |
| 4   | Evento D  | NULL      |

### Scripts Incluídos:
1. **Selecionar Pessoas e Seus Eventos**
2. **Selecionar Pessoas com Sobrenome 'Doe'**
3. **Adicionar Evento para Lisa Romero**
4. **Atualizar Evento D para John Doe**
5. **Remover Evento B**
6. **Remover Pessoas sem Eventos**
7. **Adicionar Coluna 'idade' na Tabela Pessoa**
8. **Criar Tabela Telefone Relacionada a Pessoa**
9. **Criar Índice Único na Coluna Telefone**
10. **Remover a Tabela Telefone**

## 3️⃣ Desafio Orientado a Objetos - Vending Machine

O desafio consistiu na criação de uma máquina de vendas de bebidas em lata com as seguintes funcionalidades:

### Funcionalidades Implementadas:
- **Estoque de Produtos**: Cada produto tem nome, valor e quantidade disponível.
- **Compra de Produtos**: A máquina só permite a venda se houver estoque. O pagamento deve ser igual ou superior ao valor do produto.
- **Troco**: Caso o valor inserido seja maior que o valor do produto, a máquina informa o valor do troco.
- **Visualização de Estoque**: O usuário pode visualizar todos os produtos disponíveis e suas quantidades.
- **Controle de Vendas**: A máquina registra todas as vendas realizadas e exibe o valor total arrecadado.

## ✨ Contato

Caso tenha dúvidas ou sugestões, sinta-se à vontade para entrar em contato:

**Nome**: Bruno Luís Silva Guedes   
**Email**: blsg@academico.ufpb.br  
**LinkedIn**: [Meu LinkedIn](www.linkedin.com/in/bruno-luis-8a730b220)

Agradeço pela oportunidade de participar deste processo seletivo e espero que minha solução atenda às expectativas! 🚀

---
