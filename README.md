# AnaLoja
Projeto loja virtual
Diante de toda dificuldade encontrada, consegui fazer o desafio.
Criado para atender o desafio lançado contendo CRUD com a Classe de Produtos.

Tecnologias utilizadas:
Visual Studio Community 2017
.Net Framework 4.6.1
Entity Framework 6.2.0
Bootstrap 4.1.3

Ao realizar o clone do projeto, atentar alguns detalhes que precisarão ser alterados.

* Criação do banco foi realizada em localDB, então ao ser gerado o arquivo MDF, trocar o path da connectionString conforme é exibida em sua maquina
  <connectionStrings>
    <add name="loja_desenv" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ana\source\repos\AnaLoja\AnaLoja\App_Data\AnaLoja.mdf;Integrated Security=True;" providerName="System.Data.SqlClient" />
  </connectionStrings>
  
 * Instalar o entity framework usando o NuGet. Para isto abra o gerenciador do NuGet em Tools/Library Package Manager/Packager Manager Console e digite:
  Install-Package EntityFramework
  
  Após isso pode dar Build no proeto para executá-lo.
