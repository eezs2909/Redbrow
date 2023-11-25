# Redbrow
1.-Descargar e Instalar Docker Desktop 
	https://www.docker.com/products/docker-desktop/

2.-Desde Docker Desktop Instalar la Extensión NGINX

3.-Abrir una ventana de ejecución Con WIN + R y escribir powershell

4.-Copiar y pegar el Comando en la Consola de PowerShell para bajar la imagen del SQL SERVER 
	docker pull mcr.microsoft.com/mssql/server

5.-Copiar y pegar el Comando en la Consola de PowerShell
	docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -e "MSSQL_PID=Evaluation" -p 1433:1433  --name sqlpreview --hostname sqlpreview -d mcr.microsoft.com/mssql/server:2022-preview-ubuntu-22.04

6.-Desde el Docker Desktop asegurarse que este corriendo el Contenedor sqlpreview.

7.- Abrir La Solución Test_redbrow.sln

8.-Desde Package Manager Console ejecutar los comandos 
	Add-Migration 1
	update-database
