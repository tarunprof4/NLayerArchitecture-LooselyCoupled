# NLayerArchitecture With Loosely Coupled Inversion of Control
NLayerArchitecture With Loosely Coupled Inversion of Control

Endpoint Url - http://localhost:35938/api/Customer
![2](https://user-images.githubusercontent.com/116249623/212545546-ca5ded9d-6d14-4df7-b2d6-b7168bd6050b.jpg)


Tightly Coupled Inversion of Control
https://github.com/tarunprof4/NLayerArchitecture-TightlyCoupled


The difference between tightly and loosely coupled is explained below via a use case.
Use Case- We need to switch the database from Mssql to MongoDB for both the repos. 

Difference of approach in loosely coupled repo is:
1. We can switch to new MongoDB by just modifying single file Startup.cs. However, in tightly coupled repository we will have to modify the changes in Application class library as well.
2. In loosely coupled repository the contract/interface is shifted in core library project

