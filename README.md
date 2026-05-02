# 🧠 Fantasy Image Reader API

![.NET](https://img.shields.io/badge/.NET-8/9-blue)
![Status](https://img.shields.io/badge/status-active-success)
![License](https://img.shields.io/badge/license-private-lightgrey)

API em **.NET** que utiliza inteligência artificial para **ler imagens (ex: súmulas)** e transformar em **dados estruturados prontos para uso**.

---

## 🚀 Objetivo

Automatizar o processo de entrada de dados no fantasy:

📷 Imagem → 🤖 IA → 📊 JSON estruturado

Ideal para:
- Scouts de rodada
- Estatísticas de jogadores
- Automação de input manual

---

## 🎥 Demo

![Demo](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExb2demoexample/giphy.gif)

> Exemplo: upload de imagem → retorno estruturado via API

---

## ⚙️ Stack

- .NET 8 / 9
- ASP.NET Core Web API
- OpenAI (Vision / GPT)
- Swagger

---

## 📡 Endpoints

### 📷 Processar imagem
POST /api/image/process

### 💬 Perguntar para IA
POST /api/ai/ask

---

## 🧠 Como funciona

1. Upload da imagem  
2. Conversão para base64  
3. Envio para IA  
4. Interpretação dos dados  
5. Retorno em JSON  
6. Mapeamento para classes C#  

---

## 🔐 Configuração

appsettings.json:

"OpenAI": {
  "ApiKey": "SUA_CHAVE_AQUI"
}

---

## 📌 Exemplo de resposta

{
  "jogo": "Brasilia x Santo Antonio",
  "jogadores": [
    {
      "nome": "Isaque",
      "gols": 2,
      "assistencias": 1
    }
  ]
}

---

## 🛠️ Roadmap

- [ ] Upload de múltiplas imagens  
- [ ] Suporte a abreviações (G, A, CA, CV)  
- [ ] Validação automática  
- [ ] Integração direta com 4Fantasy  
- [ ] Cache de resultados  

---

## 🏗️ Arquitetura

Controllers → Services → Models → Infrastructure

- Separação de responsabilidades  
- Fácil manutenção  
- Escalável  

---

## 👨‍💻 Projeto

Parte do ecossistema **4Fantasy**

---

## 📄 Licença

Uso privado
