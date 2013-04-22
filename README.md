pa02_ads_2013
=============

Projeto da disciplina PA do 2 módulo de ADS/UNATEC 2013

#################### Comandos básicos git #####################
# Baixar o projeto
git clone git@github.com:alcmagalhaes/pa02_ads_2013.git (baixa no diretorio corrente com o nome pa02_ads_2013)
git clone git@github.com:alcmagalhaes/pa02_ads_2013.git /home/usuario/projetos/libras (baixa no diretorio /home/usuario/projetos com o nome libras)

# Mudar para o branch developer (versão de desenvolvimento do projeto)
cd pa02_ads_2013 (entra na pasta do projeto)
git pull (atualiza a base local com a do servidor)
git checkout developer  (mudar para o branch developer)

# Mudar para o branch stable (versão estável do projeto)
cd pa02_ads_2013 (entra na pasta do projeto)
git pull (atualiza a base local com a do servidor)
git checkout stable  (mudar para o branch stable)

# Saber em qual branch esta
cd pa02_ads_2013 (entra na pasta do projeto)
git branch (o marcado com * é o branch atual)

# Buscar o nome de todos os branchs no servidor
cd pa02_ads_2013 (entra na pasta do projeto)
git branch –a

# Adicionando novo arquivo de código ao projeto
cd pa02_ads_2013 (entra na pasta do projeto)
git add arquivo (ou diretorio)

# Commit(enviar) das modificações para o servidor 
git commit –a

# Verificando ultimas alterações
git log

#################### Fim Comandos básicos git #####################
