# 🖥️ HelpSeek Desktop  
Sistema de Chamados – Versão Desktop (.NET Framework 4.8)

O **HelpSeek Desktop** é um aplicativo desenvolvido para gerenciamento de chamados internos, oferecendo recursos para colaboradores, técnicos e administradores.  
Este projeto faz parte de um sistema maior composto por API, versão Web e versão Mobile.

---

## 🚀 Funcionalidades Principais

### 👤 Colaborador
- Registro de novos chamados  
- Consulta de chamados abertos  
- Acompanhamento de status  
- Envio de mensagens para o técnico  

### 🔧 Técnico
- Visualização de chamados atribuídos  
- Alteração de status (Em andamento, Resolvido, Pendente)  
- Registro de interações com o colaborador  

### 🛠️ Administrador
- Gerenciamento de usuários  
- Controle de permissões  
- Acompanhamento geral dos chamados  

---

## 🏗️ Arquitetura do Projeto

O aplicativo foi desenvolvido utilizando:

- **C# – .NET Framework 4.8**
- **WinForms**
- **REST API HelpSeek.API** (para persistência e dados)
- **Consumo de JSON** via HttpClient
- **Padrão MVC simplificado (camadas separadas)**

---

## 📦 Estrutura do Repositório
/HelpSeek.Desktop
│── /Forms # Telas do sistema (Login, Dashboard, Chamados, etc.)
│── /Services # Classes de comunicação com a API
│── /Models # Estrutura dos objetos (Usuario, Chamado, Interacao...)
│── /Utils # Helpers e funções de suporte
│── HelpSeek.Desktop.csproj
│── README.md
