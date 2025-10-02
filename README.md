# Verificador de Idade - Windows Forms - Aula01

Este é um projeto simples em C# utilizando Windows Forms, criado na aula de Técnica de Programação II. O programa permite ao usuário digitar uma idade e informa se a pessoa é maior ou menor de idade.

## Funcionalidades

- Entrada de idade via campo de texto.
- Verificação se a idade é válida (número inteiro).
- Exibe mensagem se é maior ou menor de idade.
- Botão para limpar o campo de entrada.

## Como usar

1. Digite a idade no campo de texto.
2. Clique em **"Exibir"**:
   - Se for um número válido:
     - Mostra se é **maior** ou **menor de idade**.
   - Se não for número válido:
     - Mostra mensagem de erro.
3. Clique em **"Apagar"** para limpar o campo.

## Tecnologias

- C#
- Windows Forms (.NET Framework)

# Calculadora - Windows Forms - Aula02

Este projeto é uma calculadora simples feita em C# com Windows Forms. Ela realiza operações básicas entre dois valores numéricos digitados pelo usuário.

## Funcionalidades

- Soma
- Subtração
- Multiplicação
- Divisão
- Cálculo de IMC (Índice de Massa Corporal)

## Como usar

1. Digite dois valores numéricos nos campos disponíveis.
2. Clique no botão da operação desejada:
   - **Somar**
   - **Subtrair**
   - **Multiplicar**
   - **Dividir**
   - **IMC** (valor1 = peso, valor2 = altura)
3. O resultado será exibido no campo de resultado.

## Estrutura

- Interface feita com Windows Forms.
- A lógica das operações está encapsulada na classe `Calculadora`.
- A interface (`Form1`) instancia e utiliza essa classe para processar os cálculos.

## Tecnologias

- C#
- Windows Forms (.NET Framework)
