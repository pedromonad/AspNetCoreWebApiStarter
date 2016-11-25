# ASP.NET Core Web-Api Starter

Starter to build a WebAPI with ASP.NET Core 1.0.

This repository contains a controller which is dealing with houses. You can GET/POST/PUT and DELETE them.

See the examples here: 

## GET all users

``` http://localhost:29435/api/user ```

## GET single house

``` http://localhost:29435/api/user/1 ```


## POST a user

``` http://localhost:29435/api/house ```

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

``` http://localhost:29435/api/user/1 ```

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

``` http://localhost:29435/api/user ```


