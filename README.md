# 🧠 Fantasy Image Reader API

API desenvolvida em .NET que utiliza inteligência artificial para processar imagens e extrair informações estruturadas, transformando-as em objetos utilizáveis no sistema.

## 🚀 Objetivo

Permitir que o usuário envie imagens (como súmulas de partidas) e receba como resposta dados organizados prontos para uso no sistema.

## 🧩 Funcionalidades

- Upload de imagem
- Processamento via IA
- Extração de dados
- Conversão para classes C#
- Endpoint de pergunta/resposta

## 🏗️ Estrutura

Fantasy.ImageReader/
Controllers/
Services/
Models/
DTOs/
Infrastructure/
Utils/

## ⚙️ Tecnologias

- .NET 8 / 9
- ASP.NET Core
- OpenAI API
- Swagger

## 🔐 Configuração

Adicionar no appsettings.json:

"OpenAI": {
  "ApiKey": "SUA_CHAVE_AQUI"
}

## 📡 Endpoints

POST /api/image/process
POST /api/ai/ask

## 🧠 Fluxo

1. Envia imagem
2. IA processa
3. Retorna JSON
4. API converte para classe

## 🛠️ Roadmap

- Upload múltiplo
- Melhorar prompts
- Validação de dados
- Integração com fantasy

## 👨‍💻 Autor

Projeto 4Fantasy
