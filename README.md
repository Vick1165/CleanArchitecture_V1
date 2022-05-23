# CleanArchitecture_V1
Clean Architecture Sample Project with basic setup and unit tests (Entity Framework, Nlog, Mapper , Global Expection Handling, Moq, Nunit)


Clean Architecture is a software architecture intended to keep the code under control without all tidiness that spooks anyone from touching a code after the release. The main concept of Clean Architecture is the application code/logic which is very unlikely to change, has to be written without any direct dependencies. So it means that if I change my framework, database, or UI, the core of the system(Business Rules/ Domain) should not be changed. It means external dependencies are completely replaceable.

Overview

In Clean architecture, the Domain and Application layers remain at the center of the design which is known as the Core of the system.

