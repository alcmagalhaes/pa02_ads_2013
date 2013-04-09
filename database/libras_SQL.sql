CREATE TABLE tb_alfabeto (
  alf_id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  tb_exercicio_exec_id INTEGER UNSIGNED NOT NULL,
  alf_portugues CHAR NULL,
  alf_libras BLOB NULL,
  PRIMARY KEY(alf_id)
);

CREATE TABLE tb_aluno (
  aluno_id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  aluno_nome VARCHAR NULL,
  aluno_idade INTEGER UNSIGNED NULL,
  aluno_mae VARCHAR NULL,
  PRIMARY KEY(aluno_id)
);

CREATE TABLE tb_dicionario (
  dic_id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  tb_alfabeto_alf_id INTEGER UNSIGNED NOT NULL,
  dic_palavras VARCHAR NULL,
  PRIMARY KEY(dic_id, tb_alfabeto_alf_id)
);

CREATE TABLE tb_exercicio (
  exec_id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  tb_nivel_niv_id INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(exec_id)
);

CREATE TABLE tb_nivel (
  niv_id INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  tb_aluno_aluno_id INTEGER UNSIGNED NOT NULL,
  nivel_descricao INTEGER UNSIGNED NULL,
  nivel_aprovado BOOL NULL,
  PRIMARY KEY(niv_id)
);


