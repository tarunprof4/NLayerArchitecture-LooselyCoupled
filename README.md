# NLayerArchitecture With Loosely Coupled Inversion of Control
NLayerArchitecture With Loosely Coupled Inversion of Control

Endpoint Url - http://localhost:35938/api/Customer
![2](https://user-images.githubusercontent.com/116249623/212545546-ca5ded9d-6d14-4df7-b2d6-b7168bd6050b.jpg)


Tightly Coupled Inversion of Control
https://github.com/tarunprof4/NLayerArchitecture-TightlyCoupled


The difference between tightly and loosely coupled is explained below via a use case.
Use Case- We need to switch the database from Mssql to MongoDB for both the repos. 

Difference of approach in loosely coupled repo is:
1. We can switch to new MongoDB by just modifying single file Startup.cs as marked in red below and adding reference of new Mongo project. However, in tightly coupled repository we will have to additionally modify the changes in Application class library as well.
![3](https://user-images.githubusercontent.com/116249623/212546786-e5543645-e7c4-4715-b5f2-d3d28224e971.JPG)

2. In loosely coupled repository the contracts/interfaces are shifted to core library project which enables core project to define the interface rather than Repository layer. This is very important as the Core should not depend on repository as to how it persists the data. Core knows what but not how the data needs to be persisted.

