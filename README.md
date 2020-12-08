## QuizApp - Quiz platform
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)

## General info
The Quiz App is an application where you can add quizzes and solve them together.

## Technologies
Project is created with:
* Angular version: 10
* .NET Core Version: 3.1
 
## Setup
How to run this project?

1. Front-end

```
$ cd QuizAppClient
$ npm install
$ ng serve
```

```
$ cd QuizAppGameClient
$ npm install
$ ng serve
```

2. Back-end

1 method

```
$ cd src/QuizAppMainApi
$ dotnet ef database update
$ dotnet run

or 2 method

1. Open Visual Studio 2020
2. Tools -> NuGet Package Manager -> Package Manager Console
3. In the console you type 'update-database'
4. Click F10
```

```
$ cd src/QuizAppGameApi
$ dotnet ef database update
$ dotnet run
```
