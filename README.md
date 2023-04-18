# Tech Stack

- C#
- Nunit
- Selenium

# create test case project

- dotnet new nunit --name=name_folder_test

# add package dependencies selenium

- dotnet add package Selenium.Webdriver --version 4.8.2
- for list package in project could run command ```dotnet list package```
- or add with comand ```dotnet nuget --help```
- for finding package in nuget with command prompt, could be running ```dotnet tool search```
- for find https://www.nuget.org/packages/Selenium.WebDriver

# for running the test just using command 
- `dotnet test`

# result testing
![alt result](./result/result.gif)
