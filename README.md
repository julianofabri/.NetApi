# .NetApi

## What you need
* Install Docker Desktop (For Windows Users) - [Download Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
* Install Visual Studio - [Download Visual Studio](https://visualstudio.microsoft.com/)
* Install Dbeaver (For Database Connection and Management) - [Download Dbeaver](https://dbeaver.io/download/)
---
## After cloning project
* With docker running, open cmd in the root folder of the project and run
>**docker-compose build**
* This will build the container for you, if no errors are shown, run the next command to bring up your container
>**docker-compose up -d**
* If everything is fine with your project it will start the database container called **api-db**, the database configured on this project uses a PostgreSQL.
(*you can connect to database using Dbeaver and selecting PostgreSQL as Database type*)
---
## After running Docker and Database
* Now you good to go and explore this project example of an API builded in .Net 6
* Open the Solution (.sln) in Visual Studio and have fun!
