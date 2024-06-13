# fluent-validation
Exemplo de implementação da biblioteca fluent validation para criação de regras de validação.

# Exemplo
url: /Pessoa (POST)

Requisição
```
{
	"Id": 0,
	"Nome": "Teste Teste Teste",
	"Email": "",
	"Idade": 0
}
```

Retorno:
```
{
    "errors": {
        "Nome": [
            "'Nome' deve ter entre 0 e 10 caracteres. Você digitou 17 caracteres."
        ],
        "Email": [
            "'Email' é um endereço de email inválido."
        ],
        "Idade": [
            "'Idade' deve estar entre 18 e 60. Você digitou 0."
        ]
    },
    "title": "One or more validation errors occurred.",
    "status": 400,
    "traceId": "0HLPM1RNTVMJT:00000007"
}
```
<br/>

<a href="https://www.linkedin.com/in/glerystonmatos/" target="_blank">Gleryston Matos</a><br/>
glerystonmatos@yahoo.com.br<br/>
glerystonmatos@gmail.com<br/>