# DaLance

<h1> Sobre o projeto </h1>

<p> O projeto foi desenvolvido com as seguintes tecnologias: </p><br/>
<ul>
  <li>ASP.NET CORE 5</li>
  <li>EntityFramework 6 com Npgsql</li>
  <li>Angular 1</li>
  <li>PostgreSQL</li>
  <li>MVC</li>
<ul/>
<hr/><br/>
  
 <p> Foi utilizado o padrão de camadas com a implementação das services para realizar a regra de negócio do sistema,
  repositories para acesso ao banco de dados.</p>
  <p> Implementando as interfaces de cada uma das classes das camadas descritas para padronizar e manter a escalabilidade do sistema, além de 
  proteger o acesso direto as mesmas. </p>
  
  <hr/> <br/>
  
  <p> Existe um backup dos dados cadastrados para teste no arquivo DaLance.backup. Para informações de como fazer o restore do backup acesse:
 https://blog.tecnospeed.com.br/backup-e-restore-postgresql/ </p>
 <hr/>
 <p> Para gerar migrations e atualizar o banco de dados através do entityFramework utilize-se dos comandos abaixo na pasta raiz do projeto(powershell):</p>
 <p>
 1- dotnet ef migrations add 'Init_Migrations' --project .\DaLance.Entity\DaLance.Entity.csproj --startup-project .\DaLance\DaLance.csproj<br/>
 2- dotnet ef database update --project .\DaLance.Entity\DaLance.Entity.csproj --startup-project .\DaLance\DaLance.csproj
</p>
  
