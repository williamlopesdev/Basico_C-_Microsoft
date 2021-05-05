//Os desafios de código em todos esses módulos reforçarão o que você aprendeu e ajudarão você a ter uma certa confiança antes de continuar. Neste desafio, você imprimirá instruções para o usuário final para que ele saiba onde seu aplicativo gerará arquivos de dados. Na verdade, não vamos criar nenhum arquivo. Estamos interessados apenas em exibir instruções formatadas na janela do console. Você usará o que aprendeu sobre sequências de escape de caractere, cadeias de caracteres textuais, Unicode e interpolação de cadeias para fornecer instruções em inglês e russo. 

string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");