# 💻 Trabalho de Programação em C# – Lista de Exercícios

## 👥 Integrantes do Grupo
- Fabiane Ançai  
- Naara Sevciuc  
- Sarah Veloso

## ✅ Exercícios Resolvidos
1. **Validador de Senhas Fortes**  
9. **Jogo da Adivinhação**  


## 📝 Descrição Funcional dos Exercícios

### 1. Validador de Senhas Fortes  
Solicita uma senha ao usuário e verifica se atende aos seguintes critérios: mínimo de 8 caracteres, pelo menos uma letra maiúscula, um número e um caractere especial.

### 9. Jogo da Adivinhação  
Gera um número aleatório entre 1 e 100 e permite que o usuário tente adivinhar. Após cada tentativa, informa se o número é maior ou menor. Ao acertar, exibe a quantidade de tentativas.


## 📘 Documentação Detalhada

### 🔐 Exercício 1: Validador de Senhas Fortes

**Descrição funcional:**  
O programa solicita que o usuário insira uma senha e verifica se ela é considerada forte com base nos seguintes critérios:  
- Mínimo de 8 caracteres  
- Pelo menos uma letra maiúscula  
- Pelo menos um número  
- Pelo menos um caractere especial

**Passo a passo lógico:**
1. O usuário digita uma senha.
2. A função `ValidarSenha()` verifica os critérios.
3. São utilizados métodos da classe `char` para analisar cada caractere.
4. Se todos os critérios forem atendidos, a senha é aceita.

**Estruturas e comandos utilizados:**
- `if/else`, `foreach`, `char.IsUpper`, `char.IsDigit`, `char.IsLetterOrDigit`.

**Justificativas:**
- A verificação direta em cada caractere garante precisão na análise dos critérios.
- A função separada melhora a organização e legibilidade.


### 🎯 Exercício 9: Jogo da Adivinhação

**Descrição funcional:**  
Gera um número aleatório de 1 a 100 e solicita que o usuário tente adivinhar. Informa se o número secreto é maior ou menor a cada tentativa e exibe a quantidade total de tentativas ao final.

**Passo a passo lógico:**
1. Um número é gerado com `Random.Next(1, 101)`.
2. O usuário digita palpites até acertar.
3. A entrada é validada com `int.TryParse`.
4. O programa informa se o palpite é maior ou menor que o número secreto.

**Estruturas e comandos utilizados:**
- `Random`, `do...while`, `TryParse`, `if/else`, `contador`.

**Justificativas:**
- O uso de `TryParse` evita erros de digitação.
- A estrutura `do...while` garante que o jogo execute ao menos uma rodada.
- O loop e as mensagens tornam o jogo dinâmico e interativo.

