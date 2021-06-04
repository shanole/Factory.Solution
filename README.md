# Dr. Sillystringz's Factory

#### Epicodus Code Review: Many-to-Many

#### By Shannon Lee

#### _Table of Contents_

1. [Description](#description)
2. [Technologies Used](#technologies)
3. [Setup/Installation Requirements](#setup)
4. [Schema](#schema)
5. [Known Bugs](#bugs)
6. [License](#license)
7. [Contact Information](#contact)


## Description <a id="description"></a>

This is a web application made using C#, .NET5, MySQL, and Entity to track a hypothetical factory's engineers and machines. This project demonstrates understanding of Database basics and many-to-many relationships.

## Technologies Used <a id="technologies"></a>

* C#
* .NET 5
* MSBuild
* MSTest
* Entity
* MySQL
* git


## Setup/Installation Requirements <a id="setup"></a>

Setup requirements
* Make sure that .NET Software Development Kit 5 and MySQL have been installed to your local machine.

Installation
* Clone this repository to your machine `$ git clone https://github.com/shanole/Factory.Solution`
* In the terminal, navigate to the project directory `$ cd Factory.Solution/Factory`
* Create `appsettings.json` file in `/Factory` directory with the following code:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=shannon_lee;uid=root;pwd=<YOUR PASSWORD HERE>;"
  }
}
```
* Compile code by running command `$ dotnet build`
* Run program with command `$ dotnet run` to open webpage on your preferred browser at `http://localhost:5000`

## Schema <a id="schema"></a>

![schema design]()

## Known Bugs <a id="bugs"></a>
* None known at this time. If you find one, please don't hesitate to contact me about it!

## License <a id="license"></a>
*[MIT](https://choosealicense.com/licenses/mit/)*

Copyright (c) 2021 Shannon Lee

## Contact Information <a id="contact"></a>
**_Shannon Lee [mailto](mailto:shannonleehj@gmail.com)_**