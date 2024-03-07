using System;
class DesafioTecnico {
  static void Main() {
    Console.WriteLine("Escreva a sua senha para acessar a rede social TaticsMedia (pode escrever qualquer coisa q da certo | senha da adm = Ramza)");
    string senha = Console.ReadLine();
    int seguidores = 1, x = 0;
    string[] fotos = new string[10]{"foto na praia", "foto em Sao Paulo", "", "", "", "", "", "", "",""};
    bool adm = false;
    if (senha == "Ramza"){
        adm = true;
    }
    
    for(bool i = true; i != false; i = true){
        Console.WriteLine("Escolha oque voce quer fazer no perfil do Ramza no TaticsMedia");
        Console.WriteLine("1 - Ver a quantidade de seguidores");
        Console.WriteLine("2 - Ver quantas pessoas ele segue");
        Console.WriteLine("3 - Ver as fotos que ele postou");
        Console.WriteLine("4 - Seguir");
        if (adm == true){
            Console.WriteLine("");
            Console.WriteLine("Apenas o dono da conta");
            Console.WriteLine("5 - adicionar uma foto");
            Console.WriteLine("6 - remover uma foto");
            Console.WriteLine("7 - ver quantos seguidores ganhou");
        }
        int operacao = int.Parse(Console.ReadLine());
        switch(operacao){
            case 1 :
                Console.WriteLine($"O Usuario Ramza tem {seguidores} seguidores");
            break;
            case 2 :
                Console.WriteLine("O Usuario Ramza segue 7 pessoa");
            break;
            case 3 :
                for (x = 0; x < 10; x++){
                    Console.WriteLine($"A foto {x} = {fotos[x]}");
                }
            break;
            case 4 :
                Console.WriteLine("Voce começou a seguir o Ramza");
                seguidores++;
            break;
            case 5 :
                Console.WriteLine("Escolha um slot para botar a sua nova foto (1 a 10)");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a descrição da foto");
                fotos[x] = Console.ReadLine();
            break;
            case 6 :
                Console.WriteLine("Escolha um slot para botar a sua nova foto (0 a 10)");
                x = int.Parse(Console.ReadLine());
                fotos[x] = "";
            break;
            case 7 :
                float seguinovos = (new Random()).Next();
                double porcentagem = (seguinovos/ seguidores)*100;
                Console.WriteLine($"Voce Ganhou {seguinovos} seguidores novos, Isso é {porcentagem}% mais seguidores");
                seguidores += seguinovos;
            break;
        }
        Console.WriteLine("");
        Console.WriteLine("Aperte Enter para continuar");
        Console.ReadLine();
        
    }
  }
}