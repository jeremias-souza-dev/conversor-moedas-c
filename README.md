# Conversor de Moedas

Um app simples em C# com Windows Forms que converte valores entre moedas usando a ExchangeRate-API.

---

## O que ele faz?

- Escolhe as moedas de origem e destino.
- Confere se o valor digitado é válido.
- Busca a cotação na internet.
- Mostra o resultado rapidinho.
- Dá avisos se algo der errado.

---

## O que precisa?

- Visual Studio instalado.
- Internet pra buscar as cotações.
- Uma chave da ExchangeRate-API (é grátis!).

---

## Como usar?

1. Clone o projeto:
```bash
git clone https://github.com/jeremias-souza-dev/conversor-moedas-c.git
````

2. Abra no Visual Studio, compile e rode.
3. Escolha as moedas e digite o valor.
4. Clique em converter e pronto!

---

## Atenção com a API

Depois de criar sua conta em [https://app.exchangerate-api.com/](https://app.exchangerate-api.com/), não esqueça de confirmar seu e-mail aqui:
[https://app.exchangerate-api.com/dashboard/confirmed](https://app.exchangerate-api.com/dashboard/confirmed)

Depois pegue sua chave e troque no código onde está `apiKey`.
