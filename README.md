# NLayerArchitecture With Loosely Coupled Inversion of Control in .Net C#

# Definition
In computing and systems design a loosely coupled system is one in which change in one component has minimal or no effect on other linked
component. System can be called loosely coupled by multiple ways like agnostic to operating system, coupling of classes etc.

# Endpoint Url
http://localhost:35938/api/Customer

![2](https://user-images.githubusercontent.com/116249623/212545546-ca5ded9d-6d14-4df7-b2d6-b7168bd6050b.jpg)


# Tightly Coupled Inversion of Control
https://github.com/tarunprof4/NLayerArchitecture-TightlyCoupled


The difference between tightly and loosely coupled vs tightly coupled is explained below via a use case.

# Use Case
We need to switch the database from Mssql to MongoDB for both the repos. 

# Difference of approach in loosely coupled repo is:

1. In loosely coupled repository the contracts/interfaces are shifted to core library project which enables core project to define the interface rather than Repository layer defining the same. This is very important as the Core library should not depend on repository as to how it persists the data. Core knows what data it wants to persist but the how part is left for repository layer to implement. Core should not be aware of how the data will be persisted.

    **Summary -Interfaces enables loose coupling via abstraction(calling method doesnt know how the implementation will be done when it calls another method)**

2. We can switch to new MongoDB by just modifying single file Startup.cs as marked in red below and adding reference of new Mongo project. However, in tightly coupled repository we will have to additionally modify the changes in Application class library as well. From this example this might seem like small advantage but in real scenario mid size project, there will be ton of files where the change will happen in Application class library. Also this change will slow down other people work working parallely on the same repo.
![3](https://user-images.githubusercontent.com/116249623/212546786-e5543645-e7c4-4715-b5f2-d3d28224e971.JPG)



