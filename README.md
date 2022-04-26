
# Azure AD login from VB.NET Winforms application

This super simple demo show how to login to Azure AD from a VB.NET Winforms application. Once logged in some user information will be displayed.

## Setup
- [Register a public Azure AD application](https://docs.microsoft.com/en-us/azure/active-directory/develop/scenario-desktop-app-registration)
- Update `App.config` file with the registered application client/app Id 
```xml
  <appSettings>
    <add key="clientId" value=""/>
  </appSettings>
```

## Run
From Visual Studio:

Press `CTRL+F5`

## Use
Click the login button


## Inspiration:
https://docs.microsoft.com/en-us/answers/questions/797067/index.html


## Copyright
Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT License (the "License")