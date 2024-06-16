# R.O.B.O - (Robô Operacional Binariamente Orientado)

Projeto criado para controlar os estados do R.O.B.O.

Regras implementadas:
- O estado inicial dos movimentos é Em Repouso.
- Só poderá movimentar o Pulso caso o Cotovelo esteja Fortemente Contraído.
- Só poderá Rotacionar a Cabeça caso sua Inclinação da Cabeça não esteja em estado Para Baixo.
- Ao realizar a progressão de estados, é necessário que sempre siga a ordem crescente ou decrescente, por exemplo, a partir do estado 4, pode-se ir para os estados 3 ou 5, nunca pulando um estado.
- Se tentar enviar um estado inválido você irá corromper o sistema do R.O.B.O.

Projetos dentro da Solution:
- R.O.B.O - .Net Framework 4.7.2 - Aplicação do Front End - Web Forms
- R.O.B.O.Api - .Net Framework 8.0 - Aplicação Back End - Web Api
- R.O.B.O.Core - .Net Framework 4.7.2 - Class Library - Centralizador dos objetos utilizados

Packages utilizados para a execução do projeto:
- System.ComponentModel.DataAnnotations;
- Newtonsoft.Json;
- Microsoft.AspNetCore.Mvc;
 
