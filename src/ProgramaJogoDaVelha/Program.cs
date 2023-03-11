char[,] matriz = new char[3, 3];
char numeroDigitado = ' ';
int jogada = 0;
Tabuleiro();
Jogo();
void Jogo()
{
    bool vitoria = false;

    do
    {
        MostrarTabuleiro();
        EscolherPosicao();
        vitoria = PreencherMatriz();
        Console.Clear();

    } while (jogada < 9 && !vitoria);

    if (jogada == 9)
    {
        MostrarTabuleiro();
        Console.WriteLine("Deu Velha...Tente Novamente!");
    }

    if (vitoria == true)
    {
        MostrarTabuleiro();
        Console.WriteLine("Vitória!!!!");
        Console.WriteLine("Fim de jogo. Parabéns!!!!!");

    }
  
}
bool PreencherMatriz()
{
    bool ganhar = false;
    switch (numeroDigitado)
    {
        case '1':
            if (matriz[0, 0] == 'X' || matriz[0, 0] == 'O')
            {
                Console.Write("Opção ocupada, tente outra posição.");
                EscolherPosicao();
            }
            else if (jogada % 2 == 0)
            {
                matriz[0, 0] = 'X';
            }
            else
            {
                matriz[0, 0] = 'O';
            }
            jogada++;
            if (jogada >= 5)
            {
                ganhar = VerificarJogo();
            }
            break;
        case '2':
            if (matriz[0, 1] == 'X' || matriz[0, 1] == 'O')
            {
                Console.Write("Opção ocupada, tente outra posição.");
                EscolherPosicao();
            }
            else if (jogada % 2 == 0)
            {
                matriz[0, 1] = 'X';
            }
            else
            {
                matriz[0, 1] = 'O';
            }
            jogada++;
            if (jogada >= 5)
            {
                ganhar = VerificarJogo();
            }
            break;
        case '3':
            if (matriz[0, 2] == 'X' || matriz[0, 2] == 'O')
            {
                Console.Write("Opção ocupada, tente outra posição.");
                EscolherPosicao();
            }
            else if (jogada % 2 == 0)
            {
                matriz[0, 2] = 'X';
            }
            else
            {
                matriz[0, 2] = 'O';
            }
            jogada++;
            if (jogada >= 5)
            {
                ganhar = VerificarJogo();
            }
            break;
        case '4':
            if (matriz[1, 0] == 'X' || matriz[1, 0] == 'O')
            {
                Console.Write("Opção ocupada, tente outra posição.");
                EscolherPosicao();
            }
            else if (jogada % 2 == 0)
            {
                matriz[1, 0] = 'X';
            }
            else
            {
                matriz[1, 0] = 'O';
            }
            jogada++;
            if (jogada >= 5)
            {
                ganhar = VerificarJogo();
            }
            break;
        case '5':
            if (matriz[1, 1] == 'X' || matriz[1, 1] == 'O')
            {
                Console.Write("Opção ocupada, tente outra posição.");
                EscolherPosicao();
            }
            else if (jogada % 2 == 0)
            {
                matriz[1, 1] = 'X';
            }
            else
            {
                matriz[1, 1] = 'O';
            }
            jogada++;
            if (jogada >= 5)
            {
                ganhar = VerificarJogo();
            }
            break;
        case '6':
            if (matriz[1, 2] == 'X' || matriz[1, 2] == 'O')
            {
                Console.Write("Opção ocupada, tente outra posição.");
                EscolherPosicao();
            }
            else if (jogada % 2 == 0)
            {
                matriz[1, 2] = 'X';
            }
            else
            {
                matriz[1, 2] = 'O';
            }
            jogada++;
            if (jogada >= 5)
            {
                ganhar = VerificarJogo();
            }
            break;
        case '7':
            if (matriz[2, 0] == 'X' || matriz[2, 0] == 'O')
            {
                Console.Write("Opção ocupada, tente outra posição.");
                EscolherPosicao();
            }
            else if (jogada % 2 == 0)
            {
                matriz[2, 0] = 'X';
            }
            else
            {
                matriz[2, 0] = 'O';
            }
            jogada++;
            if (jogada >= 5)
            {
                ganhar = VerificarJogo();
            }
            break;
        case '8':
            if (matriz[2, 1] == 'X' || matriz[2, 1] == 'O')
            {
                Console.Write("Opção ocupada, tente outra posição.");
                EscolherPosicao();
            }
            else if (jogada % 2 == 0)
            {
                matriz[2, 1] = 'X';
            }
            else
            {
                matriz[2, 1] = 'O';
            }
            jogada++;
            if (jogada >= 5)
            {
                ganhar = VerificarJogo();
            }
            break;
        case '9':
            if (matriz[2, 2] == 'X' || matriz[2, 2] == 'O')
            {
                Console.Write("Opção ocupada, tente outra posição.");
                EscolherPosicao();
            }
            else if (jogada % 2 == 0)
            {
                matriz[2, 2] = 'X';
            }
            else
            {
                matriz[2, 2] = 'O';
            }
            jogada++;
            if (jogada >= 5)
            {
                ganhar = VerificarJogo();
            }
            break;
        default:
            Console.WriteLine("Digito incorreto.Tente novamnete.");
            EscolherPosicao();
            break;
    }

    return ganhar;
}
void Tabuleiro()
{
    matriz[0, 0] = '1';
    matriz[0, 1] = '2';
    matriz[0, 2] = '3';
    matriz[1, 0] = '4';
    matriz[1, 1] = '5';
    matriz[1, 2] = '6';
    matriz[2, 0] = '7';
    matriz[2, 1] = '8';
    matriz[2, 2] = '9';

}
void MostrarTabuleiro()
{

    for (int linha = 0; linha < 3; linha++)
    {
        for (int coluna = 0; coluna < 3; coluna++)
        {
            Console.Write("  " + matriz[linha, coluna] + "  |");
        }
        Console.WriteLine("\n");
    }

}
void EscolherPosicao()
{
    if (jogada % 2 == 0)
    {
        Console.WriteLine("Jogador 01: Escolha uma das posições enumeradas de 1 a 9 acima: ");
        numeroDigitado = char.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Jogador 02: Escolha uma das posições enumeradas de 1 a 9 acima: ");
        numeroDigitado = char.Parse(Console.ReadLine());
    }
}
bool VerificarJogo()
{
    //ganhar linhas
    for (int linhas = 0; linhas < 3; linhas++)
    {
        if ((matriz[linhas, 0] == matriz[linhas, 1]) && (matriz[linhas, 1] == matriz[linhas, 2]))
        {
            return true;
        }
    }
    //ganhar colunas
    for (int colunas = 0; colunas < 3; colunas++)
    {
        if ((matriz[0, colunas] == matriz[1, colunas]) && (matriz[1, colunas] == matriz[2, colunas]))
        {
            return true;
        }
    }

    if ((matriz[0, 0] == matriz[1, 1]) && (matriz[1, 1] == matriz[2, 2]))
    {
        return true;
    }
    if ((matriz[0, 2] == matriz[1, 1]) && (matriz[1, 1] == matriz[2, 0]))
    {
        return true;
    }
    return false;

}