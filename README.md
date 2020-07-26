# StudentSIMS
Explanation:
Swagger is an application which implements basic CRUD request (GET, POST,PUT,DELETE) for the tables students and address. Moreover , api methods are created for adding new address for a student using the studentID and for updating the address.
 Firstly, a Database is created in Azure and  started coding with an API asp.net Core Web Application.Migration through the package manage console after creating the models will generate the tables in the azure database. The basic CRUD request are created by using the scaffolding. Testing done by passing values to different properties.
 
 
 
**Url:** 
https://studentsims-ashly.azurewebsites.net/api/Address

https://studentsims-ashly.azurewebsites.net/api/Address

https://studentsims-ashly.azurewebsites.net/api/Address/2

https://studentsims-ashly.azurewebsites.net/api/Address/4

https://studentsims-ashly.azurewebsites.net/api/Address/2

https://studentsims-ashly.azurewebsites.net/api/Students

https://studentsims-ashly.azurewebsites.net/api/Students

https://studentsims-ashly.azurewebsites.net/api/Students/2

https://studentsims-ashly.azurewebsites.net/api/Students/2

https://studentsims-ashly.azurewebsites.net/api/Students/3

**Database:**
![db](https://user-images.githubusercontent.com/64385395/88472060-79c6b900-cf63-11ea-9ec2-15b0ea9aec92.png)
**ScreenShots:**
Student
Get/api/Students
![Get :api:Students](https://user-images.githubusercontent.com/64385395/88472084-a5e23a00-cf63-11ea-89f3-43a617d347e1.png)

Get/students/{id}
![Get:api:students:{id}](https://user-images.githubusercontent.com/64385395/88472106-c0b4ae80-cf63-11ea-9945-efd4879a9e6c.png)

post/api/students
![post:api:students](https://user-images.githubusercontent.com/64385395/88472124-df1aaa00-cf63-11ea-8526-deabe706bd89.png)
![post:api:students-response](https://user-images.githubusercontent.com/64385395/88472132-eb066c00-cf63-11ea-9487-e4d1704d1253.png)
![Get:api:students after put:api:students:{id} changed the middle name from   ash  to  Ashly  for id=1](https://user-images.githubusercontent.com/64385395/88472154-0f624880-cf64-11ea-92b3-31e757c60b6d.png)

put/api/Students/{id}
![put:api:students:{id}](https://user-images.githubusercontent.com/64385395/88472165-26089f80-cf64-11ea-8c9a-95af6130fec3.png)

Delete/api/Students/{id}
![delete:api:students:{id}](https://user-images.githubusercontent.com/64385395/88472173-36207f00-cf64-11ea-8e4e-d15a1dbf9f1c.png)

**Address**
Get/api/Address
![get:api:address](https://user-images.githubusercontent.com/64385395/88472185-551f1100-cf64-11ea-9123-2cd10719b80f.png)

Get/api/address/{id}
![Get:api:Address:{id}](https://user-images.githubusercontent.com/64385395/88472194-636d2d00-cf64-11ea-9dbc-8f9b7691042d.png)

put/api/Address/{id}
![put:api:address:{id}](https://user-images.githubusercontent.com/64385395/88472199-77b12a00-cf64-11ea-92f8-08d8f2cb53b9.png)

Delete/api/address/{id}
![delete:api:students:{id}](https://user-images.githubusercontent.com/64385395/88472207-8dbeea80-cf64-11ea-91f2-b38906dd78f0.png)


put/api/address/{id}
![Screen Shot 2020-07-26 at 10 10 23 PM](https://user-images.githubusercontent.com/64385395/88476565-66304800-cf8d-11ea-9be1-d5baad4c7733.png)
![Screen Shot 2020-07-26 at 10 10 57 PM](https://user-images.githubusercontent.com/64385395/88476566-69c3cf00-cf8d-11ea-8b44-86d774bd7af2.png)
