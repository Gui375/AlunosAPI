// 1) Front end 
//O front-end é a parte da aplicação que os usuários interagem diretamente. Ele se concentra em apresentar informações de maneira visualmente atraente e interativa.
//O objetivo principal do front-end é fornecer uma experiência amigável e intuitiva para os usuários. Isso envolve a criação de interfaces de usuário (UI) 
//
// - HTML (HyperText Markup Language): Utilizado para estruturar e criar elementos de uma página web.
// - CSS(Cascading Style Sheets): Responsável pela aparência visual da página, incluindo layout, cores, fontes e outros estilos.]



// Back-End:
//O back-end é a parte da aplicação que lida com a lógica de negócios, o processamento de dados e a comunicação com o servidor.
//É responsável por armazenar, processar e recuperar informações, além de gerenciar as regras e a lógica que governam a aplicação


//Servidores: Software que recebe solicitações dos clientes (front-end) e fornece respostas apropriadas.
//Bancos de Dados: Sistemas de armazenamento que permitem salvar e recuperar dados de maneira eficiente.


//2) A) Model : Representa os dados e a lógica de negócios da aplicação.
//      Controller : Faz a mediação entre o modelo e a visão.
//      Ele recebe as solicitações da interface do usuário e decide como os dados devem ser recuperados
//      , processados e exibidos.

// Fazemos a ligação de herança para herdar todo o protocolo HTTP

//B)Pode-se chamar um método GET no navegador facilmente porque, por padrão, quando você insere uma URL na barra de endereços do navegador e pressiona Enter
//, o navegador envia uma requisição GET para a URL especificada.

//No entanto, chamar um método POST no navegador não é tão simples.
//Para fazer uma requisição POST a partir do navegador, você geralmente precisa de um formulário HTML que envie os dados por meio desse método.


// C) O Swagger documenta e organiza a API para facilitar as requisições na mesma 


// 3) A) Post
//    B) Delet
//    C) Get
//    D) Get
//    E) Put 
//    F) Post


//4) Ok() ou 200  quando a requisição é bem sucedida
//   BadRequest() 400 é a maneira educada do servidor dizer: "Ei, eu não entendi o que você quis dizer"
//   NotFound() 404 é a maneira do servidor dizer: "Desculpe, mas o que você está procurando não está aqui.

//5)
//O "HTTP" é a maneira como o seu navegador e os servidores da web conversam quando você visita um site. 
//Aí entra o "S" no HTTPS, que significa "Secure" (seguro). 
//É como se, antes de enviar sua carta, você a colocasse em um envelope especial com um cadeado. 
//O HTTPS é como um cadeado digital que protege suas informações enquanto elas viajam pela internet.
//Já as duas barrinhas servem para referenciar o caminho que ele irá fazer

// minhaapi.com.br é o endereço URL da pagina ou da API
// /api / vendas é o caminho que fará a requisição para a API