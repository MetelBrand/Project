## Table of Contents
* Description
* [Requirements](#Requirements-Main)

## Description
### Problem Description
People take too long to sort through their stuff that they do not use every day. They put their stuff into a box and forget about it and when it comes time to either move or to make more space it takes them abnormally long to do it. I believe this is due to a nostalgic effect from not seeing those items they have every day. 

### Solution
The solution to this is an app that you can take pictures of your stuff and organize it. You will be able to place the pictures in virtual boxes which you can name. You will also be able to move the virtual boxes into location folders that correspond with its physical location.

### Key Objectives:
*	Simple 
*	Functional 
*	Fun

## Wireframe Sketches
![Login Screen](https://github.com/MetelBrand/Project/blob/main/Login%20Screen.jpg)

## Requirements 

### User Stories
* As a user, I want an app that displays my stuff.
* As a user, I want an app that can show me where my stuff is.




### Use Cases
* Given a new user, will be able to launch and start the app.
* Given a new user, will be able to create a new account.
* Given a new user, will be able to use location services.
* Given an existing user, will be able to post pictures of my things.
* Given an existing user, will be able to sort pictures by categories.
* Given an existing user, will be able to set the location of the pictures.
* Given an existing user, will be able to view the total quantity of their pictures.
* Given an existing user, will be able to search for specific items in their things.
* Given an existing user, will be able to categorize their things.
* Given an existing user, will be able to set a quantity if they have more than one item for a picture.
* Given an existing user, will be able to view total quantity of items.

### UML (User Case Diagram)

![UML](https://github.com/MetelBrand/Project/blob/main/UML.jpg)

### Requirements List

Req ID | Requirement | Test Method | Test ID
--- | --- | --- | ---
1.1 | The system shall display all the required fields to create an account.| Inspection | 1		
1.1.2	| The system shall send an email to the user to confirm that the email is valid. |	Inspection, Test	| 1
1.2	| The system shall display confirmation of the account created. | Inspection | 1
2.0 | The system shall allow the user to login.  | Test | 2
2.1	| The system shall allow the user to input their username and password. | Test	| 2
2.1.1	| The system shall verify the username and password	| Analysis	| 2
2.2	| The system shall allow the user to recover a forgotten username or password.Test	3
2.2.1	| The system shall send an email displaying the user’s username. | Inspection |	3
2.2.2	| The system shall send an email with a link to reset the user’s password. | Inspection, Test	| 3
3.0 | The system shall allow the user to post items. | Test	| 4
3.1	| The system shall allow the user to upload a picture for the item	| Test, Inspection	| 4
3.2	| The system shall allow the user to take a picture for the item.	| Test, Inspection	| 4
3.3	| The system shall allow the user to assign a location for the item. | Test, Inspection	| 4
3.3.1	| The system shall allow the user to create a new location. | Test, Inspection	| 4
3.4	| The system shall allow the user to assign a category for the item. | Test, Inspection	| 4
3.4.1	| The system shall allow the user to create a new category for the item.	| Test, Inspection	| 4
3.5	| The system shall allow the user to assign a quantity for the item.	| Test	| 4
4.0 | The system shall allow The System shall correctly the identify the user's location within 0.5 mile.	| Analysis	| 5
4.1	| The System shall provide capability to use the user's location provided by the user's browser location services. | Analysis	| 5
4.1.1	| The System shall request permission to use the user's browser location services if not already granted. | Inspection, Test	| 5
4.1.2	| Given authorization, the system shall report the client's location using the browser's location services. | Inspection	| 5
4.1.3	| The system shall display the user's location on the interface based on the reported location. | Inspection	| 5

### Testing
Test ID	| Req ID	| Test Procedure	| Current Date
--- | --- | --- | --- 
1	1, 1.1, 1.1.2, 1.2 | Create an account.	| Not tested	| TBD
2	2, 2.1, 2.1.1	| Login into your account.	| Not tested	| TBD
3	2.2, 2.2.1, 2.2.2	| Recover username and password.	| Not tested	| TBD
4	3, 3.1, 3.2, 3.3, 3.3.1, 3.4, 3.5 	| Post an item into a new category and a new location	| Not tested	| TBD
5	4, 4.1, 4.1.1, 4.1.2, 4.1.3	| Find location of the user.	| Not tested	| TBD

