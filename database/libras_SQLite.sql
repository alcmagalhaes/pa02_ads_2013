-- Creator:       MySQL Workbench 5.2.47/ExportSQLite plugin 2009.12.02
-- Author:        andre
-- Caption:       New Model
-- Project:       Name of the project
-- Changed:       2013-04-25 00:20
-- Created:       2013-04-24 23:34
PRAGMA foreign_keys = OFF;

-- Schema: mydb
BEGIN;
CREATE TABLE "tb_alfabeto"(
  "alf_id" INTEGER PRIMARY KEY NOT NULL,
  "alf_ptBR" VARCHAR(2),
  "alf_libras" BLOB
);
CREATE TABLE "tb_dicionario"(
  "dic_id" INTEGER PRIMARY KEY NOT NULL,
  "dic_palavras" VARCHAR(45),
  "alf_id" INTEGER NOT NULL,
  CONSTRAINT "fk_tb_dicionario_tb_alfabeto1"
    FOREIGN KEY("alf_id")
    REFERENCES "tb_alfabeto"("alf_id")
);
CREATE INDEX "tb_dicionario.fk_tb_dicionario_tb_alfabeto1_idx" ON "tb_dicionario"("alf_id");
CREATE TABLE "tb_exercicio"(
  "exec_id" INTEGER PRIMARY KEY NOT NULL,
  "dic_id" INTEGER NOT NULL,
  CONSTRAINT "fk_tb_exercicio_tb_dicionario1"
    FOREIGN KEY("dic_id")
    REFERENCES "tb_dicionario"("dic_id")
);
CREATE INDEX "tb_exercicio.fk_tb_exercicio_tb_dicionario1_idx" ON "tb_exercicio"("dic_id");
CREATE TABLE "tb_nivelamento"(
  "niv_id" INTEGER PRIMARY KEY NOT NULL,
  "niv_descricao" VARCHAR(45),
  "niv_status" BOOLEAN,
  "exec_id" INTEGER NOT NULL,
  CONSTRAINT "fk_tb_nivelamento_tb_exercicio1"
    FOREIGN KEY("exec_id")
    REFERENCES "tb_exercicio"("exec_id")
);
CREATE INDEX "tb_nivelamento.fk_tb_nivelamento_tb_exercicio1_idx" ON "tb_nivelamento"("exec_id");
CREATE TABLE "tb_aluno"(
  "aluno_id" INTEGER PRIMARY KEY NOT NULL,
  "aluno_nome" VARCHAR(80),
  "aluno_idade" INTEGER,
  "aluno_mae" VARCHAR(80),
  "niv_id" INTEGER NOT NULL,
  CONSTRAINT "fk_tb_aluno_tb_nivelamento"
    FOREIGN KEY("niv_id")
    REFERENCES "tb_nivelamento"("niv_id")
);
CREATE INDEX "tb_aluno.fk_tb_aluno_tb_nivelamento_idx" ON "tb_aluno"("niv_id");
COMMIT;
