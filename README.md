# GameProject3_PT

Framework de servidor de jogo multiprocesso multiplataforma, com camada de rede implementada de três maneiras: SocketApi, Boost Asio e Libuv.
O framework utiliza memória compartilhada, filas sem bloqueio (lock-free), pool de objetos e pool de memória para melhorar o desempenho do servidor.

Também possui um cliente Demo em constante aperfeiçoamento — o jogo contém uma grande quantidade de recursos completos: montarias, pets, parceiros e equipamentos, todos podem ser equipados e usados. É possível entrar em masmorras para batalhar; jogabilidade multiplayer também já foi implementada.

> **Nota:** Este é um fork em Português do [GameProject3](https://github.com/ylmbtm/GameProject3) original.

---

## Instruções de Implantação e Inicialização do Servidor

### 1. Compilação
- **Windows:** Use o VisualStudio 2017 ou superior para abrir a solução e compilar diretamente.
- **Linux:** Execute o script `buildall.sh` para compilar.

### 2. Instalação do MySQL
1. Instale o banco de dados MySQL na máquina (versão recomendada: **MySQL 5.7**).
2. Após a instalação, se não quiser alterar o arquivo de configuração, crie o usuário `root` com a senha `123456` (padrão no arquivo de configuração).
3. Encontre o arquivo `db_create.sql` no projeto e execute-o no banco de dados para criar as tabelas.

### 3. Iniciar o Servidor
Após concluir os dois passos acima, execute o arquivo `Server/StartServer.bat` e siga as instruções.

---

## Descrição dos Servidores

| Servidor | Descrição |
|---|---|
| **LoginServer** | Aceita conexões de login dos jogadores, processa mensagens de solicitação de login. |
| **AccountServer** | Processa a verificação de login da conta, criação de novas contas e salvamento no banco de dados. |
| **CenterServer** | Usado para atividades entre servidores e guerra entre servidores. |
| **LogicServer** | Processa dados lógicos do personagem e funções lógicas gerais. |
| **GameServer** | Processa sincronização de movimento, habilidades, buffs e combate. |
| **DBServer** | Proxy entre o servidor lógico e o MySQL; grava periodicamente os dados do jogador no banco de dados. |
| **ProxyServer** | Trânsito entre o cliente, servidor lógico e servidor de campo de batalha; encaminhamento de mensagens. |
| **LogServer** | Grava logs operacionais do servidor lógico no MySQL. |
| **WatchServer** | Aceita comandos de controle do backend WEB para controle do servidor. |

---

## Cliente Unity

O cliente Unity está na pasta `Client/`. Abra o projeto com **Unity 6** (ou versão compatível).

### Requisitos
- Unity 6000.0 ou superior
- MySQL 5.7 (para o servidor)

---

## Referências
- Projeto original: https://github.com/ylmbtm/GameProject3
- Endereço Gitee: https://gitee.com/ylmbtm/GameProject3