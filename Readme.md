# ASP.NET Core WebApi Sample

In this repository I want to give a plain starting point at how to build a WebAPI with ASP.NET Core 1.0.

This repository contains a controller which is dealing with houses. You can GET/POST/PUT and DELETE them.

Hope this helps.

See the examples here: 

## GET all users

``` http://localhost:3000/api/user ```

## GET single house

``` http://localhost:3000/api/user/1 ```


## POST a user

``` http://localhost:3000/api/house ```

````javascript
  {
    Name = "Pedro",
    LastName = "Barros",
    Email = "pedroaugust8@live.com",
    Password = "250494",
    emailValidated = false,
    Birthday = "2001-10-26T19:32:52+00:00",  
    City = "Araraquara",
    Rg = "4040404-4",
    Cpf = "132132132"
  }
```


## PUT a user

``` http://localhost:3000/api/user/5 ```

````javascript
{
    Id = 1,
    Name = "Pedro",
    LastName = "Barros",
    Email = "pedroaugust8@live.com",
    Password = "250494",
    emailValidated = false,
    Birthday = "2001-10-26T19:32:52+00:00",  
    City = "Araraquara",
    Rg = "4040404-4",
    Cpf = "132132132"
}
```

## DELETE a user

``` http://localhost:3000/api/user ```


