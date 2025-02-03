### 1. QUESTÕES

+----+--------------+
| tabela_pessoa     |
+----+--------------+
| id | nome         |
+----+--------------+
|  1 | John Doe     |
|  2 | Jane Doe     |
|  3 | Alice Jones  |
|  4 | Bobby Louis  |
|  5 | Lisa Romero  |
+----+--------------+
+----+----------------+-----------+
| tabela_evento                   |
+----+----------------+-----------+
| id | evento         | pessoa_id |
+----+----------------+-----------+
|  1 | Evento A       |  2        |
|  2 | Evento B       |  3        |
|  3 | Evento C       |  2        |
|  4 | Evento D       |  NULL     |
+----+----------------+-----------+
 
 2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.
 2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.
 2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.
 2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'
 2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.
 2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' que não possuem eventos 'tabela_evento' relacionados.

 ### Gerenciamento de tabelas

 2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)
 2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:\
 id: int (PK)
 telefone: varchar(200)
 pessoa_id: int(FK)
 2.9 Crie uma query para criar uma índice do tipo único
 único na coluna telefone da 'tabela_telefone'.
 2.10 Crie uma query para remover a 'tabela_telefone'.

 ### 2. RESULTADOS DA CRIAÇÃO DOS QUERYS

*Utilizei o PostgreSQL 17.2.3 e PGadmin 4 v8 para criar todas as querys necessárias;*
*Criei as tabelas EVENTO e PESSOA;*

CREATE TABLE PESSOA(
	id SERIAL PRIMARY KEY,
	nome VARCHAR(255) NOT NULL
);

CREATE TABLE EVENTO(
	id SERIAL PRIMARY KEY,
	evento VARCHAR(255) NOT NULL,
	pessoa_id INT,
	FOREIGN KEY (pessoa_id) REFERENCES PESSOA(id)
);

INSERT INTO pessoa (nome) VALUES
  ('John Doe'),
  ('Jane Doe'),
  ('Alice Jones'),
  ('Bobby Louis'),
  ('Lisa Romero');

INSERT INTO evento (evento, pessoa_id) VALUES
  ('EVENTO A', 2),
  ('EVENTO B', 3),
  ('EVENTO C', 2),
  ('EVENTO D', NULL);

### 2.1

SELECT p.id AS pessoa_id, p.nome, e.evento
FROM pessoa p
LEFT JOIN evento e ON p.id = e.pessoa_id;

### 2.2

SELECT id, nome 
FROM pessoa
WHERE LOWER(nome) LIKE '%doe';

### 2.3

INSERT INTO evento (evento, pessoa_id)
SELECT 'EVENTO E', id
FROM pessoa
WHERE nome = 'Lisa Romero';

### 2.4

UPDATE evento e
SET pessoa_id = p.id
FROM pessoa p
WHERE e.evento = 'EVENTO D'
AND p.nome = 'John Doe';

### 2.5

DELETE FROM evento
WHERE evento ILIKE 'evento b';

### 2.6

DELETE FROM pessoa p
USING (
  SELECT p.id
  FROM pessoa p
  LEFT JOIN evento e ON p.id = e.pessoa_id
  WHERE e.pessoa_id IS NULL
) AS sem_evento
WHERE p.id = sem_evento.id;

### 2.7

ALTER TABLE pessoa
ADD idade INT NOT NULL DEFAULT 0;

### 2.8

CREATE TABLE telefone (
    id SERIAL PRIMARY KEY,
    telefone VARCHAR(200) UNIQUE,
    pessoa_id INTEGER NOT NULL REFERENCES pessoa(id)
);

### 2.9

CREATE UNIQUE INDEX idx_telefone_unico ON telefone(telefone);

### 2.10

DROP TABLE IF EXISTS telefone;
