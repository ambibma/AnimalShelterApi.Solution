
# Animal Shelter Api

---
#### By Ambi Hidalgo
###### ambio.pk@gmail.com
---
Animal Shelter API is a student work showcasing the building of an API in in the .Net framework. This API allows the user to make calls to the AnimalShelter database in order to see all the animals that are available.
## Technologies Used
* C#
* Swagger
* Swashbuckle
* EFC
* MySql
* .NET SDK
* ASPNET Core MVC


## Setup/Installation Requirements
Note: In order for this application to work you will need to create called appsettings.json as well as an appsettings.Development.json file in the program directory(AnimalShelterApi).
* Clone this repository (https://github.com/ambibma/AnimalShelterApi.Solution)
* using terminal to navigate to the program file (AnimalShelter.Solution)
     ```bash
    $ cd AnimalShelterApi
    ```
* Once in the Program directory...
  ```bash
    $ dotnet restore
    ```
* Create appsettings.json
    ```bash
    $ touch appseetings.json
    ```
* Paste the following code and enter your mysql username and password
    ```JSON
    {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=ambi_hidalgo_animal_shelter;uid=[YOUR USERNAME];pwd=[YOUR PASSWORD];"
     }
    }
    ```
* Create appsettings.Development.json
    ```bash
    $ touch appsettings.Development.json
    ```
* Then add the following code...This will ensure that you can make api calls at localhost:5000 port
    ```json
    {
  "Logging": 
  {
    "LogLevel": 
    {
      "Default": "Information",
      "Microsoft": "Trace",
      "Microsoft.AspNetCore": "Information",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
    }
    ``` 
* Once that is finished you will need to update the database that stores the animals...
   ```bash
   $ dotnet ef database update
   ```
   *This will add the seed provided in the Context to populate the database with available animals!*
* Then the program is ready for a build and run!
    
    ```bash
    $ dotnet build
    ```

     ```bash
    $ dotnet watch run
    ```
* This will open the application in your web browser!
## How To Use
After the intial setup is complete. you can vist
```url
https://localhost:5001/swagger/index.html
```
This url will open up the API using swagger. You will find several buttons that are available to you.


**GET** *: This GET will retrun up to a maxium of *5* animals per page. There are *10* animals seeded into the database. In order to access them you need to add a page number, in this case to get the first 5 enter a "1." In the code, the page size will always return *5*, so enter 5. This will return the first 5 animals, to get the next 5 enter a "2" for the page number in your next get request.
To access not using swagger enter this URL
```
//https://localhost:5001/api/animals?pagenumber=1&pageSize=5
```
This is the endpoint for using pagination.
**POST**:
```
/api/Animals
```
This endpoint will create an animal and add it to your database. Click the "Try it out button" in swagger and enter the data for your animal.
*Note* : Be sure to set the 'animalId' at '11' because there are already 10 in the DB

**GET (by id)**
```
/api/Animals/{enter id number of animal here}
```
This endpoint will return a single animal with by a specific ID 

**PUT**
```
/api/Animals/{enter id number of animal here}
```

This endpoint acts as an 'Edit' for an animal currently in the database. Just enter the Id of an existent animal an alter the json data.

**DELETE**
```
/api/Animals/{enter id number of animal here}
```
This endpoint will Delete an animal from the database at a specific id number, can be dont using Swagger or Postman. Helpful for when your critter gets adopted


## Known Bugs

* None at the moment
* "*" =  **Further Exploration** Refactored GET endpoint to return animals by entering pagination parameters such as 'size' and 'page number'

send bug concerns to ambio.pk@gmail.com

## License


Copyright (c) Ambi Hidalgo 2023