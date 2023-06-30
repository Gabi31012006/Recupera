using System;
public class Verificar
{
    public int Idade;
    public double Pontos;
    public double Contribuicoes;
   
    public double Homens(int idade, double contibuicoes)
    {
        double pontos = idade + contibuicoes;
        double pontosfin = pontos - 105;

        if(pontos > 105) 
        {
            Console.WriteLine($"Já estara apto a se aposentar, pontos:{pontos} ");
            
        }
        else if(pontos < 105)
        {
            Console.WriteLine($"Não pode realizar a aposentadoria, pontos : {pontos}");
            
        }
        return pontos;
    }

    public double Mulheres(int idade, double contibuicoes)
    {
        double pontos = idade + contibuicoes;
        double pontosfin = pontos - 95;

        if (pontos > 95)
        {
            Console.WriteLine($"Já estara apto a se aposentar, pontos:{pontos} ");

        }
        else if (pontos < 105)
        {
            Console.WriteLine($"Não pode realizar a aposentadoria, pontos : {pontos}");

        }
        return pontos;
    }

}

