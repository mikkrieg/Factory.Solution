# _Dr. Sillystringz's Factory_

#### _A program that allows a manager to manage engineers and machines_

#### By _**Michael Kriegel**_

##### This project is a practice project

## Technologies Used

* _HTML/CSS_
* _Bootstrap_
* _MySQL_
* _C#_
* _Entity Framework_
* _ASP.NET Core_
* _.NET 5.0_
* _Razor_

## Description

_This project is an MVC program that uses entity migrations. It is for a factory that has engineers and machines. A many to many relationship is established with entity to allow a manager to see what machines are being worked on by what engineers. Each list entry on the home page is a clickable link that will take the user to a details page. Depending on if they selected a machine or an engineer they will see the properties of those respesctive options as well as what engineers are working on a machine and what machines an engineer is working on. Once a machine is no longer being worked on or an engineer is no longer employed, the can be deleted completley. Relationships between engineers and machines can be removed as well once they are finished._

## Setup/Installation Requirements

### Local Machine
* _Clone this repository to your machine_
* _Navigate to the Factory directory (project directory)_
* _In the terminal, within this directory, enter the terminal commands "dotnet restore" and "dotnet build"_
* _Create an appsettings.json file within the Factory directory_
* _Inside your appsettings.json, create a connection to the database you will be using_
  * _It will look similar to this: { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=(database_name_here);uid=(user_name_here));pwd=(your_password_here);" Leave out all parenthesis, they are for example purposes only_
* _Then run the command "dotnet ef migrations add Initial" in the terminal from this directory_
* _Once the build succeeds, enter the command "dotnet ef database update" in the terminal_
* _To run the program, navigate to the Factory directory and enter the command "dotnet run" in the terminal_
  * _To run the program with a watcher, use the command "dotnet watch run" in the terminal_
* _Type the url localhost:5000 (or whatever port you have configured) in a browser to view the project_


## Known Bugs

* _Styling is not responsive for large or small screens_
* _Still figuring out how to style select box in machine and engineer creation page_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright(c) 2021 Michael Kriegel

## Contact Information

Michael Kriegel: mikkrieg@gmail.com