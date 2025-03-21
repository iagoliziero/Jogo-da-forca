# Documentação do Jogo da Forca em C#

![Design sem nome (1)](https://github.com/user-attachments/assets/19285c29-66e7-4388-8682-afb4653909e4)

## Visão Geral

O Jogo da Forca é uma aplicação criada em C# utilizando o ambiente de desenvolvimento SharpDevelop.

 Ele permite que os jogadores tentem adivinhar uma palavra ao inserir letras ou tentar a palavra completa.
 
  O jogo apresenta um limite de 6 erros antes que o jogador perca a partida.

## Configuração da Interface Gráfica

### Tela Inicial

__Digite a Palavra:__

Campo para o jogador 1 inserir a palavra que será adivinhada.

Um botão "OK" para confirmar a palavra.

![Captura de tela 2024-12-19 110319](https://github.com/user-attachments/assets/f352e2e6-7e46-430d-acbc-044b5bd72026)


__Digite uma Letra:__

Campo para o jogador 2 inserir uma letra para adivinhar.

Botão "Verificar" para processar a letra inserida.

![Captura de tela 2024-12-19 110341](https://github.com/user-attachments/assets/09409783-c094-4de4-9258-46029d821a35)


__Sua Resposta:__

Campo para o jogador 2 inserir a palavra completa caso deseje tentar adivinhar diretamente.

Botão "Verificar" para processar a tentativa de resposta.

__ListBox:__

Exibe as letras já tentadas e o número de vezes que apareceram na palavra ou os erros acumulados.

![Captura de tela 2024-12-19 110433](https://github.com/user-attachments/assets/8baf569c-59df-4de2-aec0-9a22f960fac2)


__Mensagem Final:__

Um rótulo que exibe se o jogador venceu ou perdeu após o jogo terminar.

![Captura de tela 2024-12-19 110505](https://github.com/user-attachments/assets/d3712a76-b635-4f85-aedd-825d1d67f609)


## Funcionalidades

__1. Inicialização__

No método MainFormLoad, as funcionalidades do jogo são configuradas para desabilitar os botões e campos que não serão utilizados até a configuração da palavra.

```c#
button2.Enabled = false;
button3.Enabled = false;
textBox3.Enabled = false;
textBox2.Enabled = false;
```

__2. Inserção da Palavra__

O botão OK chama o método Button1Click, onde:

Verifica se a palavra inserida é válida.

Exibe a quantidade de letras na palavra.

Habilita os campos e botões para o jogador 2.

Oculta o campo e o botão de inserção da palavra.

__3. Tentativa de Letras__

No botão "Verificar" (letra), o método Button3Click:

__Valida a entrada:__

Apenas uma letra é permitida.

Caso contrário, exibe uma mensagem de erro.

![Captura de tela 2024-12-19 112457](https://github.com/user-attachments/assets/5b805181-eb85-40e6-a36e-6189ce3be20c)


__Verifica a presença da letra na palavra:__

Conta quantas vezes a letra aparece.

Atualiza a lista de tentativas (ListBox) com os resultados.

Incrementa o contador de erros caso a letra não esteja na palavra.

Finaliza o jogo se o jogador atingir 6 erros.

__Exemplo de código:__

```c#
if(vezesEncontradas >= 1) {
    listBox1.Items.Add(letra + ": aparece " + vezesEncontradas + " vez(es)");
} else {
    erros++;
    listBox1.Items.Add(letra + ": não aparece." + " Erros: " + erros);
}

if(erros == 6) {
    textBox2.Enabled = false;
    button3.Enabled = false;
    MessageBox.Show("Você atingiu o número máximo de erros.");
}
```
__4. Tentativa de Palavra Completa__

No botão "Verificar" (palavra), o método Button2Click:

Compara a palavra inserida pelo jogador 2 com a palavra original.

Exibe uma mensagem informando se o jogador venceu ou perdeu.

Altera a cor do texto da mensagem para verde (vitória) ou vermelho (derrota).

__Exemplo de código:__

```c#
if(palavra == resposta) {
    label6.Text = "Resposta Correta. Você Venceu!";
    label6.ForeColor = Color.Green;
} else {
    label6.Text = "Resposta Errada. Você Perdeu!";
    label6.ForeColor = Color.Red;
}
```

## Passo a Passo para Rodar o Jogo em Sua Máquina

- Instale o SharpDevelop
- Baixe e instale o SharpDevelop.
- Clone ou Baixe o Projeto
- Clone o repositório do GitHub ou baixe os arquivos do jogo.
- Abra o Projeto
- No SharpDevelop, selecione File > Open e escolha o arquivo .sln do projeto.
- Compile o Jogo
- Clique em Build > Build Solution ou pressione Ctrl + Shift + B.
- Execute o Jogo
- Clique em Debug > Start Without Debugging ou pressione Ctrl + F5.
- Interaja com a Interface
- Insira uma palavra para iniciar o jogo e siga as instruções na tela para tentar adivinhar.

## Conclusão

Este projeto do Jogo da Forca foi desenvolvido com o intuito de aprofundar conhecimentos em lógica programação com C#, principalmente na construção de interfaces gráficas e na lógica de jogos. 

É uma aplicação voltada para aprendizado e prática, sendo ideal para quem deseja explorar conceitos de desenvolvimento de software de forma prática e didática. 

As funcionalidades implementadas podem ser expandidas e personalizadas, proporcionando um excelente exercício para estudos futuros.
