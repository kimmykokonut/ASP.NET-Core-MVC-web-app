## Template for ASP.NET Core MVC web application using EFCore and MySQL Database

### Setup
* Make sure parent directory is ProjectName.Solution
* Change file names as necessary
* commit .gitignore first!

----------------
# Title

_by Kim Robinson_

## Description

###  This app will allow a user to:
    - DO THINGS

### Technologies Used

* C#
* ASP.Net Core Mvc
* Entity Framework Core
* MySql database
* MySql Workbench
* Git
* CSS
* Bootstrap
* HTML Helper methods
* MVC Razor
* ViewBag
* MSTest
* TDD (Test Driven Development)
* RGR Workflow (Red Green Refactor)
* NuGet package with dotnet CLI

![SQL Design]()

## Setup/Installation Requirements

_Currently not viewable on gh-pages. Please follow steps below to set up locally_

1. Navigate to [my github repository](https://github.com/kimmykokonut/TBD.Solution) for this project 

2. Click the `Fork` button and  you will be taken to a new page where you can give your repository a new name and description. Choose "create fork".

3. Click the `Code` button and copy the url for HTTPS.

4. On your local computer, create a working directory for my files and name appropriately.

5. On your terminal, type `$ git clone 'url'` (using the url from step 3.)

6. Once you have this on your local directory, if you ever want to push it to GitHub, you need to do these steps first so Git knows to ignore the desired directories and files:
`$ git init` to initialize Git (if cloning, this step already automatically happened)
`$ touch .gitignore` adds .gitignore file in the root directory. 

7. On your terminal, type `$ code .` to open in VS Code.  If you do not have VS Code Editor, you may download [here](https://code.visualstudio.com/)

8. In the .gitignore file, add 
    ```
    bin
    obj
    appsettings.json
    ```
    (SAVE this file if you do not have Auto-Save set up in VSCode).
    In the Terminal:
    ```
    $ git add .gitignore
    $ git commit -m 'add .gitignore'
    $ git push origin main
    ```
(Now these three items will not be seen or pushed to your GitHub remote repository.)
#### You must add and commit this .gitignore BEFORE creating obj, bin or appsetting.json file!

_You can now see all my files, but FIRST it is time for you to set up your database and protect the database connection string with appsettings.json_
------------------------------------------------
## Install and configure MySQL database (MacOS)
_If you already have MySQL installed, you can skip this step_
_If you have Windows 10 or 11, I have the setup info below_

1. [Download](https://dev.mysql.com/downloads/mysql/) the MySQL Community Server .dmg file.  You do not need to log in or sign up, there is a link to just download.  Choose the appropriate operating system that you use.
_You will need the 8.0 version for this to work (current latest version is 8.3)_

2. Follow along with the _Installer_ until you reach _Configuration_ page.
Set the following options:
* use legacy password encryption
* set your password
* click finish.

### Configure your shell's environmental variable.
in your bash command line:
<br/>`$ echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile`
<br/>in zsh:
<br />`$ echo 'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.zshrc`
* Restart your shell (GitBash/Terminal) to apply changes
* Verify MySQL is installed (entering your personal username/password):
<br />`$ mysql -u[YOUR-USERNAME] -p[YOUR-PASSWORD]`
* If you see an intro message and the command prompts looks like:
`mysql> ` you are good.
* Exit anytime by typing `exit`

## MySQL Workbench
1. [Download](https://dev.mysql.com/downloads/workbench/) the MySQL Workbench `.dmg` file.  
_Make sure it is the 8.0 version_ 
2. Install MySQL Workbench to Applications folder
3. Open MySQL Workbench from within the Applications folder
4. Select `Local instance 3306` server. (enter the password you set)
5. Navigate past the Windows stuff to follow directions to import my .sql file....
-----------------------------------------------
## (Windows 10 and 11) Install and configure MySQL database 
1. [Download](https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi) MySQL Web Installer (installs both Community Server and Workbench)
2. Install programs. 
* `yes` if prompted to update
* accept license terms
* choose custom setup type
* When prompted to Select Products and Features, choose the following:

    - Check the box that says "Enable the Select Features page to customize product features".
    MySQL Server 8.0.19 or the newest listed version. This will be under "MySQL Servers > MySQL Server > MySQL Server 8.0".
    MySQL Workbench 8.0.19 or the newest listed version. This will be under "Applications > MySQL Workbench > MySQL Workbench 8.0".

    - Select "Next", then "Execute". Wait for download and installation. (This can take a few minutes.)
    - Advance through Configuration as follows:

    * High Availability set to "Standalone".
    "Defaults are OK" under Type and Networking.
    Authentication Method set to Use Legacy Authentication Method.
    * Set password. 
    * Defaults are OK under Windows Service. Make sure that checkboxes are checked for the options "Configure MySQL Server as a Windows Service" and "Start the MySQL Server at System Startup". Under Run Windows Service as..., the "Standard System Account" should be selected.

    - Complete Installation process.
3. Configure System Environment Variables for "Path Variable" so `mysql` command can be recognized in any shell
    - Open the Control Panel: 
        - Select "System and Security", then select "System".
        - Select the option "Change Settings" within the section titled "Computer name, domain, and workgroup settings", and a pop-up window for "System Properties" will display. 

    - Within the "System Properties" pop-up window:
        - Select the "Advanced" tab
        - Then select the "Environment Variables..." button (red circle in image below); this will open a new window called "Environment Variables".

    - Within the "Environment Variables" window, find the section called "System variables" which will have a table listing variable names and their values. In the table, find and double click "Path" under the "variable" column (red square in image below); this will open a new window called "Edit environment variable", listing all environment variables for "Path". 

    - From this window, click "New" (green circle) and add the exact location of your MySQL installation (green square), and click OK (orange circle) to save your changes. Exit out of all of the windows.
    _This location is likely C:\Program Files\MySQL\MySQL Server 8.0\bin, but may differ depending on your specific installation._
4. Confirm both programs are working
    - open Windows PowerShell and type: <br />`$ mysql -u[YOUR-USERNAME] -p[YOUR-PASSWORD]
    (if the command prompt looks like `mysql>`, you are good)
    (you can exit anytime by typing `exit`)
5. Open MySQL Workbench and select `Local instance 3306`, enter your password and take a breath, you're almost there.
----------------------------------------------------
## Import my .sql file to MySQL Workbench
1. Ensure the MySQL server is running by opening Terminal/GitBase(Windows PowerShell) and enter command: `mysql -u[YOUR-USERNAME] -p[YOUR-PASSWORD]`
The command prompt looks like `mysql>`
2. Open MySQL Workbench, double click the instance, enter your password.  The MySQL instance should now be open.
3. Download the kim_robinson.sql file from this project onto your local computer.  The file is located at `HairSalonSolution.kim_robinson.sql`
4. In the Navigator > Administration window, select `Data Import/Restore`
5. In Import Options select `Import from Self-Contained File`
6. Navigate to the file you just downloaded.
7. Under `Default Schema to be Imported To`, select the `New` button.
        * Name your database as you see fit.
        * Click Ok.
8. Navigate to the tab called `Import Progress` and click `Start Import` at the bottom right corner of the window.
9. Reopen the `Navigator > Schemas` tab. Right click and select `Refresh All`. Our database will appear!
-----------------------------------------------
## Set up appsettings.json to include database connection string

* Create a new file named `appsettings.json` and place in the production directory of the project 
`PROJECTNAME.Solution/PROJECTNAME/appsettings.json`

* Add this code to the appsettings.json file, replacing the following values with your own:
    ```
    [YOUR-USERNAME] with your username
    [YOUR-PASSWORD] with your password
    [YOUR-DB-NAME] with the name of your database
    ```
PROJECTNAME.Solution/PROJECTNAME/appsettings.json
```    
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME];pwd=[YOUR-PASSWORD];"
    }
}
```

## ...Back to VSCode's Terminal...
1. While in the terminal, navigate to the project's production directory called "HairSalon" and type `$ dotnet build` to compile the application's code (this creates the bin folder).  Type `$ dotnet restore` to create the obj folder.

### Testing 
I have not needed to do any business logic testing using EFCore, but have left the directory intact if you would like to add more functionality and create your own tests.
- To use MSTest, you need to use the NuGet package manager to install the packages in the .csproj file.  Navigate to the HairSalon.Tests directory in the terminal and run the command `$ dotnet build`
- To run tests using MSTest, navigate to the HairSalon.Tests directory in your terminal and type `$ dotnet test`

### Compile/Execute Local Server
- (Terminal) In the working directory, type `$ dotnet run` to compile and exectute the server.  It will be available at [localhost5001](https://localhost:5001/) and [localhost5000](https://localhost:5000/)

_Optionally you can use a file watcher so you don't have to restart the server every time the code changes. Run this command `$ dotnet watch run` to make the server automatically update.  <br />If you need to restart the server, you can type `ctrl` + `r`._

- Enjoy!  You can close the development server at anytime by entering `ctrl` + `c` in the terminal.

## Known Bugs
* None known at this time

## License
MIT License. See license.md for further information
