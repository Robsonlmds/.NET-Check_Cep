<div align="center">
  <a href="https://git.io/typing-svg">
    <img src="https://readme-typing-svg.demolab.com?font=Silkscreen&size=20&duration=1500&pause=1000&center=true&vCenter=true&multiline=true&repeat=false&random=false&width=700&height=110&lines=CheckCep" 
    alt="Typing SVG" />
  </a>
</div>

### Descrição
O CheckCep é uma aplicação ASP.NET Core MVC que permite aos usuários consultar o endereço completo de um CEP utilizando a API ViaCEP. Além de exibir as informações do endereço, a aplicação possibilita copiar o endereço para a área de transferência ou enviá-lo diretamente para um email fornecido pelo usuário.

### Funcionalidades
- Consulta de endereço pelo CEP (usando a API ViaCEP).
- Exibição das informações detalhadas do endereço, como CEP, rua, cidade, estado, e complemento.
- Envio das informações de endereço para o email do usuário.
- Possibilidade de copiar o endereço para a área de transferência com um botão interativo.

### Tecnologias Utilizadas
- ASP.NET Core MVC
- C#
- API ViaCEP: Serviço público que permite consulta de CEPs e dados de endereço no Brasil.
- Bootstrap 5: Framework para estilização responsiva e componentes como modais e botões.
- JavaScript: Para interatividade na cópia de endereços e controle de modais.
- Newtonsoft.Json: Biblioteca para serialização e desserialização de objetos JSON.

### Estrutura dos Arquivos

#### AddressController.cs
Este controlador gerencia as requisições de busca de endereço e manipulação do CEP. A busca é feita através de uma requisição HTTP para a API ViaCEP, e as informações são desserializadas em um objeto do tipo `Address` e enviadas para a view.

#### EmailController.cs
Este controlador é responsável por capturar o email fornecido pelo usuário e simular o envio do endereço.

#### HomeSite.cshtml
Arquivo da view principal, onde o usuário insere o CEP, visualiza o endereço e interage com os botões para enviar o endereço por email ou copiá-lo.

### Como Usar
1. Na página inicial, insira um CEP válido no campo "CEP" e clique em "Check".
2. Se o CEP for válido, as informações do endereço aparecerão.
3. Você pode copiar o endereço para a área de transferência ou clicar no botão para enviar o endereço para o seu email.

### Exemplo de Resposta
Quando um CEP válido é inserido, o sistema exibe:

- **CEP:** 01001-000
- **Estado:** SP
- **Cidade:** São Paulo
- **Rua:** Praça da Sé
- **Complemento:** Não tem complemento (ou outro valor, se aplicável)

<h1 align="center">
<img src="https://readme-typing-svg.herokuapp.com/?font=Silkscreen&size=35&center=true&vCenter=true&width=700&height=70&duration=5000&lines=Obrigado+pela+atenção!;" />
</h1>
