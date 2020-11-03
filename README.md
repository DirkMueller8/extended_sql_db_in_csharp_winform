##  Library with reservation and contracts in normalized SQL using VS2019 and WinForms
**********************************************
Software:		C#

Version:    	0.1

Date: 			Nov 3, 2020

Author:			Dirk Mueller
**********************************************
The objective of this software is to fulfill the requirements of project 23 of the Klett Fernakademie (https://www.fernakademie-klett.de/technik-it/informatik-programmierung-internet/c-software-entwickler/4). It manages a simple library by using the in-built SQL table in Visual Studio 2019, together with a read and write application in WinForms.
Compared to the repo at https://github.com/DirkMueller8/integrated_sql_db_in_csharp_winform it has the following extensions:

1. Table to capture reservations for media
2. Table to manage loan contracts
3. Normalization of databases

The code was mostly written by the instructors, the task of the student is to ensure the correctness of the input. (There ist still a problem with the saving of the form contents.)

![](https://github.com/DirkMueller8/extended_sql_db_in_csharp_winform/blob/master/ERD.png)

*Fig 1: Entity Relationship Diagramm for library application*

![](https://github.com/DirkMueller8/integrated_sql_db_in_csharp_winform/blob/master/GUI.png)

*Fig 2: GUI for library*