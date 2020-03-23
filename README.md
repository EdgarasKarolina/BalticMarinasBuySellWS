# Baltic Marinas Buying and Selling Web Service

Web service build on ASP.NET Core platform which handles all of the comercial activity on the application. The purpose of this 
API is to serve Baltic Marinas booking web application as a module which handles all the items that are being sold on the
application by the users. 


This functionality is handled by the Buying and Selling API which stores the required data in a MySQL database. 

## Database

The API is connected to a database which has one `sold_items` table:

| Column	| Data Type     |         |
| ------------- |:-------------:| -------:|
| SoldItemId    | int AI PK     | NOT NULL|
| Title         | varchar(100)  | NOT NULL|
| Category      | varchar(100)  | NOT NULL|
| Price         | decimal(10,2) |         |
| MadeYear      | year          |         |
| Description   | varchar(1200) | NOT NULL|
| UserId        | int FK        |         |


## Technologies used

+ ASP.NET Core
+ C#
+ MySQL relational database management system (DBMS)

## Getting Started

In order to run the project a small amount of prerequisites and additional steps have to be fulfilled.

### Prerequisites

+ Microsoft Visual Studio IDE
+ Database Management System

### Running

+ Clone the project from GitHub repository
+ Open `BalticMarinasBuySellWS.sln` file using Visual Studio IDE
+ Start application by clicking `Play` button
