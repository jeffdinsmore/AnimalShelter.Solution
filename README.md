# _Animal Shelter API_

#### _Animal Shelter API allows a user to add, edit, delete and get info on animals in the shelter, 10/20/2020_

#### By _Jeff Dinsmore_

## Description

_This Animal Shelter API has an object list of animals and some info the animals at the shelter. The info includes: name, species (cat or dog), breed, age in years and months and gender. A user can get this info as well as create new, delete and edit database info._

## Setup/Installation Requirements

* _Clone this repository._
* _Open repository in your preferred code builder program. (This was built in VS Code)_
* _Check the .csproj file to ensure the proper framework under the "PropertyGroup" and "TargetFramework". I am using netcoreapp2.2. Your version may be newer_
* _If the framework does not match above, update the version of your netcoreapp by changing the numbers. For example if you are using netcoreapp 3.1, change netcoreapp2.2 to netcoreapp3.1_
* _Verify that the database password is set correctly in the appsettings.json file under DefaulConnection. The password (pwd) is currectly set to epicodus. Change to your database password_
* _In the terminal, cd into the AnimalShelter folder_
* _Type in the terminal "dotnet restore" and press enter_
* _Type "dotnet build" in the terminal to verify there are no errors_
* _Type in the terminal "dotnet ef database update"_
* _To run the program type "dotnet run" in the terminal_
* _The program should now be running_
* _Go to http://localhost:5000/swagger/index.html to see documentation on the API and to test the API_

## Known Bugs

_No known bugs at the this time._

## Support and contact details

_Please check the .csproj file to ensure the proper framework you are running and change if necessary as described in the Setup section_

_Please check the appsettings.json file to ensure the proper password is set for you database as described above_

_Any known issues, please reach out to Jeff Dinsmore by email at hello@jeffdinsmore.com._

## Technologies Used

* _C#_
* _MySQL_
* _VS Code_
* _LINQ_
* _Swashbuckle ASP.NET Core_
* _Swagger_
* _Entity Framework Core_


## License

Copyright (c) 2020, **_Jeff Dinsmore_**

This software is licensed under the MIT license.